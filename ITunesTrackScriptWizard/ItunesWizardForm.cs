using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITunesTrackScriptWizard
{
    public partial class formWizardITunes : Form
    {
        public formWizardITunes()
        {
            InitializeComponent();
            labelTitleScript.Text = m_itunesScript.getName();
            labelScriptDescription.Text = m_itunesScript.getDescription();
        }

        private ITunesScript m_itunesScript = new ITunesScript();
        private BackgroundWorker m_backgroundWorker;
        private object selectedPlayList;
        struct TrackInfos
        {
            public object track;
            public string[] infos;
        };
        private TrackInfos[] m_tracksInfos;
        private ListViewColumnSorter m_lvwColumnSorter;

        private Color windowColorLight = SystemColors.Window;
        private Color windowColorDark = Color.FromArgb(              SystemColors.Window.A,
                                                          (int)(0.95 * SystemColors.Window.R),
                                                          (int)(0.95 * SystemColors.Window.G),
                                                          (int)(0.95 * SystemColors.Window.B)
                                                          );
        private object[] m_tracksToProcess;

        private void pagePlayLists_ShowFromNext(object sender, EventArgs e)
        {
            listPlayLists.Items.Clear();
            foreach (var playList in m_itunesScript.getPlayLists())
            {
                var listView = new ListViewItem(m_itunesScript.getPlayListInfo(playList));
                listView.Tag = playList;
                listPlayLists.Items.Add(listView);
            }

            wizardITunes.NextEnabled = listPlayLists.SelectedItems.Count > 0;
        }

        private void pagePlayLists_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedPlayList = null;
            if (listPlayLists.SelectedItems.Count > 0)
                selectedPlayList = listPlayLists.SelectedItems[0].Tag;
            wizardITunes.NextEnabled = selectedPlayList!=null;
        }

        private void listPlayLists_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (selectedPlayList!=null)
                wizardITunes.Next();
        }


        private void pageTracks_ShowFromNext(object sender, EventArgs e)
        {
            try {
                listViewTracks.BeginUpdate();

                listViewTracks.Clear();

                foreach (var tracksColumn in m_itunesScript.getTracksInfoTypes())
                    listViewTracks.Columns.Add(tracksColumn);

                foreach (var trackInfos in m_tracksInfos)
                {
                    var item = new ListViewItem(trackInfos.infos);
                    item.Tag = trackInfos.track;
                    listViewTracks.Items.Add(item);
                }

                foreach (ColumnHeader col in listViewTracks.Columns)
                {
                    col.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                    var headerSize = col.Width;
                    col.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                    if (col.Width < headerSize) col.Width = headerSize;
                }

                setAlternateBackColour(listViewTracks);

                m_lvwColumnSorter = new ListViewColumnSorter();
                listViewTracks.ListViewItemSorter = m_lvwColumnSorter;
            }
            finally
            {
                listViewTracks.EndUpdate();
            }
        }

        private void pageListingTracks_ShowFromNext(object sender, EventArgs e)
        {
            wizardITunes.NextEnabled = false;

            progressListingTracks.Value = 0;
            progressListingTracks.Maximum = (int)m_itunesScript.getNbTracksInPlayList(selectedPlayList);
            progressListingTracks.Step = 1;

            var nbTracks = m_itunesScript.getNbTracksInPlayList(selectedPlayList);
            m_tracksInfos = new TrackInfos[nbTracks];

            m_backgroundWorker = new BackgroundWorker();
            m_backgroundWorker.WorkerReportsProgress = true;
            m_backgroundWorker.WorkerSupportsCancellation = true;

            m_backgroundWorker.DoWork += (_, args) =>
            {
                for (uint i = 0;
                     i < nbTracks;
                     ++i)
                {
                    if (m_backgroundWorker.CancellationPending)
                    {
                        args.Cancel = true;
                        return;
                    }

                    var track = m_itunesScript.getTrackInPlayList(selectedPlayList, i);
                    m_tracksInfos[i].track = track;
                    m_tracksInfos[i].infos = m_itunesScript.getTrackInfos(track);
                    m_backgroundWorker.ReportProgress((int)i);
                }
            };

            m_backgroundWorker.ProgressChanged += (_, args) =>
            {
                progressListingTracks.PerformStep();
            };

            m_backgroundWorker.RunWorkerCompleted += (_, args) =>
            {
                if (args.Cancelled) return;
                progressListingTracks.Enabled = false;
                wizardITunes.Next();
            };

            m_backgroundWorker.RunWorkerAsync();
        }

        private void wizardITunes_CloseFromCancel(object sender, CancelEventArgs e)
        {
            if (m_backgroundWorker!=null)
                m_backgroundWorker.CancelAsync();
        }

        private void listViewTracks_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == m_lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (m_lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    m_lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    m_lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                m_lvwColumnSorter.SortColumn = e.Column;
                m_lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            try {
                listViewTracks.BeginUpdate();
                listViewTracks.Sort();
                setAlternateBackColour(listViewTracks);
            }
            finally
            {
                listViewTracks.EndUpdate();
            }
        }

        private void setAlternateBackColour(ListView listView)
        {
            bool colorSwitch = true;
            foreach (ListViewItem item in listView.Items)
            {
                if (colorSwitch)
                    item.BackColor = windowColorDark;
                else
                    item.BackColor = windowColorLight;
                colorSwitch = !colorSwitch;

            }
        }

        private void pageListingTracks_CloseFromBack(object sender, Gui.Wizard.PageEventArgs e)
        {
            m_backgroundWorker.CancelAsync();
        }

        private void setSelectedTracksCheck(bool check)
        {
            foreach (ListViewItem trackItem in listViewTracks.SelectedItems)
            {
                trackItem.Checked = check;
            }
        }

        private void selectAllTracks()
        {
            foreach (ListViewItem trackItem in listViewTracks.Items)
            {
                trackItem.Selected = true;
            }
        }

        private void buttonCheckAll_Click(object sender, EventArgs e)
        {
            selectAllTracks();
            setSelectedTracksCheck(true);
        }

        private void buttonUnCheckAll_Click(object sender, EventArgs e)
        {
            selectAllTracks();
            setSelectedTracksCheck(false);
        }

        private void listViewTracks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.A | Keys.Control))
                selectAllTracks();
        }

        private void pageTracks_CloseFromBack(object sender, Gui.Wizard.PageEventArgs e)
        {
            // jump over progress bar
            e.Page = pagePlayLists;
        }

        private void pageTracks_CloseFromNext(object sender, Gui.Wizard.PageEventArgs e)
        {
            var tracksToProcess = new List<object>();
            foreach (ListViewItem trackItem in listViewTracks.Items)
            {
                if (trackItem.Checked)
                {
                    tracksToProcess.Add(trackItem.Tag);
                }
            }

            m_tracksToProcess = tracksToProcess.ToArray();
        }

        private void pageConfirmTracks_ShowFromNext(object sender, EventArgs e)
        {
            labelScriptNameConfirm.Text = m_itunesScript.getName();
            labelTracksCountConfirm.Text = String.Format("{0}", m_tracksToProcess.Length);
        }

        private void pageTrackProcessing_ShowFromNext(object sender, EventArgs e)
        {
            wizardITunes.NextEnabled = false;

            textBoxLogProcessing.Clear();

            progressTracksProcessing.Value = 0;
            progressTracksProcessing.Maximum = m_tracksToProcess.Length;
            progressTracksProcessing.Step = 1;

            m_backgroundWorker = new BackgroundWorker();
            m_backgroundWorker.WorkerReportsProgress = true;
            m_backgroundWorker.WorkerSupportsCancellation = true;

            m_backgroundWorker.DoWork += (_, args) =>
            {
                int count = 0;
                foreach ( var track in m_tracksToProcess)
                {
                    if (m_backgroundWorker.CancellationPending)
                    {
                        args.Cancel = true;
                        return;
                    }
                    var log = m_itunesScript.processTrack(track);
                    m_backgroundWorker.ReportProgress(count, log);
                    count++;
                }
            };

            m_backgroundWorker.ProgressChanged += (_, args) =>
            {
                progressTracksProcessing.PerformStep();
                var log = (string)args.UserState;
                log += "\r\n";
                textBoxLogProcessing.AppendText(log);
            };

            m_backgroundWorker.RunWorkerCompleted += (_, args) =>
            {
                if (args.Cancelled) return;
                progressTracksProcessing.Enabled = false;
                textBoxLogProcessing.AppendText("\r\nAll processing done");
                wizardITunes.NextEnabled = true;
                wizardITunes.CancelEnabled = false;
            };

            m_backgroundWorker.RunWorkerAsync();
        }
    }
}

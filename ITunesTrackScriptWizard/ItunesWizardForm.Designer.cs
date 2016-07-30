namespace ITunesTrackScriptWizard
{
    partial class formWizardITunes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formWizardITunes));
            this.wizardITunes = new Gui.Wizard.Wizard();
            this.pageTracks = new Gui.Wizard.WizardPage();
            this.panelTrackListAndButtons = new System.Windows.Forms.Panel();
            this.panelTracksButton = new System.Windows.Forms.Panel();
            this.buttonCheckAll = new System.Windows.Forms.Button();
            this.buttonUnCheckAll = new System.Windows.Forms.Button();
            this.listViewTracks = new System.Windows.Forms.ListView();
            this.headerTrackList = new Gui.Wizard.Header();
            this.pageConfirmTracks = new Gui.Wizard.WizardPage();
            this.panelConfirmTracks = new System.Windows.Forms.Panel();
            this.labelNbTracksConfirm = new System.Windows.Forms.Label();
            this.labelScriptNameConfirm = new System.Windows.Forms.Label();
            this.labelScriptConfirm = new System.Windows.Forms.Label();
            this.labelConfirmNextEngage = new System.Windows.Forms.Label();
            this.labelTracksCountConfirm = new System.Windows.Forms.Label();
            this.headerTrackConfirm = new Gui.Wizard.Header();
            this.pageTrackProcessing = new Gui.Wizard.WizardPage();
            this.textBoxLogProcessing = new System.Windows.Forms.TextBox();
            this.progressTracksProcessing = new System.Windows.Forms.ProgressBar();
            this.headerTracksProcessing = new Gui.Wizard.Header();
            this.pageListingTracks = new Gui.Wizard.WizardPage();
            this.progressListingTracks = new System.Windows.Forms.ProgressBar();
            this.headerListingTracks = new Gui.Wizard.Header();
            this.pagePlayLists = new Gui.Wizard.WizardPage();
            this.listPlayLists = new System.Windows.Forms.ListView();
            this.headerPlayLists = new Gui.Wizard.Header();
            this.pageIntro = new Gui.Wizard.WizardPage();
            this.wizardContainerIntro = new Gui.Wizard.InfoContainer();
            this.labelIntroEngage = new System.Windows.Forms.Label();
            this.labelScriptDescription = new System.Windows.Forms.Label();
            this.labelTitleScript = new System.Windows.Forms.Label();
            this.wizardITunes.SuspendLayout();
            this.pageTracks.SuspendLayout();
            this.panelTrackListAndButtons.SuspendLayout();
            this.panelTracksButton.SuspendLayout();
            this.pageConfirmTracks.SuspendLayout();
            this.panelConfirmTracks.SuspendLayout();
            this.pageTrackProcessing.SuspendLayout();
            this.pageListingTracks.SuspendLayout();
            this.pagePlayLists.SuspendLayout();
            this.pageIntro.SuspendLayout();
            this.wizardContainerIntro.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizardITunes
            // 
            this.wizardITunes.Controls.Add(this.pageTracks);
            this.wizardITunes.Controls.Add(this.pageListingTracks);
            this.wizardITunes.Controls.Add(this.pagePlayLists);
            this.wizardITunes.Controls.Add(this.pageIntro);
            this.wizardITunes.Controls.Add(this.pageTrackProcessing);
            this.wizardITunes.Controls.Add(this.pageConfirmTracks);
            this.wizardITunes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardITunes.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wizardITunes.Location = new System.Drawing.Point(0, 0);
            this.wizardITunes.Name = "wizardITunes";
            this.wizardITunes.Pages.AddRange(new Gui.Wizard.WizardPage[] {
            this.pageIntro,
            this.pagePlayLists,
            this.pageListingTracks,
            this.pageTracks,
            this.pageConfirmTracks,
            this.pageTrackProcessing});
            this.wizardITunes.Size = new System.Drawing.Size(1175, 740);
            this.wizardITunes.TabIndex = 0;
            this.wizardITunes.CloseFromCancel += new System.ComponentModel.CancelEventHandler(this.wizardITunes_CloseFromCancel);
            // 
            // pageTracks
            // 
            this.pageTracks.Controls.Add(this.panelTrackListAndButtons);
            this.pageTracks.Controls.Add(this.headerTrackList);
            this.pageTracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageTracks.IsFinishPage = false;
            this.pageTracks.Location = new System.Drawing.Point(0, 0);
            this.pageTracks.Name = "pageTracks";
            this.pageTracks.Size = new System.Drawing.Size(1175, 656);
            this.pageTracks.TabIndex = 3;
            this.pageTracks.CloseFromBack += new Gui.Wizard.PageEventHandler(this.pageTracks_CloseFromBack);
            this.pageTracks.CloseFromNext += new Gui.Wizard.PageEventHandler(this.pageTracks_CloseFromNext);
            this.pageTracks.ShowFromNext += new System.EventHandler(this.pageTracks_ShowFromNext);
            // 
            // panelTrackListAndButtons
            // 
            this.panelTrackListAndButtons.Controls.Add(this.listViewTracks);
            this.panelTrackListAndButtons.Controls.Add(this.panelTracksButton);
            this.panelTrackListAndButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTrackListAndButtons.Location = new System.Drawing.Point(0, 93);
            this.panelTrackListAndButtons.Name = "panelTrackListAndButtons";
            this.panelTrackListAndButtons.Size = new System.Drawing.Size(1175, 563);
            this.panelTrackListAndButtons.TabIndex = 4;
            // 
            // panelTracksButton
            // 
            this.panelTracksButton.Controls.Add(this.buttonCheckAll);
            this.panelTracksButton.Controls.Add(this.buttonUnCheckAll);
            this.panelTracksButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTracksButton.Location = new System.Drawing.Point(0, 0);
            this.panelTracksButton.Name = "panelTracksButton";
            this.panelTracksButton.Size = new System.Drawing.Size(1175, 48);
            this.panelTracksButton.TabIndex = 4;
            // 
            // buttonCheckAll
            // 
            this.buttonCheckAll.Location = new System.Drawing.Point(0, 0);
            this.buttonCheckAll.Name = "buttonCheckAll";
            this.buttonCheckAll.Size = new System.Drawing.Size(116, 44);
            this.buttonCheckAll.TabIndex = 1;
            this.buttonCheckAll.Text = "CheckAll";
            this.buttonCheckAll.UseVisualStyleBackColor = true;
            this.buttonCheckAll.Click += new System.EventHandler(this.buttonCheckAll_Click);
            // 
            // buttonUnCheckAll
            // 
            this.buttonUnCheckAll.Location = new System.Drawing.Point(122, 0);
            this.buttonUnCheckAll.Name = "buttonUnCheckAll";
            this.buttonUnCheckAll.Size = new System.Drawing.Size(146, 44);
            this.buttonUnCheckAll.TabIndex = 2;
            this.buttonUnCheckAll.Text = "Uncheck All";
            this.buttonUnCheckAll.UseVisualStyleBackColor = true;
            this.buttonUnCheckAll.Click += new System.EventHandler(this.buttonUnCheckAll_Click);
            // 
            // listViewTracks
            // 
            this.listViewTracks.AllowColumnReorder = true;
            this.listViewTracks.CheckBoxes = true;
            this.listViewTracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewTracks.FullRowSelect = true;
            this.listViewTracks.Location = new System.Drawing.Point(0, 48);
            this.listViewTracks.Name = "listViewTracks";
            this.listViewTracks.Size = new System.Drawing.Size(1175, 515);
            this.listViewTracks.TabIndex = 3;
            this.listViewTracks.UseCompatibleStateImageBehavior = false;
            this.listViewTracks.View = System.Windows.Forms.View.Details;
            this.listViewTracks.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewTracks_ColumnClick);
            this.listViewTracks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewTracks_KeyDown);
            // 
            // headerTrackList
            // 
            this.headerTrackList.BackColor = System.Drawing.SystemColors.Control;
            this.headerTrackList.CausesValidation = false;
            this.headerTrackList.Description = "Select tracks to process";
            this.headerTrackList.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerTrackList.Image = global::ITunesTrackScriptWizard.Properties.Resources.SimpleIcon;
            this.headerTrackList.Location = new System.Drawing.Point(0, 0);
            this.headerTrackList.Name = "headerTrackList";
            this.headerTrackList.Size = new System.Drawing.Size(1175, 93);
            this.headerTrackList.TabIndex = 0;
            this.headerTrackList.Title = "Tracks";
            // 
            // pageConfirmTracks
            // 
            this.pageConfirmTracks.Controls.Add(this.panelConfirmTracks);
            this.pageConfirmTracks.Controls.Add(this.headerTrackConfirm);
            this.pageConfirmTracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageConfirmTracks.IsFinishPage = false;
            this.pageConfirmTracks.Location = new System.Drawing.Point(0, 0);
            this.pageConfirmTracks.Name = "pageConfirmTracks";
            this.pageConfirmTracks.Size = new System.Drawing.Size(1175, 656);
            this.pageConfirmTracks.TabIndex = 6;
            this.pageConfirmTracks.ShowFromNext += new System.EventHandler(this.pageConfirmTracks_ShowFromNext);
            // 
            // panelConfirmTracks
            // 
            this.panelConfirmTracks.BackColor = System.Drawing.SystemColors.Window;
            this.panelConfirmTracks.Controls.Add(this.labelNbTracksConfirm);
            this.panelConfirmTracks.Controls.Add(this.labelScriptNameConfirm);
            this.panelConfirmTracks.Controls.Add(this.labelScriptConfirm);
            this.panelConfirmTracks.Controls.Add(this.labelConfirmNextEngage);
            this.panelConfirmTracks.Controls.Add(this.labelTracksCountConfirm);
            this.panelConfirmTracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConfirmTracks.Location = new System.Drawing.Point(0, 97);
            this.panelConfirmTracks.Name = "panelConfirmTracks";
            this.panelConfirmTracks.Size = new System.Drawing.Size(1175, 559);
            this.panelConfirmTracks.TabIndex = 7;
            // 
            // labelNbTracksConfirm
            // 
            this.labelNbTracksConfirm.AutoSize = true;
            this.labelNbTracksConfirm.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbTracksConfirm.Location = new System.Drawing.Point(104, 206);
            this.labelNbTracksConfirm.Name = "labelNbTracksConfirm";
            this.labelNbTracksConfirm.Size = new System.Drawing.Size(373, 32);
            this.labelNbTracksConfirm.TabIndex = 4;
            this.labelNbTracksConfirm.Text = "Number of tracks to process :";
            // 
            // labelScriptNameConfirm
            // 
            this.labelScriptNameConfirm.AutoSize = true;
            this.labelScriptNameConfirm.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScriptNameConfirm.Location = new System.Drawing.Point(217, 88);
            this.labelScriptNameConfirm.Name = "labelScriptNameConfirm";
            this.labelScriptNameConfirm.Size = new System.Drawing.Size(182, 33);
            this.labelScriptNameConfirm.TabIndex = 3;
            this.labelScriptNameConfirm.Text = "<ScriptName>";
            // 
            // labelScriptConfirm
            // 
            this.labelScriptConfirm.AutoSize = true;
            this.labelScriptConfirm.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScriptConfirm.Location = new System.Drawing.Point(104, 89);
            this.labelScriptConfirm.Name = "labelScriptConfirm";
            this.labelScriptConfirm.Size = new System.Drawing.Size(107, 32);
            this.labelScriptConfirm.TabIndex = 2;
            this.labelScriptConfirm.Text = "Script :";
            // 
            // labelConfirmNextEngage
            // 
            this.labelConfirmNextEngage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelConfirmNextEngage.AutoSize = true;
            this.labelConfirmNextEngage.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmNextEngage.Location = new System.Drawing.Point(104, 468);
            this.labelConfirmNextEngage.Name = "labelConfirmNextEngage";
            this.labelConfirmNextEngage.Size = new System.Drawing.Size(369, 33);
            this.labelConfirmNextEngage.TabIndex = 1;
            this.labelConfirmNextEngage.Text = "Press Next to start processing...";
            // 
            // labelTracksCountConfirm
            // 
            this.labelTracksCountConfirm.AutoSize = true;
            this.labelTracksCountConfirm.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTracksCountConfirm.Location = new System.Drawing.Point(483, 205);
            this.labelTracksCountConfirm.Name = "labelTracksCountConfirm";
            this.labelTracksCountConfirm.Size = new System.Drawing.Size(265, 33);
            this.labelTracksCountConfirm.TabIndex = 0;
            this.labelTracksCountConfirm.Text = "<Nb Tracks Confirm>";
            // 
            // headerTrackConfirm
            // 
            this.headerTrackConfirm.BackColor = System.Drawing.SystemColors.Control;
            this.headerTrackConfirm.CausesValidation = false;
            this.headerTrackConfirm.Description = "Are you sure ?";
            this.headerTrackConfirm.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerTrackConfirm.Image = global::ITunesTrackScriptWizard.Properties.Resources.SimpleIcon;
            this.headerTrackConfirm.Location = new System.Drawing.Point(0, 0);
            this.headerTrackConfirm.Name = "headerTrackConfirm";
            this.headerTrackConfirm.Size = new System.Drawing.Size(1175, 97);
            this.headerTrackConfirm.TabIndex = 0;
            this.headerTrackConfirm.Title = "Confirm tracks processing";
            // 
            // pageTrackProcessing
            // 
            this.pageTrackProcessing.Controls.Add(this.textBoxLogProcessing);
            this.pageTrackProcessing.Controls.Add(this.progressTracksProcessing);
            this.pageTrackProcessing.Controls.Add(this.headerTracksProcessing);
            this.pageTrackProcessing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageTrackProcessing.IsFinishPage = false;
            this.pageTrackProcessing.Location = new System.Drawing.Point(0, 0);
            this.pageTrackProcessing.Name = "pageTrackProcessing";
            this.pageTrackProcessing.Size = new System.Drawing.Size(1175, 656);
            this.pageTrackProcessing.TabIndex = 7;
            this.pageTrackProcessing.ShowFromNext += new System.EventHandler(this.pageTrackProcessing_ShowFromNext);
            // 
            // textBoxLogProcessing
            // 
            this.textBoxLogProcessing.AcceptsReturn = true;
            this.textBoxLogProcessing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLogProcessing.Location = new System.Drawing.Point(0, 157);
            this.textBoxLogProcessing.Multiline = true;
            this.textBoxLogProcessing.Name = "textBoxLogProcessing";
            this.textBoxLogProcessing.ReadOnly = true;
            this.textBoxLogProcessing.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLogProcessing.Size = new System.Drawing.Size(1175, 499);
            this.textBoxLogProcessing.TabIndex = 2;
            this.textBoxLogProcessing.WordWrap = false;
            // 
            // progressTracksProcessing
            // 
            this.progressTracksProcessing.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressTracksProcessing.Location = new System.Drawing.Point(0, 97);
            this.progressTracksProcessing.Name = "progressTracksProcessing";
            this.progressTracksProcessing.Size = new System.Drawing.Size(1175, 60);
            this.progressTracksProcessing.TabIndex = 1;
            // 
            // headerTracksProcessing
            // 
            this.headerTracksProcessing.BackColor = System.Drawing.SystemColors.Control;
            this.headerTracksProcessing.CausesValidation = false;
            this.headerTracksProcessing.Description = "Please wait while processing...";
            this.headerTracksProcessing.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerTracksProcessing.Image = global::ITunesTrackScriptWizard.Properties.Resources.SimpleIcon;
            this.headerTracksProcessing.Location = new System.Drawing.Point(0, 0);
            this.headerTracksProcessing.Name = "headerTracksProcessing";
            this.headerTracksProcessing.Size = new System.Drawing.Size(1175, 97);
            this.headerTracksProcessing.TabIndex = 0;
            this.headerTracksProcessing.Title = "Processing tracks";
            // 
            // pageListingTracks
            // 
            this.pageListingTracks.Controls.Add(this.progressListingTracks);
            this.pageListingTracks.Controls.Add(this.headerListingTracks);
            this.pageListingTracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageListingTracks.IsFinishPage = false;
            this.pageListingTracks.Location = new System.Drawing.Point(0, 0);
            this.pageListingTracks.Name = "pageListingTracks";
            this.pageListingTracks.Size = new System.Drawing.Size(1175, 656);
            this.pageListingTracks.TabIndex = 4;
            this.pageListingTracks.CloseFromBack += new Gui.Wizard.PageEventHandler(this.pageListingTracks_CloseFromBack);
            this.pageListingTracks.ShowFromNext += new System.EventHandler(this.pageListingTracks_ShowFromNext);
            // 
            // progressListingTracks
            // 
            this.progressListingTracks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressListingTracks.Location = new System.Drawing.Point(12, 340);
            this.progressListingTracks.Name = "progressListingTracks";
            this.progressListingTracks.Size = new System.Drawing.Size(1151, 62);
            this.progressListingTracks.TabIndex = 1;
            // 
            // headerListingTracks
            // 
            this.headerListingTracks.BackColor = System.Drawing.SystemColors.Control;
            this.headerListingTracks.CausesValidation = false;
            this.headerListingTracks.Description = "Please wait while accessing tracks list...";
            this.headerListingTracks.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerListingTracks.Font = new System.Drawing.Font("Vladimir Script", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerListingTracks.Image = global::ITunesTrackScriptWizard.Properties.Resources.SimpleIcon;
            this.headerListingTracks.Location = new System.Drawing.Point(0, 0);
            this.headerListingTracks.Name = "headerListingTracks";
            this.headerListingTracks.Size = new System.Drawing.Size(1175, 93);
            this.headerListingTracks.TabIndex = 0;
            this.headerListingTracks.Title = "Listing tracks";
            // 
            // pagePlayLists
            // 
            this.pagePlayLists.Controls.Add(this.listPlayLists);
            this.pagePlayLists.Controls.Add(this.headerPlayLists);
            this.pagePlayLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagePlayLists.IsFinishPage = false;
            this.pagePlayLists.Location = new System.Drawing.Point(0, 0);
            this.pagePlayLists.Name = "pagePlayLists";
            this.pagePlayLists.Size = new System.Drawing.Size(1175, 656);
            this.pagePlayLists.TabIndex = 2;
            this.pagePlayLists.ShowFromNext += new System.EventHandler(this.pagePlayLists_ShowFromNext);
            // 
            // listPlayLists
            // 
            this.listPlayLists.BackColor = System.Drawing.SystemColors.Window;
            this.listPlayLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPlayLists.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPlayLists.Location = new System.Drawing.Point(0, 97);
            this.listPlayLists.MultiSelect = false;
            this.listPlayLists.Name = "listPlayLists";
            this.listPlayLists.Size = new System.Drawing.Size(1175, 559);
            this.listPlayLists.TabIndex = 1;
            this.listPlayLists.UseCompatibleStateImageBehavior = false;
            this.listPlayLists.View = System.Windows.Forms.View.Tile;
            this.listPlayLists.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.pagePlayLists_ItemSelectionChanged);
            this.listPlayLists.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listPlayLists_MouseDoubleClick);
            // 
            // headerPlayLists
            // 
            this.headerPlayLists.BackColor = System.Drawing.SystemColors.Control;
            this.headerPlayLists.CausesValidation = false;
            this.headerPlayLists.Description = "Select the play list to lookup tracks";
            this.headerPlayLists.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPlayLists.Image = global::ITunesTrackScriptWizard.Properties.Resources.SimpleIcon;
            this.headerPlayLists.Location = new System.Drawing.Point(0, 0);
            this.headerPlayLists.Name = "headerPlayLists";
            this.headerPlayLists.Size = new System.Drawing.Size(1175, 97);
            this.headerPlayLists.TabIndex = 0;
            this.headerPlayLists.Title = "Play lists";
            // 
            // pageIntro
            // 
            this.pageIntro.Controls.Add(this.wizardContainerIntro);
            this.pageIntro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageIntro.IsFinishPage = false;
            this.pageIntro.Location = new System.Drawing.Point(0, 0);
            this.pageIntro.Name = "pageIntro";
            this.pageIntro.Size = new System.Drawing.Size(1175, 656);
            this.pageIntro.TabIndex = 1;
            // 
            // wizardContainerIntro
            // 
            this.wizardContainerIntro.BackColor = System.Drawing.Color.White;
            this.wizardContainerIntro.Controls.Add(this.labelIntroEngage);
            this.wizardContainerIntro.Controls.Add(this.labelScriptDescription);
            this.wizardContainerIntro.Controls.Add(this.labelTitleScript);
            this.wizardContainerIntro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardContainerIntro.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wizardContainerIntro.Image = ((System.Drawing.Image)(resources.GetObject("wizardContainerIntro.Image")));
            this.wizardContainerIntro.Location = new System.Drawing.Point(0, 0);
            this.wizardContainerIntro.Name = "wizardContainerIntro";
            this.wizardContainerIntro.PageTitle = "iTunes Track Script Runner";
            this.wizardContainerIntro.Size = new System.Drawing.Size(1175, 656);
            this.wizardContainerIntro.TabIndex = 0;
            // 
            // labelIntroEngage
            // 
            this.labelIntroEngage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIntroEngage.AutoSize = true;
            this.labelIntroEngage.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntroEngage.Location = new System.Drawing.Point(237, 614);
            this.labelIntroEngage.Name = "labelIntroEngage";
            this.labelIntroEngage.Size = new System.Drawing.Size(375, 33);
            this.labelIntroEngage.TabIndex = 10;
            this.labelIntroEngage.Text = "Press Next to select the tracks...";
            // 
            // labelScriptDescription
            // 
            this.labelScriptDescription.AutoSize = true;
            this.labelScriptDescription.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScriptDescription.Location = new System.Drawing.Point(241, 193);
            this.labelScriptDescription.Name = "labelScriptDescription";
            this.labelScriptDescription.Size = new System.Drawing.Size(200, 31);
            this.labelScriptDescription.TabIndex = 9;
            this.labelScriptDescription.Text = "<no description>";
            // 
            // labelTitleScript
            // 
            this.labelTitleScript.AutoSize = true;
            this.labelTitleScript.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleScript.Location = new System.Drawing.Point(237, 94);
            this.labelTitleScript.Name = "labelTitleScript";
            this.labelTitleScript.Size = new System.Drawing.Size(135, 32);
            this.labelTitleScript.TabIndex = 8;
            this.labelTitleScript.Text = "<no title>";
            // 
            // formWizardITunes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 740);
            this.Controls.Add(this.wizardITunes);
            this.Name = "formWizardITunes";
            this.Text = "iTunes Track Script Runner";
            this.wizardITunes.ResumeLayout(false);
            this.pageTracks.ResumeLayout(false);
            this.panelTrackListAndButtons.ResumeLayout(false);
            this.panelTracksButton.ResumeLayout(false);
            this.pageConfirmTracks.ResumeLayout(false);
            this.panelConfirmTracks.ResumeLayout(false);
            this.panelConfirmTracks.PerformLayout();
            this.pageTrackProcessing.ResumeLayout(false);
            this.pageTrackProcessing.PerformLayout();
            this.pageListingTracks.ResumeLayout(false);
            this.pagePlayLists.ResumeLayout(false);
            this.pageIntro.ResumeLayout(false);
            this.wizardContainerIntro.ResumeLayout(false);
            this.wizardContainerIntro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Gui.Wizard.Wizard wizardITunes;
        private Gui.Wizard.WizardPage pagePlayLists;
        private Gui.Wizard.WizardPage pageIntro;
        private Gui.Wizard.InfoContainer wizardContainerIntro;
        private System.Windows.Forms.ListView listPlayLists;
        private Gui.Wizard.Header headerPlayLists;
        private Gui.Wizard.WizardPage pageTracks;
        private System.Windows.Forms.ListView listViewTracks;
        private Gui.Wizard.Header headerTrackList;
        private Gui.Wizard.WizardPage pageListingTracks;
        private System.Windows.Forms.ProgressBar progressListingTracks;
        private Gui.Wizard.Header headerListingTracks;
        private Gui.Wizard.WizardPage pageConfirmTracks;
        private System.Windows.Forms.Label labelScriptDescription;
        private System.Windows.Forms.Label labelTitleScript;
        private System.Windows.Forms.Label labelIntroEngage;
        private System.Windows.Forms.Button buttonCheckAll;
        private System.Windows.Forms.Button buttonUnCheckAll;
        private System.Windows.Forms.Panel panelConfirmTracks;
        private System.Windows.Forms.Label labelTracksCountConfirm;
        private Gui.Wizard.Header headerTrackConfirm;
        private System.Windows.Forms.Label labelConfirmNextEngage;
        private Gui.Wizard.WizardPage pageTrackProcessing;
        private System.Windows.Forms.ProgressBar progressTracksProcessing;
        private Gui.Wizard.Header headerTracksProcessing;
        private System.Windows.Forms.Label labelScriptNameConfirm;
        private System.Windows.Forms.Label labelScriptConfirm;
        private System.Windows.Forms.Label labelNbTracksConfirm;
        private System.Windows.Forms.TextBox textBoxLogProcessing;
        private System.Windows.Forms.Panel panelTrackListAndButtons;
        private System.Windows.Forms.Panel panelTracksButton;
    }
}


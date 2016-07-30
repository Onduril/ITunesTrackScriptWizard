using System;
using System.Collections.Generic;
using iTunesLib;
using Microsoft.CSharp.RuntimeBinder;
using System.IO;

namespace ITunesTrackScriptWizard
{
    class ITunesScript
    {
        public ITunesScript()
        {
        }

        public string getName()
        {
            return "Embed artworks";
        }

        public string getDescription()
        {
            return "This script is embedding iTunes cached artworks into track files.\n" +
                   "After that, the artworks will be available on tracks outside iTunes.";
        }

        public string getPlayListInfo(object playList)
        {
            dynamic pl = playList;
            try { return pl.Name; } catch (RuntimeBinderException) { }
            return "<no name>";
        }

        public object[] getPlayLists()
        {
            var playLists = new List<object>();
            foreach (dynamic s in m_iTunesInst.Sources)
            {
                if (s.Kind == 1)
                {
                    foreach (var pl in s.PlayLists)
                        playLists.Add(pl);
                }
            }
            return playLists.ToArray();
        }

        public uint getNbTracksInPlayList(object playList)
        {
            dynamic pl = playList;
            if (pl==null || pl.tracks==null)
                return 0;

            return (uint)(pl.tracks.Count);
        }

        public string[] getTracksInfoTypes()
        {
            var trackTypes = new string[] { "Name", "Artist", "Location", "ITunes Artwork" };
            return trackTypes;
        }

        public string[] getTrackInfos(object trackObj)
        {
            dynamic track = trackObj;
            return new string[] {   getName(track),
                                    getArtist(track),
                                    getPath(track),
                                    getArtDownloaded(track) };
        }

        public object getTrackInPlayList(object playList, uint trackNum)
        {
            dynamic pl = playList;
            if (pl == null || pl.tracks == null || pl.tracks.Count <= trackNum)
                return null;

            return pl.tracks.Item[trackNum + 1];
        }


        private string getArtist(dynamic track)
        {
            try { return track.Artist; } catch (RuntimeBinderException) { }
            return "<unknown>";
        }

        private string getPath(dynamic track)
        {
            try { return track.Location; } catch (RuntimeBinderException) { }
            return "<unknown>";
        }

        private string getName(dynamic track)
        {
            try { return track.Name; } catch (RuntimeBinderException) { }
            return "<unknown>";
        }

        private dynamic getArtwork(dynamic track)
        {
            try { return track.Artwork; } catch (RuntimeBinderException) { }
            return null;
        }

        private string getArtDownloaded(dynamic track)
        {
            dynamic artwork = getArtwork(track);
            bool artworkDownloaded = false;
            if (artwork != null)
                foreach (dynamic art in artwork)
                {
                    try {
                        artworkDownloaded = artworkDownloaded | art.IsDownloadedArtwork;
                    } catch (RuntimeBinderException) { }
                }
            return artworkDownloaded ? "Cached" : "Not available";
        }

        string getExtForFormat(int format)
        {
            var extForFormat = new string[] { ".unk", ".jpg", ".png", ".bmp"};
            if (format < 0 || format > extForFormat.Length)
                return ".unk";
            return extForFormat[format];
        }

        string embbedCachedArtworkToFile(dynamic art)
        {
            var tempArtworkFile = Guid.NewGuid().ToString() + getExtForFormat(art.Format);
            tempArtworkFile = Path.Combine(Path.GetTempPath(), tempArtworkFile);
            art.SaveArtworkToFile(tempArtworkFile);
            art.SetArtworkFromFile(tempArtworkFile);
            File.Delete(tempArtworkFile);
            return "Artwork embedded to file";
        }

        public string processTrack(object track) // return a process log
        {
            var logFile = "Processing " + getName(track) + ":\r\n";
            var logResult = "Artwork not found";
            var trackPath = getPath(track);
            if (trackPath == null)
            {
                logResult = "Track file not found.";
                return logFile + logResult;
            }
            var artwork = getArtwork(track);
            if (artwork == null)
            {
                return logFile + logResult;
            }
            foreach (dynamic art in artwork)
            {
                try
                {
                    if (!art.IsDownloadedArtwork) continue;
                    logResult = embbedCachedArtworkToFile(art);
                    break;
                }
                catch (RuntimeBinderException) { }
            }
            return logFile + logResult;
        }

        iTunesApp m_iTunesInst = new iTunesApp();
    }
}

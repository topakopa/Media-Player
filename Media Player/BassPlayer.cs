using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Tags;

namespace Media_Player
{
    public class BassPlayer
    {
        private int _handleSynchronization;
        SYNCPROC _syncProcChangeTags;
        public int _numberStream;
        public TAG_INFO tag_info { get; set; }
        public FormPlayer Formplayer { get; set; }

        public BassPlayer(FormPlayer form)
        {
            Formplayer = form;
            _syncProcChangeTags = new SYNCPROC(Bass_mediaChange);
        }
        //private event EventHandler<RPTagsChangedEventArgs> Radio_TagChange;

        private void Bass_mediaChange(int handle, int channel, int data, System.IntPtr user)
        {
            
            GetTagFromURL();
            Formplayer.tegChange(tag_info);
            
        }
        public void GetTagFromURL()
        {
            tag_info = new TAG_INFO();
            Bass.BASS_ChannelGetTags(_numberStream, BASSTag.BASS_TAG_META);
            BassTags.BASS_TAG_GetFromURL(_numberStream, tag_info);
            
        }

        public void Play (string url)
        {
             _numberStream = Bass.BASS_StreamCreateURL(url, 0, BASSFlag.BASS_DEFAULT, null, IntPtr.Zero);
            if (_numberStream != 0)
            {
                Bass.BASS_ChannelPlay(_numberStream, true);
                _handleSynchronization = Bass.BASS_ChannelSetSync(_numberStream, BASSSync.BASS_SYNC_META, 0, _syncProcChangeTags, IntPtr.Zero);
                Bass.BASS_ChannelSetAttribute(_numberStream, BASSAttribute.BASS_ATTRIB_VOL, 0 / 100f);
                Formplayer.Music = url;
            }

        }
        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//подключаем пространство имён 
using Un4seen.Bass.AddOn.Tags;

namespace pleyerF
{
    public class TagInfo
    {
        public int bitRate;
        public int freq;
        public string channels;
        public string artist;
        public string album;
        public string title;
        public string years;


        Dictionary<int, string> channelDisc = new Dictionary<int, string>()
        {
            {0,"Null" },
            {1,"Mono" },
            {2,"Stereo"}
        };


        public TagInfo(string file)
        {
            TAG_INFO tag_info = new TAG_INFO();
            tag_info = BassTags.BASS_TAG_GetFromFile(file);
            bitRate = tag_info.bitrate;
            freq = tag_info.channelinfo.freq;
            channels = channelDisc[tag_info.channelinfo.chans];
            artist = tag_info.artist;
            album = tag_info.album;
            if (tag_info.title == "")
                title = Vars.GetFileName(file);
            else
                title = tag_info.title;
            years = tag_info.year;

        }


    }

}

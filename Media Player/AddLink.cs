using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Tags;

namespace Media_Player
{

    public partial class AddLink : Form
    {
        FormPlayer FormPlayer { get; set; }
        public AddLink()
        {
            InitializeComponent();
            Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
        }
        public AddLink(FormPlayer formPlayer)
        {
            InitializeComponent();
            FormPlayer = formPlayer;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string link = bunifuTextBox1.Text;
            FormPlayer.Player.currentPlaylist.appendItem(FormPlayer.Player.newMedia(link));


            var tagInfo = new TAG_INFO(link);
            
            var _stream = Bass.BASS_StreamCreateURL(link, 0, BASSFlag.BASS_DEFAULT, null, IntPtr.Zero);

            string artist = "";
            string title = "";
            if (BassTags.BASS_TAG_GetFromURL(_stream, tagInfo))
            {
                artist = tagInfo.artist.ToString();
                title = tagInfo.title.ToString();

            }


            string name;
            if (artist == "" && title == "")
            {
                name = link;
            }
            else if (artist == "" || title == "")
            {
                name = $"{artist}{title}";
            }
            else
            {
                name = $"{artist} / {title}";
            }


            int row = FormPlayer.VisualPlaylist.Rows.Add(new object[]
            {
                name,
                tagInfo.duration < TimeSpan.MaxValue.TotalSeconds ? TimeSpan.FromSeconds(tagInfo.duration).ToString(@"mm\:ss") : "radio"
            }) ;

            FormPlayer.VisualPlaylist.Rows[row].Tag = link;

        }
    }
}

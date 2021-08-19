using PlaylistsNET.Content;
using PlaylistsNET.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player
{
    public partial class FormPlayer : Form
    {
        private Dictionary<double, int> stars = new Dictionary<double, int>()
        {
            {0, 0},
            {0.5, 2},
            {1, 31},
            {1.5, 32},
            {2, 64},
            {2.5, 96},
            {3, 128},
            {3.5, 160},
            {4, 196},
            {4.5, 224},
            {5, 255}

        };
        private string Music { get; set; }
        private bool IsMute { get; set; } = false;
        TagLib.File file { get; set; }
        private WMPLib.IWMPPlaylist Playlist { get; set; }

        [Obsolete]
        public FormPlayer()
        {
            InitializeComponent();
            player_init();
            playlist_init();
            context_menu_init();
        }

        private void context_menu_init()
        {
            guna2ContextMenuStrip1.Items[0].Click += Add_File;
            //guna2ContextMenuStrip1.Items[1].Click += ChangeNick;
            //guna2ContextMenuStrip1.Items[2].Click += ChangePass;
            //guna2ContextMenuStrip1.Items[3].Click += ShowEditGame1;

            //guna2ContextMenuStrip2.Items[0].Click += GameDEL;
            //guna2ContextMenuStrip2.Items[1].Click += GameDEL;
            //guna2ContextMenuStrip2.Items[3].Click += GameDEL;
        }

        private void Add_File(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialogPlay.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                foreach (String File in openFileDialogPlay.FileNames)
                {
                    FileInfo fileInfo = new FileInfo(File);
                    TagLib.File F = TagLib.File.Create(fileInfo.FullName);

                    int row = bunifuDataGridView1.Rows.Add(new object[]
                    {
                    $"{F.Tag.FirstPerformer} / {F.Tag.Title}",
                    F.Properties.Duration.ToString(@"mm\:ss"),
                    });

                    bunifuDataGridView1.Rows[row].Tag = fileInfo;

                    Playlist.appendItem(axWindowsMediaPlayer1.newMedia(File));
                }
            }
        }

        private void player_init()
        {
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.settings.autoStart = false;
            axWindowsMediaPlayer1.URL = @"";

            string user_name = Environment.UserName;
            Stream stream = new StreamReader("Assets/Default.m3u").BaseStream;

            //var parser = PlaylistParserFactory.GetPlaylistParser(PlaylistType.M3U);
            //IBasePlaylist playlist = parser.GetFromString(@"‪C:\Users\шурик\Music\Playlists\playlist.m3u");
            M3uContent content = new M3uContent();
            M3uPlaylist playlist = content.GetFromStream(stream);

            List<string> audio_paths = playlist.GetTracksPaths();

            stream.Close();
            //File.Delete(@"C:\playlist.m3u");

            Playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist("Default");

            foreach (string path in audio_paths)
            {
                Playlist.appendItem(axWindowsMediaPlayer1.newMedia(path));
            }
            axWindowsMediaPlayer1.currentPlaylist = Playlist;
        }

        private void guna2ImageButtonInfo_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2ImageButtonVideo_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = true;

        }


        private void guna2ImageButtonPlay_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else if (Music != null)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();

            }
            timer1.Start();

            tegChange();

        }

        private void guna2ImageButtonPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void guna2ImageButtonStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void guna2ImageButtonLeft_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.previous();
            int selectedIndex = bunifuDataGridView1.SelectedRows[0].Index;
            bunifuDataGridView1.Rows[selectedIndex].Selected = false;

            if (selectedIndex == 0)
            {
                bunifuDataGridView1.Rows[bunifuDataGridView1.Rows.Count - 1].Selected = true;
            }
            else
            {
                bunifuDataGridView1.Rows[selectedIndex - 1].Selected = true;
            }

            tegChange();
        }

        private void guna2ImageButtonRight_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.next();
            int selectedIndex = bunifuDataGridView1.SelectedRows[0].Index;


            bunifuDataGridView1.Rows[selectedIndex].Selected = false;
            if (selectedIndex == bunifuDataGridView1.Rows.Count - 1)
            {
                bunifuDataGridView1.Rows[0].Selected = true;
            }
            else
            {
                bunifuDataGridView1.Rows[selectedIndex + 1].Selected = true;
            }
            tegChange();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuLabelSongTime.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            bunifuHSliderSongTime.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

            if (axWindowsMediaPlayer1.currentMedia.duration != 0)
            {
                bunifuLabelSongTimeLong.Text = axWindowsMediaPlayer1.currentMedia.durationString;
                bunifuHSliderSongTime.Maximum = (int)axWindowsMediaPlayer1.currentMedia.duration;
            }

            bunifuLabel1.Text = axWindowsMediaPlayer1.status;
            bunifuLabel3.Text = axWindowsMediaPlayer1.status;

            if (bunifuLabel1.Left == -1)
            {
                bunifuLabel3.Left = panel1.Size.Width;
                bunifuLabel3.Visible = true;
            }

            if (bunifuLabel3.Left == -1)
            {
                bunifuLabel1.Left = panel1.Size.Width;
            }

            bunifuLabel1.Left -= 1;
            bunifuLabel3.Left -= 1;

        }
        
        private void bunifuHSliderSongTime_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = e.Value;
        }

        /// <summary>
        /// настройка громокости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuHSliderVolume_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = e.Value;
            if (IsMute)
            {
                IsMute = false;
                guna2ImageButton.Image = Image.FromFile(@"C:\Users\шурик\source\repos\Media Player\Media Player\Assets\Unmute.png");
                guna2ImageButton.HoverState.Image = Image.FromFile(@"C:\Users\шурик\source\repos\Media Player\Media Player\Assets\Unmute.png");
                guna2ImageButton.PressedState.Image = Image.FromFile(@"C:\Users\шурик\source\repos\Media Player\Media Player\Assets\Mute.png");
            }

        }

        /// <summary>
        /// включение выключение звука
        /// </summary>
        private void guna2ImageButton_Click(object sender, EventArgs e)
        {

            if (IsMute)
            {
                IsMute = false;
                bunifuHSliderVolume.Value = axWindowsMediaPlayer1.settings.volume;
                guna2ImageButton.Image = Image.FromFile(@"C:\Users\шурик\source\repos\Media Player\Media Player\Assets\Unmute.png");
                guna2ImageButton.HoverState.Image = Image.FromFile(@"C:\Users\шурик\source\repos\Media Player\Media Player\Assets\Unmute.png");
                guna2ImageButton.PressedState.Image = Image.FromFile(@"C:\Users\шурик\source\repos\Media Player\Media Player\Assets\Mute.png");
            }
            else
            {
                IsMute = true;
                bunifuHSliderVolume.Value = 0;
                guna2ImageButton.Image = Image.FromFile(@"C:\Users\шурик\source\repos\Media Player\Media Player\Assets\Mute.png");
                guna2ImageButton.HoverState.Image = Image.FromFile(@"C:\Users\шурик\source\repos\Media Player\Media Player\Assets\Mute.png");
                guna2ImageButton.PressedState.Image = Image.FromFile(@"C:\Users\шурик\source\repos\Media Player\Media Player\Assets\Unmute.png");
            }
            axWindowsMediaPlayer1.settings.mute = IsMute;
        }

        /// <summary>
        /// Добавление песен через Drag Drop
        /// </summary>
        private void GridViewDragDrop(object sender, DragEventArgs e)
        {


            String[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (String File in files)
            {
                FileInfo fileInfo = new FileInfo(File);
                TagLib.File F = TagLib.File.Create(fileInfo.FullName);

                int row = bunifuDataGridView1.Rows.Add(new object[]
                {
                    $"{F.Tag.FirstPerformer} / {F.Tag.Title}",
                    F.Properties.Duration.ToString(@"mm\:ss"),
                });

                bunifuDataGridView1.Rows[row].Tag = fileInfo;

                Playlist.appendItem(axWindowsMediaPlayer1.newMedia(File));
            }
            axWindowsMediaPlayer1.currentPlaylist = Playlist;

        }

        private void GridViewDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }


        /// <summary>
        /// Наполнение панели плейлиста
        /// </summary>
        private void playlist_init()
        {

            for (int i = 0; i < axWindowsMediaPlayer1.currentPlaylist.count; i++)
            {
                WMPLib.IWMPMedia audio = axWindowsMediaPlayer1.currentPlaylist.Item[i];

                FileInfo fileInfo = new FileInfo(audio.sourceURL);
                TagLib.File F = TagLib.File.Create(fileInfo.FullName);

                int row = bunifuDataGridView1.Rows.Add(new object[]
                {
                    $"{F.Tag.FirstPerformer} / {F.Tag.Title}",
                    F.Properties.Duration.ToString(@"mm\:ss"),
                });

                bunifuDataGridView1.Rows[row].Tag = fileInfo;
            }

        }

        private void axWindowsMediaPlayer1_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {


        }

        private void axWindowsMediaPlayer1_MediaChange(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {
            int selected_index = bunifuDataGridView1.SelectedRows[0].Index;
            if (axWindowsMediaPlayer1.currentMedia.sourceURL != ((FileInfo)bunifuDataGridView1.Rows[selected_index].Tag).FullName)
            {
                bunifuDataGridView1.Rows[selected_index].Selected = false;
                if (selected_index == bunifuDataGridView1.Rows.Count - 1)
                {
                    bunifuDataGridView1.Rows[0].Selected = true;
                }
                else
                {
                    bunifuDataGridView1.Rows[selected_index].Selected = true;
                }
            }

            Music = axWindowsMediaPlayer1.currentMedia.sourceURL;
            tegChange();
        }

        /// <summary>
        /// настройка визуальных тегов
        /// </summary>
        private void tegChange()
        {
            file = TagLib.File.Create(Music);

            bunifuLabelName.Text = file.Tag.Title ?? "";
            bunifuLabelArtist.Text = file.Tag.FirstPerformer ?? "";

            bunifuLabelAlbum.Text = file.Tag.Album ?? "";
            bunifuLabelAlbumArtist.Text = file.Tag.FirstAlbumArtist ?? "";

            bunifuLabelNamber.Text = file.Tag.Track.ToString() ?? "";
            bunifuLabelAge.Text = file.Tag.Year.ToString() ?? "";
            bunifuLabelStile.Text = file.Tag.FirstGenre ?? "";

            if (file.Tag.Pictures.Length != 0)
            {
                MemoryStream ms = new MemoryStream(file.Tag.Pictures[0].Data.Data);
                guna2PictureBox1.BackgroundImage = Image.FromStream(ms);
            }
            else
            {
                guna2PictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\шурик\source\repos\Media Player\Media Player\Assets\Default album icon.jpg");
            }

            TagLib.Id3v2.PopularimeterFrame frame = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)file.GetTag(TagLib.TagTypes.Id3v2), "Windows Media Player 9 Series", true);


            guna2RatingStar1.Value = (float)stars.First(u => u.Value == frame.Rating).Key;

        }


        private void bunifuDataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            FileInfo file = (FileInfo)bunifuDataGridView1.Rows[e.RowIndex].Tag;

            Music = file.FullName;

            axWindowsMediaPlayer1.Ctlcontrols.currentItem = axWindowsMediaPlayer1.currentPlaylist.Item[e.RowIndex];
            guna2ImageButtonPlay_Click(sender, e);
            tegChange();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {


        }

        private void bunifuDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2RatingStar1_ValueChanged(object sender, EventArgs e)
        {



        }

        private void FormPlayer_Load(object sender, EventArgs e)
        {



        }

        private void guna2RatingStar1_Click(object sender, EventArgs e)
        {
            guna2ImageButton1.Visible = true;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            double currentPosition = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            TagLib.Id3v2.PopularimeterFrame frame = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)file.GetTag(TagLib.TagTypes.Id3v2), "Windows Media Player 9 Series", true);
            frame.Rating = (byte)stars[guna2RatingStar1.Value];
            axWindowsMediaPlayer1.close();
            file.Save();
            guna2ImageButton1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = currentPosition;
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.setMode("shuffle", guna2ToggleSwitch1.Checked);

        }

        private void FormPlayer_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FormPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            M3uPlaylist m3UPlaylist = new M3uPlaylist();
            m3UPlaylist.IsExtended = true;
            for (int i = 0; i < axWindowsMediaPlayer1.currentPlaylist.count; i++)
            {
                WMPLib.IWMPMedia audio = axWindowsMediaPlayer1.currentPlaylist.Item[i];

                FileInfo fileInfo = new FileInfo(audio.sourceURL);
                TagLib.File F = TagLib.File.Create(fileInfo.FullName);

                m3UPlaylist.PlaylistEntries.Add(new M3uPlaylistEntry()
                {
                    Title = F.Tag.Title,
                    Path = audio.sourceURL,
                    Duration = F.Properties.Duration,

                });
            }

            string text = PlaylistToTextHelper.ToText(m3UPlaylist);

            using (StreamWriter writer = new StreamWriter("Assets/Default.m3u", false))
            {
                writer.WriteLine(text);
            }


        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            guna2ImageButton2.ContextMenuStrip.Show(guna2ImageButton2, new Point(0, 51));
        }
    }
}

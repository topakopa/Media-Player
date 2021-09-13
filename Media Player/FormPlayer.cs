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
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Tags;

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
        /// <summary>
        /// Зацыкливание песни
        /// </summary>
        private bool Retry { get; set; }
        /// <summary>
        /// Путь к песне
        /// </summary>
        private string Music { get; set; } = @"";
        /// <summary>
        /// Выключен ли звук
        /// </summary>
        private bool IsMute { get; set; } = false;
        /// <summary>
        /// Теги песни
        /// </summary>
        TagLib.File file { get; set; }
        TAG_INFO tag_info { get; set; }
        private int Timer { get; set; }
        private string Vstatus { get; set; }
        private byte Sstatus { get; set; }
        /// <summary>
        /// Плейлист
        /// </summary>
        private WMPLib.IWMPPlaylist CurrentPlaylist { get; set; }

        [Obsolete]
        public FormPlayer()
        {
            InitializeComponent();
            player_init();
            Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
            context_menu_init();
        }

        /// <summary>
        /// Инициализация контекстных меню
        /// </summary>
        private void context_menu_init()
        {
            ContextMenuAdd.Items[0].Click += Add_File;
            ContextMenuAdd.Items[1].Click += Add_Folder;
            ContextMenuAdd.Items[2].Click += Add_Playlist;
            ContextMenuAdd.Items[3].Click += Add_Link;

            ContextMenuDEL.Items[0].Click += DEL_File;
            ContextMenuDEL.Items[1].Click += DEL_File_from_disk;
            ContextMenuDEL.Items[3].Click += Clean_Playlist;
            //ContextMenuDEL.Items[4].Click += DEL_Playlist;
        }

        private void Add_Playlist(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialogPlaylists.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                foreach (String File in openFileDialogPlaylists.FileNames)
                {
                    FileInfo fileInfo = new FileInfo(File);
                    
                    Stream stream = new StreamReader(fileInfo.FullName).BaseStream;

                    M3uContent content = new M3uContent();
                    M3uPlaylist playlist = content.GetFromStream(stream);

                    List<string> audio_paths = playlist.GetTracksPaths();

                    stream.Close();

                    CurrentPlaylist = Player.playlistCollection.newPlaylist(File);
                    

                    foreach (string path in audio_paths)
                    {
                        if (!path.StartsWith("http"))
                        {
                            TagLib.File F = TagLib.File.Create(path);
                            string name;

                            if (F.Tag.FirstPerformer == null && F.Tag.Title == null)
                            {
                                name = fileInfo.Name;
                            }
                            else if (F.Tag.FirstPerformer == null || F.Tag.Title == null)
                            {
                                name = $"{F.Tag.FirstPerformer}{F.Tag.Title}";
                            }
                            else
                            {
                                name = $"{F.Tag.FirstPerformer} / {F.Tag.Title}";
                            }

                            int row = VisualPlaylist.Rows.Add(new object[]
                            {
                                name,
                                F.Properties.Duration.ToString(@"mm\:ss"),
                            });

                            VisualPlaylist.Rows[row].Tag = fileInfo;
                        }
                        else
                        {
                            var tagInfo = new TAG_INFO(path);
                            var _stream = Bass.BASS_StreamCreateURL(path, 0, BASSFlag.BASS_DEFAULT, null, IntPtr.Zero);

                            string artist = "";
                            string title = "";

                            if (BassTags.BASS_TAG_GetFromURL(_stream, tagInfo))
                            {
                                artist = tagInfo.artist.ToString();
                                title = tagInfo.title.ToString();
                            }
                            else
                            {
                                continue;
                            }

                            string name;
                            if (artist == "" && title == "")
                            {
                                name = path;
                            }
                            else if (artist == "" || title == "")
                            {
                                name = $"{artist}{title}";
                            }
                            else
                            {
                                name = $"{artist} / {title}";
                            }


                            int row = VisualPlaylist.Rows.Add(new object[]
                            {
                                name,
                                tagInfo.duration < TimeSpan.MaxValue.TotalSeconds ? TimeSpan.FromSeconds(tagInfo.duration).ToString(@"mm\:ss") : "radio"
                            });

                            VisualPlaylist.Rows[row].Tag = path;


                        }
                        CurrentPlaylist.appendItem(Player.newMedia(path));

                    }
                    Player.currentPlaylist = CurrentPlaylist;

                    List_Playlist.Items.Add(File);
                    List_Playlist.SelectedIndex = List_Playlist.Items.Count - 1;

                }
            }
        }

        private void DEL_File_from_disk(object sender, EventArgs e)
        {
            if (VisualPlaylist.SelectedRows.Count > 0)
            {
                int index = VisualPlaylist.SelectedRows[0].Index;
                FileInfo fileInfo = (FileInfo)VisualPlaylist.SelectedRows[0].Tag;
                Player.currentPlaylist.removeItem(Player.currentPlaylist.Item[index]);
                VisualPlaylist.Rows.Remove(VisualPlaylist.Rows[index]);
                File.Delete(fileInfo.FullName);
            }

        }

        private void Clean_Playlist(object sender, EventArgs e)
        {
            VisualPlaylist.Rows.Clear();
            Player.currentPlaylist.clear();
        }

        private void DEL_File(object sender, EventArgs e)
        {
            if (VisualPlaylist.SelectedRows.Count > 0)
            {
                int index = VisualPlaylist.SelectedRows[0].Index;
                Player.currentPlaylist.removeItem(Player.currentPlaylist.Item[index]);
                VisualPlaylist.Rows.Remove(VisualPlaylist.Rows[index]);
            }
        }

        private void Add_Link(object sender, EventArgs e)
        {
            AddLink addLink = new AddLink(this);
            addLink.ShowDialog();

        }

        /// <summary>
        /// Добавление папки в плейлист
        /// </summary>
        private void Add_Folder(object sender, EventArgs e)
        {
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath); 
                foreach (String File in files)
                {
                    if (File.EndsWith(".mp3") || File.EndsWith(".wave") || File.EndsWith(".mid") || File.EndsWith(".mp4") || File.EndsWith(".avi") || File.EndsWith(".mp2"))
                    {
                        FileInfo fileInfo = new FileInfo(File);
                        TagLib.File F = TagLib.File.Create(fileInfo.FullName);

                        string name;
                        if (F.Tag.FirstPerformer == null && F.Tag.Title == null)
                        {
                            name = fileInfo.Name;
                        }
                        else if (F.Tag.FirstPerformer == null || F.Tag.Title == null)
                        {
                            name = $"{F.Tag.FirstPerformer}{F.Tag.Title}";
                        }
                        else
                        {
                            name = $"{F.Tag.FirstPerformer} / {F.Tag.Title}";
                        }

                        int row = VisualPlaylist.Rows.Add(new object[]
                        {
                            name,
                            F.Properties.Duration.ToString(@"mm\:ss"),
                        });

                        VisualPlaylist.Rows[row].Tag = fileInfo;

                        Player.currentPlaylist.appendItem(Player.newMedia(File));
                    }
                }
            }
        }
        /// <summary>
        /// Добавление файла в плейлист
        /// </summary>
        private void Add_File(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialogPlay.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                foreach (String File in openFileDialogPlay.FileNames)
                {
                    FileInfo fileInfo = new FileInfo(File);
                    TagLib.File F = TagLib.File.Create(fileInfo.FullName);

                    string name;
                    if (F.Tag.FirstPerformer == null && F.Tag.Title == null)
                    {
                        name = fileInfo.Name;
                    }
                    else if (F.Tag.FirstPerformer == null || F.Tag.Title == null)
                    {
                        name = $"{F.Tag.FirstPerformer}{F.Tag.Title}";
                    }
                    else
                    {
                        name = $"{F.Tag.FirstPerformer} / {F.Tag.Title}";
                    }

                    int row = VisualPlaylist.Rows.Add(new object[]
                    {
                        name,
                        F.Properties.Duration.ToString(@"mm\:ss"),
                    });

                    VisualPlaylist.Rows[row].Tag = fileInfo;

                    Player.currentPlaylist.appendItem(Player.newMedia(File));
                }
            }
        }

        /// <summary>
        /// Инициализация плеера и стандартного плейлиста
        /// </summary>
        private void player_init()
        {
            Player.uiMode = "none";
            Player.settings.autoStart = false;
            Player.URL = @"";
            Player.settings.setMode("loop", true);

            string user_name = Environment.UserName;
            Stream stream = new StreamReader("Assets/Default.m3u").BaseStream;

            //var parser = PlaylistParserFactory.GetPlaylistParser(PlaylistType.M3U);
            //IBasePlaylist playlist = parser.GetFromString(@"‪C:\Users\шурик\Music\Playlists\playlist.m3u");
            M3uContent content = new M3uContent();
            M3uPlaylist playlist = content.GetFromStream(stream);

            List<string> audio_paths = playlist.GetTracksPaths();

            stream.Close();
            File.Delete($@"C:\Users\{user_name}\Music\Playlists\Default.wpl");

            CurrentPlaylist = Player.playlistCollection.newPlaylist("Default");

            foreach (string path in audio_paths)
            {
                CurrentPlaylist.appendItem(Player.newMedia(path));
            }
            Player.currentPlaylist = CurrentPlaylist;
            List_Playlist.SelectedIndex = 0;
        }
        /// <summary>
        /// Скрыть визуализацию \ Показать информацию
        /// </summary>
        private void guna2ImageButtonInfo_Click(object sender, EventArgs e)
        {
            Player.Visible = false;
            FullscreanButton.Visible = false;
        }
        /// <summary>
        /// Показать визуализацию \ Скрыть информацию
        /// </summary>
        private void guna2ImageButtonVideo_Click(object sender, EventArgs e)
        {
            Player.Visible = true;
            FullscreanButton.Visible = true;

        }
        /// <summary>
        /// Кнопка Плей
        /// </summary>
        private void guna2ImageButtonPlay_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                Player.Ctlcontrols.stop();
                Player.Ctlcontrols.play();
            }
            else if (Player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                Player.Ctlcontrols.play();
            }
            else if (Music != null)
            {
                Player.Ctlcontrols.play();

            }
            timer1.Start();

            tegChange();

        }
        /// <summary>
        /// Кнопка Паузы
        /// </summary>
        private void guna2ImageButtonPause_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }
        /// <summary>
        /// Кнопка Остановки
        /// </summary>
        private void guna2ImageButtonStop_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }
        /// <summary>
        /// Кнопка Предыдущей песни
        /// </summary>
        private void guna2ImageButtonLeft_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.previous();
            int selectedIndex = VisualPlaylist.SelectedRows[0].Index;
            VisualPlaylist.Rows[selectedIndex].Selected = false;

            if (selectedIndex == 0)
            {
                VisualPlaylist.Rows[VisualPlaylist.Rows.Count - 1].Selected = true;
            }
            else
            {
                VisualPlaylist.Rows[selectedIndex - 1].Selected = true;
            }

            tegChange();
        }
        /// <summary>
        /// Кнопка Следующей песни
        /// </summary>
        private void guna2ImageButtonRight_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.next();
            int selectedIndex = VisualPlaylist.SelectedRows[0].Index;


            VisualPlaylist.Rows[selectedIndex].Selected = false;
            if (selectedIndex == VisualPlaylist.Rows.Count - 1)
            {
                VisualPlaylist.Rows[0].Selected = true;
            }
            else
            {
                VisualPlaylist.Rows[selectedIndex + 1].Selected = true;
            }
            tegChange();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Retry && (int)Player.Ctlcontrols.currentPosition == (int)Player.currentMedia.duration)
            {
                Player.Ctlcontrols.currentPosition = 0;
            }
            //визуалилизация времени
            SongTimeLabel.Text = Player.Ctlcontrols.currentPositionString;
            SongTimeSlider.Value = (int)Player.Ctlcontrols.currentPosition;


            if (Player.currentMedia != null)
            {
                if (Player.currentMedia.duration != 0)
                {
                    SongLongTimeLabel.Text = Player.currentMedia.durationString;
                    SongTimeSlider.Maximum = (int)Player.currentMedia.duration;
                }
            }


            //статус песни
            if(Player.status == "Приостановлено" || Player.status == "Остановлено")
            {
                Sstatus = 0;
                Vstatus = Player.status;
            }
            else if (Sstatus == 1)
            {
                if(TagLabelArtist.Text != null && TagLabelTile.Text != null)
                {
                    Vstatus = $"{TagLabelArtist.Text} / {TagLabelTile.Text}";
                }
                else
                {
                    Sstatus++;
                }
            }
            else if(Sstatus == 0)
            {
                Vstatus = Player.status;
            }
            else if(Sstatus == 2)
            {
                Vstatus = Player.currentMedia.name;
            }
            else if (Sstatus == 3)
            {
                if (TagLabelAlbumArtist.Text != null && TagLabelAlbum.Text != null)
                {
                    Vstatus = $"{TagLabelAlbumArtist.Text} / {TagLabelAlbum.Text}";
                }
                else
                {
                    Sstatus++;
                }
            }
            else if (Sstatus == 4)
            {
                if (TagLabelStile.Text != null)
                {
                    Vstatus = TagLabelStile.Text;
                }
                else
                {
                    Sstatus++;
                }
            }

            StatusLabel1.Text = Vstatus;
            StatusLabel2.Text = Vstatus;

            if (StatusLabel1.Left == -1)
            {
                StatusLabel2.Left = panel1.Size.Width;
                StatusLabel2.Visible = true;
            }

            if (StatusLabel2.Left == -1)
            {
                StatusLabel1.Left = panel1.Size.Width;
            }

            StatusLabel1.Left -= 1;
            StatusLabel2.Left -= 1;

            Timer++;
            if (Timer > 45)
            {
                Timer = 0;
                if(Sstatus < 4)
                {
                    Sstatus++;
                }
                else
                {
                    Sstatus = 0;
                }
                
            }
            
        }
        
        private void bunifuHSliderSongTime_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            Player.Ctlcontrols.currentPosition = e.Value;
        }

        /// <summary>
        /// настройка громокости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuHSliderVolume_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            Player.settings.volume = e.Value;
            if (IsMute)
            {
                IsMute = false;
                ButtonMute.Image = Image.FromFile(@"C:\Users\шурик\source\repos\Media Player\Media Player\Assets\Unmute.png");
                ButtonMute.HoverState.Image = Image.FromFile(@"C:\Users\шурик\source\repos\Media Player\Media Player\Assets\Unmute.png");
                ButtonMute.PressedState.Image = Image.FromFile(@"C:\Users\шурик\source\repos\Media Player\Media Player\Assets\Mute.png");
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
                VolumeSlider.Value = Player.settings.volume;
                ButtonMute.Image = Image.FromFile(@"C:\Users\шурик\source\repos\Media Player\Media Player\Assets\Unmute.png");
                ButtonMute.HoverState.Image = Image.FromFile(@"C:\Users\шурик\source\repos\Media Player\Media Player\Assets\Unmute.png");
                ButtonMute.PressedState.Image = Image.FromFile(@"C:\Users\шурик\source\repos\Media Player\Media Player\Assets\Mute.png");
            }
            else
            {
                IsMute = true;
                VolumeSlider.Value = 0;
                ButtonMute.Image = Image.FromFile(@"C:\Users\шурик\source\repos\Media Player\Media Player\Assets\Mute.png");
                ButtonMute.HoverState.Image = Image.FromFile(@"C:\Users\шурик\source\repos\Media Player\Media Player\Assets\Mute.png");
                ButtonMute.PressedState.Image = Image.FromFile(@"C:\Users\шурик\source\repos\Media Player\Media Player\Assets\Unmute.png");
            }
            Player.settings.mute = IsMute;
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

                string name;
                if (F.Tag.FirstPerformer == null && F.Tag.Title == null)
                {
                    name = fileInfo.Name;
                }
                else if (F.Tag.FirstPerformer == null || F.Tag.Title == null)
                {
                    name = $"{F.Tag.FirstPerformer}{F.Tag.Title}";
                }
                else
                {
                    name = $"{F.Tag.FirstPerformer} / {F.Tag.Title}";
                }

                int row = VisualPlaylist.Rows.Add(new object[]
                {
                    name,
                    F.Properties.Duration.ToString(@"mm\:ss"),
                });

                VisualPlaylist.Rows[row].Tag = fileInfo;

                CurrentPlaylist.appendItem(Player.newMedia(File));
            }
            Player.currentPlaylist = CurrentPlaylist;

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

            for (int i = 0; i < Player.currentPlaylist.count; i++)
            {

                WMPLib.IWMPMedia audio = Player.currentPlaylist.Item[i];

                if (!audio.sourceURL.StartsWith("http"))
                {
                    FileInfo fileInfo = new FileInfo(audio.sourceURL);
                    TagLib.File F = TagLib.File.Create(fileInfo.FullName);

                    string name;
                    if (F.Tag.FirstPerformer == null && F.Tag.Title == null)
                    {
                        name = fileInfo.Name;
                    }
                    else if (F.Tag.FirstPerformer == null || F.Tag.Title == null)
                    {
                        name = $"{F.Tag.FirstPerformer}{F.Tag.Title}";
                    }
                    else
                    {
                        name = $"{F.Tag.FirstPerformer} / {F.Tag.Title}";
                    }

                    int row = VisualPlaylist.Rows.Add(new object[]
                    {
                    name,
                    F.Properties.Duration.ToString(@"mm\:ss"),
                    });

                    VisualPlaylist.Rows[row].Tag = fileInfo;
                }
                else
                {
                    var tagInfo = new TAG_INFO(audio.sourceURL);
                    var _stream = Bass.BASS_StreamCreateURL(audio.sourceURL, 0, BASSFlag.BASS_DEFAULT, null, IntPtr.Zero);

                    string artist = "";
                    string title = "";

                    if (BassTags.BASS_TAG_GetFromURL(_stream, tagInfo))
                    {
                        artist = tagInfo.artist.ToString();
                        title = tagInfo.title.ToString();
                    }
                    else
                    {
                        continue;
                    }

                    string name;
                    if (artist == "" && title == "")
                    {
                        name = audio.sourceURL;
                    }
                    else if (artist == "" || title == "")
                    {
                        name = $"{artist}{title}";
                    }
                    else
                    {
                        name = $"{artist} / {title}";
                    }


                    int row = VisualPlaylist.Rows.Add(new object[]
                    {
                        name,
                        tagInfo.duration < TimeSpan.MaxValue.TotalSeconds ? TimeSpan.FromSeconds(tagInfo.duration).ToString(@"mm\:ss") : "radio"
                    });

                    VisualPlaylist.Rows[row].Tag = audio.sourceURL;


                }

            }

        }

        /// <summary>
        /// Переключение песни
        /// </summary>
        private void axWindowsMediaPlayer1_MediaChange(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {
            if (VisualPlaylist.SelectedRows.Count > 0)
            {
                int selected_index = VisualPlaylist.SelectedRows[0].Index;
                if (!Player.currentMedia.sourceURL.StartsWith("http"))
                {
                    if (Player.currentMedia.sourceURL != ((FileInfo)VisualPlaylist.Rows[selected_index].Tag).FullName)
                    {
                        VisualPlaylist.Rows[selected_index].Selected = false;
                        if (selected_index == VisualPlaylist.Rows.Count - 1)
                        {
                            VisualPlaylist.Rows[0].Selected = true;
                        }
                        else
                        {
                            VisualPlaylist.Rows[selected_index].Selected = true;
                        }
                    }
                }
                else
                {
                    if (Player.currentMedia.sourceURL != (string)VisualPlaylist.Rows[selected_index].Tag)
                    {
                        VisualPlaylist.Rows[selected_index].Selected = false;
                        if (selected_index == VisualPlaylist.Rows.Count - 1)
                        {
                            VisualPlaylist.Rows[0].Selected = true;
                        }
                        else
                        {
                            VisualPlaylist.Rows[selected_index].Selected = true;
                        }
                    }
                }

            }


            if(Player.currentMedia != null)
            {
                Music = Player.currentMedia.sourceURL;
            }

            tegChange();
        }

        /// <summary>
        /// настройка визуальных тегов
        /// </summary>
        private void tegChange()
        {
            if (!Music.StartsWith("http"))
            {
                file = TagLib.File.Create(Music);

                TagLabelTile.Text = file.Tag.Title ?? "";
                TagLabelArtist.Text = file.Tag.FirstPerformer ?? "";

                TagLabelAlbum.Text = file.Tag.Album ?? "";
                TagLabelAlbumArtist.Text = file.Tag.FirstAlbumArtist ?? "";

                TagLabelTrack.Text = file.Tag.Track.ToString() ?? "";
                TagLabelYear.Text = file.Tag.Year.ToString() ?? "";
                TagLabelStile.Text = file.Tag.FirstGenre ?? "";

                if (file.Tag.Pictures.Length != 0)
                {
                    MemoryStream ms = new MemoryStream(file.Tag.Pictures[0].Data.Data);
                    AlbumPictureBox.BackgroundImage = Image.FromStream(ms);
                }
                else
                {
                    AlbumPictureBox.BackgroundImage = Image.FromFile(@"C:\Users\шурик\source\repos\Media Player\Media Player\Assets\Default album icon.jpg");
                }

                if (Music.EndsWith(".mp3"))
                {
                    RatingStar.Visible = true;

                    TagLib.Id3v2.PopularimeterFrame frame = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)file.GetTag(TagLib.TagTypes.Id3v2), "Windows Media Player 9 Series", true);
                    RatingStar.Value = (float)stars.First(u => u.Value == frame.Rating).Key;
                }
                else
                {
                    RatingStar.Visible = false;
                }

            }
            else
            {
                tag_info = new TAG_INFO(Music);

                var _stream = Bass.BASS_StreamCreateURL(Music, 0, BASSFlag.BASS_DEFAULT, null, IntPtr.Zero);

                if (BassTags.BASS_TAG_GetFromURL(_stream, tag_info))
                {
                    TagLabelTile.Text = tag_info.title ?? "";
                    TagLabelArtist.Text = tag_info.artist ?? "";

                    TagLabelAlbum.Text = tag_info.album ?? "";
                    TagLabelAlbumArtist.Text = tag_info.albumartist ?? "";

                    TagLabelTrack.Text = tag_info.track ?? "";
                    TagLabelYear.Text = tag_info.year ?? "";
                    TagLabelStile.Text = tag_info.genre ?? "";

                    AlbumPictureBox.BackgroundImage = Image.FromFile(@"C:\Users\шурик\source\repos\Media Player\Media Player\Assets\Radio Album icon.png");
                }
            }

        }

        

        /// <summary>
        /// Выбор песни через плейлист
        /// </summary>
        private void bunifuDataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (!VisualPlaylist.Rows[e.RowIndex].Tag.ToString().StartsWith("http"))
            {
                FileInfo file = (FileInfo)VisualPlaylist.Rows[e.RowIndex].Tag;
                Music = file.FullName;
            }
            else
            {
                Music = VisualPlaylist.Rows[e.RowIndex].Tag.ToString();
            }




            Player.Ctlcontrols.currentItem = Player.currentPlaylist.Item[e.RowIndex];
            guna2ImageButtonPlay_Click(sender, e);
            tegChange();
        }

        private void guna2RatingStar1_ValueChanged(object sender, EventArgs e)
        {
            


        }

        private void FormPlayer_Load(object sender, EventArgs e)
        {



        }
        /// <summary>
        /// Отображение кнопки сохранения рейтинга
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guna2RatingStar1_Click(object sender, EventArgs e)
        {
            ButtonRatingSave.Visible = true;
        }
        /// <summary>
        /// Сохранение рейтинга
        /// </summary>
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            double currentPosition = Player.Ctlcontrols.currentPosition;
            TagLib.Id3v2.PopularimeterFrame frame = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)file.GetTag(TagLib.TagTypes.Id3v2), "Windows Media Player 9 Series", true);
            frame.Rating = (byte)stars[RatingStar.Value];
            Player.close();
            file.Save();
            ButtonRatingSave.Visible = false;
            Player.Ctlcontrols.play();
            Player.Ctlcontrols.currentPosition = currentPosition;
        }
        /// <summary>
        /// режим случайного воспроизведения
        /// </summary>
        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            Player.settings.setMode("shuffle", ToggleShuffle.Checked);

        }

        private void FormPlayer_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FormPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            M3uPlaylist m3UPlaylist = new M3uPlaylist();
            m3UPlaylist.IsExtended = true;
            for (int i = 0; i < Player.currentPlaylist.count; i++)
            {
                WMPLib.IWMPMedia audio = Player.currentPlaylist.Item[i];

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
            ButtonAdd.ContextMenuStrip.Show(ButtonAdd, new Point(0, 51));
        }
        /// <summary>
        /// Режим зацикливаного воспроизведения (Beta)
        /// </summary>
        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            Retry = ToggleLoop.Checked;
        }

        private void FullscreanButton_Click(object sender, EventArgs e)
        {
            Player.uiMode = "full";
            Player.fullScreen = true;
        }

        private void ButtonDEL_Click(object sender, EventArgs e)
        {
            ButtonDEL.ContextMenuStrip.Show(ButtonDEL, new Point(0, 51));
        }

        private void Player_Enter(object sender, EventArgs e)
        {

        }

        private void SongTimeSlider_ValueChanged(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs e)
        {

        }

        private void List_Playlist_SelectedIndexChanged(object sender, EventArgs e)
        {
             string playlist = (string)List_Playlist.SelectedItem;
            Player.currentPlaylist = Player.playlistCollection.getByName(playlist).Item(0);

            VisualPlaylist.Rows.Clear();
            playlist_init();
         
        }

        private void ButtonPlaylist_Next_Click(object sender, EventArgs e)
        {
            if(List_Playlist.SelectedIndex < List_Playlist.Items.Count - 1)
            {
                List_Playlist.SelectedIndex += 1;
            }
            else if (List_Playlist.SelectedIndex == List_Playlist.Items.Count - 1)
            {
                List_Playlist.SelectedIndex = 0;
            }
        }

        private void ButtonPrevious_playlist_Click(object sender, EventArgs e)
        {
            if (List_Playlist.SelectedIndex > 0)
            {
                List_Playlist.SelectedIndex -= 1;
            }
            else if (List_Playlist.SelectedIndex == 0)
            {
                List_Playlist.SelectedIndex = List_Playlist.Items.Count - 1;
            }
        }
    }
}

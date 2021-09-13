
namespace Media_Player
{
    partial class FormPlayer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlayer));
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.AlbumPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.RatingStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.ButtonPlay = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ButtonPause = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ButtonStop = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ButtonPrevious = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ButtonNext = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SongTimeSlider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.VolumeSlider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.ButtonEXIT = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ButtonHide = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SongTimeLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.SongLongTimeLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.NTagLabelAlbumArtist = new Bunifu.UI.WinForms.BunifuLabel();
            this.TagLabelTile = new Bunifu.UI.WinForms.BunifuLabel();
            this.NTagLabelTile = new Bunifu.UI.WinForms.BunifuLabel();
            this.NTagLabelArtist = new Bunifu.UI.WinForms.BunifuLabel();
            this.NTagLabelAlbum = new Bunifu.UI.WinForms.BunifuLabel();
            this.NTagLabelYear = new Bunifu.UI.WinForms.BunifuLabel();
            this.NTagLabelStile = new Bunifu.UI.WinForms.BunifuLabel();
            this.NTagLabelTrack = new Bunifu.UI.WinForms.BunifuLabel();
            this.TagLabelArtist = new Bunifu.UI.WinForms.BunifuLabel();
            this.TagLabelAlbum = new Bunifu.UI.WinForms.BunifuLabel();
            this.TagLabelYear = new Bunifu.UI.WinForms.BunifuLabel();
            this.TagLabelStile = new Bunifu.UI.WinForms.BunifuLabel();
            this.TagLabelTrack = new Bunifu.UI.WinForms.BunifuLabel();
            this.TagLabelAlbumArtist = new Bunifu.UI.WinForms.BunifuLabel();
            this.ButtonVideo = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ButtonInfo = new Guna.UI2.WinForms.Guna2ImageButton();
            this.openFileDialogPlay = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ButtonMute = new Guna.UI2.WinForms.Guna2ImageButton();
            this.VisualPlaylist = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Song = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatusLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.ButtonRatingSave = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ButtonAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ContextMenuAdd = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.toolStripMenuItemAddFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddPlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddLink = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonDEL = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ContextMenuDEL = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.toolStripMenuItemDelFromPlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelFromDisk = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemCleanPlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelPlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.ToggleShuffle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.ToggleLoop = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.PictureBoxShuffle = new Guna.UI2.WinForms.Guna2PictureBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.PictureBoxLoop = new Guna.UI2.WinForms.Guna2PictureBox();
            this.List_Playlist = new Bunifu.UI.WinForms.BunifuDropdown();
            this.ButtonPrevious_playlist = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ButtonPlaylist_Next = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SongLongTime = new Bunifu.UI.WinForms.BunifuLabel();
            this.FullscreanButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.openFileDialogPlaylists = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisualPlaylist)).BeginInit();
            this.panel1.SuspendLayout();
            this.ContextMenuAdd.SuspendLayout();
            this.ContextMenuDEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLoop)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 50;
            this.Elipse.TargetControl = this;
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(12, 188);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(826, 300);
            this.Player.TabIndex = 0;
            this.Player.Visible = false;
            this.Player.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.axWindowsMediaPlayer1_MediaChange);
            this.Player.Enter += new System.EventHandler(this.Player_Enter);
            // 
            // AlbumPictureBox
            // 
            this.AlbumPictureBox.BackColor = System.Drawing.Color.Black;
            this.AlbumPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AlbumPictureBox.BackgroundImage")));
            this.AlbumPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AlbumPictureBox.FillColor = System.Drawing.Color.Transparent;
            this.AlbumPictureBox.ImageRotate = 0F;
            this.AlbumPictureBox.Location = new System.Drawing.Point(688, 338);
            this.AlbumPictureBox.Name = "AlbumPictureBox";
            this.AlbumPictureBox.ShadowDecoration.Parent = this.AlbumPictureBox;
            this.AlbumPictureBox.Size = new System.Drawing.Size(150, 150);
            this.AlbumPictureBox.TabIndex = 18;
            this.AlbumPictureBox.TabStop = false;
            // 
            // RatingStar
            // 
            this.RatingStar.BackColor = System.Drawing.Color.Transparent;
            this.RatingStar.Location = new System.Drawing.Point(688, 304);
            this.RatingStar.Name = "RatingStar";
            this.RatingStar.Size = new System.Drawing.Size(150, 28);
            this.RatingStar.TabIndex = 19;
            this.RatingStar.ValueChanged += new System.EventHandler(this.guna2RatingStar1_ValueChanged);
            this.RatingStar.Click += new System.EventHandler(this.guna2RatingStar1_Click);
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPlay.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonPlay.CheckedState.Parent = this.ButtonPlay;
            this.ButtonPlay.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image24")));
            this.ButtonPlay.HoverState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Vertical;
            this.ButtonPlay.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonPlay.HoverState.Parent = this.ButtonPlay;
            this.ButtonPlay.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPlay.Image")));
            this.ButtonPlay.ImageOffset = new System.Drawing.Point(0, 0);
            this.ButtonPlay.ImageRotate = 0F;
            this.ButtonPlay.ImageSize = new System.Drawing.Size(58, 58);
            this.ButtonPlay.IndicateFocus = true;
            this.ButtonPlay.Location = new System.Drawing.Point(12, 92);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image25")));
            this.ButtonPlay.PressedState.ImageSize = new System.Drawing.Size(115, 115);
            this.ButtonPlay.PressedState.Parent = this.ButtonPlay;
            this.ButtonPlay.ShadowDecoration.Parent = this.ButtonPlay;
            this.ButtonPlay.Size = new System.Drawing.Size(72, 75);
            this.ButtonPlay.TabIndex = 20;
            this.ButtonPlay.Click += new System.EventHandler(this.guna2ImageButtonPlay_Click);
            // 
            // ButtonPause
            // 
            this.ButtonPause.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPause.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonPause.CheckedState.Parent = this.ButtonPause;
            this.ButtonPause.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image22")));
            this.ButtonPause.HoverState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Vertical;
            this.ButtonPause.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonPause.HoverState.Parent = this.ButtonPause;
            this.ButtonPause.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPause.Image")));
            this.ButtonPause.ImageOffset = new System.Drawing.Point(0, 0);
            this.ButtonPause.ImageRotate = 0F;
            this.ButtonPause.ImageSize = new System.Drawing.Size(58, 58);
            this.ButtonPause.IndicateFocus = true;
            this.ButtonPause.Location = new System.Drawing.Point(90, 92);
            this.ButtonPause.Name = "ButtonPause";
            this.ButtonPause.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image23")));
            this.ButtonPause.PressedState.ImageSize = new System.Drawing.Size(115, 115);
            this.ButtonPause.PressedState.Parent = this.ButtonPause;
            this.ButtonPause.ShadowDecoration.Parent = this.ButtonPause;
            this.ButtonPause.Size = new System.Drawing.Size(72, 75);
            this.ButtonPause.TabIndex = 21;
            this.ButtonPause.Click += new System.EventHandler(this.guna2ImageButtonPause_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.BackColor = System.Drawing.Color.Transparent;
            this.ButtonStop.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonStop.CheckedState.Parent = this.ButtonStop;
            this.ButtonStop.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image20")));
            this.ButtonStop.HoverState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Vertical;
            this.ButtonStop.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonStop.HoverState.Parent = this.ButtonStop;
            this.ButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("ButtonStop.Image")));
            this.ButtonStop.ImageOffset = new System.Drawing.Point(0, 0);
            this.ButtonStop.ImageRotate = 0F;
            this.ButtonStop.ImageSize = new System.Drawing.Size(58, 58);
            this.ButtonStop.IndicateFocus = true;
            this.ButtonStop.Location = new System.Drawing.Point(168, 92);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image21")));
            this.ButtonStop.PressedState.ImageSize = new System.Drawing.Size(115, 115);
            this.ButtonStop.PressedState.Parent = this.ButtonStop;
            this.ButtonStop.ShadowDecoration.Parent = this.ButtonStop;
            this.ButtonStop.Size = new System.Drawing.Size(72, 75);
            this.ButtonStop.TabIndex = 22;
            this.ButtonStop.Click += new System.EventHandler(this.guna2ImageButtonStop_Click);
            // 
            // ButtonPrevious
            // 
            this.ButtonPrevious.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPrevious.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonPrevious.CheckedState.Parent = this.ButtonPrevious;
            this.ButtonPrevious.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image18")));
            this.ButtonPrevious.HoverState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Vertical;
            this.ButtonPrevious.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonPrevious.HoverState.Parent = this.ButtonPrevious;
            this.ButtonPrevious.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPrevious.Image")));
            this.ButtonPrevious.ImageOffset = new System.Drawing.Point(0, 0);
            this.ButtonPrevious.ImageRotate = 0F;
            this.ButtonPrevious.ImageSize = new System.Drawing.Size(58, 58);
            this.ButtonPrevious.IndicateFocus = true;
            this.ButtonPrevious.Location = new System.Drawing.Point(246, 92);
            this.ButtonPrevious.Name = "ButtonPrevious";
            this.ButtonPrevious.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image19")));
            this.ButtonPrevious.PressedState.ImageSize = new System.Drawing.Size(115, 115);
            this.ButtonPrevious.PressedState.Parent = this.ButtonPrevious;
            this.ButtonPrevious.ShadowDecoration.Parent = this.ButtonPrevious;
            this.ButtonPrevious.Size = new System.Drawing.Size(72, 75);
            this.ButtonPrevious.TabIndex = 23;
            this.ButtonPrevious.Click += new System.EventHandler(this.guna2ImageButtonLeft_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.BackColor = System.Drawing.Color.Transparent;
            this.ButtonNext.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonNext.CheckedState.Parent = this.ButtonNext;
            this.ButtonNext.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image16")));
            this.ButtonNext.HoverState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Vertical;
            this.ButtonNext.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonNext.HoverState.Parent = this.ButtonNext;
            this.ButtonNext.Image = ((System.Drawing.Image)(resources.GetObject("ButtonNext.Image")));
            this.ButtonNext.ImageOffset = new System.Drawing.Point(0, 0);
            this.ButtonNext.ImageRotate = 0F;
            this.ButtonNext.ImageSize = new System.Drawing.Size(58, 58);
            this.ButtonNext.IndicateFocus = true;
            this.ButtonNext.Location = new System.Drawing.Point(324, 92);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image17")));
            this.ButtonNext.PressedState.ImageSize = new System.Drawing.Size(115, 115);
            this.ButtonNext.PressedState.Parent = this.ButtonNext;
            this.ButtonNext.ShadowDecoration.Parent = this.ButtonNext;
            this.ButtonNext.Size = new System.Drawing.Size(72, 75);
            this.ButtonNext.TabIndex = 24;
            this.ButtonNext.Click += new System.EventHandler(this.guna2ImageButtonRight_Click);
            // 
            // SongTimeSlider
            // 
            this.SongTimeSlider.AllowCursorChanges = true;
            this.SongTimeSlider.AllowHomeEndKeysDetection = false;
            this.SongTimeSlider.AllowIncrementalClickMoves = true;
            this.SongTimeSlider.AllowMouseDownEffects = false;
            this.SongTimeSlider.AllowMouseHoverEffects = false;
            this.SongTimeSlider.AllowScrollingAnimations = true;
            this.SongTimeSlider.AllowScrollKeysDetection = true;
            this.SongTimeSlider.AllowScrollOptionsMenu = true;
            this.SongTimeSlider.AllowShrinkingOnFocusLost = false;
            this.SongTimeSlider.BackColor = System.Drawing.Color.Transparent;
            this.SongTimeSlider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SongTimeSlider.BackgroundImage")));
            this.SongTimeSlider.BindingContainer = null;
            this.SongTimeSlider.BorderRadius = 2;
            this.SongTimeSlider.BorderThickness = 1;
            this.SongTimeSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SongTimeSlider.DrawThickBorder = false;
            this.SongTimeSlider.DurationBeforeShrink = 2000;
            this.SongTimeSlider.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.SongTimeSlider.LargeChange = 10;
            this.SongTimeSlider.Location = new System.Drawing.Point(12, 55);
            this.SongTimeSlider.Maximum = 100;
            this.SongTimeSlider.Minimum = 0;
            this.SongTimeSlider.MinimumSize = new System.Drawing.Size(0, 31);
            this.SongTimeSlider.MinimumThumbLength = 18;
            this.SongTimeSlider.Name = "SongTimeSlider";
            this.SongTimeSlider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.SongTimeSlider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.SongTimeSlider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.SongTimeSlider.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.SongTimeSlider.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.SongTimeSlider.ShrinkSizeLimit = 3;
            this.SongTimeSlider.Size = new System.Drawing.Size(826, 31);
            this.SongTimeSlider.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.SongTimeSlider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.SongTimeSlider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.SongTimeSlider.SmallChange = 1;
            this.SongTimeSlider.TabIndex = 26;
            this.SongTimeSlider.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.SongTimeSlider.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.SongTimeSlider.ThumbLength = 81;
            this.SongTimeSlider.ThumbMargin = 1;
            this.SongTimeSlider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.SongTimeSlider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.SongTimeSlider.Value = 0;
            this.SongTimeSlider.ValueChanged += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs>(this.SongTimeSlider_ValueChanged);
            this.SongTimeSlider.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.bunifuHSliderSongTime_Scroll);
            // 
            // VolumeSlider
            // 
            this.VolumeSlider.AllowCursorChanges = true;
            this.VolumeSlider.AllowHomeEndKeysDetection = false;
            this.VolumeSlider.AllowIncrementalClickMoves = true;
            this.VolumeSlider.AllowMouseDownEffects = false;
            this.VolumeSlider.AllowMouseHoverEffects = false;
            this.VolumeSlider.AllowScrollingAnimations = true;
            this.VolumeSlider.AllowScrollKeysDetection = true;
            this.VolumeSlider.AllowScrollOptionsMenu = true;
            this.VolumeSlider.AllowShrinkingOnFocusLost = false;
            this.VolumeSlider.BackColor = System.Drawing.Color.Transparent;
            this.VolumeSlider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VolumeSlider.BackgroundImage")));
            this.VolumeSlider.BindingContainer = null;
            this.VolumeSlider.BorderRadius = 2;
            this.VolumeSlider.BorderThickness = 1;
            this.VolumeSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VolumeSlider.DrawThickBorder = false;
            this.VolumeSlider.DurationBeforeShrink = 2000;
            this.VolumeSlider.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.VolumeSlider.LargeChange = 10;
            this.VolumeSlider.Location = new System.Drawing.Point(638, 92);
            this.VolumeSlider.Maximum = 100;
            this.VolumeSlider.Minimum = 0;
            this.VolumeSlider.MinimumSize = new System.Drawing.Size(0, 31);
            this.VolumeSlider.MinimumThumbLength = 18;
            this.VolumeSlider.Name = "VolumeSlider";
            this.VolumeSlider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.VolumeSlider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.VolumeSlider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.VolumeSlider.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.VolumeSlider.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.VolumeSlider.ShrinkSizeLimit = 3;
            this.VolumeSlider.Size = new System.Drawing.Size(200, 31);
            this.VolumeSlider.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.VolumeSlider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.VolumeSlider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.VolumeSlider.SmallChange = 1;
            this.VolumeSlider.TabIndex = 27;
            this.VolumeSlider.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.VolumeSlider.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.VolumeSlider.ThumbLength = 19;
            this.VolumeSlider.ThumbMargin = 1;
            this.VolumeSlider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.VolumeSlider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.VolumeSlider.Value = 50;
            this.VolumeSlider.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.bunifuHSliderVolume_Scroll);
            // 
            // ButtonEXIT
            // 
            this.ButtonEXIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEXIT.Animated = true;
            this.ButtonEXIT.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEXIT.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonEXIT.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.ButtonEXIT.FillColor = System.Drawing.Color.Transparent;
            this.ButtonEXIT.HoverState.BorderColor = System.Drawing.Color.Red;
            this.ButtonEXIT.HoverState.FillColor = System.Drawing.Color.Red;
            this.ButtonEXIT.HoverState.IconColor = System.Drawing.Color.White;
            this.ButtonEXIT.HoverState.Parent = this.ButtonEXIT;
            this.ButtonEXIT.IconColor = System.Drawing.Color.Red;
            this.ButtonEXIT.Location = new System.Drawing.Point(1122, 0);
            this.ButtonEXIT.Name = "ButtonEXIT";
            this.ButtonEXIT.PressedColor = System.Drawing.Color.Red;
            this.ButtonEXIT.ShadowDecoration.Parent = this.ButtonEXIT;
            this.ButtonEXIT.Size = new System.Drawing.Size(45, 29);
            this.ButtonEXIT.TabIndex = 28;
            // 
            // ButtonHide
            // 
            this.ButtonHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonHide.BackColor = System.Drawing.Color.Transparent;
            this.ButtonHide.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.ButtonHide.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ButtonHide.FillColor = System.Drawing.Color.Transparent;
            this.ButtonHide.HoverState.FillColor = System.Drawing.Color.Gray;
            this.ButtonHide.HoverState.IconColor = System.Drawing.Color.White;
            this.ButtonHide.HoverState.Parent = this.ButtonHide;
            this.ButtonHide.IconColor = System.Drawing.Color.White;
            this.ButtonHide.Location = new System.Drawing.Point(1088, 0);
            this.ButtonHide.Name = "ButtonHide";
            this.ButtonHide.ShadowDecoration.Parent = this.ButtonHide;
            this.ButtonHide.Size = new System.Drawing.Size(28, 29);
            this.ButtonHide.TabIndex = 29;
            // 
            // SongTimeLabel
            // 
            this.SongTimeLabel.AllowParentOverrides = false;
            this.SongTimeLabel.AutoEllipsis = false;
            this.SongTimeLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.SongTimeLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.SongTimeLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SongTimeLabel.ForeColor = System.Drawing.Color.White;
            this.SongTimeLabel.Location = new System.Drawing.Point(12, 34);
            this.SongTimeLabel.Name = "SongTimeLabel";
            this.SongTimeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SongTimeLabel.Size = new System.Drawing.Size(25, 17);
            this.SongTimeLabel.TabIndex = 30;
            this.SongTimeLabel.Text = "0:00";
            this.SongTimeLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.SongTimeLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // SongLongTimeLabel
            // 
            this.SongLongTimeLabel.AllowParentOverrides = false;
            this.SongLongTimeLabel.AutoEllipsis = false;
            this.SongLongTimeLabel.AutoSize = false;
            this.SongLongTimeLabel.CursorType = null;
            this.SongLongTimeLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SongLongTimeLabel.ForeColor = System.Drawing.Color.White;
            this.SongLongTimeLabel.Location = new System.Drawing.Point(770, 35);
            this.SongLongTimeLabel.Name = "SongLongTimeLabel";
            this.SongLongTimeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SongLongTimeLabel.Size = new System.Drawing.Size(59, 17);
            this.SongLongTimeLabel.TabIndex = 31;
            this.SongLongTimeLabel.Text = "0:00";
            this.SongLongTimeLabel.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.SongLongTimeLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // NTagLabelAlbumArtist
            // 
            this.NTagLabelAlbumArtist.AllowParentOverrides = false;
            this.NTagLabelAlbumArtist.AutoEllipsis = false;
            this.NTagLabelAlbumArtist.Cursor = System.Windows.Forms.Cursors.Default;
            this.NTagLabelAlbumArtist.CursorType = System.Windows.Forms.Cursors.Default;
            this.NTagLabelAlbumArtist.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NTagLabelAlbumArtist.ForeColor = System.Drawing.Color.White;
            this.NTagLabelAlbumArtist.Location = new System.Drawing.Point(12, 471);
            this.NTagLabelAlbumArtist.Name = "NTagLabelAlbumArtist";
            this.NTagLabelAlbumArtist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NTagLabelAlbumArtist.Size = new System.Drawing.Size(135, 17);
            this.NTagLabelAlbumArtist.TabIndex = 32;
            this.NTagLabelAlbumArtist.Text = "Исполнитель альбома:";
            this.NTagLabelAlbumArtist.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.NTagLabelAlbumArtist.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TagLabelTile
            // 
            this.TagLabelTile.AllowParentOverrides = false;
            this.TagLabelTile.AutoEllipsis = false;
            this.TagLabelTile.AutoSize = false;
            this.TagLabelTile.CursorType = null;
            this.TagLabelTile.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TagLabelTile.ForeColor = System.Drawing.Color.White;
            this.TagLabelTile.Location = new System.Drawing.Point(71, 333);
            this.TagLabelTile.Name = "TagLabelTile";
            this.TagLabelTile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TagLabelTile.Size = new System.Drawing.Size(611, 17);
            this.TagLabelTile.TabIndex = 33;
            this.TagLabelTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.TagLabelTile.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // NTagLabelTile
            // 
            this.NTagLabelTile.AllowParentOverrides = false;
            this.NTagLabelTile.AutoEllipsis = false;
            this.NTagLabelTile.CursorType = null;
            this.NTagLabelTile.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NTagLabelTile.ForeColor = System.Drawing.Color.White;
            this.NTagLabelTile.Location = new System.Drawing.Point(12, 333);
            this.NTagLabelTile.Name = "NTagLabelTile";
            this.NTagLabelTile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NTagLabelTile.Size = new System.Drawing.Size(57, 17);
            this.NTagLabelTile.TabIndex = 38;
            this.NTagLabelTile.Text = "Название:";
            this.NTagLabelTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.NTagLabelTile.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // NTagLabelArtist
            // 
            this.NTagLabelArtist.AllowParentOverrides = false;
            this.NTagLabelArtist.AutoEllipsis = false;
            this.NTagLabelArtist.CursorType = null;
            this.NTagLabelArtist.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NTagLabelArtist.ForeColor = System.Drawing.Color.White;
            this.NTagLabelArtist.Location = new System.Drawing.Point(12, 356);
            this.NTagLabelArtist.Name = "NTagLabelArtist";
            this.NTagLabelArtist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NTagLabelArtist.Size = new System.Drawing.Size(83, 17);
            this.NTagLabelArtist.TabIndex = 39;
            this.NTagLabelArtist.Text = "Исполнитель:";
            this.NTagLabelArtist.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.NTagLabelArtist.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // NTagLabelAlbum
            // 
            this.NTagLabelAlbum.AllowParentOverrides = false;
            this.NTagLabelAlbum.AutoEllipsis = false;
            this.NTagLabelAlbum.CursorType = null;
            this.NTagLabelAlbum.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NTagLabelAlbum.ForeColor = System.Drawing.Color.White;
            this.NTagLabelAlbum.Location = new System.Drawing.Point(12, 379);
            this.NTagLabelAlbum.Name = "NTagLabelAlbum";
            this.NTagLabelAlbum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NTagLabelAlbum.Size = new System.Drawing.Size(48, 17);
            this.NTagLabelAlbum.TabIndex = 40;
            this.NTagLabelAlbum.Text = "Альбом:";
            this.NTagLabelAlbum.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.NTagLabelAlbum.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // NTagLabelYear
            // 
            this.NTagLabelYear.AllowParentOverrides = false;
            this.NTagLabelYear.AutoEllipsis = false;
            this.NTagLabelYear.CursorType = null;
            this.NTagLabelYear.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NTagLabelYear.ForeColor = System.Drawing.Color.White;
            this.NTagLabelYear.Location = new System.Drawing.Point(12, 402);
            this.NTagLabelYear.Name = "NTagLabelYear";
            this.NTagLabelYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NTagLabelYear.Size = new System.Drawing.Size(25, 17);
            this.NTagLabelYear.TabIndex = 41;
            this.NTagLabelYear.Text = "Год:";
            this.NTagLabelYear.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.NTagLabelYear.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // NTagLabelStile
            // 
            this.NTagLabelStile.AllowParentOverrides = false;
            this.NTagLabelStile.AutoEllipsis = false;
            this.NTagLabelStile.CursorType = null;
            this.NTagLabelStile.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NTagLabelStile.ForeColor = System.Drawing.Color.White;
            this.NTagLabelStile.Location = new System.Drawing.Point(12, 425);
            this.NTagLabelStile.Name = "NTagLabelStile";
            this.NTagLabelStile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NTagLabelStile.Size = new System.Drawing.Size(33, 17);
            this.NTagLabelStile.TabIndex = 42;
            this.NTagLabelStile.Text = "Жанр:";
            this.NTagLabelStile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.NTagLabelStile.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // NTagLabelTrack
            // 
            this.NTagLabelTrack.AllowParentOverrides = false;
            this.NTagLabelTrack.AutoEllipsis = false;
            this.NTagLabelTrack.CursorType = null;
            this.NTagLabelTrack.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NTagLabelTrack.ForeColor = System.Drawing.Color.White;
            this.NTagLabelTrack.Location = new System.Drawing.Point(12, 448);
            this.NTagLabelTrack.Name = "NTagLabelTrack";
            this.NTagLabelTrack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NTagLabelTrack.Size = new System.Drawing.Size(41, 17);
            this.NTagLabelTrack.TabIndex = 43;
            this.NTagLabelTrack.Text = "Номер:";
            this.NTagLabelTrack.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.NTagLabelTrack.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TagLabelArtist
            // 
            this.TagLabelArtist.AllowParentOverrides = false;
            this.TagLabelArtist.AutoEllipsis = false;
            this.TagLabelArtist.AutoSize = false;
            this.TagLabelArtist.CursorType = null;
            this.TagLabelArtist.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TagLabelArtist.ForeColor = System.Drawing.Color.White;
            this.TagLabelArtist.Location = new System.Drawing.Point(97, 356);
            this.TagLabelArtist.Name = "TagLabelArtist";
            this.TagLabelArtist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TagLabelArtist.Size = new System.Drawing.Size(585, 17);
            this.TagLabelArtist.TabIndex = 44;
            this.TagLabelArtist.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.TagLabelArtist.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TagLabelAlbum
            // 
            this.TagLabelAlbum.AllowParentOverrides = false;
            this.TagLabelAlbum.AutoEllipsis = false;
            this.TagLabelAlbum.AutoSize = false;
            this.TagLabelAlbum.CursorType = null;
            this.TagLabelAlbum.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TagLabelAlbum.ForeColor = System.Drawing.Color.White;
            this.TagLabelAlbum.Location = new System.Drawing.Point(62, 379);
            this.TagLabelAlbum.Name = "TagLabelAlbum";
            this.TagLabelAlbum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TagLabelAlbum.Size = new System.Drawing.Size(620, 17);
            this.TagLabelAlbum.TabIndex = 45;
            this.TagLabelAlbum.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.TagLabelAlbum.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TagLabelYear
            // 
            this.TagLabelYear.AllowParentOverrides = false;
            this.TagLabelYear.AutoEllipsis = false;
            this.TagLabelYear.AutoSize = false;
            this.TagLabelYear.CursorType = null;
            this.TagLabelYear.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TagLabelYear.ForeColor = System.Drawing.Color.White;
            this.TagLabelYear.Location = new System.Drawing.Point(39, 402);
            this.TagLabelYear.Name = "TagLabelYear";
            this.TagLabelYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TagLabelYear.Size = new System.Drawing.Size(643, 17);
            this.TagLabelYear.TabIndex = 46;
            this.TagLabelYear.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.TagLabelYear.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TagLabelStile
            // 
            this.TagLabelStile.AllowParentOverrides = false;
            this.TagLabelStile.AutoEllipsis = false;
            this.TagLabelStile.AutoSize = false;
            this.TagLabelStile.CursorType = null;
            this.TagLabelStile.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TagLabelStile.ForeColor = System.Drawing.Color.White;
            this.TagLabelStile.Location = new System.Drawing.Point(47, 425);
            this.TagLabelStile.Name = "TagLabelStile";
            this.TagLabelStile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TagLabelStile.Size = new System.Drawing.Size(635, 17);
            this.TagLabelStile.TabIndex = 47;
            this.TagLabelStile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.TagLabelStile.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TagLabelTrack
            // 
            this.TagLabelTrack.AllowParentOverrides = false;
            this.TagLabelTrack.AutoEllipsis = false;
            this.TagLabelTrack.AutoSize = false;
            this.TagLabelTrack.CursorType = null;
            this.TagLabelTrack.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TagLabelTrack.ForeColor = System.Drawing.Color.White;
            this.TagLabelTrack.Location = new System.Drawing.Point(55, 448);
            this.TagLabelTrack.Name = "TagLabelTrack";
            this.TagLabelTrack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TagLabelTrack.Size = new System.Drawing.Size(627, 17);
            this.TagLabelTrack.TabIndex = 48;
            this.TagLabelTrack.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.TagLabelTrack.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TagLabelAlbumArtist
            // 
            this.TagLabelAlbumArtist.AllowParentOverrides = false;
            this.TagLabelAlbumArtist.AutoEllipsis = false;
            this.TagLabelAlbumArtist.AutoSize = false;
            this.TagLabelAlbumArtist.CursorType = null;
            this.TagLabelAlbumArtist.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TagLabelAlbumArtist.ForeColor = System.Drawing.Color.White;
            this.TagLabelAlbumArtist.Location = new System.Drawing.Point(149, 471);
            this.TagLabelAlbumArtist.Name = "TagLabelAlbumArtist";
            this.TagLabelAlbumArtist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TagLabelAlbumArtist.Size = new System.Drawing.Size(533, 17);
            this.TagLabelAlbumArtist.TabIndex = 49;
            this.TagLabelAlbumArtist.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.TagLabelAlbumArtist.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ButtonVideo
            // 
            this.ButtonVideo.BackColor = System.Drawing.Color.Transparent;
            this.ButtonVideo.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonVideo.CheckedState.Parent = this.ButtonVideo;
            this.ButtonVideo.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image14")));
            this.ButtonVideo.HoverState.ImageSize = new System.Drawing.Size(44, 44);
            this.ButtonVideo.HoverState.Parent = this.ButtonVideo;
            this.ButtonVideo.Image = ((System.Drawing.Image)(resources.GetObject("ButtonVideo.Image")));
            this.ButtonVideo.ImageOffset = new System.Drawing.Point(0, 0);
            this.ButtonVideo.ImageRotate = 0F;
            this.ButtonVideo.ImageSize = new System.Drawing.Size(38, 38);
            this.ButtonVideo.IndicateFocus = true;
            this.ButtonVideo.Location = new System.Drawing.Point(742, 116);
            this.ButtonVideo.Name = "ButtonVideo";
            this.ButtonVideo.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image15")));
            this.ButtonVideo.PressedState.ImageSize = new System.Drawing.Size(105, 105);
            this.ButtonVideo.PressedState.Parent = this.ButtonVideo;
            this.ButtonVideo.ShadowDecoration.Parent = this.ButtonVideo;
            this.ButtonVideo.Size = new System.Drawing.Size(45, 51);
            this.ButtonVideo.TabIndex = 51;
            this.ButtonVideo.Click += new System.EventHandler(this.guna2ImageButtonVideo_Click);
            // 
            // ButtonInfo
            // 
            this.ButtonInfo.BackColor = System.Drawing.Color.Transparent;
            this.ButtonInfo.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonInfo.CheckedState.Parent = this.ButtonInfo;
            this.ButtonInfo.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image12")));
            this.ButtonInfo.HoverState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.ButtonInfo.HoverState.ImageSize = new System.Drawing.Size(44, 44);
            this.ButtonInfo.HoverState.Parent = this.ButtonInfo;
            this.ButtonInfo.Image = ((System.Drawing.Image)(resources.GetObject("ButtonInfo.Image")));
            this.ButtonInfo.ImageOffset = new System.Drawing.Point(0, 0);
            this.ButtonInfo.ImageRotate = 0F;
            this.ButtonInfo.ImageSize = new System.Drawing.Size(38, 38);
            this.ButtonInfo.IndicateFocus = true;
            this.ButtonInfo.Location = new System.Drawing.Point(793, 116);
            this.ButtonInfo.Name = "ButtonInfo";
            this.ButtonInfo.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image13")));
            this.ButtonInfo.PressedState.ImageSize = new System.Drawing.Size(105, 105);
            this.ButtonInfo.PressedState.Parent = this.ButtonInfo;
            this.ButtonInfo.ShadowDecoration.Parent = this.ButtonInfo;
            this.ButtonInfo.Size = new System.Drawing.Size(45, 51);
            this.ButtonInfo.TabIndex = 52;
            this.ButtonInfo.Click += new System.EventHandler(this.guna2ImageButtonInfo_Click);
            // 
            // openFileDialogPlay
            // 
            this.openFileDialogPlay.Multiselect = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this;
            this.DragControl.Vertical = true;
            // 
            // ButtonMute
            // 
            this.ButtonMute.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMute.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonMute.CheckedState.Parent = this.ButtonMute;
            this.ButtonMute.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image10")));
            this.ButtonMute.HoverState.ImageSize = new System.Drawing.Size(44, 44);
            this.ButtonMute.HoverState.Parent = this.ButtonMute;
            this.ButtonMute.Image = ((System.Drawing.Image)(resources.GetObject("ButtonMute.Image")));
            this.ButtonMute.ImageOffset = new System.Drawing.Point(0, 0);
            this.ButtonMute.ImageRotate = 0F;
            this.ButtonMute.ImageSize = new System.Drawing.Size(38, 38);
            this.ButtonMute.IndicateFocus = true;
            this.ButtonMute.Location = new System.Drawing.Point(587, 82);
            this.ButtonMute.Name = "ButtonMute";
            this.ButtonMute.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image11")));
            this.ButtonMute.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.ButtonMute.PressedState.Parent = this.ButtonMute;
            this.ButtonMute.ShadowDecoration.Parent = this.ButtonMute;
            this.ButtonMute.Size = new System.Drawing.Size(45, 51);
            this.ButtonMute.TabIndex = 53;
            this.ButtonMute.Click += new System.EventHandler(this.guna2ImageButton_Click);
            // 
            // VisualPlaylist
            // 
            this.VisualPlaylist.AllowCustomTheming = false;
            this.VisualPlaylist.AllowDrop = true;
            this.VisualPlaylist.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.VisualPlaylist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.VisualPlaylist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VisualPlaylist.BackgroundColor = System.Drawing.Color.Black;
            this.VisualPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VisualPlaylist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.VisualPlaylist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VisualPlaylist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.VisualPlaylist.ColumnHeadersHeight = 40;
            this.VisualPlaylist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Song,
            this.SongTime});
            this.VisualPlaylist.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.VisualPlaylist.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.VisualPlaylist.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.VisualPlaylist.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.VisualPlaylist.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.VisualPlaylist.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.VisualPlaylist.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.VisualPlaylist.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.VisualPlaylist.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.VisualPlaylist.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.VisualPlaylist.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.VisualPlaylist.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.VisualPlaylist.CurrentTheme.Name = null;
            this.VisualPlaylist.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.VisualPlaylist.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.VisualPlaylist.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.VisualPlaylist.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.VisualPlaylist.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VisualPlaylist.DefaultCellStyle = dataGridViewCellStyle3;
            this.VisualPlaylist.EnableHeadersVisualStyles = false;
            this.VisualPlaylist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.VisualPlaylist.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.VisualPlaylist.HeaderBgColor = System.Drawing.Color.Empty;
            this.VisualPlaylist.HeaderForeColor = System.Drawing.Color.White;
            this.VisualPlaylist.Location = new System.Drawing.Point(852, 34);
            this.VisualPlaylist.Name = "VisualPlaylist";
            this.VisualPlaylist.ReadOnly = true;
            this.VisualPlaylist.RowHeadersVisible = false;
            this.VisualPlaylist.RowTemplate.Height = 40;
            this.VisualPlaylist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VisualPlaylist.Size = new System.Drawing.Size(307, 417);
            this.VisualPlaylist.TabIndex = 54;
            this.VisualPlaylist.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.VisualPlaylist.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.bunifuDataGridView1_CellMouseClick);
            this.VisualPlaylist.DragDrop += new System.Windows.Forms.DragEventHandler(this.GridViewDragDrop);
            this.VisualPlaylist.DragEnter += new System.Windows.Forms.DragEventHandler(this.GridViewDragEnter);
            // 
            // Song
            // 
            this.Song.FillWeight = 152.2843F;
            this.Song.HeaderText = "Исполниель / Назвавние";
            this.Song.Name = "Song";
            this.Song.ReadOnly = true;
            // 
            // SongTime
            // 
            this.SongTime.FillWeight = 47.71573F;
            this.SongTime.HeaderText = "Время";
            this.SongTime.Name = "SongTime";
            this.SongTime.ReadOnly = true;
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.AllowParentOverrides = false;
            this.StatusLabel1.AutoEllipsis = false;
            this.StatusLabel1.AutoSize = false;
            this.StatusLabel1.CursorType = null;
            this.StatusLabel1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel1.ForeColor = System.Drawing.Color.White;
            this.StatusLabel1.Location = new System.Drawing.Point(0, 0);
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StatusLabel1.Size = new System.Drawing.Size(741, 21);
            this.StatusLabel1.TabIndex = 56;
            this.StatusLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.StatusLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.StatusLabel2);
            this.panel1.Controls.Add(this.StatusLabel1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 21);
            this.panel1.TabIndex = 57;
            // 
            // StatusLabel2
            // 
            this.StatusLabel2.AllowParentOverrides = false;
            this.StatusLabel2.AutoEllipsis = false;
            this.StatusLabel2.AutoSize = false;
            this.StatusLabel2.CursorType = null;
            this.StatusLabel2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel2.ForeColor = System.Drawing.Color.White;
            this.StatusLabel2.Location = new System.Drawing.Point(0, 0);
            this.StatusLabel2.Name = "StatusLabel2";
            this.StatusLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StatusLabel2.Size = new System.Drawing.Size(741, 21);
            this.StatusLabel2.TabIndex = 57;
            this.StatusLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.StatusLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.StatusLabel2.Visible = false;
            // 
            // ButtonRatingSave
            // 
            this.ButtonRatingSave.BackColor = System.Drawing.Color.Transparent;
            this.ButtonRatingSave.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonRatingSave.CheckedState.Parent = this.ButtonRatingSave;
            this.ButtonRatingSave.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image26")));
            this.ButtonRatingSave.HoverState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.ButtonRatingSave.HoverState.ImageSize = new System.Drawing.Size(44, 44);
            this.ButtonRatingSave.HoverState.Parent = this.ButtonRatingSave;
            this.ButtonRatingSave.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRatingSave.Image")));
            this.ButtonRatingSave.ImageOffset = new System.Drawing.Point(0, 0);
            this.ButtonRatingSave.ImageRotate = 0F;
            this.ButtonRatingSave.ImageSize = new System.Drawing.Size(35, 35);
            this.ButtonRatingSave.IndicateFocus = true;
            this.ButtonRatingSave.Location = new System.Drawing.Point(793, 247);
            this.ButtonRatingSave.Name = "ButtonRatingSave";
            this.ButtonRatingSave.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image27")));
            this.ButtonRatingSave.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.ButtonRatingSave.PressedState.Parent = this.ButtonRatingSave;
            this.ButtonRatingSave.ShadowDecoration.Parent = this.ButtonRatingSave;
            this.ButtonRatingSave.Size = new System.Drawing.Size(45, 51);
            this.ButtonRatingSave.TabIndex = 58;
            this.ButtonRatingSave.Visible = false;
            this.ButtonRatingSave.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAdd.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonAdd.CheckedState.Parent = this.ButtonAdd;
            this.ButtonAdd.ContextMenuStrip = this.ContextMenuAdd;
            this.ButtonAdd.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image8")));
            this.ButtonAdd.HoverState.ImageSize = new System.Drawing.Size(44, 44);
            this.ButtonAdd.HoverState.Parent = this.ButtonAdd;
            this.ButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAdd.Image")));
            this.ButtonAdd.ImageOffset = new System.Drawing.Point(0, 0);
            this.ButtonAdd.ImageRotate = 0F;
            this.ButtonAdd.ImageSize = new System.Drawing.Size(38, 38);
            this.ButtonAdd.IndicateFocus = true;
            this.ButtonAdd.Location = new System.Drawing.Point(852, 448);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image9")));
            this.ButtonAdd.PressedState.ImageSize = new System.Drawing.Size(105, 105);
            this.ButtonAdd.PressedState.Parent = this.ButtonAdd;
            this.ButtonAdd.ShadowDecoration.Parent = this.ButtonAdd;
            this.ButtonAdd.Size = new System.Drawing.Size(45, 51);
            this.ButtonAdd.TabIndex = 59;
            this.ButtonAdd.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // ContextMenuAdd
            // 
            this.ContextMenuAdd.BackColor = System.Drawing.Color.Black;
            this.ContextMenuAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddFile,
            this.toolStripMenuItemAddFolder,
            this.toolStripMenuItemAddPlaylist,
            this.toolStripMenuItemAddLink});
            this.ContextMenuAdd.Name = "guna2ContextMenuStrip1";
            this.ContextMenuAdd.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ContextMenuAdd.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.ContextMenuAdd.RenderStyle.ColorTable = null;
            this.ContextMenuAdd.RenderStyle.RoundedEdges = true;
            this.ContextMenuAdd.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.ContextMenuAdd.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ContextMenuAdd.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ContextMenuAdd.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.ContextMenuAdd.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ContextMenuAdd.Size = new System.Drawing.Size(212, 92);
            // 
            // toolStripMenuItemAddFile
            // 
            this.toolStripMenuItemAddFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripMenuItemAddFile.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemAddFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemAddFile.Image")));
            this.toolStripMenuItemAddFile.Name = "toolStripMenuItemAddFile";
            this.toolStripMenuItemAddFile.Size = new System.Drawing.Size(211, 22);
            this.toolStripMenuItemAddFile.Text = "Добавить фаил";
            // 
            // toolStripMenuItemAddFolder
            // 
            this.toolStripMenuItemAddFolder.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemAddFolder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemAddFolder.Image")));
            this.toolStripMenuItemAddFolder.Name = "toolStripMenuItemAddFolder";
            this.toolStripMenuItemAddFolder.Size = new System.Drawing.Size(211, 22);
            this.toolStripMenuItemAddFolder.Text = "Добавить папку";
            // 
            // toolStripMenuItemAddPlaylist
            // 
            this.toolStripMenuItemAddPlaylist.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemAddPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemAddPlaylist.Image")));
            this.toolStripMenuItemAddPlaylist.Name = "toolStripMenuItemAddPlaylist";
            this.toolStripMenuItemAddPlaylist.Size = new System.Drawing.Size(211, 22);
            this.toolStripMenuItemAddPlaylist.Text = "Добавить плейлист";
            // 
            // toolStripMenuItemAddLink
            // 
            this.toolStripMenuItemAddLink.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemAddLink.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemAddLink.Image")));
            this.toolStripMenuItemAddLink.Name = "toolStripMenuItemAddLink";
            this.toolStripMenuItemAddLink.Size = new System.Drawing.Size(211, 22);
            this.toolStripMenuItemAddLink.Text = "Добавить интернет фаил";
            // 
            // ButtonDEL
            // 
            this.ButtonDEL.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDEL.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonDEL.CheckedState.Parent = this.ButtonDEL;
            this.ButtonDEL.ContextMenuStrip = this.ContextMenuDEL;
            this.ButtonDEL.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.ButtonDEL.HoverState.ImageSize = new System.Drawing.Size(44, 44);
            this.ButtonDEL.HoverState.Parent = this.ButtonDEL;
            this.ButtonDEL.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDEL.Image")));
            this.ButtonDEL.ImageOffset = new System.Drawing.Point(0, 0);
            this.ButtonDEL.ImageRotate = 0F;
            this.ButtonDEL.ImageSize = new System.Drawing.Size(38, 38);
            this.ButtonDEL.IndicateFocus = true;
            this.ButtonDEL.Location = new System.Drawing.Point(903, 448);
            this.ButtonDEL.Name = "ButtonDEL";
            this.ButtonDEL.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image7")));
            this.ButtonDEL.PressedState.ImageSize = new System.Drawing.Size(105, 105);
            this.ButtonDEL.PressedState.Parent = this.ButtonDEL;
            this.ButtonDEL.ShadowDecoration.Parent = this.ButtonDEL;
            this.ButtonDEL.Size = new System.Drawing.Size(45, 51);
            this.ButtonDEL.TabIndex = 60;
            this.ButtonDEL.Click += new System.EventHandler(this.ButtonDEL_Click);
            // 
            // ContextMenuDEL
            // 
            this.ContextMenuDEL.BackColor = System.Drawing.Color.Black;
            this.ContextMenuDEL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDelFromPlaylist,
            this.toolStripMenuItemDelFromDisk,
            this.toolStripSeparator1,
            this.toolStripMenuItemCleanPlaylist,
            this.toolStripMenuItemDelPlaylist});
            this.ContextMenuDEL.Name = "guna2ContextMenuStripDel";
            this.ContextMenuDEL.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ContextMenuDEL.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.ContextMenuDEL.RenderStyle.ColorTable = null;
            this.ContextMenuDEL.RenderStyle.RoundedEdges = true;
            this.ContextMenuDEL.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.ContextMenuDEL.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ContextMenuDEL.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ContextMenuDEL.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.ContextMenuDEL.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ContextMenuDEL.Size = new System.Drawing.Size(195, 98);
            // 
            // toolStripMenuItemDelFromPlaylist
            // 
            this.toolStripMenuItemDelFromPlaylist.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemDelFromPlaylist.Image = global::Media_Player.Properties.Resources.Del_file_lite;
            this.toolStripMenuItemDelFromPlaylist.Name = "toolStripMenuItemDelFromPlaylist";
            this.toolStripMenuItemDelFromPlaylist.Size = new System.Drawing.Size(194, 22);
            this.toolStripMenuItemDelFromPlaylist.Text = "Удалить из плейлиста";
            // 
            // toolStripMenuItemDelFromDisk
            // 
            this.toolStripMenuItemDelFromDisk.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemDelFromDisk.Image = global::Media_Player.Properties.Resources.Del_file;
            this.toolStripMenuItemDelFromDisk.Name = "toolStripMenuItemDelFromDisk";
            this.toolStripMenuItemDelFromDisk.Size = new System.Drawing.Size(194, 22);
            this.toolStripMenuItemDelFromDisk.Text = "Удалить с диска";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // toolStripMenuItemCleanPlaylist
            // 
            this.toolStripMenuItemCleanPlaylist.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemCleanPlaylist.Image = global::Media_Player.Properties.Resources.Clear_playlist;
            this.toolStripMenuItemCleanPlaylist.Name = "toolStripMenuItemCleanPlaylist";
            this.toolStripMenuItemCleanPlaylist.Size = new System.Drawing.Size(194, 22);
            this.toolStripMenuItemCleanPlaylist.Text = "Очистить плейлист";
            // 
            // toolStripMenuItemDelPlaylist
            // 
            this.toolStripMenuItemDelPlaylist.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemDelPlaylist.Image = global::Media_Player.Properties.Resources.Del_Playlist;
            this.toolStripMenuItemDelPlaylist.Name = "toolStripMenuItemDelPlaylist";
            this.toolStripMenuItemDelPlaylist.Size = new System.Drawing.Size(194, 22);
            this.toolStripMenuItemDelPlaylist.Text = "Удалить плейлист";
            // 
            // ToggleShuffle
            // 
            this.ToggleShuffle.Animated = true;
            this.ToggleShuffle.AutoRoundedCorners = true;
            this.ToggleShuffle.BackColor = System.Drawing.Color.Transparent;
            this.ToggleShuffle.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.ToggleShuffle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ToggleShuffle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ToggleShuffle.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleShuffle.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleShuffle.CheckedState.Parent = this.ToggleShuffle;
            this.ToggleShuffle.Location = new System.Drawing.Point(413, 92);
            this.ToggleShuffle.Name = "ToggleShuffle";
            this.ToggleShuffle.ShadowDecoration.Parent = this.ToggleShuffle;
            this.ToggleShuffle.Size = new System.Drawing.Size(35, 20);
            this.ToggleShuffle.TabIndex = 62;
            this.ToggleShuffle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleShuffle.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleShuffle.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleShuffle.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleShuffle.UncheckedState.Parent = this.ToggleShuffle;
            this.ToggleShuffle.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // ToggleLoop
            // 
            this.ToggleLoop.Animated = true;
            this.ToggleLoop.AutoRoundedCorners = true;
            this.ToggleLoop.BackColor = System.Drawing.Color.Transparent;
            this.ToggleLoop.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.ToggleLoop.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ToggleLoop.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ToggleLoop.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleLoop.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleLoop.CheckedState.Parent = this.ToggleLoop;
            this.ToggleLoop.Location = new System.Drawing.Point(413, 138);
            this.ToggleLoop.Name = "ToggleLoop";
            this.ToggleLoop.ShadowDecoration.Parent = this.ToggleLoop;
            this.ToggleLoop.Size = new System.Drawing.Size(35, 20);
            this.ToggleLoop.TabIndex = 63;
            this.ToggleLoop.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleLoop.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleLoop.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleLoop.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleLoop.UncheckedState.Parent = this.ToggleLoop;
            this.ToggleLoop.UseTransparentBackground = true;
            this.ToggleLoop.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch2_CheckedChanged);
            // 
            // PictureBoxShuffle
            // 
            this.PictureBoxShuffle.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxShuffle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxShuffle.BackgroundImage")));
            this.PictureBoxShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxShuffle.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxShuffle.Image")));
            this.PictureBoxShuffle.ImageRotate = 0F;
            this.PictureBoxShuffle.Location = new System.Drawing.Point(454, 82);
            this.PictureBoxShuffle.Name = "PictureBoxShuffle";
            this.PictureBoxShuffle.ShadowDecoration.Parent = this.PictureBoxShuffle;
            this.PictureBoxShuffle.Size = new System.Drawing.Size(37, 41);
            this.PictureBoxShuffle.TabIndex = 64;
            this.PictureBoxShuffle.TabStop = false;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "выберете папку";
            this.folderBrowserDialog.SelectedPath = "C/";
            // 
            // PictureBoxLoop
            // 
            this.PictureBoxLoop.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxLoop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxLoop.BackgroundImage")));
            this.PictureBoxLoop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxLoop.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLoop.Image")));
            this.PictureBoxLoop.ImageRotate = 0F;
            this.PictureBoxLoop.Location = new System.Drawing.Point(454, 126);
            this.PictureBoxLoop.Name = "PictureBoxLoop";
            this.PictureBoxLoop.ShadowDecoration.Parent = this.PictureBoxLoop;
            this.PictureBoxLoop.Size = new System.Drawing.Size(37, 41);
            this.PictureBoxLoop.TabIndex = 65;
            this.PictureBoxLoop.TabStop = false;
            // 
            // List_Playlist
            // 
            this.List_Playlist.BackColor = System.Drawing.Color.Transparent;
            this.List_Playlist.BackgroundColor = System.Drawing.Color.Transparent;
            this.List_Playlist.BorderColor = System.Drawing.Color.Silver;
            this.List_Playlist.BorderRadius = 1;
            this.List_Playlist.Color = System.Drawing.Color.Silver;
            this.List_Playlist.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.List_Playlist.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.List_Playlist.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.List_Playlist.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.List_Playlist.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.List_Playlist.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.List_Playlist.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.List_Playlist.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.List_Playlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.List_Playlist.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.List_Playlist.FillDropDown = true;
            this.List_Playlist.FillIndicator = false;
            this.List_Playlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.List_Playlist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.List_Playlist.ForeColor = System.Drawing.Color.White;
            this.List_Playlist.FormattingEnabled = true;
            this.List_Playlist.Icon = null;
            this.List_Playlist.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.List_Playlist.IndicatorColor = System.Drawing.Color.DimGray;
            this.List_Playlist.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.List_Playlist.ItemBackColor = System.Drawing.Color.Black;
            this.List_Playlist.ItemBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.List_Playlist.ItemForeColor = System.Drawing.Color.White;
            this.List_Playlist.ItemHeight = 26;
            this.List_Playlist.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.List_Playlist.ItemHighLightForeColor = System.Drawing.Color.White;
            this.List_Playlist.Items.AddRange(new object[] {
            "Default"});
            this.List_Playlist.ItemTopMargin = 3;
            this.List_Playlist.Location = new System.Drawing.Point(62, 205);
            this.List_Playlist.Name = "List_Playlist";
            this.List_Playlist.Size = new System.Drawing.Size(725, 32);
            this.List_Playlist.TabIndex = 67;
            this.List_Playlist.Text = null;
            this.List_Playlist.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.List_Playlist.TextLeftMargin = 5;
            this.List_Playlist.SelectedIndexChanged += new System.EventHandler(this.List_Playlist_SelectedIndexChanged);
            // 
            // ButtonPrevious_playlist
            // 
            this.ButtonPrevious_playlist.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPrevious_playlist.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonPrevious_playlist.CheckedState.Parent = this.ButtonPrevious_playlist;
            this.ButtonPrevious_playlist.ContextMenuStrip = this.ContextMenuAdd;
            this.ButtonPrevious_playlist.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.ButtonPrevious_playlist.HoverState.ImageSize = new System.Drawing.Size(44, 44);
            this.ButtonPrevious_playlist.HoverState.Parent = this.ButtonPrevious_playlist;
            this.ButtonPrevious_playlist.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPrevious_playlist.Image")));
            this.ButtonPrevious_playlist.ImageOffset = new System.Drawing.Point(0, 0);
            this.ButtonPrevious_playlist.ImageRotate = 0F;
            this.ButtonPrevious_playlist.ImageSize = new System.Drawing.Size(38, 38);
            this.ButtonPrevious_playlist.IndicateFocus = true;
            this.ButtonPrevious_playlist.Location = new System.Drawing.Point(8, 197);
            this.ButtonPrevious_playlist.Name = "ButtonPrevious_playlist";
            this.ButtonPrevious_playlist.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.ButtonPrevious_playlist.PressedState.ImageSize = new System.Drawing.Size(105, 105);
            this.ButtonPrevious_playlist.PressedState.Parent = this.ButtonPrevious_playlist;
            this.ButtonPrevious_playlist.ShadowDecoration.Parent = this.ButtonPrevious_playlist;
            this.ButtonPrevious_playlist.Size = new System.Drawing.Size(45, 51);
            this.ButtonPrevious_playlist.TabIndex = 68;
            this.ButtonPrevious_playlist.Click += new System.EventHandler(this.ButtonPrevious_playlist_Click);
            // 
            // ButtonPlaylist_Next
            // 
            this.ButtonPlaylist_Next.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPlaylist_Next.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonPlaylist_Next.CheckedState.Parent = this.ButtonPlaylist_Next;
            this.ButtonPlaylist_Next.ContextMenuStrip = this.ContextMenuAdd;
            this.ButtonPlaylist_Next.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.ButtonPlaylist_Next.HoverState.ImageSize = new System.Drawing.Size(44, 44);
            this.ButtonPlaylist_Next.HoverState.Parent = this.ButtonPlaylist_Next;
            this.ButtonPlaylist_Next.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPlaylist_Next.Image")));
            this.ButtonPlaylist_Next.ImageOffset = new System.Drawing.Point(0, 0);
            this.ButtonPlaylist_Next.ImageRotate = 0F;
            this.ButtonPlaylist_Next.ImageSize = new System.Drawing.Size(38, 38);
            this.ButtonPlaylist_Next.IndicateFocus = true;
            this.ButtonPlaylist_Next.Location = new System.Drawing.Point(793, 197);
            this.ButtonPlaylist_Next.Name = "ButtonPlaylist_Next";
            this.ButtonPlaylist_Next.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.ButtonPlaylist_Next.PressedState.ImageSize = new System.Drawing.Size(105, 105);
            this.ButtonPlaylist_Next.PressedState.Parent = this.ButtonPlaylist_Next;
            this.ButtonPlaylist_Next.ShadowDecoration.Parent = this.ButtonPlaylist_Next;
            this.ButtonPlaylist_Next.Size = new System.Drawing.Size(45, 51);
            this.ButtonPlaylist_Next.TabIndex = 69;
            this.ButtonPlaylist_Next.Click += new System.EventHandler(this.ButtonPlaylist_Next_Click);
            // 
            // SongLongTime
            // 
            this.SongLongTime.AllowParentOverrides = false;
            this.SongLongTime.AutoEllipsis = false;
            this.SongLongTime.AutoSize = false;
            this.SongLongTime.CursorType = null;
            this.SongLongTime.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SongLongTime.ForeColor = System.Drawing.Color.White;
            this.SongLongTime.Location = new System.Drawing.Point(770, 35);
            this.SongLongTime.Name = "SongLongTime";
            this.SongLongTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SongLongTime.Size = new System.Drawing.Size(59, 17);
            this.SongLongTime.TabIndex = 31;
            this.SongLongTime.Text = "0:00";
            this.SongLongTime.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.SongLongTime.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // FullscreanButton
            // 
            this.FullscreanButton.BackColor = System.Drawing.Color.Transparent;
            this.FullscreanButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.FullscreanButton.CheckedState.Parent = this.FullscreanButton;
            this.FullscreanButton.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.FullscreanButton.HoverState.ImageSize = new System.Drawing.Size(44, 44);
            this.FullscreanButton.HoverState.Parent = this.FullscreanButton;
            this.FullscreanButton.Image = ((System.Drawing.Image)(resources.GetObject("FullscreanButton.Image")));
            this.FullscreanButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.FullscreanButton.ImageRotate = 0F;
            this.FullscreanButton.ImageSize = new System.Drawing.Size(38, 38);
            this.FullscreanButton.IndicateFocus = true;
            this.FullscreanButton.Location = new System.Drawing.Point(688, 116);
            this.FullscreanButton.Name = "FullscreanButton";
            this.FullscreanButton.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.FullscreanButton.PressedState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.FullscreanButton.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.FullscreanButton.PressedState.Parent = this.FullscreanButton;
            this.FullscreanButton.ShadowDecoration.Parent = this.FullscreanButton;
            this.FullscreanButton.Size = new System.Drawing.Size(45, 51);
            this.FullscreanButton.TabIndex = 70;
            this.FullscreanButton.Click += new System.EventHandler(this.FullscreanButton_Click);
            // 
            // openFileDialogPlaylists
            // 
            this.openFileDialogPlaylists.FileName = "openFileDialog1";
            // 
            // FormPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1168, 500);
            this.ControlBox = false;
            this.Controls.Add(this.FullscreanButton);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.ButtonPlaylist_Next);
            this.Controls.Add(this.ButtonPrevious_playlist);
            this.Controls.Add(this.List_Playlist);
            this.Controls.Add(this.PictureBoxLoop);
            this.Controls.Add(this.PictureBoxShuffle);
            this.Controls.Add(this.ToggleLoop);
            this.Controls.Add(this.ToggleShuffle);
            this.Controls.Add(this.ButtonDEL);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VisualPlaylist);
            this.Controls.Add(this.ButtonMute);
            this.Controls.Add(this.ButtonInfo);
            this.Controls.Add(this.ButtonVideo);
            this.Controls.Add(this.TagLabelAlbumArtist);
            this.Controls.Add(this.TagLabelTrack);
            this.Controls.Add(this.TagLabelStile);
            this.Controls.Add(this.TagLabelYear);
            this.Controls.Add(this.TagLabelAlbum);
            this.Controls.Add(this.TagLabelArtist);
            this.Controls.Add(this.NTagLabelTrack);
            this.Controls.Add(this.NTagLabelStile);
            this.Controls.Add(this.NTagLabelYear);
            this.Controls.Add(this.NTagLabelAlbum);
            this.Controls.Add(this.NTagLabelArtist);
            this.Controls.Add(this.NTagLabelTile);
            this.Controls.Add(this.TagLabelTile);
            this.Controls.Add(this.NTagLabelAlbumArtist);
            this.Controls.Add(this.SongLongTimeLabel);
            this.Controls.Add(this.SongTimeLabel);
            this.Controls.Add(this.ButtonHide);
            this.Controls.Add(this.ButtonEXIT);
            this.Controls.Add(this.VolumeSlider);
            this.Controls.Add(this.SongTimeSlider);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.ButtonPrevious);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonPause);
            this.Controls.Add(this.ButtonPlay);
            this.Controls.Add(this.RatingStar);
            this.Controls.Add(this.AlbumPictureBox);
            this.Controls.Add(this.ButtonRatingSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPlayer";
            this.Text = "Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPlayer_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPlayer_FormClosed);
            this.Load += new System.EventHandler(this.FormPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisualPlaylist)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ContextMenuAdd.ResumeLayout(false);
            this.ContextMenuDEL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLoop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        public AxWMPLib.AxWindowsMediaPlayer Player;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonPlay;
        private Guna.UI2.WinForms.Guna2RatingStar RatingStar;
        private Guna.UI2.WinForms.Guna2PictureBox AlbumPictureBox;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonNext;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonPrevious;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonStop;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonPause;
        private Guna.UI2.WinForms.Guna2ControlBox ButtonEXIT;
        private Bunifu.UI.WinForms.BunifuHSlider VolumeSlider;
        private Bunifu.UI.WinForms.BunifuHSlider SongTimeSlider;
        private Bunifu.UI.WinForms.BunifuLabel SongTimeLabel;
        private Guna.UI2.WinForms.Guna2ControlBox ButtonHide;
        private Bunifu.UI.WinForms.BunifuLabel TagLabelAlbumArtist;
        private Bunifu.UI.WinForms.BunifuLabel TagLabelTrack;
        private Bunifu.UI.WinForms.BunifuLabel TagLabelStile;
        private Bunifu.UI.WinForms.BunifuLabel TagLabelYear;
        private Bunifu.UI.WinForms.BunifuLabel TagLabelAlbum;
        private Bunifu.UI.WinForms.BunifuLabel TagLabelArtist;
        private Bunifu.UI.WinForms.BunifuLabel NTagLabelTrack;
        private Bunifu.UI.WinForms.BunifuLabel NTagLabelStile;
        private Bunifu.UI.WinForms.BunifuLabel NTagLabelYear;
        private Bunifu.UI.WinForms.BunifuLabel NTagLabelAlbum;
        private Bunifu.UI.WinForms.BunifuLabel NTagLabelArtist;
        private Bunifu.UI.WinForms.BunifuLabel NTagLabelTile;
        private Bunifu.UI.WinForms.BunifuLabel TagLabelTile;
        private Bunifu.UI.WinForms.BunifuLabel NTagLabelAlbumArtist;
        private Bunifu.UI.WinForms.BunifuLabel SongLongTimeLabel;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonInfo;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonVideo;
        private System.Windows.Forms.OpenFileDialog openFileDialogPlay;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonMute;
        public Bunifu.UI.WinForms.BunifuDataGridView VisualPlaylist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Song;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongTime;
        private Bunifu.UI.WinForms.BunifuLabel StatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuLabel StatusLabel2;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonRatingSave;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxShuffle;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ToggleLoop;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ToggleShuffle;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonDEL;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonAdd;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip ContextMenuAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddFolder;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddPlaylist;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddLink;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip ContextMenuDEL;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelFromPlaylist;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelFromDisk;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCleanPlaylist;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelPlaylist;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxLoop;
        private Bunifu.UI.WinForms.BunifuDropdown List_Playlist;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonPlaylist_Next;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonPrevious_playlist;
        private Bunifu.UI.WinForms.BunifuLabel SongLongTime;
        private Guna.UI2.WinForms.Guna2ImageButton FullscreanButton;
        private System.Windows.Forms.OpenFileDialog openFileDialogPlaylists;
    }
}


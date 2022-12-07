namespace NimPile
{
    partial class NimPile
    {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NimPile));
            this.ribbonICO = new System.Windows.Forms.ImageList(this.components);
            this.about = new System.Windows.Forms.TabPage();
            this.aboutCard = new MaterialSkin.Controls.MaterialCard();
            this.settings = new System.Windows.Forms.TabPage();
            this.settingNimView = new MaterialSkin.Controls.MaterialCard();
            this.switchNimView = new MaterialSkin.Controls.MaterialSwitch();
            this.game = new System.Windows.Forms.TabPage();
            this.gameDisplay = new System.Windows.Forms.Panel();
            this.gameOUTPUT = new System.Windows.Forms.TextBox();
            this.gameInputCard = new MaterialSkin.Controls.MaterialCard();
            this.gameConfirm = new MaterialSkin.Controls.MaterialButton();
            this.gameNumInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.gamePileInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.gamePlayerDisplayPanel = new System.Windows.Forms.Panel();
            this.gamePileDisplayPanel = new System.Windows.Forms.Panel();
            this.gameReset = new MaterialSkin.Controls.MaterialButton();
            this.gameStart = new MaterialSkin.Controls.MaterialButton();
            this.config = new System.Windows.Forms.TabPage();
            this.configSave = new MaterialSkin.Controls.MaterialButton();
            this.playerConfigLabel = new MaterialSkin.Controls.MaterialLabel();
            this.pileConfigLabel = new MaterialSkin.Controls.MaterialLabel();
            this.playerConfigCard = new MaterialSkin.Controls.MaterialCard();
            this.playerInfoPanel = new System.Windows.Forms.Panel();
            this.assist_players = new MaterialSkin.Controls.MaterialLabel();
            this.playerNumEntry = new MaterialSkin.Controls.MaterialTextBox2();
            this.assist_iwantplayer = new MaterialSkin.Controls.MaterialLabel();
            this.pileConfigCard = new MaterialSkin.Controls.MaterialCard();
            this.resetLimit = new MaterialSkin.Controls.MaterialButton();
            this.pileInfoPanel = new System.Windows.Forms.Panel();
            this.assist_piles = new MaterialSkin.Controls.MaterialLabel();
            this.assist_iwantPile = new MaterialSkin.Controls.MaterialLabel();
            this.pileNumEntry = new MaterialSkin.Controls.MaterialTextBox2();
            this.mainTab = new MaterialSkin.Controls.MaterialTabControl();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.aboutICON = new System.Windows.Forms.PictureBox();
            this.aboutLabelName = new MaterialSkin.Controls.MaterialLabel();
            this.aboutLabelVersion = new MaterialSkin.Controls.MaterialLabel();
            this.aboutLabelCopyright = new MaterialSkin.Controls.MaterialLabel();
            this.about.SuspendLayout();
            this.aboutCard.SuspendLayout();
            this.settings.SuspendLayout();
            this.settingNimView.SuspendLayout();
            this.game.SuspendLayout();
            this.gameDisplay.SuspendLayout();
            this.gameInputCard.SuspendLayout();
            this.config.SuspendLayout();
            this.playerConfigCard.SuspendLayout();
            this.pileConfigCard.SuspendLayout();
            this.mainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutICON)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonICO
            // 
            this.ribbonICO.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ribbonICO.ImageStream")));
            this.ribbonICO.TransparentColor = System.Drawing.Color.Transparent;
            this.ribbonICO.Images.SetKeyName(0, "config");
            this.ribbonICO.Images.SetKeyName(1, "game");
            this.ribbonICO.Images.SetKeyName(2, "settings");
            this.ribbonICO.Images.SetKeyName(3, "about");
            // 
            // about
            // 
            this.about.Controls.Add(this.aboutCard);
            this.about.ImageKey = "about";
            this.about.Location = new System.Drawing.Point(8, 39);
            this.about.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(1901, 912);
            this.about.TabIndex = 3;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = true;
            // 
            // aboutCard
            // 
            this.aboutCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.aboutCard.Controls.Add(this.aboutLabelCopyright);
            this.aboutCard.Controls.Add(this.aboutLabelVersion);
            this.aboutCard.Controls.Add(this.aboutLabelName);
            this.aboutCard.Controls.Add(this.aboutICON);
            this.aboutCard.Depth = 0;
            this.aboutCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.aboutCard.Location = new System.Drawing.Point(287, 72);
            this.aboutCard.Margin = new System.Windows.Forms.Padding(14);
            this.aboutCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.aboutCard.Name = "aboutCard";
            this.aboutCard.Padding = new System.Windows.Forms.Padding(14);
            this.aboutCard.Size = new System.Drawing.Size(745, 443);
            this.aboutCard.TabIndex = 0;
            // 
            // settings
            // 
            this.settings.Controls.Add(this.settingNimView);
            this.settings.ImageKey = "settings";
            this.settings.Location = new System.Drawing.Point(8, 39);
            this.settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settings.Name = "settings";
            this.settings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settings.Size = new System.Drawing.Size(1901, 912);
            this.settings.TabIndex = 2;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            // 
            // settingNimView
            // 
            this.settingNimView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.settingNimView.Controls.Add(this.switchNimView);
            this.settingNimView.Depth = 0;
            this.settingNimView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settingNimView.Location = new System.Drawing.Point(208, 70);
            this.settingNimView.Margin = new System.Windows.Forms.Padding(14);
            this.settingNimView.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingNimView.Name = "settingNimView";
            this.settingNimView.Padding = new System.Windows.Forms.Padding(14);
            this.settingNimView.Size = new System.Drawing.Size(393, 108);
            this.settingNimView.TabIndex = 0;
            // 
            // switchNimView
            // 
            this.switchNimView.AutoSize = true;
            this.switchNimView.Depth = 0;
            this.switchNimView.Location = new System.Drawing.Point(15, 18);
            this.switchNimView.Margin = new System.Windows.Forms.Padding(0);
            this.switchNimView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchNimView.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchNimView.Name = "switchNimView";
            this.switchNimView.Ripple = true;
            this.switchNimView.Size = new System.Drawing.Size(165, 37);
            this.switchNimView.TabIndex = 0;
            this.switchNimView.Text = "NimValue View";
            this.switchNimView.UseVisualStyleBackColor = true;
            this.switchNimView.Click += new System.EventHandler(this.switchNimView_Click);
            // 
            // game
            // 
            this.game.Controls.Add(this.gameDisplay);
            this.game.Controls.Add(this.gameReset);
            this.game.Controls.Add(this.gameStart);
            this.game.ImageKey = "game";
            this.game.Location = new System.Drawing.Point(8, 39);
            this.game.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.game.Name = "game";
            this.game.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.game.Size = new System.Drawing.Size(1901, 912);
            this.game.TabIndex = 1;
            this.game.Text = "Game";
            this.game.UseVisualStyleBackColor = true;
            // 
            // gameDisplay
            // 
            this.gameDisplay.Controls.Add(this.gameOUTPUT);
            this.gameDisplay.Controls.Add(this.gameInputCard);
            this.gameDisplay.Controls.Add(this.gamePlayerDisplayPanel);
            this.gameDisplay.Controls.Add(this.gamePileDisplayPanel);
            this.gameDisplay.Location = new System.Drawing.Point(170, 96);
            this.gameDisplay.Name = "gameDisplay";
            this.gameDisplay.Size = new System.Drawing.Size(1728, 811);
            this.gameDisplay.TabIndex = 3;
            // 
            // gameOUTPUT
            // 
            this.gameOUTPUT.AcceptsReturn = true;
            this.gameOUTPUT.AcceptsTab = true;
            this.gameOUTPUT.Location = new System.Drawing.Point(1399, 13);
            this.gameOUTPUT.Multiline = true;
            this.gameOUTPUT.Name = "gameOUTPUT";
            this.gameOUTPUT.ReadOnly = true;
            this.gameOUTPUT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gameOUTPUT.Size = new System.Drawing.Size(312, 449);
            this.gameOUTPUT.TabIndex = 3;
            // 
            // gameInputCard
            // 
            this.gameInputCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gameInputCard.Controls.Add(this.gameConfirm);
            this.gameInputCard.Controls.Add(this.gameNumInput);
            this.gameInputCard.Controls.Add(this.gamePileInput);
            this.gameInputCard.Depth = 0;
            this.gameInputCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gameInputCard.Location = new System.Drawing.Point(1399, 499);
            this.gameInputCard.Margin = new System.Windows.Forms.Padding(14);
            this.gameInputCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.gameInputCard.Name = "gameInputCard";
            this.gameInputCard.Padding = new System.Windows.Forms.Padding(14);
            this.gameInputCard.Size = new System.Drawing.Size(329, 305);
            this.gameInputCard.TabIndex = 2;
            // 
            // gameConfirm
            // 
            this.gameConfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gameConfirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.gameConfirm.Depth = 0;
            this.gameConfirm.HighEmphasis = true;
            this.gameConfirm.Icon = ((System.Drawing.Image)(resources.GetObject("gameConfirm.Icon")));
            this.gameConfirm.Location = new System.Drawing.Point(49, 220);
            this.gameConfirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gameConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.gameConfirm.Name = "gameConfirm";
            this.gameConfirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.gameConfirm.Size = new System.Drawing.Size(114, 36);
            this.gameConfirm.TabIndex = 2;
            this.gameConfirm.Text = "Confirm";
            this.gameConfirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.gameConfirm.UseAccentColor = false;
            this.gameConfirm.UseVisualStyleBackColor = true;
            this.gameConfirm.Click += new System.EventHandler(this.gameConfirm_Click);
            // 
            // gameNumInput
            // 
            this.gameNumInput.AnimateReadOnly = false;
            this.gameNumInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gameNumInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.gameNumInput.Depth = 0;
            this.gameNumInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gameNumInput.HideSelection = true;
            this.gameNumInput.LeadingIcon = null;
            this.gameNumInput.Location = new System.Drawing.Point(17, 122);
            this.gameNumInput.MaxLength = 32767;
            this.gameNumInput.MouseState = MaterialSkin.MouseState.OUT;
            this.gameNumInput.Name = "gameNumInput";
            this.gameNumInput.PasswordChar = '\0';
            this.gameNumInput.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.gameNumInput.PrefixSuffixText = "Pick";
            this.gameNumInput.ReadOnly = false;
            this.gameNumInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gameNumInput.SelectedText = "";
            this.gameNumInput.SelectionLength = 0;
            this.gameNumInput.SelectionStart = 0;
            this.gameNumInput.ShortcutsEnabled = true;
            this.gameNumInput.Size = new System.Drawing.Size(295, 48);
            this.gameNumInput.TabIndex = 1;
            this.gameNumInput.TabStop = false;
            this.gameNumInput.Text = "1";
            this.gameNumInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gameNumInput.TrailingIcon = null;
            this.gameNumInput.UseSystemPasswordChar = false;
            this.gameNumInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumEntry_KeyPress);
            this.gameNumInput.TextChanged += new System.EventHandler(this.gameNumInput_TextChanged);
            // 
            // gamePileInput
            // 
            this.gamePileInput.AnimateReadOnly = false;
            this.gamePileInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gamePileInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.gamePileInput.Depth = 0;
            this.gamePileInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gamePileInput.HideSelection = true;
            this.gamePileInput.LeadingIcon = null;
            this.gamePileInput.Location = new System.Drawing.Point(17, 17);
            this.gamePileInput.MaxLength = 32767;
            this.gamePileInput.MouseState = MaterialSkin.MouseState.OUT;
            this.gamePileInput.Name = "gamePileInput";
            this.gamePileInput.PasswordChar = '\0';
            this.gamePileInput.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.gamePileInput.PrefixSuffixText = "Pile";
            this.gamePileInput.ReadOnly = false;
            this.gamePileInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gamePileInput.SelectedText = "";
            this.gamePileInput.SelectionLength = 0;
            this.gamePileInput.SelectionStart = 0;
            this.gamePileInput.ShortcutsEnabled = true;
            this.gamePileInput.Size = new System.Drawing.Size(295, 48);
            this.gamePileInput.TabIndex = 0;
            this.gamePileInput.TabStop = false;
            this.gamePileInput.Text = "1";
            this.gamePileInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gamePileInput.TrailingIcon = null;
            this.gamePileInput.UseSystemPasswordChar = false;
            this.gamePileInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumEntry_KeyPress);
            this.gamePileInput.TextChanged += new System.EventHandler(this.gamePileInput_TextChanged);
            // 
            // gamePlayerDisplayPanel
            // 
            this.gamePlayerDisplayPanel.AutoScroll = true;
            this.gamePlayerDisplayPanel.Location = new System.Drawing.Point(0, 600);
            this.gamePlayerDisplayPanel.Name = "gamePlayerDisplayPanel";
            this.gamePlayerDisplayPanel.Size = new System.Drawing.Size(1367, 208);
            this.gamePlayerDisplayPanel.TabIndex = 1;
            // 
            // gamePileDisplayPanel
            // 
            this.gamePileDisplayPanel.AutoScroll = true;
            this.gamePileDisplayPanel.Location = new System.Drawing.Point(3, 3);
            this.gamePileDisplayPanel.Name = "gamePileDisplayPanel";
            this.gamePileDisplayPanel.Size = new System.Drawing.Size(1394, 597);
            this.gamePileDisplayPanel.TabIndex = 0;
            // 
            // gameReset
            // 
            this.gameReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gameReset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.gameReset.Depth = 0;
            this.gameReset.Enabled = false;
            this.gameReset.HighEmphasis = true;
            this.gameReset.Icon = ((System.Drawing.Image)(resources.GetObject("gameReset.Icon")));
            this.gameReset.Location = new System.Drawing.Point(425, 13);
            this.gameReset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gameReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.gameReset.Name = "gameReset";
            this.gameReset.NoAccentTextColor = System.Drawing.Color.Empty;
            this.gameReset.Size = new System.Drawing.Size(93, 36);
            this.gameReset.TabIndex = 2;
            this.gameReset.Text = "Reset";
            this.gameReset.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.gameReset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.gameReset.UseAccentColor = false;
            this.gameReset.UseVisualStyleBackColor = true;
            this.gameReset.Click += new System.EventHandler(this.gameReset_Click);
            // 
            // gameStart
            // 
            this.gameStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gameStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.gameStart.Depth = 0;
            this.gameStart.HighEmphasis = true;
            this.gameStart.Icon = ((System.Drawing.Image)(resources.GetObject("gameStart.Icon")));
            this.gameStart.Location = new System.Drawing.Point(207, 13);
            this.gameStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gameStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.gameStart.Name = "gameStart";
            this.gameStart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.gameStart.Size = new System.Drawing.Size(95, 36);
            this.gameStart.TabIndex = 1;
            this.gameStart.Text = "Start";
            this.gameStart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.gameStart.UseAccentColor = false;
            this.gameStart.UseVisualStyleBackColor = true;
            this.gameStart.Click += new System.EventHandler(this.gameStart_Click);
            // 
            // config
            // 
            this.config.BackColor = System.Drawing.Color.Transparent;
            this.config.Controls.Add(this.configSave);
            this.config.Controls.Add(this.playerConfigLabel);
            this.config.Controls.Add(this.pileConfigLabel);
            this.config.Controls.Add(this.playerConfigCard);
            this.config.Controls.Add(this.pileConfigCard);
            this.config.ImageKey = "config";
            this.config.Location = new System.Drawing.Point(8, 39);
            this.config.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.config.Name = "config";
            this.config.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.config.Size = new System.Drawing.Size(1901, 912);
            this.config.TabIndex = 0;
            this.config.Text = "Configuration";
            // 
            // configSave
            // 
            this.configSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.configSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.configSave.Depth = 0;
            this.configSave.HighEmphasis = true;
            this.configSave.Icon = ((System.Drawing.Image)(resources.GetObject("configSave.Icon")));
            this.configSave.Location = new System.Drawing.Point(1700, 2);
            this.configSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.configSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.configSave.Name = "configSave";
            this.configSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.configSave.Size = new System.Drawing.Size(86, 36);
            this.configSave.TabIndex = 4;
            this.configSave.Text = "SAVE";
            this.configSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.configSave.UseAccentColor = false;
            this.configSave.UseVisualStyleBackColor = true;
            this.configSave.Click += new System.EventHandler(this.configSave_Click);
            // 
            // playerConfigLabel
            // 
            this.playerConfigLabel.AutoSize = true;
            this.playerConfigLabel.Depth = 0;
            this.playerConfigLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.playerConfigLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.playerConfigLabel.HighEmphasis = true;
            this.playerConfigLabel.Location = new System.Drawing.Point(152, 475);
            this.playerConfigLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.playerConfigLabel.Name = "playerConfigLabel";
            this.playerConfigLabel.Size = new System.Drawing.Size(73, 24);
            this.playerConfigLabel.TabIndex = 3;
            this.playerConfigLabel.Text = "> Player";
            // 
            // pileConfigLabel
            // 
            this.pileConfigLabel.AutoSize = true;
            this.pileConfigLabel.Depth = 0;
            this.pileConfigLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.pileConfigLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.pileConfigLabel.HighEmphasis = true;
            this.pileConfigLabel.Location = new System.Drawing.Point(155, 28);
            this.pileConfigLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.pileConfigLabel.Name = "pileConfigLabel";
            this.pileConfigLabel.Size = new System.Drawing.Size(50, 24);
            this.pileConfigLabel.TabIndex = 2;
            this.pileConfigLabel.Text = "> Pile";
            // 
            // playerConfigCard
            // 
            this.playerConfigCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.playerConfigCard.Controls.Add(this.playerInfoPanel);
            this.playerConfigCard.Controls.Add(this.assist_players);
            this.playerConfigCard.Controls.Add(this.playerNumEntry);
            this.playerConfigCard.Controls.Add(this.assist_iwantplayer);
            this.playerConfigCard.Depth = 0;
            this.playerConfigCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.playerConfigCard.Location = new System.Drawing.Point(156, 532);
            this.playerConfigCard.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.playerConfigCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.playerConfigCard.Name = "playerConfigCard";
            this.playerConfigCard.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.playerConfigCard.Size = new System.Drawing.Size(1745, 380);
            this.playerConfigCard.TabIndex = 1;
            // 
            // playerInfoPanel
            // 
            this.playerInfoPanel.AutoScroll = true;
            this.playerInfoPanel.Location = new System.Drawing.Point(321, 34);
            this.playerInfoPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerInfoPanel.Name = "playerInfoPanel";
            this.playerInfoPanel.Size = new System.Drawing.Size(1389, 318);
            this.playerInfoPanel.TabIndex = 3;
            // 
            // assist_players
            // 
            this.assist_players.AutoSize = true;
            this.assist_players.Depth = 0;
            this.assist_players.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.assist_players.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.assist_players.HighEmphasis = true;
            this.assist_players.Location = new System.Drawing.Point(193, 128);
            this.assist_players.MouseState = MaterialSkin.MouseState.HOVER;
            this.assist_players.Name = "assist_players";
            this.assist_players.Size = new System.Drawing.Size(48, 14);
            this.assist_players.TabIndex = 2;
            this.assist_players.Text = "player(s)";
            // 
            // playerNumEntry
            // 
            this.playerNumEntry.AnimateReadOnly = false;
            this.playerNumEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playerNumEntry.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.playerNumEntry.Depth = 0;
            this.playerNumEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.playerNumEntry.HideSelection = true;
            this.playerNumEntry.LeadingIcon = null;
            this.playerNumEntry.Location = new System.Drawing.Point(17, 94);
            this.playerNumEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerNumEntry.MaxLength = 32767;
            this.playerNumEntry.MouseState = MaterialSkin.MouseState.OUT;
            this.playerNumEntry.Name = "playerNumEntry";
            this.playerNumEntry.PasswordChar = '\0';
            this.playerNumEntry.PrefixSuffixText = null;
            this.playerNumEntry.ReadOnly = false;
            this.playerNumEntry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playerNumEntry.SelectedText = "";
            this.playerNumEntry.SelectionLength = 0;
            this.playerNumEntry.SelectionStart = 0;
            this.playerNumEntry.ShortcutsEnabled = true;
            this.playerNumEntry.Size = new System.Drawing.Size(171, 48);
            this.playerNumEntry.TabIndex = 1;
            this.playerNumEntry.TabStop = false;
            this.playerNumEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.playerNumEntry.TrailingIcon = null;
            this.playerNumEntry.UseSystemPasswordChar = false;
            this.playerNumEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumEntry_KeyPress);
            this.playerNumEntry.TextChanged += new System.EventHandler(this.playerNumEntry_TextChanged);
            // 
            // assist_iwantplayer
            // 
            this.assist_iwantplayer.AutoSize = true;
            this.assist_iwantplayer.Depth = 0;
            this.assist_iwantplayer.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.assist_iwantplayer.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.assist_iwantplayer.HighEmphasis = true;
            this.assist_iwantplayer.Location = new System.Drawing.Point(19, 34);
            this.assist_iwantplayer.MouseState = MaterialSkin.MouseState.HOVER;
            this.assist_iwantplayer.Name = "assist_iwantplayer";
            this.assist_iwantplayer.Size = new System.Drawing.Size(77, 14);
            this.assist_iwantplayer.TabIndex = 0;
            this.assist_iwantplayer.Text = "I\'d like to have";
            // 
            // pileConfigCard
            // 
            this.pileConfigCard.AccessibleDescription = "";
            this.pileConfigCard.AccessibleName = "";
            this.pileConfigCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pileConfigCard.Controls.Add(this.resetLimit);
            this.pileConfigCard.Controls.Add(this.pileInfoPanel);
            this.pileConfigCard.Controls.Add(this.assist_piles);
            this.pileConfigCard.Controls.Add(this.assist_iwantPile);
            this.pileConfigCard.Controls.Add(this.pileNumEntry);
            this.pileConfigCard.Depth = 0;
            this.pileConfigCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pileConfigCard.Location = new System.Drawing.Point(156, 79);
            this.pileConfigCard.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.pileConfigCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.pileConfigCard.Name = "pileConfigCard";
            this.pileConfigCard.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.pileConfigCard.Size = new System.Drawing.Size(1745, 380);
            this.pileConfigCard.TabIndex = 0;
            // 
            // resetLimit
            // 
            this.resetLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetLimit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.resetLimit.Depth = 0;
            this.resetLimit.HighEmphasis = true;
            this.resetLimit.Icon = null;
            this.resetLimit.Location = new System.Drawing.Point(29, 248);
            this.resetLimit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.resetLimit.MouseState = MaterialSkin.MouseState.HOVER;
            this.resetLimit.Name = "resetLimit";
            this.resetLimit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.resetLimit.Size = new System.Drawing.Size(103, 36);
            this.resetLimit.TabIndex = 6;
            this.resetLimit.Text = "ResetLimit";
            this.resetLimit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.resetLimit.UseAccentColor = false;
            this.resetLimit.UseVisualStyleBackColor = true;
            this.resetLimit.Click += new System.EventHandler(this.resetLimit_Click);
            // 
            // pileInfoPanel
            // 
            this.pileInfoPanel.AutoScroll = true;
            this.pileInfoPanel.Location = new System.Drawing.Point(321, 38);
            this.pileInfoPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pileInfoPanel.Name = "pileInfoPanel";
            this.pileInfoPanel.Size = new System.Drawing.Size(1389, 308);
            this.pileInfoPanel.TabIndex = 5;
            // 
            // assist_piles
            // 
            this.assist_piles.AutoSize = true;
            this.assist_piles.Depth = 0;
            this.assist_piles.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.assist_piles.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.assist_piles.HighEmphasis = true;
            this.assist_piles.Location = new System.Drawing.Point(193, 128);
            this.assist_piles.MouseState = MaterialSkin.MouseState.HOVER;
            this.assist_piles.Name = "assist_piles";
            this.assist_piles.Size = new System.Drawing.Size(34, 14);
            this.assist_piles.TabIndex = 4;
            this.assist_piles.Text = "pile(s)";
            // 
            // assist_iwantPile
            // 
            this.assist_iwantPile.AutoSize = true;
            this.assist_iwantPile.Depth = 0;
            this.assist_iwantPile.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.assist_iwantPile.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.assist_iwantPile.HighEmphasis = true;
            this.assist_iwantPile.Location = new System.Drawing.Point(19, 38);
            this.assist_iwantPile.MouseState = MaterialSkin.MouseState.HOVER;
            this.assist_iwantPile.Name = "assist_iwantPile";
            this.assist_iwantPile.Size = new System.Drawing.Size(77, 14);
            this.assist_iwantPile.TabIndex = 3;
            this.assist_iwantPile.Text = "I\'d like to have";
            // 
            // pileNumEntry
            // 
            this.pileNumEntry.AnimateReadOnly = false;
            this.pileNumEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pileNumEntry.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.pileNumEntry.Depth = 0;
            this.pileNumEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pileNumEntry.HideSelection = true;
            this.pileNumEntry.LeadingIcon = null;
            this.pileNumEntry.Location = new System.Drawing.Point(17, 92);
            this.pileNumEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pileNumEntry.MaxLength = 32767;
            this.pileNumEntry.MouseState = MaterialSkin.MouseState.OUT;
            this.pileNumEntry.Name = "pileNumEntry";
            this.pileNumEntry.PasswordChar = '\0';
            this.pileNumEntry.PrefixSuffixText = null;
            this.pileNumEntry.ReadOnly = false;
            this.pileNumEntry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pileNumEntry.SelectedText = "";
            this.pileNumEntry.SelectionLength = 0;
            this.pileNumEntry.SelectionStart = 0;
            this.pileNumEntry.ShortcutsEnabled = true;
            this.pileNumEntry.Size = new System.Drawing.Size(171, 48);
            this.pileNumEntry.TabIndex = 2;
            this.pileNumEntry.TabStop = false;
            this.pileNumEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pileNumEntry.TrailingIcon = null;
            this.pileNumEntry.UseSystemPasswordChar = false;
            this.pileNumEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumEntry_KeyPress);
            this.pileNumEntry.TextChanged += new System.EventHandler(this.pileNumEntry_TextChanged);
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.config);
            this.mainTab.Controls.Add(this.game);
            this.mainTab.Controls.Add(this.settings);
            this.mainTab.Controls.Add(this.about);
            this.mainTab.Depth = 0;
            this.mainTab.ImageList = this.ribbonICO;
            this.mainTab.Location = new System.Drawing.Point(5, 125);
            this.mainTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainTab.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTab.Multiline = true;
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(1917, 959);
            this.mainTab.TabIndex = 0;
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // aboutICON
            // 
            this.aboutICON.Image = ((System.Drawing.Image)(resources.GetObject("aboutICON.Image")));
            this.aboutICON.Location = new System.Drawing.Point(17, 57);
            this.aboutICON.Name = "aboutICON";
            this.aboutICON.Size = new System.Drawing.Size(290, 265);
            this.aboutICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aboutICON.TabIndex = 0;
            this.aboutICON.TabStop = false;
            // 
            // aboutLabelName
            // 
            this.aboutLabelName.AutoSize = true;
            this.aboutLabelName.Depth = 0;
            this.aboutLabelName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.aboutLabelName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.aboutLabelName.HighEmphasis = true;
            this.aboutLabelName.Location = new System.Drawing.Point(121, 339);
            this.aboutLabelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.aboutLabelName.Name = "aboutLabelName";
            this.aboutLabelName.Size = new System.Drawing.Size(71, 24);
            this.aboutLabelName.TabIndex = 1;
            this.aboutLabelName.Text = "NimPile";
            // 
            // aboutLabelVersion
            // 
            this.aboutLabelVersion.AutoSize = true;
            this.aboutLabelVersion.Depth = 0;
            this.aboutLabelVersion.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.aboutLabelVersion.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.aboutLabelVersion.HighEmphasis = true;
            this.aboutLabelVersion.Location = new System.Drawing.Point(338, 127);
            this.aboutLabelVersion.MouseState = MaterialSkin.MouseState.HOVER;
            this.aboutLabelVersion.Name = "aboutLabelVersion";
            this.aboutLabelVersion.Size = new System.Drawing.Size(107, 24);
            this.aboutLabelVersion.TabIndex = 2;
            this.aboutLabelVersion.Text = "Version: 1.0";
            // 
            // aboutLabelCopyright
            // 
            this.aboutLabelCopyright.AutoSize = true;
            this.aboutLabelCopyright.Depth = 0;
            this.aboutLabelCopyright.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.aboutLabelCopyright.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.aboutLabelCopyright.HighEmphasis = true;
            this.aboutLabelCopyright.Location = new System.Drawing.Point(338, 229);
            this.aboutLabelCopyright.MouseState = MaterialSkin.MouseState.HOVER;
            this.aboutLabelCopyright.Name = "aboutLabelCopyright";
            this.aboutLabelCopyright.Size = new System.Drawing.Size(179, 24);
            this.aboutLabelCopyright.TabIndex = 3;
            this.aboutLabelCopyright.Text = "Copyright © GUOYU";
            // 
            // NimPile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.mainTab);
            this.DrawerAutoShow = true;
            this.DrawerBackgroundWithAccent = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.mainTab;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "NimPile";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 3, 2);
            this.Sizable = false;
            this.Text = "NimPile";
            this.about.ResumeLayout(false);
            this.aboutCard.ResumeLayout(false);
            this.aboutCard.PerformLayout();
            this.settings.ResumeLayout(false);
            this.settingNimView.ResumeLayout(false);
            this.settingNimView.PerformLayout();
            this.game.ResumeLayout(false);
            this.game.PerformLayout();
            this.gameDisplay.ResumeLayout(false);
            this.gameDisplay.PerformLayout();
            this.gameInputCard.ResumeLayout(false);
            this.gameInputCard.PerformLayout();
            this.config.ResumeLayout(false);
            this.config.PerformLayout();
            this.playerConfigCard.ResumeLayout(false);
            this.playerConfigCard.PerformLayout();
            this.pileConfigCard.ResumeLayout(false);
            this.pileConfigCard.PerformLayout();
            this.mainTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aboutICON)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ribbonICO;
        private System.Windows.Forms.TabPage about;
        private System.Windows.Forms.TabPage settings;
        private System.Windows.Forms.TabPage game;
        private System.Windows.Forms.TabPage config;
        private MaterialSkin.Controls.MaterialButton configSave;
        private MaterialSkin.Controls.MaterialLabel playerConfigLabel;
        private MaterialSkin.Controls.MaterialLabel pileConfigLabel;
        private MaterialSkin.Controls.MaterialCard playerConfigCard;
        private System.Windows.Forms.Panel playerInfoPanel;
        private MaterialSkin.Controls.MaterialLabel assist_players;
        private MaterialSkin.Controls.MaterialTextBox2 playerNumEntry;
        private MaterialSkin.Controls.MaterialLabel assist_iwantplayer;
        private MaterialSkin.Controls.MaterialCard pileConfigCard;
        private System.Windows.Forms.Panel pileInfoPanel;
        private MaterialSkin.Controls.MaterialLabel assist_piles;
        private MaterialSkin.Controls.MaterialLabel assist_iwantPile;
        private MaterialSkin.Controls.MaterialTextBox2 pileNumEntry;
        private MaterialSkin.Controls.MaterialTabControl mainTab;
        private System.ComponentModel.IContainer components;
        private MaterialSkin.Controls.MaterialButton resetLimit;
        private MaterialSkin.Controls.MaterialButton gameReset;
        private MaterialSkin.Controls.MaterialButton gameStart;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Panel gameDisplay;
        private MaterialSkin.Controls.MaterialCard gameInputCard;
        private MaterialSkin.Controls.MaterialButton gameConfirm;
        private System.Windows.Forms.Panel gamePlayerDisplayPanel;
        private System.Windows.Forms.Panel gamePileDisplayPanel;
        private System.Windows.Forms.TextBox gameOUTPUT;
        public MaterialSkin.Controls.MaterialTextBox2 gameNumInput;
        public MaterialSkin.Controls.MaterialTextBox2 gamePileInput;
        private MaterialSkin.Controls.MaterialCard settingNimView;
        private MaterialSkin.Controls.MaterialSwitch switchNimView;
        private MaterialSkin.Controls.MaterialCard aboutCard;
        private System.Windows.Forms.PictureBox aboutICON;
        private MaterialSkin.Controls.MaterialLabel aboutLabelName;
        private MaterialSkin.Controls.MaterialLabel aboutLabelVersion;
        private MaterialSkin.Controls.MaterialLabel aboutLabelCopyright;
    }
}


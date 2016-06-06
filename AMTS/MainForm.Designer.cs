namespace AMTS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.messageBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.confirmConfirmationButton = new System.Windows.Forms.Button();
            this.zarzadzajDruzyna = new System.Windows.Forms.Button();
            this.myRegistrationButton = new System.Windows.Forms.Button();
            this.generujRaportButton = new System.Windows.Forms.Button();
            this.artykul2 = new System.Windows.Forms.Label();
            this.admin = new System.Windows.Forms.Label();
            this.kapitan = new System.Windows.Forms.Label();
            this.nazwa = new System.Windows.Forms.Label();
            this.reklama = new System.Windows.Forms.Label();
            this.artykul1 = new System.Windows.Forms.Label();
            this.rss = new System.Windows.Forms.Label();
            this.googleplus = new System.Windows.Forms.LinkLabel();
            this.youtube = new System.Windows.Forms.LinkLabel();
            this.instagram = new System.Windows.Forms.LinkLabel();
            this.twitter = new System.Windows.Forms.LinkLabel();
            this.facebook = new System.Windows.Forms.LinkLabel();
            this.spolecznosciowki = new System.Windows.Forms.Label();
            this.brakDruzyny = new System.Windows.Forms.Label();
            this.messagesButton = new System.Windows.Forms.Button();
            this.niezalogowany = new System.Windows.Forms.Label();
            this.regulaminButton = new System.Windows.Forms.Button();
            this.wynikiButton = new System.Windows.Forms.Button();
            this.klasyfikacjaButton = new System.Windows.Forms.Button();
            this.terminarzButton = new System.Windows.Forms.Button();
            this.teamLabel = new System.Windows.Forms.Label();
            this.druzynaLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.loggedInAsLabel = new System.Windows.Forms.Label();
            this.panelDruzyny = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.loggedInAs = new System.Windows.Forms.Label();
            this.gosc = new System.Windows.Forms.Label();
            this.zbanuj = new System.Windows.Forms.Button();
            this.usunUzyt = new System.Windows.Forms.Button();
            this.usunDruz = new System.Windows.Forms.Button();
            this.numberOfTeamRegistrationsLabel = new System.Windows.Forms.Label();
            this.teamRegistrationsButton = new System.Windows.Forms.Button();
            this.panelAdmina = new System.Windows.Forms.Label();
            this.registerTeamButton = new System.Windows.Forms.Button();
            this.ban = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messageBackgroundWorker
            // 
            this.messageBackgroundWorker.WorkerReportsProgress = true;
            this.messageBackgroundWorker.WorkerSupportsCancellation = true;
            this.messageBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.messageBackgroundWorker_DoWork);
            this.messageBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.messageBackgroundWorker_ProgressChanged);
            // 
            // confirmConfirmationButton
            // 
            this.confirmConfirmationButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.confirmConfirmationButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirmConfirmationButton.FlatAppearance.BorderSize = 0;
            this.confirmConfirmationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmConfirmationButton.Image = global::AMTS.Properties.Resources.potwierdz_udzial;
            this.confirmConfirmationButton.Location = new System.Drawing.Point(839, 416);
            this.confirmConfirmationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmConfirmationButton.Name = "confirmConfirmationButton";
            this.confirmConfirmationButton.Size = new System.Drawing.Size(239, 26);
            this.confirmConfirmationButton.TabIndex = 16;
            this.confirmConfirmationButton.UseVisualStyleBackColor = false;
            this.confirmConfirmationButton.Visible = false;
            this.confirmConfirmationButton.Click += new System.EventHandler(this.confirmConfirmationButton_Click);
            // 
            // zarzadzajDruzyna
            // 
            this.zarzadzajDruzyna.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.zarzadzajDruzyna.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.zarzadzajDruzyna.FlatAppearance.BorderSize = 0;
            this.zarzadzajDruzyna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zarzadzajDruzyna.Image = global::AMTS.Properties.Resources.zarzadzaj;
            this.zarzadzajDruzyna.Location = new System.Drawing.Point(839, 385);
            this.zarzadzajDruzyna.Margin = new System.Windows.Forms.Padding(4);
            this.zarzadzajDruzyna.Name = "zarzadzajDruzyna";
            this.zarzadzajDruzyna.Size = new System.Drawing.Size(147, 36);
            this.zarzadzajDruzyna.TabIndex = 23;
            this.zarzadzajDruzyna.UseVisualStyleBackColor = false;
            this.zarzadzajDruzyna.Visible = false;
            this.zarzadzajDruzyna.Click += new System.EventHandler(this.zarzadzajDruzyna_Click);
            // 
            // myRegistrationButton
            // 
            this.myRegistrationButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.myRegistrationButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.myRegistrationButton.FlatAppearance.BorderSize = 0;
            this.myRegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myRegistrationButton.Image = global::AMTS.Properties.Resources.moje_zgloszenia;
            this.myRegistrationButton.Location = new System.Drawing.Point(839, 354);
            this.myRegistrationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myRegistrationButton.Name = "myRegistrationButton";
            this.myRegistrationButton.Size = new System.Drawing.Size(224, 25);
            this.myRegistrationButton.TabIndex = 15;
            this.myRegistrationButton.UseVisualStyleBackColor = false;
            this.myRegistrationButton.Visible = false;
            this.myRegistrationButton.Click += new System.EventHandler(this.myRegistrationButton_Click);
            // 
            // generujRaportButton
            // 
            this.generujRaportButton.BackColor = System.Drawing.Color.Transparent;
            this.generujRaportButton.FlatAppearance.BorderSize = 0;
            this.generujRaportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generujRaportButton.ForeColor = System.Drawing.Color.Coral;
            this.generujRaportButton.Image = global::AMTS.Properties.Resources.generuj;
            this.generujRaportButton.Location = new System.Drawing.Point(987, 197);
            this.generujRaportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generujRaportButton.Name = "generujRaportButton";
            this.generujRaportButton.Size = new System.Drawing.Size(229, 94);
            this.generujRaportButton.TabIndex = 43;
            this.generujRaportButton.UseVisualStyleBackColor = false;
            this.generujRaportButton.Visible = false;
            this.generujRaportButton.Click += new System.EventHandler(this.generujRaportButton_Click);
            // 
            // artykul2
            // 
            this.artykul2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.artykul2.BackColor = System.Drawing.Color.Transparent;
            this.artykul2.Image = global::AMTS.Properties.Resources.artykul2;
            this.artykul2.Location = new System.Drawing.Point(12, 598);
            this.artykul2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.artykul2.Name = "artykul2";
            this.artykul2.Size = new System.Drawing.Size(559, 338);
            this.artykul2.TabIndex = 38;
            // 
            // admin
            // 
            this.admin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.admin.BackColor = System.Drawing.Color.Transparent;
            this.admin.Image = global::AMTS.Properties.Resources.ADMIN;
            this.admin.Location = new System.Drawing.Point(1008, 39);
            this.admin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(92, 18);
            this.admin.TabIndex = 27;
            this.admin.Visible = false;
            // 
            // kapitan
            // 
            this.kapitan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kapitan.BackColor = System.Drawing.Color.Transparent;
            this.kapitan.Image = global::AMTS.Properties.Resources.KAPITAN;
            this.kapitan.Location = new System.Drawing.Point(995, 38);
            this.kapitan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kapitan.Name = "kapitan";
            this.kapitan.Size = new System.Drawing.Size(109, 22);
            this.kapitan.TabIndex = 28;
            this.kapitan.Visible = false;
            // 
            // nazwa
            // 
            this.nazwa.BackColor = System.Drawing.Color.Transparent;
            this.nazwa.Image = global::AMTS.Properties.Resources.napis_na_gore;
            this.nazwa.Location = new System.Drawing.Point(21, 11);
            this.nazwa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nazwa.Name = "nazwa";
            this.nazwa.Size = new System.Drawing.Size(369, 81);
            this.nazwa.TabIndex = 41;
            // 
            // reklama
            // 
            this.reklama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reklama.BackColor = System.Drawing.Color.Transparent;
            this.reklama.Image = global::AMTS.Properties.Resources.reklama;
            this.reklama.Location = new System.Drawing.Point(787, 694);
            this.reklama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reklama.Name = "reklama";
            this.reklama.Size = new System.Drawing.Size(429, 223);
            this.reklama.TabIndex = 40;
            // 
            // artykul1
            // 
            this.artykul1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.artykul1.BackColor = System.Drawing.Color.Transparent;
            this.artykul1.Image = global::AMTS.Properties.Resources.artykul_1;
            this.artykul1.Location = new System.Drawing.Point(12, 258);
            this.artykul1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.artykul1.Name = "artykul1";
            this.artykul1.Size = new System.Drawing.Size(559, 348);
            this.artykul1.TabIndex = 39;
            // 
            // rss
            // 
            this.rss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rss.BackColor = System.Drawing.Color.Transparent;
            this.rss.Image = global::AMTS.Properties.Resources.RSS;
            this.rss.Location = new System.Drawing.Point(1152, 133);
            this.rss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rss.Name = "rss";
            this.rss.Size = new System.Drawing.Size(48, 57);
            this.rss.TabIndex = 37;
            // 
            // googleplus
            // 
            this.googleplus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.googleplus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.googleplus.Image = global::AMTS.Properties.Resources.googleplus;
            this.googleplus.Location = new System.Drawing.Point(1108, 598);
            this.googleplus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.googleplus.Name = "googleplus";
            this.googleplus.Size = new System.Drawing.Size(67, 60);
            this.googleplus.TabIndex = 36;
            this.googleplus.Click += new System.EventHandler(this.googleplus_LinkClicked);
            // 
            // youtube
            // 
            this.youtube.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.youtube.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.youtube.Image = global::AMTS.Properties.Resources.youtube;
            this.youtube.Location = new System.Drawing.Point(1036, 598);
            this.youtube.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.youtube.Name = "youtube";
            this.youtube.Size = new System.Drawing.Size(67, 60);
            this.youtube.TabIndex = 35;
            this.youtube.Click += new System.EventHandler(this.youtube_LinkClicked);
            // 
            // instagram
            // 
            this.instagram.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.instagram.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.instagram.Image = global::AMTS.Properties.Resources.instagram;
            this.instagram.Location = new System.Drawing.Point(964, 598);
            this.instagram.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instagram.Name = "instagram";
            this.instagram.Size = new System.Drawing.Size(67, 60);
            this.instagram.TabIndex = 34;
            this.instagram.Click += new System.EventHandler(this.instagram_LinkClicked);
            // 
            // twitter
            // 
            this.twitter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.twitter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.twitter.Image = global::AMTS.Properties.Resources.twitter;
            this.twitter.Location = new System.Drawing.Point(891, 598);
            this.twitter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.twitter.Name = "twitter";
            this.twitter.Size = new System.Drawing.Size(71, 60);
            this.twitter.TabIndex = 33;
            this.twitter.Click += new System.EventHandler(this.twitter_LinkClicked);
            // 
            // facebook
            // 
            this.facebook.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.facebook.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.facebook.Image = global::AMTS.Properties.Resources.facebook;
            this.facebook.Location = new System.Drawing.Point(824, 598);
            this.facebook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.facebook.Name = "facebook";
            this.facebook.Size = new System.Drawing.Size(71, 60);
            this.facebook.TabIndex = 32;
            this.facebook.Click += new System.EventHandler(this.facebook_LinkClicked);
            // 
            // spolecznosciowki
            // 
            this.spolecznosciowki.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.spolecznosciowki.BackColor = System.Drawing.Color.Transparent;
            this.spolecznosciowki.Image = global::AMTS.Properties.Resources.obserwuj_ALTS;
            this.spolecznosciowki.Location = new System.Drawing.Point(787, 544);
            this.spolecznosciowki.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.spolecznosciowki.Name = "spolecznosciowki";
            this.spolecznosciowki.Size = new System.Drawing.Size(429, 171);
            this.spolecznosciowki.TabIndex = 31;
            // 
            // brakDruzyny
            // 
            this.brakDruzyny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brakDruzyny.BackColor = System.Drawing.Color.Transparent;
            this.brakDruzyny.Image = global::AMTS.Properties.Resources.BRAK;
            this.brakDruzyny.Location = new System.Drawing.Point(987, 58);
            this.brakDruzyny.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.brakDruzyny.Name = "brakDruzyny";
            this.brakDruzyny.Size = new System.Drawing.Size(71, 34);
            this.brakDruzyny.TabIndex = 30;
            this.brakDruzyny.Visible = false;
            // 
            // messagesButton
            // 
            this.messagesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.messagesButton.BackColor = System.Drawing.Color.Transparent;
            this.messagesButton.FlatAppearance.BorderSize = 0;
            this.messagesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.messagesButton.Image = global::AMTS.Properties.Resources.greyMailImage;
            this.messagesButton.Location = new System.Drawing.Point(824, 0);
            this.messagesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.messagesButton.Name = "messagesButton";
            this.messagesButton.Size = new System.Drawing.Size(67, 68);
            this.messagesButton.TabIndex = 17;
            this.messagesButton.UseVisualStyleBackColor = false;
            this.messagesButton.Visible = false;
            this.messagesButton.Click += new System.EventHandler(this.messagesButton_Click);
            // 
            // niezalogowany
            // 
            this.niezalogowany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.niezalogowany.AutoSize = true;
            this.niezalogowany.BackColor = System.Drawing.Color.Transparent;
            this.niezalogowany.ForeColor = System.Drawing.Color.Red;
            this.niezalogowany.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.niezalogowany.Location = new System.Drawing.Point(1053, 273);
            this.niezalogowany.Name = "niezalogowany";
            this.niezalogowany.Size = new System.Drawing.Size(81, 17);
            this.niezalogowany.TabIndex = 12;
            this.niezalogowany.Text = "Zaloguj się.";
            this.niezalogowany.Visible = false;
            // 
            // regulaminButton
            // 
            this.regulaminButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.regulaminButton.BackColor = System.Drawing.Color.Transparent;
            this.regulaminButton.FlatAppearance.BorderSize = 0;
            this.regulaminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regulaminButton.Image = global::AMTS.Properties.Resources.regulamin;
            this.regulaminButton.Location = new System.Drawing.Point(909, 116);
            this.regulaminButton.Margin = new System.Windows.Forms.Padding(4);
            this.regulaminButton.Name = "regulaminButton";
            this.regulaminButton.Size = new System.Drawing.Size(181, 74);
            this.regulaminButton.TabIndex = 10;
            this.regulaminButton.UseVisualStyleBackColor = false;
            this.regulaminButton.Click += new System.EventHandler(this.regulaminButton_Click);
            // 
            // wynikiButton
            // 
            this.wynikiButton.BackColor = System.Drawing.Color.Transparent;
            this.wynikiButton.FlatAppearance.BorderSize = 0;
            this.wynikiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wynikiButton.Image = global::AMTS.Properties.Resources.wyniki;
            this.wynikiButton.Location = new System.Drawing.Point(229, 116);
            this.wynikiButton.Margin = new System.Windows.Forms.Padding(4);
            this.wynikiButton.Name = "wynikiButton";
            this.wynikiButton.Size = new System.Drawing.Size(181, 74);
            this.wynikiButton.TabIndex = 9;
            this.wynikiButton.UseVisualStyleBackColor = false;
            this.wynikiButton.Click += new System.EventHandler(this.wynikiButton_Click);
            // 
            // klasyfikacjaButton
            // 
            this.klasyfikacjaButton.BackColor = System.Drawing.Color.Transparent;
            this.klasyfikacjaButton.FlatAppearance.BorderSize = 0;
            this.klasyfikacjaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.klasyfikacjaButton.Image = global::AMTS.Properties.Resources.klasyfikacja;
            this.klasyfikacjaButton.Location = new System.Drawing.Point(16, 116);
            this.klasyfikacjaButton.Margin = new System.Windows.Forms.Padding(4);
            this.klasyfikacjaButton.Name = "klasyfikacjaButton";
            this.klasyfikacjaButton.Size = new System.Drawing.Size(181, 74);
            this.klasyfikacjaButton.TabIndex = 8;
            this.klasyfikacjaButton.UseVisualStyleBackColor = false;
            this.klasyfikacjaButton.Click += new System.EventHandler(this.klasyfikacjaButton_Click);
            // 
            // terminarzButton
            // 
            this.terminarzButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.terminarzButton.BackColor = System.Drawing.Color.Transparent;
            this.terminarzButton.FlatAppearance.BorderSize = 0;
            this.terminarzButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.terminarzButton.Image = global::AMTS.Properties.Resources.Terminarz;
            this.terminarzButton.Location = new System.Drawing.Point(709, 116);
            this.terminarzButton.Margin = new System.Windows.Forms.Padding(4);
            this.terminarzButton.Name = "terminarzButton";
            this.terminarzButton.Size = new System.Drawing.Size(181, 74);
            this.terminarzButton.TabIndex = 7;
            this.terminarzButton.UseVisualStyleBackColor = false;
            this.terminarzButton.Click += new System.EventHandler(this.terminarzButton_Click);
            // 
            // teamLabel
            // 
            this.teamLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamLabel.AutoSize = true;
            this.teamLabel.BackColor = System.Drawing.Color.Transparent;
            this.teamLabel.Location = new System.Drawing.Point(988, 70);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(204, 17);
            this.teamLabel.TabIndex = 6;
            this.teamLabel.Text = "druzyna [NIEZATWIERDZONA]";
            // 
            // druzynaLabel
            // 
            this.druzynaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.druzynaLabel.BackColor = System.Drawing.Color.Transparent;
            this.druzynaLabel.Image = global::AMTS.Properties.Resources.Drużyna;
            this.druzynaLabel.Location = new System.Drawing.Point(880, 70);
            this.druzynaLabel.Name = "druzynaLabel";
            this.druzynaLabel.Size = new System.Drawing.Size(112, 16);
            this.druzynaLabel.TabIndex = 5;
            // 
            // registerButton
            // 
            this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registerButton.BackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Image = global::AMTS.Properties.Resources.REJESTARCJA;
            this.registerButton.Location = new System.Drawing.Point(881, 95);
            this.registerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(139, 25);
            this.registerButton.TabIndex = 4;
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loggedInAsLabel
            // 
            this.loggedInAsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loggedInAsLabel.AutoSize = true;
            this.loggedInAsLabel.BackColor = System.Drawing.Color.Transparent;
            this.loggedInAsLabel.Location = new System.Drawing.Point(1105, 15);
            this.loggedInAsLabel.Name = "loggedInAsLabel";
            this.loggedInAsLabel.Size = new System.Drawing.Size(41, 17);
            this.loggedInAsLabel.TabIndex = 1;
            this.loggedInAsLabel.Text = "Gość";
            this.loggedInAsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loggedInAsLabel.Visible = false;
            // 
            // panelDruzyny
            // 
            this.panelDruzyny.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panelDruzyny.BackColor = System.Drawing.Color.Transparent;
            this.panelDruzyny.Image = global::AMTS.Properties.Resources.panel_druzyny;
            this.panelDruzyny.Location = new System.Drawing.Point(787, 308);
            this.panelDruzyny.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panelDruzyny.Name = "panelDruzyny";
            this.panelDruzyny.Size = new System.Drawing.Size(448, 194);
            this.panelDruzyny.TabIndex = 26;
            this.panelDruzyny.Visible = false;
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::AMTS.Properties.Resources.LOGO;
            this.logo.Location = new System.Drawing.Point(399, 2);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(323, 273);
            this.logo.TabIndex = 42;
            // 
            // logInButton
            // 
            this.logInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logInButton.BackColor = System.Drawing.Color.Transparent;
            this.logInButton.FlatAppearance.BorderSize = 0;
            this.logInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInButton.Image = global::AMTS.Properties.Resources.ZALOGUJ;
            this.logInButton.Location = new System.Drawing.Point(1036, 95);
            this.logInButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(104, 20);
            this.logInButton.TabIndex = 2;
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutButton.BackColor = System.Drawing.Color.Transparent;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Image = global::AMTS.Properties.Resources.WYLOGUJ;
            this.logOutButton.Location = new System.Drawing.Point(1036, 95);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(105, 20);
            this.logOutButton.TabIndex = 3;
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // loggedInAs
            // 
            this.loggedInAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loggedInAs.BackColor = System.Drawing.Color.Transparent;
            this.loggedInAs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loggedInAs.Image = global::AMTS.Properties.Resources.zalogowany_jako;
            this.loggedInAs.Location = new System.Drawing.Point(896, 2);
            this.loggedInAs.Name = "loggedInAs";
            this.loggedInAs.Size = new System.Drawing.Size(208, 42);
            this.loggedInAs.TabIndex = 0;
            this.loggedInAs.Visible = false;
            // 
            // gosc
            // 
            this.gosc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gosc.BackColor = System.Drawing.Color.Transparent;
            this.gosc.Image = global::AMTS.Properties.Resources.Niezalogowany_GOSC;
            this.gosc.Location = new System.Drawing.Point(903, -14);
            this.gosc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gosc.Name = "gosc";
            this.gosc.Size = new System.Drawing.Size(245, 68);
            this.gosc.TabIndex = 29;
            // 
            // zbanuj
            // 
            this.zbanuj.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.zbanuj.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.zbanuj.FlatAppearance.BorderSize = 0;
            this.zbanuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zbanuj.Image = global::AMTS.Properties.Resources.zawies_zawodnika;
            this.zbanuj.Location = new System.Drawing.Point(839, 422);
            this.zbanuj.Margin = new System.Windows.Forms.Padding(4);
            this.zbanuj.Name = "zbanuj";
            this.zbanuj.Size = new System.Drawing.Size(249, 27);
            this.zbanuj.TabIndex = 24;
            this.zbanuj.UseVisualStyleBackColor = false;
            this.zbanuj.Visible = false;
            this.zbanuj.Click += new System.EventHandler(this.zbanuj_Click);
            // 
            // usunUzyt
            // 
            this.usunUzyt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.usunUzyt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.usunUzyt.FlatAppearance.BorderSize = 0;
            this.usunUzyt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usunUzyt.Image = global::AMTS.Properties.Resources.usun_zawodnika;
            this.usunUzyt.Location = new System.Drawing.Point(839, 457);
            this.usunUzyt.Margin = new System.Windows.Forms.Padding(4);
            this.usunUzyt.Name = "usunUzyt";
            this.usunUzyt.Size = new System.Drawing.Size(231, 28);
            this.usunUzyt.TabIndex = 19;
            this.usunUzyt.UseVisualStyleBackColor = false;
            this.usunUzyt.Visible = false;
            this.usunUzyt.Click += new System.EventHandler(this.usunUzyt_Click);
            // 
            // usunDruz
            // 
            this.usunDruz.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.usunDruz.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.usunDruz.FlatAppearance.BorderSize = 0;
            this.usunDruz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usunDruz.Image = global::AMTS.Properties.Resources.usun_druzyne;
            this.usunDruz.Location = new System.Drawing.Point(839, 388);
            this.usunDruz.Margin = new System.Windows.Forms.Padding(4);
            this.usunDruz.Name = "usunDruz";
            this.usunDruz.Size = new System.Drawing.Size(188, 27);
            this.usunDruz.TabIndex = 18;
            this.usunDruz.UseVisualStyleBackColor = false;
            this.usunDruz.Visible = false;
            this.usunDruz.Click += new System.EventHandler(this.usunDruz_Click);
            // 
            // numberOfTeamRegistrationsLabel
            // 
            this.numberOfTeamRegistrationsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numberOfTeamRegistrationsLabel.AutoSize = true;
            this.numberOfTeamRegistrationsLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.numberOfTeamRegistrationsLabel.Location = new System.Drawing.Point(1104, 358);
            this.numberOfTeamRegistrationsLabel.Name = "numberOfTeamRegistrationsLabel";
            this.numberOfTeamRegistrationsLabel.Size = new System.Drawing.Size(34, 17);
            this.numberOfTeamRegistrationsLabel.TabIndex = 14;
            this.numberOfTeamRegistrationsLabel.Text = "(14)";
            this.numberOfTeamRegistrationsLabel.Visible = false;
            // 
            // teamRegistrationsButton
            // 
            this.teamRegistrationsButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.teamRegistrationsButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.teamRegistrationsButton.FlatAppearance.BorderSize = 0;
            this.teamRegistrationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teamRegistrationsButton.Image = global::AMTS.Properties.Resources.zatwierdz_druzyne;
            this.teamRegistrationsButton.Location = new System.Drawing.Point(839, 352);
            this.teamRegistrationsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teamRegistrationsButton.Name = "teamRegistrationsButton";
            this.teamRegistrationsButton.Size = new System.Drawing.Size(260, 28);
            this.teamRegistrationsButton.TabIndex = 13;
            this.teamRegistrationsButton.UseVisualStyleBackColor = false;
            this.teamRegistrationsButton.Visible = false;
            this.teamRegistrationsButton.Click += new System.EventHandler(this.teamRegistrationsButton_Click);
            // 
            // panelAdmina
            // 
            this.panelAdmina.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panelAdmina.BackColor = System.Drawing.Color.Transparent;
            this.panelAdmina.Image = global::AMTS.Properties.Resources.panel_admina;
            this.panelAdmina.Location = new System.Drawing.Point(793, 308);
            this.panelAdmina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panelAdmina.Name = "panelAdmina";
            this.panelAdmina.Size = new System.Drawing.Size(433, 236);
            this.panelAdmina.TabIndex = 25;
            this.panelAdmina.Visible = false;
            // 
            // registerTeamButton
            // 
            this.registerTeamButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registerTeamButton.BackColor = System.Drawing.Color.Transparent;
            this.registerTeamButton.FlatAppearance.BorderSize = 0;
            this.registerTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerTeamButton.Image = global::AMTS.Properties.Resources.zglos_druzyne;
            this.registerTeamButton.Location = new System.Drawing.Point(968, 197);
            this.registerTeamButton.Margin = new System.Windows.Forms.Padding(4);
            this.registerTeamButton.Name = "registerTeamButton";
            this.registerTeamButton.Size = new System.Drawing.Size(252, 92);
            this.registerTeamButton.TabIndex = 11;
            this.registerTeamButton.UseVisualStyleBackColor = false;
            this.registerTeamButton.Click += new System.EventHandler(this.registerTeam_Click);
            // 
            // ban
            // 
            this.ban.BackColor = System.Drawing.Color.Transparent;
            this.ban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ban.Image = global::AMTS.Properties.Resources.ban;
            this.ban.Location = new System.Drawing.Point(987, 38);
            this.ban.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ban.Name = "ban";
            this.ban.Size = new System.Drawing.Size(155, 28);
            this.ban.TabIndex = 44;
            this.ban.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::AMTS.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1236, 914);
            this.Controls.Add(this.confirmConfirmationButton);
            this.Controls.Add(this.zarzadzajDruzyna);
            this.Controls.Add(this.myRegistrationButton);
            this.Controls.Add(this.generujRaportButton);
            this.Controls.Add(this.artykul2);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.kapitan);
            this.Controls.Add(this.nazwa);
            this.Controls.Add(this.reklama);
            this.Controls.Add(this.artykul1);
            this.Controls.Add(this.rss);
            this.Controls.Add(this.googleplus);
            this.Controls.Add(this.youtube);
            this.Controls.Add(this.instagram);
            this.Controls.Add(this.twitter);
            this.Controls.Add(this.facebook);
            this.Controls.Add(this.spolecznosciowki);
            this.Controls.Add(this.brakDruzyny);
            this.Controls.Add(this.messagesButton);
            this.Controls.Add(this.niezalogowany);
            this.Controls.Add(this.regulaminButton);
            this.Controls.Add(this.wynikiButton);
            this.Controls.Add(this.klasyfikacjaButton);
            this.Controls.Add(this.terminarzButton);
            this.Controls.Add(this.teamLabel);
            this.Controls.Add(this.druzynaLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loggedInAsLabel);
            this.Controls.Add(this.panelDruzyny);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.loggedInAs);
            this.Controls.Add(this.gosc);
            this.Controls.Add(this.zbanuj);
            this.Controls.Add(this.usunUzyt);
            this.Controls.Add(this.usunDruz);
            this.Controls.Add(this.numberOfTeamRegistrationsLabel);
            this.Controls.Add(this.teamRegistrationsButton);
            this.Controls.Add(this.panelAdmina);
            this.Controls.Add(this.registerTeamButton);
            this.Controls.Add(this.ban);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Amatorska Liga Tenisa Stołowego";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loggedInAs;
        private System.Windows.Forms.Label loggedInAsLabel;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label druzynaLabel;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.Button terminarzButton;
        private System.Windows.Forms.Button klasyfikacjaButton;
        private System.Windows.Forms.Button wynikiButton;
        private System.Windows.Forms.Button regulaminButton;
        private System.Windows.Forms.Button registerTeamButton;
        private System.Windows.Forms.Label niezalogowany;
        private System.Windows.Forms.Button teamRegistrationsButton;
        private System.Windows.Forms.Label numberOfTeamRegistrationsLabel;
        private System.Windows.Forms.Button myRegistrationButton;
        private System.Windows.Forms.Button confirmConfirmationButton;
        private System.Windows.Forms.Button messagesButton;
        private System.ComponentModel.BackgroundWorker messageBackgroundWorker;
        private System.Windows.Forms.Button usunDruz;
        private System.Windows.Forms.Button usunUzyt;
        private System.Windows.Forms.Button zarzadzajDruzyna;
        private System.Windows.Forms.Button zbanuj;
        private System.Windows.Forms.Label panelAdmina;
        private System.Windows.Forms.Label panelDruzyny;
        private System.Windows.Forms.Label admin;
        private System.Windows.Forms.Label kapitan;
        private System.Windows.Forms.Label gosc;
        private System.Windows.Forms.Label brakDruzyny;
        private System.Windows.Forms.Label spolecznosciowki;
        private System.Windows.Forms.LinkLabel facebook;
        private System.Windows.Forms.LinkLabel twitter;
        private System.Windows.Forms.LinkLabel instagram;
        private System.Windows.Forms.LinkLabel youtube;
        private System.Windows.Forms.LinkLabel googleplus;
        private System.Windows.Forms.Label rss;
        private System.Windows.Forms.Label artykul2;
        private System.Windows.Forms.Label artykul1;
        private System.Windows.Forms.Label reklama;
        private System.Windows.Forms.Label nazwa;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Button generujRaportButton;
        private System.Windows.Forms.Label ban;
    }
}


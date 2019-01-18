namespace btMetrics
{
    partial class Form1
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
            this.TabBox = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.UserSortBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UserListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.userInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.KnownAliasesListBox = new System.Windows.Forms.ListBox();
            this.KnownIPListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.JoinDateTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TimePlayedTextBox = new System.Windows.Forms.TextBox();
            this.LastKnownIPTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SortedUserListBox = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.SongSortType = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SongListBox = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.SearchSongTextBox = new System.Windows.Forms.TextBox();
            this.SongSearchButton = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.SongTitleTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FirstPlayedTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TotalPlayedTextBox = new System.Windows.Forms.TextBox();
            this.LastPlayedTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SortBar = new System.Windows.Forms.ToolStripProgressBar();
            this.SortBarText = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.TabBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.userInfoGroupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabBox
            // 
            this.TabBox.Controls.Add(this.tabPage1);
            this.TabBox.Controls.Add(this.tabPage2);
            this.TabBox.Controls.Add(this.tabPage3);
            this.TabBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabBox.Location = new System.Drawing.Point(0, 0);
            this.TabBox.Multiline = true;
            this.TabBox.Name = "TabBox";
            this.TabBox.SelectedIndex = 0;
            this.TabBox.Size = new System.Drawing.Size(449, 644);
            this.TabBox.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.userInfoGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(441, 618);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.UserSortBox);
            this.groupBox8.Location = new System.Drawing.Point(3, 545);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(212, 51);
            this.groupBox8.TabIndex = 21;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Sort Type";
            // 
            // UserSortBox
            // 
            this.UserSortBox.FormattingEnabled = true;
            this.UserSortBox.Items.AddRange(new object[] {
            "Alphabetical",
            "Total Online Time",
            "Join Date"});
            this.UserSortBox.Location = new System.Drawing.Point(10, 19);
            this.UserSortBox.Name = "UserSortBox";
            this.UserSortBox.Size = new System.Drawing.Size(190, 21);
            this.UserSortBox.TabIndex = 0;
            this.UserSortBox.SelectedIndexChanged += new System.EventHandler(this.UserSortBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UserListBox);
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 533);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Users:";
            // 
            // UserListBox
            // 
            this.UserListBox.FormattingEnabled = true;
            this.UserListBox.Location = new System.Drawing.Point(10, 19);
            this.UserListBox.Name = "UserListBox";
            this.UserListBox.Size = new System.Drawing.Size(190, 498);
            this.UserListBox.TabIndex = 0;
            this.UserListBox.SelectedIndexChanged += new System.EventHandler(this.UserListBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.SearchTextBox);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Location = new System.Drawing.Point(221, 516);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 80);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search User:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Dump";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(17, 19);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(177, 20);
            this.SearchTextBox.TabIndex = 9;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(119, 45);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 10;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // userInfoGroupBox
            // 
            this.userInfoGroupBox.AutoSize = true;
            this.userInfoGroupBox.Controls.Add(this.KnownAliasesListBox);
            this.userInfoGroupBox.Controls.Add(this.KnownIPListBox);
            this.userInfoGroupBox.Controls.Add(this.label2);
            this.userInfoGroupBox.Controls.Add(this.JoinDateTextBox);
            this.userInfoGroupBox.Controls.Add(this.label7);
            this.userInfoGroupBox.Controls.Add(this.label3);
            this.userInfoGroupBox.Controls.Add(this.label6);
            this.userInfoGroupBox.Controls.Add(this.TimePlayedTextBox);
            this.userInfoGroupBox.Controls.Add(this.LastKnownIPTextBox);
            this.userInfoGroupBox.Controls.Add(this.label4);
            this.userInfoGroupBox.Location = new System.Drawing.Point(221, 6);
            this.userInfoGroupBox.Name = "userInfoGroupBox";
            this.userInfoGroupBox.Size = new System.Drawing.Size(215, 503);
            this.userInfoGroupBox.TabIndex = 18;
            this.userInfoGroupBox.TabStop = false;
            this.userInfoGroupBox.Text = "User Info:";
            // 
            // KnownAliasesListBox
            // 
            this.KnownAliasesListBox.FormattingEnabled = true;
            this.KnownAliasesListBox.Location = new System.Drawing.Point(17, 322);
            this.KnownAliasesListBox.Name = "KnownAliasesListBox";
            this.KnownAliasesListBox.Size = new System.Drawing.Size(177, 160);
            this.KnownAliasesListBox.TabIndex = 16;
            // 
            // KnownIPListBox
            // 
            this.KnownIPListBox.FormattingEnabled = true;
            this.KnownIPListBox.Location = new System.Drawing.Point(17, 152);
            this.KnownIPListBox.Name = "KnownIPListBox";
            this.KnownIPListBox.Size = new System.Drawing.Size(177, 147);
            this.KnownIPListBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Join Date:";
            // 
            // JoinDateTextBox
            // 
            this.JoinDateTextBox.Location = new System.Drawing.Point(17, 35);
            this.JoinDateTextBox.Name = "JoinDateTextBox";
            this.JoinDateTextBox.Size = new System.Drawing.Size(177, 20);
            this.JoinDateTextBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Known Aliases/Associates:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Time Online:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Known IPs:";
            // 
            // TimePlayedTextBox
            // 
            this.TimePlayedTextBox.Location = new System.Drawing.Point(17, 74);
            this.TimePlayedTextBox.Name = "TimePlayedTextBox";
            this.TimePlayedTextBox.Size = new System.Drawing.Size(177, 20);
            this.TimePlayedTextBox.TabIndex = 4;
            // 
            // LastKnownIPTextBox
            // 
            this.LastKnownIPTextBox.Location = new System.Drawing.Point(17, 113);
            this.LastKnownIPTextBox.Name = "LastKnownIPTextBox";
            this.LastKnownIPTextBox.Size = new System.Drawing.Size(177, 20);
            this.LastKnownIPTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Known IP:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(441, 618);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "UserMetrics";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Location = new System.Drawing.Point(221, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 503);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "User Info:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Join Date:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Total Time Online:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 20);
            this.textBox2.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SortedUserListBox);
            this.groupBox3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBox3.Location = new System.Drawing.Point(3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 590);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Users:";
            // 
            // SortedUserListBox
            // 
            this.SortedUserListBox.FormattingEnabled = true;
            this.SortedUserListBox.Location = new System.Drawing.Point(10, 19);
            this.SortedUserListBox.Name = "SortedUserListBox";
            this.SortedUserListBox.Size = new System.Drawing.Size(190, 563);
            this.SortedUserListBox.Sorted = true;
            this.SortedUserListBox.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox9);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(441, 618);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Songs";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.SongSortType);
            this.groupBox9.Location = new System.Drawing.Point(4, 544);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(212, 51);
            this.groupBox9.TabIndex = 24;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Sort Type";
            // 
            // SongSortType
            // 
            this.SongSortType.FormattingEnabled = true;
            this.SongSortType.Items.AddRange(new object[] {
            "Alphabetical",
            "Times Played"});
            this.SongSortType.Location = new System.Drawing.Point(10, 19);
            this.SongSortType.Name = "SongSortType";
            this.SongSortType.Size = new System.Drawing.Size(190, 21);
            this.SongSortType.TabIndex = 0;
            this.SongSortType.SelectedIndexChanged += new System.EventHandler(this.SongSortType_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SongListBox);
            this.groupBox5.Location = new System.Drawing.Point(4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(212, 533);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Songs:";
            // 
            // SongListBox
            // 
            this.SongListBox.FormattingEnabled = true;
            this.SongListBox.Location = new System.Drawing.Point(10, 19);
            this.SongListBox.Name = "SongListBox";
            this.SongListBox.Size = new System.Drawing.Size(190, 498);
            this.SongListBox.TabIndex = 0;
            this.SongListBox.SelectedIndexChanged += new System.EventHandler(this.SongListBox_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.SearchSongTextBox);
            this.groupBox6.Controls.Add(this.SongSearchButton);
            this.groupBox6.Location = new System.Drawing.Point(222, 515);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(215, 80);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Search Song:";
            // 
            // SearchSongTextBox
            // 
            this.SearchSongTextBox.Location = new System.Drawing.Point(17, 19);
            this.SearchSongTextBox.Name = "SearchSongTextBox";
            this.SearchSongTextBox.Size = new System.Drawing.Size(177, 20);
            this.SearchSongTextBox.TabIndex = 9;
            // 
            // SongSearchButton
            // 
            this.SongSearchButton.Location = new System.Drawing.Point(119, 45);
            this.SongSearchButton.Name = "SongSearchButton";
            this.SongSearchButton.Size = new System.Drawing.Size(75, 23);
            this.SongSearchButton.TabIndex = 10;
            this.SongSearchButton.Text = "Search";
            this.SongSearchButton.UseVisualStyleBackColor = true;
            this.SongSearchButton.Click += new System.EventHandler(this.SongSearchButton_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.AutoSize = true;
            this.groupBox7.Controls.Add(this.SongTitleTextBox);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.textBox3);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.FirstPlayedTextBox);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.TotalPlayedTextBox);
            this.groupBox7.Controls.Add(this.LastPlayedTextBox);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Location = new System.Drawing.Point(222, 5);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(215, 503);
            this.groupBox7.TabIndex = 21;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Song Info:";
            // 
            // SongTitleTextBox
            // 
            this.SongTitleTextBox.Location = new System.Drawing.Point(17, 191);
            this.SongTitleTextBox.Name = "SongTitleTextBox";
            this.SongTitleTextBox.Size = new System.Drawing.Size(177, 20);
            this.SongTitleTextBox.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Song Title:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(17, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 20);
            this.textBox3.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Last Played:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "First Played";
            // 
            // FirstPlayedTextBox
            // 
            this.FirstPlayedTextBox.Location = new System.Drawing.Point(17, 35);
            this.FirstPlayedTextBox.Name = "FirstPlayedTextBox";
            this.FirstPlayedTextBox.Size = new System.Drawing.Size(177, 20);
            this.FirstPlayedTextBox.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Total Times Played:";
            // 
            // TotalPlayedTextBox
            // 
            this.TotalPlayedTextBox.Location = new System.Drawing.Point(17, 74);
            this.TotalPlayedTextBox.Name = "TotalPlayedTextBox";
            this.TotalPlayedTextBox.Size = new System.Drawing.Size(177, 20);
            this.TotalPlayedTextBox.TabIndex = 4;
            // 
            // LastPlayedTextBox
            // 
            this.LastPlayedTextBox.Location = new System.Drawing.Point(17, 113);
            this.LastPlayedTextBox.Name = "LastPlayedTextBox";
            this.LastPlayedTextBox.Size = new System.Drawing.Size(177, 20);
            this.LastPlayedTextBox.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Last Played:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortBar,
            this.SortBarText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 622);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(449, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SortBar
            // 
            this.SortBar.Name = "SortBar";
            this.SortBar.Size = new System.Drawing.Size(300, 16);
            this.SortBar.Step = 1;
            this.SortBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.SortBar.Visible = false;
            // 
            // SortBarText
            // 
            this.SortBarText.Name = "SortBarText";
            this.SortBarText.Size = new System.Drawing.Size(45, 17);
            this.SortBarText.Text = "Sorting";
            this.SortBarText.Visible = false;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.background_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.background_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 644);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TabBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "BT Metrics";
            this.TabBox.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.userInfoGroupBox.ResumeLayout(false);
            this.userInfoGroupBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ListBox UserListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.GroupBox userInfoGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox JoinDateTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TimePlayedTextBox;
        private System.Windows.Forms.TextBox LastKnownIPTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.ListBox SortedUserListBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox KnownAliasesListBox;
        private System.Windows.Forms.ListBox KnownIPListBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.ListBox SongListBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox SearchSongTextBox;
        private System.Windows.Forms.Button SongSearchButton;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FirstPlayedTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TotalPlayedTextBox;
        private System.Windows.Forms.TextBox LastPlayedTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SongTitleTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox UserSortBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar SortBar;
        private System.Windows.Forms.ToolStripStatusLabel SortBarText;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ComboBox SongSortType;
        private System.Windows.Forms.Button button1;


    }
}


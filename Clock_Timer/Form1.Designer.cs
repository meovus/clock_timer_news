namespace Clock_Timer
{
    partial class TimerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
            this.exitbtn = new System.Windows.Forms.Button();
            this.toppanel = new System.Windows.Forms.Panel();
            this.minimizebtn = new System.Windows.Forms.Button();
            this.alarmpicture = new System.Windows.Forms.PictureBox();
            this.timelbl = new System.Windows.Forms.Label();
            this.calenderpicture = new System.Windows.Forms.PictureBox();
            this.datelbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clockpicture = new System.Windows.Forms.PictureBox();
            this.setalarm = new System.Windows.Forms.Button();
            this.stopalarm = new System.Windows.Forms.Button();
            this.clock_timer = new System.Windows.Forms.Timer(this.components);
            this.alarm_timer = new System.Windows.Forms.Timer(this.components);
            this.alarmprogress = new System.Windows.Forms.ProgressBar();
            this.alarmcounterlbl = new System.Windows.Forms.Label();
            this.discordbtn = new System.Windows.Forms.Button();
            this.onlinesystembtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.konya_temp_lbl = new System.Windows.Forms.Label();
            this.konya_wth_status = new System.Windows.Forms.Label();
            this.temperaturepic1 = new System.Windows.Forms.PictureBox();
            this.havadurumu1 = new System.Windows.Forms.PictureBox();
            this.ıstanbullbl = new System.Windows.Forms.Label();
            this.temp_istanbul_lbl = new System.Windows.Forms.Label();
            this.temp_istanbul_pic = new System.Windows.Forms.PictureBox();
            this.wthr_istanbul_pic = new System.Windows.Forms.PictureBox();
            this.wthr_istanbul_lbl = new System.Windows.Forms.Label();
            this.konya_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.alarmsoundbox = new System.Windows.Forms.ComboBox();
            this.timevaluepic = new System.Windows.Forms.PictureBox();
            this.soundpic = new System.Windows.Forms.PictureBox();
            this.githublogin = new System.Windows.Forms.Button();
            this.newsbtn = new System.Windows.Forms.Button();
            this.headlinenewsbtn = new System.Windows.Forms.Button();
            this.breakingnewsbtn = new System.Windows.Forms.Button();
            this.lifenewsbtn = new System.Windows.Forms.Button();
            this.currencypanel = new System.Windows.Forms.Panel();
            this.currencybox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.obslogbuton = new System.Windows.Forms.Button();
            this.userformbtn = new System.Windows.Forms.Button();
            this.alarmnotebtn = new System.Windows.Forms.Button();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alarmpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calenderpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clockpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperaturepic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.havadurumu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_istanbul_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wthr_istanbul_pic)).BeginInit();
            this.konya_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timevaluepic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundpic)).BeginInit();
            this.currencypanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitbtn
            // 
            this.exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitbtn.Location = new System.Drawing.Point(456, 3);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(30, 30);
            this.exitbtn.TabIndex = 0;
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.toppanel.Controls.Add(this.minimizebtn);
            this.toppanel.Controls.Add(this.exitbtn);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.ForeColor = System.Drawing.Color.White;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(489, 37);
            this.toppanel.TabIndex = 1;
            this.toppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseDown);
            this.toppanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseMove);
            this.toppanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseUp);
            // 
            // minimizebtn
            // 
            this.minimizebtn.Location = new System.Drawing.Point(422, 5);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.Size = new System.Drawing.Size(28, 28);
            this.minimizebtn.TabIndex = 29;
            this.minimizebtn.UseVisualStyleBackColor = true;
            this.minimizebtn.Click += new System.EventHandler(this.minimizebtn_Click);
            // 
            // alarmpicture
            // 
            this.alarmpicture.Image = ((System.Drawing.Image)(resources.GetObject("alarmpicture.Image")));
            this.alarmpicture.Location = new System.Drawing.Point(365, 102);
            this.alarmpicture.Name = "alarmpicture";
            this.alarmpicture.Size = new System.Drawing.Size(53, 51);
            this.alarmpicture.TabIndex = 2;
            this.alarmpicture.TabStop = false;
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timelbl.Location = new System.Drawing.Point(94, 84);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(52, 25);
            this.timelbl.TabIndex = 3;
            this.timelbl.Text = "time";
            // 
            // calenderpicture
            // 
            this.calenderpicture.Location = new System.Drawing.Point(19, 126);
            this.calenderpicture.Name = "calenderpicture";
            this.calenderpicture.Size = new System.Drawing.Size(52, 53);
            this.calenderpicture.TabIndex = 4;
            this.calenderpicture.TabStop = false;
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.datelbl.Location = new System.Drawing.Point(92, 144);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(54, 25);
            this.datelbl.TabIndex = 5;
            this.datelbl.Text = "date";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "5 min",
            "10 min",
            "20 min",
            "30 min ",
            "40 min",
            "50 min",
            "60 min",
            "70 min",
            "80 min",
            "90 min",
            "100 min",
            "110 min",
            "120 min",
            "150 min"});
            this.comboBox1.Location = new System.Drawing.Point(50, 207);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // clockpicture
            // 
            this.clockpicture.Location = new System.Drawing.Point(19, 71);
            this.clockpicture.Name = "clockpicture";
            this.clockpicture.Size = new System.Drawing.Size(55, 49);
            this.clockpicture.TabIndex = 7;
            this.clockpicture.TabStop = false;
            // 
            // setalarm
            // 
            this.setalarm.BackColor = System.Drawing.Color.Thistle;
            this.setalarm.FlatAppearance.BorderSize = 0;
            this.setalarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setalarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.setalarm.ForeColor = System.Drawing.Color.Crimson;
            this.setalarm.Location = new System.Drawing.Point(222, 254);
            this.setalarm.Name = "setalarm";
            this.setalarm.Size = new System.Drawing.Size(126, 35);
            this.setalarm.TabIndex = 8;
            this.setalarm.Text = "Set Alarm";
            this.setalarm.UseVisualStyleBackColor = false;
            this.setalarm.Click += new System.EventHandler(this.setalarm_Click);
            // 
            // stopalarm
            // 
            this.stopalarm.BackColor = System.Drawing.Color.Thistle;
            this.stopalarm.FlatAppearance.BorderSize = 0;
            this.stopalarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopalarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stopalarm.ForeColor = System.Drawing.Color.Crimson;
            this.stopalarm.Location = new System.Drawing.Point(352, 254);
            this.stopalarm.Name = "stopalarm";
            this.stopalarm.Size = new System.Drawing.Size(125, 35);
            this.stopalarm.TabIndex = 9;
            this.stopalarm.Text = "Stop Alarm";
            this.stopalarm.UseVisualStyleBackColor = false;
            this.stopalarm.Click += new System.EventHandler(this.stopalarm_Click);
            // 
            // clock_timer
            // 
            this.clock_timer.Interval = 1000;
            this.clock_timer.Tick += new System.EventHandler(this.clock_timer_Tick);
            // 
            // alarm_timer
            // 
            this.alarm_timer.Interval = 1000;
            this.alarm_timer.Tick += new System.EventHandler(this.alarm_timer_Tick);
            // 
            // alarmprogress
            // 
            this.alarmprogress.Location = new System.Drawing.Point(376, 159);
            this.alarmprogress.MarqueeAnimationSpeed = 3000;
            this.alarmprogress.Maximum = 10000;
            this.alarmprogress.Name = "alarmprogress";
            this.alarmprogress.Size = new System.Drawing.Size(98, 20);
            this.alarmprogress.TabIndex = 12;
            // 
            // alarmcounterlbl
            // 
            this.alarmcounterlbl.AutoSize = true;
            this.alarmcounterlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alarmcounterlbl.Location = new System.Drawing.Point(412, 116);
            this.alarmcounterlbl.Name = "alarmcounterlbl";
            this.alarmcounterlbl.Size = new System.Drawing.Size(65, 25);
            this.alarmcounterlbl.TabIndex = 13;
            this.alarmcounterlbl.Text = "alarm";
            // 
            // discordbtn
            // 
            this.discordbtn.Location = new System.Drawing.Point(437, 43);
            this.discordbtn.Name = "discordbtn";
            this.discordbtn.Size = new System.Drawing.Size(40, 40);
            this.discordbtn.TabIndex = 14;
            this.discordbtn.UseVisualStyleBackColor = true;
            this.discordbtn.Click += new System.EventHandler(this.discordbtn_Click);
            // 
            // onlinesystembtn
            // 
            this.onlinesystembtn.Location = new System.Drawing.Point(390, 43);
            this.onlinesystembtn.Name = "onlinesystembtn";
            this.onlinesystembtn.Size = new System.Drawing.Size(40, 40);
            this.onlinesystembtn.TabIndex = 15;
            this.onlinesystembtn.UseVisualStyleBackColor = true;
            this.onlinesystembtn.Click += new System.EventHandler(this.onlinesystembtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Konya";
            // 
            // konya_temp_lbl
            // 
            this.konya_temp_lbl.AutoSize = true;
            this.konya_temp_lbl.BackColor = System.Drawing.Color.Crimson;
            this.konya_temp_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.konya_temp_lbl.ForeColor = System.Drawing.Color.White;
            this.konya_temp_lbl.Location = new System.Drawing.Point(51, 50);
            this.konya_temp_lbl.Name = "konya_temp_lbl";
            this.konya_temp_lbl.Size = new System.Drawing.Size(49, 20);
            this.konya_temp_lbl.TabIndex = 18;
            this.konya_temp_lbl.Text = "temp";
            // 
            // konya_wth_status
            // 
            this.konya_wth_status.AutoSize = true;
            this.konya_wth_status.BackColor = System.Drawing.Color.Crimson;
            this.konya_wth_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.konya_wth_status.ForeColor = System.Drawing.Color.White;
            this.konya_wth_status.Location = new System.Drawing.Point(54, 88);
            this.konya_wth_status.Name = "konya_wth_status";
            this.konya_wth_status.Size = new System.Drawing.Size(43, 20);
            this.konya_wth_status.TabIndex = 19;
            this.konya_wth_status.Text = "wthr";
            // 
            // temperaturepic1
            // 
            this.temperaturepic1.Location = new System.Drawing.Point(13, 43);
            this.temperaturepic1.Name = "temperaturepic1";
            this.temperaturepic1.Size = new System.Drawing.Size(32, 32);
            this.temperaturepic1.TabIndex = 20;
            this.temperaturepic1.TabStop = false;
            // 
            // havadurumu1
            // 
            this.havadurumu1.Location = new System.Drawing.Point(13, 84);
            this.havadurumu1.Name = "havadurumu1";
            this.havadurumu1.Size = new System.Drawing.Size(32, 32);
            this.havadurumu1.TabIndex = 21;
            this.havadurumu1.TabStop = false;
            // 
            // ıstanbullbl
            // 
            this.ıstanbullbl.AutoSize = true;
            this.ıstanbullbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıstanbullbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ıstanbullbl.Location = new System.Drawing.Point(53, 10);
            this.ıstanbullbl.Name = "ıstanbullbl";
            this.ıstanbullbl.Size = new System.Drawing.Size(104, 29);
            this.ıstanbullbl.TabIndex = 22;
            this.ıstanbullbl.Text = "İstanbul";
            // 
            // temp_istanbul_lbl
            // 
            this.temp_istanbul_lbl.AutoSize = true;
            this.temp_istanbul_lbl.BackColor = System.Drawing.Color.Crimson;
            this.temp_istanbul_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temp_istanbul_lbl.ForeColor = System.Drawing.Color.White;
            this.temp_istanbul_lbl.Location = new System.Drawing.Point(51, 50);
            this.temp_istanbul_lbl.Name = "temp_istanbul_lbl";
            this.temp_istanbul_lbl.Size = new System.Drawing.Size(49, 20);
            this.temp_istanbul_lbl.TabIndex = 23;
            this.temp_istanbul_lbl.Text = "temp";
            // 
            // temp_istanbul_pic
            // 
            this.temp_istanbul_pic.Location = new System.Drawing.Point(13, 46);
            this.temp_istanbul_pic.Name = "temp_istanbul_pic";
            this.temp_istanbul_pic.Size = new System.Drawing.Size(32, 32);
            this.temp_istanbul_pic.TabIndex = 24;
            this.temp_istanbul_pic.TabStop = false;
            // 
            // wthr_istanbul_pic
            // 
            this.wthr_istanbul_pic.Location = new System.Drawing.Point(13, 84);
            this.wthr_istanbul_pic.Name = "wthr_istanbul_pic";
            this.wthr_istanbul_pic.Size = new System.Drawing.Size(32, 32);
            this.wthr_istanbul_pic.TabIndex = 25;
            this.wthr_istanbul_pic.TabStop = false;
            // 
            // wthr_istanbul_lbl
            // 
            this.wthr_istanbul_lbl.AutoSize = true;
            this.wthr_istanbul_lbl.BackColor = System.Drawing.Color.Crimson;
            this.wthr_istanbul_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wthr_istanbul_lbl.ForeColor = System.Drawing.Color.White;
            this.wthr_istanbul_lbl.Location = new System.Drawing.Point(51, 89);
            this.wthr_istanbul_lbl.Name = "wthr_istanbul_lbl";
            this.wthr_istanbul_lbl.Size = new System.Drawing.Size(43, 20);
            this.wthr_istanbul_lbl.TabIndex = 26;
            this.wthr_istanbul_lbl.Text = "wthr";
            // 
            // konya_panel
            // 
            this.konya_panel.BackColor = System.Drawing.Color.Thistle;
            this.konya_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.konya_panel.Controls.Add(this.label1);
            this.konya_panel.Controls.Add(this.temperaturepic1);
            this.konya_panel.Controls.Add(this.konya_temp_lbl);
            this.konya_panel.Controls.Add(this.havadurumu1);
            this.konya_panel.Controls.Add(this.konya_wth_status);
            this.konya_panel.Location = new System.Drawing.Point(12, 254);
            this.konya_panel.Name = "konya_panel";
            this.konya_panel.Size = new System.Drawing.Size(204, 144);
            this.konya_panel.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ıstanbullbl);
            this.panel1.Controls.Add(this.temp_istanbul_pic);
            this.panel1.Controls.Add(this.wthr_istanbul_lbl);
            this.panel1.Controls.Add(this.temp_istanbul_lbl);
            this.panel1.Controls.Add(this.wthr_istanbul_pic);
            this.panel1.Location = new System.Drawing.Point(12, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 140);
            this.panel1.TabIndex = 28;
            // 
            // alarmsoundbox
            // 
            this.alarmsoundbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alarmsoundbox.FormattingEnabled = true;
            this.alarmsoundbox.Items.AddRange(new object[] {
            "DefaultAlarm",
            "WinAlarm",
            "MorningAlarm",
            "WarningBuzer"});
            this.alarmsoundbox.Location = new System.Drawing.Point(232, 207);
            this.alarmsoundbox.Name = "alarmsoundbox";
            this.alarmsoundbox.Size = new System.Drawing.Size(188, 28);
            this.alarmsoundbox.TabIndex = 29;
            // 
            // timevaluepic
            // 
            this.timevaluepic.Location = new System.Drawing.Point(12, 204);
            this.timevaluepic.Name = "timevaluepic";
            this.timevaluepic.Size = new System.Drawing.Size(32, 32);
            this.timevaluepic.TabIndex = 30;
            this.timevaluepic.TabStop = false;
            // 
            // soundpic
            // 
            this.soundpic.Location = new System.Drawing.Point(194, 204);
            this.soundpic.Name = "soundpic";
            this.soundpic.Size = new System.Drawing.Size(32, 32);
            this.soundpic.TabIndex = 31;
            this.soundpic.TabStop = false;
            // 
            // githublogin
            // 
            this.githublogin.Location = new System.Drawing.Point(344, 43);
            this.githublogin.Name = "githublogin";
            this.githublogin.Size = new System.Drawing.Size(40, 40);
            this.githublogin.TabIndex = 36;
            this.githublogin.UseVisualStyleBackColor = true;
            this.githublogin.Click += new System.EventHandler(this.githublogin_Click);
            // 
            // newsbtn
            // 
            this.newsbtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.newsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newsbtn.ForeColor = System.Drawing.Color.Crimson;
            this.newsbtn.Location = new System.Drawing.Point(222, 304);
            this.newsbtn.Name = "newsbtn";
            this.newsbtn.Size = new System.Drawing.Size(114, 45);
            this.newsbtn.TabIndex = 38;
            this.newsbtn.Text = "World News";
            this.newsbtn.UseVisualStyleBackColor = false;
            this.newsbtn.Click += new System.EventHandler(this.newsbtn_Click);
            // 
            // headlinenewsbtn
            // 
            this.headlinenewsbtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.headlinenewsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.headlinenewsbtn.ForeColor = System.Drawing.Color.Crimson;
            this.headlinenewsbtn.Location = new System.Drawing.Point(340, 304);
            this.headlinenewsbtn.Name = "headlinenewsbtn";
            this.headlinenewsbtn.Size = new System.Drawing.Size(137, 45);
            this.headlinenewsbtn.TabIndex = 39;
            this.headlinenewsbtn.Text = "Headline News";
            this.headlinenewsbtn.UseVisualStyleBackColor = false;
            this.headlinenewsbtn.Click += new System.EventHandler(this.headlinenewsbtn_Click);
            // 
            // breakingnewsbtn
            // 
            this.breakingnewsbtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.breakingnewsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.breakingnewsbtn.ForeColor = System.Drawing.Color.Crimson;
            this.breakingnewsbtn.Location = new System.Drawing.Point(222, 355);
            this.breakingnewsbtn.Name = "breakingnewsbtn";
            this.breakingnewsbtn.Size = new System.Drawing.Size(141, 45);
            this.breakingnewsbtn.TabIndex = 40;
            this.breakingnewsbtn.Text = "Breaking News";
            this.breakingnewsbtn.UseVisualStyleBackColor = false;
            this.breakingnewsbtn.Click += new System.EventHandler(this.breakingnewsbtn_Click);
            // 
            // lifenewsbtn
            // 
            this.lifenewsbtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lifenewsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lifenewsbtn.ForeColor = System.Drawing.Color.Crimson;
            this.lifenewsbtn.Location = new System.Drawing.Point(365, 355);
            this.lifenewsbtn.Name = "lifenewsbtn";
            this.lifenewsbtn.Size = new System.Drawing.Size(112, 45);
            this.lifenewsbtn.TabIndex = 41;
            this.lifenewsbtn.Text = "Life News";
            this.lifenewsbtn.UseVisualStyleBackColor = false;
            this.lifenewsbtn.Click += new System.EventHandler(this.lifenewsbtn_Click);
            // 
            // currencypanel
            // 
            this.currencypanel.BackColor = System.Drawing.Color.Thistle;
            this.currencypanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currencypanel.Controls.Add(this.currencybox);
            this.currencypanel.Controls.Add(this.label2);
            this.currencypanel.Location = new System.Drawing.Point(222, 407);
            this.currencypanel.Name = "currencypanel";
            this.currencypanel.Size = new System.Drawing.Size(255, 140);
            this.currencypanel.TabIndex = 42;
            // 
            // currencybox
            // 
            this.currencybox.BackColor = System.Drawing.Color.Thistle;
            this.currencybox.Enabled = false;
            this.currencybox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.currencybox.ForeColor = System.Drawing.Color.MediumBlue;
            this.currencybox.Location = new System.Drawing.Point(6, 46);
            this.currencybox.Name = "currencybox";
            this.currencybox.Size = new System.Drawing.Size(243, 88);
            this.currencybox.TabIndex = 3;
            this.currencybox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(76, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Currency";
            // 
            // obslogbuton
            // 
            this.obslogbuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.obslogbuton.Location = new System.Drawing.Point(295, 43);
            this.obslogbuton.Name = "obslogbuton";
            this.obslogbuton.Size = new System.Drawing.Size(43, 40);
            this.obslogbuton.TabIndex = 43;
            this.obslogbuton.UseVisualStyleBackColor = true;
            this.obslogbuton.Click += new System.EventHandler(this.obslogbuton_Click);
            // 
            // userformbtn
            // 
            this.userformbtn.Location = new System.Drawing.Point(248, 43);
            this.userformbtn.Name = "userformbtn";
            this.userformbtn.Size = new System.Drawing.Size(41, 40);
            this.userformbtn.TabIndex = 44;
            this.userformbtn.UseVisualStyleBackColor = true;
            this.userformbtn.Click += new System.EventHandler(this.userformbtn_Click);
            // 
            // alarmnotebtn
            // 
            this.alarmnotebtn.FlatAppearance.BorderSize = 0;
            this.alarmnotebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alarmnotebtn.Location = new System.Drawing.Point(432, 204);
            this.alarmnotebtn.Name = "alarmnotebtn";
            this.alarmnotebtn.Size = new System.Drawing.Size(32, 32);
            this.alarmnotebtn.TabIndex = 45;
            this.alarmnotebtn.UseVisualStyleBackColor = true;
            this.alarmnotebtn.Click += new System.EventHandler(this.alarmnotebtn_Click);
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(489, 559);
            this.Controls.Add(this.alarmnotebtn);
            this.Controls.Add(this.userformbtn);
            this.Controls.Add(this.obslogbuton);
            this.Controls.Add(this.currencypanel);
            this.Controls.Add(this.lifenewsbtn);
            this.Controls.Add(this.breakingnewsbtn);
            this.Controls.Add(this.headlinenewsbtn);
            this.Controls.Add(this.newsbtn);
            this.Controls.Add(this.githublogin);
            this.Controls.Add(this.soundpic);
            this.Controls.Add(this.timevaluepic);
            this.Controls.Add(this.alarmsoundbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.konya_panel);
            this.Controls.Add(this.onlinesystembtn);
            this.Controls.Add(this.discordbtn);
            this.Controls.Add(this.alarmcounterlbl);
            this.Controls.Add(this.alarmprogress);
            this.Controls.Add(this.stopalarm);
            this.Controls.Add(this.setalarm);
            this.Controls.Add(this.clockpicture);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.calenderpicture);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.alarmpicture);
            this.Controls.Add(this.toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimerForm";
            this.Opacity = 0.95D;
            this.Text = "TimerForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toppanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alarmpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calenderpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clockpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperaturepic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.havadurumu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_istanbul_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wthr_istanbul_pic)).EndInit();
            this.konya_panel.ResumeLayout(false);
            this.konya_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timevaluepic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundpic)).EndInit();
            this.currencypanel.ResumeLayout(false);
            this.currencypanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.PictureBox alarmpicture;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.PictureBox calenderpicture;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox clockpicture;
        private System.Windows.Forms.Button setalarm;
        private System.Windows.Forms.Button stopalarm;
        private System.Windows.Forms.Timer clock_timer;
        private System.Windows.Forms.Timer alarm_timer;
        private System.Windows.Forms.ProgressBar alarmprogress;
        private System.Windows.Forms.Label alarmcounterlbl;
        private System.Windows.Forms.Button discordbtn;
        private System.Windows.Forms.Button onlinesystembtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label konya_temp_lbl;
        private System.Windows.Forms.Label konya_wth_status;
        private System.Windows.Forms.PictureBox temperaturepic1;
        private System.Windows.Forms.PictureBox havadurumu1;
        private System.Windows.Forms.Label ıstanbullbl;
        private System.Windows.Forms.Label temp_istanbul_lbl;
        private System.Windows.Forms.PictureBox temp_istanbul_pic;
        private System.Windows.Forms.PictureBox wthr_istanbul_pic;
        private System.Windows.Forms.Label wthr_istanbul_lbl;
        private System.Windows.Forms.Panel konya_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minimizebtn;
        private System.Windows.Forms.ComboBox alarmsoundbox;
        private System.Windows.Forms.PictureBox timevaluepic;
        private System.Windows.Forms.PictureBox soundpic;
        private System.Windows.Forms.Button githublogin;
        private System.Windows.Forms.Button newsbtn;
        private System.Windows.Forms.Button headlinenewsbtn;
        private System.Windows.Forms.Button breakingnewsbtn;
        private System.Windows.Forms.Button lifenewsbtn;
        private System.Windows.Forms.Panel currencypanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox currencybox;
        private System.Windows.Forms.Button obslogbuton;
        private System.Windows.Forms.Button userformbtn;
        private System.Windows.Forms.Button alarmnotebtn;
    }
}


namespace Clock_Timer
{
    partial class NewsForm
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
            this.exitbuton = new System.Windows.Forms.Button();
            this.toppanel = new System.Windows.Forms.Panel();
            this.minimizebtn = new System.Windows.Forms.Button();
            this.news_timer = new System.Windows.Forms.Timer(this.components);
            this.worldcontentbox = new System.Windows.Forms.RichTextBox();
            this.worldtitle = new System.Windows.Forms.RichTextBox();
            this.next_wnews_btn = new System.Windows.Forms.Button();
            this.world_news_pic = new System.Windows.Forms.PictureBox();
            this.backnews = new System.Windows.Forms.Button();
            this.newsname = new System.Windows.Forms.Label();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.world_news_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // exitbuton
            // 
            this.exitbuton.Location = new System.Drawing.Point(593, 3);
            this.exitbuton.Name = "exitbuton";
            this.exitbuton.Size = new System.Drawing.Size(32, 32);
            this.exitbuton.TabIndex = 0;
            this.exitbuton.UseVisualStyleBackColor = true;
            this.exitbuton.Click += new System.EventHandler(this.exitbuton_Click);
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.toppanel.Controls.Add(this.newsname);
            this.toppanel.Controls.Add(this.minimizebtn);
            this.toppanel.Controls.Add(this.exitbuton);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(631, 37);
            this.toppanel.TabIndex = 1;
            this.toppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseDown);
            this.toppanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseMove);
            this.toppanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseUp);
            // 
            // minimizebtn
            // 
            this.minimizebtn.Location = new System.Drawing.Point(556, 3);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.Size = new System.Drawing.Size(31, 31);
            this.minimizebtn.TabIndex = 2;
            this.minimizebtn.UseVisualStyleBackColor = true;
            this.minimizebtn.Click += new System.EventHandler(this.minimizebtn_Click);
            // 
            // news_timer
            // 
            this.news_timer.Interval = 2000;
            this.news_timer.Tick += new System.EventHandler(this.news_timer_Tick);
            // 
            // worldcontentbox
            // 
            this.worldcontentbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.worldcontentbox.Cursor = System.Windows.Forms.Cursors.No;
            this.worldcontentbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.worldcontentbox.HideSelection = false;
            this.worldcontentbox.Location = new System.Drawing.Point(37, 332);
            this.worldcontentbox.Name = "worldcontentbox";
            this.worldcontentbox.Size = new System.Drawing.Size(567, 126);
            this.worldcontentbox.TabIndex = 1;
            this.worldcontentbox.Text = "";
            this.worldcontentbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.worldcontentbox_KeyPress);
            // 
            // worldtitle
            // 
            this.worldtitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.worldtitle.Cursor = System.Windows.Forms.Cursors.No;
            this.worldtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.worldtitle.ForeColor = System.Drawing.Color.Brown;
            this.worldtitle.Location = new System.Drawing.Point(37, 269);
            this.worldtitle.Name = "worldtitle";
            this.worldtitle.Size = new System.Drawing.Size(567, 57);
            this.worldtitle.TabIndex = 2;
            this.worldtitle.Text = "";
            this.worldtitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.worldtitle_KeyPress);
            // 
            // next_wnews_btn
            // 
            this.next_wnews_btn.FlatAppearance.BorderSize = 0;
            this.next_wnews_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_wnews_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.next_wnews_btn.Location = new System.Drawing.Point(509, 127);
            this.next_wnews_btn.Name = "next_wnews_btn";
            this.next_wnews_btn.Size = new System.Drawing.Size(44, 48);
            this.next_wnews_btn.TabIndex = 3;
            this.next_wnews_btn.Text = ">>";
            this.next_wnews_btn.UseVisualStyleBackColor = true;
            this.next_wnews_btn.Click += new System.EventHandler(this.next_wnews_btn_Click);
            // 
            // world_news_pic
            // 
            this.world_news_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.world_news_pic.Location = new System.Drawing.Point(130, 43);
            this.world_news_pic.Name = "world_news_pic";
            this.world_news_pic.Size = new System.Drawing.Size(373, 210);
            this.world_news_pic.TabIndex = 3;
            this.world_news_pic.TabStop = false;
            this.world_news_pic.DoubleClick += new System.EventHandler(this.world_news_pic_DoubleClick);
            // 
            // backnews
            // 
            this.backnews.FlatAppearance.BorderSize = 0;
            this.backnews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backnews.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backnews.Location = new System.Drawing.Point(83, 127);
            this.backnews.Name = "backnews";
            this.backnews.Size = new System.Drawing.Size(41, 48);
            this.backnews.TabIndex = 4;
            this.backnews.Text = "<<";
            this.backnews.UseVisualStyleBackColor = true;
            this.backnews.Click += new System.EventHandler(this.backnews_Click);
            // 
            // newsname
            // 
            this.newsname.AutoSize = true;
            this.newsname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newsname.ForeColor = System.Drawing.Color.White;
            this.newsname.Location = new System.Drawing.Point(12, 9);
            this.newsname.Name = "newsname";
            this.newsname.Size = new System.Drawing.Size(57, 20);
            this.newsname.TabIndex = 3;
            this.newsname.Text = "label1";
            // 
            // NewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(631, 490);
            this.Controls.Add(this.backnews);
            this.Controls.Add(this.worldcontentbox);
            this.Controls.Add(this.worldtitle);
            this.Controls.Add(this.next_wnews_btn);
            this.Controls.Add(this.world_news_pic);
            this.Controls.Add(this.toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewsForm";
            this.Opacity = 0.98D;
            this.Text = "NewsForm";
            this.Load += new System.EventHandler(this.NewsForm_Load);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.world_news_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitbuton;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Button minimizebtn;
        private System.Windows.Forms.Timer news_timer;
        private System.Windows.Forms.RichTextBox worldcontentbox;
        private System.Windows.Forms.RichTextBox worldtitle;
        private System.Windows.Forms.Button next_wnews_btn;
        private System.Windows.Forms.PictureBox world_news_pic;
        private System.Windows.Forms.Button backnews;
        private System.Windows.Forms.Label newsname;
    }
}
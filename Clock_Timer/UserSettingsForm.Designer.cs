namespace Clock_Timer
{
    partial class UserSettingsForm
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
            this.exitbtn = new System.Windows.Forms.Button();
            this.toppanel = new System.Windows.Forms.Panel();
            this.updatebtn = new System.Windows.Forms.Button();
            this.obstab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.obspassbox = new System.Windows.Forms.TextBox();
            this.obsusernamebox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.oypass = new System.Windows.Forms.TextBox();
            this.oyusername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.discordpass = new System.Windows.Forms.TextBox();
            this.discordusername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.githubpass = new System.Windows.Forms.TextBox();
            this.githubusername = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.toppanel.SuspendLayout();
            this.obstab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitbtn
            // 
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitbtn.Location = new System.Drawing.Point(288, 2);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(30, 30);
            this.exitbtn.TabIndex = 0;
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.toppanel.Controls.Add(this.updatebtn);
            this.toppanel.Controls.Add(this.exitbtn);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(322, 36);
            this.toppanel.TabIndex = 1;
            this.toppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseDown);
            this.toppanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseMove);
            this.toppanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseUp);
            // 
            // updatebtn
            // 
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updatebtn.Location = new System.Drawing.Point(206, 6);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(76, 26);
            this.updatebtn.TabIndex = 1;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // obstab
            // 
            this.obstab.Controls.Add(this.tabPage1);
            this.obstab.Controls.Add(this.tabPage2);
            this.obstab.Controls.Add(this.tabPage3);
            this.obstab.Controls.Add(this.tabPage4);
            this.obstab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.obstab.Location = new System.Drawing.Point(0, 36);
            this.obstab.Name = "obstab";
            this.obstab.SelectedIndex = 0;
            this.obstab.Size = new System.Drawing.Size(322, 226);
            this.obstab.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.obspassbox);
            this.tabPage1.Controls.Add(this.obsusernamebox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(314, 200);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "OBS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(85, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "YTÜ OBS";
            // 
            // obspassbox
            // 
            this.obspassbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.obspassbox.Location = new System.Drawing.Point(105, 114);
            this.obspassbox.Name = "obspassbox";
            this.obspassbox.PasswordChar = '*';
            this.obspassbox.Size = new System.Drawing.Size(201, 26);
            this.obspassbox.TabIndex = 3;
            // 
            // obsusernamebox
            // 
            this.obsusernamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.obsusernamebox.Location = new System.Drawing.Point(105, 79);
            this.obsusernamebox.Name = "obsusernamebox";
            this.obsusernamebox.Size = new System.Drawing.Size(201, 26);
            this.obsusernamebox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(3, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(3, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username : ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.oypass);
            this.tabPage2.Controls.Add(this.oyusername);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(314, 200);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Online Yıldız";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // oypass
            // 
            this.oypass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oypass.Location = new System.Drawing.Point(106, 121);
            this.oypass.Name = "oypass";
            this.oypass.PasswordChar = '*';
            this.oypass.Size = new System.Drawing.Size(200, 26);
            this.oypass.TabIndex = 4;
            // 
            // oyusername
            // 
            this.oyusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyusername.Location = new System.Drawing.Point(106, 82);
            this.oyusername.Name = "oyusername";
            this.oyusername.Size = new System.Drawing.Size(200, 26);
            this.oyusername.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(8, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Password : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(3, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Username : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(59, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "ONLİNE YILDIZ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.discordpass);
            this.tabPage3.Controls.Add(this.discordusername);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(314, 200);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Discord";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // discordpass
            // 
            this.discordpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.discordpass.Location = new System.Drawing.Point(97, 116);
            this.discordpass.Name = "discordpass";
            this.discordpass.PasswordChar = '*';
            this.discordpass.Size = new System.Drawing.Size(197, 26);
            this.discordpass.TabIndex = 4;
            // 
            // discordusername
            // 
            this.discordusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.discordusername.Location = new System.Drawing.Point(97, 80);
            this.discordusername.Name = "discordusername";
            this.discordusername.Size = new System.Drawing.Size(197, 26);
            this.discordusername.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(3, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Password : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(3, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Username : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(75, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "DISCORD";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.githubpass);
            this.tabPage4.Controls.Add(this.githubusername);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(314, 200);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Github";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // githubpass
            // 
            this.githubpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.githubpass.Location = new System.Drawing.Point(102, 112);
            this.githubpass.Name = "githubpass";
            this.githubpass.PasswordChar = '*';
            this.githubpass.Size = new System.Drawing.Size(204, 26);
            this.githubpass.TabIndex = 4;
            // 
            // githubusername
            // 
            this.githubusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.githubusername.Location = new System.Drawing.Point(102, 80);
            this.githubusername.Name = "githubusername";
            this.githubusername.Size = new System.Drawing.Size(204, 26);
            this.githubusername.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Crimson;
            this.label12.Location = new System.Drawing.Point(8, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 18);
            this.label12.TabIndex = 2;
            this.label12.Text = "Password  : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(8, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Username : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(97, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "Github";
            // 
            // UserSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 262);
            this.Controls.Add(this.obstab);
            this.Controls.Add(this.toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserSettingsForm";
            this.Text = "UserSettingsForm";
            this.Load += new System.EventHandler(this.UserSettingsForm_Load);
            this.toppanel.ResumeLayout(false);
            this.obstab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.TabControl obstab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox obspassbox;
        private System.Windows.Forms.TextBox obsusernamebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oypass;
        private System.Windows.Forms.TextBox oyusername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox discordpass;
        private System.Windows.Forms.TextBox discordusername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox githubpass;
        private System.Windows.Forms.TextBox githubusername;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}
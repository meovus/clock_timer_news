namespace Clock_Timer
{
    partial class AlarmNoteForm
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
            this.notebox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.savenote = new System.Windows.Forms.Button();
            this.toppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(305, 3);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(32, 32);
            this.exitbtn.TabIndex = 0;
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.SystemColors.Control;
            this.toppanel.Controls.Add(this.exitbtn);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(340, 36);
            this.toppanel.TabIndex = 1;
            this.toppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseDown);
            this.toppanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseMove);
            this.toppanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseUp);
            // 
            // notebox
            // 
            this.notebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notebox.ForeColor = System.Drawing.Color.Magenta;
            this.notebox.Location = new System.Drawing.Point(29, 67);
            this.notebox.Name = "notebox";
            this.notebox.Size = new System.Drawing.Size(282, 173);
            this.notebox.TabIndex = 2;
            this.notebox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Note";
            // 
            // savenote
            // 
            this.savenote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.savenote.Location = new System.Drawing.Point(221, 254);
            this.savenote.Name = "savenote";
            this.savenote.Size = new System.Drawing.Size(90, 30);
            this.savenote.TabIndex = 4;
            this.savenote.Text = "Save";
            this.savenote.UseVisualStyleBackColor = true;
            this.savenote.Click += new System.EventHandler(this.savenote_Click);
            // 
            // AlarmNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 296);
            this.Controls.Add(this.savenote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notebox);
            this.Controls.Add(this.toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlarmNoteForm";
            this.Text = "AlarmNoteForm";
            this.Load += new System.EventHandler(this.AlarmNoteForm_Load);
            this.toppanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.RichTextBox notebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button savenote;
    }
}
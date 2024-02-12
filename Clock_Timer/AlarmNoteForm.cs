using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_Timer
{
    public partial class AlarmNoteForm : Form
    {
        public AlarmNoteForm()
        {
            InitializeComponent();
        }
        bool movestatus;
        int axis_x, axis_y;
        private void AlarmNoteForm_Load(object sender, EventArgs e)
        {
            exitbtn.Image = Image.FromFile(@"..\..\images\closebtn.png");
            notebox.Clear();

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            movestatus = true;
            axis_x = e.X;
            axis_y = e.Y;
        }

        private void toppanel_MouseUp(object sender, MouseEventArgs e)
        {
            movestatus = false;
        }


        private void toppanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (movestatus)
            {

                this.SetDesktopLocation(MousePosition.X - axis_x, MousePosition.Y-axis_y);
            }
        }

        private void savenote_Click(object sender, EventArgs e)
        {

            if (notebox.Text.Trim() != "")
            {
                TimerForm.alarm_note = notebox.Text;
                this.Close();
            }
            else
            {
                this.Close();

            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clock_Timer
{
    public partial class UserSettingsForm : Form
    {
        public UserSettingsForm()
        {
            InitializeComponent();
        }

        SqlConnection dbcon = new SqlConnection(DbConnectionString.connstring);
        string[] obsdata = new string[2];
        

        bool movesetpanel;
        int axis_x_setp, axis_y_setp;

        private void UserSettingsForm_Load(object sender, EventArgs e)
        {
            exitbtn.Image = Image.FromFile(@"..\..\images\closebtn.png");
            exitbtn.BackgroundImageLayout = ImageLayout.Center;
           
            obsdata = GetUserData("Obs");
            obsusernamebox.Text = obsdata[0];
            obspassbox.Text = obsdata[1];
            obsdata = GetUserData("OnlineYildiz");
            oyusername.Text = obsdata[0];
            oypass.Text = obsdata[1];
            obsdata = GetUserData("Discord");
            discordusername.Text = obsdata[0];
            discordpass.Text = obsdata[1];
            obsdata = GetUserData("Github");
            githubusername.Text = obsdata[0];
            githubpass.Text = obsdata[1];
            


        }

        private string[] GetUserData(string tag)
        {
            string query = "Select Username,Password from Data where Tag =@val";
            SqlCommand getdata = new SqlCommand(query, dbcon);

            getdata.Parameters.AddWithValue("@val", tag);
            string[] result = {"--","--"};
            dbcon.Open();
            SqlDataReader reader = getdata.ExecuteReader();

            if (reader.Read())
            {
                string username = reader["Username"].ToString().Trim();
                string password = reader["Password"].ToString().Trim();

                result[0] =username; result[1] = password;
                dbcon.Close();
                return result;
                    
            }
            else
            {
                dbcon.Close();
                return result;
                
            }
            

        }

         private  void UpdateUserData(string tag , string username , string password)
        {


            string query = "update Data set Username= @val1,Password=@val2 where Tag = @val3 ";

            SqlCommand update = new SqlCommand(query,dbcon);

            update.Parameters.AddWithValue("@val1", username);
            update.Parameters.AddWithValue("@val2", password);
            update.Parameters.AddWithValue("@val3", tag);

           
            update.ExecuteNonQuery();
            
        }


        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            movesetpanel = true;
           
            axis_x_setp = e.X;
            axis_y_setp = e.Y;

        }

        private void toppanel_MouseUp(object sender, MouseEventArgs e)
        {
            movesetpanel = false;
        }

        
        private void toppanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (movesetpanel)
            {
                this.SetDesktopLocation(MousePosition.X - axis_x_setp, MousePosition.Y - axis_y_setp);

            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            dbcon.Open();
            UpdateUserData("Obs", obsusernamebox.Text.Trim(), obspassbox.Text.Trim());
            UpdateUserData("OnlineYildiz", oyusername.Text.Trim(), oypass.Text.Trim());
            UpdateUserData("Discord", discordusername.Text.Trim(), discordpass.Text.Trim());
            UpdateUserData("Github", githubusername.Text.Trim(), githubpass.Text.Trim());
            dbcon.Close();
            MessageBox.Show("Updated Data...");
            this.Close();
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Clock_Timer
{
    public partial class NewsForm : Form
    {
        public NewsForm()
        {
            InitializeComponent();
        }

        public static string url = "https://www.trthaber.com/xml_mobile.php?tur=xml_genel&kategori=dunya&adet=20&selectEx=yorumSay,okunmaadedi,anasayfamanset,kategorimanset";
        public static string formtitle = "WORLD NEWS";
        bool movenewspanel;
        int axis_x_newsp, axis_y_newsp;
        int newscounter=0;
        int newsnumber;
        bool slidestatus = true;

        List<string> worldnewstitle = new List<string>();
        List<string> worldnewscontent= new List<string>();
        List<string> worldnewsimages = new List<string>();

        private void NewsForm_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("../../images/news.ico");
            exitbuton.Image = Image.FromFile(@"..\..\images\closebtn.png");
            exitbuton.BackgroundImageLayout = ImageLayout.Center;
            minimizebtn.Image = Image.FromFile(@"..\..\images\minimizeicon.png");
            minimizebtn.BackgroundImageLayout = ImageLayout.Center;
            newsname.Text = formtitle;
            if (GetNews())
            {
                newsnumber = worldnewstitle.Count;
                news_timer.Interval = 5000;
                news_timer.Enabled = true;
                world_news_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                this.Close();
            }
           

        }

        private void exitbuton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            movenewspanel = true;
            axis_x_newsp = e.X;
            axis_y_newsp = e.Y;
        }

        private void toppanel_MouseUp(object sender, MouseEventArgs e)
        {
            movenewspanel = false;
        }

        private void toppanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (movenewspanel)
            {
                this.SetDesktopLocation(MousePosition.X - axis_x_newsp, MousePosition.Y - axis_y_newsp);

            }
        }

        private void FillNewsToBox(int counter)
        {
            worldcontentbox.Text = worldnewscontent[counter];
            worldtitle.Text = worldnewstitle[counter];
            world_news_pic.ImageLocation = worldnewsimages[counter];

        }

       



        private bool GetNews()
        {

            try
            {
                XmlDocument newsdoc = new XmlDocument();
                newsdoc.Load(url);

                XmlElement element = newsdoc.DocumentElement;

                XmlNodeList nodes = element.SelectNodes("haber");

                foreach (XmlNode node in nodes)
                {
                    string titledata = node["haber_manset"].InnerText;
                    string contentdata = node["haber_aciklama"].InnerText;
                    string imagesurl = node["haber_resim"].InnerText;
                    worldnewstitle.Add(titledata);
                    worldnewscontent.Add(contentdata);
                    worldnewsimages.Add(imagesurl);
                }
                return true;
            }

            catch
            {
                
                MessageBox.Show("Check Your Wifi Connection,Please!");
                return false;
                
            }

        }
        private void worldtitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void worldcontentbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void next_wnews_btn_Click(object sender, EventArgs e)
        {
           
            
            if (newscounter == newsnumber-1)
            {
                newscounter = 0;
                FillNewsToBox(newscounter);
            }
            else
            {
                newscounter++;
                FillNewsToBox(newscounter);
            }


        }

        private void backnews_Click(object sender, EventArgs e)
        {
            if(newscounter == 0)
            {
                newscounter = newsnumber-1;
                FillNewsToBox(newscounter);
            }
            else
            {
                newscounter--;
                FillNewsToBox(newscounter);
            }
            
        }


        private void world_news_pic_DoubleClick(object sender, EventArgs e)
        {
            if (slidestatus)
            {
                news_timer.Enabled = false;
                slidestatus = false;

            }
            else
            {
                news_timer.Enabled = true;
                slidestatus = true;
            }
        }

        private void news_timer_Tick(object sender, EventArgs e)
        {
            FillNewsToBox(newscounter);
            newscounter++;

            if(newscounter == newsnumber-1)
            {
                newscounter = 0;
            }
        }




    }
}

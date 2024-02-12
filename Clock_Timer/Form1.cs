using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;



namespace Clock_Timer
{
    public partial class TimerForm : Form
    {
        public TimerForm()
        {
            InitializeComponent();
        }

        SqlConnection dbconntimer = new SqlConnection(DbConnectionString.connstring);

        bool move;
        int axis_x, axis_y;
        int counter_sec;
        int alarm_minute;
        public static string alarm_note;
        
        
        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("../../images/planning.ico");         
            AdjustFormImage();
            alarmsoundbox.Text = "DefaultAlarm";
            comboBox1.Text = "5 min";
            clock_timer.Enabled = true;
            alarmpicture.Visible = false;
            alarmprogress.Visible = false;
            alarm_note = "";
            AlarmVisible(false);
            GetWeatherCity();
            GetCurrency();
            
        }

        private string[] GetUserData(string tag)
        {
            string query = "Select Username,Password from Data where Tag =@val";
            SqlCommand getdata = new SqlCommand(query, dbconntimer);

            getdata.Parameters.AddWithValue("@val", tag);
            string[] result = { "--", "--" };
            dbconntimer.Open();
            SqlDataReader reader = getdata.ExecuteReader();

            if (reader.Read())
            {
                string username = reader["Username"].ToString().Trim();
                string password = reader["Password"].ToString().Trim();

                result[0] = username; result[1] = password;
                dbconntimer.Close();
                return result;

            }
            else
            {
                dbconntimer.Close();
                return result;

            }


        }




        private void AlarmVisible(bool trueorfalse)
        {
            if (trueorfalse)
            {
                alarmpicture.Visible = true;
                alarmprogress.Visible = true;
                alarmcounterlbl.Visible = true;
                
            }
            else
            {
                alarmpicture.Visible = false;
                alarmprogress.Visible = false;
                alarmcounterlbl.Visible = false;
            }
        }

        private int ComboBoxConvertString()
        {
            if (comboBox1.Text != "" || comboBox1.Text.Trim() != "")
            {
               string alarmval = comboBox1.Text.Trim();
               alarmval = alarmval.Trim('m', 'i', 'n');

                int alarmdeger = Int32.Parse(alarmval);
                return alarmdeger;

            }
            else
            {
              MessageBox.Show("Invalid Value");
              return 0;
            }
        }
        private void AlarmOnOff(bool tf)
        {
            if (tf)
            {
                alarmpicture.Image = Image.FromFile(@"..\..\images\alarm.gif");
                alarmpicture.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                alarmpicture.Image = Image.FromFile(@"..\..\images\alarmoff.png");
                alarmpicture.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void AdjustFormImage()
        {
            exitbtn.Image = Image.FromFile(@"..\..\images\closebtn.png");
            exitbtn.BackgroundImageLayout = ImageLayout.Center;
            clockpicture.Image = Image.FromFile(@"..\..\images\formclock.png");
            clockpicture.SizeMode = PictureBoxSizeMode.CenterImage;
            calenderpicture.Image = Image.FromFile(@"..\..\images\calender.png");
            calenderpicture.SizeMode = PictureBoxSizeMode.CenterImage;
            discordbtn.Image = Image.FromFile(@"..\..\images\discord.png");
            discordbtn.BackgroundImageLayout = ImageLayout.Center;
            onlinesystembtn.Image = Image.FromFile(@"..\..\images\university.png");
            onlinesystembtn.BackgroundImageLayout = ImageLayout.Center;
            havadurumu1.Image = Image.FromFile(@"..\..\images\weather.png");
            havadurumu1.SizeMode = PictureBoxSizeMode.CenterImage;
            temperaturepic1.Image = Image.FromFile(@"..\..\images\temperature.png");
            temperaturepic1.SizeMode = PictureBoxSizeMode.CenterImage;
            minimizebtn.Image = Image.FromFile(@"..\..\images\minimizeicon.png");
            minimizebtn.BackgroundImageLayout = ImageLayout.Center;
            wthr_istanbul_pic.Image = Image.FromFile(@"..\..\images\weather.png");
            wthr_istanbul_pic.SizeMode = PictureBoxSizeMode.CenterImage;
            temp_istanbul_pic.Image = Image.FromFile(@"..\..\images\temperature.png");
            temp_istanbul_pic.SizeMode = PictureBoxSizeMode.CenterImage;
            timevaluepic.Image = Image.FromFile(@"..\..\images\hourglass.png");
            timevaluepic.SizeMode = PictureBoxSizeMode.CenterImage;
            soundpic.Image = Image.FromFile(@"..\..\images\sound.png");
            soundpic.SizeMode = PictureBoxSizeMode.CenterImage;
            githublogin.Image = Image.FromFile(@"..\..\images\githubicon.png");
            githublogin.BackgroundImageLayout = ImageLayout.Center;
            obslogbuton.Image = Image.FromFile(@"..\..\images\exam.png");
            obslogbuton.BackgroundImageLayout = ImageLayout.Center;
            userformbtn.Image = Image.FromFile(@"..\..\images\profile.png");
            userformbtn.BackgroundImageLayout = ImageLayout.Center;
            alarmnotebtn.Image = Image.FromFile(@"..\..\images\notepad.png");
            alarmnotebtn.BackgroundImageLayout = ImageLayout.Center;

        }


        private void GetCurrency()
        {
            try
            {
                XmlDocument currencydoc = new XmlDocument();
                currencydoc.Load("https://www.tcmb.gov.tr/kurlar/today.xml");

                DateTime currencydate = Convert.ToDateTime(currencydoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);


                string sellingusd = currencydoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='USD']/BanknoteSelling").InnerXml;
                string buyingusd = currencydoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='USD']/BanknoteBuying").InnerXml;
                string sellingeur = currencydoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='EUR']/BanknoteSelling").InnerXml;
                string buyingeur = currencydoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='EUR']/BanknoteBuying").InnerXml;

                currencybox.Text = string.Format("     " + "USD\t\tEURO " + "\n\nBuy: {0}\t\tBuy:{1}\nSell: {2}\t\tSell: {3}\nUpdate: {4}", buyingusd, buyingeur, sellingusd, sellingeur, currencydate.ToLongDateString());
            }
            catch
            {
                MessageBox.Show("Currency informations could not be retrieved");
            }

        }


        private void GetWeatherCity()
        {
            try
            {

                string api = "442c433e02a302f596bd8fc3c92ef558";

                string url_istanbul = "http://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
                string url_konya = "http://api.openweathermap.org/data/2.5/weather?q=konya&mode=xml&lang=tr&units=metric&appid=" + api;

                XDocument istanbul = XDocument.Load(url_istanbul);
                System.Threading.Thread.Sleep(500);
                XDocument konya = XDocument.Load(url_konya);
                var temp_istanbul = istanbul.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                var weather_istanbul = istanbul.Descendants("weather").ElementAt(0).Attribute("value").Value;
                var temp_konya = konya.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                var weather_konya = konya.Descendants("weather").ElementAt(0).Attribute("value").Value;

                konya_temp_lbl.Text = temp_konya.ToString()+" C";
                konya_wth_status.Text = weather_konya.ToString();

                temp_istanbul_lbl.Text = temp_istanbul.ToString()+" C";
                wthr_istanbul_lbl.Text = weather_istanbul.ToString();



            }
            catch
            {
                MessageBox.Show("Weather informations could not be retrieved ,Check Your Wifi Connection,Please!");
                temp_istanbul_lbl.Text = "?";
                wthr_istanbul_lbl.Text = "?";
                konya_temp_lbl.Text = "?";
                konya_wth_status.Text = "?";
            }

            
        }

         private async void GetNews()
        {
            string url = "https://www.trthaber.com/xml_mobile.php?tur=xml_genel&kategori=dunya&adet=20&selectEx=yorumSay,okunmaadedi,anasayfamanset,kategorimanset";


            XmlDocument newsdoc = new XmlDocument();
            newsdoc.Load(url);

            XmlElement element = newsdoc.DocumentElement;

            XmlNodeList nodes = element.SelectNodes("haber");

            List<string> veriler = new List<string>();
            

            foreach ( XmlNode node in nodes)
            {
                string veri = node["haber_manset"].InnerText;
                veriler.Add(veri);
            }
            
            foreach (string veri in veriler)
            {
                await Task.Delay(2000);
            }


        }

    


        private void toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            axis_x = e.X;
            axis_y = e.Y;
        }

        private void toppanel_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void toppanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - axis_x, MousePosition.Y - axis_y);

            }
        }
        private void clock_timer_Tick(object sender, EventArgs e)
        {

            string time = DateTime.Now.ToLongTimeString();
            string date = DateTime.Now.Date.ToLongDateString();

            timelbl.Text = time;
            datelbl.Text = date;
            

        }

        private void alarm_timer_Tick(object sender, EventArgs e)
        {

            if(alarm_minute != 0 || counter_sec!=0)
            {

                if (counter_sec == 0)
                {
                    counter_sec = 60;
                    alarm_minute--;
                    alarmprogress.Value++;
                }
                counter_sec--;
                alarmcounterlbl.Text = alarm_minute.ToString() + ":" + counter_sec.ToString();

            }
            else
            {
                alarmcounterlbl.Text = alarm_minute.ToString() + ":" + counter_sec.ToString();
                alarmprogress.Value++;
                string soundname = alarmsoundbox.Text.Trim();
                if (soundname == "" || soundname.Trim()=="")
                {
                    soundname = "DefaultAlarm";
                }
                SoundPlayer sound = new SoundPlayer(@"..\..\images\"+soundname+".wav");
                sound.Play();
                alarm_timer.Enabled = false;
                setalarm.Enabled = true;
                stopalarm.Enabled = false;
                AlarmOnOff(false);
                if (alarm_note != "")
                {
                    MessageBox.Show(alarm_note);
                }
            }

                   
        }

        private void setalarm_Click(object sender, EventArgs e)
        {
            
            if (ComboBoxConvertString() != 0) {
                alarmprogress.Value = 0;
                alarm_timer.Enabled = true;
                alarm_minute = ComboBoxConvertString() - 1;

                counter_sec = 60;
                alarmprogress.Maximum = alarm_minute + 1;


                setalarm.Enabled = false;
                stopalarm.Enabled = true;
                AlarmOnOff(true);
                AlarmVisible(true);
                
            }
            
              
        }

        private void stopalarm_Click(object sender, EventArgs e)
        {
            alarm_timer.Enabled = false;
            
            alarm_minute = 0;
            setalarm.Enabled = true;
            stopalarm.Enabled = false;
            AlarmOnOff(false);
            
        }

        private void onlinesystembtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                string[] logdata = new string[2];
                logdata = GetUserData("OnlineYildiz");
                IWebDriver ytüdriver = new ChromeDriver();
                ytüdriver.Navigate().GoToUrl("https://online.yildiz.edu.tr/Account/Login?ReturnUrl=%2f");
                System.Threading.Thread.Sleep(1000);
                IWebElement username = ytüdriver.FindElement(By.Name("Data.Mail"));
                IWebElement password = ytüdriver.FindElement(By.Name("Data.Password"));
                IWebElement logbuton = ytüdriver.FindElement(By.CssSelector(".btn.btn-primary.mt-2"));

                username.SendKeys(logdata[0]);
                password.SendKeys(logdata[1]);
                System.Threading.Thread.Sleep(500);
                logbuton.Click();
            }

            catch
            {
                MessageBox.Show("Login Error ,Try Again");
            }



        }

     

        private void discordbtn_Click(object sender, EventArgs e)
        {

            try
            {
                string[] logdata = new string[2];
                logdata = GetUserData("Discord");
                IWebDriver discorddriver = new ChromeDriver();
                discorddriver.Navigate().GoToUrl("https://discord.com/login");
                System.Threading.Thread.Sleep(1000);
                IWebElement username = discorddriver.FindElement(By.Name("email"));
                IWebElement password = discorddriver.FindElement(By.Name("password"));
                IWebElement logbuton = discorddriver.FindElement(By.CssSelector(".marginBottom8-emkd0_.button-1cRKG6.button-f2h6uQ.lookFilled-yCfaCM.colorBrand-I6CyqQ.sizeLarge-3mScP9.fullWidth-fJIsjq.grow-2sR_-F"));

                username.SendKeys(logdata[0]);
                password.SendKeys(logdata[1]);
                System.Threading.Thread.Sleep(500);
                logbuton.Click();
            }

            catch
            {
                MessageBox.Show("Login Error ,Try Again");
            }
        }

    

        private void githublogin_Click(object sender, EventArgs e)
        {
            try
            {
                string[] logdata = new string[2];
                logdata = GetUserData("Github");
                IWebDriver githubdriver = new ChromeDriver();
                githubdriver.Navigate().GoToUrl("https://github.com/login");
                System.Threading.Thread.Sleep(1000);
                IWebElement username = githubdriver.FindElement(By.Name("login"));
                IWebElement password = githubdriver.FindElement(By.Name("password"));
                IWebElement logbuton = githubdriver.FindElement(By.CssSelector(".btn.btn-primary.btn-block.js-sign-in-button"));

                username.SendKeys(logdata[0]);
                password.SendKeys(logdata[1]);
                System.Threading.Thread.Sleep(1500);
                logbuton.Click();
            }

            catch
            {
                MessageBox.Show("Login Error ,Try Again");
            }
        }

        private void obslogbuton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] logdata = new string[2];
                logdata = GetUserData("Obs");
                IWebDriver obsdriver = new ChromeDriver();
                obsdriver.Navigate().GoToUrl("https://obs.yildiz.edu.tr/oibs/ogrenci/login.aspx");
                System.Threading.Thread.Sleep(2000);
                IWebElement username = obsdriver.FindElement(By.Id("txtParamT01"));
                IWebElement password = obsdriver.FindElement(By.Id("txtParamT02"));
                

                username.SendKeys(logdata[0]);
                password.SendKeys(logdata[1]);
                System.Threading.Thread.Sleep(500);
            }

            catch
            {
                MessageBox.Show("Login Error ,Try Again");
            }




        }
        private void userformbtn_Click(object sender, EventArgs e)
        {

            UserSettingsForm settingsform = new UserSettingsForm();
            settingsform.Show();    

        }


        private void OpenNewsForm(string newstype)
        {
            NewsForm newsform = new NewsForm();
            NewsForm.url = newstype;
            newsform.Show();
        }
        

        private void newsbtn_Click(object sender, EventArgs e)
        {
            string url = "https://www.trthaber.com/xml_mobile.php?tur=xml_genel&kategori=dunya&adet=20&selectEx=yorumSay,okunmaadedi,anasayfamanset,kategorimanset";
            NewsForm.formtitle = "WORLD NEWS";
            OpenNewsForm(url);

        }

        private void headlinenewsbtn_Click(object sender, EventArgs e)
        {
            string url = "http://www.trthaber.com/xml_mobile.php?tur=xml_genel&kategori=&adet=20&selectEx=yorumSay,okunmaadedi,anasayfamanset,kategorimanset";
            NewsForm.formtitle = "HEADLİNE NEWS";
            OpenNewsForm(url);
        }


        private void breakingnewsbtn_Click(object sender, EventArgs e)
        {
            string url = "http://www.trthaber.com/xml_mobile.php?tur=xml_genel&kategori=sondakika&adet=20&selectEx=yorumSay,okunmaadedi,anasayfamanset,kategorimanset";
            NewsForm.formtitle = "BREAKING NEWS";
            OpenNewsForm(url); 
        }


        private void lifenewsbtn_Click(object sender, EventArgs e)
        {
            string url = "http://www.trthaber.com/xml_mobile.php?tur=xml_genel&kategori=yasam&adet=20&selectEx=yorumSay,okunmaadedi,anasayfamanset,kategorimanset";
            NewsForm.formtitle = "LIFE NEWS";
            OpenNewsForm(url);
        }

        private void alarmnotebtn_Click(object sender, EventArgs e)
        {
            AlarmNoteForm alarmnoteform = new AlarmNoteForm();
            alarmnoteform.Show();
            
        }




    }
}

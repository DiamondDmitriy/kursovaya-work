using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//подключил
using System.Media;
using Un4seen.Bass;

namespace pleyerF
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {

            InitializeComponent();
            BassMain.InitBass(BassMain.HZ);
            Vars.link = this;
            Vars.setInputFormats();

        }
        Form2 form2 = new Form2();
        
        

        public bool Drawning { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public bool minMax = true;
        string fileName = string.Empty;


        int promMejFormamy = 10;
        private void button1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
        private void button3_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (minMax)
            {
                this.WindowState = FormWindowState.Maximized;
                minMax = false;
            }
            else if (!minMax)
            {
                minMax = true;
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

                if (Drawning == true)

                {
                    x = this.Location.X + e.X - X;
                    y = this.Location.Y + e.Y - Y;
                    this.Location = new Point(x, y);

                    form2.Location = new Point(x, y+this.Size.Height + promMejFormamy);
                }

        }


            

        private void Form1_MouseUp_1(object sender, MouseEventArgs e)

        {
            Drawning = false;
        }

        

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)

        {
            Drawning = true;
            X = e.X;
            Y = e.Y;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ////открытие файла
 

            openFileDialog1.ShowDialog(); 


        }

        public void button6_Click(object sender, EventArgs e)
        {
            if ( (form2.playList.Items.Count!=0) && (form2.playList.SelectedIndex!=-1) )
            {
                string current=Vars.Files[form2.playList.SelectedIndex];
                Vars.CurrentTrackNumber = form2.playList.SelectedIndex;

                BassMain.Play(current, BassMain.voluem);
                //timespan перевод секунды в минуты а минуты в часы 
                timePlayNow.Text = TimeSpan.FromSeconds(BassMain.getPosOfChanal(BassMain.chanal)).ToString();
                timePlayOver.Text = TimeSpan.FromSeconds(BassMain.GetTimeOfChanal(BassMain.chanal)).ToString();
                slTime.Maximum = BassMain.GetTimeOfChanal(BassMain.chanal);
                slTime.Value = BassMain.getPosOfChanal(BassMain.chanal);
                timer1.Enabled = true;//vkl timer

                //fun nime;
                string fileNameTrack = Vars.GetFileName(openFileDialog1.FileName);
                label1.Text = Vars.GetFileName(current);
                
            }

        }

 
        bool form2Close = true;

        


        private void button4_Click(object sender, EventArgs e)
        {
            if (form2Close)
            {

                
                
                form2.Show();
                form2Close = false;
                
                form2.Top = this.Bottom+ promMejFormamy;
                form2.Left = this.Left;
                
                
            }
            else {
                form2.Hide();
                form2Close = true;
            }

            


        }

        private void timePlayOver_Click(object sender, EventArgs e)
        {
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //добавяем треки в лист  бокс
            string[] tmp = openFileDialog1.FileNames;
            for (int i = 0; i < tmp.Length; i++)
            {
                Vars.Files.Add(tmp[i]);
                TagInfo TI = new TagInfo(tmp[i]);


                form2.playList.Items.Add(TI.artist+"-"+TI.title);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timePlayNow.Text = TimeSpan.FromSeconds(BassMain.getPosOfChanal(BassMain.chanal)).ToString();
            slTime.Value = BassMain.getPosOfChanal(BassMain.chanal);

            bool posSecBool = false;
            bool firstSecBool = false;
            int timePlayNowInt = (Convert.ToInt32(timePlayNow.Text.Substring(3, 2)) * 60) + Convert.ToInt32(timePlayNow.Text.Substring(6, 2));
            int timePlayOverInt = (Convert.ToInt32(timePlayOver.Text.Substring(3, 2)) * 60) + Convert.ToInt32(timePlayOver.Text.Substring(6, 2));

           

            if (timePlayOverInt - timePlayNowInt == 1)
            {
                posSecBool = true;
            }
            else
            {
                posSecBool = false;

            }

            if (timePlayOverInt - timePlayNowInt == timePlayOverInt)
            {
                firstSecBool = true;
            }
            else
            {
                firstSecBool = false;

            }



            if (BassMain.ToNextTrack() & firstSecBool)
            {

                form2.playList.SelectedIndex = Vars.CurrentTrackNumber;
                timePlayNow.Text = TimeSpan.FromSeconds(BassMain.getPosOfChanal(BassMain.chanal)).ToString();
                timePlayOver.Text = TimeSpan.FromSeconds(BassMain.GetTimeOfChanal(BassMain.chanal)).ToString();
                slTime.Maximum = BassMain.GetTimeOfChanal(BassMain.chanal);
                slTime.Value = BassMain.getPosOfChanal(BassMain.chanal);
            }

            if (BassMain.ToNextTrack() & posSecBool)
            { 
            
                form2.playList.SelectedIndex = Vars.CurrentTrackNumber;
                timePlayNow.Text = TimeSpan.FromSeconds(BassMain.getPosOfChanal(BassMain.chanal)).ToString();
                timePlayOver.Text = TimeSpan.FromSeconds(BassMain.GetTimeOfChanal(BassMain.chanal)).ToString();
                slTime.Maximum = BassMain.GetTimeOfChanal(BassMain.chanal);
                slTime.Value = BassMain.getPosOfChanal(BassMain.chanal);
            }
            if (BassMain.endPleyList)
            {
                button9_Click(this, new EventArgs());
                form2.playList.SelectedIndex = Vars.CurrentTrackNumber = 0;
                BassMain.endPleyList = false;
                timePlayOver.Text = "00:00:00";
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            BassMain.Stop();
            timer1.Enabled = false;
            slTime.Value = 0;
            timePlayNow.Text = "00:00";
        }
        
        //перематываем волум
        private void slTime_Scroll(object sender, ScrollEventArgs e)
        {
            BassMain.setPosOfScrol(BassMain.chanal, slTime.Value);
        }
        

        //сама громкость 
        private void slVol_Scroll(object sender, ScrollEventArgs e)
        {
            BassMain.setVoidToChanal(BassMain.chanal, slVol.Value);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BassMain.Pause();


        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (form2.playList.SelectedIndex+1 == form2.playList.Items.Count)
            {
                Vars.CurrentTrackNumber = 0;
                form2.playList.SelectedIndex = 0;
                button6_Click(sender, e);
            }

            else if (form2.playList.SelectedIndex+1 < form2.playList.Items.Count)
            
            {
                form2.playList.SelectedIndex = Vars.CurrentTrackNumber + 1;
                Vars.CurrentTrackNumber++;
                button6_Click(sender, e);
                button6_Click(sender, e);

            }
            

            


        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (form2.playList.SelectedIndex ==0)
            {
                Vars.CurrentTrackNumber = form2.playList.Items.Count-1;
                form2.playList.SelectedIndex = form2.playList.Items.Count - 1;
                button6_Click(sender, e);
            }

            else if (form2.playList.SelectedIndex !=0)

            {
                form2.playList.SelectedIndex = Vars.CurrentTrackNumber - 1;
                Vars.CurrentTrackNumber--;
                button6_Click(sender, e);
                button6_Click(sender, e);

            }
        }
    }
}

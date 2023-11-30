using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class frmMovingMemory : Form
    {
        public frmMovingMemory(string s)
        {
            InitializeComponent();
            name = s;
            KhoiDau();
        }
        public static string time;
        int countp;
        int counts;
        Button[] btn;
        string max;
        int[] numberde = { 0,0,1, 1, 2, 2, 3, 3, 4, 4, 5, 5,6,6,7,7};
        int[] numbertb = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9 };
        int[] numberkho = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11 };
        public static string name;
        public static int n;
        string playermax;
        int score=0;
        string thoigian;
        Random r = new Random();
       
        public void KhoiDau()
        {
            score = 0;
            lblTime.Text = "00:00";
            time = "";
            countp = 0;
            counts = 0;
            timer1.Stop();
            GiaoDienNhapTen();            
            score = 0;
            btn = new Button[n];
            int j = 0;
            int k = 0;
            int hei = (pnlBang.Height-50) /(n / 4);
            int wid = (pnlBang.Width-50) / 4;

            for(int i = 0; i < n; ++i)
            {
                btn[i] = new Button();
                btn[i].Width = wid;
                btn[i].Height = hei;
  
                if (j == 0 && k == 0)
                {
                    btn[i].Location = new Point(10, 10);
                }
                else
                {
                    if (j == 0 && k != 0)
                    {
                        btn[i].Location = new Point(10, hei * k + 10 * k + 10);
                    }
                    else
                    {
                        btn[i].Location = new Point(wid * j + 10 * j+10, hei * k + 10 * k+10);
                    }
                }
                btn[i].Click += new EventHandler(btn_Click);
                btn[i].Image= Image.FromFile(Application.StartupPath + @"\Data\background.jpg");
                btn[i].Enabled = false;
                j++;
                pnlBang.Controls.Add(btn[i]);
                if(j == 4)
                {
                    j = 0;
                    k++;
                }
               
            }
            NgauNhien();
            btnPause.Enabled = false;
            btnStart.Enabled = true;
            btnRetry.Enabled = false;
        }
        private void MaxScore()
        {
            FileStream fs = new FileStream(Application.StartupPath + @"\Data\MaxScore.txt", FileMode.Open);
            StreamReader read = new StreamReader(fs);
            max = read.ReadLine();
            fs.Close();
            FileStream fs2 = new FileStream(Application.StartupPath + @"\Data\PlayerMax.txt", FileMode.Open);
            StreamReader read2 = new StreamReader(fs2);
            playermax = read2.ReadLine();
            fs2.Close();
            FileStream fs3 = new FileStream(Application.StartupPath + @"\Data\Time.txt", FileMode.Open);
            StreamReader read3 = new StreamReader(fs3);
            thoigian = read3.ReadLine();
            fs3.Close();
        }
        public void GiaoDienNhapTen()
        { 
            lblTenNC.Text = name;
            lblScore.Text = score.ToString();
            MaxScore();
            lblSoDiemCaoNhat.Text = max;
            lblTenNCCaoNhat.Text = playermax;
            lblMaxTime.Text = thoigian;
        }
        List<int> number;
        public void NgauNhien()
        { 
            if (n == 16) 
            {
                var randomlist = numberde.OrderBy(x => Guid.NewGuid()).ToList();
                number = randomlist;
            }
            if (n == 20)
            {
                var randomlist = numbertb.OrderBy(x => Guid.NewGuid()).ToList();
                number = randomlist;
            }
            if (n == 24)
            {
                var randomlist = numberkho.OrderBy(x => Guid.NewGuid()).ToList();
                number = randomlist;
            }

            for(int i = 0; i < n; i++)
            {
                btn[i].Tag = number[i].ToString();
            }
        }
        public void btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
         
            b.Image = Image.FromFile(Application.StartupPath + @"\Data\" + b.Tag.ToString() + ".png");
            b.Enabled = false;
           
            Check();
            lblScore.Text = score.ToString();
            if (checkrong())
            {
                timer1.Stop();
                string[] a = time.Split(':');
                string[] a1 = thoigian.Split(':');
                    if (score > int.Parse(max) || (score == int.Parse(max) && int.Parse(a[0]) < int.Parse(a1[0])) || (score == int.Parse(max) && int.Parse(a[0]) == int.Parse(a1[0]) && int.Parse(a[1]) < int.Parse(a1[1])))
                    {
                       
                        StreamWriter writer = new StreamWriter(Application.StartupPath + @"\Data\MaxScore.txt");
                        writer.WriteLine(score.ToString());
                        StreamWriter wri = new StreamWriter(Application.StartupPath + @"\Data\PlayerMax.txt");
                        wri.WriteLine(name);
                        StreamWriter wri2 = new StreamWriter(Application.StartupPath + @"\Data\Time.txt");
                        wri2.WriteLine(time);
                        MessageBox.Show("Chúc mừng bạn đã hoàn thành trò chơi. Bạn đã đạt điểm cao nhất");
                        writer.Close();
                        wri.Close();
                        wri2.Close();
                        MaxScore();
                        lblSoDiemCaoNhat.Text = max;
                    }
                    else
                    {
                        MessageBox.Show("Chúc mừng bạn đã hoàn thành trò chơi. Rất tiếc khi bạn không vượt qua điểm cao nhất của chúng tôi. Thử lại lần sau nhé");
                    }
                    if(MessageBox.Show("Bạn có muốn chơi lại không?", "Xác nhận chơi lại", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                    for (int i = 0; i < n; i++)
                    {
                        btn[i].Image = Image.FromFile(Application.StartupPath + @"\Data\background.jpg");
                        btn[i].Enabled = false;
                        btn[i].Visible = true;
                    }
                    lblTime.Text = "00:00";
                    time = "";
                    countp = 0;
                    counts = 0;
                    timer1.Stop();
                    GiaoDienNhapTen();
                    score = 0;
                    btnStart.Enabled = true;
                    btnPause.Enabled = false;
                    btnRetry.Enabled = false;
                    NgauNhien();
                }
                    else
                    {
                    frmMoDau moDau = new frmMoDau();
                    moDau.Show();
                    this.Hide();
                    }

            }
        }
        public void Check()
        {
            for (int i = 0; i < btn.Length; i++)
                for (int j = i + 1; j < btn.Length; j++)
                    if (btn[i].Enabled==false&& btn[j].Enabled==false)
                    {
                        if (btn[i].Tag.ToString() == btn[j].Tag.ToString())
                        {
                            System.Threading.Thread.Sleep(700);
                            btn[i].Enabled = true;
                            btn[j].Enabled = true;
                            btn[i].Visible = false;
                            btn[j].Visible = false;
                            switch (n)
                            {
                                case 16:
                                    score += 10;
                                    break;
                                case 20:
                                    score += 20;
                                    break;
                                default:
                                    score += 30;
                                    break;
                            }
                        }
                        else
                        {
                            System.Threading.Thread.Sleep(700);
                            btn[i].Enabled = true;
                            btn[j].Enabled = true;
                            btn[i].Image = Image.FromFile(Application.StartupPath + @"\Data\background.jpg");
                            btn[j].Image = Image.FromFile(Application.StartupPath + @"\Data\background.jpg");
                            if (score > 0)
                                switch (n)
                                {
                                    case 16:
                                        score -= 5;
                                        break;
                                    case 20:
                                        score -= 10;
                                        break;
                                    default:
                                        score -= 15;
                                        break;
                                }
                        }
                    }
        }
        public bool checkrong()
        {
            for (int i = 0; i < btn.Length; i++)
                if (btn[i].Visible == true)
                    return false;
            return true;
        }

        private void frmMovingMemory_Load(object sender, EventArgs e)
        {

        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            counts++;
            if (countp < 2)
            {
                if (counts == 60)
                {
                    countp++;
                    counts = 0;
                }
                if (countp < 10)
                {
                    time = "0" + countp + ":";

                }
                else
                {
                    time = countp.ToString() + ':';
                }
                if (counts < 10)
                {
                    time += "0" + counts;
                }
                else
                {
                    time += counts.ToString();
                }
                lblTime.Text = time;
            }
            else
            {
                timer1.Stop();
                DialogResult r;
                r = MessageBox.Show("Đã hết thời gian, rất tiết bạn đã không vượt qua màn chơi.Hãy thử lại lần sau.", "GameOver");
                if (MessageBox.Show("Bạn có muốn chơi lại không?", "Xác nhận chơi lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    for (int i = 0; i < n; i++)
                    {
                        btn[i].Image = Image.FromFile(Application.StartupPath + @"\Data\background.jpg");
                        btn[i].Enabled = false;
                        btn[i].Visible = true;
                        
                    }
                    lblTime.Text = "00:00";
                    time = "";
                    countp = 0;
                    counts = 0;
                    timer1.Stop();
                    GiaoDienNhapTen();
                    score = 0;
                    btnStart.Enabled = true;
                    btnPause.Enabled = false;
                    btnRetry.Enabled = false;
                    NgauNhien();
                    btnStart.Text = "Bắt đầu";
                }
                else
                {
                    frmMoDau moDau = new frmMoDau();
                    moDau.Show();
                    this.Hide();
                }
            }
        }
        int index=-1;
        private void btnStart_Click(object sender, EventArgs e)
        {
            for(int i=0;i<n;i++)
            {
                btn[i].Image = Image.FromFile(Application.StartupPath + @"\Data\background.jpg");
                btn[i].Enabled = true;
            }
            timer1.Start();
            btnPause.Enabled = true;
            btnStart.Enabled = false;
            btnRetry.Enabled = true;
           
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnPause.Enabled = false;
            btnStart.Text = "Tiếp tục";
            btnStart.Enabled = true;
            btnRetry.Enabled = true;
            for (int i=0;i<n;i++)
            {
                if (btn[i].Enabled == true)
                {
                    btn[i].Enabled = false;
                }
                else
                    index = i;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMoDau moDau = new frmMoDau();
            moDau.Show();
            this.Hide();
            timer1.Stop();
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                btn[i].Image = Image.FromFile(Application.StartupPath + @"\Data\background.jpg");
                btn[i].Enabled = false;
                btn[i].Visible = true;

            }
            lblTime.Text = "00:00";
            time = "";
            countp = 0;
            counts = 0;
            timer1.Stop();
            GiaoDienNhapTen();
            score = 0;
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btnStart.Text = "Bắt đầu";
            btnRetry.Enabled = false;
            NgauNhien();
        }
    }
    
}

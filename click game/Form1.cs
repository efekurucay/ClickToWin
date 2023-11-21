using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace click_game
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Skor_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           string basilantus =e.KeyCode.ToString();
            timer1.Enabled = true;
           
            
            if (basilantus == harf.Text)
            {
                Random random = new Random();
                string rastgeleharf = "QWERTYUIOPASDFGHJKLZXCVBNM";
                char a= rastgeleharf[random.Next(rastgeleharf.Length)];
                harf.Text = a.ToString ();
                int c = Convert.ToInt32(Skor.Text);
                c += 10;
                Skor.Text = c.ToString();
            }
            else
            {
               int b= Convert.ToInt32(hatalitus.Text);
                b++;
                hatalitus.Text = b.ToString ();
            }
            if (hatalitus.Text == 10.ToString())
            {
                timer1.Enabled = false;
                DialogResult bitti = new DialogResult();
               bitti =  MessageBox.Show("Skor:"+Skor.Text+"\n"+"Tekrar Oynamak İster misiniz?", "Kaybettiniz", MessageBoxButtons.YesNo);
                
                if (bitti == DialogResult.No)
                {
                    Application.Exit();
                }
                else if(bitti == DialogResult.Yes)
                {
                    Skor.Text = "0";
                    sure.Text = "10";
                    hatalitus.Text = "0";
                }

                

            }
            
        }

        private void harf_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            int d = Convert.ToInt32(sure.Text);
            d--;
            sure.Text = d.ToString();
            if (sure.Text == "0")
            {
                timer1.Enabled = false;
                DialogResult isim = new DialogResult();
               isim= MessageBox.Show("Skor: " + Skor.Text+"\n"+"Tekrar Oynamak İsten Mi?", "Tebrikler", MessageBoxButtons.YesNo);
                
                if (isim == DialogResult.No)
                {
                 Application.Exit();
                }
                else if (isim == DialogResult.Yes)
                {
                    sure.Text = "10";
                    
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_sayitahminoyunu
{
    public partial class Form1 : Form
    {
        int sayi = 0, tahminsayısı = 0, puan = 1000;

        private void button1_Click(object sender, EventArgs e)
        {
            int tahmin;
            tahminsayısı++;
            if (tahminsayısı<=10)
            {
                tahmin =int.Parse( textBox1.Text);
                label6.Text=tahminsayısı.ToString();
                if (tahmin<sayi)
                {
                    label5.Text = "doğru tahmin için sayıyı büyütünüz!";
                    puan = puan - 100;
                    label7.Text=puan.ToString();    
                }
                else if (tahmin > sayi)
                {
                    label5.Text = "doğru tahmin için sayıyı küçültünüz!";
                    puan = puan - 100;
                    label7.Text = puan.ToString();
                }
                else if (tahmin==sayi)
                {
                    MessageBox.Show("Tebrikler! "+label6.Text+" defada bilip "+puan+"puan kazandınız :))");
                    button2.Enabled = true;
                    button1.Enabled = false;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Üzgünüm yarışmayı kazanamadınız! Doğru sonuç : "+sayi);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;    
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            Random rnd=new Random();    
            sayi=rnd.Next(100);
            label5.Text = "";
            label7.Text = "1000";
            


        }
    }
}

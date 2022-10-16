using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        double s1, s2;
        String islem;
   


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }
        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

        //Form Aşagı alma Kodları
        private void winAsagi_MouseLeave(object sender, EventArgs e)
        {
            winAsagi.ForeColor = Color.Black;
          
        }
        private void winAsagi_MouseEnter(object sender, EventArgs e)
        {
            winAsagi.ForeColor = Color.White;

        }
        private void winAsagi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
           
        }





        private void btn_0_Click(object sender, EventArgs e)
        {
            if (txt_sonuc.Text =="0") { txt_sonuc.Text += "0"; }
            else { txt_sonuc.Text += "0"; }

        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            if (txt_sonuc.Text == "0") { txt_sonuc.Text = "0";}
            else
            {
                s1 = Convert.ToDouble(txt_sonuc.Text);
                txt_sonuc.Text = Convert.ToString(s1) + ",";
            }
        }
        private void btn_bir_Click(object sender, EventArgs e)
        {
            if (txt_sonuc.Text == "0"){txt_sonuc.Text = "1";}
            else {txt_sonuc.Text += "1"; }
        
        }

        private void btn_iki_Click(object sender, EventArgs e)
        {
            if (txt_sonuc.Text == "0")  {  txt_sonuc.Text = "2";}
            else {txt_sonuc.Text += "2"; }
        }

        private void btn_uc_Click(object sender, EventArgs e)
        {
            if (txt_sonuc.Text == "0"){txt_sonuc.Text = "3";}
            else { txt_sonuc.Text += "3";}

        }

        private void btn_dort_Click(object sender, EventArgs e)
        {
            if (txt_sonuc.Text == "0"){txt_sonuc.Text = "4";}
            else{ txt_sonuc.Text += "4"; }
        }

        private void btn_bes_Click(object sender, EventArgs e)
        {
            if (txt_sonuc.Text == "0"){txt_sonuc.Text = "5";}
            else{ txt_sonuc.Text += "5"; }
        }

        private void btn_alti_Click(object sender, EventArgs e)
        {
            if (txt_sonuc.Text == "0"){txt_sonuc.Text = "6";}
            else { txt_sonuc.Text += "6"; }
        }

        private void btn_yedi_Click(object sender, EventArgs e)
        {
            if (txt_sonuc.Text == "0"){ txt_sonuc.Text = "7";  }
            else{ txt_sonuc.Text += "7"; }
        }

        private void btn_sekiz_Click(object sender, EventArgs e)
        {
            if (txt_sonuc.Text == "0"){txt_sonuc.Text = "8";}
            else{ txt_sonuc.Text += "8"; }
        }

        private void btn_dokuz_Click(object sender, EventArgs e)
        {
            if (txt_sonuc.Text == "0"){ txt_sonuc.Text = "9"; }
            else{ txt_sonuc.Text += "9"; }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txt_sonuc.Text) > 0) {
                txt_sonuc.Text = txt_sonuc.Text.Remove(txt_sonuc.Text.Length - 1, 1);
                if (txt_sonuc.Text.Length == 0){txt_sonuc.Text = "0";}
            }
        }

        private void btn_sifirla_Click(object sender, EventArgs e)
        {
            txt_sonuc.Text = "0";
            lbl_sonuc.Text = "";
        }

        private void gunaGradientTileButton10_Click(object sender, EventArgs e)
        {
            lbl_sonuc.Text = "";
        }


        
        
        private void btn_topla_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(txt_sonuc.Text);
            islem = "+";
            lbl_sonuc.Text = txt_sonuc.Text + "+";
            txt_sonuc.Text = "0";
          
        }

        private void btn_cikar_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(txt_sonuc.Text);
            islem = "-";
            lbl_sonuc.Text = txt_sonuc.Text + "-";
            txt_sonuc.Text = "0";
        }

        private void btn_bol_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(txt_sonuc.Text);
            islem = "/";
            lbl_sonuc.Text = txt_sonuc.Text + "/";
            txt_sonuc.Text = "0";
        }

        private void btn_carp_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(txt_sonuc.Text);
            islem = "x";
            lbl_sonuc.Text = txt_sonuc.Text + "x";
            txt_sonuc.Text = "0";
        }

        private void pozneg_Click(object sender, EventArgs e)
        {

            int s3 = Convert.ToInt32(txt_sonuc.Text);

            if (s3 < 0)
            {
                int sonuc = Math.Abs(s3);
                lbl_sonuc.Text = sonuc.ToString();
                txt_sonuc.Text = Convert.ToString(sonuc);
            }
            else {
                txt_sonuc.Text = Convert.ToString(s3 * (-1)); 
            } 
            lbl_sonuc.Text = s3 + "+/-";
        }


        private void gunaGradientTileButton12_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(txt_sonuc.Text);
            double kare = Convert.ToDouble(txt_sonuc.Text);
            kare = Math.Pow(kare, 2);
            txt_sonuc.Text = Convert.ToString(kare);
            lbl_sonuc.Text = s1+"^2";
        }

        private void gunaGradientTileButton11_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(txt_sonuc.Text);
            double karekok = Convert.ToDouble(txt_sonuc.Text);
            karekok = Math.Sqrt(karekok);
            txt_sonuc.Text = Convert.ToString(karekok);
            lbl_sonuc.Text = "√(" + s1 + ")";
        }

        private void gunaGradientTileButton5_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(txt_sonuc.Text);
            double bolum = Convert.ToDouble(txt_sonuc.Text);
            bolum = 1 / (bolum);
            txt_sonuc.Text = Convert.ToString(bolum);
            lbl_sonuc.Text = "1/(" + s1 + ")";
        }

        private void gunaGradientTileButton1_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(txt_sonuc.Text);
            islem = "mod";
            lbl_sonuc.Text = txt_sonuc.Text + "(mod)";
            txt_sonuc.Text = "0";
        }
        private void Faktoriyel_Click(object sender, EventArgs e)
        {
            int sonuc = 1;
            s1 = Convert.ToDouble(txt_sonuc.Text);
            double fakto = Convert.ToDouble(txt_sonuc.Text);
            for (int i = 1; i <= fakto; i++)
            {
                sonuc = i * sonuc;
            }
            

            txt_sonuc.Text = Convert.ToString(sonuc);
            lbl_sonuc.Text = s1+"!";
        }

        private void btn_sonuc_Click(object sender, EventArgs e)//= işareti ile yapılacak matematiksel işlemler
        {
            s2 = Convert.ToDouble(txt_sonuc.Text);
            switch (islem) {

                case "+":
                    txt_sonuc.Text = Convert.ToString(s1 + s2);
                    lbl_sonuc.Text = null;
                    break;

                case "-":
                    txt_sonuc.Text = Convert.ToString(s1 - s2);
                    lbl_sonuc.Text = null;
                    break;

                case "/":
                    txt_sonuc.Text = Convert.ToString(s1 / s2);
                    lbl_sonuc.Text = null;
                    break;

                case "x":
                    txt_sonuc.Text = Convert.ToString(s1 * s2);
                    lbl_sonuc.Text = null;
                    break;

                case "mod":
                    txt_sonuc.Text = Convert.ToString(s1 % s2);
                    lbl_sonuc.Text = null;
                    break;

            }

        }

        


        //textboxa sadece sayı girilebilecek.
        private void txt_sonuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }

   

    }


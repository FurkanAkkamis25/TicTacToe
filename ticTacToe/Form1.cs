using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ticTacToe
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
           
           
        }
        public enum oyuncular
        {
            X, O
        }
        oyuncular oyuncuX;
        int oyuncu = 0;
        int bilgisayar = 0;
        Random random = new Random();
        List<Button> butonlar;
        Boolean sıra = true;






        private void Form1_Load(object sender, EventArgs e)
        {
                
        }


        private void yenileButon(object sender, EventArgs e)
        {
            yenile();
        }

        private void oyuncuTikla(object sender, EventArgs e)
        {
            if (sıra)
            {
                oyuncuX = oyuncular.X;
                label4.Text = "Sıra O Oyuncusunda";
            }
            else
            {
                oyuncuX = oyuncular.O;
                label4.Text = "Sıra X Oyuncusunda";
            }
            var button = (Button)sender;
            butonlar = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            button.Text = oyuncuX.ToString();
            button.Enabled = false;
            //  button.BackColor 
            butonlar.Remove(button);
            Console.Read();
            pcTimer.Start();
            sıra = !sıra;
            oyunKontrol();

        }
        private void yenile()
        {
            butonlar = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            foreach (Button X in butonlar)
            {
                X.Enabled = true;
                X.Text = " ";
                X.BackColor = DefaultBackColor;
            }

        }
        private void oyunKontrol()
        {
         if(button1.Text=="X"&& button2.Text=="X"&& button3.Text=="X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                pcTimer.Stop();
                MessageBox.Show("X OYUNCUSU KAZANDI..");
                oyuncu++;
                label3.Text = "X Oyuncusu:" + oyuncu;
                yenile();
            }
         else if(button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                pcTimer.Stop();
                MessageBox.Show("O OYUNCUSU KAZANDI..");
                bilgisayar++;
                label2.Text = "O Oyuncusu: " + bilgisayar;
                yenile();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private KoderDekoder wsk;
        private int kodowanie = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            kodowanie = 0;

            wsk = new ROT13(napis.Text);
            if (wybor.Text == "Kodowanie")
                zakodowane.Text = wsk.koduj();
            else
                zakodowane.Text = wsk.dekoduj();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            kodowanie = 1;
            napis.Text = "";
            zakodowane.Text = "";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            kodowanie = 2;
            wsk = new Kwadrat(napis.Text);
            if (wybor.Text == "Kodowanie")
                zakodowane.Text = wsk.koduj();
            else
                zakodowane.Text = wsk.dekoduj();
        }



        private void napis_KeyUp(object sender, KeyEventArgs e)
        {
            switch (kodowanie)
            {
                case 0:
                    wsk = new ROT13(napis.Text);
                    break;
                case 1:
                    wsk = new Hex(napis.Text);
                    break;
                case 2:
                    wsk = new Kwadrat(napis.Text);
                    break;
                case 3:
                    wsk = new Base64(napis.Text);
                    break;
            }

            if (wybor.Text == "Kodowanie")
            {
                zakodowane.Text = wsk.koduj();
            }
            else
            {
                zakodowane.Text = wsk.dekoduj();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Tekst wyjściowy.txt";
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                    sw.WriteLine(zakodowane.Text);
            }
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Tekst wyjściowy.txt";
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                    sw.WriteLine(zakodowane.Text);
            }
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autorem programu jest Grzegorz Milaszkiewicz®", "O autorze");
        }

        private void instrukcjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Wybierz pozycję z listy Kodowanie/Dekodowanie \n2. Zaznacz wybrany algorytm \n3. Wpisz tekst w wyznaczone pole", "Instrukcja obsługi");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            kodowanie = 3;
            wsk = new Base64(napis.Text);
            if (wybor.Text == "Kodowanie")
                zakodowane.Text = wsk.koduj();
            else
                zakodowane.Text = wsk.dekoduj();
        }
    }
    }

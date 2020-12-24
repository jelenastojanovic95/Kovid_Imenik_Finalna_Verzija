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


namespace Kovid_Imenik
{
    public partial class Dodaj_pacijenta : Form
    {
        public Dodaj_pacijenta()
        {
            InitializeComponent();
        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonMinimiziraj_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            Pacijent pacijent = new Pacijent();
            
            string Ime = textBoxImePacijenta.Text;
            string Prezime = textBoxPrezimePacijenta.Text;
            string JMBG = textBoxJMBG.Text;
            string BrTel = textBoxBrTel.Text;
            string LBO = textBoxLBO.Text; ;
            string RezultatTesta = comboBoxRezultatTesta.Text;
            string PoslednjiTest = textBoxDatum.Text;
            string BezSimptoma = comboBoxBezSimptoma.Text;
            string Oporavljen = comboBoxOporavljen.Text;
            string PodlegaoBolesti = comboBoxPodlegaoBolesti.Text;
            string Dijabetes = comboBoxDijabetes.Text;
            string KVProblemi = comboBoxKVProblemi.Text;
            string PlucneBolesti = comboBoxPlucneBolesti.Text;

           
            bool jmbgIma13Cifara;//provera da li jmbg ima 13 cifara
            if (JMBG.Length ==13)
            {
                jmbgIma13Cifara = true;
                
            }
            else
            {
                jmbgIma13Cifara = false;
            }

                 
                
                if (!jmbgIma13Cifara)
                {
                    MessageBox.Show("Greska! JMBG pacijenta mora imati 13 cifara!", "Dodaj pacijenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (jmbgIma13Cifara)
                {
                    int[] JmbgInt = new int[13];
                    string[] nizJMBG = new string[13];//prebacujem JMBG u niz stringova od po jedan karakter, sa zeljom da ga posle konvertujem u int
                    bool poslednjCifraJeKorektna;
                    int S, K, m;


                    for (int i = 0; i < 13; i++)
                    {
                        nizJMBG[i] = JMBG.Substring(i, 1);
                    }
                    for (int i = 0; i < 13; i++)
                    {
                        JmbgInt[i] = Convert.ToInt32(nizJMBG[i]);
                    }

                    S = 7 * JmbgInt[0] + 6 * JmbgInt[1] + 5 * JmbgInt[2] + 4 * JmbgInt[3] + 3 * JmbgInt[4] + 2 * JmbgInt[5] + 7 * JmbgInt[6] + 6 * JmbgInt[7] + 5 * JmbgInt[8] + 4 * JmbgInt[9] + 3 * JmbgInt[10] + 2 * JmbgInt[11];
                    m = S % 11;

                    if (m == 0)
                    {
                        K = 0;
                    }
                    else if (m > 1)
                    {
                        K = 11 - m;
                    }
                    else K = -1;

                    if (JmbgInt[12] == K)
                    {
                        poslednjCifraJeKorektna = true;
                    }
                    else
                    {
                        poslednjCifraJeKorektna = false;
                    }

                    if (poslednjCifraJeKorektna)
                    {
                        if (pacijent.ubaciPacijenta(Ime, Prezime, JMBG, BrTel, LBO, PoslednjiTest, RezultatTesta, Oporavljen, PodlegaoBolesti, BezSimptoma, Dijabetes, KVProblemi, PlucneBolesti))
                        { MessageBox.Show("Novi pacijent je dodat", "Dodaj pacijenta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    }
                    else 
                    {
                      MessageBox.Show("Greska! JMBG pacijenta ne postoji!", "Dodaj pacijenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Greska", "Dodaj pacijenta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            
        }

        private void buttonDatum_Click(object sender, EventArgs e)
        {
            textBoxDatum.Text = monthCalendar.SelectionStart.Day.ToString() + "/" +
                monthCalendar.SelectionStart.Month.ToString() + "/" + monthCalendar.SelectionStart.Year.ToString();
        }
    }
}

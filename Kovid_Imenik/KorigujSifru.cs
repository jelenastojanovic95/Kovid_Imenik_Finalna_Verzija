using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kovid_Imenik
{
    public partial class KorigujSifru : Form
    {
        public KorigujSifru()
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
        
        
        Korisnik korisnik = new Korisnik();



        int Uporedi(string A, string B)//definisemo metod uporedi koja ce da nam vrati 0, -1 ili 1
        {
            int s = A.CompareTo(B);
            return s;
        }

        private void buttonKorigujKor_Click(object sender, EventArgs e)
        {
            DataTable table = korisnik.dodajKorisnikaPomocuID(Uopstenje.UopsteniKorisnickiID);
            string Ime = table.Rows[0][1].ToString();
            string Prezime = table.Rows[0][2].ToString();
            string KorIme = table.Rows[0][3].ToString();
            string SifraBol = table.Rows[0][4].ToString();

            Moja_Baza_Podataka bp = new Moja_Baza_Podataka();

            int idKorisnika = Uopstenje.UopsteniKorisnickiID;// ostani prijavljen u korisnicki id

            string Sifra = textBoxSifraKor.Text;
            string SifraPon = textBoxSifraPonovo.Text;

            

            bool jednakaPolja;//proveravam da li polja sifra i ponovljena iste da bi mogli da proenimo sifru korisnika
            if (Uporedi(Sifra, SifraPon) == 0)
            {
                jednakaPolja = true;
            }
            else
            {
                jednakaPolja = false;
            }

            if (Sifra.Trim().Equals("") || SifraPon.Trim().Equals("")) //proveri prazna polja
            {
                MessageBox.Show("Potrebno je da oba polja budu popunjena", "Informacija o korigovanju", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                if (korisnik.korigujKorisnika(idKorisnika, Ime, Prezime, KorIme, Sifra, SifraBol)  & jednakaPolja)
                {

                    MessageBox.Show("Tvoji podaci su korigovani", "Informacije o korigovanju", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (!jednakaPolja)
                {
                    MessageBox.Show("Unesene sifre se ne poklapaju!", "Informacija o korigovanju", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Greska", "Informacije o korigovanju", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

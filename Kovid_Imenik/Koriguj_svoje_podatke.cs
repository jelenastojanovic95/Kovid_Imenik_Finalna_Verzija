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
    public partial class Koriguj_svoje_podatke : Form
    {
        public Koriguj_svoje_podatke()
        {
            InitializeComponent();
        }

        Korisnik korisnik = new Korisnik();
        private void Koriguj_svoje_podatke_Load(object sender, EventArgs e)
        {
            //prikazi podatke korisnika
            DataTable table = korisnik.dodajKorisnikaPomocuID(Uopstenje.UopsteniKorisnickiID);
            textBoxImeKor.Text = table.Rows[0][1].ToString();
            textBoxPrezimeKor.Text = table.Rows[0][2].ToString();
            textBoxKorImeKor.Text = table.Rows[0][3].ToString();
            
            textBoxSifraBolKor.Text = table.Rows[0][4].ToString();
        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonMinimiziraj_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        int Uporedi(string A, string B)//definisemo metod uporedi koja ce da nam vrati 0, -1 ili 1
        {
            int s = A.CompareTo(B);
            return s;
        }

        //
        private void buttonKorigujKor_Click(object sender, EventArgs e)
        {
            DataTable table = korisnik.dodajKorisnikaPomocuID(Uopstenje.UopsteniKorisnickiID);
            string PostojecaSifra = table.Rows[0][5].ToString();//Pamtim postojecu sifru korisnika ali je ne prikazujem

            Moja_Baza_Podataka bp = new Moja_Baza_Podataka();

            int idKorisnika = Uopstenje.UopsteniKorisnickiID;// ostani prijavljen u korisnicki id
            string Ime = textBoxImeKor.Text;
            string Prezime = textBoxPrezimeKor.Text;

            string SifraBol = textBoxSifraBolKor.Text;
            string KorIme = textBoxKorImeKor.Text;

      

            if (Ime.Trim().Equals("") || Prezime.Trim().Equals("") || KorIme.Trim().Equals("") || SifraBol.Trim().Equals("")) //proveri prazna polja
            {
                MessageBox.Show("Potrebno je da polja: Korisnicko ime, Ime, Prezime i Sifra bolnice ne budu prazna", "Informacija o korigovanju", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (korisnik.korImePostojanje(KorIme, "Koriguj", idKorisnika))//proveri da li korIme vec postoji, i da je razlicito od njegovog kor imena 
                {
                    MessageBox.Show("Ovo korisnicko ime vec postoji probajte drugo", "Nekorektno korisnicko ime",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                if (korisnik.korigujKorisnikaBezSifre(idKorisnika, Ime, Prezime, KorIme, SifraBol, PostojecaSifra))
                {
                    
                    MessageBox.Show("Tvoji podaci su korigovani", "Informacije o korigovanju", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                {
                    MessageBox.Show("Greska", "Informacije o korigovanju", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonPromeniSifru_Click(object sender, EventArgs e)
        {
            KorigujSifru korigujSifru = new KorigujSifru();
            korigujSifru.Show(this);
        }
    }
}

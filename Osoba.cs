using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseiObjekti12
{
    internal class Osoba
    {
        string ime, prezime;
        int godinaRođenja, visina, tezina;
        char spol;

        public void setIme(string ime)
        {
            this.ime = ime;
        }
        public void setPrezime(string prezime)
        {
            this.prezime = prezime;
        }
        public void setGodinarođenja(int godinaRođenja)
        {
            this.godinaRođenja = godinaRođenja;
        }
        public void setVisina(int visina)
        {
            this.visina = visina;
        }
        public void setTezina(int tezina)
        {
            this.tezina = tezina;
        }
        public void setSpol(char spol)
        {
            this.spol = spol;
        }



        public string getIme()
        {
            return this.ime;
        }
        public string getPrezime()
        {
            return this.prezime;
        }
        public int getGodinarođenja()
        {
            return this.godinaRođenja;
        }
        public int getVisina()
        {
            return this.visina;
        }
        public int getTezina()
        {
            return this.tezina;
        }
        public char getSpol()
        {
            return this.spol;
        }

        public override string ToString()
        {
            string ispis = "Ime i prezime: " + this.getIme()
                + " " + this.getPrezime() + "\n"
                + "Godina rođenja: " + this.getGodinarođenja() + "\n"
                + "Visina: " + this.getVisina() + "cm\n"
                + "Težina: " + this.getTezina() + "kg\n"
                + "Spol: " + this.getSpol();
            return ispis;

        }
        public Osoba(String ime, String prezime, int godinaRodjenja,
            int visina, int tezina, char spol)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godinaRođenja = godinaRodjenja;
            this.visina = visina;
            this.tezina = tezina;
            this.spol = spol;
        }

        public Osoba()
        {
        }
    }
}

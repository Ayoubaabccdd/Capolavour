using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Capolavour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> Giocatori = new List<string>();



        public void AddGiocatore()
        {
            string giocatore;
            string Nome, Cognome, id;
            Nome = nome1.Text; Cognome = cognome1.Text; id = id1.Text;
            giocatore = Nome + " " + Cognome + " " + id;

            if (Giocatori.Contains(giocatore))
            {
                MessageBox.Show("Giocatore inserito");
            }
            else
            {
                Giocatori.Add(giocatore);
                listView1.Items.Add(giocatore);
            }

        }
        private void Add_Click(object sender, EventArgs e)
        {
            AddGiocatore();
            nome1.Text = "";
            cognome1.Text = "";
            id1.Text = "";
        }

        public void DelGiocatore()
        {
            string giocatore;
            string Nome, Cognome, id;
            Nome = nome1.Text; Cognome = cognome1.Text; id = id1.Text;
            giocatore = Nome + " " + Cognome + " " + id;
            if (Giocatori.Contains(giocatore))
            {
                Giocatori.Remove(giocatore);
            }
            else
            {
                MessageBox.Show("Giocatore non trovato");
            }
            Visualizza();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DelGiocatore();
            nome1.Text = "";
            cognome1.Text = "";
            id1.Text = "";

        }

        private void Visualizza()
        {
            listView1.Items.Clear();
            for (int j = 0; j < Giocatori.Count; j++)
            {
                listView1.Items.Add(Giocatori[j]);
            }
        }


        private void DEL_TextChanged(object sender, EventArgs e)
        {

        }



        private void start_Click(object sender, EventArgs e)
        {
            if (Giocatori.Count > 2)
            {
                Visualizza();
                AbbinaElementiCasualmente(Giocatori);
            }
            else
            {
                MessageBox.Show("Impossibile iniziare il torneo, Numero di partecipaneti insufficenti");
            }
        }

       
        public List<string> AbbinaElementiCasualmente(List<string> elementi)
        {
            Random random = new Random();
            List<string> elementiMescolati = new List<string>(elementi);
            int n = elementiMescolati.Count;

            // Mescola gli elementi
            for (int i = 0; i < n; i++)
            {
                int j = random.Next(i, n);
                string temp = elementiMescolati[i];
                elementiMescolati[i] = elementiMescolati[j];
                elementiMescolati[j] = temp;
            }
            List<string> coppie = new List<string>();

            // Crea le coppie
            for (int i = 0; i < n - 1; i += 2)
            {
                coppie.Add((elementiMescolati[i] + "                " +elementiMescolati[i + 1]));
            }

            VisualizzaCoppie(coppie);

            return coppie;
        }
        private void VisualizzaCoppie(List<string> coppie) 
        {
            listView1.Items.Clear();
            for (int j = 0; j < coppie.Count; j++)
            {
                listView1.Items.Add(coppie[j]);
            }
        }
    }
}

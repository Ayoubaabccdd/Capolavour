﻿using System;
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
        private Dictionary<string, int> Punti = new Dictionary<string, int>();
        private List<Giocatore> Giocatores = new List<Giocatore>();

        public class Giocatore
        {
            int Punti;
            string nome; string cognome; string id;
            public Giocatore(string nome, string cognome, string id)
            {
                this.nome = nome;
                this.cognome = cognome;
                this.id = id;   
            }

        }

        //Aggiunge giocatore alla lista degli iscritti
        public void AddGiocatore()
        {
            string giocatore;
            string Nome, Cognome, id;
            Nome = nome1.Text; Cognome = cognome1.Text; id = id1.Text;
            giocatore = Nome + " " + Cognome + " " + id;
            //controlla l'esistenza del giocatore
            if (Giocatori.Contains(giocatore))
            {
                MessageBox.Show("Giocatore inserito");
            }
            else
            {
                Giocatori.Add(giocatore);
                Listagioc.Items.Add(giocatore);
                Punti[giocatore] = 0;

            }

        }
        private void Add_Click(object sender, EventArgs e)
        {
            AddGiocatore();
            nome1.Text = "";
            cognome1.Text = "";
            id1.Text = "";
        }

        //rimuove giocatore alla lista degli iscritti
        public void DelGiocatore()
        {
            string giocatore;
            string Nome, Cognome, id;
            Nome = nome1.Text; Cognome = cognome1.Text; id = id1.Text;
            giocatore = Nome + " " + Cognome + " " + id;
            //controlla l'esistenza del giocatore
            if (Giocatori.Contains(giocatore))
            {
                Giocatori.Remove(giocatore);
                Punti[giocatore] = 0;

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
        //visualizza i giocatori nella lista degli iscritti
        private void Visualizza()
        {
            Listagioc.Items.Clear();
            for (int j = 0; j < Giocatori.Count; j++)
            {
                Listagioc.Items.Add(Giocatori[j]);
            }
        }
        //visualizza il tabellone degli abbinamenti
        private void VisualizzaTab()
        {
            listView1.Items.Clear();
            for (int j = 0; j < Giocatori.Count; j++)
            {
                listView1.Items.Add(Giocatori[j]);
            }
        }
        //visualizza classifica
        private void VisualizzaClassifica()
        {
            Classifica.Items.Clear();
            //fa un sort in ordine decrescente di punti
            var classifica = Giocatori
                .Select(g => new
                {
                    Giocatore = g,
                    Punti = (Punti[g]) 
                })
                .OrderByDescending(g => g.Punti);
            //aggiunge gli elementi nella classifica
            foreach (var Giocatore in classifica)
            {
                Classifica.Items.Add(Giocatore.Giocatore + "  punti tot:" + Giocatore.Punti);
            }
        }


        private void DEL_TextChanged(object sender, EventArgs e)
        {

        }


        //inizia il torneo creando gli abbinamenti tramite CalcolaTurni
        private void start_Click(object sender, EventArgs e)
        {
            //stampa i giocatori nella lista degli iscritti e nel tabellone
            if (Giocatori.Count > 2)
            {
                listView1.Clear();
                for (int j = 0; j < Giocatori.Count; j++)
                {
                    listView1.Items.Add(Giocatori[j]);
                }
                VisualizzaTab();
                CalcolaTurni();
                
            }
            else
            {
                MessageBox.Show("Impossibile iniziare il torneo, Numero di partecipaneti insufficenti");
            }
        }

        //crea abbinamenti casuali mettendo in coppie le persone
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
                coppie.Add((elementiMescolati[i] + "       vs        " + elementiMescolati[i + 1]));
            }

            VisualizzaCoppie(coppie);

            return coppie;
        }
        //visualizza le coppie nel tabellone
        private void VisualizzaCoppie(List<string> coppie)
        {
            listView1.Items.Clear();
            for (int j = 0; j < coppie.Count; j++)
            {
                listView1.Items.Add(coppie[j]);
            }
        }
        //assegna la vittoria al giocatore 
        public void Win()
        {
            string giocatore;
            string Nome, Cognome, id;
            Nome = nome1.Text; Cognome = cognome1.Text; id = id1.Text;
            giocatore = Nome + " " + Cognome + " " + id;
            //registra la vittoria
            if (Giocatori.Contains(giocatore))
            {
                Punti[giocatore]+= 3;

                MessageBox.Show($"Vittoria registrata per {giocatore}");
                Classifica.Items.Add(giocatore + " " + Punti[giocatore]);
            }

        }
        //bottone per assegnare la vittoria
        private void winbutton_Click(object sender, EventArgs e)
        {
            Win();
            nome1.Text = "";
            cognome1.Text = "";
            id1.Text = "";
        }

        //assegna la sconfitta al giocatore 
        public void Lose()
        {
            string giocatore;
            string Nome, Cognome, id;
            Nome = nome1.Text; Cognome = cognome1.Text; id = id1.Text;
            giocatore = Nome + " " + Cognome + " " + id;
            //registra la sconfitta
            if (Giocatori.Contains(giocatore))
            {
                
                MessageBox.Show($"Sconfitta registrata per {giocatore}");
                Classifica.Items.Add(giocatore + " " + Punti[giocatore]);
            }

        }
        //bottone per assegnare la sconfitta
        private void losebtn_Click(object sender, EventArgs e)
        {
            Lose();
            nome1.Text = "";
            cognome1.Text = "";
            id1.Text = "";
        }
        //assegna il pareggio al giocatore 
        public void Draw()
        {
            string giocatore;
            string Nome, Cognome, id;
            Nome = nome1.Text; Cognome = cognome1.Text; id = id1.Text;
            giocatore = Nome + " " + Cognome + " " + id;
            //registra il pareggio
            if (Giocatori.Contains(giocatore))
            {
                Punti[giocatore]++;
                MessageBox.Show($"Pareggio registrato per {giocatore}");
                Classifica.Items.Add(giocatore + " " + Punti[giocatore]);
            }

        }
        //bottone per assegnare il pareggio
        private void drawbtn_Click(object sender, EventArgs e)
        {
            Draw();
            nome1.Text = "";
            cognome1.Text = "";
            id1.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void classbtn_Click(object sender, EventArgs e)
        {
            VisualizzaClassifica();
        }

    
        //calcola i turni necessari per svolgere il torneo e vede se è possibile iniziarlo
        private void CalcolaTurni()
        {
            if (Giocatori.Count % 2 != 0)
            {
                MessageBox.Show("Il numero di giocatori deve essere pari per creare i turni.");
                return;
            }

            var abbinamenti = AbbinaGiocatoriPerTurno();
            VisualizzaCoppie(abbinamenti);
        }
        //abbina i giocatori in base al punteggio ottenuto nei vari turni
        private List<string> AbbinaGiocatoriPerTurno()
        {
            var giocatoriOrdinati = Giocatori
                .OrderByDescending(g => (Punti[g]))
                .ToList();

            List<string> coppie = new List<string>();

            for (int i = 0; i < giocatoriOrdinati.Count; i += 2)
            {
                coppie.Add(giocatoriOrdinati[i] + " vs " + giocatoriOrdinati[i + 1]);
            }

            
            return coppie;
        }
        //crea un nuovo turno con gli abbinamenti nuovi
        private void button2_Click(object sender, EventArgs e)
        {
            CalcolaTurni();
            Classifica.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Classifica.Items.Clear();
        }

        private void nome1_TextChanged(object sender, EventArgs e)
        {

        }
        //funzionalita per poter aggiungere i dati alle caselle cliccando direttamente dalla lista di giocatori
        private void Listagioc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Listagioc.SelectedIndices.Count > 0)
            {
                int indexSelected = Listagioc.SelectedIndices[0];
                var info = Giocatori[indexSelected].Split(' ');

                nome1.Text = info[0];
                if(info.Length > 1)
                {
                    cognome1.Text = info[1];
                }
                if(info.Length > 2)
                {
                    id1.Text = info[2];
                }
                
            }
        }
        //fine torneo, visualizza la classifica finale
        private void endbtn_Click(object sender, EventArgs e)
        {
            VisualizzaClassifica();
        }
    }
}




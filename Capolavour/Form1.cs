﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

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
            else {
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
                for (int a = 0; a < Giocatori.Count; a++)
                {
                   
                    Giocatori[a] = Giocatori[a] + "   "+(a+1).ToString();
                }
                Visualizza();

            }
            else
            {
                MessageBox.Show("Impossibile iniziare il torneo, Numero di partecipaneti insufficenti");
            }
        }
        public void coppie () 
        { 
            Random P = new Random();   
            List<string> Pairing = new List<string>();
            for (int a = 0; a < Giocatori.Count; a++)
            {
                Pairing[a] = Giocatori[a];
            }
        }   
    }
}

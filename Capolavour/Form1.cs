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
        private Dictionary<string, int> Vittorie = new Dictionary<string, int>();
        private Dictionary<string, int> Sconfitte = new Dictionary<string, int>();
        private Dictionary<string, int> Pareggi = new Dictionary<string, int>();



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
                Vittorie[giocatore] = 0;
                Sconfitte[giocatore] = 0;
                Pareggi[giocatore] = 0;
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
                Giocatori.Add(giocatore);
                Vittorie[giocatore] = 0;
                Sconfitte[giocatore] = 0;
                Pareggi[giocatore] = 0;
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
        private void VisualizzaClassifica()
        {
            Classifica.Items.Clear();

            var classifica = Giocatori
                .Select(g => new
                {
                    Giocatore = g,
                    Punti = (Vittorie[g]) + (Pareggi[g])
                })
                .OrderByDescending(g => g.Punti);
            for (int j = 0; j < Giocatori.Count; j++)
            {
                Classifica.Items.Add(Giocatori[j]);

            }
        }


        private void DEL_TextChanged(object sender, EventArgs e)
        {

        }



        private void start_Click(object sender, EventArgs e)
        {
            if (Giocatori.Count > 2)
            {
                listView1.Clear();
                for (int j = 0; j < Giocatori.Count; j++)
                {
                    listView1.Items.Add(Giocatori[j]);
                }
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
                coppie.Add((elementiMescolati[i] + "                " + elementiMescolati[i + 1]));
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

        public void Vittoria(object sender, EventArgs e)
        {
            string player = listView1.Items.ToString().Split(' ')[0];
            if (Giocatori.Contains(player))
            {
                Vittorie[player]++;
                MessageBox.Show($"Vittoria registrata per {player}");
            }
            else
            {
                MessageBox.Show("Giocatore non trovato.");
            }
        }

        public void Pareggio(object sender, EventArgs e)
        {
            string player = listView1.Items.ToString().Split(' ')[0];
            if (Giocatori.Contains(player))
            {
                Sconfitte[player]++;
                MessageBox.Show($"Sconfitta registrata per {player}");
            }
            else
            {
                MessageBox.Show("Giocatore non trovato.");
            }
        }

        public void Sconfitta(object sender, EventArgs e)
        {
            string player = listView1.Items.ToString().Split(' ')[0];
            if (Giocatori.Contains(player))
            {
                Pareggi[player]++;
                MessageBox.Show($"Pareggio registrato per {player}");
            }
            else
            {
                MessageBox.Show("Giocatore non trovato.");
            }
            
        }
        public void Win()
        {
            string giocatore;
            string Nome, Cognome, id;
            Nome = nome1.Text; Cognome = cognome1.Text; id = id1.Text;
            giocatore = Nome + " " + Cognome + " " + id;
            if (Giocatori.Contains(giocatore))
            {
                Vittorie[giocatore]++;
                Vittorie[giocatore]++;
                Vittorie[giocatore]++;
                MessageBox.Show($"Vittoria registrata per {giocatore}");
                Classifica.Items.Add(giocatore + " " + Vittorie[giocatore]);
            }

        }
        private void winbutton_Click(object sender, EventArgs e)
        {
            Win();
        }

        public void Lose()
        {
            string giocatore;
            string Nome, Cognome, id;
            Nome = nome1.Text; Cognome = cognome1.Text; id = id1.Text;
            giocatore = Nome + " " + Cognome + " " + id;
            if (Giocatori.Contains(giocatore))
            {
                
                MessageBox.Show($"Sconfitta registrata per {giocatore}");
                Classifica.Items.Add(giocatore + " " + Sconfitte[giocatore]);
            }

        }
        private void losebtn_Click(object sender, EventArgs e)
        {
            Lose();
        }
        public void Draw()
        {
            string giocatore;
            string Nome, Cognome, id;
            Nome = nome1.Text; Cognome = cognome1.Text; id = id1.Text;
            giocatore = Nome + " " + Cognome + " " + id;
            if (Giocatori.Contains(giocatore))
            {
                Pareggi[giocatore]++;
                MessageBox.Show($"Pareggio registrato per {giocatore}");
                Classifica.Items.Add(giocatore + " " + Pareggi[giocatore]);
            }

        }

        private void drawbtn_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void classbtn_Click(object sender, EventArgs e)
        {
            VisualizzaClassifica();
        }

        private void Turni()
        {
            int a = Giocatori.Count;

            
            Math.Sqrt(a);
            switch (a)
            {
                case 0: 

                case 1:

                case 2:

                case 3:

                case 4:

                case 5:

                case 6:

                case 7:

                case 8:

                break;
            }
        }

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

        private List<string> AbbinaGiocatoriPerTurno()
        {
            var giocatoriOrdinati = Giocatori
                .OrderByDescending(g => (Vittorie[g] * 3) + Pareggi[g])
                .ToList();

            List<string> coppie = new List<string>();

            for (int i = 0; i < giocatoriOrdinati.Count; i += 2)
            {
                coppie.Add(giocatoriOrdinati[i] + " vs " + giocatoriOrdinati[i + 1]);
            }

            return coppie;
        }

    }
}




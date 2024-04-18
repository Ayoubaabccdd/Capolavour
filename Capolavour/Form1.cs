using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private string Nome, Cognome, id;

        private void Add_Click(object sender, EventArgs e)
        {
            AddGiocatore();
        }

        public void AddGiocatore()
        {
            Giocatori.Add(nome1.Text);
            listView1.Items.Add(nome1.Text);
            Giocatori.Add(cognome1.Text);
            listView1.Items.Add(cognome1.Text);
            Giocatori.Add(id1.Text);
            listView1.Items.Add(id1.Text);
        }
        
    }
}

namespace Capolavour
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.nome1 = new System.Windows.Forms.TextBox();
            this.id1 = new System.Windows.Forms.TextBox();
            this.cognome1 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.gioccont = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.winbutton = new System.Windows.Forms.Button();
            this.Classifica = new System.Windows.Forms.ListView();
            this.drawbtn = new System.Windows.Forms.Button();
            this.losebtn = new System.Windows.Forms.Button();
            this.classbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Listagioc = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.endbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nome1
            // 
            this.nome1.Location = new System.Drawing.Point(251, 124);
            this.nome1.Margin = new System.Windows.Forms.Padding(4);
            this.nome1.Name = "nome1";
            this.nome1.Size = new System.Drawing.Size(132, 22);
            this.nome1.TabIndex = 0;
            this.nome1.TextChanged += new System.EventHandler(this.nome1_TextChanged);
            // 
            // id1
            // 
            this.id1.Location = new System.Drawing.Point(255, 268);
            this.id1.Margin = new System.Windows.Forms.Padding(4);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(132, 22);
            this.id1.TabIndex = 1;
            // 
            // cognome1
            // 
            this.cognome1.Location = new System.Drawing.Point(251, 193);
            this.cognome1.Margin = new System.Windows.Forms.Padding(4);
            this.cognome1.Name = "cognome1";
            this.cognome1.Size = new System.Drawing.Size(132, 22);
            this.cognome1.TabIndex = 2;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(16, 121);
            this.Add.Margin = new System.Windows.Forms.Padding(4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(197, 28);
            this.Add.TabIndex = 3;
            this.Add.Text = "Aggiungi Giocatore";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gioccont});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(739, 111);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(306, 405);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // gioccont
            // 
            this.gioccont.Text = "";
            this.gioccont.Width = 400;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cognome";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 190);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Rimuovi Giocatore";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(16, 262);
            this.start.Margin = new System.Windows.Forms.Padding(4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(197, 28);
            this.start.TabIndex = 10;
            this.start.Text = "Inizio Torneo";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // winbutton
            // 
            this.winbutton.Location = new System.Drawing.Point(68, 355);
            this.winbutton.Name = "winbutton";
            this.winbutton.Size = new System.Drawing.Size(75, 23);
            this.winbutton.TabIndex = 11;
            this.winbutton.Text = "Vittoria";
            this.winbutton.UseVisualStyleBackColor = true;
            this.winbutton.Click += new System.EventHandler(this.winbutton_Click);
            // 
            // Classifica
            // 
            this.Classifica.HideSelection = false;
            this.Classifica.Location = new System.Drawing.Point(1103, 124);
            this.Classifica.Name = "Classifica";
            this.Classifica.Size = new System.Drawing.Size(236, 317);
            this.Classifica.TabIndex = 12;
            this.Classifica.UseCompatibleStateImageBehavior = false;
            this.Classifica.View = System.Windows.Forms.View.List;
            // 
            // drawbtn
            // 
            this.drawbtn.Location = new System.Drawing.Point(257, 355);
            this.drawbtn.Name = "drawbtn";
            this.drawbtn.Size = new System.Drawing.Size(75, 23);
            this.drawbtn.TabIndex = 13;
            this.drawbtn.Text = "Pareggio";
            this.drawbtn.UseVisualStyleBackColor = true;
            this.drawbtn.Click += new System.EventHandler(this.drawbtn_Click);
            // 
            // losebtn
            // 
            this.losebtn.Location = new System.Drawing.Point(161, 355);
            this.losebtn.Name = "losebtn";
            this.losebtn.Size = new System.Drawing.Size(75, 23);
            this.losebtn.TabIndex = 14;
            this.losebtn.Text = "Sconfitta";
            this.losebtn.UseVisualStyleBackColor = true;
            this.losebtn.Click += new System.EventHandler(this.losebtn_Click);
            // 
            // classbtn
            // 
            this.classbtn.Location = new System.Drawing.Point(78, 415);
            this.classbtn.Name = "classbtn";
            this.classbtn.Size = new System.Drawing.Size(227, 23);
            this.classbtn.TabIndex = 15;
            this.classbtn.Text = "Visualizza Classifica Provissoria";
            this.classbtn.UseVisualStyleBackColor = true;
            this.classbtn.Click += new System.EventHandler(this.classbtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Nuovo Turno";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1119, 463);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Pulisci Classifica";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Listagioc
            // 
            this.Listagioc.HideSelection = false;
            this.Listagioc.Location = new System.Drawing.Point(455, 121);
            this.Listagioc.Name = "Listagioc";
            this.Listagioc.Size = new System.Drawing.Size(198, 395);
            this.Listagioc.TabIndex = 18;
            this.Listagioc.UseCompatibleStateImageBehavior = false;
            this.Listagioc.View = System.Windows.Forms.View.List;
            this.Listagioc.SelectedIndexChanged += new System.EventHandler(this.Listagioc_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Lista Giocatori Iscritti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(853, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tabellone ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1180, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Classifica";
            // 
            // endbtn
            // 
            this.endbtn.Location = new System.Drawing.Point(94, 525);
            this.endbtn.Name = "endbtn";
            this.endbtn.Size = new System.Drawing.Size(184, 23);
            this.endbtn.TabIndex = 22;
            this.endbtn.Text = "Fine Torneo";
            this.endbtn.UseVisualStyleBackColor = true;
            this.endbtn.Click += new System.EventHandler(this.endbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1856, 656);
            this.Controls.Add(this.endbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Listagioc);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.classbtn);
            this.Controls.Add(this.losebtn);
            this.Controls.Add(this.drawbtn);
            this.Controls.Add(this.Classifica);
            this.Controls.Add(this.winbutton);
            this.Controls.Add(this.start);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.cognome1);
            this.Controls.Add(this.id1);
            this.Controls.Add(this.nome1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nome1;
        private System.Windows.Forms.TextBox id1;
        private System.Windows.Forms.TextBox cognome1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader gioccont;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button winbutton;
        private System.Windows.Forms.ListView Classifica;
        private System.Windows.Forms.Button drawbtn;
        private System.Windows.Forms.Button losebtn;
        private System.Windows.Forms.Button classbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView Listagioc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button endbtn;
    }
}


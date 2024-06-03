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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
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
            this.SuspendLayout();
            // 
            // nome1
            // 
            this.nome1.Location = new System.Drawing.Point(251, 95);
            this.nome1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nome1.Name = "nome1";
            this.nome1.Size = new System.Drawing.Size(132, 22);
            this.nome1.TabIndex = 0;
            // 
            // id1
            // 
            this.id1.Location = new System.Drawing.Point(255, 239);
            this.id1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(132, 22);
            this.id1.TabIndex = 1;
            // 
            // cognome1
            // 
            this.cognome1.Location = new System.Drawing.Point(251, 164);
            this.cognome1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cognome1.Name = "cognome1";
            this.cognome1.Size = new System.Drawing.Size(132, 22);
            this.cognome1.TabIndex = 2;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(16, 92);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(424, 55);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(404, 405);
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
            this.label1.Location = new System.Drawing.Point(251, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cognome";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 146);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Rimuovi Giocatore";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(16, 239);
            this.start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(197, 28);
            this.start.TabIndex = 10;
            this.start.Text = "Inizio Torneo";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // winbutton
            // 
            this.winbutton.Location = new System.Drawing.Point(101, 348);
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
            this.Classifica.Location = new System.Drawing.Point(949, 71);
            this.Classifica.Name = "Classifica";
            this.Classifica.Size = new System.Drawing.Size(236, 317);
            this.Classifica.TabIndex = 12;
            this.Classifica.UseCompatibleStateImageBehavior = false;
            this.Classifica.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1856, 656);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}


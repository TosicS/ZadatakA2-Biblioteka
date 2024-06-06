namespace ZadatakA2_Biblioteka
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBrisanje = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAnaliza = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOAplikaciji = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonIzlaz = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSifra = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRodjen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(55, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBrisanje,
            this.toolStripButtonAnaliza,
            this.toolStripButtonOAplikaciji,
            this.toolStripButtonIzlaz});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 72);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonBrisanje
            // 
            this.toolStripButtonBrisanje.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBrisanje.Image")));
            this.toolStripButtonBrisanje.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBrisanje.Name = "toolStripButtonBrisanje";
            this.toolStripButtonBrisanje.Size = new System.Drawing.Size(59, 69);
            this.toolStripButtonBrisanje.Text = "Brisanje";
            this.toolStripButtonBrisanje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonBrisanje.Click += new System.EventHandler(this.toolStripButtonBrisanje_Click);
            // 
            // toolStripButtonAnaliza
            // 
            this.toolStripButtonAnaliza.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAnaliza.Image")));
            this.toolStripButtonAnaliza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAnaliza.Name = "toolStripButtonAnaliza";
            this.toolStripButtonAnaliza.Size = new System.Drawing.Size(59, 69);
            this.toolStripButtonAnaliza.Text = "Analiza";
            this.toolStripButtonAnaliza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonAnaliza.Click += new System.EventHandler(this.toolStripButtonAnaliza_Click);
            // 
            // toolStripButtonOAplikaciji
            // 
            this.toolStripButtonOAplikaciji.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOAplikaciji.Image")));
            this.toolStripButtonOAplikaciji.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOAplikaciji.Name = "toolStripButtonOAplikaciji";
            this.toolStripButtonOAplikaciji.Size = new System.Drawing.Size(69, 69);
            this.toolStripButtonOAplikaciji.Text = "O aplikaciji";
            this.toolStripButtonOAplikaciji.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonOAplikaciji.Click += new System.EventHandler(this.toolStripButtonOAplikaciji_Click);
            // 
            // toolStripButtonIzlaz
            // 
            this.toolStripButtonIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIzlaz.Image")));
            this.toolStripButtonIzlaz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIzlaz.Name = "toolStripButtonIzlaz";
            this.toolStripButtonIzlaz.Size = new System.Drawing.Size(59, 69);
            this.toolStripButtonIzlaz.Text = "Izlaz";
            this.toolStripButtonIzlaz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonIzlaz.Click += new System.EventHandler(this.toolStripButtonIzlaz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sifra";
            // 
            // textBoxSifra
            // 
            this.textBoxSifra.Location = new System.Drawing.Point(98, 102);
            this.textBoxSifra.Name = "textBoxSifra";
            this.textBoxSifra.Size = new System.Drawing.Size(100, 20);
            this.textBoxSifra.TabIndex = 2;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(98, 152);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(100, 20);
            this.textBoxIme.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ime";
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(98, 207);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrezime.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prezime";
            // 
            // textBoxRodjen
            // 
            this.textBoxRodjen.Location = new System.Drawing.Point(98, 258);
            this.textBoxRodjen.Name = "textBoxRodjen";
            this.textBoxRodjen.Size = new System.Drawing.Size(100, 20);
            this.textBoxRodjen.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rodjen";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(318, 102);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(443, 286);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sifra";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Datum rodjenja";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBoxRodjen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSifra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonBrisanje;
        private System.Windows.Forms.ToolStripButton toolStripButtonAnaliza;
        private System.Windows.Forms.ToolStripButton toolStripButtonOAplikaciji;
        private System.Windows.Forms.ToolStripButton toolStripButtonIzlaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSifra;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRodjen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}



namespace esercizio_classi
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
            this.input_titolo = new System.Windows.Forms.TextBox();
            this.input_autore = new System.Windows.Forms.TextBox();
            this.input_genere = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.input_search = new System.Windows.Forms.ComboBox();
            this.Autore = new System.Windows.Forms.RadioButton();
            this.Genere = new System.Windows.Forms.RadioButton();
            this.Anno = new System.Windows.Forms.RadioButton();
            this.find_Button = new System.Windows.Forms.Button();
            this.Ano = new System.Windows.Forms.Label();
            this.input_anno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.input_pagine = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input_titolo
            // 
            this.input_titolo.Location = new System.Drawing.Point(48, 40);
            this.input_titolo.Name = "input_titolo";
            this.input_titolo.Size = new System.Drawing.Size(100, 20);
            this.input_titolo.TabIndex = 0;
            // 
            // input_autore
            // 
            this.input_autore.Location = new System.Drawing.Point(179, 40);
            this.input_autore.Name = "input_autore";
            this.input_autore.Size = new System.Drawing.Size(100, 20);
            this.input_autore.TabIndex = 1;
            // 
            // input_genere
            // 
            this.input_genere.FormattingEnabled = true;
            this.input_genere.Location = new System.Drawing.Point(557, 42);
            this.input_genere.Name = "input_genere";
            this.input_genere.Size = new System.Drawing.Size(121, 21);
            this.input_genere.TabIndex = 2;
            this.input_genere.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(751, 40);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(27, 23);
            this.add.TabIndex = 3;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(48, 115);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(697, 95);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titolo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Autore";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search By";
            // 
            // input_search
            // 
            this.input_search.FormattingEnabled = true;
            this.input_search.Location = new System.Drawing.Point(142, 273);
            this.input_search.Name = "input_search";
            this.input_search.Size = new System.Drawing.Size(121, 21);
            this.input_search.TabIndex = 8;
            // 
            // Autore
            // 
            this.Autore.AutoSize = true;
            this.Autore.Location = new System.Drawing.Point(48, 303);
            this.Autore.Name = "Autore";
            this.Autore.Size = new System.Drawing.Size(56, 17);
            this.Autore.TabIndex = 9;
            this.Autore.TabStop = true;
            this.Autore.Text = "Autore";
            this.Autore.UseVisualStyleBackColor = true;
            // 
            // Genere
            // 
            this.Genere.AutoSize = true;
            this.Genere.Location = new System.Drawing.Point(48, 326);
            this.Genere.Name = "Genere";
            this.Genere.Size = new System.Drawing.Size(60, 17);
            this.Genere.TabIndex = 10;
            this.Genere.TabStop = true;
            this.Genere.Text = "Genere";
            this.Genere.UseVisualStyleBackColor = true;
            // 
            // Anno
            // 
            this.Anno.AutoSize = true;
            this.Anno.Location = new System.Drawing.Point(48, 349);
            this.Anno.Name = "Anno";
            this.Anno.Size = new System.Drawing.Size(50, 17);
            this.Anno.TabIndex = 11;
            this.Anno.TabStop = true;
            this.Anno.Text = "Anno";
            this.Anno.UseVisualStyleBackColor = true;
            // 
            // find_Button
            // 
            this.find_Button.Location = new System.Drawing.Point(48, 388);
            this.find_Button.Name = "find_Button";
            this.find_Button.Size = new System.Drawing.Size(34, 23);
            this.find_Button.TabIndex = 13;
            this.find_Button.Text = "find";
            this.find_Button.UseVisualStyleBackColor = true;
            // 
            // Ano
            // 
            this.Ano.AutoSize = true;
            this.Ano.Location = new System.Drawing.Point(294, 24);
            this.Ano.Name = "Ano";
            this.Ano.Size = new System.Drawing.Size(32, 13);
            this.Ano.TabIndex = 15;
            this.Ano.Text = "Anno";
            // 
            // input_anno
            // 
            this.input_anno.Location = new System.Drawing.Point(297, 40);
            this.input_anno.Name = "input_anno";
            this.input_anno.Size = new System.Drawing.Size(100, 20);
            this.input_anno.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Genere";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(741, 415);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(47, 23);
            this.close.TabIndex = 17;
            this.close.Text = "close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "N.pagine";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // input_pagine
            // 
            this.input_pagine.Location = new System.Drawing.Point(418, 40);
            this.input_pagine.Name = "input_pagine";
            this.input_pagine.Size = new System.Drawing.Size(100, 20);
            this.input_pagine.TabIndex = 18;
            this.input_pagine.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.input_pagine);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Ano);
            this.Controls.Add(this.input_anno);
            this.Controls.Add(this.find_Button);
            this.Controls.Add(this.Anno);
            this.Controls.Add(this.Genere);
            this.Controls.Add(this.Autore);
            this.Controls.Add(this.input_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.input_genere);
            this.Controls.Add(this.input_autore);
            this.Controls.Add(this.input_titolo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_titolo;
        private System.Windows.Forms.TextBox input_autore;
        private System.Windows.Forms.ComboBox input_genere;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox input_search;
        private System.Windows.Forms.RadioButton Autore;
        private System.Windows.Forms.RadioButton Genere;
        private System.Windows.Forms.RadioButton Anno;
        private System.Windows.Forms.Button find_Button;
        private System.Windows.Forms.Label Ano;
        private System.Windows.Forms.TextBox input_anno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox input_pagine;
    }
}


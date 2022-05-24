using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esercizio_classi
{
    public partial class Form1 : Form
    {
        private List<Libro> biblio;
        public Form1()
        {
            InitializeComponent();
            biblio = new List<Libro>();
            input_genere.Items.Add("Romantico");
            input_genere.Items.Add("Giallo");
            input_genere.Items.Add("Saggio");
            input_genere.Items.Add("Avventura");
            input_genere.Items.Add("Fanatasy");



        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(input_autore.Text)&&string.IsNullOrEmpty(input_pagine.Text)&& string.IsNullOrEmpty(input_titolo.Text)&& string.IsNullOrEmpty(input_anno.Text)&&
                string.IsNullOrEmpty(input_genere.Text))
            {
                MessageBox.Show("Inserisci i dati perfavore");
            }
            else
            {
                string au = input_autore.Text;
                int np = int.Parse(input_pagine.Text);
                string ti = input_titolo.Text;
                int aa = int.Parse(input_anno.Text);
                string ge = input_genere.Text;


                Libro libro = new Libro(ti, au, aa, np, ge);
                string msg = libro.Description();
                listBox1.Items.Add(libro.Description());


            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

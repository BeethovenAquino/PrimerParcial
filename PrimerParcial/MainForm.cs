﻿using PrimerParcial.UI.Consulta;
using PrimerParcial.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimerParcial
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro n = new Registro();
            n.Show();

        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta c = new Consulta();
            c.Show();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2LAB2
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Mostrar_Click(object sender, EventArgs e)
        {

        }

        private void bt_Limpiar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}

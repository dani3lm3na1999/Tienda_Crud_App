﻿using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MnRegistroVenta_Click(object sender, EventArgs e)
        {
            RegistroVenta objRegistro = new RegistroVenta();
            objRegistro.ShowDialog();
        }

        private void MnMttProductos_Click(object sender, EventArgs e)
        {
            MantenimientoProductos objMttProductos = new MantenimientoProductos();
            objMttProductos.ShowDialog();
        }

        private void MnReporteVentas_Click(object sender, EventArgs e)
        {

        }
    }
}

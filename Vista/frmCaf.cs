using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;

namespace Vista
{
    public partial class frmCaf : Form
    {
        CafModel caf;
        public frmCaf()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.FileName.ToString();
            this.caf = new CafModel().xmlToCaf(openFileDialog1.FileName.ToString());
            labelRutEmpresa.Text   =  caf.rutEmpresa;
            labelFchCaf.Text = caf.fecha.ToString("yyyy-MM-dd");
            labelFolioIni.Text = caf.folioInicial.ToString();
            labelFolioFinal.Text = caf.folioFinal.ToString();
            labelTipoDte.Text = caf.tipote;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void frmCaf_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmFolio(this).ShowDialog();
        }
    }
}

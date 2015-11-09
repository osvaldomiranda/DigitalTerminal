using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmFolio : Form
    {
        frmCaf frmcaf;
        public frmFolio()
        {
            InitializeComponent();
        }
        public frmFolio(frmCaf frmcaf)
        {
            InitializeComponent();
            this.frmcaf = frmcaf;
        }



        private void agregaFolios(int inicial, int final)
        {
            while(inicial < final+1)
            {
                Console.WriteLine(inicial);

                // insert tabla folio
                inicial = inicial+1;
            }

            //insert tabla caf
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            int inicial = Convert.ToInt32(frmcaf.labelFolioIni.Text);
            int final = Convert.ToInt32(frmcaf.labelFolioFinal.Text);
            agregaFolios(inicial, final);

        }
    }
}

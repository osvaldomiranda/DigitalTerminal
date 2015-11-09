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
    public partial class frmTipoTraslado : Form
    {
        DocumentoModel doc = new DocumentoModel();
        string tipoTraslado = string.Empty;
        string tipoDespacho = string.Empty;

        public frmTipoTraslado(DocumentoModel doc)
        {
            InitializeComponent();
            this.doc = doc;
        }

        public frmTipoTraslado()
        {
            InitializeComponent();
            
        }
        private void frmTipoTraslado_Load(object sender, EventArgs e)
        {
            comboBoxIndTraslado.Items.Add("1 - CONSTITUYE VENTA");
            comboBoxIndTraslado.Items.Add("2 - VENTA POR EFECTUAR");
            comboBoxIndTraslado.Items.Add("3 - CONSIGNACIONES");
            comboBoxIndTraslado.Items.Add("4 - ENTREGA GRATUITA");
            comboBoxIndTraslado.Items.Add("5 - TRASLADO INTERNO");
            comboBoxIndTraslado.Items.Add("6 - OTRO TRASLADO NO VENTA");
            comboBoxIndTraslado.Items.Add("7 - GUIA DEVOLUCION");
            comboBoxIndTraslado.Items.Add("8 - TRASLADO PARA EXPORTACIÓN.");
            comboBoxIndTraslado.Items.Add("9 - VENTA EXPORTACIÓN");
            comboBoxTipoDespacho.Items.Add("1 - RECEPTOR");
            comboBoxTipoDespacho.Items.Add("2 - EMISOR A INSTALACIONES DEL CLIENTE");
            comboBoxTipoDespacho.Items.Add("3 - EMISOR A OTRAS INSTALACIONES");
            comboBoxIndTraslado.Select();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxIndTraslado_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoTraslado = (comboBoxIndTraslado.SelectedIndex + 1).ToString();
        }



        private void comboBoxTipoDespacho_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoDespacho = (comboBoxTipoDespacho.SelectedIndex + 1).ToString();

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            doc.IndTraslado = Convert.ToInt32(tipoTraslado);
            if (tipoDespacho == "")
            {
                tipoDespacho = "0";
            }
            doc.TipoDespacho = Convert.ToInt32(tipoDespacho);
            this.Close();
        }
    }
}

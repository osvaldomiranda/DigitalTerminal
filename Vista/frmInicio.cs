using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;
using System.Globalization;

namespace Vista
{
    public partial class frmInicio : Form
    {
        DataTable dataTable = new DataTable();
        String nombreDoc = String.Empty;
        public frmInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            this.btnPedidos.Select();
            //DataRow fila = new DataRow();
            //this.dataGridView1.DataSource = new DocumentoModel().getAllDocDT();
            dataTable = new DocumentoModel().getAllDocDT();
            foreach (DataRow fila in dataTable.Rows)
            {
               Int32 n = this.dataGridView1.Rows.Add();
               dataGridView1.Rows[n].Cells[0].Value  = fila["nombre"].ToString();
               dataGridView1.Rows[n].Cells[1].Value = fila["TipoDTE"].ToString(); 
               dataGridView1.Rows[n].Cells[2].Value = fila["Folio"].ToString(); 
               dataGridView1.Rows[n].Cells[3].Value = fila["FchEmis"].ToString();
               dataGridView1.Rows[n].Cells[4].Value = fila["RznSocRecep"].ToString();
               dataGridView1.Rows[n].Cells[5].Value = fila["MntTotal"].ToString();
               dataGridView1.Rows[n].Cells[6].Value = "    VER    ";

            }

        }



        private void btnSalir_Click(object sender, EventArgs e)
        {

            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }


        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmPaises().ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            new frmPuntoVenta().ShowDialog();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            new frmArchivosMaestros().ShowDialog();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            new DocumentoModel().getDocumento(33, 1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["abrir"].Index && e.RowIndex >= 0)
            {
                String tipoDte = dataGridView1.Rows[e.RowIndex].Cells["Tipo_Dte"].Value.ToString();
                String folio = dataGridView1.Rows[e.RowIndex].Cells["Folio"].Value.ToString();
                nombreDoc = dataGridView1.Rows[e.RowIndex].Cells["Documento"].Value.ToString(); 
                getDoc(Convert.ToInt32(tipoDte),Convert.ToInt32(folio));
            }
        }

        public void getDoc(int tipo, int folio)
        {
            DocumentoModel documento = new DocumentoModel();
            documento = documento.getDocumento(tipo, folio);
            frmPuntoVenta pos = new frmPuntoVenta(documento);
            pos.textBoxRutRecep.Text = documento.RUTRecep;
            pos.textBoxRutRecep.Enabled = false;
            pos.labelRznSocRecep.Text = documento.RznSocRecep;
            pos.labelGiroRecep.Text = documento.GiroRecep;
            pos.labelTelefonoRecep.Text = documento.TelRecep;
            pos.labelDireccionRecep.Text = documento.DirRecep;
            pos.labelCiudadRecep.Text = documento.CiudadRecep;
            pos.labelComunaRecep.Text = documento.CmnaRecep;
            pos.lblNomForm.Text = nombreDoc;

            // Cargo Detalle
            foreach(Detalle detalle in documento.detalle)
            {
                Int32 n = pos.dtgwDetalle.Rows.Add();
               pos.dtgwDetalle.Rows[n].Cells["elimina"].Value = "-";             
               pos.dtgwDetalle.Rows[n].Cells["item"].Value = n + 1;
               pos.dtgwDetalle.Rows[n].Cells["codigo"].Value = detalle.VlrCodigo;
               pos.dtgwDetalle.Rows[n].Cells["nombre"].Value = detalle.NmbItem; 
               pos.dtgwDetalle.Rows[n].Cells["Precio_Neto"].Value = Decimal.Round(detalle.PrcItem);
               pos.dtgwDetalle.Rows[n].Cells["precio"].Value = detalle.PrcBruItem.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
               pos.dtgwDetalle.Rows[n].Cells["cantidad"].Value = detalle.QtyItem;
               pos.dtgwDetalle.Rows[n].Cells["desc"].Value = detalle.DescuentoPct;
               pos.dtgwDetalle.Rows[n].Cells["Monto_Descuento"].Value = detalle.DescuentoMonto.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
               pos.dtgwDetalle.Rows[n].Cells["Total_Neto"].Value = detalle.MontoItem.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
               pos.dtgwDetalle.Rows[n].Cells["total"].Value = detalle.MontoBruItem.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
               if(detalle.IndExe == "1")
               {
                   pos.dtgwDetalle.Rows[n].Cells["exento"].Value = "True";
               }
               else
               {
                   pos.dtgwDetalle.Rows[n].Cells["exento"].Value = "False";
               }


            }
            // Cargo Totales
            //pos.textBoxDctoGlobal.Text = documento.dscRcgGlobal; // TODO
            pos.labelSubTotal.Text = documento.MntNeto.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
            pos.labelMtoExento.Text = documento.MntExe.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
            pos.labelIva.Text = documento.IVA.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
            //pos.labelImpAdic.Text = documento.imptoReten; // TODO
            pos.labelMtoTotal.Text = documento.MntTotal.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
            //Cargo las referencias

            pos.ShowDialog();
           
        }
    }
}

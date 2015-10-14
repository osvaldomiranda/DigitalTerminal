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
    public partial class frmPuntoVenta : Form
    {
        int n = 0;
        ContribuyenteModel cliente= new ContribuyenteModel();
        DataTable dataTableCliente = new DataTable();
        DocumentoModel documento = new DocumentoModel();
        Detalle detalle = new Detalle();
        ReferenciaDoc referencia = new ReferenciaDoc();
        folioModel folio = new folioModel();
        
        public frmPuntoVenta()
        {
            InitializeComponent();
            
        }


        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            new frmBuscaCliente(this).ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscaProducto_Click(object sender, EventArgs e)
        {
            new frmBuscaProductos(this).ShowDialog();
           
        }

        public DataGridView getDGVDetalle()
        {
            return this.dtgwDetalle;
        }


        private void frmPuntoVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {

                MessageBox.Show("F1");
            }
            if (e.KeyData == Keys.F7)
            {
                new frmBuscaProductos(this).ShowDialog();             
            }

            if (e.KeyData == Keys.F9)
            {
                MessageBox.Show("Agrega cliente");
            }
        }

        private void btnGeneraDoc_Click(object sender, EventArgs e)
        {
            new frmSelecVenta().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
        private void button4_Click(object sender, EventArgs e)
        {
            this.textBoxCodBarra.Select();
            frmBuscaProductos frmbuscaprod = new frmBuscaProductos(this);
            frmbuscaprod.ShowDialog();
        }

     public void frmPuntoVenta_Load(object sender, EventArgs e)
        {
            this.textBoxRutRecep.Select();
        }



     private void dtgwDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
     {
         try
         {
            
            decimal num1 = Convert.ToDecimal(this.dtgwDetalle.CurrentRow.Cells["precio"].Value);
            int num2 = Convert.ToInt32(this.dtgwDetalle.CurrentRow.Cells["cantidad"].Value) ;
            this.dtgwDetalle.CurrentRow.Cells["total"].Value = num1 * num2;
         }
             
         catch (Exception ex)
         {
             Console.WriteLine("" + ex);
         }
     }

     public void textBoxRut_KeyPress(object sender, KeyPressEventArgs e)
     {
         if (e.KeyChar == (int)13)
         {
             if (textBoxRutRecep.Text != "")
             {
                 dataTableCliente = cliente.getContribuyente(textBoxRutRecep.Text);
                 if (dataTableCliente.Rows.Count != 0)
                 {
                     labelRznSocRecep.Text = dataTableCliente.Rows[0][1].ToString();
                     labelGiroRecep.Text = dataTableCliente.Rows[0][2].ToString();
                     labelDireccionRecep.Text = dataTableCliente.Rows[0][3].ToString();
                     labelCiudadRecep.Text = dataTableCliente.Rows[0][8].ToString();
                     labelComunaRecep.Text = dataTableCliente.Rows[0][11].ToString();              
                     labelTelefonoRecep.Text = dataTableCliente.Rows[0][6].ToString();
                     textBoxRutRecep.Enabled = false;
                     textBoxCodBarra.Select();
                 }
                 else
                 {
                     MessageBox.Show("No esta Registrado el cliente");
                     textBoxRutRecep.Text = "";
                     // TODO verificar rut
                 }
             }
         }

}

     private void textBoxRut_KeyDown(object sender, KeyEventArgs e)
     {

     }

     private void textBoxRut_Validated(object sender, EventArgs e)
     {
         textBoxRutRecep.Text = new MetodosComunes().formatearRut(textBoxRutRecep.Text.ToUpper());
     }


     private void buttonBuscaCliente_Click(object sender, EventArgs e)
     {
         textBoxCodBarra.Select();
         new frmBuscaCliente(this).ShowDialog(); 
    
     }

     private void textBoxRut_TextChanged(object sender, EventArgs e)
     {

     }


     public void AddProducto(ProductosModel producto, Detalle detalle)
     {
         n = this.dtgwDetalle.Rows.Add();
         this.dtgwDetalle.Rows[n].Cells[0].Value = "-";
         this.dtgwDetalle.Rows[n].Cells[1].Value =  n + 1;
         this.dtgwDetalle.Rows[n].Cells[2].Value =  producto.codigoInt.ToString(); 
         this.dtgwDetalle.Rows[n].Cells[3].Value =  producto.nombre.ToString();
         this.dtgwDetalle.Rows[n].Cells[4].Value =  producto.precioNeto.ToString();
         this.dtgwDetalle.Rows[n].Cells[5].Value =  producto.precioventa.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
         this.dtgwDetalle.Rows[n].Cells[6].Value =  detalle.QtyItem.ToString();
         this.dtgwDetalle.Rows[n].Cells[7].Value =  Decimal.Round(detalle.DescuentoPct*100);
         this.dtgwDetalle.Rows[n].Cells[8].Value = detalle.DescuentoMonto.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
         this.dtgwDetalle.Rows[n].Cells[9].Value =  detalle.MontoItem.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
         this.dtgwDetalle.Rows[n].Cells[10].Value = detalle.MontoBruItem.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
         actualizaTotal();
     }

     private void dtgwDetalle_Validated(object sender, EventArgs e)
     {
         //actualizaTotal();
     }

     private void actualizaTotal()
     {
         Decimal suma = 0;
         for (int i = 0; i < dtgwDetalle.RowCount; i++)
         {
             suma += Convert.ToDecimal(this.dtgwDetalle.Rows[i].Cells[10].Value.ToString().Replace(".",""));
         }
         labelMtoTotal.Text = suma.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
         calculaIva();
     }

        private void calculaIva()
        {
            string total = labelMtoTotal.Text.Replace(".", "");
            labelSubTotal.Text = (Convert.ToDecimal(total) / Convert.ToDecimal(1.19)).ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
            labelIva.Text = (Convert.ToInt32(total) - Convert.ToInt32(labelSubTotal.Text.Replace(".", ""))).ToString("N0", CultureInfo.CreateSpecificCulture("es-ES")); 
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                documento.serialize(cargaDocumento());
                documento.save(documento);
                detalle.save(documento);
                referencia.save(documento);
                folio.modificaEstado("JSON CREADO", documento.Folio);
                MessageBox.Show("El Documento se guardo");
               

            }
            catch(Exception err)
            {
                MessageBox.Show("" + err);
            }
        }


        private DocumentoModel cargaDocumento()
        {

            try
            {
                EmpresaModel empresa = new EmpresaModel();
                empresa.getEmpresa();

                documento.TipoDTE = 33; // cod pedido TODO
                documento.Folio = folio.getUltimoFolio();
                // Cargo Datos Emisor
                documento.RUTEmisor = empresa.Rut;
                documento.RznSoc = empresa.RazonSocial;
                documento.GiroEmis = empresa.GiroEmisor;
                documento.CdgSIISucur = empresa.CodigoSiiSucursal;
                documento.Telefono = empresa.Telefono;
                documento.CorreoEmisor = empresa.Correo;
                documento.Acteco = empresa.Acteco;
                documento.DirOrigen = empresa.DireccionOrigen;
                documento.CmnaOrigen = empresa.ComunaOrigen;
                documento.CiudadOrigen = empresa.CiudadOrigen;
                // Datos Receptor
                documento.RUTRecep = this.textBoxRutRecep.Text;
                documento.RznSocRecep = this.labelRznSocRecep.Text;
                documento.GiroRecep = this.labelGiroRecep.Text;
                documento.DirRecep = this.labelDireccionRecep.Text;
                documento.CmnaRecep = this.labelComunaRecep.Text;
                documento.CiudadRecep = this.labelCiudadRecep.Text;
                documento.TelRecep = this.labelTelefonoRecep.Text;
                documento.FchEmis = DateTime.Today.ToString("yyyy-MM-dd");  
                List<Detalle> detalles = new List<Detalle>();
                //cargo detalle doc
                for (int i = 0; i < dtgwDetalle.RowCount; i++)
                {
                    Detalle detalle = new Detalle();
                    detalle.NroLinDet = Convert.ToInt32(this.dtgwDetalle.Rows[i].Cells[1].Value);
                    detalle.TpoCodigo = "PLU";
                    detalle.VlrCodigo = this.dtgwDetalle.Rows[i].Cells[2].Value.ToString();
                    detalle.NmbItem = this.dtgwDetalle.Rows[i].Cells[3].Value.ToString();
                    detalle.PrcItem = Convert.ToDecimal(this.dtgwDetalle.Rows[i].Cells[4].Value.ToString());
                    detalle.PrcBruItem = Convert.ToDecimal(this.dtgwDetalle.Rows[i].Cells[5].Value.ToString().Replace(".", ""));
                    detalle.QtyItem = Convert.ToInt32(this.dtgwDetalle.Rows[i].Cells[6].Value);
                    detalle.DescuentoPct = Convert.ToInt32(this.dtgwDetalle.Rows[i].Cells[7].Value);
                    detalle.DescuentoMonto = Convert.ToInt32(this.dtgwDetalle.Rows[i].Cells[8].Value.ToString().Replace(".", ""));
                    detalle.MontoItem = Convert.ToInt32(this.dtgwDetalle.Rows[i].Cells[9].Value.ToString().Replace(".",""));
                    detalle.MontoBruItem = Convert.ToInt32(this.dtgwDetalle.Rows[i].Cells[10].Value.ToString().Replace(".", ""));
                    detalles.Add(detalle);
                }
                //Cargo los descuentos globales
                List<DscRcgGlobal> descuentosGlobales = new List<DscRcgGlobal>();
                DscRcgGlobal descuentoGlobal = new DscRcgGlobal();
                descuentoGlobal.NroLinDR = 0;
                descuentoGlobal.TpoMov = "";
                descuentoGlobal.GlosaDR = "";
                descuentoGlobal.TpoValor = "";
                descuentoGlobal.ValorDR = 0;
                descuentoGlobal.IndExeDR = Convert.ToInt32(labelDctoGlobal.Text);
                descuentosGlobales.Add(descuentoGlobal);
                documento.detalle = detalles;
                documento.TasaIVA = 19;
                documento.dscRcgGlobal = descuentosGlobales;
                documento.MntNeto = Convert.ToInt32(labelSubTotal.Text.ToString().Replace(".", ""));
                documento.IVA = Convert.ToInt32(labelIva.Text.ToString().Replace(".", ""));
                documento.MntTotal = Convert.ToInt32(labelMtoTotal.Text.ToString().Replace(".", ""));
                return documento;
            }
            catch(Exception e)
            {
                return documento;
            }
        }

        private void buttonReferencia_Click(object sender, EventArgs e)
        {
            new frmReferencia(documento).ShowDialog();
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {

        }



    }
}

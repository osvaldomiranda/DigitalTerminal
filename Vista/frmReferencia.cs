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
    public partial class frmReferencia : Form
    {
        DocumentoModel doc;
        List<ReferenciaDoc> referencias = new List<ReferenciaDoc>();

        public frmReferencia(DocumentoModel documento)
        {
            InitializeComponent();
            doc = documento;
        }

        private void frmReferencia_Load(object sender, EventArgs e)
        {
            comboBoxTipoDte.ValueMember = "tipo";
            comboBoxTipoDte.DisplayMember = "nombre";
            comboBoxTipoDte.DataSource = new TipoDteModel().getTipoDte();
            comboBoxCodRef.Items.Add("Anula Documento de Referencia");
            comboBoxCodRef.Items.Add("Corrige Texto Documento");
            comboBoxCodRef.Items.Add("Corrige Monto Documento");

            foreach (ReferenciaDoc referencia in doc.Referencia)
            {
                Int32 n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["Elimina"].Value = " - ";
                if (referencia.TpoDocRef == "SET")
                {
                    dataGridView1.Rows[n].Cells["Cod_Tipo"].Value = "1000";
                    dataGridView1.Rows[n].Cells["Documento"].Value = "SET";
                }
                else
                {
                    dataGridView1.Rows[n].Cells["Cod_Tipo"].Value = referencia.TpoDocRef;
                    dataGridView1.Rows[n].Cells["Documento"].Value = new TipoDteModel().getNombre(referencia.TpoDocRef);
                }
                dataGridView1.Rows[n].Cells["Folio"].Value = referencia.FolioRef;
                dataGridView1.Rows[n].Cells["Fecha"].Value = referencia.FchRef;
                dataGridView1.Rows[n].Cells["Razon_Ref"].Value = referencia.RazonRef;  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxFolio.Text != "" && textBoxRazRef.Text != "")
            {

                dataGridView1.Rows.Add(" - " ,labelIdDocRef.Text,comboBoxTipoDte.Text,textBoxFolio.Text,dateTimePicker1.Value.ToString("yyyy-MM-dd"),textBoxRazRef.Text.ToUpper());

            }
        }

        private void comboBoxTipoDte_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelIdDocRef.Text = comboBoxTipoDte.SelectedValue.ToString();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            cargaReferencia();
            this.Close();

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
                cargaReferencia();
                this.Close();
            
        }

        private void comboBoxCodRef_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelCodRef.Text = (comboBoxCodRef.SelectedIndex + 1).ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Elimina"].Index && e.RowIndex >= 0)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void cargaReferencia()
        {
            string codTipo = (String)this.dataGridView1.CurrentRow.Cells["Cod_Tipo"].Value;
            if (dataGridView1.Rows.Count != 0)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    ReferenciaDoc referencia = new ReferenciaDoc();
                    if (codTipo == "1000")
                    {
                        referencia.NroLinRef = i + 1;
                        referencia.TpoDocRef = "SET";
                        referencia.RazonRef = this.dataGridView1.Rows[i].Cells["Razon_Ref"].Value.ToString();
                        referencia.FolioRef = "0";
                        referencia.FchRef = this.dataGridView1.Rows[i].Cells["Fecha"].Value.ToString();
                    }
                    else
                    {
                        referencia.NroLinRef = i + 1;
                        referencia.TpoDocRef = this.dataGridView1.Rows[i].Cells["Cod_Tipo"].Value.ToString();
                        referencia.FolioRef = this.dataGridView1.Rows[i].Cells["Folio"].Value.ToString();
                        referencia.FchRef = this.dataGridView1.Rows[i].Cells["Fecha"].Value.ToString();
                        referencia.RazonRef = this.dataGridView1.Rows[i].Cells["Razon_Ref"].Value.ToString();
                        referencia.CodRef = Convert.ToInt32(labelCodRef.Text);
                    }
                    referencias.Add(referencia);
                    codTipo = "0";
                }
                doc.Referencia = referencias;
            }

        }
    }
}

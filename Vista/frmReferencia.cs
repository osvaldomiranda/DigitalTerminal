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
        ReferenciaDoc referencia = new ReferenciaDoc();
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxFolio.Text != "" && textBoxRazRef.Text != "")
            {

                dataGridView1.Rows.Add(labelIdDocRef.Text,comboBoxTipoDte.Text,textBoxFolio.Text,dateTimePicker1.Value.ToString("yyyy-MM-dd"),textBoxRazRef.Text.ToUpper());

            }
        }

        private void comboBoxTipoDte_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelIdDocRef.Text = comboBoxTipoDte.SelectedValue.ToString();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {  
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if ((String)this.dataGridView1.CurrentRow.Cells["Cod_Tipo"].Value == "1000")
                    {
                        referencia.NroLinRef = 0;
                        referencia.TpoDocRef = "SET";
                        referencia.RazonRef = (String)this.dataGridView1.CurrentRow.Cells["Razon_Ref"].Value;
                    }
                    else
                    {
                        referencia.NroLinRef = i + 1;
                        referencia.TpoDocRef = (String)this.dataGridView1.CurrentRow.Cells["Cod_Tipo"].Value;
                        referencia.FolioRef = (String)this.dataGridView1.CurrentRow.Cells["Folio"].Value;
                        referencia.FchRef = (String)this.dataGridView1.CurrentRow.Cells["Fecha"].Value;
                        referencia.RazonRef = (String)this.dataGridView1.CurrentRow.Cells["Razon_Ref"].Value;
                        referencia.CodRef = 0; // TODO
                    }

                }

                referencias.Add(referencia);
                doc.Referencia = referencias;
                this.Close();
            }
        }
    }
}

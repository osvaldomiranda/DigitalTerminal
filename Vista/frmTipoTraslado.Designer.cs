namespace Vista
{
    partial class frmTipoTraslado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxTipoDespacho = new System.Windows.Forms.ComboBox();
            this.comboBoxIndTraslado = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.lblNomForm = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNomForm, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(292, 250);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.comboBoxTipoDespacho, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxIndTraslado, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.72131F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.27869F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(286, 114);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // comboBoxTipoDespacho
            // 
            this.comboBoxTipoDespacho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoDespacho.FormattingEnabled = true;
            this.comboBoxTipoDespacho.Location = new System.Drawing.Point(3, 56);
            this.comboBoxTipoDespacho.Name = "comboBoxTipoDespacho";
            this.comboBoxTipoDespacho.Size = new System.Drawing.Size(280, 24);
            this.comboBoxTipoDespacho.TabIndex = 1;
            this.comboBoxTipoDespacho.Text = "SELECCIONE...";
            this.comboBoxTipoDespacho.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoDespacho_SelectedIndexChanged);
            // 
            // comboBoxIndTraslado
            // 
            this.comboBoxIndTraslado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIndTraslado.FormattingEnabled = true;
            this.comboBoxIndTraslado.Location = new System.Drawing.Point(3, 3);
            this.comboBoxIndTraslado.Name = "comboBoxIndTraslado";
            this.comboBoxIndTraslado.Size = new System.Drawing.Size(280, 24);
            this.comboBoxIndTraslado.TabIndex = 0;
            this.comboBoxIndTraslado.Text = "SELECCIONE...";
            this.comboBoxIndTraslado.SelectedIndexChanged += new System.EventHandler(this.comboBoxIndTraslado_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonAceptar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSalir, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 145);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.ForeColor = System.Drawing.Color.Green;
            this.buttonAceptar.Image = global::Vista.Properties.Resources.check_mark_11_32;
            this.buttonAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAceptar.Location = new System.Drawing.Point(103, 18);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(80, 63);
            this.buttonAceptar.TabIndex = 3;
            this.buttonAceptar.Text = "ACEPTAR";
            this.buttonAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.ForeColor = System.Drawing.Color.Green;
            this.buttonSalir.Image = global::Vista.Properties.Resources.exit_32;
            this.buttonSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSalir.Location = new System.Drawing.Point(3, 18);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(80, 63);
            this.buttonSalir.TabIndex = 2;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // lblNomForm
            // 
            this.lblNomForm.AutoSize = true;
            this.lblNomForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNomForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomForm.Location = new System.Drawing.Point(3, 2);
            this.lblNomForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblNomForm.Name = "lblNomForm";
            this.lblNomForm.Size = new System.Drawing.Size(286, 18);
            this.lblNomForm.TabIndex = 15;
            this.lblNomForm.Text = "DESPACHO / TRASLADO";
            this.lblNomForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmTipoTraslado
            // 
            this.AcceptButton = this.buttonAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonSalir;
            this.ClientSize = new System.Drawing.Size(292, 250);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmTipoTraslado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTipoTraslado_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxIndTraslado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox comboBoxTipoDespacho;
        public System.Windows.Forms.Label lblNomForm;
    }
}
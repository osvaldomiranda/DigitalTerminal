namespace Vista
{
    partial class frmClienteProducto
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
            this.lblProductos = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPrcNeto = new System.Windows.Forms.TextBox();
            this.textBoxNomProd = new System.Windows.Forms.TextBox();
            this.labelCodIntProd = new System.Windows.Forms.Label();
            this.labelRznSocCli = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCodIntProd = new System.Windows.Forms.TextBox();
            this.textBoxprcVenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelIdProducto = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblProductos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.25888F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.74112F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(615, 467);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(5, 3);
            this.lblProductos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(605, 18);
            this.lblProductos.TabIndex = 21;
            this.lblProductos.Text = "CLIENTE - PRODUCTO ";
            this.lblProductos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.2816F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.71841F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxPrcNeto, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxNomProd, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelCodIntProd, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelRznSocCli, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxCodIntProd, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxprcVenta, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelIdProducto, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 38);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(607, 153);
            this.tableLayoutPanel2.TabIndex = 22;
            // 
            // textBoxPrcNeto
            // 
            this.textBoxPrcNeto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPrcNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrcNeto.Location = new System.Drawing.Point(122, 93);
            this.textBoxPrcNeto.Name = "textBoxPrcNeto";
            this.textBoxPrcNeto.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrcNeto.TabIndex = 7;
            this.textBoxPrcNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxNomProd
            // 
            this.textBoxNomProd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxNomProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNomProd.Location = new System.Drawing.Point(122, 61);
            this.textBoxNomProd.Name = "textBoxNomProd";
            this.textBoxNomProd.Size = new System.Drawing.Size(283, 20);
            this.textBoxNomProd.TabIndex = 6;
            this.textBoxNomProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNomProd_KeyPress);
            // 
            // labelCodIntProd
            // 
            this.labelCodIntProd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCodIntProd.AutoSize = true;
            this.labelCodIntProd.Location = new System.Drawing.Point(3, 34);
            this.labelCodIntProd.Name = "labelCodIntProd";
            this.labelCodIntProd.Size = new System.Drawing.Size(96, 13);
            this.labelCodIntProd.TabIndex = 2;
            this.labelCodIntProd.Text = "Cod. Int. Producto:";
            // 
            // labelRznSocCli
            // 
            this.labelRznSocCli.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRznSocCli.AutoSize = true;
            this.labelRznSocCli.Location = new System.Drawing.Point(122, 7);
            this.labelRznSocCli.Name = "labelRznSocCli";
            this.labelRznSocCli.Size = new System.Drawing.Size(66, 13);
            this.labelRznSocCli.TabIndex = 1;
            this.labelRznSocCli.Text = "RznSocialCli";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razón Social:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre Producto:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio Neto:";
            // 
            // textBoxCodIntProd
            // 
            this.textBoxCodIntProd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCodIntProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCodIntProd.Location = new System.Drawing.Point(122, 30);
            this.textBoxCodIntProd.Name = "textBoxCodIntProd";
            this.textBoxCodIntProd.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodIntProd.TabIndex = 5;
            this.textBoxCodIntProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodIntProd_KeyPress);
            // 
            // textBoxprcVenta
            // 
            this.textBoxprcVenta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxprcVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxprcVenta.Location = new System.Drawing.Point(122, 125);
            this.textBoxprcVenta.Name = "textBoxprcVenta";
            this.textBoxprcVenta.Size = new System.Drawing.Size(100, 20);
            this.textBoxprcVenta.TabIndex = 9;
            this.textBoxprcVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Precio Venta:";
            // 
            // labelIdProducto
            // 
            this.labelIdProducto.AutoSize = true;
            this.labelIdProducto.Location = new System.Drawing.Point(514, 0);
            this.labelIdProducto.Name = "labelIdProducto";
            this.labelIdProducto.Size = new System.Drawing.Size(58, 13);
            this.labelIdProducto.TabIndex = 10;
            this.labelIdProducto.Text = "idProducto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(4, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(607, 150);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutPanel3.Controls.Add(this.btnSalir, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSave, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 372);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(371, 74);
            this.tableLayoutPanel3.TabIndex = 24;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Green;
            this.btnSalir.Image = global::Vista.Properties.Resources.exit_32;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(3, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 63);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Image = global::Vista.Properties.Resources.save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(91, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 63);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "GUARDAR";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmClienteProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 496);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmClienteProducto";
            this.Text = "frmClienteProducto";
            this.Load += new System.EventHandler(this.frmClienteProducto_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxPrcNeto;
        private System.Windows.Forms.TextBox textBoxNomProd;
        private System.Windows.Forms.Label labelCodIntProd;
        private System.Windows.Forms.Label labelRznSocCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCodIntProd;
        private System.Windows.Forms.TextBox textBoxprcVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelIdProducto;
    }
}
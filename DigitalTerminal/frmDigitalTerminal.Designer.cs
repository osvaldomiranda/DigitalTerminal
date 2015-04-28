namespace DigitalTerminal
{
    partial class frmDigitalTerminal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblpDigitalTerminal = new System.Windows.Forms.TableLayoutPanel();
            this.dtgwDigitalTerminal = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tblpDigitalTerminal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwDigitalTerminal)).BeginInit();
            this.SuspendLayout();
            // 
            // tblpDigitalTerminal
            // 
            this.tblpDigitalTerminal.ColumnCount = 2;
            this.tblpDigitalTerminal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblpDigitalTerminal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblpDigitalTerminal.Controls.Add(this.dtgwDigitalTerminal, 0, 1);
            this.tblpDigitalTerminal.Controls.Add(this.lblTipoDoc, 0, 0);
            this.tblpDigitalTerminal.Controls.Add(this.button1, 1, 0);
            this.tblpDigitalTerminal.ForeColor = System.Drawing.Color.Black;
            this.tblpDigitalTerminal.Location = new System.Drawing.Point(0, 2);
            this.tblpDigitalTerminal.Name = "tblpDigitalTerminal";
            this.tblpDigitalTerminal.RowCount = 2;
            this.tblpDigitalTerminal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.75904F));
            this.tblpDigitalTerminal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.24096F));
            this.tblpDigitalTerminal.Size = new System.Drawing.Size(1217, 628);
            this.tblpDigitalTerminal.TabIndex = 0;
            this.tblpDigitalTerminal.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // dtgwDigitalTerminal
            // 
            this.dtgwDigitalTerminal.BackgroundColor = System.Drawing.Color.White;
            this.dtgwDigitalTerminal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgwDigitalTerminal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgwDigitalTerminal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgwDigitalTerminal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgwDigitalTerminal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwDigitalTerminal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.plu,
            this.descripcion,
            this.cantidad,
            this.descuento,
            this.total});
            this.dtgwDigitalTerminal.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgwDigitalTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgwDigitalTerminal.GridColor = System.Drawing.Color.OrangeRed;
            this.dtgwDigitalTerminal.Location = new System.Drawing.Point(3, 95);
            this.dtgwDigitalTerminal.MultiSelect = false;
            this.dtgwDigitalTerminal.Name = "dtgwDigitalTerminal";
            this.dtgwDigitalTerminal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgwDigitalTerminal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgwDigitalTerminal.Size = new System.Drawing.Size(724, 530);
            this.dtgwDigitalTerminal.TabIndex = 0;
            this.dtgwDigitalTerminal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgwDigitalTerminal_CellContentClick);
            // 
            // col1
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col1.DefaultCellStyle = dataGridViewCellStyle2;
            this.col1.HeaderText = "ITEM";
            this.col1.Name = "col1";
            this.col1.Width = 50;
            // 
            // plu
            // 
            this.plu.HeaderText = "PLU";
            this.plu.Name = "plu";
            this.plu.Width = 51;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "DESCRIPCIÓN";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 300;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 65;
            // 
            // descuento
            // 
            this.descuento.HeaderText = "%";
            this.descuento.Name = "descuento";
            this.descuento.Width = 50;
            // 
            // total
            // 
            this.total.HeaderText = "TOTAL";
            this.total.Name = "total";
            this.total.Width = 50;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTipoDoc.Location = new System.Drawing.Point(3, 0);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(291, 24);
            this.lblTipoDoc.TabIndex = 1;
            this.lblTipoDoc.Text = "FACTURA ELECTRONICA -33";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(733, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDigitalTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(831, 435);
            this.Controls.Add(this.tblpDigitalTerminal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDigitalTerminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDigitalTerminal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDigitalTerminal_Load);
            this.tblpDigitalTerminal.ResumeLayout(false);
            this.tblpDigitalTerminal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwDigitalTerminal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblpDigitalTerminal;
        private System.Windows.Forms.DataGridView dtgwDigitalTerminal;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn plu;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Button button1;


    }
}
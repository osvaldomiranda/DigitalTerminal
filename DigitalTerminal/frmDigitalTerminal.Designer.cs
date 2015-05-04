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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tblpIzquierdo = new System.Windows.Forms.TableLayoutPanel();
            this.dtgwDetalle = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblpDerecho = new System.Windows.Forms.TableLayoutPanel();
            this.btSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tblpIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwDetalle)).BeginInit();
            this.tblpDerecho.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tblpIzquierdo);
            this.splitContainer1.Size = new System.Drawing.Size(1157, 513);
            this.splitContainer1.SplitterDistance = 646;
            this.splitContainer1.TabIndex = 0;
            // 
            // tblpIzquierdo
            // 
            this.tblpIzquierdo.BackColor = System.Drawing.Color.Transparent;
            this.tblpIzquierdo.ColumnCount = 1;
            this.tblpIzquierdo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpIzquierdo.Controls.Add(this.dtgwDetalle, 0, 1);
            this.tblpIzquierdo.Controls.Add(this.tblpDerecho, 0, 0);
            this.tblpIzquierdo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.tblpIzquierdo.Name = "tblpIzquierdo";
            this.tblpIzquierdo.RowCount = 3;
            this.tblpIzquierdo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblpIzquierdo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblpIzquierdo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpIzquierdo.Size = new System.Drawing.Size(646, 513);
            this.tblpIzquierdo.TabIndex = 0;
            // 
            // dtgwDetalle
            // 
            this.dtgwDetalle.AllowUserToOrderColumns = true;
            this.dtgwDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dtgwDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgwDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgwDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgwDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgwDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.plu,
            this.nombre,
            this.cantidad,
            this.precio,
            this.descuento,
            this.total});
            this.dtgwDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgwDetalle.Location = new System.Drawing.Point(3, 43);
            this.dtgwDetalle.Name = "dtgwDetalle";
            this.dtgwDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgwDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgwDetalle.RowHeadersVisible = false;
            this.dtgwDetalle.Size = new System.Drawing.Size(640, 348);
            this.dtgwDetalle.TabIndex = 0;
            this.dtgwDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // item
            // 
            this.item.Frozen = true;
            this.item.HeaderText = "ITEM";
            this.item.Name = "item";
            this.item.Width = 40;
            // 
            // plu
            // 
            this.plu.Frozen = true;
            this.plu.HeaderText = "PLU";
            this.plu.Name = "plu";
            this.plu.Width = 50;
            // 
            // nombre
            // 
            this.nombre.Frozen = true;
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.Width = 300;
            // 
            // cantidad
            // 
            this.cantidad.Frozen = true;
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            // 
            // precio
            // 
            this.precio.Frozen = true;
            this.precio.HeaderText = "PRECIO";
            this.precio.Name = "precio";
            this.precio.Width = 60;
            // 
            // descuento
            // 
            this.descuento.Frozen = true;
            this.descuento.HeaderText = "%";
            this.descuento.Name = "descuento";
            this.descuento.Width = 50;
            // 
            // total
            // 
            this.total.Frozen = true;
            this.total.HeaderText = "TOTAL";
            this.total.Name = "total";
            this.total.Width = 70;
            // 
            // tblpDerecho
            // 
            this.tblpDerecho.ColumnCount = 4;
            this.tblpDerecho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpDerecho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpDerecho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpDerecho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpDerecho.Controls.Add(this.btSalir, 0, 0);
            this.tblpDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpDerecho.Location = new System.Drawing.Point(3, 3);
            this.tblpDerecho.Name = "tblpDerecho";
            this.tblpDerecho.RowCount = 1;
            this.tblpDerecho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpDerecho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tblpDerecho.Size = new System.Drawing.Size(640, 34);
            this.tblpDerecho.TabIndex = 1;
            // 
            // btSalir
            // 
            this.btSalir.BackgroundImage = global::DigitalTerminal.Properties.Resources.btSalir;
            this.btSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.ForeColor = System.Drawing.Color.White;
            this.btSalir.Location = new System.Drawing.Point(3, 3);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(154, 28);
            this.btSalir.TabIndex = 0;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmDigitalTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1157, 513);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Name = "frmDigitalTerminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDigitalTerminal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDigitalTerminal_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tblpIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgwDetalle)).EndInit();
            this.tblpDerecho.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tblpIzquierdo;
        private System.Windows.Forms.DataGridView dtgwDetalle;
        private System.Windows.Forms.TableLayoutPanel tblpDerecho;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn plu;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;



    }
}
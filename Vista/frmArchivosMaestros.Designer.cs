namespace Vista
{
    partial class frmArchivosMaestros
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
            this.btnClientes = new System.Windows.Forms.Button();
            this.buttonProductos = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonComunas = new System.Windows.Forms.Button();
            this.buttonPaises = new System.Windows.Forms.Button();
            this.buttonCiudades = new System.Windows.Forms.Button();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnClientes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonProductos, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonComunas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonPaises, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCiudades, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonConfig, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(442, 331);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnClientes
            // 
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Black;
            this.btnClientes.Image = global::Vista.Properties.Resources.add_user_3_48;
            this.btnClientes.Location = new System.Drawing.Point(5, 5);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(5);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(100, 100);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // buttonProductos
            // 
            this.buttonProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProductos.ForeColor = System.Drawing.Color.Black;
            this.buttonProductos.Image = global::Vista.Properties.Resources.product_48;
            this.buttonProductos.Location = new System.Drawing.Point(115, 5);
            this.buttonProductos.Margin = new System.Windows.Forms.Padding(5);
            this.buttonProductos.Name = "buttonProductos";
            this.buttonProductos.Size = new System.Drawing.Size(100, 100);
            this.buttonProductos.TabIndex = 1;
            this.buttonProductos.Text = "Productos";
            this.buttonProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonProductos.UseVisualStyleBackColor = true;
            this.buttonProductos.Click += new System.EventHandler(this.buttonProductos_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::Vista.Properties.Resources.exit_32;
            this.button5.Location = new System.Drawing.Point(5, 225);
            this.button5.Margin = new System.Windows.Forms.Padding(5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 100);
            this.button5.TabIndex = 5;
            this.button5.Text = "Salir";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonComunas
            // 
            this.buttonComunas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonComunas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComunas.Image = global::Vista.Properties.Resources.globe_48__2_;
            this.buttonComunas.Location = new System.Drawing.Point(5, 115);
            this.buttonComunas.Margin = new System.Windows.Forms.Padding(5);
            this.buttonComunas.Name = "buttonComunas";
            this.buttonComunas.Size = new System.Drawing.Size(100, 100);
            this.buttonComunas.TabIndex = 4;
            this.buttonComunas.Text = "Comunas";
            this.buttonComunas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonComunas.UseVisualStyleBackColor = true;
            this.buttonComunas.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonPaises
            // 
            this.buttonPaises.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPaises.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaises.Image = global::Vista.Properties.Resources.globe_48;
            this.buttonPaises.Location = new System.Drawing.Point(225, 5);
            this.buttonPaises.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPaises.Name = "buttonPaises";
            this.buttonPaises.Size = new System.Drawing.Size(100, 100);
            this.buttonPaises.TabIndex = 2;
            this.buttonPaises.Text = "Paises";
            this.buttonPaises.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPaises.UseVisualStyleBackColor = true;
            this.buttonPaises.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCiudades
            // 
            this.buttonCiudades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCiudades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCiudades.Image = global::Vista.Properties.Resources.globe_48__1_;
            this.buttonCiudades.Location = new System.Drawing.Point(335, 5);
            this.buttonCiudades.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCiudades.Name = "buttonCiudades";
            this.buttonCiudades.Size = new System.Drawing.Size(100, 100);
            this.buttonCiudades.TabIndex = 3;
            this.buttonCiudades.Text = "Ciudades";
            this.buttonCiudades.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCiudades.UseVisualStyleBackColor = true;
            this.buttonCiudades.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonConfig
            // 
            this.buttonConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfig.Image = global::Vista.Properties.Resources.settings_7_48;
            this.buttonConfig.Location = new System.Drawing.Point(115, 115);
            this.buttonConfig.Margin = new System.Windows.Forms.Padding(5);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(100, 100);
            this.buttonConfig.TabIndex = 6;
            this.buttonConfig.Text = "Configuración";
            this.buttonConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonConfig.UseVisualStyleBackColor = true;
            // 
            // frmArchivosMaestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 331);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmArchivosMaestros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmArchivosMaestros_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button buttonProductos;
        private System.Windows.Forms.Button buttonPaises;
        private System.Windows.Forms.Button buttonCiudades;
        private System.Windows.Forms.Button buttonComunas;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonConfig;
    }
}
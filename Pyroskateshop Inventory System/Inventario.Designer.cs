namespace Pyroskateshop_Inventory_System
{
    partial class Inventario
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
            this.lblAgregarArticulo = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.btnDescripcion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonLogoMenu = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoDolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgregarArticulo
            // 
            this.lblAgregarArticulo.AutoSize = true;
            this.lblAgregarArticulo.BackColor = System.Drawing.Color.Transparent;
            this.lblAgregarArticulo.Font = new System.Drawing.Font("Lucida Sans", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarArticulo.Location = new System.Drawing.Point(498, 60);
            this.lblAgregarArticulo.Name = "lblAgregarArticulo";
            this.lblAgregarArticulo.Size = new System.Drawing.Size(258, 45);
            this.lblAgregarArticulo.TabIndex = 1;
            this.lblAgregarArticulo.Text = "ARTÍCULOS";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.tbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescripcion.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.tbDescripcion.Location = new System.Drawing.Point(93, 155);
            this.tbDescripcion.MaxLength = 50;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(960, 18);
            this.tbDescripcion.TabIndex = 37;
            this.tbDescripcion.Text = "Buscar por descripción, precio, existencias, etc";
            // 
            // btnDescripcion
            // 
            this.btnDescripcion.BackColor = System.Drawing.Color.White;
            this.btnDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnDescripcion.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnDescripcion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDescripcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescripcion.Location = new System.Drawing.Point(6, 123);
            this.btnDescripcion.Margin = new System.Windows.Forms.Padding(0);
            this.btnDescripcion.Name = "btnDescripcion";
            this.btnDescripcion.Size = new System.Drawing.Size(1241, 80);
            this.btnDescripcion.TabIndex = 36;
            this.btnDescripcion.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(30, 144);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1039, 40);
            this.button1.TabIndex = 51;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(6, 213);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1239, 684);
            this.button2.TabIndex = 53;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Categoria,
            this.Tipo,
            this.Descripcion,
            this.Marca,
            this.Medida,
            this.Cantidad,
            this.CostoCompra,
            this.CostoDolares,
            this.PreioVenta,
            this.Estado,
            this.Modificar,
            this.Eliminar});
            this.dataGridView1.Location = new System.Drawing.Point(8, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1239, 684);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // buttonLogoMenu
            // 
            this.buttonLogoMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.buttonLogoMenu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonLogoMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLogoMenu.FlatAppearance.BorderSize = 0;
            this.buttonLogoMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLogoMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLogoMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogoMenu.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogoMenu.ForeColor = System.Drawing.Color.Black;
            this.buttonLogoMenu.Image = global::Pyroskateshop_Inventory_System.Properties.Resources.Buscar;
            this.buttonLogoMenu.Location = new System.Drawing.Point(54, 154);
            this.buttonLogoMenu.Name = "buttonLogoMenu";
            this.buttonLogoMenu.Size = new System.Drawing.Size(21, 21);
            this.buttonLogoMenu.TabIndex = 52;
            this.buttonLogoMenu.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(1)))), ((int)(((byte)(35)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(1)))), ((int)(((byte)(35)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::Pyroskateshop_Inventory_System.Properties.Resources.filtrar;
            this.btnCancelar.Location = new System.Drawing.Point(1084, 143);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 41);
            this.btnCancelar.TabIndex = 50;
            this.btnCancelar.Text = "   FILTRAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.Name = "Categoria";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Medida
            // 
            this.Medida.HeaderText = "Medida";
            this.Medida.Name = "Medida";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // CostoCompra
            // 
            this.CostoCompra.HeaderText = "Costo de compra";
            this.CostoCompra.Name = "CostoCompra";
            // 
            // CostoDolares
            // 
            this.CostoDolares.HeaderText = "Costo en dolares";
            this.CostoDolares.Name = "CostoDolares";
            // 
            // PreioVenta
            // 
            this.PreioVenta.HeaderText = "Precio de venta";
            this.PreioVenta.Name = "PreioVenta";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1254, 906);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonLogoMenu);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.lblAgregarArticulo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventario";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarArticulo;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Button btnDescripcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonLogoMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}
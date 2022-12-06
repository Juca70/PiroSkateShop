namespace Pyroskateshop_Inventory_System
{
    partial class AgregarArticulo
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
            this.pAgregarArticulo = new System.Windows.Forms.Panel();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblSeparador2 = new System.Windows.Forms.Label();
            this.tbPrecioVenta = new System.Windows.Forms.TextBox();
            this.btnPrecioVenta = new System.Windows.Forms.Button();
            this.tbPrecioDolares = new System.Windows.Forms.TextBox();
            this.btnPrecioDolares = new System.Windows.Forms.Button();
            this.tbPrecioCompra = new System.Windows.Forms.TextBox();
            this.btnPrecioCompra = new System.Windows.Forms.Button();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.btnCantidad = new System.Windows.Forms.Button();
            this.tbMedida = new System.Windows.Forms.TextBox();
            this.btnMedida = new System.Windows.Forms.Button();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.btnMarca = new System.Windows.Forms.Button();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.btnDescripcion = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.lblPrecioDolares = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblMedida = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.lblSeparador1 = new System.Windows.Forms.Label();
            this.lblNuevoArticulo = new System.Windows.Forms.Label();
            this.cbDolares = new System.Windows.Forms.CheckBox();
            this.pAgregarArticulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAgregarArticulo
            // 
            this.lblAgregarArticulo.AutoSize = true;
            this.lblAgregarArticulo.BackColor = System.Drawing.Color.Transparent;
            this.lblAgregarArticulo.Font = new System.Drawing.Font("Lucida Sans", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarArticulo.Location = new System.Drawing.Point(354, -7);
            this.lblAgregarArticulo.Name = "lblAgregarArticulo";
            this.lblAgregarArticulo.Size = new System.Drawing.Size(472, 45);
            this.lblAgregarArticulo.TabIndex = 0;
            this.lblAgregarArticulo.Text = "AGREGAR ARTÍCULOS";
            // 
            // pAgregarArticulo
            // 
            this.pAgregarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.pAgregarArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pAgregarArticulo.Controls.Add(this.cbDolares);
            this.pAgregarArticulo.Controls.Add(this.cbCategorias);
            this.pAgregarArticulo.Controls.Add(this.btnGuardar);
            this.pAgregarArticulo.Controls.Add(this.lblSeparador2);
            this.pAgregarArticulo.Controls.Add(this.tbPrecioVenta);
            this.pAgregarArticulo.Controls.Add(this.btnPrecioVenta);
            this.pAgregarArticulo.Controls.Add(this.tbPrecioDolares);
            this.pAgregarArticulo.Controls.Add(this.btnPrecioDolares);
            this.pAgregarArticulo.Controls.Add(this.tbPrecioCompra);
            this.pAgregarArticulo.Controls.Add(this.btnPrecioCompra);
            this.pAgregarArticulo.Controls.Add(this.tbCantidad);
            this.pAgregarArticulo.Controls.Add(this.btnCantidad);
            this.pAgregarArticulo.Controls.Add(this.tbMedida);
            this.pAgregarArticulo.Controls.Add(this.btnMedida);
            this.pAgregarArticulo.Controls.Add(this.tbMarca);
            this.pAgregarArticulo.Controls.Add(this.btnMarca);
            this.pAgregarArticulo.Controls.Add(this.tbDescripcion);
            this.pAgregarArticulo.Controls.Add(this.btnDescripcion);
            this.pAgregarArticulo.Controls.Add(this.btnCategorias);
            this.pAgregarArticulo.Controls.Add(this.lblPrecioDolares);
            this.pAgregarArticulo.Controls.Add(this.lblDescripcion);
            this.pAgregarArticulo.Controls.Add(this.lblMarca);
            this.pAgregarArticulo.Controls.Add(this.lblMedida);
            this.pAgregarArticulo.Controls.Add(this.lblCantidad);
            this.pAgregarArticulo.Controls.Add(this.lblPrecioVenta);
            this.pAgregarArticulo.Controls.Add(this.lblPrecioCompra);
            this.pAgregarArticulo.Controls.Add(this.lblCategorias);
            this.pAgregarArticulo.Controls.Add(this.lblSeparador1);
            this.pAgregarArticulo.Controls.Add(this.lblNuevoArticulo);
            this.pAgregarArticulo.Location = new System.Drawing.Point(87, 61);
            this.pAgregarArticulo.Name = "pAgregarArticulo";
            this.pAgregarArticulo.Size = new System.Drawing.Size(1005, 576);
            this.pAgregarArticulo.TabIndex = 1;
            // 
            // cbCategorias
            // 
            this.cbCategorias.BackColor = System.Drawing.Color.White;
            this.cbCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Items.AddRange(new object[] {
            "Accesories",
            "Bearings",
            "Decks",
            "Fleece",
            "Griptape",
            "Hardware",
            "Hats",
            "Pants-Shorts-Swim",
            "Protecciones",
            "Rise pad-bushing",
            "Shoes",
            "Socks",
            "Stickers",
            "T-Shirts",
            "Truck",
            "Wax",
            "Wheels"});
            this.cbCategorias.Location = new System.Drawing.Point(49, 126);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(262, 21);
            this.cbCategorias.TabIndex = 51;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(1)))), ((int)(((byte)(35)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(1)))), ((int)(((byte)(35)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(754, 525);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(183, 45);
            this.btnGuardar.TabIndex = 50;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.button8_Click);
            // 
            // lblSeparador2
            // 
            this.lblSeparador2.AutoSize = true;
            this.lblSeparador2.ForeColor = System.Drawing.Color.White;
            this.lblSeparador2.Location = new System.Drawing.Point(30, 485);
            this.lblSeparador2.Name = "lblSeparador2";
            this.lblSeparador2.Size = new System.Drawing.Size(907, 13);
            this.lblSeparador2.TabIndex = 48;
            this.lblSeparador2.Text = "_________________________________________________________________________________" +
    "_____________________________________________________________________";
            // 
            // tbPrecioVenta
            // 
            this.tbPrecioVenta.BackColor = System.Drawing.Color.White;
            this.tbPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrecioVenta.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecioVenta.ForeColor = System.Drawing.Color.Black;
            this.tbPrecioVenta.Location = new System.Drawing.Point(690, 425);
            this.tbPrecioVenta.Name = "tbPrecioVenta";
            this.tbPrecioVenta.Size = new System.Drawing.Size(263, 18);
            this.tbPrecioVenta.TabIndex = 47;
            this.tbPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecioVenta_KeyPress);
            // 
            // btnPrecioVenta
            // 
            this.btnPrecioVenta.BackColor = System.Drawing.Color.White;
            this.btnPrecioVenta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnPrecioVenta.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnPrecioVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPrecioVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPrecioVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrecioVenta.Location = new System.Drawing.Point(673, 404);
            this.btnPrecioVenta.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrecioVenta.Name = "btnPrecioVenta";
            this.btnPrecioVenta.Size = new System.Drawing.Size(293, 60);
            this.btnPrecioVenta.TabIndex = 46;
            this.btnPrecioVenta.UseVisualStyleBackColor = false;
            // 
            // tbPrecioDolares
            // 
            this.tbPrecioDolares.BackColor = System.Drawing.Color.White;
            this.tbPrecioDolares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrecioDolares.Enabled = false;
            this.tbPrecioDolares.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecioDolares.ForeColor = System.Drawing.Color.Black;
            this.tbPrecioDolares.Location = new System.Drawing.Point(370, 426);
            this.tbPrecioDolares.Name = "tbPrecioDolares";
            this.tbPrecioDolares.Size = new System.Drawing.Size(259, 18);
            this.tbPrecioDolares.TabIndex = 45;
            this.tbPrecioDolares.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecioDolares_KeyPress);
            // 
            // btnPrecioDolares
            // 
            this.btnPrecioDolares.BackColor = System.Drawing.Color.White;
            this.btnPrecioDolares.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnPrecioDolares.Enabled = false;
            this.btnPrecioDolares.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnPrecioDolares.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPrecioDolares.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPrecioDolares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrecioDolares.Location = new System.Drawing.Point(353, 404);
            this.btnPrecioDolares.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrecioDolares.Name = "btnPrecioDolares";
            this.btnPrecioDolares.Size = new System.Drawing.Size(293, 60);
            this.btnPrecioDolares.TabIndex = 44;
            this.btnPrecioDolares.UseVisualStyleBackColor = false;
            // 
            // tbPrecioCompra
            // 
            this.tbPrecioCompra.BackColor = System.Drawing.Color.White;
            this.tbPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrecioCompra.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecioCompra.ForeColor = System.Drawing.Color.Black;
            this.tbPrecioCompra.Location = new System.Drawing.Point(49, 427);
            this.tbPrecioCompra.Name = "tbPrecioCompra";
            this.tbPrecioCompra.Size = new System.Drawing.Size(262, 18);
            this.tbPrecioCompra.TabIndex = 43;
            this.tbPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecioCompra_KeyPress);
            this.tbPrecioCompra.Leave += new System.EventHandler(this.tbPrecioCompra_Leave);
            // 
            // btnPrecioCompra
            // 
            this.btnPrecioCompra.BackColor = System.Drawing.Color.White;
            this.btnPrecioCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnPrecioCompra.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnPrecioCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPrecioCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPrecioCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrecioCompra.Location = new System.Drawing.Point(35, 405);
            this.btnPrecioCompra.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrecioCompra.Name = "btnPrecioCompra";
            this.btnPrecioCompra.Size = new System.Drawing.Size(293, 60);
            this.btnPrecioCompra.TabIndex = 42;
            this.btnPrecioCompra.UseVisualStyleBackColor = false;
            // 
            // tbCantidad
            // 
            this.tbCantidad.BackColor = System.Drawing.Color.White;
            this.tbCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCantidad.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.ForeColor = System.Drawing.Color.Black;
            this.tbCantidad.Location = new System.Drawing.Point(690, 325);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(263, 18);
            this.tbCantidad.TabIndex = 41;
            this.tbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCantidad_KeyPress);
            // 
            // btnCantidad
            // 
            this.btnCantidad.BackColor = System.Drawing.Color.White;
            this.btnCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnCantidad.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCantidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCantidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCantidad.Location = new System.Drawing.Point(673, 304);
            this.btnCantidad.Margin = new System.Windows.Forms.Padding(0);
            this.btnCantidad.Name = "btnCantidad";
            this.btnCantidad.Size = new System.Drawing.Size(293, 60);
            this.btnCantidad.TabIndex = 40;
            this.btnCantidad.UseVisualStyleBackColor = false;
            // 
            // tbMedida
            // 
            this.tbMedida.BackColor = System.Drawing.Color.White;
            this.tbMedida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMedida.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMedida.ForeColor = System.Drawing.Color.Black;
            this.tbMedida.Location = new System.Drawing.Point(370, 326);
            this.tbMedida.Name = "tbMedida";
            this.tbMedida.Size = new System.Drawing.Size(259, 18);
            this.tbMedida.TabIndex = 39;
            // 
            // btnMedida
            // 
            this.btnMedida.BackColor = System.Drawing.Color.White;
            this.btnMedida.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnMedida.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnMedida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMedida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedida.Location = new System.Drawing.Point(353, 304);
            this.btnMedida.Margin = new System.Windows.Forms.Padding(0);
            this.btnMedida.Name = "btnMedida";
            this.btnMedida.Size = new System.Drawing.Size(293, 60);
            this.btnMedida.TabIndex = 38;
            this.btnMedida.UseVisualStyleBackColor = false;
            // 
            // tbMarca
            // 
            this.tbMarca.BackColor = System.Drawing.Color.White;
            this.tbMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMarca.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMarca.ForeColor = System.Drawing.Color.Black;
            this.tbMarca.Location = new System.Drawing.Point(49, 326);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(262, 18);
            this.tbMarca.TabIndex = 37;
            // 
            // btnMarca
            // 
            this.btnMarca.BackColor = System.Drawing.Color.White;
            this.btnMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnMarca.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarca.Location = new System.Drawing.Point(35, 305);
            this.btnMarca.Margin = new System.Windows.Forms.Padding(0);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(293, 60);
            this.btnMarca.TabIndex = 36;
            this.btnMarca.UseVisualStyleBackColor = false;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.Color.White;
            this.tbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescripcion.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.ForeColor = System.Drawing.Color.Black;
            this.tbDescripcion.Location = new System.Drawing.Point(49, 226);
            this.tbDescripcion.MaxLength = 50;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(904, 18);
            this.tbDescripcion.TabIndex = 35;
            // 
            // btnDescripcion
            // 
            this.btnDescripcion.BackColor = System.Drawing.Color.White;
            this.btnDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnDescripcion.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnDescripcion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDescripcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescripcion.Location = new System.Drawing.Point(35, 205);
            this.btnDescripcion.Margin = new System.Windows.Forms.Padding(0);
            this.btnDescripcion.Name = "btnDescripcion";
            this.btnDescripcion.Size = new System.Drawing.Size(932, 60);
            this.btnDescripcion.TabIndex = 34;
            this.btnDescripcion.UseVisualStyleBackColor = false;
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.White;
            this.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategorias.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCategorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Location = new System.Drawing.Point(35, 105);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(0);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(293, 60);
            this.btnCategorias.TabIndex = 32;
            this.btnCategorias.UseVisualStyleBackColor = false;
            // 
            // lblPrecioDolares
            // 
            this.lblPrecioDolares.AutoSize = true;
            this.lblPrecioDolares.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioDolares.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDolares.Location = new System.Drawing.Point(354, 380);
            this.lblPrecioDolares.Name = "lblPrecioDolares";
            this.lblPrecioDolares.Size = new System.Drawing.Size(148, 18);
            this.lblPrecioDolares.TabIndex = 31;
            this.lblPrecioDolares.Text = "Precio en dolares";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(35, 185);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(103, 18);
            this.lblDescripcion.TabIndex = 30;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(35, 285);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(59, 18);
            this.lblMarca.TabIndex = 29;
            this.lblMarca.Text = "Marca";
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.BackColor = System.Drawing.Color.Transparent;
            this.lblMedida.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedida.Location = new System.Drawing.Point(354, 285);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(68, 18);
            this.lblMedida.TabIndex = 28;
            this.lblMedida.Text = "Medida";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(671, 285);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(80, 18);
            this.lblCantidad.TabIndex = 27;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.Location = new System.Drawing.Point(671, 380);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(135, 18);
            this.lblPrecioVenta.TabIndex = 26;
            this.lblPrecioVenta.Text = "Precio de venta";
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioCompra.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCompra.Location = new System.Drawing.Point(32, 380);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(148, 18);
            this.lblPrecioCompra.TabIndex = 25;
            this.lblPrecioCompra.Text = "Precio de compra";
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.BackColor = System.Drawing.Color.Transparent;
            this.lblCategorias.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.Location = new System.Drawing.Point(35, 80);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(96, 18);
            this.lblCategorias.TabIndex = 24;
            this.lblCategorias.Text = "Categorias";
            // 
            // lblSeparador1
            // 
            this.lblSeparador1.AutoSize = true;
            this.lblSeparador1.BackColor = System.Drawing.Color.Transparent;
            this.lblSeparador1.ForeColor = System.Drawing.Color.White;
            this.lblSeparador1.Location = new System.Drawing.Point(30, 49);
            this.lblSeparador1.Name = "lblSeparador1";
            this.lblSeparador1.Size = new System.Drawing.Size(907, 13);
            this.lblSeparador1.TabIndex = 23;
            this.lblSeparador1.Text = "_________________________________________________________________________________" +
    "_____________________________________________________________________";
            // 
            // lblNuevoArticulo
            // 
            this.lblNuevoArticulo.AutoSize = true;
            this.lblNuevoArticulo.BackColor = System.Drawing.Color.Transparent;
            this.lblNuevoArticulo.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoArticulo.Location = new System.Drawing.Point(34, 31);
            this.lblNuevoArticulo.Name = "lblNuevoArticulo";
            this.lblNuevoArticulo.Size = new System.Drawing.Size(158, 22);
            this.lblNuevoArticulo.TabIndex = 2;
            this.lblNuevoArticulo.Text = "Nuevo artículo";
            // 
            // cbDolares
            // 
            this.cbDolares.AutoSize = true;
            this.cbDolares.Location = new System.Drawing.Point(508, 384);
            this.cbDolares.Name = "cbDolares";
            this.cbDolares.Size = new System.Drawing.Size(15, 14);
            this.cbDolares.TabIndex = 52;
            this.cbDolares.UseVisualStyleBackColor = true;
            this.cbDolares.Click += new System.EventHandler(this.cbDolares_Click);
            // 
            // AgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 706);
            this.Controls.Add(this.pAgregarArticulo);
            this.Controls.Add(this.lblAgregarArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarArticulo";
            this.Text = "AgregarArticulo";
            this.pAgregarArticulo.ResumeLayout(false);
            this.pAgregarArticulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarArticulo;
        private System.Windows.Forms.Panel pAgregarArticulo;
        private System.Windows.Forms.Label lblNuevoArticulo;
        private System.Windows.Forms.Label lblSeparador1;
        private System.Windows.Forms.Label lblPrecioDolares;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.TextBox tbPrecioCompra;
        private System.Windows.Forms.Button btnPrecioCompra;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Button btnCantidad;
        private System.Windows.Forms.TextBox tbMedida;
        private System.Windows.Forms.Button btnMedida;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Button btnDescripcion;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.TextBox tbPrecioVenta;
        private System.Windows.Forms.Button btnPrecioVenta;
        private System.Windows.Forms.TextBox tbPrecioDolares;
        private System.Windows.Forms.Button btnPrecioDolares;
        private System.Windows.Forms.Label lblSeparador2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.CheckBox cbDolares;
    }
}
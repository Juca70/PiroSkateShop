namespace Pyroskateshop_Inventory_System
{
    partial class SistemaDeInventario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.kryptonSeparatorMenuLateral = new ComponentFactory.Krypton.Toolkit.KryptonSeparator();
            this.panelEncabezado = new System.Windows.Forms.Panel();
            this.labelHeaderUsuario = new System.Windows.Forms.Label();
            this.panelSubEncabezado = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.pictureBoxMinimizarVentana = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrarVentana = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLogoMenu = new System.Windows.Forms.Button();
            this.buttonCerrarSesionMenu = new System.Windows.Forms.Button();
            this.buttonHerramientasMenu = new System.Windows.Forms.Button();
            this.buttonReporteMenu = new System.Windows.Forms.Button();
            this.buttonVentaMenu = new System.Windows.Forms.Button();
            this.buttonInventarioMenu = new System.Windows.Forms.Button();
            this.buttonAgregarMenu = new System.Windows.Forms.Button();
            this.panelMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparatorMenuLateral)).BeginInit();
            this.panelEncabezado.SuspendLayout();
            this.panelSubEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.Color.White;
            this.panelMenuLateral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenuLateral.Controls.Add(this.buttonLogoMenu);
            this.panelMenuLateral.Controls.Add(this.buttonCerrarSesionMenu);
            this.panelMenuLateral.Controls.Add(this.buttonHerramientasMenu);
            this.panelMenuLateral.Controls.Add(this.buttonReporteMenu);
            this.panelMenuLateral.Controls.Add(this.buttonVentaMenu);
            this.panelMenuLateral.Controls.Add(this.buttonInventarioMenu);
            this.panelMenuLateral.Controls.Add(this.buttonAgregarMenu);
            this.panelMenuLateral.Controls.Add(this.kryptonSeparatorMenuLateral);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(186, 1024);
            this.panelMenuLateral.TabIndex = 0;
            // 
            // kryptonSeparatorMenuLateral
            // 
            this.kryptonSeparatorMenuLateral.Location = new System.Drawing.Point(-1, 194);
            this.kryptonSeparatorMenuLateral.Name = "kryptonSeparatorMenuLateral";
            this.kryptonSeparatorMenuLateral.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.kryptonSeparatorMenuLateral.Size = new System.Drawing.Size(186, 3);
            this.kryptonSeparatorMenuLateral.TabIndex = 1;
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.BackColor = System.Drawing.Color.White;
            this.panelEncabezado.Controls.Add(this.pictureBoxMinimizarVentana);
            this.panelEncabezado.Controls.Add(this.pictureBoxCerrarVentana);
            this.panelEncabezado.Controls.Add(this.labelHeaderUsuario);
            this.panelEncabezado.Controls.Add(this.pictureBox1);
            this.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncabezado.Location = new System.Drawing.Point(186, 0);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Size = new System.Drawing.Size(1254, 67);
            this.panelEncabezado.TabIndex = 1;
            this.panelEncabezado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // labelHeaderUsuario
            // 
            this.labelHeaderUsuario.AutoSize = true;
            this.labelHeaderUsuario.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderUsuario.Location = new System.Drawing.Point(968, 24);
            this.labelHeaderUsuario.Name = "labelHeaderUsuario";
            this.labelHeaderUsuario.Size = new System.Drawing.Size(136, 22);
            this.labelHeaderUsuario.TabIndex = 1;
            this.labelHeaderUsuario.Text = "Hola, Usuario";
            // 
            // panelSubEncabezado
            // 
            this.panelSubEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelSubEncabezado.Controls.Add(this.dateTimePicker1);
            this.panelSubEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubEncabezado.Location = new System.Drawing.Point(186, 67);
            this.panelSubEncabezado.Name = "panelSubEncabezado";
            this.panelSubEncabezado.Size = new System.Drawing.Size(1254, 51);
            this.panelSubEncabezado.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1027, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(186, 118);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1254, 906);
            this.panelContenido.TabIndex = 3;
            // 
            // pictureBoxMinimizarVentana
            // 
            this.pictureBoxMinimizarVentana.Image = global::Pyroskateshop_Inventory_System.Properties.Resources.MinimizarVentana;
            this.pictureBoxMinimizarVentana.Location = new System.Drawing.Point(1176, 16);
            this.pictureBoxMinimizarVentana.Name = "pictureBoxMinimizarVentana";
            this.pictureBoxMinimizarVentana.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxMinimizarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMinimizarVentana.TabIndex = 3;
            this.pictureBoxMinimizarVentana.TabStop = false;
            this.pictureBoxMinimizarVentana.Click += new System.EventHandler(this.pictureBoxMinimizarVentana_Click);
            // 
            // pictureBoxCerrarVentana
            // 
            this.pictureBoxCerrarVentana.BackColor = System.Drawing.Color.White;
            this.pictureBoxCerrarVentana.Image = global::Pyroskateshop_Inventory_System.Properties.Resources.CerrarVentana;
            this.pictureBoxCerrarVentana.Location = new System.Drawing.Point(1212, 16);
            this.pictureBoxCerrarVentana.Name = "pictureBoxCerrarVentana";
            this.pictureBoxCerrarVentana.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxCerrarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxCerrarVentana.TabIndex = 2;
            this.pictureBoxCerrarVentana.TabStop = false;
            this.pictureBoxCerrarVentana.Click += new System.EventHandler(this.pictureBoxCerrarVentana_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pyroskateshop_Inventory_System.Properties.Resources.IconoUsuario;
            this.pictureBox1.Location = new System.Drawing.Point(1110, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLogoMenu
            // 
            this.buttonLogoMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogoMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogoMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLogoMenu.FlatAppearance.BorderSize = 0;
            this.buttonLogoMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLogoMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLogoMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogoMenu.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogoMenu.ForeColor = System.Drawing.Color.Black;
            this.buttonLogoMenu.Image = global::Pyroskateshop_Inventory_System.Properties.Resources.PyroLogoMenuLateral2;
            this.buttonLogoMenu.Location = new System.Drawing.Point(40, 20);
            this.buttonLogoMenu.Name = "buttonLogoMenu";
            this.buttonLogoMenu.Size = new System.Drawing.Size(103, 140);
            this.buttonLogoMenu.TabIndex = 19;
            this.buttonLogoMenu.UseVisualStyleBackColor = false;
            this.buttonLogoMenu.Click += new System.EventHandler(this.buttonLogoMenu_Click);
            // 
            // buttonCerrarSesionMenu
            // 
            this.buttonCerrarSesionMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonCerrarSesionMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCerrarSesionMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCerrarSesionMenu.FlatAppearance.BorderSize = 0;
            this.buttonCerrarSesionMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonCerrarSesionMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrarSesionMenu.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarSesionMenu.ForeColor = System.Drawing.Color.Black;
            this.buttonCerrarSesionMenu.Image = global::Pyroskateshop_Inventory_System.Properties.Resources.CerrarSesionMenuLateral1;
            this.buttonCerrarSesionMenu.Location = new System.Drawing.Point(0, 895);
            this.buttonCerrarSesionMenu.Name = "buttonCerrarSesionMenu";
            this.buttonCerrarSesionMenu.Size = new System.Drawing.Size(186, 100);
            this.buttonCerrarSesionMenu.TabIndex = 18;
            this.buttonCerrarSesionMenu.Text = "Cerrar sesión";
            this.buttonCerrarSesionMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCerrarSesionMenu.UseVisualStyleBackColor = false;
            // 
            // buttonHerramientasMenu
            // 
            this.buttonHerramientasMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonHerramientasMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHerramientasMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonHerramientasMenu.FlatAppearance.BorderSize = 0;
            this.buttonHerramientasMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHerramientasMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHerramientasMenu.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHerramientasMenu.ForeColor = System.Drawing.Color.Black;
            this.buttonHerramientasMenu.Image = global::Pyroskateshop_Inventory_System.Properties.Resources.HerramientasMenuLateral1;
            this.buttonHerramientasMenu.Location = new System.Drawing.Point(0, 700);
            this.buttonHerramientasMenu.Name = "buttonHerramientasMenu";
            this.buttonHerramientasMenu.Size = new System.Drawing.Size(186, 100);
            this.buttonHerramientasMenu.TabIndex = 17;
            this.buttonHerramientasMenu.Text = "Herramientas";
            this.buttonHerramientasMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonHerramientasMenu.UseVisualStyleBackColor = false;
            // 
            // buttonReporteMenu
            // 
            this.buttonReporteMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonReporteMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReporteMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonReporteMenu.FlatAppearance.BorderSize = 0;
            this.buttonReporteMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonReporteMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReporteMenu.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReporteMenu.ForeColor = System.Drawing.Color.Black;
            this.buttonReporteMenu.Image = global::Pyroskateshop_Inventory_System.Properties.Resources.ReporteMenuLateral;
            this.buttonReporteMenu.Location = new System.Drawing.Point(0, 575);
            this.buttonReporteMenu.Name = "buttonReporteMenu";
            this.buttonReporteMenu.Size = new System.Drawing.Size(186, 100);
            this.buttonReporteMenu.TabIndex = 16;
            this.buttonReporteMenu.Text = "Reporte de ventas";
            this.buttonReporteMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonReporteMenu.UseVisualStyleBackColor = false;
            // 
            // buttonVentaMenu
            // 
            this.buttonVentaMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonVentaMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVentaMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonVentaMenu.FlatAppearance.BorderSize = 0;
            this.buttonVentaMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonVentaMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVentaMenu.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVentaMenu.ForeColor = System.Drawing.Color.Black;
            this.buttonVentaMenu.Image = global::Pyroskateshop_Inventory_System.Properties.Resources.CarritoMenuLateral1;
            this.buttonVentaMenu.Location = new System.Drawing.Point(0, 450);
            this.buttonVentaMenu.Name = "buttonVentaMenu";
            this.buttonVentaMenu.Size = new System.Drawing.Size(186, 100);
            this.buttonVentaMenu.TabIndex = 15;
            this.buttonVentaMenu.Text = "Realizar venta";
            this.buttonVentaMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonVentaMenu.UseVisualStyleBackColor = false;
            // 
            // buttonInventarioMenu
            // 
            this.buttonInventarioMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonInventarioMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInventarioMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonInventarioMenu.FlatAppearance.BorderSize = 0;
            this.buttonInventarioMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonInventarioMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventarioMenu.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInventarioMenu.ForeColor = System.Drawing.Color.Black;
            this.buttonInventarioMenu.Image = global::Pyroskateshop_Inventory_System.Properties.Resources.ConsultarMenuLateral2;
            this.buttonInventarioMenu.Location = new System.Drawing.Point(0, 325);
            this.buttonInventarioMenu.Name = "buttonInventarioMenu";
            this.buttonInventarioMenu.Size = new System.Drawing.Size(186, 100);
            this.buttonInventarioMenu.TabIndex = 14;
            this.buttonInventarioMenu.Text = "Inventario";
            this.buttonInventarioMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonInventarioMenu.UseVisualStyleBackColor = false;
            this.buttonInventarioMenu.Click += new System.EventHandler(this.buttonInventarioMenu_Click);
            // 
            // buttonAgregarMenu
            // 
            this.buttonAgregarMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonAgregarMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregarMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAgregarMenu.FlatAppearance.BorderSize = 0;
            this.buttonAgregarMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAgregarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarMenu.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarMenu.ForeColor = System.Drawing.Color.Black;
            this.buttonAgregarMenu.Image = global::Pyroskateshop_Inventory_System.Properties.Resources.BotonAgregarMenuLateral1;
            this.buttonAgregarMenu.Location = new System.Drawing.Point(0, 200);
            this.buttonAgregarMenu.Name = "buttonAgregarMenu";
            this.buttonAgregarMenu.Size = new System.Drawing.Size(186, 100);
            this.buttonAgregarMenu.TabIndex = 2;
            this.buttonAgregarMenu.Text = "Agregar artículo";
            this.buttonAgregarMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAgregarMenu.UseVisualStyleBackColor = false;
            this.buttonAgregarMenu.Click += new System.EventHandler(this.buttonAgregarMenu_Click);
            // 
            // SistemaDeInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1440, 1024);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelSubEncabezado);
            this.Controls.Add(this.panelEncabezado);
            this.Controls.Add(this.panelMenuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SistemaDeInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenuLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparatorMenuLateral)).EndInit();
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            this.panelSubEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Panel panelSubEncabezado;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Label labelHeaderUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private ComponentFactory.Krypton.Toolkit.KryptonSeparator kryptonSeparatorMenuLateral;
        private System.Windows.Forms.Button buttonAgregarMenu;
        private System.Windows.Forms.Button buttonCerrarSesionMenu;
        private System.Windows.Forms.Button buttonHerramientasMenu;
        private System.Windows.Forms.Button buttonReporteMenu;
        private System.Windows.Forms.Button buttonVentaMenu;
        private System.Windows.Forms.Button buttonInventarioMenu;
        private System.Windows.Forms.Button buttonLogoMenu;
        private System.Windows.Forms.PictureBox pictureBoxMinimizarVentana;
        private System.Windows.Forms.PictureBox pictureBoxCerrarVentana;
    }
}


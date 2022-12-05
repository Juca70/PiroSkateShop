using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Pyroskateshop_Inventory_System
{
    public partial class SistemaDeInventario : Form
    {
        public SistemaDeInventario()
        {
            InitializeComponent();
            AbrirFormulario(new Inicio());
        }

        // Movimiento de la ventana

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Abrir formularios en el panel contenedor

        private void AbrirFormulario(Object Formhijo)
        {
            if (this.panelContenido.Controls.Count > 0)
                this.panelContenido.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenido.Controls.Add(fh);
            this.panelContenido.Tag = fh;
            fh.Show();
        }

        private void buttonAgregarMenu_Click(object sender, System.EventArgs e)
        {
            AbrirFormulario(new AgregarArticulo());
        }

        private void buttonLogoMenu_Click(object sender, System.EventArgs e)
        {
            AbrirFormulario(new Inicio());
        }

        private void pictureBoxMinimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxCerrarVentana_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonInventarioMenu_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Inventario());
        }
    }
}

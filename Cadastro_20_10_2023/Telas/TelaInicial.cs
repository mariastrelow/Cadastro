using Guna.UI2.WinForms.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_20_10_2023
{
    public partial class TelaInicial : Form
    {
        bool sidebearExpand;
        public TelaInicial()
        {
            InitializeComponent();
        }
        private static TelaInicial instanciaForm1 = null;

        public void AbrirFormulario(Form formulario)
        {
            if (this.panelChildForm.Controls.Count > 0)
            {
                this.panelChildForm.Controls.RemoveAt(0);
            }

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            this.panelChildForm.Controls.Add(formulario);
            formulario.Show();

        }
        private void menu_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            TelaCadastroFuncionario T = new TelaCadastroFuncionario();
            T.Show();
            this.Hide();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ListaFuncionario T = new ListaFuncionario();
            T.Show();
            this.Hide();
        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuTrans_Tick(object sender, EventArgs e)
        {

            if (sidebarExpand == false)
            {
                sidebear.Width -= 100;
                if (menuContainer.Height == 251)
                {
                    menuTrans.Stop();
                    sidebarExpand = true;
                }
                else
                {
                    menuContainer.Height -= 10;
                    if (sidebear.Height <= 50)
                    {
                        menuTrans.Stop();
                        sidebarExpand = false;
                    }
                }
            }
        }
        private void selecionado_Click(object sender, EventArgs e)
        {
            sidebarTrans.Start();
        }
        bool sidebarExpand = true;
        private void sidebarTrans_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebear.Width -= 10;
                if (selecionado.Width <= 50)
                {
                    sidebarExpand = false;
                    sidebarTrans.Stop();
                }
            }
            else
            {
                sidebear.Width += 10;
                if (sidebear.Width >= 251)
                {
                    sidebarExpand = true;
                    sidebarTrans.Stop();
                }
            }
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ListaFuncionario());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new TelaCadastroFuncionario());
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void sidebear_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new TelaCadastroEmpresa());
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ListaEmpresa());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }
    }
}

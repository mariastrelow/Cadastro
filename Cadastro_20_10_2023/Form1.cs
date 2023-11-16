namespace Loja_de_Eletronicos
{
    public partial class Form1 : Form
    {
        bool transicao;
        public Form1()
        {   
            InitializeComponent();

        }

        private static Form1 instanciaForm1 = null;

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
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialg = new DialogResult();
            dialg = MessageBox.Show("Deseja mesmo sair?", "Alerta!", MessageBoxButtons.YesNo);

            if (dialg == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                AbrirFormulario(new Cadastrar_Produto());

            }
            this.Visible = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

     

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1menu_Paint(object sender, PaintEventArgs e)
        {

        }


        private void flowLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
         
        private void button2_Click_3(object sender, EventArgs e)
        {
            DialogResult dialg = new DialogResult();
            dialg = MessageBox.Show("Deseja mesmo sair?", "Alerta!", MessageBoxButtons.YesNo);

            if (dialg == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }



        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Form3_VisualizarEstoque());
        }

        private void menu_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (transicao == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height == 334)
                {                   
                    menuTrans.Stop();
                    transicao = true;
                }
                else
                {
                    menuContainer.Height  -= 10;
                    if (panelSideMenu.Height <= 100)
                    {                      
                        menuTrans.Stop();
                        transicao = false;
                    }
                    
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTrans.Start();
        }
        bool sidebarExpand = true;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panelSideMenu.Width = 10;
                if (selecionado.Width <= 100)
                {
                    sidebarExpand = false;
                    sidebarTrans.Stop();
                }
            }
            else
            {
                panelSideMenu.Width += 10;
                if (panelSideMenu.Width >= 334)
                {
                    sidebarExpand = true;
                    sidebarTrans.Stop();
                }
            }
        }

        private void flowLayoutPanel2_Paint_2(object sender, PaintEventArgs e)
        {

        }
   
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Form2_RealizarVenda());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Cadastrar_Produto());
        }

        private void menu_Click(object sender, EventArgs e)
        {
            if (instanciaForm1 == null || instanciaForm1.IsDisposed)
            {
                instanciaForm1 = new Form1();
                instanciaForm1.Show();
            }   
        }

        private void sidebar_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
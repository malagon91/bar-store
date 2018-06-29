using System;
using System.Windows.Forms;
using Bar_Store.Clases;
using Bar_Store.Negocios;

namespace Bar_Store.Presentacion
{
    public partial class main : Form
    {
        public User userInfo = new User();

        public main()
        {
            InitializeComponent();
        }
       public void initForm(User use)
        {
            userInfo = use;
            bUsers.Visible = false;
            bInventory.Visible = false;
            txtOpcion.Text = $"Bienvenido a la tienda {use.Name}";
            if (use.Role  == "ADMIN")
            {
                bUsers.Visible = true;
                bInventory.Visible = true;

            }
        }

        private void main_Load(object sender, EventArgs e)
        {
           // if (user.Login == null)
              //  Application.Exit();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void bUsers_Click(object sender, EventArgs e)
        {
            QuitaForma();
            user form = new user();
            InsertaEnDock(form);
        }

        private void InsertaEnDock(Form xForma)
        {
            xForma.TopLevel = false;
            xForma.FormBorderStyle = FormBorderStyle.None;
            xForma.Dock = DockStyle.Fill;
            this.panel.Controls.Add(xForma);
            this.Tag = xForma;

            xForma.Show();
        }

        public void QuitaForma()
        {
            if (panel.Controls.Count > 0)
            {
                panel.Controls.RemoveAt(0);
            }
            
        }

    }
}

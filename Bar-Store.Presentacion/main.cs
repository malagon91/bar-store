using System;
using System.Windows.Forms;
using Bar_Store.Clases;
using Bar_Store.Negocios;

namespace Bar_Store.Presentacion
{
    public partial class main : Form
    {
        public User user = new User();

        public main()
        {
            InitializeComponent();
        }
       public void initForm(User use)
        {
            txtOpcion.Text = $"Bienvenido a la tienda {use.Name}";
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
    }
}

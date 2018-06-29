using System;
using System.Windows.Forms;
using Bar_Store.Clases;
using Bar_Store.Negocios;

namespace Bar_Store.Presentacion
{
    public partial class login : Form
    {
        Negocio controller = new Negocio();
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            //clear();
        }
        private void clear()
        {
            tUser.Clear();
            tPass.Clear();
            tUser.Focus();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            try
            {
               if(tUser.Text != "" & tPass.Text != "")
                {
                    User user = controller.login(tUser.Text, tPass.Text);
                    if (user.Login != null)
                    {
                      
                        main menu = new main();
                        menu.initForm(user);
                        menu.Show();
                      
                    }
                    else
                        MessageBox.Show($"el usuario o contraseña no existen", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar sesion, Error: {ex.Message}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bar_Store.Negocios;
using Bar_Store.Clases;

namespace Bar_Store.Presentacion
{
    public partial class user : Form
    {
        Negocio controller = new Negocio();
        public user()
        {
            InitializeComponent();
        }

        private void user_Load(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            tLogin.Clear();
            tPass.Clear();
            tName.Clear();
            cAdmin.Checked = false;
            bSave.Enabled = false;
            bDelete.Enabled = false;
            dgv.DataSource = controller.getUsers();
            dgv.Columns[1].Visible = false;
            dgv.Columns[2].Width = 200;
        }
        public void ValidTxt()
        {
            if (tLogin.Text != "" & tPass.Text != "" & tName.Text != "")
            {
                bSave.Enabled = true;
            }
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                bDelete.Enabled = true;
                bSave.Enabled = false;
                tLogin.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
                tPass.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                tName.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
                cAdmin.Checked = dgv.SelectedRows[0].Cells[3].Value.ToString() == "ADMIN";
            }

        }

        private void tLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidTxt();
        }

        private void tName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidTxt();
        }

        private void tPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidTxt();
        }

        private void cAdmin_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (tLogin.Text != "" & tPass.Text != "" & tName.Text != "")
            {
                try
                {
                    User tmp = new User();
                    tmp.Login = tLogin.Text;
                    tmp.Name = tName.Text;
                    tmp.Pass = tPass.Text;
                    tmp.Role = cAdmin.Checked ? "1" : "2";
                    bool isNew = controller.getUser(tmp.Login).Login == null;
                    controller.saveUser(tmp, isNew);
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la info, Error: {ex.Message}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"llena todos los campos por favor", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0 & tLogin.Text != "")
            {
                try
                {
                    controller.deleteUser(tLogin.Text);
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la info, Error: {ex.Message}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cAdmin_Click(object sender, EventArgs e)
        {
            ValidTxt();
        }
    }
}

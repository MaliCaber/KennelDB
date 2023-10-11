using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace KennelDB
{
    public partial class LoginPage : MaterialForm
    {
        public LoginPage()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbUser.Text = "Username";
            tbPass.Text = "Password";
            tbUser.ForeColor = Color.LightGray;
            tbPass.ForeColor = Color.LightGray;
        }

        private void tbUser_Enter(object sender, EventArgs e)
        {
            if (tbUser.Text == "Username")
            {
                tbUser.Text = "";
                tbUser.ForeColor = Color.Black;
            }
        }

        private void tbUser_Leave(object sender, EventArgs e)
        {
            if (tbUser.Text == "")
            {
                tbUser.Text = "Username";
                tbUser.ForeColor = Color.LightGray;
            }
        }

        private void tbPass_Enter(object sender, EventArgs e)
        {
            if (tbPass.Text == "Password")
            {
                tbPass.Text = "";
                tbPass.ForeColor = Color.Black;
            }
        }

        private void tbPass_Leave(object sender, EventArgs e)
        {
            if (tbPass.Text == "")
            {
                tbPass.Text = "Password";
                tbPass.ForeColor = Color.LightGray;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            
            Home home = new Home(this);
            home.Show();
            this.Close();
        }
    }
}

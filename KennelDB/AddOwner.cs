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
using System.Data.SQLite;
using System.Configuration;
using Dapper;

namespace KennelDB
{
    public partial class AddOwner : MaterialForm
    {
        Home home;
        public AddOwner(Home hm)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            home = hm;
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        private void AddOwner_Load(object sender, EventArgs e)
        {
            tbOwnerName.Text = "";
        }

        private void btnInsertOwner_Click(object sender, EventArgs e)
        {
            try
            {
                string ownerName = tbOwnerName.Text; // Get owner name from a TextBox

                if (ownerName != "")
                {
                    using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
                    {
                        string insertOwnerQuery = "INSERT INTO Owners (OwnerName) VALUES (@OwnerName)";
                        using (SQLiteCommand ownerCommand = new SQLiteCommand(insertOwnerQuery, con))
                        {
                            ownerCommand.Parameters.AddWithValue("@OwnerName", ownerName);
                            con.Open();
                            // Execute the insert command for the owner
                            ownerCommand.ExecuteNonQuery();

                            MessageBox.Show("Owner added successfully.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter an owner name.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            home.PopulateOwners();
            this.Close();
        }
    }
}

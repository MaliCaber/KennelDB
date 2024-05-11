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
    public partial class AddVaccineToListForm : MaterialForm
    {
        Home home;
        public AddVaccineToListForm(Home hm)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            home = hm;
        }

        private void AddVaccineToListForm_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertVaccine_Click(object sender, EventArgs e)
        {
            // Gather details from the input fields
            string vaccineName = tbNameOfVaccine.Text;
            DateTime vaccinationDate = dtpDOV.Value;

            // Add the vaccine to the list
            Vaccine vaccine = new Vaccine(vaccineName, vaccinationDate);
            home.PopulateVaccineList(vaccine);
            // Clear input fields or update the UI as needed
            tbNameOfVaccine.Clear();
            // ... other necessary updates to the UI

            MessageBox.Show("Vaccine added successfully!"); // Optional: Show a confirmation message
            this.Close();
        }
    }
}

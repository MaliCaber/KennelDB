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
using System.Security.Cryptography;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace KennelDB
{
    public partial class Home : MaterialForm
    {



        private Dog selectedDog;
        private List<Dog> dogsList;
        private List<OwnerItem> ownersList;
        private List<OwnerItem> ownersOfSelectedDog;
        public Home()
        {
            InitializeComponent();

            cbEnableEditing.Checked = true;
            cbEnableEditing.Checked = false;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        private void Home_Load(object sender, EventArgs e)
        {

            
            LoadOwnersCheckBoxList();
            LoadListBoxData();
            PopulateOwners();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoadListBoxData()
        {
            dogsList = GetDogsFromDatabase();

            // Clear existing items
            listbSearch.Items.Clear();

            // Add dogs' names to the ListBox
            foreach (var dog in dogsList)
            {
                listbSearch.Items.Add(dog);
            }
        }

        private List<Dog> GetDogsFromDatabase()
        {
            List<Dog> dogs = new List<Dog>();

            // Query the database to get the list of dogs
            string selectQuery = "SELECT DogID, Name FROM DogPedigree";
            using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectQuery, con))
                using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dog dog = new Dog
                        {
                            DogID = Convert.ToInt32(reader["DogID"]),
                            Name = reader["Name"].ToString()
                        };

                        dogs.Add(dog);
                    }
                }
            }

            return dogs;
        }

        private void LoadOwnersCheckBoxList()
        {
            ownersList = GetOwnersFromDatabase();

            // Clear existing items
            cblHOwners.Items.Clear();

            // Add owners to the CheckBoxList
            foreach (var owner in ownersList)
            {
                cblHOwners.Items.Add(owner);
            }
        }

        private List<OwnerItem> GetOwnersFromDatabase()
        {
            List<OwnerItem> owners = new List<OwnerItem>();

            // Query the database to get the list of owners
            string selectQuery = "SELECT OwnerID, OwnerName FROM Owners";
            using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectQuery, con))
                using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        OwnerItem owner = new OwnerItem
                        (
                            Convert.ToInt32(reader["OwnerID"]),
                            reader["OwnerName"].ToString()
                        );

                        owners.Add(owner);
                    }
                }
            }

            return owners;
        }

        
        

        

        

        private void DisplayDetailedInformation(int dogID)
        {
            // Query the database to fetch detailed information for the selected dog
            string selectDetailedQuery = "SELECT * FROM DogPedigree WHERE DogID = @DogID";
            using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                using (SQLiteCommand selectDetailedCommand = new SQLiteCommand(selectDetailedQuery, con))
                {
                    selectDetailedCommand.Parameters.AddWithValue("@DogID", dogID);
                    con.Open();
                    using (SQLiteDataReader reader = selectDetailedCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tbHName.Text = reader["Name"].ToString();
                            tbHRN.Text = reader["RegistrationNumber"].ToString();
                            tbHMC.Text = reader["MicrochipTattooID"].ToString();
                            tbHBreed.Text = reader["Breed"].ToString();
                            dtpHDOB.Value = DateTime.Parse(reader["DateOfBirth"].ToString());
                            tbHCoat.Text = reader["CoatType"].ToString();
                            tbHColor.Text = reader["Color"].ToString();
                            tbHMarkings.Text = reader["Markings"].ToString();
                            if (reader["Sex"].ToString() == "Male")
                            {
                                rbHMale.Checked = true;
                                rbHFemale.Checked = false;
                            }
                            else
                            {
                                rbHMale.Checked = false;
                                rbHFemale.Checked = true;
                            }
                            tbHSire.Text = reader["SireName"].ToString();
                            tbHDam.Text = reader["DamName"].ToString();
                            tbHBreeder.Text = reader["BreederName"].ToString();
                            dtpHDOR.Value = DateTime.Parse(reader["DateOfRegistration"].ToString());
                            tbHKennelClub.Text = reader["KennelClub"].ToString();
                            
                        }
                    }
                }
            }
            
        }


        private void btnAddDog_Click(object sender, EventArgs e)
        {
            string sex = "Male";
            if (rbMale.Checked)
            {
                sex = "Male";
            }
            else 
            {
                sex = "Female";
            }
            try
            {
                // Define your insert query
                string insertQuery = "INSERT INTO DogPedigree (Name, RegistrationNumber, Breed, DateOfBirth, CoatType, Color, Markings, Sex, SireName, DamName, BreederName, DateOfRegistration, MicrochipTattooID, KennelClub) " +
                                     "VALUES (@Name, @RegistrationNumber, @Breed, @DateOfBirth, @CoatType, @Color, @Markings, @Sex, @SireName, @DamName, @BreederName, @DateOfRegistration, @MicrochipTattooID, @KennelClub)";

                using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
                {
                    using (SQLiteCommand sqlCommand = new SQLiteCommand(insertQuery, con))
                    {
                        // Set parameters from your input fields
                        sqlCommand.Parameters.AddWithValue("@Name", tbName.Text);
                        sqlCommand.Parameters.AddWithValue("@RegistrationNumber", tbRN.Text);
                        sqlCommand.Parameters.AddWithValue("@Breed", tbBreed.Text);
                        sqlCommand.Parameters.AddWithValue("@DateOfBirth", dtpDOB.Value);
                        sqlCommand.Parameters.AddWithValue("@CoatType", tbCoat.Text);
                        sqlCommand.Parameters.AddWithValue("@Color", tbColor.Text);
                        sqlCommand.Parameters.AddWithValue("@Markings", tbMarkings.Text);
                        sqlCommand.Parameters.AddWithValue("@Sex", sex);
                        sqlCommand.Parameters.AddWithValue("@SireName", tbSire.Text);
                        sqlCommand.Parameters.AddWithValue("@DamName", tbDam.Text);
                        sqlCommand.Parameters.AddWithValue("@BreederName", tbBreeder.Text);
                        sqlCommand.Parameters.AddWithValue("@DateOfRegistration", dtpDOR.Value);
                        sqlCommand.Parameters.AddWithValue("@MicrochipTattooID", tbMC.Text);
                        sqlCommand.Parameters.AddWithValue("@KennelClub", tbKennelClub.Text);

                        con.Open();
                        // Execute the insert command
                        sqlCommand.ExecuteNonQuery();

                        
                    }
                }

                string selectDogIDQuery = "SELECT DogID FROM DogPedigree WHERE RegistrationNumber = @RegistrationNumber AND MicrochipTattooID = @MicrochipTattooID";
                long dogID;

                using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
                {
                    using (SQLiteCommand selectDogIDCommand = new SQLiteCommand(selectDogIDQuery, con))
                    {
                        selectDogIDCommand.Parameters.AddWithValue("@RegistrationNumber", tbRN.Text);
                        selectDogIDCommand.Parameters.AddWithValue("@MicrochipTattooID", tbMC.Text);
                        con.Open();
                        dogID = (long)selectDogIDCommand.ExecuteScalar();
                    }
                }

                foreach (OwnerItem ownerItem in cblOwners.CheckedItems)
                {
                    int ownerID = ownerItem.OwnerID;
                    // Insert a record in the DogOwner table to link the dog to the owner
                    string insertDogOwnerQuery = "INSERT INTO DogOwner (DogID, OwnerID) VALUES (@DogID, @OwnerID)";

                    using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
                    {
                        using (SQLiteCommand dogOwnerCommand = new SQLiteCommand(insertDogOwnerQuery, con))
                        {
                            dogOwnerCommand.Parameters.AddWithValue("@DogID", dogID);
                            dogOwnerCommand.Parameters.AddWithValue("@OwnerID", ownerID);
                            con.Open();
                            // Execute the insert command for the DogOwner relationship
                            dogOwnerCommand.ExecuteNonQuery();
                        }
                    }
                }

                string insertVaccineQuery = "INSERT INTO Vaccinations (DogID, VaccineName, VaccinationDate) VALUES (@DogID, @VaccineName, @VaccinationDate)";
                foreach (Vaccine vaccine in listbVaccines.Items)
                {
                    using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
                    {
                        con.Open();
                        using (SQLiteCommand insertVaccineCommand = new SQLiteCommand(insertVaccineQuery, con))
                        {
                            insertVaccineCommand.Parameters.AddWithValue("@DogID", dogID);
                            insertVaccineCommand.Parameters.AddWithValue("@VaccineName", vaccine.VaccineName);
                            insertVaccineCommand.Parameters.AddWithValue("@VaccinationDate", vaccine.VaccinationDate);

                            insertVaccineCommand.ExecuteNonQuery();
                        }
                    }
                }

                EraseDataFromAddDog();
                MessageBox.Show("Dog pedigree added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void EraseDataFromAddDog()
        {
            tbName.Text = "";
            tbRN.Text = "";
            tbMC.Text = "";
            tbBreed.Text = "";
            dtpDOB.ResetText();
            tbCoat.Text = "";
            tbColor.Text = "";
            tbMarkings.Text = "";
            rbMale.Checked = true;
            rbFemale.Checked = false;
            tbSire.Text = "";
            tbDam.Text = "";
            tbBreeder.Text = "";
            dtpDOR.ResetText();
            tbKennelClub.Text = "";
            for (int i = 0; i < cblOwners.Items.Count; i++)
            {
                cblOwners.SetItemChecked(i, false);
            }
            listbVaccines.Items.Clear();
        }

        public void PopulateOwners()
        {
            cblOwners.Items.Clear();
            string selectOwnersQuery = "SELECT OwnerID, OwnerName FROM Owners";
            using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                using (SQLiteCommand selectOwnersCommand = new SQLiteCommand(selectOwnersQuery, con))
                {
                    using (SQLiteDataReader reader = selectOwnersCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int ownerID = reader.GetInt32(0);
                            string ownerName = reader.GetString(1);
                            OwnerItem ownerItem = new OwnerItem(ownerID, ownerName);
                            cblOwners.Items.Add(ownerItem);
                        }
                    }
                }
            }
        }

        private void btnAddOwnersToListOfOwners_Click(object sender, EventArgs e)
        {
            AddOwner ao = new AddOwner(this);
            ao.Show();
        }

        private List<OwnerItem> GetOwnersOfDog(int dogID)
        {
            List<OwnerItem> owners = new List<OwnerItem>();

            // Query the database to get the owners associated with the dog
            string selectQuery = "SELECT Owners.OwnerID, Owners.OwnerName " +
                                 "FROM Owners " +
                                 "JOIN DogOwner ON Owners.OwnerID = DogOwner.OwnerID " +
                                 "WHERE DogOwner.DogID = @DogID";

            using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectQuery, con))
                {
                    selectCommand.Parameters.AddWithValue("@DogID", dogID);

                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OwnerItem owner = new OwnerItem(Convert.ToInt32(reader["OwnerID"]), reader["OwnerName"].ToString());
                            owners.Add(owner);
                        }
                    }
                }
            }

            return owners;
        }

        private void MarkOwnersInCheckBoxList()
        {
            // Clear existing marks
            for (int i = 0; i < cblHOwners.Items.Count; i++)
            {
                cblHOwners.SetItemChecked(i, false);
            }

            // Mark owners associated with the selected dog
            foreach (var owner in ownersOfSelectedDog)
            {
                int index = cblHOwners.FindString(owner.OwnerName);
                if (index != ListBox.NoMatches)
                {
                    cblHOwners.SetItemChecked(index, true);
                }
            }
        }

        private void cbEnableEditing_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnableEditing.Checked)
            {
                btnHSave.Enabled = cbEnableEditing.Checked;
                tbHName.ReadOnly = cbEnableEditing.Checked;
                tbHRN.ReadOnly = cbEnableEditing.Checked;
                tbHMC.ReadOnly = cbEnableEditing.Checked;
                tbHBreed.ReadOnly = cbEnableEditing.Checked;
                dtpHDOB.Enabled = cbEnableEditing.Checked;
                tbHCoat.Enabled = cbEnableEditing.Checked;
                tbHColor.ReadOnly = cbEnableEditing.Checked;
                tbHMarkings.ReadOnly = cbEnableEditing.Checked;
                rbHMale.Enabled = cbEnableEditing.Checked;
                rbHFemale.Enabled = cbEnableEditing.Checked;
                tbHSire.ReadOnly = cbEnableEditing.Checked;
                tbHDam.ReadOnly = cbEnableEditing.Checked;
                tbHBreeder.ReadOnly = cbEnableEditing.Checked;
                dtpHDOR.Enabled = cbEnableEditing.Checked;
                tbHKennelClub.ReadOnly = cbEnableEditing.Checked;
                cblHOwners.Enabled = cbEnableEditing.Checked;
                listbHVaccines.Enabled = cbEnableEditing.Checked;
            }
            else
            {
                btnHSave.Enabled = false;
                tbHName.ReadOnly = false;
                tbHRN.ReadOnly = false;
                tbHMC.ReadOnly = false;
                tbHBreed.ReadOnly = false;
                dtpHDOB.Enabled = false;
                tbHCoat.ReadOnly = false;
                tbHColor.ReadOnly = false;
                tbHMarkings.ReadOnly = false;
                rbHMale.Enabled = false;
                rbHFemale.Enabled = false;
                tbHSire.ReadOnly = false;
                tbHDam.ReadOnly = false;
                tbHBreeder.ReadOnly = false;
                dtpHDOR.Enabled = false;
                tbHKennelClub.ReadOnly = false;
                cblHOwners.Enabled = false;
                listbHVaccines.Enabled = false;
            }
        }

        private List<Vaccine> GetVaccinesForDog(int dogID)
        {
            // Your database retrieval logic to fetch vaccines for the dog with 'dogID'
            // Implement the logic to query the database and retrieve the vaccines associated with the selected dog

            // Example of fetching vaccines for the dog from the database
            // This is a simplified version; replace it with your database query
            List<Vaccine> vaccines = new List<Vaccine>();
            string query = "SELECT VaccineName, VaccinationDate FROM Vaccinations WHERE DogID = @DogID";

            using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, con))
                {
                    command.Parameters.AddWithValue("@DogID", dogID);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string vaccineName = reader["VaccineName"].ToString();
                            DateTime vaccinationDate = Convert.ToDateTime(reader["VaccinationDate"]);

                            vaccines.Add(new Vaccine (vaccineName, vaccinationDate));
                        }
                    }
                }
            }

            return vaccines;
        }

        private void SearchDogAndDisplayVaccines(int dogID)
        {
            // Fetch the vaccines for the selected dog
            List<Vaccine> dogVaccines = GetVaccinesForDog(dogID);

            // Assuming 'vaccineListBox' is the ListBox control on your form
            listbHVaccines.Items.Clear(); // Clear existing items

            // Display the fetched vaccines in the ListBox
            foreach (var vaccine in dogVaccines)
            {
                listbHVaccines.Items.Add($"{vaccine.VaccineName} - {vaccine.VaccinationDate.ToShortDateString()}");
                // Customize the display format as needed
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = tbSearch.Text.ToLower();
            List<Dog> filteredDogs = dogsList.Where(dog => dog.Name.ToLower().Contains(searchTerm)).ToList();

            // Clear existing items
            listbSearch.Items.Clear();

            // Add filtered dogs' names to the ListBox
            foreach (var dog in filteredDogs)
            {
                listbSearch.Items.Add(dog);
            }
        }

        private void listbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDog = listbSearch.SelectedItem as Dog;
            if (selectedDog != null)
            {
                // Fetch detailed information for the selected dog
                DisplayDetailedInformation(selectedDog.DogID);

                ownersOfSelectedDog = GetOwnersOfDog(selectedDog.DogID);
                // Mark owners in the CheckBoxList
                MarkOwnersInCheckBoxList();
                SearchDogAndDisplayVaccines(selectedDog.DogID);
            }
        }

        public void PopulateVaccineList(Vaccine vaccine)
        {
            listbVaccines.Items.Add(vaccine);
        }

        private void btnAddVaccines_Click_1(object sender, EventArgs e)
        {
            AddVaccineToListForm addVaccineToListForm = new AddVaccineToListForm(this);
            addVaccineToListForm.Show();
        }
    }
}

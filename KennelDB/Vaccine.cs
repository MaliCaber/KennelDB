using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KennelDB
{
    public class Vaccine
    {
        public Vaccine(string vaccineName, DateTime vaccinationDate)
        {
            VaccineName = vaccineName;
            VaccinationDate = vaccinationDate;
        }

        public int VaccineID { get; set; }
        public string VaccineName { get; set; }
        public DateTime VaccinationDate { get; set; }

        public override string ToString()
        {
            return VaccineName;
        }
    }
}

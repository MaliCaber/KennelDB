using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelDB
{
    public class OwnerItem
    {
        public int OwnerID { get; set; }
        public string OwnerName { get; set; }

        public OwnerItem(int ownerID, string ownerName)
        {
            OwnerID = ownerID;
            OwnerName = ownerName;
        }

        public override string ToString()
        {
            return OwnerName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_6
{
    public class SickPerson
    {
        public string Virus { get; set; }
        public string Name { get; set; }


        public void Recover(IMedication medication)
        {
            Console.WriteLine(Name + " recovered from " + Virus + " with the help of " + medication.Cure());
        }
    }
}

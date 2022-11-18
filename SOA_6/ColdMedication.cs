using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_6
{
    public class ColdMedication:IMedication
    {
        string TypeOfPills { get; set; } = "hah";

        int NumberOfPills { get; set; } = 3;

        private void TakePills()
        {
            Console.WriteLine(TypeOfPills);
        }
        public string Cure()
        {
            TakePills();
            return $"{TypeOfPills} in {NumberOfPills} pills";
        }
    }
}

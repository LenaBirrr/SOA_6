using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_6
{
    public class ColdMedication:PlagueMedication
    {
        string TypeOfPills { get; set; } = "hah";

        int NumberOfPills { get; set; } = 3;

        public override void TakePills()
        {
            Console.WriteLine(TypeOfPills);
        }

        public override void TakeInjections()
        {
            throw new NotImplementedException();
        }
        public override string Cure()
        {
            return $"{TypeOfPills} in {NumberOfPills} pills";
        }
    }
}

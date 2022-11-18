using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_6
{
    public class PlagueMedication:IMedication
    {
        string TypeOfPills { get; set; } = "meh";
        string TypeOfInjections { get; set; } = "kol";

        int NumberOfPills { get; set; } = 3;
        int NumberOfInjections { get; set; } = 2;
        private void TakePills()
        {
            Console.WriteLine(TypeOfPills);
        }
        private void TakeInjections()
        {
            Console.WriteLine(TypeOfInjections);
        }
        public string Cure()
        {
            TakePills();
            TakeInjections();
            return $"{TypeOfPills} in {NumberOfPills} pills and {TypeOfInjections} in {NumberOfInjections} injections";
        }
    }
}

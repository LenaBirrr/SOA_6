using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_6
{
    public class PlagueMedication
    {
        string TypeOfPills { get; set; } = "meh";
        string TypeOfInjections { get; set; } = "kol";

        int NumberOfPills { get; set; } = 3;
        int NumberOfInjections { get; set; } = 2;

        public virtual void TakePills()
        {
            Console.WriteLine(TypeOfPills);
        }
        public virtual void TakeInjections()
        {
            Console.WriteLine(TypeOfInjections);
        }
        public virtual string Cure()
        {
            return $"{TypeOfPills} in {NumberOfPills} pills and {TypeOfInjections} in {NumberOfInjections} injections";
        }
    }
}

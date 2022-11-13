using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_6
{
    public class PlagueMedication:IMedication
    {
        public string Cure()
        {
            return "intravenous chloramphenicol with streptomycin";
        }
    }
}

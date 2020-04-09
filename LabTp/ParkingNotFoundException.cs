using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTp
{
    public class ParkingNotFoundException : Exception
    {
        public ParkingNotFoundException(int i) : base("Не найден самолет по месту "
       + i)
        { }
    }
}


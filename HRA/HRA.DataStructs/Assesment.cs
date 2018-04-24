using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRA.DataStructs
{
    class Assesment
    {
        public int ID { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime EndDate { get; set; }
        public int PositionProgreeId { get; set; }
    }
}

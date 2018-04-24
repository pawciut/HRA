using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRA.DataStructs
{
    class Notes
    {
        public int ID { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public bool IsPublic { get; set; }
    }
}

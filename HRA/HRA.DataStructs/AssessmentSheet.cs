using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRA.DataStructs
{
    class AssessmentSheet
    {
        public int ID { get; set; }
        public int AssessmentId { get; set; }
        public int Typ { get; set; }
        public DateTime Created { get; set; }
        public DateTime CreatedBy { get; set; }
    }
}

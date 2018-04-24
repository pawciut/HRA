using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRA.DataStructs
{
    class Task
    {
        public int ID { get; set; }
        public int PositionProgressId { get; set; }
        public string Description { get; set; }
        public int PositionRequirementId { get; set; }
        public bool IsFinished { get; set; }
        public string Result { get; set; }
        public int AcceptedBy { get; set; }
    }
}

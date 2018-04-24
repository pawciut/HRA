using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRA.DataStructs
{
    public class AssessmentSheetTask
    {
        public int TaskId { get; set; }
        public int AssesmenSheetId { get; set; }
        public bool Result { get; set; }
        public string AdditionalInfo { get; set; }
    }
}

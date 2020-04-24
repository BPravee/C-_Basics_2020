using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
   public  class PatientDataValidator
    {
        ConsoleLogger _logger = new ConsoleLogger();
        public bool Validate(string mrn,string email,string name,string contactNumber)
        {
            if (string.IsNullOrEmpty(mrn))
            {
                //Log
                _logger.Write("MRN Invalid");
            }
            return false;

        }
            
    }
}

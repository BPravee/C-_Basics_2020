using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    public class PatientInfoDataModel
    {
        #region Private Data Members (Fields) , state - allocated in Heap
        private string _mrn;
        private string _name;
        private string _email;
        private string _phoneNumber;
        #endregion

        #region Constructors
        //Constructor is a function
        //Constructor Name is same as TypeName
        //Constructor By Default return void (implicit)
        //constructor can  be overloaded
        //constructor can call another contructor

            //Default Constructor - Argument Lenght = 0
        public PatientInfoDataModel()
        {
            System.Random _randomgenerator = new Random();
         //  string autoMrn = "MRN" + _randomgenerator.Next(1, 1000);
         //New Grammer String Interpollation - Dontnet Fx 4.5 + 
         string automMrn= $"MRN{_randomgenerator.Next()}";

            this._mrn = automMrn;
            this._name = default(string);
            this._email = default(string);
            this._phoneNumber = default(string);

        }

        public PatientInfoDataModel(string mrn,string name,string contactNumber):this()
        {
            this._mrn = mrn;
            this._name = name;
            this._phoneNumber = contactNumber;
        }

        public PatientInfoDataModel(string mrn,string name,string email,string contactNumber):this(mrn,name,contactNumber)
        {
            this._email = email;
           
        }
        #endregion

        #region Mutators / Methods

        //public string Get_mrn()
        //{
        //    return this._mrn;

        //}
        //public void Set_email(string value)
        //{
        //    this._email = value;
        //}
        //public string Get_email() { return this._email;  }

        #endregion

        #region Properties - smart data Fields
        public string MRN
        {
            get { return this._mrn; }
        }
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        public string ContactNumber
        {
            get { return this._phoneNumber; }
            set { this._phoneNumber = value; }
        }
        #endregion
    }
}

using System;

namespace App.Con
{
    public class HumanBeing
    {
        #region Constructors

        //1. Constructors
        //special function
        //Run only once in its lifetime
        //has no return type
        //Name same as that of class
        //ccan be overloaded
        //main use: to provide / inject default values

        public HumanBeing()
        {
        }

        public HumanBeing(string name)
        {
            _fname = name;
        }

        public HumanBeing(string name, string email)
        {
        }

        #endregion Constructors

        #region Destructors

        //2. Destructor
        //we donot write
        //only one
        ~HumanBeing()
        {
            _fname = string.Empty;
        }

        #endregion Destructors

        //3. Variables

        private int age = 0;

        //4. Properties
        private string _fname = "Babu";

        public string FirstName
        {
            get { return _fname; }
            set { _fname = value; }
        }

        public string LastName { get; set; }
        //5. Methods / Functions

        public void Eat()
        {
            Console.WriteLine($"{this.GetHashCode()} is eating");
        }

        public void DisplayIdentity()
        {
            StudentInfo s1 = new StudentInfo("Samir", "", "Maharjan");
            s1.MathMarks = 40;
            s1.ScienceMarks = 40;
            StudentInfo s2 = new StudentInfo("Samir", "", "Maharjan");
            s2.MathMarks = 50;
            s2.ScienceMarks = 50;
            StudentInfo s3 = new StudentInfo("Samir", "", "Maharjan");
            s3.MathMarks = 50;
            s3.ScienceMarks = 50;

            var rres = s1 + s2 + s3;

            Console.WriteLine(this._fname);
        }

        public void SetName(string name)
        {
            _fname = name;
        }
    }
}
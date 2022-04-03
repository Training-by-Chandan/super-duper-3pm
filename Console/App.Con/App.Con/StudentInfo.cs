using System;

namespace App.Con
{
    public class StudentInfo
    {
        public StudentInfo()
        {
        }

        public StudentInfo(string firstname, string middlename, string lastname)
        {
            FirstName = firstname;
            MiddleName = middlename;
            LastName = lastname;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public string FullName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(MiddleName))
                    return $"{FirstName} {LastName}";
                else
                    return $"{FirstName} {MiddleName} {LastName}";
            }
        }

        private float _math;

        public float MathMarks
        {
            get { return _math; }
            set
            {
                if (value > 100)
                {
                    _math = 100;
                }
                else if (value < 0)
                {
                    _math = 0;
                }
                else
                {
                    _math = value;
                }
            }
        }

        private float _science;

        public float ScienceMarks
        {
            get { return _science; }
            set
            {
                _science = value > 100 ? 100 : value < 0 ? 0 : value;
            }
        }

        public float Total
        {
            get
            {
                return MathMarks + ScienceMarks;
            }
        }

        public float Percentage
        {
            get
            {
                return Total / 2;
            }
        }

        public string Division
        {
            get
            {
                if (Percentage > 80) return "Distinction";
                else if (Percentage > 60) return "First Division";
                else if (Percentage > 45) return "Second Division";
                else if (Percentage > 32) return "Third Division";
                else return "Fail";
            }
        }
    }
}
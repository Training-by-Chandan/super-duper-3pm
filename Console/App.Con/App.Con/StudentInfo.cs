using System;

namespace App.Con
{
    public class StudentInfo
    {
        public StudentInfo()
        {
            _fullMarks = 100;
            _passMarks = 32;
        }

        public StudentInfo(string firstname, string middlename, string lastname)
        {
            _fullMarks = 100;
            _passMarks = 32;
            FirstName = firstname;
            MiddleName = middlename;
            LastName = lastname;
        }

        public StudentInfo(double fullmarks, double passmarks)
        {
            _fullMarks = fullmarks;
            _passMarks = passmarks;
        }

        public StudentInfo(double fullmarks, double passmarks, string firstname, string middlename, string lastname)
        {
            _fullMarks = fullmarks;
            _passMarks = passmarks;
            FirstName = firstname;
            MiddleName = middlename;
            LastName = lastname;
        }

        private double _fullMarks;
        public double FullMarks => _fullMarks;
        private double _passMarks;
        public double PassMarks => _passMarks;

        public bool IsFailedInMinOneSubject => ScienceMarks < PassMarks || MathMarks < PassMarks;

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
                if (value > FullMarks)
                {
                    _math = (float)FullMarks;
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
                _science = value > FullMarks ? (float)FullMarks : value < 0 ? 0 : value;
            }
        }

        public float Total
        {
            get
            {
                return MathMarks + ScienceMarks;
            }
        }

        public string Percentage
        {
            get
            {
                return percentage.ToString("00.00") + " %";
            }
        }

        private float percentage
        {
            get
            {
                return (float)((Total / (2 * FullMarks)) * 100);
            }
        }

        //public string Div => Percentage >= 80 ? "Distinction" : Percentage >= 60 ? "First Division" : Percentage >= 45 ? "Second Division" : Percentage >= 32 ? "Third Division" : "Fail";

        public string Division
        {
            get
            {
                if (IsFailedInMinOneSubject) return "Fail";

                if (percentage >= 80) return "Distinction";
                else if (percentage >= 60) return "First Division";
                else if (percentage >= 45) return "Second Division";
                else if (percentage >= 32) return "Third Division";
                else return "Fail";
            }
        }

        public int Adds(int a, int b) => a + b;

        //function overloading
        public int Add(int a, int b) //int, int
        {
            return a + b;
        }

        public int Add(int b, float a)//int, float
        {
            return (int)a + b;
        }

        public int Add(float b, int a) // float, int
        {
            Display(a);
            return (int)(a + b);
        }

        public static void Display(int a)
        {
            for (int i = 0; i < a; i++)
            {
                if (a == 3)
                {
                    return;
                }
            }
        }

        //Operator overloading
        //+
        public static StudentInfo operator +(StudentInfo a, StudentInfo b)
        {
            var ret = new StudentInfo(a.FullMarks + b.FullMarks, a.PassMarks + b.PassMarks, a.FirstName, a.MiddleName, a.LastName);
            ret.MathMarks = a.MathMarks + b.MathMarks;
            ret.ScienceMarks = a.ScienceMarks + b.ScienceMarks;

            return ret;
        }

        public static StudentInfo operator ++(StudentInfo a)
        {
            a.MathMarks++;
            a.ScienceMarks++;

            return a;
        }

        public static StudentInfo operator +(StudentInfo a, float b)
        {
            a.MathMarks = a.MathMarks + b;
            a.ScienceMarks = a.ScienceMarks + b;

            return a;
        }
    }
}
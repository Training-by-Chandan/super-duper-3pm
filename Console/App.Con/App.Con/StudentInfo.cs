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

        private float _computer;

        public float ComputereMarks
        {
            get { return _computer; }
            set
            {
                _computer = value > FullMarks ? (float)FullMarks : value < 0 ? 0 : value;
            }
        }

        public float Total
        {
            get
            {
                return MathMarks + ScienceMarks + ComputereMarks;
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
                return (float)((Total / (3 * FullMarks)) * 100);
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
            var totalFullmarks = a.FullMarks + b.FullMarks;
            var totalPassmarks = a.PassMarks + b.PassMarks;
            StudentInfo sres = new StudentInfo(totalFullmarks, totalPassmarks, a.FirstName, a.MiddleName, a.LastName);
            sres.MathMarks = a.MathMarks + b.MathMarks;
            sres.ScienceMarks = a.ScienceMarks + b.ScienceMarks;
            sres.ComputereMarks = a.ComputereMarks + b.ComputereMarks;

            return sres;
        }

        public static StudentInfo operator -(StudentInfo a, StudentInfo b)
        {
            var totalFullmarks = a.FullMarks - b.FullMarks;
            var totalPassmarks = a.PassMarks - b.PassMarks;
            StudentInfo sres = new StudentInfo(totalFullmarks, totalPassmarks, a.FirstName, a.MiddleName, a.LastName);
            sres.MathMarks = a.MathMarks - b.MathMarks;
            sres.ScienceMarks = a.ScienceMarks - b.ScienceMarks;
            sres.ComputereMarks = a.ComputereMarks - b.ComputereMarks;

            return sres;
        }

        public static StudentInfo operator +(StudentInfo a, double b)
        {
            a.MathMarks = a.MathMarks + 5;
            a.ScienceMarks = a.ScienceMarks + 5;
            a.ComputereMarks = a.ComputereMarks + 5;

            return a;
        }

        //equals to and not equals to == , !=
        public static bool operator ==(StudentInfo a, StudentInfo b)
        {
            return a.FullMarks == b.FullMarks && a.PassMarks == b.PassMarks && a.ScienceMarks == b.ScienceMarks && a.MathMarks == b.MathMarks && a.ComputereMarks == b.ComputereMarks;
        }

        public static bool operator !=(StudentInfo a, StudentInfo b)
        {
            return !(a.FullMarks == b.FullMarks && a.PassMarks == b.PassMarks && a.ScienceMarks == b.ScienceMarks && a.MathMarks == b.MathMarks && a.ComputereMarks == b.ComputereMarks);
        }

        //less than , greater  than <, > : do it in total

        // less than and equals to , greater than and equals to <=, >=

        //Override
        public override string ToString()
        {
            return $"Fullname : {FullName}\nScience Marks : {ScienceMarks}\nMath Marks : {MathMarks}\nComputer : {ComputereMarks}\nTotal : {Total}\nPercentage : {Percentage}\nDivision : {Division}";
        }
    }
}
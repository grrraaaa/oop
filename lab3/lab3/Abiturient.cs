using System;
using System.Collections.Generic;
using System.Linq;


namespace lab2
{
    public partial class Abiturient
    {
        private static int _objectCount;

        public readonly int Id;

        private string _lastName;
        private string _firstName;
        private string _middleName;
        private string _address;
        private string _phone;
        private List<double> _grades;
        private string nonChangable;

        
        private const double PassingGrade = 2.0;

        
        static Abiturient()
        {
            _objectCount = 0;
        }

        private Abiturient()
        {
            Id = GenerateId();
        }

        public Abiturient(string lastName, string firstName, string middleName)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            Grades = new List<double>();
        }

        public Abiturient(string lastName, string firstName, string middleName, string address, string phone, List<double> grades)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            Address = address;
            Phone = phone;
            Grades = grades;
            Id = GenerateId();

        }

        public Abiturient(List<double> grades)
        : this("lastname", "firstname", "middlename")
        {
            Grades = new List<double>();
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string FirstName
        {
            get => _firstName;
            set => _firstName = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string MiddleName
        {
            get => _middleName;
            set => _middleName = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Address
        {
            get => _address;
            set => _address = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Phone
        {
            get => _phone;
            set => _phone = value ?? throw new ArgumentNullException(nameof(value));
        }

        public List<double> Grades
        {
            get => _grades;
            set => _grades = value ?? throw new ArgumentNullException(nameof(value));
        }
        
        public string NonChangable
        {
            get;
        }

        // Methods
        public double CalculateAverageGrade() => Grades.Average();

        public double GetMaxGrade() => Grades.Max();

        public double GetMinGrade() => Grades.Min();

        public static int GetObjectCount() => _objectCount;

        public static void ShowClassInfo()
        {
            Console.WriteLine($"Total objects created: {_objectCount}");
            Console.WriteLine($"Passing grade: {PassingGrade}");
        }

        public void UpdateGrades(ref List<double> newGrades, out bool success)
        {
            if (newGrades != null)
            {
                Grades = newGrades;
                success = true;
            }
            else
            {
                success = false;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is Abiturient other)
            {
                return Id == other.Id;
            }
            return false;
        }

        public override int GetHashCode() => HashCode.Combine(Id);

        public override string ToString() => $"Abiturient: {LastName} {FirstName} {MiddleName}, ID: {Id}";

        // Private helper methods
        private int GenerateId()
        {
            _objectCount++;
            return _objectCount;
        }
    }
}
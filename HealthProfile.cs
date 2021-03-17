using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEG_324_Health_Records
{
    class HealthProfile
    {
        string _firstName;
        string _lastName;
        int _dayOfBirth;
        int _monthOfBirth;
        int _yearOfBirth;
        int _weightInPounds;
        int _heightInInches;
        string _gender;
        int _currentYear;
        public HealthProfile(string FirstName, string LastName, string Gender, int MonthOfBirth, int DayOfBirth, int YearOfBirth, int WeightInPounds, int HeightInInches, int CurrentYear)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
            this._dayOfBirth = DayOfBirth;
            this._monthOfBirth = MonthOfBirth;
            this._yearOfBirth = YearOfBirth;
            this._weightInPounds = WeightInPounds;
            this._heightInInches = HeightInInches;
            this._gender = Gender;
            this._yearOfBirth = YearOfBirth;
        }
        public int DayOfBirth
        {
            get
            {
                return _dayOfBirth;
            }
            set
            {
                this._dayOfBirth = value;
            }
        }
        public void DisplayDayOfBirth()
        {
            Console.WriteLine("Day of Birth: {0}", DayOfBirth);
        }
        public int MonthOfBirth
        {
            get
            {
                return _monthOfBirth;
            }
            set
            {
                this._monthOfBirth = value;
            }
        }
        public void DisplayMonthOfBirth()
        {
            Console.WriteLine("Month of Birth: {0}", MonthOfBirth);
        }

        //set and get _yearOfBirth
        public int YearOfBirth
        {
            get
            {
                return _yearOfBirth;
            }
            set
            {
                this._yearOfBirth = value;
            }
        }
        public void DisplayYearOfBirth()
        {
            Console.WriteLine("Year of Birth: {0}", YearOfBirth);
        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public void DisplayFirstName()
        {
            Console.WriteLine("First Name: {0}", FirstName);
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                this._lastName = value;
            }
        }
        public void DisplayLastName()
        {
            Console.WriteLine("Last Name: {0}", LastName);
        }
        public int WeightInPounds
        {
            get
            {
                return _weightInPounds;
            }
            set
            {
                this._weightInPounds = value;
            }
        }
        public void DisplayWeightInPounds()
        {
            Console.WriteLine("Weight in pounds: {0}", WeightInPounds);
        }
        public int HeightInInches
        {
            get
            {
                return _heightInInches;
            }
            set
            {
                this._heightInInches = value;
            }
        }
        public void DisplayHeightInInches()
        {
            Console.WriteLine("Height in inches: {0}", HeightInInches);
        }
        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                this._gender = value;
            }

        }
        public void DisplayGender()
        {
            Console.WriteLine("Gender is: {0}", Gender);
        }
        public int CurrentYear
        {
            get
            {
                return _currentYear;
            }
            set
            {
                _currentYear = value;
            }
        }
        public void DisplayCurrentYear()
        {
            Console.WriteLine("Current Year: {0}", CurrentYear);
        }
        public float BodyMassIndex()
        {
            float BMI = (WeightInPounds * 703) / (HeightInInches * HeightInInches);
            return BMI;
        }
        public void DisplayBodyMassIndex()
        {
            Console.WriteLine("Body Mass Index: {0}", BodyMassIndex());
        }
        public void DisplayBMIOutput()
        {
            if (BodyMassIndex() < 18.5)
            {
                Console.Write("\nYou are Underweight.\n");
            }
            else if (BodyMassIndex() < 25)
            {
                Console.Write("\nYou weight is Normal.\n");
            } 
            else if (BodyMassIndex() < 30)
            {
                Console.Write("\nYou are Overweight\n");
            }
            else Console.Write("\nYou are Obese.\n");
        }
        public void DisplayBMIChart()
        {
            Console.Write("\n\n\nBMI Values\n\nUnderweight: less than 18.5\nNormal: between 18.5 and 24.9\nOverweight: between 25 and 29.9\nObese: 30 or greater\n");
        }
        public int YearsOfAgeSimple()
        {
            int YearsOfAgeSimple = (2021 - this._yearOfBirth);
            return YearsOfAgeSimple;
        }
        public void DisplayYearsOfAgeSimple()
        {
            Console.WriteLine("{0} years of age.", YearsOfAgeSimple());
        }
        public double MaxHeartRate()
        {
            int MaxHeartRate = (220 - YearsOfAgeSimple());
            return MaxHeartRate;
        }
        public void DisplayMaxHeartRate()
        {
            Console.WriteLine("Max heart rate: {0}", MaxHeartRate());
        }
        
        public double TargetHeartRate()
        {
            double TargetHeartRate = (.68 * MaxHeartRate());
            return TargetHeartRate;
        }
        public void DisplayTargetHeartRate()
        {
            Console.WriteLine("Target heart rate: {0}", TargetHeartRate());
        }
    }
}

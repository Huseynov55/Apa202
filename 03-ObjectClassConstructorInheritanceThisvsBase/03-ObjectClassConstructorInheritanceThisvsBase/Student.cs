using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Text;

namespace _03_ObjectClassConstructorInheritanceThisvsBase
{
    internal class Student : Person
    {
        public string StudentNumber;
        public string Faculty;
        public double GPA;
        public int Year;

        public Student(string FirstName, string LastName, int Age, string Email, string Id, string StudentNumber, string Faculty, double GPA, int Year)
            : base(FirstName, LastName, Age, Email, Id)
        {
            this.StudentNumber = StudentNumber;
            this.Faculty = Faculty;
            this.GPA = GPA;
            this.Year = Year;
        }
        public void ShowStudentInfo()
        {
            Console.WriteLine($"Ad: {FirstName} Soyad: {LastName} Yas: {Age} Email: {Email} Id: {Id} Telebe nomresi: {StudentNumber} Fakulte: {Faculty} Orta bal: {GPA} Kurs: {Year}");

        }
        public int CalculateScholarship()
        {
            if (GPA >= 90)
            {
                return 500;
            }
            else if (GPA >= 80)
            {
                return 350;
            }
            else if(GPA >= 70)
            {
                return 200;
            }
            else
            {
                return 0;
            }


        }
    }
}

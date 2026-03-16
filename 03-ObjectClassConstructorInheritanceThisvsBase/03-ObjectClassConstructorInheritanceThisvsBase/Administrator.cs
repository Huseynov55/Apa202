using System;
using System.Collections.Generic;
using System.Text;

namespace _03_ObjectClassConstructorInheritanceThisvsBase
{
    internal class Administrator : Person
    {
        public string Position;
        public string Department;
        public int AccessLevel;

        public Administrator(string FirstName, string LastName, int Age, string Email, string Id, string Position, string Department, int AccessLevel)
        : base(FirstName, LastName, Age, Email, Id)
        {
            this.Position = Position;
            this.Department = Department;
            this.AccessLevel = AccessLevel;
        }
        public void ShowAdminInfo()
        {
            Console.WriteLine($"Ad: {FirstName} Soyad: {LastName} Yas: {Age} Email: {Email} Id: {Id} Vezife: {Position} Kafedra/Sobe: {Department} Giris seviyyesi: {AccessLevel}");
        }
        public void GrantAccess(Student student)
        {
            Console.WriteLine($"{Position} {FirstName} {LastName} terefinden {student.GetFullName()} adlı telebeye sisteme giriş icazesi verildi.");
        }
    }
}

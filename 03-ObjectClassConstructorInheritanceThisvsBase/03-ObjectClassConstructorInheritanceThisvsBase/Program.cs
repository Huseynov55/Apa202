namespace _03_ObjectClassConstructorInheritanceThisvsBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student telebe1 = new Student("Anar", "Huseynov", 20, "anar@gmail.com", "ID105", "ST555", "IT", 88.5, 3);
            Student telebe2 = new Student("Ilkin", "Omarov", 19, "ilkin@gmail.com", "ID108", "ST888", "BM", 92.0, 4);
            Student telebe3 = new Student("Nurlan", "Hidayetov", 18, "nurlan@gmail.com", "ID106", "ST666", "HT", 68.5, 2);

            Teacher muellim1 = new Teacher("Fizuli", "Ezimov", 64, "fizuli@gmail.com", "ID204", "Komputer texnologiyalari", "Python-la masin oyrenilmesi", 1200, 35);
            Teacher muellim2 = new Teacher("Zehra", "Yusifli", 34, "zehra@gmail.com", "ID268", "Komputer elmleri", "Mikroprosessorlar", 880, 12);

            Administrator admin1 = new Administrator("Nigar", "Rzayeva", 40, "nigar@gmail.com", "ID307", "Dekan", "IT", 5);

            telebe1.ShowStudentInfo();
            Console.WriteLine($"Teqaud meblegi: {telebe1.CalculateScholarship()}");
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            telebe2.ShowStudentInfo();
            Console.WriteLine($"Teqaud meblegi: {telebe2.CalculateScholarship()}");
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            telebe3 .ShowStudentInfo();
            Console.WriteLine($"Teqaud meblegi: {telebe3.CalculateScholarship()}");
            Console.WriteLine("------------------------------------------------------------------------------------------------");

            muellim1.ShowTeacherInfo();
            Console.WriteLine($"Maas meblegi: {muellim1.CalculateSalary()}");
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            muellim2.ShowTeacherInfo();
            Console.WriteLine($"Maas meblegi: {muellim2.CalculateSalary()}");
            Console.WriteLine("------------------------------------------------------------------------------------------------");

            admin1.ShowAdminInfo();
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            admin1.GrantAccess(telebe1);
            
            int totalScholarship = telebe1.CalculateScholarship() + telebe2.CalculateScholarship() + telebe3.CalculateScholarship();
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Umumi teqaud xerci: {totalScholarship} AZN");
            decimal totalSalary = muellim1.CalculateSalary() + muellim2.CalculateSalary();
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Umumi maas xerci: {totalSalary} AZN");
        }
    }
}

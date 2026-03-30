using _08_StatiClassExtensionMethodsExceptions.CustomExceptions;

namespace _08_StatiClassExtensionMethodsExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoginSystem mySystem = new LoginSystem();

            while (true)
            {
                try
                {
                    Console.WriteLine("\n--- GİRİŞ SİSTEMİ ---");
                    Console.Write("Username: ");
                    string userInp = Console.ReadLine();

                    Console.Write("Password: ");
                    string passInp = Console.ReadLine();

                    if (mySystem.Login(userInp, passInp))
                    {
                        break;
                    }
                }
                catch (InvalidUsernameException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidPasswordException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (UserNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Melumat: Movcud istifadeciler: admin, student, teacher.");
                }
                catch (IncorrectPasswordException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (AccountLockedException ex)
                {
                    Console.WriteLine(ex.Message);
                    break; 
                }
                catch (Exception ex)
                {
                    Console.WriteLine("UNEXPECTED ERROR: " + ex.Message);
                }
            }

            Console.WriteLine("\nProqram başa çatdi.");
            Console.ReadKey();
        }
    }
}

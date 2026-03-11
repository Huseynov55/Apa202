namespace _01_C_IntroMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hər biri 2 parametr qəbul edib və riyazi əməlləri yerinə yetiren method yazin.
            //int n = Convert.ToInt32(Console.ReadLine());
            //int m = Convert.ToInt32(Console.ReadLine());
            //string c = "";
            //while (true)
            //{
            //    c = Console.ReadLine();
            //    if (c == "+" || c == "*" || c == "/" || c == "-")
            //    {
            //        Console.WriteLine(Emeliyyat(n, m, c));
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Daxil etdiyiniz simvol yanlisdir");
            //    }
            //}


            // Verilen arqumentlere uygun tek ve cut edeleri tapan method yazin.(14, 20, 35, 40, 57, 60, 100)
            //int[] arr = { 14, 20, 35, 40, 57, 60, 100 };
            //FindNumber(arr);

            //Verilmis arreyde elementlerin həm 4-ə, həm də 5-ə bölününen elementlerin cemini tapin.[14, 20, 35, 40, 57, 60, 100]
            //int[] arr = [14, 20, 35, 40, 57, 60, 100];
            //Console.WriteLine(SumNumber(arr));

            //Daxil edilmiş cümlədə daxil edilmis simvoldan nece eded olduğunu tapan Proqramın alqoritmini yazin.(Cumle serbestdir).
            //string word= Console.ReadLine();
            //char letter = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine(WordCount(word, letter));


        }


        // task 1-in methodu
        public static int Emeliyyat(int n, int m, string c)
        {
            switch (c)
            {
                case "+":
                    return n + m;
                case "-":
                    return n - m;
                case "*":
                    return n * m;
                case "/":
                    return n / m;
            }
            return 0;
        }
        // task 2-nin methodu
        public static void FindNumber(int[] arr)
        {
            string even = "";
            string odd = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even += arr[i]+ ",";
                }
                else
                {
                    odd += arr[i]+ ",";
                }
            }
            Console.WriteLine($"Cut ededler {even}");
            Console.WriteLine($"Tek ededler {odd}");
        }
        // task 3-un methodu
        public static int SumNumber(int[] arr)
        {
            int sum = 0;
            for (int i = 0;i < arr.Length; i++)
            {
                if(arr[i]%4==0 && arr[i] % 5 == 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        //task 4-un methodu
        public static int WordCount(string word, char letter)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {

                if (letter == word[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}

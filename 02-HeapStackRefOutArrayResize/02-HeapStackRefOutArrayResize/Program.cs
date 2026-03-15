namespace _02_HeapStackRefOutArrayResize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = [1, 2, 3, 4];
            CustomArrResize(ref arr1, [5, 6, 7, 8]);

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
        }
        public static void CustomArrResize(ref int[] array1, params int[] nums)
        {
            int[] newarr= new int[array1.Length + nums.Length];
            for (int i = 0; i < newarr.Length; i++)
            {
                if (i>=array1.Length)
                {
                    newarr[i] = nums[i-array1.Length];
                }
                else
                {
                    newarr[i] = array1[i];
                }
            }
            array1 = newarr;
        }
    }
}

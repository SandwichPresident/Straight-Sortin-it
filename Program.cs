namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -11, 12, -42, 0, 1, 90, 68, 6, -9 }; 
            int[] array2 = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };

            static void Sort(int[] a)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    bool isAnyChange = false;
                    for (int j = 0; j < a.Length - 1; j++)
                    {
                        if (a[j] > a[j + 1])
                        {
                            isAnyChange = true;
                            (a[j], a[j + 1]) = (a[j + 1], a[j]);
                        }
                    }
                    if (!isAnyChange) { break; }
                }
            }
            Console.WriteLine("Original array:");
            foreach (int arr in array)
            {
                Console.WriteLine(arr);
            }
            Sort(array);
            Console.WriteLine("Sorted array:");
            foreach (int arr in array)
            {
                Console.WriteLine(arr);
            }
            Console.WriteLine("Second Original array:");
            foreach (int arr2 in array2)
            {
                Console.WriteLine(arr2);
            }
            Array.Sort(array2);
            Console.WriteLine("Second Sorted array:");
            foreach (int arr2 in array2)
            {
                Console.WriteLine(arr2);
            }
        }
    }
}

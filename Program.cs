namespace c_sharp_arrays_string
{//lab-4
    public class Program
    {
        static void Main()
        {
            var random = new Random();

            Console.WriteLine("Enter the lower bound of the random number: ");
            var lowerMaxRandomBound = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the upper bound of the random number: ");
            var upperMaxRandomBound = Convert.ToInt32(Console.ReadLine());

            if (lowerMaxRandomBound > upperMaxRandomBound)
            {
                (lowerMaxRandomBound, upperMaxRandomBound) = (upperMaxRandomBound, lowerMaxRandomBound);
            }
            Console.WriteLine("Enter the size of the array M: ");
            int M = Convert.ToInt32(Console.ReadLine());
            var arr_1 = new int[M];
            for (int i = 0; i < M; i++)
            {
                arr_1[i] = random.Next(lowerMaxRandomBound, upperMaxRandomBound);
            }

            Console.WriteLine("The array M is: ");
            foreach (var item in arr_1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Enter the size of the array N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            var arr_2 = new int[N];
            for (int i = 0; i < N; i++)
            {
                arr_2[i] = random.Next(lowerMaxRandomBound, upperMaxRandomBound);
            }
            Console.WriteLine("The array N is: ");
            foreach (var item in arr_2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            var arr_3 = arr_1.Intersect(arr_2).ToArray();

            Console.WriteLine("The similar array is: ");
            foreach (var item in arr_3)
            {
                Console.Write(item + " ");
            }
        }
    }
}


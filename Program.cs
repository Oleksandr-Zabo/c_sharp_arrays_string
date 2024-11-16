namespace c_sharp_arrays_string
{//lab-1
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
            Console.WriteLine("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            var arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(lowerMaxRandomBound, upperMaxRandomBound);
            }

            Console.WriteLine("The array is: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            int even = 0;
            int odd = 0;
            int unique = 0;

            for (int i = 0; i < size; i++)
            {
                if (arr[i] % 2 == 1) {
                    odd++;
                }
                else
                {
                    even++;
                }

                bool isUnique = true;
                for (int j = 0; j < size; j++)
                {
                    if (i != j) {
                        if (arr[i] == arr[j])
                        {
                            isUnique = false;
                            break;
                        }
                    }
                }
                if (isUnique)
                {
                    unique++;
                }
            }

            Console.WriteLine($"\nNumber of even numbers: {even}");
            Console.WriteLine($"Number of odd numbers: {odd}");
            Console.WriteLine($"Number of unique numbers: {unique}");

        }
    }
}

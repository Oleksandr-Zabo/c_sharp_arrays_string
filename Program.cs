namespace c_sharp_arrays_string
{//lab-5
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
            Console.WriteLine("Enter the rows of the array: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the cols of the array: ");
            int cols = Convert.ToInt32(Console.ReadLine());
            var arr = new int[rows, cols];
            //init array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = random.Next(lowerMaxRandomBound, upperMaxRandomBound);
                }
            }

            //print array
            Console.WriteLine("The array is: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            //create 1D array from 2D array
            var arr_2 = new int[rows * cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr_2[i * cols + j] = arr[i, j];
                }
            }

            Console.WriteLine("Max in array: " + arr_2.Max());
            Console.WriteLine("Min in array: " + arr_2.Min());

        }
    }
}


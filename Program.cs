namespace c_sharp_arrays_string
{//hw-ex.2
    public class Program
    {
        static void Main()
        {
            try
            {
                // Initialize the 5x5 array
                var array = new int[5, 5];
                Random rand = new Random();

                // Fill the array with random numbers between -100 and 100
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        array[i, j] = rand.Next(-100, 101);
                    }
                }

                // Display the array
                Console.WriteLine("Array:");
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write($"{array[i, j],5}");
                    }
                    Console.WriteLine();
                }

                //transform to 1-d array
                int[] array1d = new int[25];
                int k = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        array1d[k] = array[i, j];
                        k++;
                    }
                }

                int min_element = array1d.Min();
                int max_element = array1d.Max();
                int min_index = Array.IndexOf(array1d, min_element);
                int max_index = Array.IndexOf(array1d, max_element);

                if (max_index < min_index) {
                    (max_index, min_index) = (min_index, max_index);
                }

                int sum_min_to_max = 0;
                for (int i = min_index + 1; i < max_index; i++)
                {
                    sum_min_to_max += array1d[i];
                }
                Console.WriteLine($"\nMinimum element: {min_element}");
                Console.WriteLine($"Maximum element: {max_element}");
                Console.WriteLine($"Sum of elements between min and max: {sum_min_to_max}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Exeption {ex}");
            }

        }
    }
}



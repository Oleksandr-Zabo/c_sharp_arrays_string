namespace c_sharp_arrays_string
{//hw-ex.1
    public class Program
    {
        static void Main()
        {
            try
            {
                var A = new double[5];
                var B = new double[3, 4];

                // Fill array A with user input
                Console.WriteLine("Enter 5 elements for array A:");
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write($"A[{i}] = ");
                    A[i] = Convert.ToDouble(Console.ReadLine());
                }

                // Fill array B with random numbers
                Random rand = new Random();
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        B[i, j] = rand.NextDouble() * 100; // Random numbers from 0 to 100
                    }
                }

                // Display arrays
                Console.WriteLine("\nArray A:");
                foreach (int num in A)
                {
                    Console.Write(num + " ");
                }

                Console.WriteLine("\n\nArray B:");
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        Console.Write($"{B[i, j]:F2} ");
                    }
                    Console.WriteLine();
                }

                // Find the overall maximum and minimum elements
                double maxElement = A[0];
                double minElement = A[0];
                double sumAllElements = 0;
                double productAllElements = 1;

                foreach (int num in A)
                {
                    if (num > maxElement) {
                        maxElement = num;
                            }
                    if (num < minElement) { 
                        minElement = num; 
                    }
                    sumAllElements += num;
                    productAllElements *= num;
                }

                foreach (double num in B)
                {
                    if (num > maxElement)
                    {
                        maxElement = num;
                    }
                    if (num < minElement) { 
                        minElement = num; 
                    }
                    sumAllElements += num;
                    productAllElements *= num;
                }

                // Sum of even elements in array A
                int sumEvenA = 0;
                foreach (int num in A)
                {
                    if (num % 2 == 0) { 
                        sumEvenA += num; 
                    }
                }

                // Sum of odd columns in array B
                double sumOddColumnsB = 0;
                for (int j = 0; j < B.GetLength(1); j += 2)
                {
                    for (int i = 0; i < B.GetLength(0); i++)
                    {
                        sumOddColumnsB += B[i, j];
                    }
                }

                // Display results
                Console.WriteLine($"\nMaximum element: {maxElement}");
                Console.WriteLine($"Minimum element: {minElement}");
                Console.WriteLine($"Total sum of all elements: {sumAllElements}");
                Console.WriteLine($"Total product of all elements: {productAllElements}");
                Console.WriteLine($"Sum of even elements in array A: {sumEvenA}");
                Console.WriteLine($"Sum of odd columns in array B: {sumOddColumnsB}");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Exeption {ex}");
            }

        }
    }
}


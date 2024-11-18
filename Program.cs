namespace c_sharp_arrays_string
{//hw-ex.4
    public class Program
    {
        static void Main()
        {
            try
            {
                Random rand = new Random();

                // Input matrix size
                Console.WriteLine("Enter the number of rows:");
                int rows = Convert.ToInt32(Console.ReadLine());
                if (rows < 1)
                {
                    throw new Exception("Number of rows must be greater than 0.");
                }

                Console.WriteLine("Enter the number of columns:");
                int cols = Convert.ToInt32(Console.ReadLine());
                if (cols < 1)
                {
                    throw new Exception("Number of columns must be greater than 0.");
                }

                // Initialize matrices
                var matrix1 = new int[rows, cols];
                var matrix2 = new int[rows, cols];
                var result = new int[rows, cols];

                // Fill matrices with random integers
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix1[i, j] = rand.Next(-100, 101);
                        matrix2[i, j] = rand.Next(-100, 101);
                    }
                }

                // Display matrices
                Console.WriteLine("\nMatrix 1:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(matrix1[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\nMatrix 2:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(matrix2[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                // Multiply matrix1 by a scalar
                Console.WriteLine("Enter the number of scalar (mulp to matrix 1):");
                int scalar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"\nMatrix 1 multiplied by scalar {scalar}:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        result[i, j] = matrix1[i, j] * scalar;
                        Console.Write(result[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                // Add matrix1 and matrix2
                Console.WriteLine("\nMatrix 1 + Matrix 2:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        result[i, j] = matrix1[i, j] + matrix2[i, j];
                        Console.Write(result[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                // Multiply matrix1 and matrix2 (only if they are square matrices)
                if (rows == cols)
                {
                    Console.WriteLine("\nMatrix 1 * Matrix 2:");
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            result[i, j] = 0;
                            for (int k = 0; k < cols; k++)
                            {
                                result[i, j] += matrix1[i, k] * matrix2[k, j];
                            }
                            Console.Write(result[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    throw new Exception("Matrix multiplication is not possible as the matrices are not square.");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Exeption {ex}");
            }

        }
    }
}



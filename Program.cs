namespace c_sharp_arrays_string
{//lab-3
    public class Program
    {
        static void Main()
        {
            var random = new Random();

            try
            {

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Exeption: {ex}");
            }

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
            if (size < 0) { 
                throw new Exception("The size of the array cannot be negative");
            }
            var arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(lowerMaxRandomBound, upperMaxRandomBound);
            }

            //arr = new int[] { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };//to test the code

            Console.WriteLine("The array is: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            var arr_three = new int[3];

            Console.WriteLine("Enter numbers (by space): ");
            string? arr_three_str = Console.ReadLine();

            if (arr_three_str == null) {
                throw new Exception("The input cannot be null");
            }

            arr_three = Array.ConvertAll(arr_three_str.Split(' '), int.Parse);//to convert the string to int array

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter number {i}: ");
            //    arr_three[i] = Convert.ToInt32(Console.ReadLine());
            //}

            int three_in_arr = 0;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (arr[i] == arr_three[0] && arr[i + 1] == arr_three[1] && arr[i + 2] == arr_three[2]) {
                    three_in_arr++;
                }
            }

            Console.WriteLine($"The number of times the sequence appears in the array is: {three_in_arr}");
        }
    }
}

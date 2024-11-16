namespace c_sharp_arrays_string
{//lab-2
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
            Console.WriteLine();
            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int low_to_user = 0;

            for (int i = 0; i < size; i++)
            {
                if (arr[i] < number) {
                    low_to_user++;

                }
            }

            Console.WriteLine("The number of elements in the array that are less than to the number is: " + low_to_user);

        }
    }
}

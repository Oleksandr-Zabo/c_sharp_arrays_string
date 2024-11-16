namespace c_sharp_arrays_string
{//lab-ex.7
    public class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter a sentence: ");
                string? input = Console.ReadLine();

                // Split the input string into words
                if (input == null)
                {
                    throw new Exception("Input is null");
                }
                string[] words = input.Split(' ');

                // Reverse each word
                for (int i = 0; i < words.Length; i++)
                {
                    char[] charArray = words[i].ToCharArray();
                    Array.Reverse(charArray);
                    words[i] = new string(charArray);
                }

                // Join the reversed words into a single string
                string result = string.Join(" ", words);

                // Output the result
                Console.WriteLine($"Result: {result}");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Exeption {ex}");
            }

        }
    }
}


namespace c_sharp_arrays_string
{//lab-ex.6
    public class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter sentence: ");
                string? input = Console.ReadLine();

                if (input == null) {
                    throw new ArgumentNullException("Input is null");
                }
                string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    Console.WriteLine(word);
                }
                int wordCount = words.Length;


                Console.WriteLine($"Number of word in sentence: {wordCount}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Exeption {ex}");
            }
            
        }
    }
}

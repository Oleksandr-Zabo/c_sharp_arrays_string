namespace c_sharp_arrays_string
{//lab-ex.8
    public class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter a sentence: ");
                string? input = Console.ReadLine();
                if(input == null)
                {
                    throw new Exception("Input is null");
                }

                // Define vowels
                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

                // Count vowels
                int vowelCount = 0;

                foreach (char c in input)
                {
                    bool isVowel = false;
                    foreach (char vowel in vowels)
                    {
                        if (vowel == c)
                        {
                            isVowel = true;
                            break;
                        }
                    }

                    if (isVowel)
                    {
                        vowelCount++;
                    }
                }

                // Output the result
                Console.WriteLine($"Number of vowels in the sentence: {vowelCount}");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Exeption {ex}");
            }

        }
    }
}


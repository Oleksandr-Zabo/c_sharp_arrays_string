namespace c_sharp_arrays_string
{//hw-ex.7
    public class Program
    {
        static void Main()
        {
            try
            {
                // Input text
                string text = @"To be, or not to be, that is the question,
Whether 'tis nobler in the mind to suffer
The slings and arrows of outrageous fortune,
Or to take arms against a sea of troubles,
And by opposing end them? To die: to sleep;
No more; and by a sleep to say we end
The heart-ache and the thousand natural shocks
That flesh is heir to, 'tis a consummation
Devoutly to be wish'd. To die, to sleep";

                // Display the input text
                Console.WriteLine("Input text:");
                Console.WriteLine();
                Console.WriteLine(text);
                Console.WriteLine();

                //to input text

                //Console.WriteLine("Enter an arithmetic expression with +, -, *, /, ^:");
                //string? text = Console.ReadLine();
                //if (string.IsNullOrEmpty(text))
                //{
                //    throw new ArgumentNullException("Input is null or empty");
                //}

                // Forbidden word
                string forbiddenWord = "die";
                string replacement = new string('*', forbiddenWord.Length);

                // Replace forbidden word and count replacements
                int count = 0;
                string[] words = text.Split(new char[] { ' ', '\n', '\r', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Equals(forbiddenWord, StringComparison.OrdinalIgnoreCase))
                    {
                        words[i] = replacement;
                        count++;
                    }
                }

                // Reconstruct the text
                string result = text;
                foreach (string word in words)
                {
                    result = result.Replace(forbiddenWord, replacement, StringComparison.OrdinalIgnoreCase);
                }

                // Display the result
                Console.WriteLine("Result:");
                Console.WriteLine();
                Console.WriteLine(result);

                // Display the statistics
                Console.WriteLine();
                Console.WriteLine($"\nStatistics: {count} replacements of the word '{forbiddenWord}'");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Exeption {ex}");
            }

        }
    }
}

namespace c_sharp_arrays_string
{//hw-ex.6
    public class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter your text:");
                string? input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    throw new ArgumentNullException("Input is null or empty");
                }

                bool capitalizeNext = true;
                string result = "";

                for (int i = 0; i < input.Length; i++)
                {
                    char ch = input[i];

                    if (capitalizeNext && char.IsLetter(ch))
                    {
                        result += char.ToUpper(ch);
                        capitalizeNext = false;
                    }
                    else
                    {
                        result += ch;
                    }

                    if (ch == '.' || ch == '!' || ch == '?')
                    {
                        capitalizeNext = true;
                    }
                }

                Console.WriteLine("Result:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Exeption {ex}");
            }

        }
    }
}

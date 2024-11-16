namespace c_sharp_arrays_string
{//lab-ex.9
    public class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter the main string: ");
                string? mainString = Console.ReadLine();
                if (string.IsNullOrEmpty(mainString))
                {
                    throw new Exception("Main string cannot be empty.");
                    
                }

                Console.WriteLine("Enter the substring to search for: ");
                string? substring = Console.ReadLine();
                if (string.IsNullOrEmpty(substring))
                {
                    throw new Exception("Substring string cannot be empty.");

                }
                int count = 0;

                for (int i = 0; i < mainString.Length; i++)
                {
                    bool isMatch = false;
                    for (int j = 0; j < substring.Length; j++)
                    {
                        if (mainString[i + j] == substring[j])
                        {
                            isMatch = true;
                        }
                        else
                        {
                            isMatch = false;
                            break;
                        }
                    }

                    if (isMatch)
                    {
                        count++;
                    }
                }

                Console.WriteLine($"The substring '{substring}' occurs {count} times in the main string.");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Exeption {ex}");
            }

        }
    }
}


namespace c_sharp_arrays_string
{//hw-ex.3
    public class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter the text to be encrypted:");
                string? input = Console.ReadLine();
                if(string.IsNullOrEmpty(input))
                {
                    throw new Exception("Input is empty");
                }

                Console.WriteLine("Enter the shift value:");
                int shift = Convert.ToInt32(Console.ReadLine());
                if(shift < 0)
                {
                    throw new Exception("Shift value must be positive");
                }

                // Encrypt the text
                string encrypted = "";
                for (int i = 0; i < input.Length; i++)
                {
                    char ch = input[i];
                    if (char.IsLetter(ch))
                    {
                        char offset;
                        if (char.IsUpper(ch))
                        {
                            offset = 'A';
                        }
                        else
                        {
                            offset = 'a';
                        }
                        encrypted += (char)(((ch + shift - offset) % 26) + offset);//26- num of letters
                    }
                    else
                    {
                        encrypted += ch;
                    }
                }

                Console.WriteLine($"Encrypted text: {encrypted}");

                // Decrypt the text
                string decrypted = "";
                for (int i = 0; i < encrypted.Length; i++)
                {
                    char ch = encrypted[i];
                    if (char.IsLetter(ch))
                    {
                        char offset;
                        if (char.IsUpper(ch))
                        {
                            offset = 'A';
                        }
                        else
                        {
                            offset = 'a';
                        }
                        decrypted += (char)(((ch - shift - offset + 26) % 26) + offset);
                    }
                    else
                    {
                        decrypted += ch;
                    }
                }

                Console.WriteLine($"Decrypted text: {decrypted}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Exeption {ex}");
            }

        }
    }
}



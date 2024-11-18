namespace c_sharp_arrays_string
{//hw-ex.5
    public class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter an arithmetic expression with +, -, *, /, ^:");
                string? input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    throw new ArgumentNullException("Input is null or empty");
                }

                double result = 0;
                double currentNumber = 0;
                char currentOperation = '+';
                bool isNegative = false;

                for (int i = 0; i < input.Length; i++)
                {
                    char ch = input[i];

                    if (char.IsDigit(ch) || ch == '.')
                    {
                        if (ch == '.')
                        {
                            int decimalPlace = 1;
                            i++;
                            while (i < input.Length && char.IsDigit(input[i]))
                            {
                                currentNumber += (input[i] - '0') / Math.Pow(10, decimalPlace);
                                decimalPlace++;
                                i++;
                            }
                            i--;
                        }
                        else
                        {
                            currentNumber = currentNumber * 10 + (ch - '0');
                        }
                    }

                    if (!char.IsDigit(ch) && ch != '.' && !char.IsWhiteSpace(ch) || i == input.Length - 1)
                    {
                        if (isNegative)
                        {
                            currentNumber = -currentNumber;
                            isNegative = false;
                        }

                        if (currentOperation == '+')
                        {
                            result += currentNumber;
                        }
                        else if (currentOperation == '-')
                        {
                            result -= currentNumber;
                        }
                        else if (currentOperation == '*')
                        {
                            double tempResult = 0;
                            for (int j = 0; j < Math.Abs(currentNumber); j++)
                            {
                                tempResult += result;
                            }
                            if (currentNumber < 0)
                            {
                                tempResult = -tempResult;
                            }
                            result = tempResult;
                        }
                        else if (currentOperation == '/')
                        {
                            if (currentNumber == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            double tempResult = 0;
                            double absResult = Math.Abs(result);
                            double absCurrentNumber = Math.Abs(currentNumber);
                            while (absResult >= absCurrentNumber)
                            {
                                absResult -= absCurrentNumber;
                                tempResult++;
                            }
                            if ((result < 0 && currentNumber > 0) || (result > 0 && currentNumber < 0))
                            {
                                tempResult = -tempResult;
                            }
                            result = tempResult;
                        }
                        else if (currentOperation == '^')
                        {
                            double tempResult = 1;
                            for (int j = 0; j < Math.Abs(currentNumber); j++)
                            {
                                double powerResult = 0;
                                for (int k = 0; k < Math.Abs(result); k++)
                                {
                                    powerResult += tempResult;
                                }
                                tempResult = powerResult;
                            }
                            if (currentNumber < 0)
                            {
                                tempResult = 1 / tempResult;
                            }
                            result = tempResult;
                        }
                        else
                        {
                            throw new InvalidOperationException("Invalid operation");
                        }

                        currentOperation = ch;
                        currentNumber = 0;

                        if (ch == '-')
                        {
                            isNegative = true;
                        }
                    }
                }

                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Exeption {ex}");
            }

        }
    }
}
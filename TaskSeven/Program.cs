using System;

namespace TaskSeven
{
    public class Program

    {

        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Введите число с плавающей точкой ");
                string numЬerInput = Console.ReadLine();
                if (numЬerInput.Length == 0)
                {
                    break;
                }
                double number = Double.Parse(numЬerInput);

                Console.WriteLine("Bвeдитe модификаторы форматирования, разделенные пробелами");
                Console.WriteLine(" ( Haпpимep : СЕ Fl N0 0000000 . 00000 ) ");
                char[] separator = { ' ' };
                string formatString = Console.ReadLine();
                string[] formats = formatString.Split(separator);
                foreach (string s in formats)
                {
                    if (s.Length != 0)
                    {
                        string formatCommand = "{0:" + s + "}";
                        Console.Write("Модификатор {0} дает ", formatCommand);
                        try
                        {
                            Console.WriteLine(formatCommand, number);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("<неверный модификатор>");
                        }
                        Console.WriteLine();


                    }
                }
            }
        }
    }
}

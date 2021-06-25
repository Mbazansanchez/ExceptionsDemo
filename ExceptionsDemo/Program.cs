using System;

namespace ExceptionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string doAnother;

            do
            {

                try
                {
                    Console.WriteLine("Please enter num1: ");
                    string Num1str = Console.ReadLine();
                    int num1 = int.Parse(Num1str);

                    Console.Write("Please enter num2: ");
                    string num2str = Console.ReadLine();
                    int num2 = int.Parse(num2str);

                    Console.WriteLine("num1/num2: {0}", num1 / num2);
                } catch (System.FormatException exc)
                {
                    Console.WriteLine("Not a number");
                } catch (System.OverflowException exc)
                {
                    Console.WriteLine("Number is to large or small!");
                }
                catch (Exception exc)
                {
                    Console.WriteLine("Error " + exc.Message + "\nException type: " +
                        exc.GetType());

                } finally
                {
                    Console.WriteLine("This section always executes");
                }

                Console.WriteLine("Do another? (y/n): ");
                doAnother = Console.ReadLine();
            } while (doAnother == "y");

        }
    }
}

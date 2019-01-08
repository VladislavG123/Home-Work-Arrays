using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountSpaces = 0;
            string symbol;
            const string SPACE = " ";
            const string DOT = ".";
            Console.WriteLine("Введите символы и программа посчитает сколько было введено пробелов. Для выхода введите точку");
            while (true)
            {
                symbol = Console.ReadLine();
                if (symbol == SPACE)
                {
                    amountSpaces++;
                }
                else if (symbol == DOT)
                {
                    break;
                }
            }
            Console.WriteLine($"Количество пробелов - {amountSpaces}.");

            string numberOfTicket;
            string firstPartOFTicket;
            int sumOfFirstPart = 0;
            string secondPartOFTicket;
            int sumOfSecondPart = 0;
            const int CENTER_POSITION = 3;
            const int START_POSITION = 0;
            Console.WriteLine("Введите номер билета.");
            numberOfTicket = Console.ReadLine();
            secondPartOFTicket = numberOfTicket.Substring(CENTER_POSITION); 
            firstPartOFTicket = numberOfTicket.Remove(CENTER_POSITION).Substring(START_POSITION);
            foreach (var element in firstPartOFTicket)
            {
                // Отнимаем 48 для получения числа, ибо значения елементов сохранены в формате char.
                sumOfFirstPart += element - 48;
            }
            foreach (var element in secondPartOFTicket)
            {
                // Отнимаем 48 для получения числа, ибо значения елементов сохранены в формате char.
                sumOfSecondPart += element - 48;
            }
            Console.WriteLine(sumOfFirstPart == sumOfSecondPart ? "Билет является счастливым." : "У Вас обычный билет.");



            Console.WriteLine("Введите 2 числа ( 1<2 )");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                int transfer = firstNumber;
                firstNumber = secondNumber;
                secondNumber = transfer;
            }
            for (int i = firstNumber; i < secondNumber; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }



            Console.WriteLine("Введите целое число");
            string number = Console.ReadLine();
            if (Convert.ToInt32(number) < 0)
            {
                number = Convert.ToString(Convert.ToInt32(number) * -1);
            }
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }


            Console.WriteLine("\nВведите символ, и программа преобразует его в обратный регистер");
            Console.WriteLine("Для выхода введите точку");
            int codeOfSymbol;
            while (true)
            {
                codeOfSymbol = Console.Read();
                if ((char)codeOfSymbol == '.')
                {
                    break;
                }
                if (codeOfSymbol >= 65 && codeOfSymbol <= 90)
                {
                    codeOfSymbol += 32;
                    Console.WriteLine((char)codeOfSymbol);
                }
                else if (codeOfSymbol >= 97 && codeOfSymbol <= 122)
                {
                    codeOfSymbol -= 32;
                    Console.WriteLine((char)codeOfSymbol);
                }
            }
          



            Console.Read();
        }
    }
}

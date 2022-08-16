// See https://aka.ms/new-console-template for more information
using System;

namespace Private
{
    class ATM
    {
        static void Main()
        {
            int i;
            Console.Write("Меню:\n1) Посмотреть баланс \n2) Отправить средства \n3) Посмотреть номер лицевого счета \n\nВаш выбор: ");
            try
            {
                i = int.Parse(Console.ReadLine());
                Private.Program program = new Private.Program();
                program.Menu(i);
                Console.WriteLine();
            }
             catch (FormatException)
            {
                Console.WriteLine("Вы ввели не тот формат строки");
            }            
                       
        }
    }
}

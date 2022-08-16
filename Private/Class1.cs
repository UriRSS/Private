using System;
using System.Globalization;

namespace Private
{
    internal class Program
    {       
        public void Menu(int i)
        {
         
            switch (i)
            {
                case 1:
                    User UserAvtorizovan;
                    UserAvtorizovan.Firstname = "Alikeev";
                    UserAvtorizovan.name = "Urmat";
                    UserAvtorizovan.NomerScheta = 12345678;
                    UserAvtorizovan.Balans = 1000;
                    Console.WriteLine($"Фамилия: {UserAvtorizovan.Firstname}");
                    Console.WriteLine($"Имя: {UserAvtorizovan.name}");
                    Console.WriteLine($"Номер счета: {UserAvtorizovan.NomerScheta}");
                    Console.WriteLine($"Баланс: {UserAvtorizovan.Balans}");
                    break;
                case 2:
                    Tranzakciya tranzakciyaStuktura;
                    tranzakciyaStuktura.NomerSchetaPoluchatel = 12345678;
                    tranzakciyaStuktura.dateTranzakcii = DateTime.Now;
                    tranzakciyaStuktura.NomerTranzakcii = 0001;
                    Console.WriteLine($"Введите номер счета:");
                    tranzakciyaStuktura.NomerSchetaOtprovitel = Convert.ToInt32(Console.ReadLine());
                    if (tranzakciyaStuktura.NomerSchetaPoluchatel == tranzakciyaStuktura.NomerSchetaOtprovitel)
                    {
                        Console.WriteLine("Введите сумму пополнения");
                        NumberFormatInfo Rasdelitel = new NumberFormatInfo()
                        {
                            NumberDecimalSeparator = ".",
                        };
                        tranzakciyaStuktura.StrokaSumaPerevoda = Console.ReadLine();
                        tranzakciyaStuktura.SumaPerevoda = Convert.ToDouble(tranzakciyaStuktura.StrokaSumaPerevoda, Rasdelitel);
                        if (1000 <= tranzakciyaStuktura.SumaPerevoda)
                        {
                            tranzakciyaStuktura.SumaPerevoda = tranzakciyaStuktura.SumaPerevoda + 1000;
                            Console.WriteLine($"дата транзакции:  {tranzakciyaStuktura.dateTranzakcii}");
                            Console.WriteLine($"Счет отправителя: {tranzakciyaStuktura.NomerSchetaOtprovitel}");
                            Console.WriteLine($"Счет получателя: {tranzakciyaStuktura.NomerSchetaPoluchatel}");
                            Console.WriteLine($"Сумма: {tranzakciyaStuktura.SumaPerevoda}");
                            Console.WriteLine($"Номер транзакции: {tranzakciyaStuktura.NomerTranzakcii}");
                        }
                        else Console.WriteLine("Не достаточно средств для пополнения");
                    }
                    else
                    {
                        Console.WriteLine("Номер счета веден не верно");
                    }
                    break;
                case 3:
                    User UserAvtorizovanNomerScheta;
                    UserAvtorizovanNomerScheta.NomerScheta = 12345678;
                    Console.WriteLine($"Ваш номер счета: {UserAvtorizovanNomerScheta.NomerScheta}");
                    break;
                default:
                    Console.WriteLine("Вы нажали что-то другое...");
                    break;
            }
        }

        struct User
        {
            public string name;
            public string Firstname;
            public int NomerScheta;
            public double Balans;
        }

        struct Tranzakciya
        {
            public DateTime dateTranzakcii;
            public int NomerSchetaOtprovitel;
            public int NomerSchetaPoluchatel;
            public double SumaPerevoda;
            public String StrokaSumaPerevoda;
            public int NomerTranzakcii;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Создать класс для моделирования счета в банке. 
    Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.  
    Класс должен быть объявлен как обобщенный. 
    Универсальный параметр T должен определять тип номера счета. 
    Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения. 
    Создать  несколько экземпляров класса, параметризированного различными типам.
    Заполнить его поля и вывести информацию об экземпляре класса на печать.*/

namespace lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер счета");
            int accountnumbers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите баланс");
            int balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            string name = Console.ReadLine();


            Bankaccount<int> bankaccount1 = new Bankaccount<int>(accountnumbers, balance, name);
            Console.WriteLine(bankaccount1.GetInfo());
            

            Console.WriteLine("Введите номер счета");
            string accint = Console.ReadLine();
            Console.WriteLine("Введите баланс");
            balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            name = Console.ReadLine();

            Bankaccount<string> bankaccount2 = new Bankaccount<string>(accint, balance, name);
            Console.WriteLine(bankaccount2.GetInfo());

            Console.ReadKey();
        }
    }
    class Bankaccount<T>
    {
        public T Accountnumbers { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }

        public Bankaccount(T accountnumbers, int balance, string name)
        {
            Accountnumbers = accountnumbers;
            Balance = balance;
            Name = name;
        }
        public string GetInfo()
        {
            return $"{Accountnumbers} {Balance} {Name}";
        }
        //public void Input()
        //{
        //    Console.WriteLine("Введите номер счета");
        //    Accountnumbers = (T) Convert.ChangeType(Console.ReadLine(), typeof(T));
        //    Console.WriteLine("Введите баланс");
        //     Balance = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Введите ФИО");
        //     Name = Console.ReadLine();



        //}

    }
}

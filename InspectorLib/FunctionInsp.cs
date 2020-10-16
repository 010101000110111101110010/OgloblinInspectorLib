using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace InspectorLib
{
    public class FunctionInsp
    {
        static public string GInsp = ("Васильев Василий Иванович");
        static public string sot = ("Иванов И.И.;Зиронов Т.А.;Миронов А.В.;Васильев В.И.");
        static public string[] sot2;
        static public string Newsot;
        static public string NewGInsp;
        /// <summary>
        /// Выводит на экран ФИО главного инспектора
        /// </summary>
        static public void GetInspector()
        {
            Console.WriteLine($"Главный инспектор – {GInsp}");
        }
        /// <summary>
        /// Выводит на экран название автоинспекции
        /// </summary>
        static public void GetСarInspection()
        {
            Console.WriteLine("Название – Автоинспекция г. Чита");
        }
        /// <summary>
        /// Выводит на экран ФИО сотрудников автоинспекции
        /// </summary>
        static public void GetWorker()
        {
            sot2 = sot.Split(new Char[] { ';' });
            Console.WriteLine($"ФИО сотрудников автоинспекции: {sot}");
        }
        /// <summary>
        /// Устанавливает нового главного инспектора
        /// </summary>
        static public void SetInspector()
        {
            Console.WriteLine("Введите полное имя нового главного инспектора");
            NewGInsp = Console.ReadLine();
            for (int i = 0; i <= 3; i++)
            {
                if (NewGInsp == sot2[i])
                {
                    GInsp = NewGInsp;
                }
            }
        }
        /// <summary>
        /// Добовляет нового сотрудника в переменную sot
        /// </summary>
        static public void AddWorker()
        {
            Console.WriteLine("Введите ФИО нового сотрудника");
            Newsot = Console.ReadLine();
            sot = sot + ";" + Newsot;
        }
        /// <summary>
        /// Выводит на экран госномер при условии что переменная code=75
        /// </summary>
        /// <param name="number"></param>
        /// <param name="symbol"></param>
        /// <param name="code"></param>
        static public void GenerateNumber(int number, string symbol, int code)
        {
            if (code == 75) Console.WriteLine($"Госномер - {symbol.ToUpper()}{number}_{code}");
            else Console.WriteLine("Введён не верный номер региона");
        }

    }
}
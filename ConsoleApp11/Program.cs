using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Money obj = new Money();

            bool num = true;

            obj.print();


        }
    }
    public class Money
    {
        public Money() { }
        public Money(int a,double b)
        {
            dolar = a;
            cent = b;
        }

        public void print()
        {
            Console.WriteLine($"{dolar} доларов {cent} центов");
        }
        int dolar = 100;
        double cent = 50;
    }
    public class Product : Money
    {
       public Product(int a, double b):base(a,b)
       {
            if(true)
            {
                a += 100;
                b += 50;
            }
            else
            {
                a -= 100;
                b -= 50;
            }
       }
       
    }


    public class Device
    {
        string name;
        string sound;
        string desc;
        public void Sound()
        {
            sound = "";
        }
        public void Show()
        {
            name = "";
        }
        public void Desc()
        {
            desc = "";
        }
        public void Print()
        {
            Console.WriteLine("Устройства: ");
        }
    }
    public class Kettle : Device
    {
        public void Sound(string sound)
        {
            sound = "Чайник Чайник Чайник";
        }
        public void Show(string name)
        {
            name = "Чайник";
        }
        public void Desc(string desc)
        {
            desc = "Греет воду";
        }
        new public void Print()
        {
            base.Print();
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Звук: " + sound);
            Console.WriteLine("Описание: " + desc);
        }
    }
    public class Microwave : Device
    {
        public void Sound(string sound)
        {
            sound = "Микроволновка Микроволновка Микроволновка";
        }
        public void Show(string name)
        {
            name = "Микроволновка";
        }
        public void Desc(string desc)
        {
            desc = "Греет еду";
        }
        new public void Print()
        {
            base.Print();
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Звук: " + sound);
            Console.WriteLine("Описание: " + desc);
        }
    }
    public class Automobile : Device
    {
        public void Sound(string sound)
        {
            sound = "Автомобиль Автомобиль Автомобиль";
        }
        public void Show(string name)
        {
            name = "Автомобиль";
        }
        public void Desc(string desc)
        {
            desc = "Перевозит еду";
        }
        new public void Print()
        {
            base.Print();
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Звук: " + sound);
            Console.WriteLine("Описание: " + desc);
        }
    }
    public class Steamer : Device
    {
        public void Sound(string sound)
        {
            sound = "Пароход Пароход Пароход";
        }
        public void Show(string name)
        {
            name = "Пароход";
        }
        public void Desc(string desc)
        {
            desc = "Перевозит еду по воде";
        }
        new public void Print()
        {
            base.Print();
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Звук: " + sound);
            Console.WriteLine("Описание: " + desc);
        }

    }


    public class Musical 
    {
        string name;
        string sound;
        string desc;
        string history;
        public void Sound()
        {
            sound = "";
        }
        public void Show()
        {
            name = "";
        }
        public void Desc()
        {
            desc = "";
        }
        public void History()
        {
            history = "";
        }
        public void Print()
        {
            Console.WriteLine("Музыкальный инструмент: ");
        }
    }
    public class Violin : Musical
    {
        public void Sound(string sound)
        {
            sound = "Скрипка Скрипка Скрипка";
        }
        public void Show(string name)
        {
            name = "Скрипка";
        }
        public void Desc(string desc)
        {
            desc = "Звучит как скрипка";
        }
        public void History(string history)
        {
            history = "Скрипка 0000";
        }
        new public void Print()
        {
            base.Print();
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Звук: " + sound);
            Console.WriteLine("Описание: " + desc);
            Console.WriteLine("Описание: " + history);
        }
    }
    public class Trombone : Musical
    {
        public void Sound(string sound)
        {
            sound = "Тромбон Тромбон Тромбон";
        }
        public void Show(string name)
        {
            name = "Тромбон";
        }
        public void Desc(string desc)
        {
            desc = "Звучит как тромбон";
        }
        public void History(string history)
        {
            history = "Тромбон 0000";
        }
        new public void Print()
        {
            base.Print();
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Звук: " + sound);
            Console.WriteLine("Описание: " + desc);
            Console.WriteLine("Описание: " + history);
        }
    }
    public class Ukulele : Musical
    {
        public void Sound(string sound)
        {
            sound = "Укулеле Укулеле Укулеле";
        }
        public void Show(string name)
        {
            name = "Укулеле";
        }
        public void Desc(string desc)
        {
            desc = "Звучит как Укулеле";
        }
        public void History(string history)
        {
            history = "Укулеле 0000";
        }
        new public void Print()
        {
            base.Print();
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Звук: " + sound);
            Console.WriteLine("Описание: " + desc);
            Console.WriteLine("Описание: " + history);
        }
    }
    public class Cello : Musical
    {
        public void Sound(string sound)
        {
            sound = "Виолончель Виолончель Виолончель";
        }
        public void Show(string name)
        {
            name = "Виолончель";
        }
        public void Desc(string desc)
        {
            desc = "Звучит как виолончель";
        }
        public void History(string history)
        {
            history = "Виолончель 0000";
        }
        new public void Print()
        {
            base.Print();
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Звук: " + sound);
            Console.WriteLine("Описание: " + desc);
            Console.WriteLine("Описание: " + history);
        }
    }


    abstract class Worker
    {
        public void Print()
        {
            Console.Write("Он ");
        }
    }
    abstract class President : Worker
    {
        new public void Print()
        {
            base.Print();
            Console.WriteLine("Управляет");
        }
    }
    abstract class Security : Worker
    {
        new public void Print()
        {
            base.Print();
            Console.WriteLine("Охраняет");
        }
    }
    abstract class Manager : Worker
    {
        new public void Print()
        {
            base.Print();
            Console.WriteLine("Советует");
        }
    }
    abstract class Engineer : Worker
    {
        new public void Print()
        {
            base.Print();
            Console.WriteLine("Изобретает");
        }
    }
}

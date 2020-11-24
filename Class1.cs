using System;
using System.Collections.Generic;
using System.Text;

namespace Linst_Lern
{   
    interface ICafedra
    {
        void Print();
        void Output();          
    }

    class Cafedra: ICafedra
    {
        List<Cafedra> lists = new List<Cafedra>();
        public string name;
        public string famil;
        public string fathername;
        public string work;
        public int level;
        public int hardly;
       
        public void Print()
        {
            Cafedra cafedra = new Cafedra();
            Console.WriteLine("Print name employees: "); cafedra.name = Console.ReadLine();
            Console.WriteLine("Print surname employees: "); cafedra.famil = Console.ReadLine();
            Console.WriteLine("Print patronymic employees: "); cafedra.fathername = Console.ReadLine();
            Console.WriteLine("Print position employees: "); cafedra.work = Console.ReadLine();
            Console.WriteLine("Print level employees: "); cafedra.level = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Print hardly employees: "); cafedra.hardly = Convert.ToInt32(Console.ReadLine());
            lists.Add(cafedra);
        }      

        public void Output()
        {
            foreach (Cafedra a in lists)
            {
                Console.WriteLine("Name empoyees: " + a.name + "\nSurname empoyees: " + a.famil + "\nPatronymic empoyees: " + a.fathername + "\nPosition empoyees: " + a.work + "\nAcademic degree of empoyees: " + a.level + "\nLoad of empoyees: " + a.hardly + "\n");
            }
        }

       public void Menu()
       {
            Cafedra cafedra = new Cafedra();
            do
            {
                Console.WriteLine("[1]. Print information about employees.\n[2]. Output information about employees.\n[3]. Exit.");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Please, print number of employees to save information to the database: "); int h = Convert.ToInt32(Console.ReadLine());
                        for (int j = 0; j < h; j++)
                        {
                            cafedra.Print();
                        }
                        break;
                    case 2:
                        cafedra.Output();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ошибка.");
                        break;
                }
            } while (true);
        }
    }   
}

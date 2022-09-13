using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SpaceShuttle
{
    internal class Program
    {
        struct structure
        {
            public string missionCode;
            public string LaunchingDate;
            public string spaceShuttleName;
            public int dayCount;
            public double hourInSpaceCount;
            public string airBaseName;
            public int memberCount;
        }
        static void Main(string[] args)
        {
            List<structure> lst = new List<structure>();
            FileStream fs = new FileStream("kuldetesek.csv", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                string tmp = sr.ReadLine();
                string[] removeTmb = tmp.Split(';');
                structure s = new structure();
                s.missionCode = removeTmb[0];
                s.LaunchingDate = removeTmb[1];
                s.spaceShuttleName = removeTmb[2];
                s.dayCount = Convert.ToInt32(removeTmb[3]);
                s.hourInSpaceCount = Convert.ToDouble(removeTmb[4]);
                s.airBaseName = removeTmb[5];
                s.memberCount = Convert.ToInt32(removeTmb[6]);
                lst.Add(s);
            }
            sr.Close();
            fs.Close();

            //Debug

            //for (int i = 0; i < lst.Count; i++)
            //{
            //    Console.WriteLine($" {lst[i].missionCode}\n {lst[i].LaunchingDate}\n {lst[i].spaceShuttleName}\n {lst[i].dayCount}\n {lst[i].hourInSpaceCount}\n {lst[i].memberCount}");
            //}

            Feladat3(lst);
            Feladat4(lst);
            Feladat5(lst);
            Feladat6(lst);
            Feladat7(lst);
            Feladat8(lst);
            Console.ReadKey();
        }

        static void Feladat3(List<structure> lst)
        {
            Console.WriteLine("3. feldat:");
            Console.WriteLine($"\tÖsszesen {lst.Count} alkalommal indítottak űrhajót.");
        }
        static void Feladat4(List<structure> lst)
        {
            Console.WriteLine("4. feldat:");
            int sum = 0;
            foreach (var i in lst)
            {
                sum += i.memberCount;
            }
            Console.WriteLine($"\t{sum} utas indult az űrbe összesen.");
        }
        static void Feladat5(List<structure> lst)
        {
            Console.WriteLine("5. feladat:");
            int count = 0;
            foreach (var i in lst)
            {
                if (i.memberCount < 5)
                {
                    count++;
                }
            }
            Console.WriteLine($"\tÖsszesen {count} alkalommal küldtek kevesebb, mint 5 embert az űrbe.");
        }
        static void Feladat6(List<structure> lst)
        {
            Console.WriteLine("6. feladat:");
            int aCount = 0;
            Console.WriteLine($"\t{aCount} volt a Columbia fedélzetén annak utolsó útján");
        }
        static void Feladat7(List<structure> lst)
        {
            Console.WriteLine("7. feladat:");
            double time = 0;
            int tmp = 0;
            for (int i = 0; i < lst.Count; i++)
            {
                if (time < lst[i].hourInSpaceCount)
                {
                    tmp = i;
                    time = lst[i].hourInSpaceCount;
                }
            }
            Console.WriteLine($"\tA leghosszabb ideig a Columbia volt az űrben a {lst[tmp].missionCode} küldetés során.\n\tÖsszesen {time} órát volt távol a Földtől");
        }
        static void Feladat8(List<structure> lst)
        {
            Console.WriteLine("8. feladat:");
            Console.Write("\tÉvszám: ");
            string year = Console.ReadLine();
            bool have = false;
            int count = 0;
            foreach (var i in lst)
            {
                if (year == i.LaunchingDate)
                {

                }
            }
        }
    }
}

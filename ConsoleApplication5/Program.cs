using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, string, bool> std = new Tuple<int, string, bool>(0, "Yousif", true);
            Tuple<int, string, bool> std1 = new Tuple<int, string, bool>(1, "Ali", false);
            Tuple<int, string, bool> std2 = new Tuple<int, string, bool>(2, "Yassin", true);

            List<Tuple<int,string,bool>> student = new List<Tuple<int,string,bool>>();
            student.Add(std);
            student.Add(std1);
            student.Add(std2);

            Present(student);
            Abcent(student);
        }
        static void Present(List<Tuple<int,string,bool>> data)
        {
            foreach (var item in data)
            {
                if (item.Item3)
                {
                    Console.WriteLine("Present "+item.Item2);
                }
            }
        }
        static void Abcent(List<Tuple<int,string,bool>>data)
        {
            foreach (var item in data)
            {
                if (!item.Item3)
                {
                    Console.WriteLine("Abecnt " + item.Item2);
                }
            }
        }
    }
}

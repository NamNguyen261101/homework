using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btvnless1
{
    public class Program
    {
        

        static void Bai1()
        {
            DateTime birthday;
            Console.Write("Nhap ngay sinh:");
            birthday = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ngay sinh:{0:dd/MM/yyyy}", birthday);
        }

    }

   
}

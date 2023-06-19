using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class program
    {
        static void Main(string[] args)
        {
            person person1 = new person ("Uchup Bensin", 21);
            person1.Infoperson();

            //inheritance
            Karyawan karyawan = new Karyawan("Alinko", "Admin");
            karyawan.InfoKaryawan();

            Console.ReadLine();
        }
    }
}
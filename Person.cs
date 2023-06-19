using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
     public class person
    {
        //properties
        public string Name;
        public int Age;

        //constructor
        public person (string name, int Age)
        {
            this.Name = name;
            this.Age = Age;
        }

        public person()
        {

        }
        //fungsi
        public void Infoperson()
        {
            Console.WriteLine("Nama Saya {0}, dan umur saya {1} tahun ", this.Name, this.Age);
        }

    }

    // CLAS TURUNAN
    public class Karyawan : person
    {
        public string KaryawanID { get; set; }
        public string Subject { get; set; }

        public Karyawan(string karyawanID, string subject)
         
        {
            KaryawanID = karyawanID;
            Subject = subject;
        }

        public void InfoKaryawan()
        {
            Console.WriteLine("Nama Saya {0} Saya disini sebagai {1}", KaryawanID, Subject);
        }
    }
}
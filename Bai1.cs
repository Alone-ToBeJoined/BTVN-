using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNV1
{
    internal class Bai1
    {
        public static void thongTinSinhVien() 
        {
            string name, gender, birthday, email, fatherName, motherName, id, age, address;

            //khai bao cac bien la cac thong tin cua sinh vien

            Console.WriteLine("Enter infomation :");
            Console.WriteLine("--------------**--------------");

            Console.WriteLine("Enter name");
            name = Console.ReadLine();

            Console.WriteLine("Enter gender");
            gender = Console.ReadLine();
           
            Console.WriteLine("Enter birthday");
            birthday = Console.ReadLine();

            Console.WriteLine("Enter Email");
            email = Console.ReadLine();

            Console.WriteLine("Enter Father's name");
            fatherName = Console.ReadLine();

            Console.WriteLine("Enter Mother's name");
            motherName = Console.ReadLine();

            Console.WriteLine("Enter ID");
            id = Console.ReadLine();

            Console.WriteLine("Enter Age");
            age = Console.ReadLine();

            Console.WriteLine("Enter address");
            address = Console.ReadLine();
            
            //lay gia tri cua cac bien tu ban phim

            Console.WriteLine("*** Studen information ***");
            Console.WriteLine("{0}", name);
            Console.WriteLine("{0}", gender);
            Console.WriteLine("{0}", birthday);
            Console.WriteLine("{0}", email);
            Console.WriteLine("{0}", fatherName);
            Console.WriteLine("{0}", motherName);
            Console.WriteLine("{0}", id);
            Console.WriteLine("{0}", age);
            Console.WriteLine("{0}", address);

            //in ra man hinh gia tri cac bien

            Console.ReadKey();
        }
    }
}

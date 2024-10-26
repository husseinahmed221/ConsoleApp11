using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{

    class vehicle

    {
       private string brand;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

    }
    class motorevehicle:vehicle
    {
        private string modelname;
        public string Modelname 
        {
            get{ return  modelname; }
            set{ modelname = value; }
        }

    }
    class car :motorevehicle
    {
   

    }
    class truck : motorevehicle
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car obj = new car();
          
            obj.Brand = "Bmw";
            obj.Modelname = "c800";
            Console.WriteLine("Brand car:"+obj.Brand);
            Console.WriteLine("Model Name car:"+obj.Modelname);
            truck obj2 = new truck();
            obj2.Brand = "Mercedes";
            obj2.Modelname = "Actros,Axor,Unimog U 4000 / U 5000";
            Console.WriteLine("Brand truck:"+obj2.Brand);
            Console.WriteLine("Model Name "+obj2.Modelname);
            Console.ReadLine();
        }
    }
}

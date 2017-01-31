using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism
{
    public class BaseClass
    { 

        public virtual void printInfo()
        {

            Console.WriteLine("This is the BaseClass");
        }
    }
    public class DerivedClass_1 : BaseClass
    { 

        public override void printInfo()
        {
             Console.WriteLine("This is the Derrived_1 Class");
        }
    }
    public class DerivedClass_2 : BaseClass
    {
        public override void printInfo()
        {
            Console.WriteLine("This is the Derrived_2 Class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            BaseClass[] bc = new BaseClass[3];
            bc[0] = new DerivedClass_1();
            bc[1] = new DerivedClass_2();
            bc[2] = new BaseClass();

            foreach(BaseClass item  in bc)
            {
                item.printInfo();
            }
            Console.ReadKey();
        }
    }
}

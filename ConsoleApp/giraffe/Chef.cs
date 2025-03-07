using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace giraffe
{
    public class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }

        public virtual void MakeSpecialDish() //virtual means can be overwritten in any subclasses
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }
    }
}
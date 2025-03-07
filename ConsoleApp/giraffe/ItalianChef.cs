using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace giraffe
{
    public class ItalianChef : Chef //want to be able to do everything Chef can do + more specialized dishes [: Chef => inherits functionality of Chef]
    {
        public override void MakeSpecialDish() //override MakeSpecialDish method from the superclass
        {
            Console.WriteLine("The Chef makes chicken parm");
        }
       public void MakePasta()
       {
        Console.WriteLine("The Chef makes pasta");
       } 
    }
}
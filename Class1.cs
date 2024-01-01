using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public interface InterfaceCube
    {
        int cube();
    }
    public interface InterfaceSquare
    { 
        int square();
    }
    internal class Class1
    {
        public int x_1;
        public Class1(int x)
        { 
            x_1 = x;
        }

    }
    public class Inter : InterfaceSquare, InterfaceCube
    {
        public int x_1;
        public Inter(int x_1)
        {
            this.x_1 = x_1;
        }

        public int cube()
        {
            return x_1 * x_1 * x_1;
        }
        public int square()
        {
            return x_1 * x_1;
        }
    }
}

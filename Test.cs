using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAndPolymorphismHW
{
    class Test
    {
        static void Main()
        {
            List<object> listOfShapes = new List<object>();

            try
            {
                listOfShapes.Add(new Circle(6));
                listOfShapes.Add(new Circle(26.5));
                listOfShapes.Add(new Triangle(2, 8, 7, 8));
                listOfShapes.Add(new Triangle(26.5, 54.6, 23.4, 23.4));
                listOfShapes.Add(new Rectangle(6, 5));
                listOfShapes.Add(new Rectangle(25.6, 85.2));

                foreach (var shape in listOfShapes)
                {
                    Console.WriteLine(shape);
                }
            }
            catch (Triangle.TriangleDimensionsException triangleException)
            {
                Console.Error.WriteLine(triangleException.Message + "\n\r" + triangleException.StackTrace);
            }
            catch (ArgumentNullException arNullException)
            {
                Console.Error.WriteLine(arNullException.Message + "\n\r" + arNullException.StackTrace);
            }
            catch (ArgumentOutOfRangeException arOutOfRangeException)
            {
                Console.Error.WriteLine(arOutOfRangeException.Message + "\n\r" + arOutOfRangeException.StackTrace);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        public static int[] b = {
        };

        static void Main(string[] args)
        {

            var Prueba = new List<Ejemplo_obj.PruebaList>();

            Prueba.Add(new Ejemplo_obj.PruebaList()
            {
                P1 = "crank arm",
                P2 = "Prueba 2"
            });

            T1(Prueba);



        }
        public static void T1(List<Ejemplo_obj.PruebaList> P1)
        {        
                      // List<string> strings = P2.Select(s => (string)s).ToList();

            foreach (object item in P1)
            {
                Console.WriteLine("Primer row");
                Console.WriteLine(item.GetType().GetProperties());

                string Resultado = "";
                foreach (var fieldInfo in item.GetType().GetProperties())
                {

                        var Key = fieldInfo.GetMethod.Name.Replace("get_", "");
                        var Value = fieldInfo.GetValue(item);

                    Resultado += Value + "|";
                    Console.WriteLine("Nombre: {0} - Valor: {1} - COUNT{2} ", Key, Value, fieldInfo.PropertyType.GetProperties());
                 }

                Console.WriteLine(Resultado);
               
            }


            Console.ReadKey();
        }


    }
}

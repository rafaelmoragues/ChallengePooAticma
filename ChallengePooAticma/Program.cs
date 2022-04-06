using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengePooAticma;

namespace ChallengePooAticma
{
    internal class Program
    {
        //creo la clase person
        public class Person
        {
            //propiedades de person
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Birthday { get; set; }

            public Person()
            {

            }

            //constructor parametrizado
            public Person(string nombre, string apellido, string cumpleanos)
            {
                FirstName = nombre;
                LastName = apellido;
                Birthday = cumpleanos;
            }

            //sobrecarga de ToString, devuelve el nombre, espacio, apellido
            public override string ToString()
            {
                return string.Format(FirstName + " " + LastName);
            }
            
            //muestro los datos de la instancia en una oracion
            public  void MyInfo()
            {
                Console.WriteLine("La persona es: " + this.ToString() + " y su cumpleaños es el: " + this.Birthday);
            }
        }

        //Clase employee, hereda de person
        public class Employee : Person
        {
            public int File { get; set; }
            public string Department { get; set; }

            //metodo que esconde el mismo metodo del padre y muestra todos los atributos
            public new void MyInfo()
            {
                Console.WriteLine("La persona es: " + this.ToString() + " y su cumpleaños es el: " + this.Birthday + ". Jugaba al " + 
                    this.Department + " de " + this.File);

            }

        }
        static void Main(string[] args)
        {
            //declaro 3 variables de ejemplo
            string nombre = "Diego";
            string apellido = "Maradona";
            string cumple = "30/10/2022";

            //instancio una persona sin parametros y le seteo los atributos
            Person persona1 = new Person();
            persona1.FirstName = nombre;
            persona1.LastName = apellido;
            persona1.Birthday = cumple;

            //instancio otra persona con parametros por constructor
            Person persona2 = new Person(nombre, apellido, cumple);

            //Llamo al metodo myinfo de persona para que muestre su info
            persona1.MyInfo();
            Console.ReadLine();

            //metodo para comparar dos person
            bool Comparar(Person a, Person b)
            {
                if (a.Birthday == b.Birthday && a.FirstName == b.FirstName && a.LastName == b.LastName)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                //Si se hiciera con Equals daria siempre false
                //return a.Equals(b);
            }

            //Comparo las dos instancias, llamo al metodo comparar
            if (Comparar(persona1, persona2))
            {
                Console.WriteLine("Son iguales");
                Console.ReadLine();
            }

            //instancio un employee que hereda de person, seteo atributos, propios y del padre
            Employee emp = new Employee();
            emp.FirstName = nombre;
            emp.LastName = apellido;
            emp.Birthday = cumple;
            emp.File = 10;
            emp.Department = "Futbol";

            //llamo al metodo info de empleado, que esconde al del padre
            emp.MyInfo();
            Console.ReadKey();
        }
    }
}

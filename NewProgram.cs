using System;
using  System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetAnotherTest
{
  internal class Program
  {
    public static void Main(string[] args)
    { /*
      Rectangulo rec = new Rectangulo();
      rec.Base = 20;
      rec.Altura = 5;

     int area = rec.CalcuArea();
     Console.WriteLine("Rectangulo: "+rec.Base+" * "+rec.Altura+"\nArea: "+area);
     
     // Sintaxis de inicialización
     Rectangulo rectan = new Rectangulo {Base = 10, Altura = 15};

     int area2 = rectan.CalcuArea();
     Console.WriteLine("Rectangulo: "+rectan.Base+" * "+rectan.Altura+"\nArea: "+area2); */
      // Constructores

      Obrero fulano1 = new Obrero("114589", "Juan", "De la Mar", 3250);
      Console.WriteLine("Matricula del trabajador: "+fulano1.MatriTrabajador+"\nNombre del trabajador: "+fulano1.Nombre+" "+fulano1.Apellido+"\nSalario: "+fulano1.Salario);
      
      Obrero fulano2 = new Obrero("125683", "Armando", "Polainas", 4650);
      Console.WriteLine("\nMatricula del trabajador: "+fulano2.MatriTrabajador+"\nNombre del trabajador: "+fulano2.Nombre+" "+fulano2.Apellido+"\nSalario: "+fulano2.Salario);
    }
  }
}
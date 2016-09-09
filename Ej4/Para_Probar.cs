using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
         out0:
            Console.Clear();
            Console.WriteLine("..:: Numeros Complejos ::..");
            Console.WriteLine("Ingrese su numero complejo por partes...");
            Console.WriteLine("Parte Real:");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Parte imaginaria:");
            double numi = Convert.ToDouble(Console.ReadLine());
            if (numi < 0) { Console.WriteLine("El numero complejo es:   {0} {1}i", num, numi); }
            else { Console.WriteLine("El numero complejo es:   {0} + {1}i", num, numi); }
            Console.ReadLine();
            Complejo hola = new Complejo(num, numi);
         out1:
            Console.Clear();
            Console.WriteLine("Que quiere calcular?");
            Console.WriteLine("1: Argumento");
            Console.WriteLine("2: Magnitud");
            Console.WriteLine("3: Conjugado");
            Console.WriteLine("4: Comparar");
            Console.WriteLine("5: Realizar operaciones (+ - * /)");
            Console.WriteLine("6: Cambiar el numero ingresado");
            Console.WriteLine("7: Salir");
            int op = Convert.ToInt32 (Console.ReadLine());
            Console.Clear();
            switch (op)
            { 
                case 1:
                    out2:
                    Console.Clear();
                    Console.WriteLine("Argumento");
                    Console.WriteLine("1: En Radianes");
                    Console.WriteLine("2: En Grados");
                    Console.WriteLine("3: Volver al menu anterior");
                    Console.Clear();
                    int aux = Convert.ToInt32(Console.ReadLine());
                    if (aux == 1)
                    {
                        num = hola.ArgumentoEnRadianes();
                        Console.WriteLine("Arg Rad:{0} Rad", num);
                        Console.ReadKey();
                        goto out2;
                    }
                    else
                    {
                        if (aux == 2)
                        {
                            num = hola.ArgumentEnGrados();
                            Console.WriteLine("Arg Grad: {0}°", num);
                            Console.ReadKey();
                            goto out2;
                        }
                        else { goto out1; }
                    }
                case 2:
                    num = hola.Magnitud();
                    Console.WriteLine("La magnitud del numero es: {0}", num);
                    Console.ReadKey();
                    goto out1;

                case 3:
                    Complejo auxC = new Complejo(0, 0);
                    auxC = auxC.Conjugado();
                    if (hola.Imaginario < 0) { Console.WriteLine("El conjugado del numero: {0} {1}i", hola.Real, hola.Imaginario); }
                    else { Console.WriteLine("El numero complejo es:   {0} + {1}i", hola.Real, hola.Imaginario); }
                    if (auxC.Imaginario < 0) { Console.WriteLine("Es: {0} {1}i", auxC.Real, auxC.Imaginario); }
                    else { Console.WriteLine("Es: {0} + {1}i", auxC.Real, auxC.Imaginario); }
                    Console.ReadKey();
                    goto out1;

                case 4:
                    Console.WriteLine("Ingrese el numero a comparar: ");
                    Console.WriteLine("Parte Real:");
                    num = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Parte imaginaria:");
                    numi = Convert.ToDouble(Console.ReadLine());
                    if (hola.EsIgual(num, numi) == true) { Console.WriteLine("Son iguales"); }
                    else { Console.WriteLine("No son iguales"); }
                    /*
                    Complejo auxC = new Complejo(num, numi);
                    hola.EsIgual(auxC);
                    */
                    Console.ReadKey();
                    goto out1;

                case 5:
                 out3:
                    Console.Clear();
                    Console.WriteLine("Eliga la operacion:");
                    Console.WriteLine("1: Sumar");
                    Console.WriteLine("2: Restar");
                    Console.WriteLine("3: Multiplicar");
                    Console.WriteLine("4: Dividir");
                    Console.WriteLine("5: Volver al menu anterior");
                    string opcion = Console.ReadLine();
                    Console.Clear();
                    switch (opcion)
                    {
                        case "1":
                            Console.WriteLine("Ingrese el numero a sumar: ");
                            Console.WriteLine("Parte Real:");
                            num = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Parte imaginaria:");
                            numi = Convert.ToDouble(Console.ReadLine());
                            Complejo auxCom = new Complejo(num, numi);
                            auxCom = hola.Sumar(auxCom);
                            if (auxCom.Imaginario < 0) { Console.WriteLine("La suma es: {0} {1}i", auxCom.Real, auxCom.Imaginario); }
                            else { Console.WriteLine("La suma es:   {0} + {1}i", auxCom.Real, auxCom.Imaginario); }
                            Console.ReadKey();
                            goto out3;

                        case "2":
                            Console.WriteLine("Ingrese el numero a restar: ");
                            Console.WriteLine("Parte Real:");
                            num = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Parte imaginaria:");
                            numi = Convert.ToDouble(Console.ReadLine());
                            Complejo auxCom2 = new Complejo(num, numi);
                            auxCom2 = hola.Restar(auxCom2);
                            if (auxCom2.Imaginario < 0) { Console.WriteLine("La resta es: {0} {1}i", auxCom2.Real, auxCom2.Imaginario); }
                            else { Console.WriteLine("La resta es:   {0} + {1}i", auxCom2.Real, auxCom2.Imaginario); }
                            Console.ReadKey();
                            goto out3;

                        case "3":
                            Console.WriteLine("Ingrese el numero a multiplicar: ");
                            Console.WriteLine("Parte Real:");
                            num = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Parte imaginaria:");
                            numi = Convert.ToDouble(Console.ReadLine());
                            Complejo auxCom3 = new Complejo(num, numi);
                            auxCom3 = hola.MultiplicarPor(auxCom3);
                            if (auxCom3.Imaginario < 0) { Console.WriteLine("La multiplicaciones es: {0} {1}i", auxCom3.Real, auxCom3.Imaginario); }
                            else { Console.WriteLine("La multiplicacion es:   {0} + {1}i", auxCom3.Real, auxCom3.Imaginario); }
                            Console.ReadKey();
                            goto out3;

                        case "4":
                            Console.WriteLine("Ingrese el numero a dividir: ");
                            Console.WriteLine("Parte Real:");
                            num = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Parte imaginaria:");
                            numi = Convert.ToDouble(Console.ReadLine());
                            Complejo auxCom4 = new Complejo(num, numi);
                            auxCom4 = hola.MultiplicarPor(auxCom4);
                            if (auxCom4.Imaginario < 0) { Console.WriteLine("La division es: {0} {1}i", auxCom4.Real, auxCom4.Imaginario); }
                            else { Console.WriteLine("La division es:   {0} + {1}i", auxCom4.Real, auxCom4.Imaginario); }
                            Console.ReadKey();
                            goto out3;


                        case "5": goto out1;
                        default: goto out1;
                    }

                case 6: goto out0;

                case 7: break;
            }

            /*
            Console.WriteLine("Es real? Es Imaginario?  Es igual?  + - / *");

            
            
            

            */
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            out1:
            Console.Clear();
            Console.WriteLine("Seleccione la forma con la cual desea trabajar:");
            Console.WriteLine("1: Triangulo");
            Console.WriteLine("2: Circulo");
            Console.WriteLine("3: Salir");
            string opcion = Console.ReadLine();
            Console.Clear();
            FachadaFiguras cF = new FachadaFiguras();
            switch (opcion)
            {
                case "1": out2:
                    Console.Clear();
                    Console.WriteLine("¿Que desea realizar con el hermoso Triangulo?");
                    Console.WriteLine("1: Calcular Area");
                    Console.WriteLine("2: Calcular Perimetro");
                    Console.WriteLine("3: Cancelar");
                    string op = Console.ReadLine();
                    Console.Clear();
                    if (op == "1")
                    {
                        Console.WriteLine("Ingrese el primer punto, x y luego y");
                        double x1 = Convert.ToDouble(Console.ReadLine());
                        double y1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese 2do punto, x y luego y");
                        double x2 = Convert.ToDouble(Console.ReadLine());
                        double y2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese 3er punto, x y luego y");
                        double x3 = Convert.ToDouble(Console.ReadLine());
                        double y3 = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Los puntos son: ({0}, {1}) ({2}, {3}) ({4}, {5})", x1,y1,x2,y2,x3,y3);
                        double valor = cF.CalcularAreaTriangulo(x1, x2, x3, y1, y2, y3);
                        Console.WriteLine("El Area del Triangulo es: {0}", valor);
                        Console.ReadKey();
                        goto out2;

                    }
                    else { if (op == "2")
                        {
                            Console.WriteLine("Ingrese el primer punto, x y luego y");
                            double x1 = Convert.ToDouble(Console.ReadLine());
                            double y1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese 2do punto, x y luego y");
                            double x2 = Convert.ToDouble(Console.ReadLine());
                            double y2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese 3er punto, x y luego y");
                            double x3 = Convert.ToDouble(Console.ReadLine());
                            double y3 = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("Los puntos son: ({0}, {1}) ({2}, {3}) ({4}, {5})", x1, y1, x2, y2, x3, y3);
                            double valor = cF.CalcularPerimetroTriangulo(x1, x2, x3, y1, y2, y3);
                            Console.WriteLine("El Perimetro del Triangulo es: {0}", valor);
                            Console.ReadKey();
                            goto out2;
                        }
                        else goto out1;
                    }
                    break;
                case "2": out3:
                    Console.WriteLine(" ¿Que desea realizar con el hermoso Circulo?");
                    Console.WriteLine("1: Calcular Area");
                    Console.WriteLine("2: Calcular Perimetro");
                    Console.WriteLine("3: Cancelar");
                    string ope = Console.ReadLine();
                    Console.Clear();
                    if (ope == "1")
                    {
                        Console.WriteLine("Ingrese los puntos para el centro del circulo : X y luego Y");
                        double x1 = Convert.ToDouble(Console.ReadLine());
                        double y1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ahora ingrese el radio del estimado Circulo:");
                        double rad = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Centro del circulo: ({0}, {1}) y radio: {2}",x1,y1,rad);
                        double valor = cF.CalcularAreaCirculo(x1, y1, rad);
                        Console.WriteLine("El Area del Circulo es: {0}", valor);
                        Console.ReadKey();
                        goto out3;
                    }
                        else { if (ope == "2")
                        {
                            Console.WriteLine("Ingrese los puntos para el centro del circulo : X y luego Y");
                            double x1 = Convert.ToDouble(Console.ReadLine());
                            double y1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ahora ingrese el radio del estimado Circulo:");
                            double rad = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("Centro del circulo: ({0}, {1}) y radio: {2}", x1, y1, rad);
                            double valor = cF.CalcularPerimetroCirculo(x1, y1, rad);
                            Console.WriteLine("El Perimetro del Circulo es: {0}", valor);
                            Console.ReadKey();
                            goto out3;
                        }
                        else goto out1;
                    }
                    break;
                default: break;
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Prueba

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ayudante ayuda = new Ayudante();
            Cuentas cuentas = new Cuentas();
            out1:
            Console.Clear();
            Console.WriteLine("¿Qué desea realizar?");
            Console.WriteLine("1: Caja Ahorro");
            Console.WriteLine("2: Cuenta Corriente");
            Console.WriteLine("3: Transferencia");
            Console.WriteLine("0: Salir");
            int auxP = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (auxP)
            {
                case 0: break;
                case 1:
                    out2:
                    Console.WriteLine("Operaciones:");
                    Console.WriteLine("1: Acreditar");
                    Console.WriteLine("2: Descontar");
                    Console.WriteLine("3: Consultar Saldo");
                    Console.WriteLine("0: Cancelar");
                    int aux = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (aux == 0) { goto out1; }
                    if (aux == 1)
                    {
                        Console.WriteLine("Ingrese el monto a acreditar:");
                        double auxSaldo1 = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        auxSaldo1 = ayuda.Acreditar(auxSaldo1, auxP, cuentas);
                        Console.WriteLine("El nuevo monto es: {0}", auxSaldo1);
                        Console.ReadKey();
                        goto out1;
                    }
                    else
                    {
                        if (aux == 2)
                        {
                            Console.WriteLine("Ingrese el monto a descontar:");
                            double auxSaldo2 = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                            double varAux = ayuda.Descontar(auxSaldo2, auxP, cuentas);
                            if (varAux == -99)
                            {
                                Console.WriteLine("Error");
                            }
                            else { Console.WriteLine("Modificado con exito"); }
                            
                        }
                        if (aux == 3)
                        {
                            if (auxP == 1)
                            {
                                double saldo = cuentas.CajaAhorro.Saldo;
                                Console.WriteLine("En la Caja de Ahorro hay: {0}", saldo);
                                Console.WriteLine("Y el Acuerdo es: {0}", cuentas.CajaAhorro.Acuerdo);
                            }
                            else
                            {
                                if (auxP == 2)
                                {
                                    double saldo = cuentas.CuentaCorriente.Saldo;
                                    Console.WriteLine("En la Cuenta Corriente hay: {0}", saldo);
                                    Console.WriteLine("Y el Acuerdo es: {0}", cuentas.CuentaCorriente.Acuerdo);
                                }
                            }
                        }
                        Console.ReadKey();
                        goto out1;
                    }

                case 2: goto out2;
                case 3:
                    Console.WriteLine("1: De Caja de Ahorro a Cuenta Corriente");
                    Console.WriteLine("2: De Cuenta Corriente a Caja de Ahorro");
                    Console.WriteLine("0: Cancelar");
                    aux = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Ingrese el monto a transferir:");
                    double auxSaldo = Convert.ToDouble(Console.ReadLine());
                    bool var = ayuda.Transferir(auxSaldo, aux, cuentas);
                    if (var == true) { Console.WriteLine("Transferido con exito"); }
                    else { Console.WriteLine("Error"); }
                    Console.ReadKey();
                    goto out1;
            }
        }
    }
}

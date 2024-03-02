using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    namespace Dasafio_3_Try_Catch_Finally
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                try
                {
                    // Leer dos valores del usuario
                    Console.WriteLine("Introduzca el primer valor:");
                    string valor1 = Console.ReadLine();

                    Console.WriteLine("Introduzca el segundo valor:");
                    string valor2 = Console.ReadLine();

                    // Convertir las cadenas a enteros
                    int num1 = int.Parse(valor1);
                    int num2 = int.Parse(valor2);

                    // Sumar los valores
                    int suma = num1 + num2;

                    // Mostrar el resultado
                    Console.WriteLine("La suma es: " + suma);
                }
                catch (FormatException ex)
                {
                    // Mostrar mensaje de error si no se pueden convertir a enteros
                    Console.WriteLine("Error al convertir los valores a números: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error general
                    Console.WriteLine("Error al sumar los valores: " + ex.Message);
                }
                finally
                {
                    // Se ejecuta siempre, incluso si hay errores
                    Console.WriteLine("Proceso finalizado");
                }
            }
        }
    }



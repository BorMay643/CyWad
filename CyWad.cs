using System;
public class CyWad {
    static public void Main() {
        while (true) {
            Console.Clear();
            Console.WriteLine("\nCalculadora de potencia");
            Console.WriteLine("Escribe un numero: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe la potencia: ");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine("{0} a la potencia de {1} es {2}", valor1,valor2,Math.Pow(valor1,valor2));
            Console.WriteLine("\nQuieres seguir usando el programa? (y/n)");
            string seguir = Console.ReadLine();
            switch (seguir) {
                case "y":
                    continue;
                case "n":
                    break;
                default:
                    do
                    {
                        Console.WriteLine("Usa y o n como respuesta");
                        Console.WriteLine("Quieres seguir usando el programa? (y/n)");
                        seguir = Console.ReadLine();
                    } while (seguir != "y" && seguir != "n");
                    if (seguir == "y") {
                        continue;
                    }
                    break;
            }
            break;
        }
    }
}
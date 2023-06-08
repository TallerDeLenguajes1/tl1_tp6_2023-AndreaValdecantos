// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a=10;
// b=a;
// Console.WriteLine("valor de a:"+a);
// Console.WriteLine("valor de b:"+b);

//EJERCICIO 1

// string numeroAInvertir;
// int numero = 0;
// string numeroInvertido = "";
// Console.WriteLine("Ingrese un número");
// numeroAInvertir = Console.ReadLine();

// if (int.TryParse(numeroAInvertir, out numero))
// {
//     if (numero > 0)
//     {
//         while (numero > 1)
//         {
//             numeroInvertido = numeroInvertido + (numero % 10);
//             numero = numero/10;
//         }
//     }
// } else {
//     Console.WriteLine("El número no es válido");
// }

// Console.WriteLine(numeroInvertido);

//EJERCICIO 2
int eleccion = 1;
double numero1;
double numero2;
double resultado;

while (eleccion != 0)
{
    Console.WriteLine("Ingrese la operación");
    Console.WriteLine("1_ Sumar");
    Console.WriteLine("2_ Restar");
    Console.WriteLine("3_ Multiplicar");
    Console.WriteLine("4_ Dividir");
    Console.WriteLine("5_ Valor absoluto");
    Console.WriteLine("6_ Cuadrado");
    Console.WriteLine("7_ Raíz cuadrada");
    Console.WriteLine("8_ Seno");
    Console.WriteLine("9_ Coseno");
    Console.WriteLine("10_ Parte entera");
    Console.WriteLine("11_ Máximo entre dos números");
    Console.WriteLine("12_ Mínimo entre dos números");
    Console.WriteLine("0_ Salir");
    Console.WriteLine("-----------");
    Console.WriteLine("OPERACIÓN");
    Console.WriteLine("-----------");
    eleccion = Convert.ToInt16(Console.ReadLine());

    if (eleccion != 0)
    {
        if (eleccion != 5 && eleccion != 6 && eleccion != 7 && eleccion != 8 && eleccion != 9 && eleccion != 10)
        {
            Console.WriteLine("Ingrese un número");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            numero2 = Convert.ToDouble(Console.ReadLine());
            switch (eleccion)
            {
                case 1:
                    resultado = numero1 + numero2;
                    Console.WriteLine("Resultado de " + numero1 + " + " + numero2 + " : " + resultado);
                    break;
                case 2:
                    resultado = numero1 - numero2;
                    Console.WriteLine("Resultado de " + numero1 + " - " + numero2 + " : " + resultado);
                    break;
                case 3:
                    resultado = numero1 * numero2;
                    Console.WriteLine("Resultado de " + numero1 + " * " + numero2 + " : " + resultado);
                    break;
                case 4:
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine("Resultado de " + numero1 + " / " + numero2 + " : " + double.Round(resultado, 2));
                    }
                    else
                    {
                        Console.WriteLine("No es posible dividir en cero");
                    }
                    break;
                case 11:
                    resultado = Math.Max(numero1, numero2);
                    Console.WriteLine("El máximo entre " + numero1 + " * " + numero2 + " : " + resultado);
                    break;
                case 12:
                    resultado = Math.Min(numero1, numero2);
                    Console.WriteLine("El mínimo entre " + numero1 + " * " + numero2 + " : " + resultado);
                    break;
                default:
                    break;
            }

            Console.WriteLine("Apriete una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Ingrese un número");
            numero1 = Convert.ToDouble(Console.ReadLine());
            switch (eleccion)
            {
                case 5:
                    resultado = Math.Abs(numero1);
                    Console.WriteLine("Valor absoluto de " + numero1 + " : " + resultado);
                    break;
                case 6:
                    resultado = Math.Pow(numero1, 2);
                    Console.WriteLine("El cuadrado de " + numero1 + " : " + resultado);
                    break;
                case 7:
                    resultado = Math.Sqrt(numero1);
                    Console.WriteLine("La raíz cuadrada de " + numero1 + " : " + resultado);
                    break;
                case 8:
                    resultado = Math.Sin(numero1);
                    Console.WriteLine("Seno de " + numero1 + " : " + resultado);
                    break;
                case 9:
                    resultado = Math.Cos(numero1);
                    Console.WriteLine("Coseno de " + numero1 + " : " + resultado);
                    break;
                case 10:
                    resultado = Math.Floor(numero1);
                    Console.WriteLine("Parte entera de " + numero1 + " : " + resultado);
                    break;
                default:
                    break;
            }

            Console.WriteLine("Apriete una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
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

//no va
// if (int.TryParse(numeroInvertido, out numero))
// {
//     Console.WriteLine(numero);
// }

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
    Console.WriteLine("0_ Salir");
    Console.WriteLine("-----------");
    Console.WriteLine("OPERACIÓN");
    Console.WriteLine("-----------");
    eleccion = Convert.ToInt16(Console.ReadLine());

    if (eleccion != 0)
    {
        Console.WriteLine("Ingrese un número");
        numero1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese otro número");
        numero2 = Convert.ToDouble(Console.ReadLine());
        switch (eleccion)
        {
            case 1:
                Console.WriteLine(numero1);
                Console.WriteLine(numero2);
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
            default:
                break;
        }

        Console.WriteLine("Apriete una tecla para continuar");
        Console.ReadKey();
        Console.Clear();
    }
}

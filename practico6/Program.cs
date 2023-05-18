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
string operacion;
int eleccion = 2;
string numeroA;
float numero1 = 0;
string numeroB;
float numero2 = 0;
float resultado = 0;

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
    operacion = Console.ReadLine();
    Console.WriteLine("Ingrese un número");
    numeroA = Console.ReadLine();
    Console.WriteLine("Ingrese otro número");
    numeroB = Console.ReadLine();

    if (int.TryParse(operacion, out eleccion) && float.TryParse(numeroA, out numero1) && float.TryParse(numeroB, out numero2))
    {
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
                }
                else
                {
                    Console.WriteLine("No es posible dividir en cero");
                }
                Console.WriteLine("Resultado de " + numero1 + " / " + numero2 + " : " + float.Round(resultado, 2));
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
        Console.WriteLine("Las datos ingresados no son válidos");
    }
}

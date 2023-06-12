// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a=10;
// b=a;
// Console.WriteLine("valor de a:"+a);
// Console.WriteLine("valor de b:"+b);

//EJERICIO 1
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

// EJERCICIO 4

// Console.WriteLine("Ingrese una frase:");
// string fraseUno = Console.ReadLine();
// Console.WriteLine("Longitud de la frase \"" + fraseUno + "\": " + fraseUno.Length);

// Console.WriteLine("Ingrese otra frase:");
// string fraseDos = Console.ReadLine();
// Console.WriteLine(fraseUno + " " + fraseDos);

// string[] subcadenas = fraseUno.Split();
// foreach (var subcadena in subcadenas)
// {
//     Console.WriteLine("Subcadena: " + subcadena);
// }

// foreach (var elemento in fraseUno)
// {
//     Console.WriteLine(elemento);
// }

// //ocurrencias
// Console.WriteLine("Ingrese la palabra que desea buscar:");
// string palabraBuscada = Console.ReadLine();
// var ocurrencias = 0;
// foreach (var subcadena in subcadenas)
// {
//     if (subcadena == palabraBuscada)
//     {
//         ocurrencias++;
//     }
// }
// Console.WriteLine($"Cantidad de veces que aparece {palabraBuscada} en la frase: " + ocurrencias);

// fraseUno = fraseUno.ToUpper();
// Console.WriteLine("Frase en mayúsculas: " + fraseUno);
// fraseUno = fraseUno.ToLower();
// Console.WriteLine("Frase en minúsculas: " + fraseUno);

// string fraseTres = "hola-como-estas";
// Console.WriteLine(fraseTres);
// string[] fraseTresSplit = fraseTres.Split("-");
// foreach (var subcadena in fraseTresSplit)
// {
//     Console.WriteLine(subcadena);
// }

Console.WriteLine("Ingrese la operación");
string operacion = Console.ReadLine();
var resultado = 0;
var operando1 = 0;
var operando2 = 0;
    if (operacion.Contains('+'))
    {
        string[] operacionSplit = operacion.Split("+");
        if ((int.TryParse(operacionSplit[0], out operando1)) && (int.TryParse(operacionSplit[1], out operando2)))
        {
            resultado = operando1 + operando2;
        }
        else
        {
            Console.WriteLine("No se pudieron convertir los operandos");
        }
    }
    else if (operacion.Contains('-'))
    {
        string[] operacionSplit = operacion.Split("-");
        if ((int.TryParse(operacionSplit[0], out operando1)) && (int.TryParse(operacionSplit[1], out operando2)))
        {
            resultado = operando1 - operando2;
        }
        else
        {
            Console.WriteLine("No se pudieron convertir los operandos");
        }
    }
    else if (operacion.Contains('*'))
    {
        string[] operacionSplit = operacion.Split("*");
        if ((int.TryParse(operacionSplit[0], out operando1)) && (int.TryParse(operacionSplit[1], out operando2)))
        {
            resultado = operando1 * operando2;
        }
        else
        {
            Console.WriteLine("No se pudieron convertir los operandos");
        }
    }
    else if (operacion.Contains('/'))
    {
        string[] operacionSplit = operacion.Split("/");
        if ((int.TryParse(operacionSplit[0], out operando1)) && (int.TryParse(operacionSplit[1], out operando2)))
        {
            if (operando2 != 0)
            {
                resultado = operando1 / operando2;
            }
            else
            {
                Console.WriteLine("No se puede dividir en cero");
            }
        }
        else
        {
            Console.WriteLine("No se pudieron convertir los operandos");
        }
    }

Console.WriteLine(resultado);
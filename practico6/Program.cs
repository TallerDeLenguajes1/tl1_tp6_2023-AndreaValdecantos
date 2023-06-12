using System.Text.RegularExpressions;

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

// Console.WriteLine("Ingrese la operación");
// string operacion = Console.ReadLine();
// var resultado = 0;
// var operando1 = 0;
// var operando2 = 0;
//     if (operacion.Contains('+'))
//     {
//         string[] operacionSplit = operacion.Split("+");
//         if ((int.TryParse(operacionSplit[0], out operando1)) && (int.TryParse(operacionSplit[1], out operando2)))
//         {
//             resultado = operando1 + operando2;
//         }
//         else
//         {
//             Console.WriteLine("No se pudieron convertir los operandos");
//         }
//     }
//     else if (operacion.Contains('-'))
//     {
//         string[] operacionSplit = operacion.Split("-");
//         if ((int.TryParse(operacionSplit[0], out operando1)) && (int.TryParse(operacionSplit[1], out operando2)))
//         {
//             resultado = operando1 - operando2;
//         }
//         else
//         {
//             Console.WriteLine("No se pudieron convertir los operandos");
//         }
//     }
//     else if (operacion.Contains('*'))
//     {
//         string[] operacionSplit = operacion.Split("*");
//         if ((int.TryParse(operacionSplit[0], out operando1)) && (int.TryParse(operacionSplit[1], out operando2)))
//         {
//             resultado = operando1 * operando2;
//         }
//         else
//         {
//             Console.WriteLine("No se pudieron convertir los operandos");
//         }
//     }
//     else if (operacion.Contains('/'))
//     {
//         string[] operacionSplit = operacion.Split("/");
//         if ((int.TryParse(operacionSplit[0], out operando1)) && (int.TryParse(operacionSplit[1], out operando2)))
//         {
//             if (operando2 != 0)
//             {
//                 resultado = operando1 / operando2;
//             }
//             else
//             {
//                 Console.WriteLine("No se puede dividir en cero");
//             }
//         }
//         else
//         {
//             Console.WriteLine("No se pudieron convertir los operandos");
//         }
//     }

// Console.WriteLine(resultado);


// EJERCICIO 5
// Las regex son cadenas de caracteres basadas en reglas sintácticas que permiten describir secuencias de caracteres. Así, forman parte de los lenguajes regulares, los cuales son un subgrupo de los lenguajes formales, de gran importancia para la tecnología de la información y, especialmente, para el desarrollo de software.
// Una expresión regular puede estar formada, o bien exclusivamente por caracteres normales (como abc), o bien por una combinación de caracteres normales y metacaracteres (como ab*c). Los metacaracteres describen ciertas construcciones o disposiciones de caracteres: por ejemplo, si un carácter debe estar en el inicio de la línea o si un carácter solo debe o puede aparecer exactamente una vez, más veces o menos.
// Las expresiones regulares son particularmente útiles para definir filtros. Las expresiones regulares contienen una serie de caracteres que definen un patrón de texto a hacerse coincidir para confeccionar un filtro más especializado, o general.

// Construir un programa que permita identificar de forma sencilla si la cadena ingresada es una dirección web y otro que una cadena ingresada sea un mail válido.

Console.WriteLine("Ingrese una dirección web");
string direccionWeb = Console.ReadLine();

Console.WriteLine("Ingrese un email");
string email = Console.ReadLine();

if (Regex.IsMatch(direccionWeb, @"^https?:\/\/[\w\-]+(\.[\w\-]+)+[/#?]?.*$"))
{
    Console.WriteLine("Dirección web válida");
} else {
    Console.WriteLine("Dirección web inválida");
}

if (Regex.IsMatch(email, @"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$"))
{
    Console.WriteLine("E-mail válido");
} else {
    Console.WriteLine("E-mail inválido");
}
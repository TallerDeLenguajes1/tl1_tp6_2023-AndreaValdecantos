// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a=10;
// b=a;
// Console.WriteLine("valor de a:"+a);
// Console.WriteLine("valor de b:"+b);

//EJERICIO 1
string numeroAInvertir;
int numero = 0;
string numeroInvertido = "";
Console.WriteLine("Ingrese un número");
numeroAInvertir = Console.ReadLine();

if (int.TryParse(numeroAInvertir, out numero))
{
    if (numero > 0)
    {
        while (numero > 1)
        {
            numeroInvertido = numeroInvertido + (numero % 10);
            numero = numero/10;
        }
    }
} else {
    Console.WriteLine("El número no es válido");
}

Console.WriteLine(numeroInvertido);


// if (int.TryParse(numeroInvertido, out numero))
// {
//     Console.WriteLine(numero);
// }
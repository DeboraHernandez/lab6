// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Ejercicio 1");

Console.WriteLine("Ingrese el numero del mes");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 12)
{
    switch (num)
    {
        case 1:
            Console.WriteLine("Mes: enero");
            break;
        case 2:
            Console.WriteLine("Mes: febrero");
            break;
        case 3:
            Console.WriteLine("Mes: marzo");
            break;
        case 4:
            Console.WriteLine("Mes: abril");
            break;
        case 5:
            Console.WriteLine("Mes: mayo");
            break;
        case 6:
            Console.WriteLine("Mes: junio");
            break;
        case 7:
            Console.WriteLine("Mes: julio");
            break;
        case 8:
            Console.WriteLine("Mes: agosto");
            break;
        case 9:
            Console.WriteLine("Mes: septiembre");
            break;
        case 10:
            Console.WriteLine("Mes: octubre");
            break;
        case 11:
            Console.WriteLine("Mes: noviembre");
            break;
        case 12:
            Console.WriteLine("Mes: diciembre");
            break;
    }
}
else
{
    Console.WriteLine("Error. El numero a ingresar debe estar contenido entre 1 y 12");
}

Console.WriteLine("Ejercicio 2");
Console.WriteLine("Ingrese un numero");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese otro numero");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese otro numero");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine(a + " es el numero mayor");
    }
    else
    {
        if (a == c)
        {
            Console.WriteLine(a + " y " + c + " son iguales y mayores que"+b);
        }
        else
        {
            Console.WriteLine(c + " es el numero mayor");
        }
    }
}
else if (a == b)
{
    if (a > c)
    {
        Console.WriteLine(a + " es el numero mayor");
    }
    else if (a==c)
    {
        Console.WriteLine(a + " y " + b + " son iguales y mayores que "+c);
    }
}
else if (b > c)
{
    Console.WriteLine(b + " es el numero mayor");
}
else if (b==c)
{
    Console.WriteLine(b + " y " + c + " son iguales y mayores que " + a);
}
else
{
    Console.WriteLine(c+" es el numero mayor");
}
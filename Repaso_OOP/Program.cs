// See https://aka.ms/new-console-template for more information

/*Console.WriteLine("Hello sigmotoa");
int edad;
edad = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"Hola, ya sabemos que tienes {edad} años");
double dinero;
dinero = 320.5d;
string name = "sigmotoa";
Console.WriteLine("Hola "+name+" Bienvenido con tus "+dinero+" pesos");

var algo = 0.1f;

Console.WriteLine(dinero*algo);*/


/*
//Operadores aritmeticos
// + - * / %

double numA;
numA = 0.5;
double numB;
numB = 7.1;

Console.WriteLine($"La suma es {numA+numB}\nLa resta es{numA-numB}" +
                  $"\nEl producto es {numA*numB}"+
                  $"\nEl residuo es {numA%numB}"+
                  $"\nEl cociente es {numA/numB}");
                  */


//Operadores Lógicos
//AND, OR, NOT

/*bool datoA = true;
bool datoB = true;

Console.WriteLine(datoA && datoB);
Console.WriteLine(datoA || datoB);
Console.WriteLine(!datoA);
Console.WriteLine(!datoB);*/


/*
//Operadores Relacionales

float numA = 8.7233f;
float numB = 8.7233f;

Console.WriteLine(numA>numB);
Console.WriteLine(numA<numB);
Console.WriteLine(numA==numB);
Console.WriteLine(numA!=numB);
*/


int edad = 0;
Console.WriteLine("Ingrese su edad");

edad = Convert.ToInt16(Console.ReadLine());
string day = "Friday";
bool genero = false;
//False = hombre
//True = mujer

if (edad > 18 && day == "Friday")
{
    if (genero)
    {
        Console.WriteLine("Bienvenido a Piscilago, mi rey");
    }
    else
    {
        Console.WriteLine("Bienvenido a Piscilago, mi reina");
    }
}
else
{
    Console.WriteLine("A dormir bebe");
}
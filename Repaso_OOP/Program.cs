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


/*
int edad = 0;
Console.WriteLine("Ingrese su edad");

edad = Convert.ToInt16(Console.ReadLine());
string day = "Friday";
bool genero = true;
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
}*/


/*
using System.Linq.Expressions;

string caso = "caso9";
Console.WriteLine("Ingrese un caso");
caso = Console.ReadLine();

switch (caso)
{
    case "caso1":
        Console.WriteLine("Soy el Caso1");
        break;
    case "caso2":
        Console.WriteLine("Soy el Caso2");
        break;

    case "caso3":
        Console.WriteLine("Soy el Caso3");
        break;

    case "caso4":
        Console.WriteLine("Caso4");
        break;

    case "caso5":
        Console.WriteLine("Caso5");
        break;

    case "caso6":
        Console.WriteLine("Caso6");
        break;

    case null:
        Console.WriteLine("Bueno");
        break;

    default:
        Console.WriteLine("Toma tu medicina");
        break;


}
*/

/*
int average = 0;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ingrese su nota");
    int num = Convert.ToInt32(Console.ReadLine());

    average = average + num;
}

Console.WriteLine($"El promedo de notas es: {average / 5}");*/

//Recibir el cover de un bar y mostrar cuanto ingreso.

//
// int capacidad = 0;
// double pagos = 0d;
//
// Console.WriteLine("Ingrese la capacidad del bar");
// capacidad = Convert.ToInt32(Console.ReadLine());
//
// for (int i = 1; i <= capacidad; i++)
// {
//     Console.WriteLine($"Usted es la {i} persona en llegar \nPague.");
//     pagos = pagos+ Convert.ToDouble(Console.ReadLine());
// }
// Console.WriteLine($"Nos ganamos {pagos} lukas");
//

string[] countries = new[] { "CO", "MX", "CA", "AU" };

/*

for (int i = 0; i < countries.Length; i++)
{
    Console.WriteLine($"{countries[i]} es el pais en el sitio: {i}" );
}
*/

/*
var i = 0;
while (i<4)

{
    i++;
    Console.WriteLine("Hello");
    Console.WriteLine(countries[i]);

}
*/

//Usando while, haga un ciclo que imprima un 
//Hello a cada paso, pero pregunte si desea conyinuat


/*
List<int> misenteros = new List<int>();

misenteros.Add(10);
misenteros.Add(10);
misenteros.Add(10);
misenteros.Add(10);
misenteros.Add(10);

bool next = false;

do {
    Console.WriteLine("Ingrese un numero entero");
    misenteros.Add(Convert.ToInt16(Console.ReadLine()));
    Console.WriteLine("Desea continuar");
    next = Convert.ToBoolean(Console.ReadLine());
}
while (next) ;

foreach (var dato in misenteros)
{
    Console.WriteLine(dato);
}
*/
//Funciones

//No recibe y no retorna

int valor = 0;

Console.WriteLine(valor);

void f1()
{
    valor++;
}

for (int i = 0; i < 5; i++)
{
    f1();
    Console.WriteLine(f2());
}

Console.WriteLine(valor);

//No recibe, si retorna

int f2()
{
    return valor;
}











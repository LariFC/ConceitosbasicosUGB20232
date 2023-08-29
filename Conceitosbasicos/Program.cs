/*
using Conceitosbasicos;

int num1 = 20;
int num2 = 11, result;

Somador soma;
soma = new Somador();
result = soma.Soma(num1, num2);

Console.WriteLine(result);

-----------------------------------------------------------------------
Console.WriteLine(Conversor.MetrosMilimetros(1.85);
double metros = 1.75 ;
Console.WriteLine($"A medida {metros} metros corresponde a {Conversor.MetrosMilimetros(metros)} milimetros");
*/

using Conceitosbasicos;
int Cont = 1;
Console.WriteLine("Os multiplos de 3 entre 0 e 100 são:");
while (Cont < 100)
{
    if( Multiplos3.Multiplos(Cont) == true)
        {
            Console.WriteLine(Cont);
        }
    else
        {

        }
    Cont++;
}






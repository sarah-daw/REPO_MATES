using MatesLib;

Console.Write("Introdueix un número de l'1 al 9: ");
int numero = Convert.ToInt32(Console.ReadLine());

while (numero < 1 || numero > 9)
{
    Console.Write("Número incorrecte. Torna a introduir un número de l'1 al 9: ");
    numero = Convert.ToInt32(Console.ReadLine());
}

Mates.TaulaMultiplicar(numero);

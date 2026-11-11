namespace MatesLib
{
    public static class Mates
    {
        /// <summary>
        /// Mostra per pantalla la taula de multiplicar de n (de l'1 al 10)
        /// </summary>
        public static void TaulaMultiplicar(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }

        /// <summary>
        /// Suma tots els nombres de l'1 fins a n
        /// </summary>
        public static int SumaFins(int n)
        {
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
                suma += i;
            }
            return suma;
        }
    }
}
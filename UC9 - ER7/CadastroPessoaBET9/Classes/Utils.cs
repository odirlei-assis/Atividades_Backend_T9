namespace CadastroPessoaBET9.Classes
{
    public static class Utils
    {
        public static void BarraCarregamento(string texto, int repeticao, string elemento, int tempo){
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write($"{texto}");

            for (int contador = 0; contador < repeticao; contador++)
            {
                Thread.Sleep(tempo);
                Console.Write($"{elemento}");
            }
            Console.ResetColor();
        }
    }
}
namespace JogoDaForcaV2.ConsoleApp
{
    public static class Arte
    {
        public static void DesenharForca(int quantidadeErros)
        {
            switch (quantidadeErros)
            {
                case 0:
                    Console.WriteLine(" ___________        ");
                    Console.WriteLine(" |/        |        ");
                    Console.WriteLine(" |                  ");
                    Console.WriteLine(" |                  ");
                    Console.WriteLine(" |                  ");
                    Console.WriteLine(" |                  ");
                    Console.WriteLine(" |                  ");
                    Console.WriteLine(" |                  ");
                    Console.WriteLine("_|____              ");
                    break;
                case 1:
                    Console.WriteLine(" ___________        ");
                    Console.WriteLine(" |/                ");
                    Console.WriteLine(" |         o        ");
                    Console.WriteLine(" |                      ");
                    Console.WriteLine(" |                  ");
                    Console.WriteLine(" |                  ");
                    Console.WriteLine(" |                  ");
                    Console.WriteLine(" |                  ");
                    Console.WriteLine("_|____              ");
                    break;
                case 2:
                    Console.WriteLine(" ___________        ");
                    Console.WriteLine(" |/                ");
                    Console.WriteLine(" |         o        ");
                    Console.WriteLine(" |         x            ");
                    Console.WriteLine(" |         x         ");
                    Console.WriteLine(" |                  ");
                    Console.WriteLine(" |                  ");
                    Console.WriteLine(" |                  ");
                    Console.WriteLine("_|____              ");
                    break;
                case 3:
                    Console.WriteLine(" ___________        ");
                    Console.WriteLine(" |/                ");
                    Console.WriteLine(" |         o        ");
                    Console.WriteLine(" |        /x\\             ");
                    Console.WriteLine(" |         x         ");
                    Console.WriteLine(" |                  ");
                    Console.WriteLine(" |                  ");
                    Console.WriteLine(" |                  ");
                    Console.WriteLine("_|____              ");
                    break;
                case 4:
                    Console.WriteLine(" ___________        ");
                    Console.WriteLine(" |/                ");
                    Console.WriteLine(" |         o        ");
                    Console.WriteLine(" |        /x\\             ");
                    Console.WriteLine(" |         x         ");
                    Console.WriteLine(" |        / \\        ");
                    Console.WriteLine(" |                  ");
                    Console.WriteLine(" |                  ");
                    Console.WriteLine("_|____              ");
                    break;
                case 5:
                    Console.WriteLine(" ___________        ");
                    Console.WriteLine(" |/                ");
                    Console.WriteLine(" |         o        ");
                    Console.WriteLine(" |        /x\\             ");
                    Console.WriteLine(" |         x         ");
                    Console.WriteLine(" |        / \\        ");
                    Console.WriteLine(" |       -----          ");
                    Console.WriteLine(" |                  ");
                    Console.WriteLine("_|____              ");
                    break;
            }
            Console.WriteLine("-------------------------------------");
        }
    }
}
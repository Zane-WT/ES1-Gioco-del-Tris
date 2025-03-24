namespace ES1_Gioco_del_Tris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] table = new int[3, 3];

            Console.WriteLine("Inserire nome del giocatore 1");
            string player_1 = Console.ReadLine();
            Console.WriteLine("Inserire nome del giocatore 2");
            string player_2 = Console.ReadLine();
            bool risultatoFinale = false;
            do 
            {
                stampaGrafica(table);
            }while (false);
            


        }
        static void stampaGrafica(int[,] box)
        {
            for(int i = 0; i < 3; i++) 
            {
                Console.WriteLine($"");      
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"| {box[i,j]} |");  
                }
               
                
            }
        }
    }
}

namespace ES1_Gioco_del_Tris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] table = new char[3, 3];

            Console.WriteLine("Inserire nome del giocatore 1");
            string player_1 = Console.ReadLine();
            Console.WriteLine("Inserire nome del giocatore 2");
            string player_2 = Console.ReadLine();
            bool risultatoFinale = false;
            Random rand = new Random();
            int turnoGiocatore = rand.Next(1, 3);
            
            do 
            {
                    for (int i = 0; i < 1; i++) 
                { 
                    if (turnoGiocatore == 1)
                    {
                         TurnoPlayer_1(table,player_1);
                        turnoGiocatore++;
                    }
                    else
                    {
                        
                         TurnoPlayer_2(table, player_2);
                        turnoGiocatore--;
                    
                    }
                }       
            } while (true);
            


        }
        static void stampaGrafica(char[,] box)
        {
            for(int i = 0; i < 3; i++) 
            {
                Console.WriteLine($"");
                Console.Write(i + 1);
                for(int j = 0; j < 3; j++)
                {
                    

                    Console.Write($" |\t{box[i,j]}\t|");  
                }
               
                
            }
        }
        static void TurnoPlayer_1(char[,] box, string nome)
        {
            int righa_player_1;
            int colonna_player_1;
            bool controllo;
            do
            {
                Console.WriteLine($"\nTurno di {nome} il tuo segno è lo 'O' ");
                Console.WriteLine("In che posizione metti il tuo segno:");
                Console.Write("Righa:");
                righa_player_1 = int.Parse(Console.ReadLine());
                Console.Write("Colonna:");
                colonna_player_1 = int.Parse(Console.ReadLine());
                 controllo = controllo_posione(box, righa_player_1, colonna_player_1);
            } while (controllo);

            box[righa_player_1 - 1, colonna_player_1 - 1] = 'O';
            stampaGrafica(box);
            
        }
        static void TurnoPlayer_2(char[,] box,  string nome)
        {
            int righa_player_2;
            int colonna_player_2;
            bool controllo;
            do
            {
                Console.WriteLine($"\nTurno di {nome} il tuo segno è lo 'X' ");
                Console.WriteLine("In che posizione metti il tuo segno:");
                Console.Write("Righa:");
                righa_player_2 = int.Parse(Console.ReadLine());
                Console.Write("Colonna:");
                colonna_player_2 = int.Parse(Console.ReadLine());
                 controllo = controllo_posione(box, righa_player_2, colonna_player_2);
            } while (controllo);

                box[righa_player_2 - 1, colonna_player_2 - 1] = 'X';
            stampaGrafica(box);
            
        }
        static bool controllo_posione(char[,]box,int riga, int colonna)
        {
            if (box[riga, colonna] == 'O' || box[riga, colonna] == 'X')
            {
                Console.WriteLine("La posizione inserita è già occupata.\n" +
                    "Inserire un'altra posozione");
                return true;
            }
            return false;
            //W.I.B
            
        }

    }  
}

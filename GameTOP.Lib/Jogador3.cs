using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador3 : iJogador
    {
         public string Chuta()
        {
            return "teste chuta \n";
        }

        //corre
        public string Corre()
        {
            return "teste corre \n";
        }

        //passe
        public string Passe()
        {
            return "teste passa \n";
        }
        
    }
}
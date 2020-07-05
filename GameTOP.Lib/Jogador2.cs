using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradona estas pateando \n";
        }

        //corre
        public string Corre()
        {
            return "Maradona estas corriendo \n";
        }

        //passe
        public string Passe()
        {
            return "Maradona estas passando \n";
        }
    }
}
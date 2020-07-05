using GameTOP.Interface;

namespace GameTOP.Lib
{
     public class Jogador1 : iJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome = "Marcos")
        {
            _Nome = nome;
        }
        
        //chuta
        public string Chuta()
        {
            return $"{_Nome} está chutando \n";
        }

        //corre
        public string Corre()
        {
            return $"{_Nome} está correndo \n";
        }

        //passe
        public string Passe()
        {
            return $"{_Nome} está passando \n";
        }
    }
}
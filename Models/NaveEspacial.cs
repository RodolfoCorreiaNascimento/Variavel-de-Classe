namespace Variaveis_de_Classe.Models
{
    public class NaveEspacial
    {
        // variaveis de classe
        public static int resistencia;

        // variaveis de instancia
        public string name;
        public string description;
        private int _attackPoints;

        // método construtor
        public NaveEspacial()
        {
            name = "First-R1";
            _attackPoints = 10;
        }

        // método construtor com paramêtros
        public NaveEspacial(string name, int _attackPoints)
        {
            this.name = name;
            this._attackPoints = _attackPoints;
        }

        // método construtor com sobrecarga
        public NaveEspacial(string name, int _attackPoints, string description)
        {
            this.name = name;
            this._attackPoints = _attackPoints;
            this.description = description;
        }

        // set attack points 
        public void SetAttackPoints(int _attackPoints)
        {
            this._attackPoints =  _attackPoints;
        }

        // show attackPoints
        public void ShowAtkPoints()
        {
            System.Console.WriteLine($"Attack points: {this._attackPoints}");
        }
    }
}
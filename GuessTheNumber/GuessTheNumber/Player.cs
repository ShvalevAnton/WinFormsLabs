using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class Player : IComparable<Player>
    {
        // Поля класса
        private string _name; 
        private string _password;
        private int _score;
        public int _bestRes;    //Лучший резултат

        // Конструктор
        public Player(){}

        public Player(string name, int score = 0)
        {
            _name = name;
            _score = score;
        }

        // Свойства
        public string Name
        {
            get => _name; 
            set => _name = value; 
        }
        public string Password
        {
            get => _password;
            set => _password = value;
        }

        public int Score
        {
            get => _score; 
            set => _score = value;
        }

        public int BestRes
        {
            get => _bestRes;
            set => _bestRes = value;
        }

        public void SubScore(int points)
        {
            _score -= points;
            //Console.WriteLine($"{_name} набрал очки: {_score}");            
        }

        public override string ToString() => $"{Name, 10} {BestRes, 10}";

        public int CompareTo(Player other)
        {
            // Сравниваем кол-во очков
            //return this.Score.CompareTo(other.Score);
            return other.BestRes.CompareTo(this.BestRes);
        }       

        public void methBestRes()
        {
            BestRes = BestRes > Score ? BestRes : Score;            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab_4
{
    internal class Tenis {
        private int _score;

        public string _firstPlayer, _secondPlayer;

        public int score { get { return _score; } }

        public string firstPlayer { get => _firstPlayer; set => _firstPlayer = value; }
        public string secondPlayer { get => _secondPlayer; set => _secondPlayer = value; }

        public Tenis() {
            _score = 0;
        }

        public Tenis(string firstPlayer, string secondPlayer) { 
            _firstPlayer = firstPlayer;
            _secondPlayer = secondPlayer;
            _score = 0;
        }

        public void StartGame() {
            Console.WriteLine("Game started");
        }
    }
}

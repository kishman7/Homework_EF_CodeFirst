using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_EF_CodeFirst
{
    public enum GameMode
    {
        singlePlayer = 1,
        multiPlayer
    };

    public class Game
    {
        internal GameMode gameMode;

        //GameMode gameMode = new GameMode();

        public int Id { get; set; }
        public string NameGame { get; set; }
        public string ProducerGame { get; set; }
        public string StyleGame { get; set; }
        public DateTime DateGame { get; set; }
        public int BuyCopyNumber { get; set; }
        public GameMode GameModePlayer { get; set; }

        // Навігаційні властивості можуть бути, якщо будуть зовнішні ключі
    }
}

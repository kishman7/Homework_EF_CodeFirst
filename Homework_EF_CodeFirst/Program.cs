using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_EF_CodeFirst
{
    class Program
    {

        static void Main(string[] args)
        {
            var context = new ApplicationContex();

            GameMode gameMode = default;
            //var game = new Game // додаємо першу гру
            //{
            //    NameGame = "MineCraft",
            //    ProducerGame = "Microsoft",
            //    StyleGame = "Logic",
            //    DateGame = new DateTime(2015, 8, 17),
            //    BuyCopyNumber = 25,
            //    gameMode = GameMode.multiPlayer

            //};
            //context.Games.Add(game);
            context.SaveChanges();

            //var game2 = new Game // додаємо першу гру
            //{
            //    NameGame = "Need For Speed",
            //    ProducerGame = "Ghost Games",
            //    StyleGame = "Speed",
            //    DateGame = new DateTime(2010, 11, 23),
            //    BuyCopyNumber = 37,
            //    gameMode = GameMode.singlePlayer
            //};
            //context.Games.Add(game2);
            context.SaveChanges();

            //using (ApplicationContex db = new ApplicationContex()) // пробував видалити
            //{
            //    var rem = db.Games.Where(x => x.Id == 3);
            //    db.Games.Remove((Game)rem);
            //    db.SaveChanges();
            //}

            using (ApplicationContex db = new ApplicationContex()) // підключаємось до бази і виводимо ігри на екран
            {
                var g = db.Games.ToList();
                foreach (var item in g)
                {
                    Console.WriteLine(item.Id + ". " + item.NameGame + ", " + item.ProducerGame + ", " + item.StyleGame + ", " + item.DateGame
                        + ", " + item.BuyCopyNumber + ", " + item.GameModePlayer);
                }
            }
        }
    }
}

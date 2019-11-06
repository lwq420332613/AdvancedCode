using MyOO.Interface;
using MyOO.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOO.Service
{

    public class iPhone : BasePhone, IExtend, IExtendAdvanced
    {
        public void Photo()
        {
            Console.WriteLine($"{this.GetType().Name} Photo");
        }

        public void Video()
        {
            Console.WriteLine($"{this.GetType().Name} Video");
        }

        public override void Text()
        {
            base.Text();
        }

        //public int Id { get; set; }
        //public string Name { get; set; }
        //public string Branch { get; set; }

        public override void System()
        {
            Console.WriteLine($"{this.GetType().Name} System is IOS");
        }
        //public void Call()
        //{
        //    Console.WriteLine($"Use {this.GetType().Name} Call");
        //}
        //public void Text()
        //{
        //    Console.WriteLine($"Use {this.GetType().Name} Text");
        //}

        public void Game(Game game)
        {
            game.Start();
            game.Play();
        }


    }
}

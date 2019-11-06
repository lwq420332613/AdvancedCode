using MyOO.Interface;
using MyOO.Item;
using MyOO.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOO
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private int Salary { get; set; }

        public void UserIphone(iPhone phone)
        {
            Console.WriteLine("******************");
            phone.Call();
            phone.Text();
        }
        public void UserMi(Mi phone)
        {
            Console.WriteLine("******************");
            phone.Call();
            phone.Text();
        }
        public void UserLumia(Lumia phone)
        {
            Console.WriteLine("******************");
            phone.Call();
            phone.Text();
        }

        /// <summary>
        /// 面向抽象：只能用抽象里面的东西，只能如此
        /// 如果有个性化操作，那就别用抽象了，因为没有意义
        /// </summary>
        /// <param name="phone"></param>
        public void User(BasePhone phone)
        {
            Console.WriteLine("******************");
            phone.Call();
            phone.Text();
            //phone.Video();

            //Game game = new Game();
            //phone.Game(game);//苹果手机专有的
        }

        public void Use<T>(T phone) where T : BasePhone, IExtend
        {
            Console.WriteLine("******************");
            phone.Call();
            phone.Text();
            phone.Video();
        }





        public void PlayIphoneGame(iPhone phone)
        {
            Console.WriteLine("******************");
            Game game = new Game();
            phone.Game(game);
        }


    }
}

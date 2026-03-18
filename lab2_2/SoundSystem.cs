using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2_2
{
    internal class SoundSystem
    {
        public void Subscribe(Player player)
        {
            player.OnDamageTaken += OnDamage;
        }
        public void OnDamage(int hp)
        {
            Console.WriteLine("Sound: звук отримання урону");

            if (hp <= 20)
                Console.WriteLine("Sound: критичний стан!");
        }
    }
}

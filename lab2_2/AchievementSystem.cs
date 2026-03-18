using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2_2
{
    internal class AchievementSystem
    {
        public void Subscribe(Player player)
        {
            player.OnDamageTaken += OnDamage;
        }
        public void OnDamage(int hp)
        {
            if (hp <= 50)
                Console.WriteLine("Achievement: Half Health");

            if (hp <= 0)
                Console.WriteLine("Achievement: First Death");
        }
    }
}

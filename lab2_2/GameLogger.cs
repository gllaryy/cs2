using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2_2
{
    internal class GameLogger
    {
        public void Subscribe(Player player)
        {
            player.OnDamageTaken += OnDamage;
        }
        public void OnDamage(int hp)
        {
            Console.WriteLine($"Log: поточне HP = {hp}");
        }
    }
}

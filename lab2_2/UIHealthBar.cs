using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2_2
{
    internal class UIHealthBar
    {
        public void Subscribe(Player player)
        {
            player.OnDamageTaken += OnDamage;
        }

        public void OnDamage(int hp)
        {
            Console.WriteLine($"UI: HP = {hp}");
        }
    }
}

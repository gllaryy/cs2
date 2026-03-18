using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2_2
{
    internal class Player
    {
        public int Health { get; private set; }
        public event Action<int> OnDamageTaken;
        public Player(int health)
        {
            Health = health;
        }
        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"\nPlayer отримав {damage} урону");

            OnDamageTaken?.Invoke(Health);
        }
    }
}

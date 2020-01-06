using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_TEST
{
    class RedTeam : Human
    {

        private int health;
        private int damage;
        private bool stillAlive;
        /// <summary>
        /// Has 90 health
        /// </summary>
        /// <returns></returns>
        public RedTeam()
        {
            health = 1;
            damage = 1;
            stillAlive = true;
        }
        public RedTeam NewHuman(int health, int damage, bool isDead)
        {
            return new RedTeam ( health, damage, isDead );
        }
        public RedTeam(int health, int damage, bool stillAlive = true)
        {
            this.health = health;
            this.damage = damage;
            this.stillAlive = stillAlive;
        }
        public override int Health { get { return health; } }
        public override int Punch { get { return damage; } }
        public override bool IsAlive { get { return stillAlive; } }

        public void GetDamage(int damage)
        {
            health -= damage;
        }
        public override string ToString()
        {
            return $"Health: {health}, Damage: {damage}, Alive: {stillAlive}";
        }
    }
}

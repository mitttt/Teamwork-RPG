using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamworkRPG.Player
{
    public class Player
    {
        // Fields
        private string name;
        private int health;
        private int attackPower;
        private int armor;
        private int stamina;
        private int level = 1;

        // Constructor
        public Player(string name)
        {
            this.Name = name;
            this.Health = health;
            this.AttackPower = attackPower;
            this.Armor = armor;
            this.Stamina = stamina;
            this.Level = level;
        }

        // Properties
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Name cannot be null");

                if (value.Length < 2 || value.Length > 12)
                    throw new ArgumentOutOfRangeException("Name should be between 2 and 12 characters");

                this.name = value;
            }
        }

        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Armor { get; set; }
        public int Stamina { get; set; }
        public int Level { get; set; }

        // Methods
        public int GetHealth(int pStamina)
        {
            // Convert every single
            // point of stamina to 
            // 30 points of health
            return pStamina * 30;
        }
    }
}

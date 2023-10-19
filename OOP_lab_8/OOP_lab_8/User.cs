using System;

namespace OOP_lab_8 {
    internal class User {
        private string _id;
        private string _name;

        private int _lvl;
        private int _experience;
        private const int _ExperienceToUpgrade = 1000;

        public delegate void UserDelegate(string name, int newLvl);

        private event UserDelegate _EOnLvlUpgrade;

        public event UserDelegate EOnLevelUpgrade { 
            add => _EOnLvlUpgrade += value;
            remove => _EOnLvlUpgrade -= value;
        }

        public string id { 
            get => _id;
        }

        public string name { 
            get => _name;
        }

        public int lvl {
            get => _lvl;
        }

        public int experience {
            get => _experience;
        }

        public int experienceToUpgrade { 
            get => _ExperienceToUpgrade;
        }

        public User() {
            Console.Write("Enter name: ");
            _name = Console.ReadLine();

            _experience = 0;
            _lvl = 0;
            _id = new DateTime().ToLongDateString();
        }

        public User(int lvl, int experience, string name, string id) {
            _lvl = lvl;
            _experience = experience;
            _name = name;
            _id = id;
        }

        public void AddExperience(int experienceGrowth) {
            int expIncrision = experienceGrowth;

            if(_experience + experienceGrowth >= _ExperienceToUpgrade) {
                expIncrision = experienceGrowth - _experience;
                
                _experience = 0;
                _lvl++;

                _EOnLvlUpgrade?.Invoke(_name, _lvl);
            }

            _experience += expIncrision;
        }
    }
}

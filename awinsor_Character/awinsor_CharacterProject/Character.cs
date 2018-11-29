using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsor_CharacterProject
{
    class Character
    {
        public string name;
        public int height;
        public int age;
        public string skin_color;
        public string hair_color;

        public Character(string name, int height, int age, string skin_color, string hair_color)
        {
            this.name = name;
            this.height = height;
            this.age = age;
            this.skin_color = skin_color;
            this.hair_color = hair_color;
        }
    }
}

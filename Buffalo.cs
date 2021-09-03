using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace Assignment_2_Q2
{
    public class Buffalo : Animal 
    {
        private string _power;
        private string weight;

        public string Power { get => _power; set => _power = value; }
        public string Weight { get => weight; set => weight = value; }

        public Buffalo(string animalname = "", string animalspecies = "", string animalcolor = "", string animaldescription = "", string animalspeed = "", string animalheight = "", string animalfood = "", string animallifecycle = "", string power = "", string weight = "") : base(animalname, animalspecies, animalcolor, animaldescription, animalspeed, animalheight, animalfood, animallifecycle)
        {
            this.Power = power;
            this.Weight = weight;
        }

        public override string ToString()
        {
            return String.Format("\n{0}\n Animal Power = {1}\nAnimal Weight ={2}\n", base.ToString(), this.Power, this.Weight);
        }

        public override void AnimalSound()
        {
            string _filePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\Buffalo.wav";
            SoundPlayer AS = new SoundPlayer(_filePath);
            AS.Play();
        }
    }
}

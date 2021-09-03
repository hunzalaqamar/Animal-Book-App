using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace Assignment_2_Q2
{
    public class Wolf : Animal
    {
        private string _smellingPower;
        private string _agility;

        public Wolf(string animalname = "", string animalspecies = "", string animalcolor = "", string animaldescription = "", string animalspeed = "", string animalheight = "", string animalfood = "", string animallifecycle = "", string smellingpower = "", string agility = "") : base(animalname, animalspecies, animalcolor, animaldescription, animalspeed, animalheight, animalfood, animallifecycle)
        {
            this.SmellingPower = smellingpower;
            this.Agility = agility;
        }

        public override string ToString()
        {
            return String.Format("\n{0}\nAnimal Smelling Power = {1}\nAnimal Agility ={2}\n", base.ToString(), this.SmellingPower, this.Agility);
        }

        public override void AnimalSound()
        {
            string _filePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\Wolf.wav";
            SoundPlayer AS = new SoundPlayer(_filePath);
            AS.Play();
        }

        public string SmellingPower { get => _smellingPower; set => _smellingPower = value; }
        public string Agility { get => _agility; set => _agility = value; }
    }
}

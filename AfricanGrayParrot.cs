using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace Assignment_2_Q2
{
    public class AfricanGrayParrot : Animal
    {
        private string _learningSkills;
        private string _maxFlyingAltitude;

        public string LearningSkills { get => _learningSkills; set => _learningSkills = value; }
        public string MaxFlyingAltitude { get => _maxFlyingAltitude; set => _maxFlyingAltitude = value; }

        public AfricanGrayParrot(string animalname = "", string animalspecies = "", string animalcolor = "", string animaldescription = "", string animalspeed = "", string animalheight = "", string animalfood = "", string animallifecycle = "", string maxflyingalt = "", string learningskills = "") : base(animalname, animalspecies, animalcolor, animaldescription, animalspeed, animalheight, animalfood, animallifecycle)
        {
            this.MaxFlyingAltitude = maxflyingalt;
            this.LearningSkills = learningskills;
        }

        public override string ToString()
        {
            return String.Format("\n{0}\nAnimal Max Flying Altitude = {1}\nAnimal Learning Skills ={2}\n", base.ToString(), this.MaxFlyingAltitude, this.LearningSkills);
        }

        public override void AnimalSound()
        {
            string _filePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\AfricanGrayParrot.wav";
            SoundPlayer AS = new SoundPlayer(_filePath);
            AS.Play();
        }
    }
}

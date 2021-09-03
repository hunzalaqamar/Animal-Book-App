using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace Assignment_2_Q2
{
    public class Falcon : Animal
    {
        private string _maxFlyingAltitude;
        private string _eyeSight;

        public string MaxFlyingAltitude { get => _maxFlyingAltitude; set => _maxFlyingAltitude = value; }
        public string EyeSight { get => _eyeSight; set => _eyeSight = value; }

        public Falcon(string animalname = "", string animalspecies = "", string animalcolor = "", string animaldescription = "", string animalspeed = "", string animalheight = "", string animalfood = "", string animallifecycle = "", string maxflyinhalt = "", string eyesight = "") : base(animalname, animalspecies, animalcolor, animaldescription, animalspeed, animalheight, animalfood, animallifecycle)
        {
            this.MaxFlyingAltitude = maxflyinhalt;
            this.EyeSight = eyesight;
        }

        public override string ToString()
        {
            return String.Format("\n{0}\nAnimal Max Flying Altitude = {1}\nAnimal Eye Sight ={2}\n", base.ToString(), this.MaxFlyingAltitude, this.EyeSight);
        }

        public override void AnimalSound()
        {
            string _filePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\Falcon.wav";
            SoundPlayer AS = new SoundPlayer(_filePath);
            AS.Play();
        }
    }
}

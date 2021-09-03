using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace Assignment_2_Q2
{
    public class Owl : Animal
    {
        private string _neckRotation;
        private string _maxFlyingAltitude;

        public Owl(string animalname = "", string animalspecies = "", string animalcolor = "", string animaldescription = "", string animalspeed = "", string animalheight = "", string animalfood = "", string animallifecycle = "", string maxflyinhalt = "", string neckrot = "") : base(animalname, animalspecies, animalcolor, animaldescription, animalspeed, animalheight, animalfood, animallifecycle)
        {
            this.MaxFlyingAltitude = maxflyinhalt;
            this.NeckRotation = neckrot;
        }

        public override string ToString()
        {
            return String.Format("\n{0}\nAnimal Max Flying Altitude = {1}\nAnimal Neck Rotation ={2}\n", base.ToString(), this.MaxFlyingAltitude, this.NeckRotation);
        }

        public override void AnimalSound()
        {
            string _filePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\Owl.wav";
            SoundPlayer AS = new SoundPlayer(_filePath);
            AS.Play();
        }

        public string NeckRotation { get => _neckRotation; set => _neckRotation = value; }
        public string MaxFlyingAltitude { get => _maxFlyingAltitude; set => _maxFlyingAltitude = value; }
    }
}

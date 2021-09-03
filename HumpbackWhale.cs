using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace Assignment_2_Q2
{
    public class HumpbackWhale : Animal
    {
        private string _weight;

        public HumpbackWhale(string animalname = "", string animalspecies = "", string animalcolor = "", string animaldescription = "", string animalspeed = "", string animalheight = "", string animalfood = "", string animallifecycle = "", string weight = "") : base(animalname, animalspecies, animalcolor, animaldescription, animalspeed, animalheight, animalfood, animallifecycle)
        {
            this.Weight = weight;
        }

        public override string ToString()
        {
            return String.Format("\n{0}\nAnimal Weight = {1}\n", base.ToString(), this.Weight);
        }

        public override void AnimalSound()
        {
            string _filePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\HumpbackWhale.wav";
            SoundPlayer AS = new SoundPlayer(_filePath);
            AS.Play();
        }
        public string Weight { get => _weight; set => _weight = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace Assignment_2_Q2
{
    public class Elephant : Animal
    {
        private string _trunkSize;
        private string _Tusks;

        public Elephant(string animalname = "", string animalspecies = "", string animalcolor = "", string animaldescription = "", string animalspeed = "", string animalheight = "", string animalfood = "", string animallifecycle = "", string trunksize = "", string tusks = "") : base(animalname, animalspecies, animalcolor, animaldescription, animalspeed, animalheight, animalfood, animallifecycle)
        {
            this.TrunkSize = trunksize;
            this.Tusks = tusks;
        }

        public override string ToString()
        {
            return String.Format("\n{0}\nAnimal Trunk Size = {1}\nAnimal Tusks ={2}\n", base.ToString(), this.TrunkSize, this.Tusks);
        }

        public override void AnimalSound()
        {
            string _filePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\Elephant.wav";
            SoundPlayer AS = new SoundPlayer(_filePath);
            AS.Play();
        }

        public string TrunkSize { get => _trunkSize; set => _trunkSize = value; }
        public string Tusks { get => _Tusks; set => _Tusks = value; }
    }
}

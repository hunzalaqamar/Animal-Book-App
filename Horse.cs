using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace Assignment_2_Q2
{
    public class Horse : Animal
    {
        private string _friendly;
        private string _averageHorsePower;

        public Horse(string animalname = "", string animalspecies = "", string animalcolor = "", string animaldescription = "", string animalspeed = "", string animalheight = "", string animalfood = "", string animallifecycle = "", string friendly = "", string avghorsepower = "") : base(animalname, animalspecies, animalcolor, animaldescription, animalspeed, animalheight, animalfood, animallifecycle)
        {
            this.Friendly = friendly;
            this.AverageHorsePower = avghorsepower;
        }

        public override string ToString()
        {
            return String.Format("\n{0}\nFriendly = {1}\nAverage Horse Power ={2}\n", base.ToString(), this.Friendly, this.AverageHorsePower);
        }

        public override void AnimalSound()
        {
            string _filePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\Horse.wav";
            SoundPlayer AS = new SoundPlayer(_filePath);
            AS.Play();
        }

        public string Friendly { get => _friendly; set => _friendly = value; }
        public string AverageHorsePower { get => _averageHorsePower; set => _averageHorsePower = value; }
    }
}

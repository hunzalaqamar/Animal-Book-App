using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace Assignment_2_Q2
{
    public class Lion : Animal
    {
        private string _friendly;
        private string _agility;

        public string Friendly { get => _friendly; set => _friendly = value; }
        public string Agility { get => _agility; set => _agility = value; }

        public Lion(string animalname = "", string animalspecies = "", string animalcolor = "", string animaldescription = "", string animalspeed = "", string animalheight = "", string animalfood = "", string animallifecycle = "", string friendly = "",string agility = "") : base(animalname, animalspecies, animalcolor, animaldescription, animalspeed,animalheight,animalfood,animallifecycle)
        {
            this.Friendly = friendly;
            this.Agility = agility;
        }

        public override string ToString()
        {
            return String.Format("\n{0}\nFriendly = {1}\nAnimal Agility = {2}",base.ToString(),this.Friendly,this.Agility);
        }

        public override void AnimalSound()
        {
            string _filePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\Lion.wav";
            SoundPlayer AS = new SoundPlayer(_filePath);
            AS.Play();
        }
    }
}

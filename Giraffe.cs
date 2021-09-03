using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace Assignment_2_Q2
{
    public class Giraffe : Animal
    {
        private string _neckSize;
        private string _friendly;

        public Giraffe(string animalname = "", string animalspecies = "", string animalcolor = "", string animaldescription = "", string animalspeed = "", string animalheight = "", string animalfood = "", string animallifecycle = "", string necksize = "", string friendly = "") : base(animalname, animalspecies, animalcolor, animaldescription, animalspeed, animalheight, animalfood, animallifecycle)
        {
            this.NeckSize = necksize;
            this.Friendly = friendly;
        }

        public override string ToString()
        {
            return String.Format("\n{0}\nAnimal Neck Size = {1}\nFriendly ={2}\n", base.ToString(), this.NeckSize, this.Friendly);
        }

        public override void AnimalSound()
        {
            string _filePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\Giraffe.wav";
            SoundPlayer AS = new SoundPlayer(_filePath);
            AS.Play();
        }

        public string NeckSize { get => _neckSize; set => _neckSize = value; }
        public string Friendly { get => _friendly; set => _friendly = value; }
    }
}

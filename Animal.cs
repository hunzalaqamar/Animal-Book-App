using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Assignment_2_Q2
{
    public abstract class Animal
    {
        private string _animalName;
        private string _animalSpecies;
        private string _animalColor;
        private string _animalDescription;
        private string _animalSpeed;
        private string _animalHeight;
        private string _animalFood;
        private string _animaLifeCycle;

        public Animal(string animalname = "", string animalspecies = "", string animalcolor = "", string animaldescription = "", string animalspeed = "", string aheight = "", string animalfood = "", string animallifecycle = "" )
        {
            this.AnimalName = animalname;
            this.AnimalSpecies = animalspecies;
            this.AnimalColor = animalcolor;
            this.AnimalDescription = animaldescription;
            this.AnimalSpeed = animalspeed;
            this.AnimalHeight = aheight;
            this.AnimalFood = animalfood;
            this.AnimaLifeCycle = animallifecycle;
        }

        public string AnimalName { get => _animalName; set => _animalName = value; }
        public string AnimalSpecies { get => _animalSpecies; set => _animalSpecies = value; }
        public string AnimalColor { get => _animalColor; set => _animalColor = value; }
        public string AnimalDescription { get => _animalDescription; set => _animalDescription = value; }
        public string AnimalSpeed { get => _animalSpeed; set => _animalSpeed = value; }
        public string AnimalHeight { get => _animalHeight; set => _animalHeight = value; }
        public string AnimalFood { get => _animalFood; set => _animalFood = value; }
        public string AnimaLifeCycle { get => _animaLifeCycle; set => _animaLifeCycle = value; }

        public override string ToString()
        {
            return String.Format("\nAnimal Name = {0}\nAnimal Species = {1}\nAnimal Color = {2}\nAnimal Description = {3}\nAnimal Speed = {4}\nAnimal Height = {5}\nAnimal Food = {6}\nAnimal LifeCycle = {7}", this.AnimalName, this.AnimalSpecies, this.AnimalColor, this.AnimalDescription,this.AnimalSpeed,this.AnimalHeight,this.AnimalFood,this.AnimaLifeCycle);
        }

        public virtual void AnimalSound()
        {
            /*Animal Sound Code here*/
        }
    }
}

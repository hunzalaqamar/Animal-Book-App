using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_Q2
{
    public partial class AnimalsForm : Form
    {
        private Animal[] animals;

        public AnimalsForm()
        {
            InitializeComponent();
            animals = new Animal[10];
        }

        private void pb1_AnimalsForm_Click(object sender, EventArgs e)
        {
            animals[0] = new Lion("Lion", "The lion is a species in the family Felidae and a member of the genus Panthera", "Orange", "Lions have strong, compact bodies and powerful forelegs, teeth and jaws for pulling down and killing prey. Their coats are yellow-gold, and adult males have shaggy manes that range in color from blond to reddish-brown to black. The length and color of a lion's mane is likely determined by age, genetics and hormones.", "80 km/h (Maximum, In Short Bursts)", "Male: 1.2 m (Adult, At Shoulder), Female: 1.1 m (Adult, At Shoulder)", "Carnivore", "Lifespan: 10 – 14 years (Adult, In the wild)", "Maybe, Maybe Not", "High Agility");
            new DisplayForm(animals[0]).Show();
        }

        private void AnimalsForm_Load(object sender, EventArgs e)
        {
        }

        private void btn1_AnimalsForm_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pb2_AnimalsForm_Click(object sender, EventArgs e)
        {
            animals[1] = new Buffalo("Buffalo", "Bovidae Family", "Black", "Buffalo live mostly on the plains, but some are known to inhabit river valleys as well as forests. Buffalo and bison played an important role on the North American plains for many years.True buffalo only live in Asia and Africa. Plains Indians used every part of the buffalo to help them survive. Their hides were used for clothing, blankets and shelters, meat was used for food, and bones were used for tools and toys. Horns were used for cups and spoons while tendons were used for thread and bowstrings. Buffalo chips were used for fuel. Buffalo can be 6 to 7 feet long, stand from 5 to 6 feet tall and weigh up to 2,000 pounds. Their size makes them the largest animal living in North America. Buffalo’s tail can be almost three feet long, and they use it to swap at pesky bugs. Thick brown fur keeps them warm on the frigid and frozen plains during the winter months. Buffalo also has a large hump on its back.", "35 mph", "Buffalo can be 6 to 7 feet long, stand from 5 to 6 feet tall", "Herbivores", "Live upto 25 Years", "Four Times more strength than Ox", "1500 - 2600 Pounds");
            new DisplayForm(animals[1]).Show();
        }

        private void pb3_AnimalsForm_Click(object sender, EventArgs e)
        {
            animals[2] = new Elephant("Elephant", "Asian Elephant", "Dark", "Elephant, (family Elephantidae), largest living land animal, characterized by its long trunk (elongated upper lip and nose), columnar legs, and huge head with temporal glands and wide, flat ears. Elephants are grayish to brown in colour, and their body hair is sparse and coarse. They are found most often in savannas, grasslands, and forests but occupy a wide range of habitats, including deserts, swamps, and highlands in tropical and subtropical regions of Africa and Asia.The Asian elephant (Elephas maximus) weighs about 5,500 kg and has a shoulder height of up to 3.5 metres. The Asian elephant includes three subspecies: the Indian, or mainland (E. maximus indicus), the Sumatran (E. maximus sumatranus), and the Sri Lankan (E. maximus maximus). African elephants have much larger ears, which are used to dissipate body heat.", "40 km/h", "2.8 meters", "Elephants eat roots, grasses, fruit, and bark. An adult elephant can consume up to 300 pounds of food in a single day.", "48-70 Years depending upon different species", "Approx. 6 Feet", "2 Meters");
            new DisplayForm(animals[2]).Show();
        }

        private void pb4_AnimalsForm_Click(object sender, EventArgs e)
        {
            animals[3] = new Falcon("Falcon", "Falco", "Many Colors", "Falcons use their powerful wings and vision to spot prey while flying and swoop down on it. They can fly rapidly and change direction very quickly. A falcon is a type of raptor, birds of prey that include eagles and vultures. The peregrine falcon, is the fastest-moving of all animals. The Latin root of falcon is probably falx, curved blade or sickle, which describes the shape of the bird's talons and beak.", "390 Km/h", "13 to 23 Inches", "Birds, Rabbits, Bats", "12-18 Years", "1 KM high", "Can Spot Medium Size Prey from 1 Mile Away");
            new DisplayForm(animals[3]).Show();
        }

        private void pb5_AnimalsForm_Click(object sender, EventArgs e)
        {
            animals[4] = new Giraffe("Giraffe", "Giraffa", "Orange boxes on Pale white skin", "Characterized by its long legs, long neck, and distinctive spotted pattern, many people first believed the giraffe was a cross between a leopard and a camel, which is reflected in its scientific name, Giraffa camelopardalis. Giraffes live primarily in savanna areas in the sub-Saharan region of Africa. Their extreme height allows them to eat leaves and shoots located much higher than other animals can reach. In particular, they seek out acacia trees. Their long tongues are helpful in eating because they help pull leaves from the trees. Spending most of the day eating, a full-grown giraffe consumes over 45 kg (100 lb.) of leaves and twigs a day. The male giraffe is both taller and heavier than the female. Both sexes have skin-covered knobs, called ossicones, on the top of their heads. Female ossicones are smaller and have a small tuft of fur on top, while male ossicones are bald on the top. These knobs are used to protect the head when males fight, which involves swinging their necks at each other in a show of strength called 'necking'", "upto 35 Mph", "16-18 Feet", "Leaves and Twigs", "upto 25 Years in Wild", "Approx. 6 Feet Long", "An iconic species, giraffes are sensitive, gentle, social, and friendly.");
            new DisplayForm(animals[4]).Show();
        }

        private void pb6_AnimalsForm_Click(object sender, EventArgs e)
        {
            animals[5] = new Horse("Horse", "E. Ferus", "Many Colors According to Species, but Dark brown mostly", "Horses can live to be 30 or 40 years of age They have an acute sense of smell and hearing and can look forward with one eye and backwards with another. That is one reason why they are skittish and sometimes outfit with blinders. Horses can trot, canter and gallop and reach speed of 43mph. Their hoof are actually large middle toes. The muscular hindquarters is the source of a horse's power. The alignment of the legs critical for speed but is complicated. Horses are vegetarians, generally eating grass in the summer and hay in the winter, but are not cud-chewing ruminants like cattle, sheep or goats. They need more grass than these animals and digest fibrous materials in a greatly enlarged section of their gut called a caecum, located between the large and small intestines. With no cud and a fermentation body at the end of the large intestine instead of the beginning, horses are only two thirds as efficient digesting grass as cattle or sheep and need a third more land to maintain their body weight. Horses have large teeth that are best suited for grinding grass and can be used to tell a horses age.The first teeth are called 'nippers', which are fully grown after nine months.Permanent teeth begin growing the third year.A full set of teeth is obtained at the end of the sixth year.The enamel edges wear down over time are usually completely gone by the 11th year.", "88 Km/h", "1.4 - 1.8 meter", "horses eat grass and hay or haylage, but salt, concentrates and fruits or vegetables.", "upto 25-30 Years", "Horses are highly social herd animals, often because they learn to trust a human handler.", " Interestingly, a horse exerting 1 horsepower can lift 330 pounds of coal 100 feet per minute, 33 pounds of coal 1000 feet in one minute, or 1000 pounds 33 feet in one minute.");
            new DisplayForm(animals[5]).Show();
        }

        private void pb7_AnimalsForm_Click(object sender, EventArgs e)
        {
            animals[6] = new HumpbackWhale("HumpBack Whale", "M. novaeangliae", "Black or grey with White undersides", "Humpbacks are mainly black or grey with white undersides to their flukes, flippers and bellies. They are 15m long. One of the most noticeable characteristics of humpback whales is their long flippers. Humpback whales are extremely active, often slapping their flippers and flukes on the surface of the sea. They also breach more than any other baleen whales. Humpbacks often feed in large groups and are famous for their 'song'. Male humpbacks produce a long series of calls that are normally heard during the winter breeding season, although songs have been recorded in the summer. The whales may repeat the same song for several hours.humpback whales are found in the north Pacific, from South-East Alaska, Prince William Sound, and British Columbia and migrate seasonally to Hawaii, the Gulf of California, Mexico and Costa Rica.", "5-15 Kmph", "Female: 15 – 16 m (Adult), Male: 13 – 14 m (Adult)", "Humpback whales filter-feed on small crustaceans (mostly krill) and small fish, consuming up to 2,000 pounds of food per day.", "upto 45-50 Years", "30,000 KG (Adult)");
            new DisplayForm(animals[6]).Show();
        }

        private void pb8_AnimalsForm_Click(object sender, EventArgs e)
        {
            animals[7] = new AfricanGrayParrot("African Gray Parrot", "P. erithacus", "Gray and white", "As its name indicates, the African grey is a mottled grey colored, medium-sized parrot. It has a large black bill and white mask enclosing a yellow eye, and has a striking red vent and tail . Females have a pale gray crown with dark gray edges, a gray body, and scarlet tail feathers. The male looks similar to the female, but becomes darker with age.", "45-60 mph", "12-16 Inches", "Seeds, Nuts, Fruits", "Approx. 23 Years", "African grey parrots are capable flyers, but they don't always do it as much as other birds", "mimic human speech, identify shapes and colors, learn number sequences, ask unprompted questions, hold entire conversations with their owners");
            new DisplayForm(animals[7]).Show();
        }

        private void pb9_AnimalsForm_Click(object sender, EventArgs e)
        {
            animals[8] = new Owl("Owl", "Strigiformes", "Many different colors, mostly brown and white", "Owls are birds from the order Strigiformes, which includes over 200 species of mostly solitary and nocturnal birds of prey typified by an upright stance, a large, broad head, binocular vision, binaural hearing, sharp talons, and feathers adapted for silent flight. Exceptions include the diurnal northern hawk-owl and the gregarious burrowing owl. Owls hunt mostly small mammals, insects, and other birds, although a few species specialize in hunting fish. They are found in all regions of the Earth except the polar ice caps and some remote islands. Owls are divided into two families: the true (or typical) owl family, Strigidae, and the barn-owl family, Tytonidae. A group of owls is called a 'parliament.'", "30-40 MPH", "43-64 cm", "Many owl species are carnivores, or meat eaters. Small, rodent-like mammals, such as voles and mice, are the primary prey for many owl species. An owl's diet may also include frogs, lizards, snakes, fish, mice, rabbits, birds, squirrels, and other creatures.", "Approx. 25 Years", "Owls have large wings relative to their body mass, and that allows them to fly slowly. They are able to glide a lot in flight, rather than flap their wings", "owls can rotate their necks a maximum of 270 degrees without breaking blood vessels or tearing tendons. A Great Horned Owl syncs its ears and eyes to unleash it's silent assault on prey");
            new DisplayForm(animals[8]).Show();
        }

        private void pb10_AnimalsForm_Click(object sender, EventArgs e)
        {
            animals[9] = new Wolf("Wolf", "C. lupus", "Many Colors but, mostly Black and Golden", "The wolf has a long muzzle, short ears, long legs, and a long bushy tail. Wolves usually measure 26–38 inches at the shoulder. Wolves have fur made up of two layers. The top layer is resistant to dirt, and the under-layer is water resistant. The color of their fur can be any combination of grey, white, taupe, brown, and black. Wolves live in groups called 'packs'. They are pack hunters. The members of the pack are usually family members, often just the parents and offspring. Wolves that are not family may join if they do not have a pack of their own. Packs are usually up to 12 wolves, but they can be as small as two or as large as 25. The leaders are called the parent (breeding) male and the parent (breeding) female. Their territory is marked by scent and howling; they will fight any intruders. Young wolves are called 'pups' or 'whelps'. Adult females usually give birth to five or six pups in a litter. Wolves make a noise called a howl. They howl to communicate with each other from long distances and to mark the edges of their territory. Wolves have a complicated body language.", "50-60 KM/h", "66-81 cm (Adult, At Shoulder)", "Wolves are carnivores—they prefer to eat large hoofed mammals such as deer, elk, bison, and moose. They also hunt smaller mammals such as beavers, rodents, and hares. Adults can eat 20 pounds of meat in a single meal.", "Approx. 14 Years in Wild", "Wolves have a very good sense of smell—about 100 times greater than humans.", "Top Agility");
            new DisplayForm(animals[9]).Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment_2_Q2
{
    public partial class DisplayForm : Form
    {
        private Animal animal;
        public DisplayForm(Animal animal_param)
        {
            InitializeComponent();
            animal = animal_param;
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            if(animal is Lion)
            {
                string _filePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\liondisp.jpg";
                pb1_DisplayForm.Image = Image.FromFile(_filePath);
                rtb1_DisplayForm.AppendText("\n\n**************************************************************");
                rtb1_DisplayForm.AppendText("\n\t\t\t\t\t\tLion\n");
                rtb1_DisplayForm.AppendText("**************************************************************\n\n");
                rtb1_DisplayForm.AppendText(animal.ToString());
            }
            else if(animal is AfricanGrayParrot)
            {
                string _filePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\africangrayparrotdisp.jpg";
                pb1_DisplayForm.Image = Image.FromFile(_filePath);
                rtb1_DisplayForm.AppendText("\n\n**************************************************************");
                rtb1_DisplayForm.AppendText("\n\t\t\tAfrican Gray Parrot\n");
                rtb1_DisplayForm.AppendText("**************************************************************\n\n");
                rtb1_DisplayForm.AppendText(animal.ToString());
            }
            else if(animal is Buffalo)
            {
                string _filePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\buffalodisp1.jpg";
                pb1_DisplayForm.Image = Image.FromFile(_filePath);
                rtb1_DisplayForm.AppendText("\n\n**************************************************************");
                rtb1_DisplayForm.AppendText("\n\t\t\t\t\t\tBuffalo\n");
                rtb1_DisplayForm.AppendText("**************************************************************\n\n");
                rtb1_DisplayForm.AppendText(animal.ToString());
            }
            else if(animal is Elephant)
            {
                string _filePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\elephantdisp.jpg";
                pb1_DisplayForm.Image = Image.FromFile(_filePath);
                rtb1_DisplayForm.AppendText("\n\n**************************************************************");
                rtb1_DisplayForm.AppendText("\n\t\t\t\t\t\tElephant\n");
                rtb1_DisplayForm.AppendText("**************************************************************\n\n");
                rtb1_DisplayForm.AppendText(animal.ToString());
            }
            else if(animal is Falcon)
            {
                string _filePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\falcondisp.jpg";
                pb1_DisplayForm.Image = Image.FromFile(_filePath);
                rtb1_DisplayForm.AppendText("\n\n**************************************************************");
                rtb1_DisplayForm.AppendText("\n\t\t\t\t\t\tFalcon\n");
                rtb1_DisplayForm.AppendText("**************************************************************\n\n");
                rtb1_DisplayForm.AppendText(animal.ToString());
            }
            else if(animal is Giraffe)
            {
                string _filePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\giraffedisp.jpg";
                pb1_DisplayForm.Image = Image.FromFile(_filePath);
                rtb1_DisplayForm.AppendText("\n\n**************************************************************");
                rtb1_DisplayForm.AppendText("\n\t\t\t\t\t\tGiraffe\n");
                rtb1_DisplayForm.AppendText("**************************************************************\n\n");
                rtb1_DisplayForm.AppendText(animal.ToString());
            }
            else if(animal is Horse)
            {
                string _filePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\horsedisp.jpg";
                pb1_DisplayForm.Image = Image.FromFile(_filePath);
                rtb1_DisplayForm.AppendText("\n\n**************************************************************");
                rtb1_DisplayForm.AppendText("\n\t\t\t\t\t\tHorse\n");
                rtb1_DisplayForm.AppendText("**************************************************************\n\n");
                rtb1_DisplayForm.AppendText(animal.ToString());
            }
            else if(animal is HumpbackWhale)
            {
                string _filePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\Humpbackwhaledisp.jpg";
                pb1_DisplayForm.Image = Image.FromFile(_filePath);
                rtb1_DisplayForm.AppendText("\n\n**************************************************************");
                rtb1_DisplayForm.AppendText("\n\t\t\t\tHumpback Whale\n");
                rtb1_DisplayForm.AppendText("**************************************************************\n\n");
                rtb1_DisplayForm.AppendText(animal.ToString());
            }
            else if(animal is Owl)
            {
                string _filePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\owldisp.jpg";
                pb1_DisplayForm.Image = Image.FromFile(_filePath);
                rtb1_DisplayForm.AppendText("\n\n**************************************************************");
                rtb1_DisplayForm.AppendText("\n\t\t\t\t\t\tOwl\n");
                rtb1_DisplayForm.AppendText("**************************************************************\n\n");
                rtb1_DisplayForm.AppendText(animal.ToString());
            }
            else if(animal is Wolf)
            {
                string _filePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\wolfdisp.jpg";
                pb1_DisplayForm.Image = Image.FromFile(_filePath);
                rtb1_DisplayForm.AppendText("\n\n**************************************************************");
                rtb1_DisplayForm.AppendText("\n\t\t\t\t\t\tWolf\n");
                rtb1_DisplayForm.AppendText("**************************************************************\n\n");
                rtb1_DisplayForm.AppendText(animal.ToString());
            }

        }

        private void btn1_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn1_DisplayForm_Click(object sender, EventArgs e)
        {
            animal.AnimalSound();
        }
    }
}

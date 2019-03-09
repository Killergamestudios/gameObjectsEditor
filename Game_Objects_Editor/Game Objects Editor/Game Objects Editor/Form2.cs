using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Game_Objects_Editor
{
    public partial class newChar : Form
    {
        message0 notification0;

        string charName = "INCOMPLETE";
        int exp = 0;
        int maxHealth =0;
        int agilityNum =0;
        int precisionNum =0;
        int maxEnergy= 0;
        int masteryNum = 0;
        int actionsNum = 0;
        
        

        void create()
        {

            string fileDirectory = "./Data/Characters";
            List<string> localTemp = new List<string>();
            DirectoryInfo d = new DirectoryInfo(fileDirectory);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
            int newID = 0;
            foreach (FileInfo character in Files)
            {
                newID++;
            }
            string filePrefix = newID.ToString("D4");
            string filePath = "./Data/Characters/" +filePrefix +charName +".txt";
            if (File.Exists(filePath))
            {
                if (notification0 == null)
                {
                    notification0 = new message0();
                }
                if (notification0.ShowDialog() == DialogResult.OK)
                {

                   
                File.Create(filePath).Close();
                }             
            

            }
            else
            {
                File.Create(filePath).Close();
            }


            StreamWriter file = new StreamWriter(filePath);
            file.WriteLine(newID);
            file.WriteLine(charName);
            file.WriteLine(exp);
            file.WriteLine(maxHealth);
            file.WriteLine(agilityNum);
            file.WriteLine(precisionNum);
            file.WriteLine(maxEnergy);
            file.WriteLine(masteryNum);
            file.WriteLine(actionsNum);
            file.Close();
           
        }

        public newChar()
        {
            InitializeComponent();
            this.AcceptButton = createCharButton;
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            charName = nameBox.Text;
        }

        private void healthBox_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(healthBox.Text,out maxHealth);
        }

        private void agilityBox_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(agilityBox.Text,out agilityNum);
        }

        private void precisionBox_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(precisionBox.Text,out precisionNum);
        }

        private void energyBox_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(energyBox.Text, out maxEnergy);
        }

        private void masteryBox_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(masteryBox.Text, out masteryNum);
        }

        private void actionsBox_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(actionsBox.Text, out actionsNum);
        }

        private void experienceBox_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(experienceBox.Text, out exp);
        }
        
        private void createCharButton_Click(object sender, EventArgs e)
        {
            create();
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }


    }
}

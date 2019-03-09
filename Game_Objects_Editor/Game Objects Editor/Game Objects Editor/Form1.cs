using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;



namespace Game_Objects_Editor
{
    public partial class Form1 : Form
    {
        int curSelected =0;

        List<string> characters;
        List<string> weapons;
        List<string> armors;
        List<string> abilities;
        List<string> misc;
        List<string> warnings;

        string curCharacter;
        string curWeapon;
        string curArmor;
        string curAbility;
        string curMisc;

        newChar form2;
        message0 notification0;

        public Form1()
        {
            InitializeComponent();

            //Loads the existing files
            characters = loadData("Characters/");
            
            weapons = loadData("Weapons");
            armors = loadData("Armours");
            abilities = loadData("Abilities");
            misc = loadData("Misc");
            warnings = new List<string>();
            
            

            //Initialises the lists Data.
            charactersList.DataSource = characters;
            weaponsList.DataSource = weapons;
            weaponsList0.DataSource = weapons;
            armorsList.DataSource = armors;
            armourList0.DataSource = armors;
            abilitiesList.DataSource = abilities;
            miscList0.DataSource = misc;
        }
        private List<string> loadData(string type)
        {
            string fileDirectory = "./Data/" + type;
            List<string> localTemp = new List<string>();
            DirectoryInfo d = new DirectoryInfo(fileDirectory);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
            foreach(FileInfo file in Files )
            {
                localTemp.Add(file.Name);
            }
            return localTemp;
        }

        private void charactersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            curSelected = charactersList.SelectedIndex;
            curCharacter = charactersList.SelectedItem.ToString();
            string filepath = "./Data/Characters/" + curCharacter;
            string[] lines = File.ReadAllLines(filepath);
            int reader =0;

            // Display the file contents by using a foreach loop.
            foreach (string line in lines)
            {
                switch (reader)
                {
                    case 0:
                        characterID.Text = line;
                        break;
                    case 1:
                        nameBox.Text = line;
                        break;
                    case 2:
                        experienceBox.Text = line;
                        break;
                    case 3:
                        healthBox.Text = line;
                        break;
                    case 4:
                        agilityBox.Text = line;
                        break;
                    case 5:
                        precisionBox.Text = line;
                        break;
                    case 6:
                        energyBox.Text = line;
                        break;
                    case 7:
                        masteryBox.Text = line;
                        break;
                    case 8:
                        actionsBox.Text = line;
                        break;
                    case 9:
                        weaponsList.Text = line;
                        break;
                    case 10:
                        wDropChanceBox.Text = line;
                        break;
                    case 11:
                        armorsList.Text = line;
                        break;
                    case 12:
                        aDropChanceBox.Text = line;
                        break;
                    default:
                       
                        break;
                }
                reader++;
            }
        }

        private void newChar_Click(object sender, EventArgs e)
        {
            
            if (form2 == null ||form2.IsDisposed)
            {
                form2 = new newChar();
            }
            //form2.Show();
            //form2.Focus();
            int newID = characters.Count();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                refreshButton.PerformClick();
            }

            


        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            characters = loadData("Characters");

            charactersList.DataSource = characters;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            string filePrefix = int.Parse(characterID.Text).ToString("D4");
            string filePath = "./Data/Characters/" +filePrefix +nameBox.Text + ".txt";
            string exAddress = "./Data/Characters/" + curCharacter;
            if (File.Exists(filePath) && filePath !=exAddress)
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
                
                if(File.Exists(exAddress))  File.Delete(exAddress);
                File.Create(filePath).Close();
            }

            StreamWriter file = new StreamWriter(filePath);
            file.WriteLine(characterID.Text);
            file.WriteLine(nameBox.Text);
            file.WriteLine(experienceBox.Text); //Checked in Verify for int
            file.WriteLine(healthBox.Text); // 
            file.WriteLine(agilityBox.Text); // 
            file.WriteLine(precisionBox.Text); // 
            file.WriteLine(energyBox.Text); //
            file.WriteLine(masteryBox.Text); //
            file.WriteLine(actionsBox.Text); // 
            file.WriteLine(weaponsList.Text);
            file.WriteLine(wDropChanceBox.Text); //
            file.WriteLine(armorsList.Text);
            file.WriteLine(aDropChanceBox.Text); //
            file.Close();
            curCharacter = filePrefix + nameBox.Text + ".txt";


            verifyCharacter();
            refreshButton.PerformClick();
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            refreshButton.PerformClick();
        }

        // WEAPONS TAB
        private void newWeapon_Click(object sender, EventArgs e)
        {
            int newID = weapons.Count;
            string filePrefix = newID.ToString("D4");
            string filePath = "./Data/Weapons/"+filePrefix+"new_weapon.txt";
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
            weapons = loadData("Weapons");

            weaponsList.DataSource = weapons;
            weaponsList0.DataSource = weapons;

            StreamWriter newWeaponFile = new StreamWriter(filePath);
            newWeaponFile.WriteLine(newID);
            for (int i = 1; i < 11; i++)
            {
                newWeaponFile.WriteLine("");
            }
            weaponID.Text = filePrefix;
            newWeaponFile.Close();
            weaponBoxesRefresh();
        }

        private void applyWeapons_Click(object sender, EventArgs e)
        {
            string prefix = int.Parse(weaponID.Text).ToString("D4");
            string filePath = "./Data/Weapons/" +prefix + weaponNameBox.Text + ".txt";
            string exAddress = "./Data/Weapons/" + curWeapon;
            if (File.Exists(filePath) && filePath != exAddress)
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

                if (File.Exists(exAddress)) File.Delete(exAddress);
                File.Create(filePath).Close();
            }
            // WRITES THE WEAPON TO A TEXT FILE
            StreamWriter file = new StreamWriter(filePath);
            file.WriteLine(weaponID.Text);
            file.WriteLine(weaponNameBox.Text);
            file.WriteLine(weaponType.Text);
            file.WriteLine(baseDamageBox.Text);
            file.WriteLine(rangeBox.Text);
            file.WriteLine(magicdmgTypeBox.Text);
            file.WriteLine(eeAmplitudeBox.Text);
            file.WriteLine(eeDurationBox.Text);
            file.WriteLine(wMasteryReqBox.Text);
            file.WriteLine(wClassReqBox.Text);
            file.WriteLine(weaponDescriptionBox.Text);
            file.Close();

            curWeapon = prefix + weaponNameBox.Text + ".txt";

            weapons = loadData("Weapons");

            verifyWeapon();
            weaponsList.DataSource = weapons;
            weaponsList0.DataSource = weapons;

            
            
        }

        private void weaponsList0_SelectedIndexChanged(object sender, EventArgs e)
        {
            weaponBoxesRefresh();
        }

        private void armourList0_SelectedIndexChanged(object sender, EventArgs e)
        {
            armorBoxesRefresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string prefix = int.Parse(armorID.Text).ToString("D4");
            string filePath = "./Data/Armours/" +prefix+ armorNameBox.Text + ".txt";
            string exAddress = "./Data/Armours/" + curArmor;
            if (File.Exists(filePath) && filePath != exAddress)
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

                if (File.Exists(exAddress)) File.Delete(exAddress);
                File.Create(filePath).Close();
            }

            StreamWriter file = new StreamWriter(filePath);
            file.WriteLine(armorID.Text);
            file.WriteLine(armorNameBox.Text);
            file.WriteLine(armorTypeBox.Text);
            file.WriteLine(minMastery.Text);
            file.WriteLine(armorBaseBox.Text);
            file.WriteLine(upgradeSlotsBox.Text);
            file.WriteLine(fireRes.Text);
            file.WriteLine(iceRes.Text);
            file.WriteLine(poisonRes.Text);
            file.WriteLine(darkRes.Text);
            file.WriteLine(natureRes.Text);
            file.WriteLine(windRes.Text);
            file.WriteLine(lightRes.Text);
            file.WriteLine(harmonyRes.Text);
            file.WriteLine(armorEXPGainBox.Text);
            file.WriteLine(armorHPBox.Text);
            file.WriteLine(armorAgilityBox.Text);
            file.WriteLine(armorPrecisionBox.Text);
            file.WriteLine(armorMPBox.Text);
            file.WriteLine(armorMasteryBox.Text);
            file.WriteLine(armorActionsBox.Text);
            if (legsCovered.Checked) file.WriteLine("1"); else file.WriteLine("0");
            if (rightArmCovered.Checked) file.WriteLine("1"); else file.WriteLine("0");
            if (leftArmCovered.Checked) file.WriteLine("1"); else file.WriteLine("0");
            if (headCovered.Checked) file.WriteLine("1"); else file.WriteLine("0");
            if (isDroppable.Checked) file.WriteLine("1"); else file.WriteLine("0");
            file.WriteLine(armorDescriptionBox.Text);
            file.Close();

            curArmor = prefix + armorNameBox.Text + ".txt";

            verifyArmor();
            armors = loadData("Armours");
            armorsList.DataSource = armors;
            armourList0.DataSource = armors;
            



            
        }

        private void newArmor_Click(object sender, EventArgs e)
        {
            int newID = armors.Count;
            string filePrefix = newID.ToString("D4");
            string filePath = "./Data/Armours/"+filePrefix+"new_armour.txt";
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
            armors = loadData("Armours");

            armorsList.DataSource = armors;
            armourList0.DataSource = armors;
            StreamWriter newArmorFile = new StreamWriter(filePath);
            newArmorFile.WriteLine(newID);
            for (int i = 1; i < 27; i++)
            {
                newArmorFile.WriteLine("");
            }
            armorID.Text = filePrefix;
            newArmorFile.Close();
            armorBoxesRefresh();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportFile();
        }

        private void localFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("./Data\\");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            armorBoxesRefresh();
        }


        void armorBoxesRefresh()
        {
            // Get the currently selected item in the ListBox.
            curSelected = armourList0.SelectedIndex;
            curArmor = armourList0.SelectedItem.ToString();
            Console.WriteLine(curArmor); //DEBUG
            string filepath = "./Data/Armours/" + curArmor;
            string[] lines = File.ReadAllLines(filepath);
            int reader = 0;

            // Display the file contents by using a foreach loop.
            foreach (string line in lines)
            {
                switch (reader)
                {
                    case 0:
                        armorID.Text = line;
                        break;
                    case 1:
                        armorNameBox.Text = line;
                        break;
                    case 2:
                        armorTypeBox.Text = line;
                        break;
                    case 3:
                        minMastery.Text = line;
                        break;
                    case 4:
                        armorBaseBox.Text = line;
                        break;
                    case 5:
                        upgradeSlotsBox.Text = line;
                        break;
                    case 6:
                        fireRes.Text = line;
                        break;
                    case 7:
                        iceRes.Text = line;
                        break;
                    case 8:
                        poisonRes.Text = line;
                        break;
                    case 9:
                        darkRes.Text = line;
                        break;
                    case 10:
                        natureRes.Text = line;
                        break;
                    case 11:
                        windRes.Text = line;
                        break;
                    case 12:
                        lightRes.Text = line;
                        break;
                    case 13:
                        harmonyRes.Text = line;
                        break;
                    case 14:
                        armorEXPGainBox.Text = line;
                        break;
                    case 15:
                        armorHPBox.Text = line;
                        break;
                    case 16:
                        armorAgilityBox.Text = line;
                        break;
                    case 17:
                        armorPrecisionBox.Text = line;
                        break;
                    case 18:
                        armorMPBox.Text = line;
                        break;
                    case 19:
                        armorMasteryBox.Text = line;
                        break;
                    case 20:
                        armorActionsBox.Text = line;
                        break;
                    case 21:
                        if (line == "1")
                        {
                            legsCovered.Checked = true;
                        }
                        else
                        {
                            legsCovered.Checked = false;
                        }
                        break;
                    case 22:
                        if (line == "1")
                        {
                            rightArmCovered.Checked = true;
                        }
                        else
                        {
                            rightArmCovered.Checked = false;
                        }
                        break;
                    case 23:
                        if (line == "1")
                        {
                            leftArmCovered.Checked = true;
                        }
                        else
                        {
                            leftArmCovered.Checked = false;
                        }
                        break;
                    case 24:
                        if (line == "1")
                        {
                            headCovered.Checked = true;
                        }
                        else
                        {
                            headCovered.Checked = false;
                        }
                        break;
                    case 25:
                        if (line == "1")
                        {
                            isDroppable.Checked = true;
                        }
                        else
                        {
                            isDroppable.Checked = false;
                        }
                        break;
                    case 26:
                        armorDescriptionBox.Text = line;
                        break;
                    default:

                        break;
                }
                reader++;
            }
        }

        void weaponBoxesRefresh()
        {
            // Get the currently selected item in the ListBox.
            curSelected = weaponsList0.SelectedIndex;
            curWeapon = weaponsList0.SelectedItem.ToString();
            string filepath = "./Data/Weapons/" + curWeapon;
            string[] lines = File.ReadAllLines(filepath);
            int reader = 0;

            // Display the file contents by using a foreach loop.
            foreach (string line in lines)
            {
                switch (reader)
                {
                    case 0:
                        weaponID.Text = line;
                        break;
                    case 1:
                        weaponNameBox.Text = line;
                        break;
                    case 2:
                        weaponType.Text = line;
                        break;
                    case 3:
                        baseDamageBox.Text = line;
                        break;
                    case 4:
                        rangeBox.Text = line;
                        break;
                    case 5:
                        magicdmgTypeBox.Text = line;
                        break;
                    case 6:
                        eeAmplitudeBox.Text = line;
                        break;
                    case 7:
                        eeDurationBox.Text = line;
                        break;
                    case 8:
                        wMasteryReqBox.Text = line;
                        break;
                    case 9:
                        wClassReqBox.Text = line;
                        break;
                    case 10:
                        weaponDescriptionBox.Text = line;
                        break;
                    default:

                        break;
                }
                reader++;
            }
        }

        void abilityBoxesRefresh()
        {
            // Get the currently selected item in the ListBox.
            curSelected = abilitiesList.SelectedIndex;
            curAbility = abilitiesList.SelectedItem.ToString();
            string filepath = "./Data/Abilities/" + curAbility;
            string[] lines = File.ReadAllLines(filepath);
            int reader = 0;

            // Display the file contents by using a foreach loop.
            foreach (string line in lines)
            {
                switch (reader)
                {
                    case 0:
                        abilityID.Text = line;
                        break;
                    case 1:
                        abilityNameBox.Text = line;
                        break;
                    default:

                        break;
                }
                reader++;
            }
        }

        bool isNumeric(string s)
        {
            int n;
            return int.TryParse(s,out n);
        }

        void verifyCharacter()
        {
            string base0 = "Character " + curCharacter.Substring(0, 4) +" ";
            List<int> toRemove = new List<int>();
            int counter = 0;
            foreach (string warns in warnings)
            {
                if (warns.StartsWith(base0)) toRemove.Add(counter);
                counter++;

            }
            for (int z = toRemove.Count - 1; z >= 0; z--)
            {
                warnings.RemoveAt(toRemove[z]);

            }
            if (isNumeric(experienceBox.Text) == false)
                warnings.Add(base0 + "Warning: Experience must be Numeric");
            if (isNumeric(healthBox.Text) == false)
                warnings.Add(base0 + "Warning: Max Health must be Numeric");
            if (isNumeric(agilityBox.Text) == false)
                warnings.Add(base0 + "Warning: Agility must be Numeric");
            if (isNumeric(precisionBox.Text) == false)
                warnings.Add(base0 + "Warning: Precision must be Numeric");
            if (isNumeric(energyBox.Text) == false)
                warnings.Add(base0 + "Warning: Max Energy must be Numeric");
            if (isNumeric(masteryBox.Text) == false)
                warnings.Add(base0 + "Warning: Mastery must be Numeric");
            if (isNumeric(actionsBox.Text) == false)
                warnings.Add(base0 + "Warning: Actions must be Numeric");
            if (isNumeric(wDropChanceBox.Text) == false)
                warnings.Add(base0 + "Warning: Weapon Drop Chance must be Numeric");
            if (isNumeric(aDropChanceBox.Text) == false)
                warnings.Add(base0 + "Warning: Armor Drop Chance must be Numeric");


            warningsList.DataSource = null;
            warningsList.DataSource = warnings;
            warningsList.SelectionMode = SelectionMode.None;
            warningsList.SelectionMode = SelectionMode.One;
        }

        void verifyWeapon()
        {
            string base0 = "Weapon " + curWeapon.Substring(0, 4) + " ";
            List<int> toRemove= new List<int>();
            int counter=0;
            foreach (string warns in warnings)
            {
                if (warns.StartsWith(base0))toRemove.Add(counter);
                counter++;
              
            }
            for (int z = toRemove.Count -1; z >= 0; z--)
            {
                warnings.RemoveAt(toRemove[z]);
                
            }
            if (isNumeric(baseDamageBox.Text) == false)
                warnings.Add(base0 + "Warning: Physical Damage must be Numeric");
            if (isNumeric(rangeBox.Text) == false)
                warnings.Add(base0 + "Warning: Range must be Numeric");
            if (isNumeric(eeAmplitudeBox.Text) == false)
                warnings.Add(base0 + "Warning: Element Amplitude must be Numeric");
            if (isNumeric(eeDurationBox.Text) == false)
                warnings.Add(base0 + "Warning: Element Duration must be Numeric");
            if (isNumeric(wMasteryReqBox.Text) == false)
                warnings.Add(base0 + "Warning: Weapon Mastery Requirement must be Numeric");


            
            warningsList.DataSource = null;
            warningsList.DataSource = warnings;
            warningsList.SelectionMode = SelectionMode.None;
            warningsList.SelectionMode = SelectionMode.One;
            
        }

        void verifyArmor()
        {
            string base0 = "Armour " + curArmor.Substring(0, 4) + " ";
            List<int> toRemove = new List<int>();
            int counter = 0;
            foreach (string warns in warnings)
            {
                if (warns.StartsWith(base0)) toRemove.Add(counter);
                counter++;

            }
            for (int z = toRemove.Count - 1; z >= 0; z--)
            {
                warnings.RemoveAt(toRemove[z]);

            }
            if (isNumeric(armorBaseBox.Text) == false)
                warnings.Add(base0 + "Warning: Physical Resistance must be Numeric");
            if (isNumeric(minMastery.Text) == false)
                warnings.Add(base0 + "Warning: Minimum Mastery must be Numeric");
            if (isNumeric(upgradeSlotsBox.Text) == false)
                warnings.Add(base0 + "Warning: Upgrade Slots must be Numeric");
            if (isNumeric(fireRes.Text) == false || isNumeric(iceRes.Text) == false || isNumeric(poisonRes.Text) == false
                || isNumeric(natureRes.Text) == false || isNumeric(darkRes.Text) == false || isNumeric(lightRes.Text) == false
                || isNumeric(windRes.Text) == false || isNumeric(harmonyRes.Text) == false)
                warnings.Add(base0 + "Warning: Elemental Resistances must be Numeric");
            if (isNumeric(armorEXPGainBox.Text) == false)
                warnings.Add(base0 + "Warning: Armor EXP Gain must be Numeric");
            if (isNumeric(armorHPBox.Text) == false)
                warnings.Add(base0 + "Warning: Armor Max Health Bonus must be Numeric");
            if (isNumeric(armorMPBox.Text) == false)
                warnings.Add(base0 + "Warning: Armor Max Energy Bonus must be Numeric");
            if (isNumeric(armorAgilityBox.Text) == false)
                warnings.Add(base0 + "Warning: Armor Agility Bonus must be Numeric");
            if (isNumeric(armorPrecisionBox.Text) == false)
                warnings.Add(base0 + "Warning: Armor Precision Bonus must be Numeric");
            if (isNumeric(armorMasteryBox.Text) == false)
                warnings.Add(base0 + "Warning: Armor Mastery Bonus must be Numeric");
            if (isNumeric(armorActionsBox.Text) == false)
                warnings.Add(base0 + "Warning: Armor Actions Bomus must be Numeric");

            warningsList.DataSource = null;
            warningsList.DataSource = warnings;
            warningsList.SelectionMode = SelectionMode.None;
            warningsList.SelectionMode = SelectionMode.One;
        }

        private void newAbility_Click(object sender, EventArgs e)
        {
            int newID = abilities.Count;
            string filePrefix = newID.ToString("D4");
            string filePath = "./Data/Abilities/"+filePrefix+"new_ability.txt";
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
            abilities = loadData("Abilities");
            ability1Box.DataSource = abilities;
            ability2Box.DataSource = abilities;
            ability3Box.DataSource =abilities;

            abilitiesList.DataSource = abilities;
            StreamWriter newAbilityFile = new StreamWriter(filePath);
            newAbilityFile.WriteLine(newID);
            newAbilityFile.WriteLine("");
            newAbilityFile.Close();
            abilityID.Text = filePrefix;
            abilityBoxesRefresh();
        }

        private void applyAbilities_Click(object sender, EventArgs e)
        {
            string prefix = int.Parse(abilityID.Text).ToString("D4");
            string filePath = "./Data/Abilities/" + prefix + abilityNameBox.Text + ".txt";
            string exAddress = "./Data/Abilities/" + curAbility;
            if (File.Exists(filePath) && filePath != exAddress)
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

                if (File.Exists(exAddress)) File.Delete(exAddress);
                File.Create(filePath).Close();
            }

            StreamWriter newAbilityFile = new StreamWriter(filePath);
            newAbilityFile.WriteLine(prefix);
            newAbilityFile.WriteLine(abilityNameBox.Text);
            newAbilityFile.Close();

            abilities = loadData("Abilities");
            abilitiesList.DataSource = abilities;
            ability1Box.DataSource = abilities;
            ability2Box.DataSource = abilities;
            ability3Box.DataSource = abilities;
        }

        private void abilitiesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            abilityBoxesRefresh();
        }

        private void verifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verifyAll();
        }

        protected override bool  ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData ==(Keys.Control| Keys.N))
            {
                verifyAll();
                return true;
            }
            if (keyData == (Keys.Control | Keys.E))
            {
                exportFile();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        void verifyAll()
        {
            TabPage currentTab = MiscTab.SelectedTab;
            MiscTab.SelectedTab = Characters;
            charactersList.SelectedIndex = 0;
            foreach (string file in characters)
            {

                verifyCharacter();
                if (charactersList.SelectedIndex < charactersList.Items.Count - 1)
                    charactersList.SelectedIndex += 1;
            }
            MiscTab.SelectedTab = Weapons;
            weaponsList.SelectedIndex = 0;
            foreach (string file in weapons)
            {

                verifyWeapon();
                if (weaponsList.SelectedIndex < weaponsList.Items.Count - 1)
                    weaponsList.SelectedIndex += 1;
            }

            MiscTab.SelectedTab = Armours;
            armourList0.SelectedIndex = 0;
            foreach (string file in armors)
            {
                verifyArmor();
                if (armourList0.SelectedIndex < armourList0.Items.Count - 1)
                    armourList0.SelectedIndex += 1;
            }
            MiscTab.SelectedTab = currentTab;
        }

        void exportFile()
        {
            string filePath = "./Data/Exports/DataBase.cpp";
            File.Create(filePath).Close();
            StreamWriter exportFile = new StreamWriter(filePath);
            int counter = 0;

            //Basic Template:
            exportFile.WriteLine("#include \"pch.h\"");
            exportFile.WriteLine("#include \"DataBase.h\"");
            exportFile.WriteLine("");
            //Method for acquiring Armor items by ID
            exportFile.WriteLine("//Method for acquiring Armor items by ID");
            exportFile.WriteLine("ArmorComponent * DataBase::getArmor(int ID)");
            exportFile.WriteLine("{");
            exportFile.WriteLine("  for(auto i = armors.begin(); i != armors.end(); ++i)");
            exportFile.WriteLine("      if(ID == i->getid())");
            exportFile.WriteLine("          return i->copySelf();");
            exportFile.WriteLine("  throw \"404: not found\";");
            exportFile.WriteLine("  return nullptr;");
            exportFile.WriteLine("}");
            exportFile.WriteLine("");
            //Method for acquiring Armor items by Name
            exportFile.WriteLine("//Method for acquiring Armor items by Name");
            exportFile.WriteLine("ArmorComponent * DataBase::getArmor(string Name)");
            exportFile.WriteLine("{");
            exportFile.WriteLine("  for(auto i = armors.begin(); i!= armors.end(); ++i)");
            exportFile.WriteLine("       if(Name == i->getname())");
            exportFile.WriteLine("          return i->copySelf();");
            exportFile.WriteLine("  throw \"404: not found\";");
            exportFile.WriteLine("  return nullptr;");
            exportFile.WriteLine("}");
            exportFile.WriteLine("");
            //Method for acquiring Weapon item by ID
            exportFile.WriteLine("//Method for acquiring Weapon item by ID");
            exportFile.WriteLine("WeaponComponent * DataBase::getWeapon(int ID)");
            exportFile.WriteLine("{");
            exportFile.WriteLine("  for(auto i = weapons.begin(); i!=weapons.end(); ++i) {");
            exportFile.WriteLine("      if(ID == i->getid())");
            exportFile.WriteLine("          return i->copySelf();");
            exportFile.WriteLine("  }");
            exportFile.WriteLine("  throw \"404: not found\";");
            exportFile.WriteLine("  return nullptr;");
            exportFile.WriteLine("}");
            exportFile.WriteLine("");
            //Method for acquiring Weapon item by Name
            exportFile.WriteLine("//Method for acquiring Weapon item by Name");
            exportFile.WriteLine("WeaponComponent * DataBase::getWeapon(string Name)");
            exportFile.WriteLine("{");
            exportFile.WriteLine("  for(auto i =weapons.begin(); i != weapons.end(); ++i) {");
            exportFile.WriteLine("      if(Name == i->Getname())");
            exportFile.WriteLine("          return i->copySelf();");
            exportFile.WriteLine("  }");
            exportFile.WriteLine("  throw \"404: not found\";");
            exportFile.WriteLine("  return nullptr;");
            exportFile.WriteLine("}");
            //Method for acquiring Character by ID

            //Method for acquiring Character by Name

            //Deconstructor
            exportFile.WriteLine("DataBase::~DataBase()");
            exportFile.WriteLine("{");
            exportFile.WriteLine("}");


            //Constructor
            exportFile.WriteLine("DataBase::DataBase()");
            exportFile.WriteLine("{");
            //Loading Txt files onto Lists:
            List<string> characterList = loadData("Characters/");
            List<string> weaponList = loadData("Weapons");
            List<string> armorList = loadData("Armours");

            //Populating Characters Database List
            //foreach (string characterTXT in characterList)
            //{
            //}

            //Populating Weapons

            //Comment Line:
            exportFile.WriteLine("//weapons.push_back(new WeaponComponent(Type, Name));");
            exportFile.WriteLine("//weapons[id].spawn(element,amplitude,duration,damage,range,masteryReq,classReq,Description);");
            exportFile.WriteLine("");

            foreach (string weaponTXT in weaponList)
            {
                string weaponPath = "./Data/Weapons/" + weaponTXT;
                string[] lines = File.ReadAllLines(weaponPath);
                int reader = 0;
                string weaponIDExport = "0";
                string weaponNameExport = "";
                string weaponTypeExport = "";
                string baseDamageExport = "";
                string rangeExport = "";
                string elementExport = "";
                string amplitudeExport = "";
                string durationExport = "";
                string masteryReqExport = "";
                string classReqExport = "";
                string descExport = "";


                foreach (string line in lines)
                {

                    //Code for one weapon
                    switch (reader)
                    {
                        case 0:
                            weaponIDExport = line;
                            break;
                        case 1:
                            weaponNameExport = line;
                            break;
                        case 2:
                            weaponTypeExport = line;
                            break;
                        case 3:
                            baseDamageExport = line;
                            break;
                        case 4:
                            rangeExport = line;
                            break;
                        case 5:
                            elementExport = line;
                            break;
                        case 6:
                            amplitudeExport = line;
                            break;
                        case 7:
                            durationExport = line;
                            break;
                        case 8:
                            masteryReqExport = line;
                            break;
                        case 9:
                            classReqExport = line;
                            break;
                        case 10:
                            descExport = line;
                            break;
                    }
                    reader++;

                }
                exportFile.WriteLine("weapons.push_back(new WeaponComponent(\"" + weaponTypeExport + "\",\"" + weaponNameExport + "\"));");
                exportFile.WriteLine("weapons[" + counter + "].spawn(\"" + elementExport + "\","
                                                         + amplitudeExport + ","
                                                         + durationExport + ","
                                                         + baseDamageExport + ","
                                                         + rangeExport + ","
                                                         + masteryReqExport + ",\""
                                                         + classReqExport + "\",\""
                                                         + descExport + "\");");
                exportFile.WriteLine("");
                counter++;

            }

            //Populating Armors  

            exportFile.WriteLine("//Populating Armors DataBase");
            exportFile.WriteLine("//Buffs/Debuffs haven't been included yet.");

            foreach (string armorTXT in armorList)
            {
                string armorPath = "./Data/Armours/" + armorTXT;
                string[] lines = File.ReadAllLines(armorPath);
                int reader = 0;
                for (int i = 21; i <= 25; i++)
                {
                    if (lines[i] == "1") lines[i] = "true";
                    else lines[i] = "false";
                }
                exportFile.WriteLine("armors.push_back(new ArmorComponent(" + lines[1] + "));");
                exportFile.WriteLine("armors[" + reader + "].spawn([<\"Fire\"," + lines[6] +
                                                   ">,<\"Ice\"," + lines[7] +
                                                   ">,<\"Poison\"," + lines[8] +
                                                   ">,<\"Dark\"," + lines[9] +
                                                   ">,<\"Nature\"," + lines[10] +
                                                   ">,<\"Wind\"," + lines[11] +
                                                   ">,<\"Light\"," + lines[12] +
                                                   ">,<\"Harmony\"," + lines[13] + ">]," +
                                                   lines[25] + "," +
                                                   lines[26] +
                                                   ",[<\"legs\"," + lines[21] +
                                                   ">,<\"rightArm\"" + lines[22] +
                                                   ">,<\"leftArm\"" + lines[23] +
                                                   ">,<\"Head\"" + lines[24] + ">]," +
                                                   lines[3] + "," + lines[2] + "," + lines[4] + "," + lines[5] + ");");
                exportFile.WriteLine("");
            }



            exportFile.WriteLine("}");
            exportFile.Close();
            System.Windows.Forms.MessageBox.Show("DataBase.cpp has been exported succesfully");
            System.Diagnostics.Process.Start("./Data/Exports\\");
        }
        }
   
    
}


namespace Game_Objects_Editor
{
    partial class newChar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Health = new System.Windows.Forms.Label();
            this.actionsBox = new System.Windows.Forms.TextBox();
            this.healthBox = new System.Windows.Forms.TextBox();
            this.actions = new System.Windows.Forms.Label();
            this.agility = new System.Windows.Forms.Label();
            this.agilityBox = new System.Windows.Forms.TextBox();
            this.precision = new System.Windows.Forms.Label();
            this.precisionBox = new System.Windows.Forms.TextBox();
            this.energy = new System.Windows.Forms.Label();
            this.energyBox = new System.Windows.Forms.TextBox();
            this.mastery = new System.Windows.Forms.Label();
            this.experienceBox = new System.Windows.Forms.TextBox();
            this.masteryBox = new System.Windows.Forms.TextBox();
            this.experience = new System.Windows.Forms.Label();
            this.createCharButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(18, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(57, 22);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(81, 11);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 1;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Health);
            this.panel2.Controls.Add(this.actionsBox);
            this.panel2.Controls.Add(this.healthBox);
            this.panel2.Controls.Add(this.actions);
            this.panel2.Controls.Add(this.agility);
            this.panel2.Controls.Add(this.agilityBox);
            this.panel2.Controls.Add(this.precision);
            this.panel2.Controls.Add(this.precisionBox);
            this.panel2.Controls.Add(this.energy);
            this.panel2.Controls.Add(this.energyBox);
            this.panel2.Controls.Add(this.mastery);
            this.panel2.Controls.Add(this.experienceBox);
            this.panel2.Controls.Add(this.masteryBox);
            this.panel2.Controls.Add(this.experience);
            this.panel2.Location = new System.Drawing.Point(12, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 234);
            this.panel2.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "STATS";
            // 
            // Health
            // 
            this.Health.AutoSize = true;
            this.Health.Location = new System.Drawing.Point(28, 62);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(61, 13);
            this.Health.TabIndex = 4;
            this.Health.Text = "Max Health";
            // 
            // actionsBox
            // 
            this.actionsBox.Location = new System.Drawing.Point(127, 195);
            this.actionsBox.Name = "actionsBox";
            this.actionsBox.Size = new System.Drawing.Size(47, 20);
            this.actionsBox.TabIndex = 29;
            this.actionsBox.TextChanged += new System.EventHandler(this.actionsBox_TextChanged);
            // 
            // healthBox
            // 
            this.healthBox.Location = new System.Drawing.Point(127, 59);
            this.healthBox.Name = "healthBox";
            this.healthBox.Size = new System.Drawing.Size(47, 20);
            this.healthBox.TabIndex = 5;
            this.healthBox.TextChanged += new System.EventHandler(this.healthBox_TextChanged);
            // 
            // actions
            // 
            this.actions.AutoSize = true;
            this.actions.Location = new System.Drawing.Point(31, 195);
            this.actions.Name = "actions";
            this.actions.Size = new System.Drawing.Size(42, 13);
            this.actions.TabIndex = 28;
            this.actions.Text = "Actions";
            // 
            // agility
            // 
            this.agility.AutoSize = true;
            this.agility.Location = new System.Drawing.Point(28, 85);
            this.agility.Name = "agility";
            this.agility.Size = new System.Drawing.Size(34, 13);
            this.agility.TabIndex = 6;
            this.agility.Text = "Agility";
            // 
            // agilityBox
            // 
            this.agilityBox.Location = new System.Drawing.Point(127, 85);
            this.agilityBox.Name = "agilityBox";
            this.agilityBox.Size = new System.Drawing.Size(47, 20);
            this.agilityBox.TabIndex = 7;
            this.agilityBox.TextChanged += new System.EventHandler(this.agilityBox_TextChanged);
            // 
            // precision
            // 
            this.precision.AutoSize = true;
            this.precision.Location = new System.Drawing.Point(28, 111);
            this.precision.Name = "precision";
            this.precision.Size = new System.Drawing.Size(50, 13);
            this.precision.TabIndex = 8;
            this.precision.Text = "Precision";
            // 
            // precisionBox
            // 
            this.precisionBox.Location = new System.Drawing.Point(127, 111);
            this.precisionBox.Name = "precisionBox";
            this.precisionBox.Size = new System.Drawing.Size(47, 20);
            this.precisionBox.TabIndex = 9;
            this.precisionBox.TextChanged += new System.EventHandler(this.precisionBox_TextChanged);
            // 
            // energy
            // 
            this.energy.AutoSize = true;
            this.energy.Location = new System.Drawing.Point(28, 139);
            this.energy.Name = "energy";
            this.energy.Size = new System.Drawing.Size(63, 13);
            this.energy.TabIndex = 10;
            this.energy.Text = "Max Energy";
            // 
            // energyBox
            // 
            this.energyBox.Location = new System.Drawing.Point(127, 136);
            this.energyBox.Name = "energyBox";
            this.energyBox.Size = new System.Drawing.Size(47, 20);
            this.energyBox.TabIndex = 11;
            this.energyBox.TextChanged += new System.EventHandler(this.energyBox_TextChanged);
            // 
            // mastery
            // 
            this.mastery.AutoSize = true;
            this.mastery.Location = new System.Drawing.Point(28, 169);
            this.mastery.Name = "mastery";
            this.mastery.Size = new System.Drawing.Size(44, 13);
            this.mastery.TabIndex = 16;
            this.mastery.Text = "Mastery";
            // 
            // experienceBox
            // 
            this.experienceBox.Location = new System.Drawing.Point(127, 31);
            this.experienceBox.Name = "experienceBox";
            this.experienceBox.Size = new System.Drawing.Size(47, 20);
            this.experienceBox.TabIndex = 3;
            this.experienceBox.TextChanged += new System.EventHandler(this.experienceBox_TextChanged);
            // 
            // masteryBox
            // 
            this.masteryBox.Location = new System.Drawing.Point(127, 169);
            this.masteryBox.Name = "masteryBox";
            this.masteryBox.Size = new System.Drawing.Size(47, 20);
            this.masteryBox.TabIndex = 17;
            this.masteryBox.TextChanged += new System.EventHandler(this.masteryBox_TextChanged);
            // 
            // experience
            // 
            this.experience.AutoSize = true;
            this.experience.Location = new System.Drawing.Point(28, 38);
            this.experience.Name = "experience";
            this.experience.Size = new System.Drawing.Size(60, 13);
            this.experience.TabIndex = 2;
            this.experience.Text = "Experience";
            // 
            // createCharButton
            // 
            this.createCharButton.Location = new System.Drawing.Point(70, 308);
            this.createCharButton.Name = "createCharButton";
            this.createCharButton.Size = new System.Drawing.Size(75, 23);
            this.createCharButton.TabIndex = 32;
            this.createCharButton.Text = "Create";
            this.createCharButton.UseVisualStyleBackColor = true;
            this.createCharButton.Click += new System.EventHandler(this.createCharButton_Click);
            // 
            // newChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 359);
            this.Controls.Add(this.createCharButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.name);
            this.Name = "newChar";
            this.Text = "New Character";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Health;
        private System.Windows.Forms.TextBox actionsBox;
        private System.Windows.Forms.TextBox healthBox;
        private System.Windows.Forms.Label actions;
        private System.Windows.Forms.Label agility;
        private System.Windows.Forms.TextBox agilityBox;
        private System.Windows.Forms.Label precision;
        private System.Windows.Forms.TextBox precisionBox;
        private System.Windows.Forms.Label energy;
        private System.Windows.Forms.TextBox energyBox;
        private System.Windows.Forms.Label mastery;
        private System.Windows.Forms.TextBox experienceBox;
        private System.Windows.Forms.TextBox masteryBox;
        private System.Windows.Forms.Label experience;
        private System.Windows.Forms.Button createCharButton;
    }
}
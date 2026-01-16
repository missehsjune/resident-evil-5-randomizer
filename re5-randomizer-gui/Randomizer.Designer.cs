namespace re5_randomizer_gui
    {
    partial class Randomizer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randomizer));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonFolderSelect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelSeedNumber = new System.Windows.Forms.Label();
            this.buttonRandomize = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelEnemyVariety = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelMapSelection = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.labelEnemySelection = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.randomizeEnemiesCheckBox = new System.Windows.Forms.CheckBox();
            this.randomizeItemCheckBox = new System.Windows.Forms.CheckBox();
            this.keyItemCheckBox = new System.Windows.Forms.CheckBox();
            this.treasureItemCheckBox = new System.Windows.Forms.CheckBox();
            this.unsafeItemCheckBox = new System.Windows.Forms.CheckBox();
            this.randomizeQuantityCheckBox = new System.Windows.Forms.CheckBox();
            this.minesLanternCheckBox = new System.Windows.Forms.CheckBox();
            this.startingCaseWeaponCheckbox = new System.Windows.Forms.CheckBox();
            this.dlcItemCheckbox = new System.Windows.Forms.CheckBox();
            this.weaponCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // buttonFolderSelect
            // 
            this.buttonFolderSelect.Location = new System.Drawing.Point(493, 36);
            this.buttonFolderSelect.Name = "buttonFolderSelect";
            this.buttonFolderSelect.Size = new System.Drawing.Size(87, 23);
            this.buttonFolderSelect.TabIndex = 0;
            this.buttonFolderSelect.Text = "Select Folder";
            this.toolTip1.SetToolTip(this.buttonFolderSelect, "Choose the folder containing the level files and ARCTool.exe.");
            this.buttonFolderSelect.UseVisualStyleBackColor = true;
            this.buttonFolderSelect.Click += new System.EventHandler(this.buttonFolderSelect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(475, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Location = new System.Drawing.Point(13, 19);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(229, 13);
            this.labelFilePath.TabIndex = 2;
            this.labelFilePath.Text = "Select location of game files and ARCTool.exe:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(212, 69);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            this.toolTip1.SetToolTip(this.numericUpDown1, "This number will be used as the basis of randomization. Two different seeds with " +
        "the same settings will give different randomization.");
            // 
            // labelSeedNumber
            // 
            this.labelSeedNumber.AutoSize = true;
            this.labelSeedNumber.Location = new System.Drawing.Point(12, 71);
            this.labelSeedNumber.Name = "labelSeedNumber";
            this.labelSeedNumber.Size = new System.Drawing.Size(194, 13);
            this.labelSeedNumber.TabIndex = 4;
            this.labelSeedNumber.Text = "Enter a seed number for randomization: ";
            this.toolTip1.SetToolTip(this.labelSeedNumber, "This number will be used as the basis of randomization. Two different seeds with " +
        "the same settings will give different randomization.");
            // 
            // buttonRandomize
            // 
            this.buttonRandomize.Enabled = false;
            this.buttonRandomize.Location = new System.Drawing.Point(262, 357);
            this.buttonRandomize.Name = "buttonRandomize";
            this.buttonRandomize.Size = new System.Drawing.Size(75, 23);
            this.buttonRandomize.TabIndex = 5;
            this.buttonRandomize.Text = "Randomize";
            this.toolTip1.SetToolTip(this.buttonRandomize, "Randomizes.");
            this.buttonRandomize.UseVisualStyleBackColor = true;
            this.buttonRandomize.Click += new System.EventHandler(this.buttonRandomize_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(170, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Single enemy per spawn group";
            this.toolTip1.SetToolTip(this.radioButton1, "Will replace spawn files with only a single enemy.");
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // labelEnemyVariety
            // 
            this.labelEnemyVariety.Enabled = false;
            this.labelEnemyVariety.Location = new System.Drawing.Point(12, 132);
            this.labelEnemyVariety.Name = "labelEnemyVariety";
            this.labelEnemyVariety.Size = new System.Drawing.Size(91, 13);
            this.labelEnemyVariety.TabIndex = 0;
            this.labelEnemyVariety.Text = "Enemy Variety: ";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(161, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Match original game\'s variety";
            this.toolTip1.SetToolTip(this.radioButton2, "Will replace spawn files with the same number of enemies as was there originally " +
        "(2 unique enemies = 2 unique enemies).");
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(15, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 76);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // labelMapSelection
            // 
            this.labelMapSelection.AutoSize = true;
            this.labelMapSelection.Enabled = false;
            this.labelMapSelection.Location = new System.Drawing.Point(203, 132);
            this.labelMapSelection.Name = "labelMapSelection";
            this.labelMapSelection.Size = new System.Drawing.Size(112, 13);
            this.labelMapSelection.TabIndex = 9;
            this.labelMapSelection.Text = "Levels to Randomize: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(206, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 95);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(7, 66);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(140, 17);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Main game + DLC levels";
            this.toolTip1.SetToolTip(this.radioButton8, "Randomizes the same levels as above option, as well as the DLC levels.");
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 42);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(173, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "All non-guaranteed crash levels";
            this.toolTip1.SetToolTip(this.radioButton4, "Will randomize all the levels that do not crash. Should be softlock free, due to " +
        "additional key items added.");
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(99, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Only safe levels";
            this.toolTip1.SetToolTip(this.radioButton3, "Will only randomize levels that should not crash (Mostly obselete).");
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // labelEnemySelection
            // 
            this.labelEnemySelection.AutoSize = true;
            this.labelEnemySelection.Enabled = false;
            this.labelEnemySelection.Location = new System.Drawing.Point(394, 132);
            this.labelEnemySelection.Name = "labelEnemySelection";
            this.labelEnemySelection.Size = new System.Drawing.Size(98, 13);
            this.labelEnemySelection.TabIndex = 11;
            this.labelEnemySelection.Text = "Enemy List to Use: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(397, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 76);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(7, 42);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(132, 17);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "All main game enemies";
            this.toolTip1.SetToolTip(this.radioButton6, "Replaces enemies with all main game enemies that do not guarantee problems.");
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Location = new System.Drawing.Point(7, 19);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(111, 17);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Only safe enemies";
            this.toolTip1.SetToolTip(this.radioButton5, "Replaces enemies in the game with only enemies that should not cause crashes.");
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // randomizeEnemiesCheckBox
            // 
            this.randomizeEnemiesCheckBox.AutoSize = true;
            this.randomizeEnemiesCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.randomizeEnemiesCheckBox.Location = new System.Drawing.Point(11, 105);
            this.randomizeEnemiesCheckBox.Name = "randomizeEnemiesCheckBox";
            this.randomizeEnemiesCheckBox.Size = new System.Drawing.Size(128, 17);
            this.randomizeEnemiesCheckBox.TabIndex = 13;
            this.randomizeEnemiesCheckBox.Text = "Randomize Enemies?";
            this.toolTip1.SetToolTip(this.randomizeEnemiesCheckBox, "Toggle to enable randomization of the enemies in the game. Options below change w" +
        "hich levels are randomized and variety of enemies.");
            this.randomizeEnemiesCheckBox.UseVisualStyleBackColor = true;
            this.randomizeEnemiesCheckBox.CheckedChanged += new System.EventHandler(this.randomizeEnemiesCheckBox_CheckedChanged);
            // 
            // randomizeItemCheckBox
            // 
            this.randomizeItemCheckBox.AutoSize = true;
            this.randomizeItemCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.randomizeItemCheckBox.Location = new System.Drawing.Point(11, 242);
            this.randomizeItemCheckBox.Name = "randomizeItemCheckBox";
            this.randomizeItemCheckBox.Size = new System.Drawing.Size(113, 17);
            this.randomizeItemCheckBox.TabIndex = 14;
            this.randomizeItemCheckBox.Text = "Randomize Items?";
            this.toolTip1.SetToolTip(this.randomizeItemCheckBox, "Toggle to enable randomization of items in the game. Options below change the ava" +
        "ilable pool of items.");
            this.randomizeItemCheckBox.UseVisualStyleBackColor = true;
            this.randomizeItemCheckBox.CheckedChanged += new System.EventHandler(this.randomizeItemCheckBox_CheckedChanged);
            // 
            // keyItemCheckBox
            // 
            this.keyItemCheckBox.AutoSize = true;
            this.keyItemCheckBox.Enabled = false;
            this.keyItemCheckBox.Location = new System.Drawing.Point(34, 275);
            this.keyItemCheckBox.Name = "keyItemCheckBox";
            this.keyItemCheckBox.Size = new System.Drawing.Size(110, 17);
            this.keyItemCheckBox.TabIndex = 15;
            this.keyItemCheckBox.Text = "Include Key Items";
            this.toolTip1.SetToolTip(this.keyItemCheckBox, "Includes all main game key items ");
            this.keyItemCheckBox.UseVisualStyleBackColor = true;
            // 
            // treasureItemCheckBox
            // 
            this.treasureItemCheckBox.AutoSize = true;
            this.treasureItemCheckBox.Enabled = false;
            this.treasureItemCheckBox.Location = new System.Drawing.Point(212, 275);
            this.treasureItemCheckBox.Name = "treasureItemCheckBox";
            this.treasureItemCheckBox.Size = new System.Drawing.Size(111, 17);
            this.treasureItemCheckBox.TabIndex = 16;
            this.treasureItemCheckBox.Text = "Include Treasures";
            this.toolTip1.SetToolTip(this.treasureItemCheckBox, "Includes all treasure items (gems, bugs, etc.)");
            this.treasureItemCheckBox.UseVisualStyleBackColor = true;
            // 
            // unsafeItemCheckBox
            // 
            this.unsafeItemCheckBox.AutoSize = true;
            this.unsafeItemCheckBox.Enabled = false;
            this.unsafeItemCheckBox.Location = new System.Drawing.Point(34, 323);
            this.unsafeItemCheckBox.Name = "unsafeItemCheckBox";
            this.unsafeItemCheckBox.Size = new System.Drawing.Size(126, 17);
            this.unsafeItemCheckBox.TabIndex = 17;
            this.unsafeItemCheckBox.Text = "Include Unsafe Items";
            this.toolTip1.SetToolTip(this.unsafeItemCheckBox, "Includes enemy weapons and various items not intended to be spawned.");
            this.unsafeItemCheckBox.UseVisualStyleBackColor = true;
            // 
            // randomizeQuantityCheckBox
            // 
            this.randomizeQuantityCheckBox.AutoSize = true;
            this.randomizeQuantityCheckBox.Enabled = false;
            this.randomizeQuantityCheckBox.Location = new System.Drawing.Point(212, 323);
            this.randomizeQuantityCheckBox.Name = "randomizeQuantityCheckBox";
            this.randomizeQuantityCheckBox.Size = new System.Drawing.Size(121, 17);
            this.randomizeQuantityCheckBox.TabIndex = 18;
            this.randomizeQuantityCheckBox.Text = "Randomize Quantity";
            this.toolTip1.SetToolTip(this.randomizeQuantityCheckBox, "Items will have a random quantity (weapon ammo, healing item usage, money value, " +
        "etc.)");
            this.randomizeQuantityCheckBox.UseVisualStyleBackColor = true;
            this.randomizeQuantityCheckBox.Visible = false;
            // 
            // minesLanternCheckBox
            // 
            this.minesLanternCheckBox.AutoSize = true;
            this.minesLanternCheckBox.Enabled = false;
            this.minesLanternCheckBox.Location = new System.Drawing.Point(404, 275);
            this.minesLanternCheckBox.Name = "minesLanternCheckBox";
            this.minesLanternCheckBox.Size = new System.Drawing.Size(108, 17);
            this.minesLanternCheckBox.TabIndex = 20;
            this.minesLanternCheckBox.Text = "Keep 2-1 Lantern";
            this.toolTip1.SetToolTip(this.minesLanternCheckBox, "For players who can\'t see without it, will leave the lantern in the mines.");
            this.minesLanternCheckBox.UseVisualStyleBackColor = true;
            // 
            // startingCaseWeaponCheckbox
            // 
            this.startingCaseWeaponCheckbox.AutoSize = true;
            this.startingCaseWeaponCheckbox.Enabled = false;
            this.startingCaseWeaponCheckbox.Location = new System.Drawing.Point(404, 300);
            this.startingCaseWeaponCheckbox.Name = "startingCaseWeaponCheckbox";
            this.startingCaseWeaponCheckbox.Size = new System.Drawing.Size(174, 17);
            this.startingCaseWeaponCheckbox.TabIndex = 21;
            this.startingCaseWeaponCheckbox.Text = "Keep starting case as weapons";
            this.toolTip1.SetToolTip(this.startingCaseWeaponCheckbox, "For fresh save files, ensures weapons will be in the starting case.");
            this.startingCaseWeaponCheckbox.UseVisualStyleBackColor = true;
            // 
            // dlcItemCheckbox
            // 
            this.dlcItemCheckbox.AutoSize = true;
            this.dlcItemCheckbox.Enabled = false;
            this.dlcItemCheckbox.Location = new System.Drawing.Point(212, 300);
            this.dlcItemCheckbox.Name = "dlcItemCheckbox";
            this.dlcItemCheckbox.Size = new System.Drawing.Size(113, 17);
            this.dlcItemCheckbox.TabIndex = 22;
            this.dlcItemCheckbox.Text = "Include DLC Items";
            this.toolTip1.SetToolTip(this.dlcItemCheckbox, "Includes items from the DLCs. Do not enable when playing with non-Gold edition ga" +
        "mes.");
            this.dlcItemCheckbox.UseVisualStyleBackColor = true;
            // 
            // weaponCheckBox
            // 
            this.weaponCheckBox.AutoSize = true;
            this.weaponCheckBox.Enabled = false;
            this.weaponCheckBox.Location = new System.Drawing.Point(34, 300);
            this.weaponCheckBox.Name = "weaponCheckBox";
            this.weaponCheckBox.Size = new System.Drawing.Size(110, 17);
            this.weaponCheckBox.TabIndex = 23;
            this.weaponCheckBox.Text = "Include Weapons";
            this.toolTip1.SetToolTip(this.weaponCheckBox, "Includes all regular weapons used by the player.");
            this.weaponCheckBox.UseVisualStyleBackColor = true;
            // 
            // Randomizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 394);
            this.Controls.Add(this.weaponCheckBox);
            this.Controls.Add(this.dlcItemCheckbox);
            this.Controls.Add(this.startingCaseWeaponCheckbox);
            this.Controls.Add(this.minesLanternCheckBox);
            this.Controls.Add(this.randomizeQuantityCheckBox);
            this.Controls.Add(this.unsafeItemCheckBox);
            this.Controls.Add(this.treasureItemCheckBox);
            this.Controls.Add(this.keyItemCheckBox);
            this.Controls.Add(this.randomizeItemCheckBox);
            this.Controls.Add(this.randomizeEnemiesCheckBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labelEnemySelection);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelMapSelection);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelEnemyVariety);
            this.Controls.Add(this.buttonRandomize);
            this.Controls.Add(this.labelSeedNumber);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelFilePath);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonFolderSelect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Randomizer";
            this.Text = "Resident Evil 5 Randomizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonFolderSelect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelSeedNumber;
        private System.Windows.Forms.Button buttonRandomize;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labelEnemyVariety;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelMapSelection;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label labelEnemySelection;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.CheckBox randomizeEnemiesCheckBox;
        private System.Windows.Forms.CheckBox randomizeItemCheckBox;
        private System.Windows.Forms.CheckBox keyItemCheckBox;
        private System.Windows.Forms.CheckBox treasureItemCheckBox;
        private System.Windows.Forms.CheckBox unsafeItemCheckBox;
        private System.Windows.Forms.CheckBox randomizeQuantityCheckBox;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.CheckBox minesLanternCheckBox;
        private System.Windows.Forms.CheckBox startingCaseWeaponCheckbox;
        private System.Windows.Forms.CheckBox dlcItemCheckbox;
        private System.Windows.Forms.CheckBox weaponCheckBox;
        private System.Windows.Forms.ToolTip toolTip1;
        }
    }


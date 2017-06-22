using System.Collections;
using System;
using System.Diagnostics;
using System.IO;
using System.Data;

namespace WindowsFormsApplication1
{
    partial class PF
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
            this.strengthBox = new System.Windows.Forms.NumericUpDown();
            this.dexterityBox = new System.Windows.Forms.NumericUpDown();
            this.constitutionBox = new System.Windows.Forms.NumericUpDown();
            this.intelligenceBox = new System.Windows.Forms.NumericUpDown();
            this.wisdomBox = new System.Windows.Forms.NumericUpDown();
            this.charismaBox = new System.Windows.Forms.NumericUpDown();
            this.la_strengthBox = new System.Windows.Forms.Label();
            this.la_dexterityBox = new System.Windows.Forms.Label();
            this.la_constitutionBox = new System.Windows.Forms.Label();
            this.la_intelligenceBox = new System.Windows.Forms.Label();
            this.la_wisdomBox = new System.Windows.Forms.Label();
            this.la_charismaBox = new System.Windows.Forms.Label();
            this.strengthMod = new System.Windows.Forms.TextBox();
            this.dexterityMod = new System.Windows.Forms.TextBox();
            this.constitutionMod = new System.Windows.Forms.TextBox();
            this.intelligenceMod = new System.Windows.Forms.TextBox();
            this.wisdomMod = new System.Windows.Forms.TextBox();
            this.charismaMod = new System.Windows.Forms.TextBox();
            this.raceCollection = new System.Data.DataSet();
            this.updateData = new System.Windows.Forms.Button();
            this.la_raceBox = new System.Windows.Forms.Label();
            this.alignmentBox = new System.Windows.Forms.ComboBox();
            this.la_alignmentBox = new System.Windows.Forms.Label();
            this.templateBox1 = new System.Windows.Forms.ComboBox();
            this.templateBox2 = new System.Windows.Forms.ComboBox();
            this.templateBox3 = new System.Windows.Forms.ComboBox();
            this.la_templateBox1 = new System.Windows.Forms.Label();
            this.la_templateBox2 = new System.Windows.Forms.Label();
            this.la_templateBox3 = new System.Windows.Forms.Label();
            this.racialTraitBox = new System.Windows.Forms.ListBox();
            this.raceTraitData = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.raceBox = new System.Windows.Forms.ComboBox();
            this.bi_raceCollection = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.strengthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexterityBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.constitutionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intelligenceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wisdomBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charismaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTraitData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bi_raceCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // strengthBox
            // 
            this.strengthBox.AccessibleDescription = "";
            this.strengthBox.Location = new System.Drawing.Point(13, 13);
            this.strengthBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.strengthBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.strengthBox.Name = "strengthBox";
            this.strengthBox.Size = new System.Drawing.Size(53, 20);
            this.strengthBox.TabIndex = 0;
            this.strengthBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.strengthBox.ValueChanged += new System.EventHandler(this.strengthBox_ValueChanged);
            // 
            // dexterityBox
            // 
            this.dexterityBox.Location = new System.Drawing.Point(13, 39);
            this.dexterityBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.dexterityBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.dexterityBox.Name = "dexterityBox";
            this.dexterityBox.Size = new System.Drawing.Size(53, 20);
            this.dexterityBox.TabIndex = 1;
            this.dexterityBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.dexterityBox.ValueChanged += new System.EventHandler(this.dexterityBox_ValueChanged);
            // 
            // constitutionBox
            // 
            this.constitutionBox.Location = new System.Drawing.Point(13, 65);
            this.constitutionBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.constitutionBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.constitutionBox.Name = "constitutionBox";
            this.constitutionBox.Size = new System.Drawing.Size(53, 20);
            this.constitutionBox.TabIndex = 2;
            this.constitutionBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.constitutionBox.ValueChanged += new System.EventHandler(this.constitutionBox_ValueChanged);
            // 
            // intelligenceBox
            // 
            this.intelligenceBox.Location = new System.Drawing.Point(13, 91);
            this.intelligenceBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.intelligenceBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.intelligenceBox.Name = "intelligenceBox";
            this.intelligenceBox.Size = new System.Drawing.Size(53, 20);
            this.intelligenceBox.TabIndex = 3;
            this.intelligenceBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.intelligenceBox.ValueChanged += new System.EventHandler(this.intelligenceBox_ValueChanged);
            // 
            // wisdomBox
            // 
            this.wisdomBox.Location = new System.Drawing.Point(13, 117);
            this.wisdomBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.wisdomBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.wisdomBox.Name = "wisdomBox";
            this.wisdomBox.Size = new System.Drawing.Size(53, 20);
            this.wisdomBox.TabIndex = 4;
            this.wisdomBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.wisdomBox.ValueChanged += new System.EventHandler(this.wisdomBox_ValueChanged);
            // 
            // charismaBox
            // 
            this.charismaBox.Location = new System.Drawing.Point(13, 143);
            this.charismaBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.charismaBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.charismaBox.Name = "charismaBox";
            this.charismaBox.Size = new System.Drawing.Size(53, 20);
            this.charismaBox.TabIndex = 5;
            this.charismaBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.charismaBox.ValueChanged += new System.EventHandler(this.charismaBox_ValueChanged);
            // 
            // la_strengthBox
            // 
            this.la_strengthBox.AutoSize = true;
            this.la_strengthBox.Location = new System.Drawing.Point(122, 13);
            this.la_strengthBox.Name = "la_strengthBox";
            this.la_strengthBox.Size = new System.Drawing.Size(47, 13);
            this.la_strengthBox.TabIndex = 6;
            this.la_strengthBox.Text = "Strength";
            // 
            // la_dexterityBox
            // 
            this.la_dexterityBox.AutoSize = true;
            this.la_dexterityBox.Location = new System.Drawing.Point(121, 39);
            this.la_dexterityBox.Name = "la_dexterityBox";
            this.la_dexterityBox.Size = new System.Drawing.Size(48, 13);
            this.la_dexterityBox.TabIndex = 7;
            this.la_dexterityBox.Text = "Dexterity";
            // 
            // la_constitutionBox
            // 
            this.la_constitutionBox.AutoSize = true;
            this.la_constitutionBox.Location = new System.Drawing.Point(121, 65);
            this.la_constitutionBox.Name = "la_constitutionBox";
            this.la_constitutionBox.Size = new System.Drawing.Size(62, 13);
            this.la_constitutionBox.TabIndex = 8;
            this.la_constitutionBox.Text = "Constitution";
            // 
            // la_intelligenceBox
            // 
            this.la_intelligenceBox.AutoSize = true;
            this.la_intelligenceBox.Location = new System.Drawing.Point(122, 91);
            this.la_intelligenceBox.Name = "la_intelligenceBox";
            this.la_intelligenceBox.Size = new System.Drawing.Size(61, 13);
            this.la_intelligenceBox.TabIndex = 9;
            this.la_intelligenceBox.Text = "Intelligence";
            // 
            // la_wisdomBox
            // 
            this.la_wisdomBox.AutoSize = true;
            this.la_wisdomBox.Location = new System.Drawing.Point(121, 117);
            this.la_wisdomBox.Name = "la_wisdomBox";
            this.la_wisdomBox.Size = new System.Drawing.Size(45, 13);
            this.la_wisdomBox.TabIndex = 10;
            this.la_wisdomBox.Text = "Wisdom";
            // 
            // la_charismaBox
            // 
            this.la_charismaBox.AutoSize = true;
            this.la_charismaBox.Location = new System.Drawing.Point(121, 143);
            this.la_charismaBox.Name = "la_charismaBox";
            this.la_charismaBox.Size = new System.Drawing.Size(50, 13);
            this.la_charismaBox.TabIndex = 11;
            this.la_charismaBox.Text = "Charisma";
            // 
            // strengthMod
            // 
            this.strengthMod.Location = new System.Drawing.Point(72, 13);
            this.strengthMod.Name = "strengthMod";
            this.strengthMod.ReadOnly = true;
            this.strengthMod.Size = new System.Drawing.Size(43, 20);
            this.strengthMod.TabIndex = 12;
            this.strengthMod.Text = "0";
            // 
            // dexterityMod
            // 
            this.dexterityMod.Location = new System.Drawing.Point(72, 39);
            this.dexterityMod.Name = "dexterityMod";
            this.dexterityMod.ReadOnly = true;
            this.dexterityMod.Size = new System.Drawing.Size(43, 20);
            this.dexterityMod.TabIndex = 13;
            this.dexterityMod.Text = "0";
            // 
            // constitutionMod
            // 
            this.constitutionMod.Location = new System.Drawing.Point(72, 65);
            this.constitutionMod.Name = "constitutionMod";
            this.constitutionMod.ReadOnly = true;
            this.constitutionMod.Size = new System.Drawing.Size(43, 20);
            this.constitutionMod.TabIndex = 14;
            this.constitutionMod.Text = "0";
            // 
            // intelligenceMod
            // 
            this.intelligenceMod.Location = new System.Drawing.Point(72, 91);
            this.intelligenceMod.Name = "intelligenceMod";
            this.intelligenceMod.ReadOnly = true;
            this.intelligenceMod.Size = new System.Drawing.Size(43, 20);
            this.intelligenceMod.TabIndex = 15;
            this.intelligenceMod.Text = "0";
            // 
            // wisdomMod
            // 
            this.wisdomMod.Location = new System.Drawing.Point(72, 117);
            this.wisdomMod.Name = "wisdomMod";
            this.wisdomMod.ReadOnly = true;
            this.wisdomMod.Size = new System.Drawing.Size(43, 20);
            this.wisdomMod.TabIndex = 16;
            this.wisdomMod.Text = "0";
            // 
            // charismaMod
            // 
            this.charismaMod.Location = new System.Drawing.Point(72, 143);
            this.charismaMod.Name = "charismaMod";
            this.charismaMod.ReadOnly = true;
            this.charismaMod.Size = new System.Drawing.Size(43, 20);
            this.charismaMod.TabIndex = 17;
            this.charismaMod.Text = "0";
            // 
            // raceCollection
            // 
            this.raceCollection.DataSetName = "raceCollection";
            // 
            // updateData
            // 
            this.updateData.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updateData.Location = new System.Drawing.Point(12, 588);
            this.updateData.Name = "updateData";
            this.updateData.Size = new System.Drawing.Size(78, 23);
            this.updateData.TabIndex = 19;
            this.updateData.Text = "Update Data";
            this.updateData.UseVisualStyleBackColor = false;
            this.updateData.Click += new System.EventHandler(this.updateData_Click);
            // 
            // la_raceBox
            // 
            this.la_raceBox.AutoSize = true;
            this.la_raceBox.Location = new System.Drawing.Point(315, 13);
            this.la_raceBox.Name = "la_raceBox";
            this.la_raceBox.Size = new System.Drawing.Size(33, 13);
            this.la_raceBox.TabIndex = 22;
            this.la_raceBox.Text = "Race";
            // 
            // alignmentBox
            // 
            this.alignmentBox.FormattingEnabled = true;
            this.alignmentBox.Items.AddRange(new object[] {
            "N/A",
            "Lawful Good",
            "Neutral Good",
            "Chaotic Good",
            "Lawful Neutral",
            "True Neutral",
            "Chaotic Neutral",
            "Lawful Evil",
            "Neutral Evil",
            "Chaotic Evil"});
            this.alignmentBox.Location = new System.Drawing.Point(188, 36);
            this.alignmentBox.Name = "alignmentBox";
            this.alignmentBox.Size = new System.Drawing.Size(121, 21);
            this.alignmentBox.TabIndex = 23;
            this.alignmentBox.SelectedIndexChanged += new System.EventHandler(this.alignmentBox_SelectedIndexChanged);
            // 
            // la_alignmentBox
            // 
            this.la_alignmentBox.AutoSize = true;
            this.la_alignmentBox.Location = new System.Drawing.Point(316, 39);
            this.la_alignmentBox.Name = "la_alignmentBox";
            this.la_alignmentBox.Size = new System.Drawing.Size(53, 13);
            this.la_alignmentBox.TabIndex = 24;
            this.la_alignmentBox.Text = "Alignment";
            // 
            // templateBox1
            // 
            this.templateBox1.FormattingEnabled = true;
            this.templateBox1.Location = new System.Drawing.Point(188, 62);
            this.templateBox1.Name = "templateBox1";
            this.templateBox1.Size = new System.Drawing.Size(121, 21);
            this.templateBox1.TabIndex = 25;
            // 
            // templateBox2
            // 
            this.templateBox2.FormattingEnabled = true;
            this.templateBox2.Location = new System.Drawing.Point(188, 88);
            this.templateBox2.Name = "templateBox2";
            this.templateBox2.Size = new System.Drawing.Size(121, 21);
            this.templateBox2.TabIndex = 26;
            // 
            // templateBox3
            // 
            this.templateBox3.FormattingEnabled = true;
            this.templateBox3.Location = new System.Drawing.Point(188, 114);
            this.templateBox3.Name = "templateBox3";
            this.templateBox3.Size = new System.Drawing.Size(121, 21);
            this.templateBox3.TabIndex = 27;
            // 
            // la_templateBox1
            // 
            this.la_templateBox1.AutoSize = true;
            this.la_templateBox1.Location = new System.Drawing.Point(316, 64);
            this.la_templateBox1.Name = "la_templateBox1";
            this.la_templateBox1.Size = new System.Drawing.Size(60, 13);
            this.la_templateBox1.TabIndex = 28;
            this.la_templateBox1.Text = "Template 1";
            // 
            // la_templateBox2
            // 
            this.la_templateBox2.AutoSize = true;
            this.la_templateBox2.Location = new System.Drawing.Point(316, 91);
            this.la_templateBox2.Name = "la_templateBox2";
            this.la_templateBox2.Size = new System.Drawing.Size(60, 13);
            this.la_templateBox2.TabIndex = 29;
            this.la_templateBox2.Text = "Template 2";
            // 
            // la_templateBox3
            // 
            this.la_templateBox3.AutoSize = true;
            this.la_templateBox3.Location = new System.Drawing.Point(316, 119);
            this.la_templateBox3.Name = "la_templateBox3";
            this.la_templateBox3.Size = new System.Drawing.Size(60, 13);
            this.la_templateBox3.TabIndex = 30;
            this.la_templateBox3.Text = "Template 3";
            // 
            // racialTraitBox
            // 
            this.racialTraitBox.FormattingEnabled = true;
            this.racialTraitBox.Location = new System.Drawing.Point(382, 16);
            this.racialTraitBox.Name = "racialTraitBox";
            this.racialTraitBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.racialTraitBox.Size = new System.Drawing.Size(270, 121);
            this.racialTraitBox.TabIndex = 31;
            this.racialTraitBox.SelectedIndexChanged += new System.EventHandler(this.racialTraitBox_SelectedIndexChanged);
            // 
            // raceTraitData
            // 
            this.raceTraitData.DataSetName = "raceTraitData";
            this.raceTraitData.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.TableName = "Table1";
            // 
            // raceBox
            // 
            this.raceBox.DataSource = this.raceCollection;
            this.raceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.raceBox.FormattingEnabled = true;
            this.raceBox.Location = new System.Drawing.Point(188, 10);
            this.raceBox.Name = "raceBox";
            this.raceBox.Size = new System.Drawing.Size(121, 21);
            this.raceBox.TabIndex = 32;
            this.raceBox.SelectedIndexChanged += new System.EventHandler(this.raceBox_SelectedIndexChanged);
            // 
            // PF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(664, 623);
            this.Controls.Add(this.raceBox);
            this.Controls.Add(this.racialTraitBox);
            this.Controls.Add(this.la_templateBox3);
            this.Controls.Add(this.la_templateBox2);
            this.Controls.Add(this.la_templateBox1);
            this.Controls.Add(this.templateBox3);
            this.Controls.Add(this.templateBox2);
            this.Controls.Add(this.templateBox1);
            this.Controls.Add(this.la_alignmentBox);
            this.Controls.Add(this.alignmentBox);
            this.Controls.Add(this.la_raceBox);
            this.Controls.Add(this.updateData);
            this.Controls.Add(this.charismaMod);
            this.Controls.Add(this.wisdomMod);
            this.Controls.Add(this.intelligenceMod);
            this.Controls.Add(this.constitutionMod);
            this.Controls.Add(this.dexterityMod);
            this.Controls.Add(this.strengthMod);
            this.Controls.Add(this.la_charismaBox);
            this.Controls.Add(this.la_wisdomBox);
            this.Controls.Add(this.la_intelligenceBox);
            this.Controls.Add(this.la_constitutionBox);
            this.Controls.Add(this.la_dexterityBox);
            this.Controls.Add(this.la_strengthBox);
            this.Controls.Add(this.charismaBox);
            this.Controls.Add(this.wisdomBox);
            this.Controls.Add(this.intelligenceBox);
            this.Controls.Add(this.constitutionBox);
            this.Controls.Add(this.dexterityBox);
            this.Controls.Add(this.strengthBox);
            this.Name = "PF";
            this.Text = "Pathfinder NPC Generator";
            ((System.ComponentModel.ISupportInitialize)(this.strengthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexterityBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.constitutionBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intelligenceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wisdomBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charismaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTraitData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bi_raceCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown strengthBox;
        private System.Windows.Forms.NumericUpDown dexterityBox;
        private System.Windows.Forms.NumericUpDown constitutionBox;
        private System.Windows.Forms.NumericUpDown intelligenceBox;
        private System.Windows.Forms.NumericUpDown wisdomBox;
        private System.Windows.Forms.NumericUpDown charismaBox;
        private System.Windows.Forms.Label la_strengthBox;
        private System.Windows.Forms.Label la_dexterityBox;
        private System.Windows.Forms.Label la_constitutionBox;
        private System.Windows.Forms.Label la_intelligenceBox;
        private System.Windows.Forms.Label la_wisdomBox;
        private System.Windows.Forms.Label la_charismaBox;
        private System.Windows.Forms.TextBox strengthMod;
        private System.Windows.Forms.TextBox dexterityMod;
        private System.Windows.Forms.TextBox constitutionMod;
        private System.Windows.Forms.TextBox intelligenceMod;
        private System.Windows.Forms.TextBox wisdomMod;
        private System.Windows.Forms.TextBox charismaMod;

        public string modCalculation(System.Windows.Forms.NumericUpDown score)
        {
            decimal scoreNum = score.Value;
            if (scoreNum == -1 || scoreNum == 10)
            {
                return 0.ToString();
            } else
            {
               string mod = System.Math.Floor(((scoreNum - 10) / 2)).ToString();
               if (scoreNum > 11)
                {
                    mod = "+" + mod;
                }
                return mod;
            }
        }

        public string[] xmlArrayParse(string toSeperate)
        {
            string[] seperated;
            string[] seperator = { "," };
            seperated = toSeperate.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
            return seperated;
        }

        private System.Windows.Forms.Button updateData;
        private System.Data.DataSet raceCollection;
        private System.Windows.Forms.Label la_raceBox;
        private System.Windows.Forms.ComboBox alignmentBox;
        private System.Windows.Forms.Label la_alignmentBox;
        private System.Windows.Forms.ComboBox templateBox1;
        private System.Windows.Forms.ComboBox templateBox2;
        private System.Windows.Forms.ComboBox templateBox3;
        private System.Windows.Forms.Label la_templateBox1;
        private System.Windows.Forms.Label la_templateBox2;
        private System.Windows.Forms.Label la_templateBox3;
        private System.Windows.Forms.ListBox racialTraitBox;
        private System.Data.DataSet raceTraitData;


        public void updateRaceCollectionData()
        {
            raceCollection = new System.Data.DataSet(); //Clear away the previous existing data
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "raceCollection.xml");

            // Debug.WriteLine(Directory.GetCurrentDirectory());
            // Debug.WriteLine(filePath);

            raceCollection.ReadXml(filePath);

            raceBox.DataSource = raceCollection;
            raceBox.ValueMember = "races.raceName";
            raceBox.DisplayMember = "races.raceName";

        }

        public void updateRaceTraitData()
        {
            raceTraitData = new System.Data.DataSet(); //Clear away the previous existing data
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "raceTraitData.xml");
            raceTraitData.ReadXml(filePath);

            DataView dv = raceTraitData.Tables["raceTrait"].DefaultView;
            dv.RowFilter = "raceName = '" + raceBox.SelectedValue.ToString() + "'";
            racialTraitBox.DataSource = dv;
            racialTraitBox.ValueMember = dv.Table.Columns[1].ToString();
            racialTraitBox.DisplayMember = "raceTrait.raceTrait_id";
            Debug.WriteLine(racialTraitBox.DisplayMember.ToString());

        }

        public void updateDataNow()
        {
            updateRaceCollectionData();
            updateRaceTraitData();
        }

        private System.Data.DataTable dataTable1;
        private System.Windows.Forms.ComboBox raceBox;
        private System.Windows.Forms.BindingSource bi_raceCollection;
    }
}


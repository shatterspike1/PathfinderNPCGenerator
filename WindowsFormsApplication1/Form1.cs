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
using System.Diagnostics;

namespace PathfinderNPCGenerator
{
    public partial class PF : Form
    {
        public PF()
        {
            InitializeComponent();
            updateDataNow();
        }

        private void strengthBox_ValueChanged(object sender, EventArgs e)
        {
            strengthMod.Text = modCalculation(strengthBox);
        }

        private void dexterityBox_ValueChanged(object sender, EventArgs e)
        {
            dexterityMod.Text = modCalculation(dexterityBox);
        }

        private void constitutionBox_ValueChanged(object sender, EventArgs e)
        {
            constitutionMod.Text = modCalculation(constitutionBox);
        }

        private void intelligenceBox_ValueChanged(object sender, EventArgs e)
        {
            intelligenceMod.Text = modCalculation(intelligenceBox);
        }

        private void wisdomBox_ValueChanged(object sender, EventArgs e)
        {
            wisdomMod.Text = modCalculation(wisdomBox);
        }

        private void charismaBox_ValueChanged(object sender, EventArgs e)
        {
            charismaMod.Text = modCalculation(charismaBox);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void raceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //I AM AN IDIOT: MAKE SURE FUNCTIONS ARE HOOKED UP
            Debug.WriteLine("raceBox Changed:");
            Debug.WriteLine(raceBox.SelectedValue.ToString());

            updateRaceTraitData();
            
        }

        private void updateData_Click(object sender, EventArgs e)
        {
            updateDataNow();
        }

        private void alignmentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("alignmentBox Changed:");
        }

        bool racialTraitBox_SelectedIndexChanged_InUse = false;

        private void racialTraitBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!racialTraitBox_SelectedIndexChanged_InUse)
            {
                racialTraitBox_SelectedIndexChanged_InUse = true;
                if (racialTraitBox.SelectedItems != null)
                {
                    for (int i = 0; i < racialTraitBox.SelectedItems.Count; i++)
                    {
                        Debug.WriteLine(((DataRowView)racialTraitBox.SelectedItems[i])[1]); //UGLY
                    }
                }

                DataView dv = raceTraitData.Tables["raceTrait"].DefaultView;
                dv.RowFilter = "raceName = '" + raceBox.SelectedValue.ToString() + "'";

                for (int i = 0; i < racialTraitBox.SelectedItems.Count; i++)
                {
                    string replace = ((DataRowView)(racialTraitBox.SelectedItems[i]))[2].ToString();
                    dv.RowFilter = "replaces <> '" + replace + "'";
                }

                racialTraitBox.DataSource = dv;
                racialTraitBox_SelectedIndexChanged_InUse = false;
            }
        }


    }
}

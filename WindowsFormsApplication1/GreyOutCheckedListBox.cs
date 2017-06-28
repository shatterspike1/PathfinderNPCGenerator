using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathfinderNPCGenerator
{
    class GreyOutCheckedListBox : CheckedListBox
    {
        public List<int> DisabledIndices { get; set; }

        public GreyOutCheckedListBox()
        {
            DisabledIndices = new List<int>();
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            Size checkSize = CheckBoxRenderer.GetGlyphSize(e.Graphics, System.Windows.Forms.VisualStyles.CheckBoxState.MixedNormal);
            int d = (e.Bounds.Height - checkSize.Height) / 2;
            if (DisabledIndices.Contains(e.Index))
            {
                CheckBoxRenderer.DrawCheckBox(e.Graphics, new Point(d, e.Bounds.Top + d), GetItemChecked(e.Index) ? System.Windows.Forms.VisualStyles.CheckBoxState.CheckedDisabled : System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedDisabled);
            }
        }

        protected override void OnItemCheck(ItemCheckEventArgs ice)
        {
            base.OnItemCheck(ice);
            if (DisabledIndices.Contains(ice.Index)) ice.NewValue = ice.CurrentValue;
        }

        public void DisableIndex(int i)
        {
            DisabledIndices.Add(i);
        }

        public void EnableIndex(int i)
        {
            if (DisabledIndices.Contains(i))
            {
                DisabledIndices.Remove(i);
            }
        }

        /* protected override void OnDataSourceChanged(EventArgs e)
        {
            base.OnDataSourceChanged(e);
            ClearDisabledIndicies();
        } */

        private void ClearDisabledIndicies()
        {
            //Warning: can cause unexpected behavior
            DisabledIndices = new List<int>();
        }
    }
}

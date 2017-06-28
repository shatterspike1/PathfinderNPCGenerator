using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathfinderNPCGenerator
{
    class GreyOutListBox : ListBox
    {

        List<int> DisabledIndicies { get; set; }

        public GreyOutListBox()
        {
            DisabledIndicies = new List<int>();

        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThemeParkTycoonGame.Forms.UI.Controls
{
    public partial class DesireLabel : UserControl
    {
        private Desire desire;

        public DesireLabel()
        {
            InitializeComponent();
        }

        public DesireLabel(Desire desire)
            :this()
        {
            this.desire = desire;

            label.Text = string.Format("{0} - {1}", desire.GainedAt, desire.Reason);
        }
    }
}

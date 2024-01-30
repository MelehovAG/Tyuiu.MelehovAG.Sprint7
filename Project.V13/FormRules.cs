using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ComponentFactory.Krypton.Toolkit;

namespace Project.V13
{
    public partial class FormRules : KryptonForm
    {
        public FormRules()
        {
            InitializeComponent();
        }
        private void buttonOK_MAG_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

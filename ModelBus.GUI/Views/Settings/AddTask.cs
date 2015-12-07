using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModBus.GUI
{
    public partial class AddTask : UserControlBase
    {
        public AddTask()
        {
            InitializeComponent();
        }

        private void buttonAddConnection_Click(object sender, EventArgs e)
        {
            switch(new AddConnection().ShowDialog(this))
            {
                case DialogResult.OK:
                    break;
                default:
                case DialogResult.Cancel:
                    break;
            }
        }
    }
}

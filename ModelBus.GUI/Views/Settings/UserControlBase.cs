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
    public partial class UserControlBase : UserControl
    {
        private string _title;
        public UserControlBase()
        {
            InitializeComponent();
        }

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }

        private void LabelTitle_Paint(object sender, PaintEventArgs e)
        {
            var control = sender as Control;
            e.Graphics.DrawTitle(Title, control.Font, control.Size);
        } 
    }
}

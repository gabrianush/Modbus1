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
    public partial class SettingsContainerRight : UserControl
    {
        #region control title properties
        public string AboutTitle { get; set; }
        public string AutoUpdateTitle { get; set; }
        public string AddTaskTitle { get; set; }
        #endregion

        public SettingsContainerRight()
        {
            InitializeComponent();
        }

        private void addTask_Load(object sender, EventArgs e)
        {
            about.Title = AboutTitle;
            autoUpdate.Title = AutoUpdateTitle;
            addTask.Title = AddTaskTitle;
        }

        public void ShowTab(string tabTitle)
        {
            about.Visible = about.Title == tabTitle;
            autoUpdate.Visible = autoUpdate.Title == tabTitle;
            addTask.Visible = addTask.Title == tabTitle;
        }
    }
}

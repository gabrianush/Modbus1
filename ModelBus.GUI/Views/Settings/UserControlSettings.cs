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
    public partial class UserControlSettings : UserControl
    {
        public UserControlSettings()
        {
            InitializeComponent();

            //treeView1.Nodes.AddRange(new[] {
            //    new TreeNode(settingsContainerRight.AboutTitle),
            //    new TreeNode(settingsContainerRight.AutoUpdateTitle),
            //    new TreeNode(settingsContainerRight.AddTaskTitle)
            //});
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            settingsContainerRight.ShowTab(e.Node.Text);
        }

        private void UserControlSettings_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.AddRange(settingsContainerRight.Controls.Cast<UserControlBase>().Select(c => new TreeNode(c.Title)).ToArray());

            //settingsContainerRight.Controls.Cast<UserControlBase>().ToList().ForEach(delegate (UserControlBase ucb) {
            //    treeView1.Nodes.Add(ucb.Title);
            //});
        }
    }
}

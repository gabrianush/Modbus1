namespace ModBus.GUI
{
    partial class SettingsContainerRight
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.about = new ModBus.GUI.About();
            this.autoUpdate = new ModBus.GUI.AutoUpdate();
            this.addTask = new ModBus.GUI.AddTask();
            this.SuspendLayout();
            // 
            // about
            // 
            this.about.Dock = System.Windows.Forms.DockStyle.Fill;
            this.about.Location = new System.Drawing.Point(0, 0);
            this.about.MinimumSize = new System.Drawing.Size(500, 250);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(500, 250);
            this.about.TabIndex = 0;
            this.about.Title = null;
            // 
            // autoUpdate
            // 
            this.autoUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoUpdate.Location = new System.Drawing.Point(0, 0);
            this.autoUpdate.MinimumSize = new System.Drawing.Size(500, 250);
            this.autoUpdate.Name = "autoUpdate";
            this.autoUpdate.Size = new System.Drawing.Size(500, 250);
            this.autoUpdate.TabIndex = 1;
            this.autoUpdate.Title = null;
            // 
            // addTask
            // 
            this.addTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTask.Location = new System.Drawing.Point(0, 0);
            this.addTask.MinimumSize = new System.Drawing.Size(500, 250);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(500, 250);
            this.addTask.TabIndex = 2;
            this.addTask.Title = null;
            this.addTask.Load += new System.EventHandler(this.addTask_Load);
            // 
            // SettingsContainerRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.about);
            this.Controls.Add(this.autoUpdate);
            this.Controls.Add(this.addTask);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "SettingsContainerRight";
            this.Size = new System.Drawing.Size(496, 246);
            this.ResumeLayout(false);

        }

        #endregion

        private AddTask addTask;
        private AutoUpdate autoUpdate;
        private ModBus.GUI.About about;
    }
}

using System.Windows.Forms;
namespace PretpoqueGui
{
    partial class ButtonBinder : Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BellWhistleGroup = new System.Windows.Forms.GroupBox();
            this.AxisGroup = new System.Windows.Forms.FlowLayoutPanel();
            this.StartBindings = new System.Windows.Forms.Button();
            this.ExitConfig = new System.Windows.Forms.Button();
            this.ControllerPoller = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonGroup = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HatGroup = new System.Windows.Forms.FlowLayoutPanel();
            this.BellWhistleGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BellWhistleGroup
            // 
            this.BellWhistleGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BellWhistleGroup.Controls.Add(this.AxisGroup);
            this.BellWhistleGroup.Location = new System.Drawing.Point(12, 12);
            this.BellWhistleGroup.Name = "BellWhistleGroup";
            this.BellWhistleGroup.Size = new System.Drawing.Size(297, 533);
            this.BellWhistleGroup.TabIndex = 1;
            this.BellWhistleGroup.TabStop = false;
            this.BellWhistleGroup.Text = "Axis";
            // 
            // AxisGroup
            // 
            this.AxisGroup.AutoScroll = true;
            this.AxisGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AxisGroup.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.AxisGroup.Location = new System.Drawing.Point(3, 18);
            this.AxisGroup.Name = "AxisGroup";
            this.AxisGroup.Size = new System.Drawing.Size(291, 512);
            this.AxisGroup.TabIndex = 1;
            // 
            // StartBindings
            // 
            this.StartBindings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartBindings.Location = new System.Drawing.Point(776, 551);
            this.StartBindings.Name = "StartBindings";
            this.StartBindings.Size = new System.Drawing.Size(75, 23);
            this.StartBindings.TabIndex = 2;
            this.StartBindings.Text = "Save";
            this.StartBindings.UseVisualStyleBackColor = true;
            this.StartBindings.Click += new System.EventHandler(this.StartBindings_Click);
            // 
            // ExitConfig
            // 
            this.ExitConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitConfig.Location = new System.Drawing.Point(695, 551);
            this.ExitConfig.Name = "ExitConfig";
            this.ExitConfig.Size = new System.Drawing.Size(75, 23);
            this.ExitConfig.TabIndex = 3;
            this.ExitConfig.Text = "Exit";
            this.ExitConfig.UseVisualStyleBackColor = true;
            this.ExitConfig.Click += new System.EventHandler(this.ExitConfig_Click);
            // 
            // ControllerPoller
            // 
            this.ControllerPoller.Tick += new System.EventHandler(this.ControllerPoller_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ButtonGroup);
            this.groupBox1.Location = new System.Drawing.Point(315, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 533);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buttons";
            // 
            // ButtonGroup
            // 
            this.ButtonGroup.AutoScroll = true;
            this.ButtonGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonGroup.Location = new System.Drawing.Point(3, 18);
            this.ButtonGroup.Name = "ButtonGroup";
            this.ButtonGroup.Size = new System.Drawing.Size(259, 512);
            this.ButtonGroup.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.HatGroup);
            this.groupBox2.Location = new System.Drawing.Point(586, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 533);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hats";
            // 
            // HatGroup
            // 
            this.HatGroup.AutoScroll = true;
            this.HatGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HatGroup.Location = new System.Drawing.Point(3, 18);
            this.HatGroup.Name = "HatGroup";
            this.HatGroup.Size = new System.Drawing.Size(259, 512);
            this.HatGroup.TabIndex = 1;
            // 
            // ButtonBinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 586);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExitConfig);
            this.Controls.Add(this.StartBindings);
            this.Controls.Add(this.BellWhistleGroup);
            this.Name = "ButtonBinder";
            this.Text = "ButtonBinder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ButtonBinder_FormClosing);
            this.Load += new System.EventHandler(this.ControllerBinder_Load);
            this.Shown += new System.EventHandler(this.BinderVisible);
            this.BellWhistleGroup.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox BellWhistleGroup;
        private FlowLayoutPanel AxisGroup;
        private Button StartBindings;
        private Button ExitConfig;
        private Timer ControllerPoller;
        private GroupBox groupBox1;
        private FlowLayoutPanel ButtonGroup;
        private GroupBox groupBox2;
        private FlowLayoutPanel HatGroup;

    }
}
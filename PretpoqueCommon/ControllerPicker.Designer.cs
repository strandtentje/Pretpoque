namespace PretpoqueCommon
{
    partial class ControllerPicker
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
            this.ControllerList = new System.Windows.Forms.ListBox();
            this.Explanation = new System.Windows.Forms.TextBox();
            this.AcceptControllerButton = new System.Windows.Forms.Button();
            this.CancelLaunchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GamepadList
            // 
            this.ControllerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ControllerList.FormattingEnabled = true;
            this.ControllerList.ItemHeight = 16;
            this.ControllerList.Location = new System.Drawing.Point(12, 68);
            this.ControllerList.Name = "GamepadList";
            this.ControllerList.Size = new System.Drawing.Size(569, 100);
            this.ControllerList.TabIndex = 0;
            this.ControllerList.SelectedIndexChanged += new System.EventHandler(this.DeviceListMutation);
            this.ControllerList.DoubleClick += new System.EventHandler(this.GamepadChosenFromList);
            // 
            // Explanation
            // 
            this.Explanation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Explanation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Explanation.Location = new System.Drawing.Point(12, 12);
            this.Explanation.Multiline = true;
            this.Explanation.Name = "Explanation";
            this.Explanation.ReadOnly = true;
            this.Explanation.Size = new System.Drawing.Size(569, 50);
            this.Explanation.TabIndex = 1;
            this.Explanation.Text = "Select the Gamepad you\'d like to use for this session";
            // 
            // AcceptJoystickButton
            // 
            this.AcceptControllerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptControllerButton.Enabled = false;
            this.AcceptControllerButton.Location = new System.Drawing.Point(413, 184);
            this.AcceptControllerButton.Name = "AcceptJoystickButton";
            this.AcceptControllerButton.Size = new System.Drawing.Size(168, 23);
            this.AcceptControllerButton.TabIndex = 2;
            this.AcceptControllerButton.Text = "Use Selected Joystick";
            this.AcceptControllerButton.UseVisualStyleBackColor = true;
            this.AcceptControllerButton.Click += new System.EventHandler(this.ControllerChosenByButton);
            // 
            // CancelLaunchButton
            // 
            this.CancelLaunchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelLaunchButton.Location = new System.Drawing.Point(297, 184);
            this.CancelLaunchButton.Name = "CancelLaunchButton";
            this.CancelLaunchButton.Size = new System.Drawing.Size(110, 23);
            this.CancelLaunchButton.TabIndex = 3;
            this.CancelLaunchButton.Text = "Exit Program";
            this.CancelLaunchButton.UseVisualStyleBackColor = true;
            this.CancelLaunchButton.Click += new System.EventHandler(this.CancelLaunchButton_Click);
            // 
            // GamepadPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 219);
            this.Controls.Add(this.CancelLaunchButton);
            this.Controls.Add(this.AcceptControllerButton);
            this.Controls.Add(this.Explanation);
            this.Controls.Add(this.ControllerList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GamepadPicker";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Pick a gamepad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ControllerList;
        private System.Windows.Forms.TextBox Explanation;
        private System.Windows.Forms.Button AcceptControllerButton;
        private System.Windows.Forms.Button CancelLaunchButton;
    }
}
namespace PretpoqueGui
{
    partial class AxisConfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MouseXMult = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MouseYMult = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LowTriggerLevel = new System.Windows.Forms.TrackBar();
            this.LowTriggerKey = new System.Windows.Forms.ComboBox();
            this.LowTriggerOn = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HighTriggerLevel = new System.Windows.Forms.TrackBar();
            this.HighTriggerKey = new System.Windows.Forms.ComboBox();
            this.HighTriggerOn = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.AxisPosition = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MouseXMult)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MouseYMult)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LowTriggerLevel)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HighTriggerLevel)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AxisPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.MouseXMult);
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 50);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mouse X Sensitivity";
            // 
            // MouseXMult
            // 
            this.MouseXMult.Dock = System.Windows.Forms.DockStyle.Top;
            this.MouseXMult.Location = new System.Drawing.Point(3, 18);
            this.MouseXMult.Maximum = 100;
            this.MouseXMult.Minimum = -100;
            this.MouseXMult.Name = "MouseXMult";
            this.MouseXMult.Size = new System.Drawing.Size(199, 56);
            this.MouseXMult.TabIndex = 4;
            this.MouseXMult.TickFrequency = 5;
            this.MouseXMult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ResetTrackbar);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.MouseYMult);
            this.groupBox3.Location = new System.Drawing.Point(12, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 50);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mouse Y Sensitivity";
            // 
            // MouseYMult
            // 
            this.MouseYMult.Dock = System.Windows.Forms.DockStyle.Top;
            this.MouseYMult.Location = new System.Drawing.Point(3, 18);
            this.MouseYMult.Maximum = 100;
            this.MouseYMult.Minimum = -100;
            this.MouseYMult.Name = "MouseYMult";
            this.MouseYMult.Size = new System.Drawing.Size(199, 56);
            this.MouseYMult.TabIndex = 6;
            this.MouseYMult.TickFrequency = 5;
            this.MouseYMult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ResetTrackbar);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.LowTriggerLevel);
            this.groupBox4.Controls.Add(this.LowTriggerKey);
            this.groupBox4.Controls.Add(this.LowTriggerOn);
            this.groupBox4.Location = new System.Drawing.Point(12, 226);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(205, 95);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lower Trigger";
            // 
            // LowTriggerLevel
            // 
            this.LowTriggerLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LowTriggerLevel.Location = new System.Drawing.Point(3, 63);
            this.LowTriggerLevel.Maximum = 100;
            this.LowTriggerLevel.Minimum = -100;
            this.LowTriggerLevel.Name = "LowTriggerLevel";
            this.LowTriggerLevel.Size = new System.Drawing.Size(199, 56);
            this.LowTriggerLevel.TabIndex = 11;
            this.LowTriggerLevel.TickFrequency = 5;
            this.LowTriggerLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ResetTrackbar);
            // 
            // LowTriggerKey
            // 
            this.LowTriggerKey.Dock = System.Windows.Forms.DockStyle.Top;
            this.LowTriggerKey.FormattingEnabled = true;
            this.LowTriggerKey.Location = new System.Drawing.Point(3, 39);
            this.LowTriggerKey.Name = "LowTriggerKey";
            this.LowTriggerKey.Size = new System.Drawing.Size(199, 24);
            this.LowTriggerKey.TabIndex = 12;
            // 
            // LowTriggerOn
            // 
            this.LowTriggerOn.AutoSize = true;
            this.LowTriggerOn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LowTriggerOn.Enabled = false;
            this.LowTriggerOn.Location = new System.Drawing.Point(3, 18);
            this.LowTriggerOn.Name = "LowTriggerOn";
            this.LowTriggerOn.Size = new System.Drawing.Size(199, 21);
            this.LowTriggerOn.TabIndex = 13;
            this.LowTriggerOn.Text = "Active";
            this.LowTriggerOn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.HighTriggerLevel);
            this.groupBox2.Controls.Add(this.HighTriggerKey);
            this.groupBox2.Controls.Add(this.HighTriggerOn);
            this.groupBox2.Location = new System.Drawing.Point(12, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 94);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upper Trigger";
            // 
            // HighTriggerLevel
            // 
            this.HighTriggerLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HighTriggerLevel.Location = new System.Drawing.Point(3, 63);
            this.HighTriggerLevel.Maximum = 100;
            this.HighTriggerLevel.Minimum = -100;
            this.HighTriggerLevel.Name = "HighTriggerLevel";
            this.HighTriggerLevel.Size = new System.Drawing.Size(199, 56);
            this.HighTriggerLevel.TabIndex = 12;
            this.HighTriggerLevel.TickFrequency = 5;
            this.HighTriggerLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ResetTrackbar);
            // 
            // HighTriggerKey
            // 
            this.HighTriggerKey.Dock = System.Windows.Forms.DockStyle.Top;
            this.HighTriggerKey.FormattingEnabled = true;
            this.HighTriggerKey.Location = new System.Drawing.Point(3, 39);
            this.HighTriggerKey.Name = "HighTriggerKey";
            this.HighTriggerKey.Size = new System.Drawing.Size(199, 24);
            this.HighTriggerKey.TabIndex = 13;
            // 
            // HighTriggerOn
            // 
            this.HighTriggerOn.AutoSize = true;
            this.HighTriggerOn.Dock = System.Windows.Forms.DockStyle.Top;
            this.HighTriggerOn.Enabled = false;
            this.HighTriggerOn.Location = new System.Drawing.Point(3, 18);
            this.HighTriggerOn.Name = "HighTriggerOn";
            this.HighTriggerOn.Size = new System.Drawing.Size(199, 21);
            this.HighTriggerOn.TabIndex = 14;
            this.HighTriggerOn.Text = "Active";
            this.HighTriggerOn.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.AxisPosition);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(205, 47);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Position of Axis";
            // 
            // AxisPosition
            // 
            this.AxisPosition.Dock = System.Windows.Forms.DockStyle.Top;
            this.AxisPosition.Enabled = false;
            this.AxisPosition.Location = new System.Drawing.Point(3, 18);
            this.AxisPosition.Maximum = 100;
            this.AxisPosition.Minimum = -100;
            this.AxisPosition.Name = "AxisPosition";
            this.AxisPosition.Size = new System.Drawing.Size(199, 56);
            this.AxisPosition.TabIndex = 1;
            this.AxisPosition.TickFrequency = 5;
            // 
            // AxisConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Name = "AxisConfig";
            this.Size = new System.Drawing.Size(229, 469);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MouseXMult)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MouseYMult)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LowTriggerLevel)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HighTriggerLevel)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AxisPosition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar MouseXMult;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar MouseYMult;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox LowTriggerKey;
        private System.Windows.Forms.TrackBar LowTriggerLevel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox HighTriggerKey;
        private System.Windows.Forms.TrackBar HighTriggerLevel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TrackBar AxisPosition;
        private System.Windows.Forms.CheckBox LowTriggerOn;
        private System.Windows.Forms.CheckBox HighTriggerOn;
    }
}

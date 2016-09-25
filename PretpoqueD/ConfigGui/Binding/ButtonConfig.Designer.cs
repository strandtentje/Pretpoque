namespace PretpoqueD
{
    partial class ButtonConfig
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
            this.ButtonActive = new System.Windows.Forms.CheckBox();
            this.KeybindSelector = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ButtonActive
            // 
            this.ButtonActive.AutoSize = true;
            this.ButtonActive.Location = new System.Drawing.Point(3, 3);
            this.ButtonActive.Name = "ButtonActive";
            this.ButtonActive.Size = new System.Drawing.Size(127, 21);
            this.ButtonActive.TabIndex = 0;
            this.ButtonActive.Text = "Button Pressed";
            this.ButtonActive.UseVisualStyleBackColor = true;
            // 
            // KeybindSelector
            // 
            this.KeybindSelector.FormattingEnabled = true;
            this.KeybindSelector.Location = new System.Drawing.Point(3, 30);
            this.KeybindSelector.Name = "KeybindSelector";
            this.KeybindSelector.Size = new System.Drawing.Size(223, 24);
            this.KeybindSelector.TabIndex = 13;
            // 
            // ButtonConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Size = new System.Drawing.Size(229, 57);
            this.Controls.Add(this.KeybindSelector);
            this.Controls.Add(this.ButtonActive);
            this.Name = "ButtonConfig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ButtonActive;
        private System.Windows.Forms.ComboBox KeybindSelector;
    }
}

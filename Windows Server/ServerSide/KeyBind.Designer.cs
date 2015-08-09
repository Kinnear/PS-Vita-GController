namespace ServerSide
{
    partial class KeyBind
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
            this.saveKeyBindsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveKeyBindsBtn
            // 
            this.saveKeyBindsBtn.Location = new System.Drawing.Point(1016, 518);
            this.saveKeyBindsBtn.Name = "saveKeyBindsBtn";
            this.saveKeyBindsBtn.Size = new System.Drawing.Size(121, 42);
            this.saveKeyBindsBtn.TabIndex = 0;
            this.saveKeyBindsBtn.Text = "Save & Close";
            this.saveKeyBindsBtn.UseVisualStyleBackColor = true;
            this.saveKeyBindsBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // KeyBind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 572);
            this.Controls.Add(this.saveKeyBindsBtn);
            this.Name = "KeyBind";
            this.Text = "KeyBind";
            this.Load += new System.EventHandler(this.KeyBind_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveKeyBindsBtn;
    }
}
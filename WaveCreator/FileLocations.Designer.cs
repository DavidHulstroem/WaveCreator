namespace WaveCreator
{
    partial class FileLocations
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.SaveLoc = new System.Windows.Forms.TextBox();
            this.FindSaveLoc = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StreamLoc = new System.Windows.Forms.TextBox();
            this.FindStreamLoc = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox21
            // 
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox21.Location = new System.Drawing.Point(12, 120);
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.textBox21.Size = new System.Drawing.Size(139, 13);
            this.textBox21.TabIndex = 35;
            this.textBox21.Text = "Save Location";
            // 
            // SaveLoc
            // 
            this.SaveLoc.Location = new System.Drawing.Point(12, 135);
            this.SaveLoc.Name = "SaveLoc";
            this.SaveLoc.Size = new System.Drawing.Size(270, 20);
            this.SaveLoc.TabIndex = 34;
            // 
            // FindSaveLoc
            // 
            this.FindSaveLoc.Location = new System.Drawing.Point(12, 161);
            this.FindSaveLoc.Name = "FindSaveLoc";
            this.FindSaveLoc.Size = new System.Drawing.Size(154, 23);
            this.FindSaveLoc.TabIndex = 33;
            this.FindSaveLoc.Text = "Change Save Location";
            this.FindSaveLoc.UseVisualStyleBackColor = true;
            this.FindSaveLoc.Click += new System.EventHandler(this.FindSaveLoc_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(139, 13);
            this.textBox1.TabIndex = 38;
            this.textBox1.Text = "StreamingAssetsFolder";
            // 
            // StreamLoc
            // 
            this.StreamLoc.Location = new System.Drawing.Point(12, 27);
            this.StreamLoc.Name = "StreamLoc";
            this.StreamLoc.Size = new System.Drawing.Size(270, 20);
            this.StreamLoc.TabIndex = 37;
            // 
            // FindStreamLoc
            // 
            this.FindStreamLoc.Location = new System.Drawing.Point(12, 53);
            this.FindStreamLoc.Name = "FindStreamLoc";
            this.FindStreamLoc.Size = new System.Drawing.Size(154, 23);
            this.FindStreamLoc.TabIndex = 36;
            this.FindStreamLoc.Text = "Find Streaming Assets";
            this.FindStreamLoc.UseVisualStyleBackColor = true;
            this.FindStreamLoc.Click += new System.EventHandler(this.FindStreamLoc_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(306, 251);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(97, 23);
            this.Save.TabIndex = 39;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // FileLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 286);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StreamLoc);
            this.Controls.Add(this.FindStreamLoc);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.SaveLoc);
            this.Controls.Add(this.FindSaveLoc);
            this.Name = "FileLocations";
            this.Text = "FileLocations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.TextBox textBox21;
        public System.Windows.Forms.TextBox SaveLoc;
        private System.Windows.Forms.Button FindSaveLoc;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox StreamLoc;
        private System.Windows.Forms.Button FindStreamLoc;
        private System.Windows.Forms.Button Save;
    }
}
namespace klasa_proces
{
    partial class Form1
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
            this.fExplorer = new System.Windows.Forms.Button();
            this.fExcel = new System.Windows.Forms.Button();
            this.fWord = new System.Windows.Forms.Button();
            this.fInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fExplorer
            // 
            this.fExplorer.Location = new System.Drawing.Point(12, 12);
            this.fExplorer.Name = "fExplorer";
            this.fExplorer.Size = new System.Drawing.Size(127, 56);
            this.fExplorer.TabIndex = 0;
            this.fExplorer.Text = "Internet explorer";
            this.fExplorer.UseVisualStyleBackColor = true;
            this.fExplorer.Click += new System.EventHandler(this.fExplorer_Click);
            // 
            // fExcel
            // 
            this.fExcel.Location = new System.Drawing.Point(168, 12);
            this.fExcel.Name = "fExcel";
            this.fExcel.Size = new System.Drawing.Size(113, 56);
            this.fExcel.TabIndex = 1;
            this.fExcel.Text = "Excel";
            this.fExcel.UseVisualStyleBackColor = true;
            this.fExcel.Click += new System.EventHandler(this.fExcel_Click);
            // 
            // fWord
            // 
            this.fWord.Location = new System.Drawing.Point(12, 91);
            this.fWord.Name = "fWord";
            this.fWord.Size = new System.Drawing.Size(127, 61);
            this.fWord.TabIndex = 2;
            this.fWord.Text = "Word";
            this.fWord.UseVisualStyleBackColor = true;
            this.fWord.Click += new System.EventHandler(this.fWord_Click);
            // 
            // fInfo
            // 
            this.fInfo.Location = new System.Drawing.Point(168, 91);
            this.fInfo.Name = "fInfo";
            this.fInfo.Size = new System.Drawing.Size(113, 61);
            this.fInfo.TabIndex = 3;
            this.fInfo.Text = "Start Info";
            this.fInfo.UseVisualStyleBackColor = true;
            this.fInfo.Click += new System.EventHandler(this.fInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 170);
            this.Controls.Add(this.fInfo);
            this.Controls.Add(this.fWord);
            this.Controls.Add(this.fExcel);
            this.Controls.Add(this.fExplorer);
            this.Name = "Form1";
            this.Text = "Process start";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fExplorer;
        private System.Windows.Forms.Button fExcel;
        private System.Windows.Forms.Button fWord;
        private System.Windows.Forms.Button fInfo;
    }
}


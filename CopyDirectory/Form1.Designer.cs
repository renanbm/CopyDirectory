namespace CopyDirectory
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
            this.btnCopyFiles = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnSource = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnTarget = new System.Windows.Forms.Button();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.log = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCopyFiles
            // 
            this.btnCopyFiles.Location = new System.Drawing.Point(185, 329);
            this.btnCopyFiles.Name = "btnCopyFiles";
            this.btnCopyFiles.Size = new System.Drawing.Size(131, 51);
            this.btnCopyFiles.TabIndex = 0;
            this.btnCopyFiles.Text = "Copy Files";
            this.btnCopyFiles.UseVisualStyleBackColor = true;
            this.btnCopyFiles.Click += new System.EventHandler(this.btnCopyFiles_Click);
            // 
            // txtSource
            // 
            this.txtSource.Enabled = false;
            this.txtSource.Location = new System.Drawing.Point(32, 41);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(258, 20);
            this.txtSource.TabIndex = 1;
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(296, 39);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(138, 23);
            this.btnSource.TabIndex = 2;
            this.btnSource.Text = "Select Source Path";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // btnTarget
            // 
            this.btnTarget.Location = new System.Drawing.Point(296, 74);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(138, 23);
            this.btnTarget.TabIndex = 4;
            this.btnTarget.Text = "Select Target Path";
            this.btnTarget.UseVisualStyleBackColor = true;
            this.btnTarget.Click += new System.EventHandler(this.btnTarget_Click);
            // 
            // txtTarget
            // 
            this.txtTarget.Enabled = false;
            this.txtTarget.Location = new System.Drawing.Point(32, 77);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(258, 20);
            this.txtTarget.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSource);
            this.groupBox1.Controls.Add(this.btnTarget);
            this.groupBox1.Controls.Add(this.btnSource);
            this.groupBox1.Controls.Add(this.txtTarget);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 128);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Path Select";
            // 
            // log
            // 
            this.log.FormattingEnabled = true;
            this.log.Location = new System.Drawing.Point(32, 19);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(402, 121);
            this.log.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.log);
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 155);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 399);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCopyFiles);
            this.Name = "Form1";
            this.Text = "Copy Directory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCopyFiles;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnTarget;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox log;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


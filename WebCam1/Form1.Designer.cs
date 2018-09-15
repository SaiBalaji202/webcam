namespace WebCam1
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
            this.picOutput = new System.Windows.Forms.PictureBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.picStream = new System.Windows.Forms.PictureBox();
            this.btnStreamOnOff = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStream)).BeginInit();
            this.SuspendLayout();
            // 
            // picOutput
            // 
            this.picOutput.Location = new System.Drawing.Point(374, 34);
            this.picOutput.Name = "picOutput";
            this.picOutput.Size = new System.Drawing.Size(157, 163);
            this.picOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOutput.TabIndex = 0;
            this.picOutput.TabStop = false;
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(51, 282);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(130, 23);
            this.btnCapture.TabIndex = 1;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // picStream
            // 
            this.picStream.Location = new System.Drawing.Point(35, 34);
            this.picStream.Name = "picStream";
            this.picStream.Size = new System.Drawing.Size(157, 163);
            this.picStream.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStream.TabIndex = 0;
            this.picStream.TabStop = false;
            // 
            // btnStreamOnOff
            // 
            this.btnStreamOnOff.Location = new System.Drawing.Point(51, 230);
            this.btnStreamOnOff.Name = "btnStreamOnOff";
            this.btnStreamOnOff.Size = new System.Drawing.Size(130, 23);
            this.btnStreamOnOff.TabIndex = 1;
            this.btnStreamOnOff.Text = "Start Streaming";
            this.btnStreamOnOff.UseVisualStyleBackColor = true;
            this.btnStreamOnOff.Click += new System.EventHandler(this.btnStreamOnOff_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(415, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 446);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnStreamOnOff);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.picStream);
            this.Controls.Add(this.picOutput);
            this.Name = "Form1";
            this.Text = "Camera";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStream)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picOutput;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.PictureBox picStream;
        private System.Windows.Forms.Button btnStreamOnOff;
        private System.Windows.Forms.Button btnSave;
    }
}


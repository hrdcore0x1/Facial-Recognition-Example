namespace FacialRecognition
{
    partial class faceRecognition
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
            this.btnGrabber = new System.Windows.Forms.Button();
            this.picWebCam = new System.Windows.Forms.PictureBox();
            this.chkboxDetectFaces = new System.Windows.Forms.CheckBox();
            this.btnTrain = new System.Windows.Forms.Button();
            this.picTraining = new System.Windows.Forms.PictureBox();
            this.lstTraining = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDetect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picWebCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTraining)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGrabber
            // 
            this.btnGrabber.Location = new System.Drawing.Point(418, 34);
            this.btnGrabber.Name = "btnGrabber";
            this.btnGrabber.Size = new System.Drawing.Size(121, 23);
            this.btnGrabber.TabIndex = 0;
            this.btnGrabber.Text = "View Webcam";
            this.btnGrabber.UseVisualStyleBackColor = true;
            this.btnGrabber.Click += new System.EventHandler(this.btnGrabber_Click);
            // 
            // picWebCam
            // 
            this.picWebCam.Location = new System.Drawing.Point(48, 25);
            this.picWebCam.Name = "picWebCam";
            this.picWebCam.Size = new System.Drawing.Size(300, 300);
            this.picWebCam.TabIndex = 1;
            this.picWebCam.TabStop = false;
            // 
            // chkboxDetectFaces
            // 
            this.chkboxDetectFaces.AutoSize = true;
            this.chkboxDetectFaces.Location = new System.Drawing.Point(557, 39);
            this.chkboxDetectFaces.Name = "chkboxDetectFaces";
            this.chkboxDetectFaces.Size = new System.Drawing.Size(87, 17);
            this.chkboxDetectFaces.TabIndex = 2;
            this.chkboxDetectFaces.Text = "Detect faces";
            this.chkboxDetectFaces.UseVisualStyleBackColor = true;
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(418, 63);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(121, 23);
            this.btnTrain.TabIndex = 3;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // picTraining
            // 
            this.picTraining.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTraining.Location = new System.Drawing.Point(418, 92);
            this.picTraining.Name = "picTraining";
            this.picTraining.Size = new System.Drawing.Size(100, 108);
            this.picTraining.TabIndex = 4;
            this.picTraining.TabStop = false;
            // 
            // lstTraining
            // 
            this.lstTraining.FormattingEnabled = true;
            this.lstTraining.Location = new System.Drawing.Point(545, 92);
            this.lstTraining.Name = "lstTraining";
            this.lstTraining.Size = new System.Drawing.Size(120, 108);
            this.lstTraining.TabIndex = 5;
            this.lstTraining.SelectedIndexChanged += new System.EventHandler(this.lstTraining_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(69, 340);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDetect
            // 
            this.btnDetect.Location = new System.Drawing.Point(150, 340);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(99, 23);
            this.btnDetect.TabIndex = 7;
            this.btnDetect.Text = "Detect Faces";
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // faceRecognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 399);
            this.Controls.Add(this.btnDetect);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lstTraining);
            this.Controls.Add(this.picTraining);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.chkboxDetectFaces);
            this.Controls.Add(this.picWebCam);
            this.Controls.Add(this.btnGrabber);
            this.Name = "faceRecognition";
            this.Text = "Facial Recognition";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWebCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTraining)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrabber;
        private System.Windows.Forms.PictureBox picWebCam;
        private System.Windows.Forms.CheckBox chkboxDetectFaces;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.PictureBox picTraining;
        private System.Windows.Forms.ListBox lstTraining;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDetect;
    }
}


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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEpsilon = new System.Windows.Forms.TextBox();
            this.txtScale = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseHAAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCascadeFile = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWebCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTraining)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGrabber
            // 
            this.btnGrabber.Location = new System.Drawing.Point(389, 32);
            this.btnGrabber.Name = "btnGrabber";
            this.btnGrabber.Size = new System.Drawing.Size(121, 23);
            this.btnGrabber.TabIndex = 0;
            this.btnGrabber.Text = "View Webcam";
            this.btnGrabber.UseVisualStyleBackColor = true;
            this.btnGrabber.Click += new System.EventHandler(this.btnGrabber_Click);
            // 
            // picWebCam
            // 
            this.picWebCam.Location = new System.Drawing.Point(24, 46);
            this.picWebCam.Name = "picWebCam";
            this.picWebCam.Size = new System.Drawing.Size(300, 300);
            this.picWebCam.TabIndex = 1;
            this.picWebCam.TabStop = false;
            // 
            // chkboxDetectFaces
            // 
            this.chkboxDetectFaces.AutoSize = true;
            this.chkboxDetectFaces.Location = new System.Drawing.Point(516, 36);
            this.chkboxDetectFaces.Name = "chkboxDetectFaces";
            this.chkboxDetectFaces.Size = new System.Drawing.Size(87, 17);
            this.chkboxDetectFaces.TabIndex = 2;
            this.chkboxDetectFaces.Text = "Detect faces";
            this.chkboxDetectFaces.UseVisualStyleBackColor = true;
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(76, 172);
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
            this.picTraining.Location = new System.Drawing.Point(30, 39);
            this.picTraining.Name = "picTraining";
            this.picTraining.Size = new System.Drawing.Size(100, 108);
            this.picTraining.TabIndex = 4;
            this.picTraining.TabStop = false;
            // 
            // lstTraining
            // 
            this.lstTraining.FormattingEnabled = true;
            this.lstTraining.Location = new System.Drawing.Point(147, 39);
            this.lstTraining.Name = "lstTraining";
            this.lstTraining.Size = new System.Drawing.Size(93, 108);
            this.lstTraining.TabIndex = 5;
            this.lstTraining.SelectedIndexChanged += new System.EventHandler(this.lstTraining_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(389, 61);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(121, 23);
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
            this.btnDetect.Location = new System.Drawing.Point(516, 61);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(101, 23);
            this.btnDetect.TabIndex = 7;
            this.btnDetect.Text = "Detect Faces";
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picTraining);
            this.groupBox1.Controls.Add(this.lstTraining);
            this.groupBox1.Controls.Add(this.btnTrain);
            this.groupBox1.Location = new System.Drawing.Point(347, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 228);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnDetect);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.picWebCam);
            this.groupBox2.Controls.Add(this.chkboxDetectFaces);
            this.groupBox2.Controls.Add(this.btnGrabber);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 498);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Webcam/Pictures";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtEpsilon);
            this.groupBox3.Controls.Add(this.txtScale);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnBrowseHAAR);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtCascadeFile);
            this.groupBox3.Location = new System.Drawing.Point(6, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(617, 125);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Epsilon Criteria";
            // 
            // txtEpsilon
            // 
            this.txtEpsilon.Location = new System.Drawing.Point(166, 87);
            this.txtEpsilon.Name = "txtEpsilon";
            this.txtEpsilon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEpsilon.Size = new System.Drawing.Size(32, 20);
            this.txtEpsilon.TabIndex = 5;
            this.txtEpsilon.Text = "0.001";
            this.txtEpsilon.Leave += new System.EventHandler(this.txtEpsilon_Leave);
            // 
            // txtScale
            // 
            this.txtScale.Location = new System.Drawing.Point(166, 60);
            this.txtScale.Name = "txtScale";
            this.txtScale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtScale.Size = new System.Drawing.Size(32, 20);
            this.txtScale.TabIndex = 4;
            this.txtScale.Text = "1.2";
            this.txtScale.Leave += new System.EventHandler(this.txtScale_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "HAAR Detection Scale";
            // 
            // btnBrowseHAAR
            // 
            this.btnBrowseHAAR.Location = new System.Drawing.Point(390, 33);
            this.btnBrowseHAAR.Name = "btnBrowseHAAR";
            this.btnBrowseHAAR.Size = new System.Drawing.Size(26, 23);
            this.btnBrowseHAAR.TabIndex = 2;
            this.btnBrowseHAAR.Text = "...";
            this.btnBrowseHAAR.UseVisualStyleBackColor = true;
            this.btnBrowseHAAR.Click += new System.EventHandler(this.btnBrowseHAAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "HAAR Cascade File";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCascadeFile
            // 
            this.txtCascadeFile.Location = new System.Drawing.Point(166, 35);
            this.txtCascadeFile.Name = "txtCascadeFile";
            this.txtCascadeFile.Size = new System.Drawing.Size(218, 20);
            this.txtCascadeFile.TabIndex = 0;
            // 
            // faceRecognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 532);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "faceRecognition";
            this.Text = "Facial Recognition";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWebCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTraining)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCascadeFile;
        private System.Windows.Forms.Button btnBrowseHAAR;
        private System.Windows.Forms.TextBox txtScale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEpsilon;
    }
}


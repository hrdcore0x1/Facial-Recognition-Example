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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(faceRecognition));
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
            this.txtMinNeighbors = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEpsilon = new System.Windows.Forms.TextBox();
            this.txtScale = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseHAAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCascadeFile = new System.Windows.Forms.TextBox();
            this.myToolTips = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picWebCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTraining)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGrabber
            // 
            this.btnGrabber.Location = new System.Drawing.Point(351, 217);
            this.btnGrabber.Name = "btnGrabber";
            this.btnGrabber.Size = new System.Drawing.Size(121, 23);
            this.btnGrabber.TabIndex = 0;
            this.btnGrabber.Text = "View Webcam";
            this.myToolTips.SetToolTip(this.btnGrabber, "View input from your webcam.");
            this.btnGrabber.UseVisualStyleBackColor = true;
            this.btnGrabber.Click += new System.EventHandler(this.btnGrabber_Click);
            // 
            // picWebCam
            // 
            this.picWebCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picWebCam.Location = new System.Drawing.Point(6, 19);
            this.picWebCam.Name = "picWebCam";
            this.picWebCam.Size = new System.Drawing.Size(300, 250);
            this.picWebCam.TabIndex = 1;
            this.picWebCam.TabStop = false;
            // 
            // chkboxDetectFaces
            // 
            this.chkboxDetectFaces.AutoSize = true;
            this.chkboxDetectFaces.Location = new System.Drawing.Point(498, 221);
            this.chkboxDetectFaces.Name = "chkboxDetectFaces";
            this.chkboxDetectFaces.Size = new System.Drawing.Size(90, 17);
            this.chkboxDetectFaces.TabIndex = 2;
            this.chkboxDetectFaces.Text = "Detect Faces";
            this.myToolTips.SetToolTip(this.chkboxDetectFaces, "If checked, detected faces will be outlined in the Webcam/Picture box.");
            this.chkboxDetectFaces.UseVisualStyleBackColor = true;
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(74, 145);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(121, 23);
            this.btnTrain.TabIndex = 3;
            this.btnTrain.Text = "Train";
            this.myToolTips.SetToolTip(this.btnTrain, "Click to train the faces currently detected in the Webcam/Pictures box.");
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // picTraining
            // 
            this.picTraining.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTraining.Location = new System.Drawing.Point(31, 39);
            this.picTraining.Name = "picTraining";
            this.picTraining.Size = new System.Drawing.Size(100, 100);
            this.picTraining.TabIndex = 4;
            this.picTraining.TabStop = false;
            // 
            // lstTraining
            // 
            this.lstTraining.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lstTraining.FormattingEnabled = true;
            this.lstTraining.Location = new System.Drawing.Point(147, 39);
            this.lstTraining.Name = "lstTraining";
            this.lstTraining.Size = new System.Drawing.Size(100, 95);
            this.lstTraining.TabIndex = 5;
            this.myToolTips.SetToolTip(this.lstTraining, "This is a list of trained images.  Double click to remove an image.");
            this.lstTraining.SelectedIndexChanged += new System.EventHandler(this.lstTraining_SelectedIndexChanged);
            this.lstTraining.DoubleClick += new System.EventHandler(this.lstTraining_DoubleClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(351, 246);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(121, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load Image";
            this.myToolTips.SetToolTip(this.btnLoad, "Load an image from file.");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDetect
            // 
            this.btnDetect.Location = new System.Drawing.Point(497, 246);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(101, 23);
            this.btnDetect.TabIndex = 7;
            this.btnDetect.Text = "Detect Faces";
            this.myToolTips.SetToolTip(this.btnDetect, "Click to show detected faces in an image loaded from file.");
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picTraining);
            this.groupBox1.Controls.Add(this.lstTraining);
            this.groupBox1.Controls.Add(this.btnTrain);
            this.groupBox1.Location = new System.Drawing.Point(341, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 181);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnDetect);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.chkboxDetectFaces);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.picWebCam);
            this.groupBox2.Controls.Add(this.btnGrabber);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 430);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Webcam/Pictures";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMinNeighbors);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtEpsilon);
            this.groupBox3.Controls.Add(this.txtScale);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnBrowseHAAR);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtCascadeFile);
            this.groupBox3.Location = new System.Drawing.Point(0, 290);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(635, 139);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // txtMinNeighbors
            // 
            this.txtMinNeighbors.Location = new System.Drawing.Point(166, 89);
            this.txtMinNeighbors.Name = "txtMinNeighbors";
            this.txtMinNeighbors.Size = new System.Drawing.Size(32, 20);
            this.txtMinNeighbors.TabIndex = 8;
            this.txtMinNeighbors.Text = "3";
            this.myToolTips.SetToolTip(this.txtMinNeighbors, resources.GetString("txtMinNeighbors.ToolTip"));
            this.txtMinNeighbors.Leave += new System.EventHandler(this.txtMinNeighbors_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "HAAR Min Neighbors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Eigen Epsilon Criteria";
            // 
            // txtEpsilon
            // 
            this.txtEpsilon.Location = new System.Drawing.Point(565, 35);
            this.txtEpsilon.Name = "txtEpsilon";
            this.txtEpsilon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEpsilon.Size = new System.Drawing.Size(32, 20);
            this.txtEpsilon.TabIndex = 5;
            this.txtEpsilon.Text = "0.001";
            this.myToolTips.SetToolTip(this.txtEpsilon, "This value defines the size of difference the algorithm will stop on.");
            this.txtEpsilon.Leave += new System.EventHandler(this.txtEpsilon_Leave);
            // 
            // txtScale
            // 
            this.txtScale.Location = new System.Drawing.Point(166, 60);
            this.txtScale.Name = "txtScale";
            this.txtScale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtScale.Size = new System.Drawing.Size(32, 20);
            this.txtScale.TabIndex = 4;
            this.txtScale.Text = "1.1";
            this.myToolTips.SetToolTip(this.txtScale, "The factor by which the search window is scaled between the subsequent scans, for" +
        " example, 1.1 means increasing window by 10%.");
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
            this.myToolTips.SetToolTip(this.btnBrowseHAAR, "Browse for a HAAR cascade file.");
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
            // 
            // txtCascadeFile
            // 
            this.txtCascadeFile.Location = new System.Drawing.Point(166, 35);
            this.txtCascadeFile.Name = "txtCascadeFile";
            this.txtCascadeFile.Size = new System.Drawing.Size(218, 20);
            this.txtCascadeFile.TabIndex = 0;
            // 
            // myToolTips
            // 
            this.myToolTips.AutoPopDelay = 10000;
            this.myToolTips.InitialDelay = 500;
            this.myToolTips.IsBalloon = true;
            this.myToolTips.ReshowDelay = 100;
            // 
            // faceRecognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 439);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ToolTip myToolTips;
        private System.Windows.Forms.TextBox txtMinNeighbors;
        private System.Windows.Forms.Label label4;
    }
}


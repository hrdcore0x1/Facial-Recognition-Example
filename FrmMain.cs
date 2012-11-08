using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Microsoft.VisualBasic;


/*
 * Author: Cory Nance
 * Professor: Dr. Cook
 * Class: CSCI 7130
 * Date: 7 Novemeber 2012
 * Artificial Intelligence Semester Project - Facial Recognition
 * 
 * REFERENCES:
 * http://www.codeproject.com/Articles/239849/Multiple-face-detection-and-recognition-in-real-ti
 * http://docs.opencv.org/trunk/modules/contrib/doc/facerec/
 * http://code.google.com/p/javacv/source/browse/samples/FaceRecognition.java
 */

namespace FacialRecognition
{
    public partial class faceRecognition : Form
    {
        private Capture grab;
        private HaarCascade face;
        private List<Image<Gray, byte>> trainingImgs;
        private List<string> trainingNames;
        private Image<Bgr, byte> current;
        private string filePath;
        private double scale;
        private double epsilon;
        private int minNeighbors;

        public faceRecognition()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            txtCascadeFile.Text = Application.StartupPath + "\\haarcascade_frontalface_default.xml";
            face = new HaarCascade(txtCascadeFile.Text);
            btnTrain.Enabled = false;
            trainingImgs = new List<Image<Gray, byte>>();
            trainingNames = new List<string>();
            Application.Idle += new EventHandler(FrameGrabber);
            current = null;
            filePath = string.Empty;
            btnDetect.Enabled = false;
            chkboxDetectFaces.Enabled = false;
            scale = Double.Parse(txtScale.Text);
            epsilon = Double.Parse(txtEpsilon.Text);
            minNeighbors = Int32.Parse(txtMinNeighbors.Text);
        }

        private void btnGrabber_Click(object sender, EventArgs e)
        {
            if (btnGrabber.Text == "View Webcam")
            {
                grab = new Capture();
                grab.QueryFrame();
                //btnTrain.Enabled = true;
                btnGrabber.Text = "Stop Webcam";
                btnLoad.Enabled = false;
                btnDetect.Enabled = false;
                btnTrain.Enabled = true;
                chkboxDetectFaces.Enabled = true;
            }
            else if (btnGrabber.Text == "Stop Webcam")
            {
                btnGrabber.Text = "View Webcam";
                //btnTrain.Enabled = false;
                grab.Dispose();
                btnLoad.Enabled = true;
                btnTrain.Enabled = false;
                chkboxDetectFaces.Enabled = false;
            }

        }

        private void FrameGrabber(object sender, EventArgs args)
        {
            if (btnGrabber.Text == "View Webcam") return; 

            current = grab.QueryFrame().Resize(300, 250, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            if (chkboxDetectFaces.Checked == true)
            {
                Image<Gray, byte> grayScale = current.Convert<Gray, byte>();

                MCvAvgComp[][] detected = grayScale.DetectHaarCascade(face, scale, minNeighbors, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
                foreach (MCvAvgComp d in detected[0])
                {
                    current.Draw(d.rect, new Bgr(Color.LawnGreen), 2);
                    if (trainingImgs.Count > 0)
                    {
                        Image<Gray, byte> dFace = current.Copy(d.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                        MCvTermCriteria criteria = new MCvTermCriteria(trainingImgs.Count, epsilon);  //count, epsilon value
                        EigenObjectRecognizer recognize = new EigenObjectRecognizer(trainingImgs.ToArray(), trainingNames.ToArray(), ref criteria);
                        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 1, 1);
                        string name = recognize.Recognize(dFace);
                        current.Draw(name, ref font, new Point(d.rect.X - 2, d.rect.Y - 20), new Bgr(Color.Red));
                    }
                }
            }
            picWebCam.Image = current.ToBitmap();
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            if (btnGrabber.Text == "View Webcam")
            {
                current = new Image<Bgr, byte>(filePath).Resize(300, 250, INTER.CV_INTER_CUBIC);
            }
            else
            {
                current = grab.QueryFrame().Resize(300, 250, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            }
            Image<Gray, byte> train = current.Convert<Gray, byte>();
            MCvAvgComp[][] detected = train.DetectHaarCascade(face, scale, minNeighbors, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));  //20x20 default for faces
            if (detected[0].Length < 1)
            {
                MessageBox.Show("There aren't any faces to train!");
                return;
            }
            foreach (MCvAvgComp d in detected[0])
            {
                train = current.Copy(d.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                picTraining.Image = train.ToBitmap();
                string name = Interaction.InputBox("Please enter a name for this person.", Application.ProductName);

                trainingNames.Add(name);
                lstTraining.Items.Add(name);
                trainingImgs.Add(train);
                lstTraining.SelectedIndex = lstTraining.Items.Count - 1;
            }
        }

        private void lstTraining_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (trainingImgs.Count > 0)
            {
                if (lstTraining.SelectedIndex == -1) lstTraining.SelectedIndex = lstTraining.Items.Count - 1;
                picTraining.Image = trainingImgs[lstTraining.SelectedIndex].ToBitmap();
            }
            else picTraining.Image = null;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result != DialogResult.OK) return;
            filePath = openFileDialog1.FileName;
            btnDetect.Enabled = true;
            btnTrain.Enabled = true;
            current = new Image<Bgr, byte>(filePath).Resize(300, 250, INTER.CV_INTER_CUBIC);
            picWebCam.Image = current.ToBitmap();
        }

        private void lstTraining_DoubleClick(object sender, EventArgs e)
        {
            if (lstTraining.SelectedIndex == -1) return;
            DialogResult result = MessageBox.Show("Are you sure you wish to delete this entry?", "Delete?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int index = lstTraining.SelectedIndex;
                trainingImgs.RemoveAt(index);
                trainingNames.RemoveAt(index);
                if (trainingImgs.Count > 0) lstTraining.SelectedIndex = trainingImgs.Count - 1;
                
                lstTraining.Items.RemoveAt(index);
                
            }
            //else do nothing
        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            current = new Image<Bgr, byte>(filePath).Resize(300, 250, INTER.CV_INTER_CUBIC);
            Image<Gray, byte> grayScale = current.Convert<Gray, byte>();

                MCvAvgComp[][] detected = grayScale.DetectHaarCascade(face, scale, minNeighbors, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
                foreach (MCvAvgComp d in detected[0])
                {
                    current.Draw(d.rect, new Bgr(Color.LawnGreen), 2);
                    if (trainingImgs.Count > 0)
                    {
                        Image<Gray, byte> dFace = current.Copy(d.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                        MCvTermCriteria criteria = new MCvTermCriteria(trainingImgs.Count, epsilon);  //count, epsilon value
                        EigenObjectRecognizer recognize = new EigenObjectRecognizer(trainingImgs.ToArray(), trainingNames.ToArray(), 0, ref criteria);
                        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 1, 1);
                        string name = recognize.Recognize(dFace);
                        current.Draw(name, ref font, new Point(d.rect.X - 2, d.rect.Y - 20), new Bgr(Color.Red));
                    }
                }
            picWebCam.Image = current.ToBitmap();
        }


        private void btnBrowseHAAR_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result != DialogResult.OK) return;
            txtCascadeFile.Text = openFileDialog1.FileName;
            face = new HaarCascade(txtCascadeFile.Text);
        }

        private void txtScale_Leave(object sender, EventArgs e)
        {
            try
            {
                double tmp = Double.Parse(txtScale.Text);
                if (tmp <= 1)
                {
                    throw new Exception("The scale must be greater than 1!");
                }
                scale = tmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtScale.Text = "" + scale;
            }
        }

        private void txtEpsilon_Leave(object sender, EventArgs e)
        {
            try
            {
                double tmp = Double.Parse(txtEpsilon.Text);
                epsilon = tmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtEpsilon.Text = "" + epsilon;
            }
        }


        private void txtMinNeighbors_Leave(object sender, EventArgs e)
        {
            try
            {
                int tmp = Int32.Parse(txtMinNeighbors.Text);
                minNeighbors = tmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtMinNeighbors.Text = "" + minNeighbors;
            }
        }





    }
}

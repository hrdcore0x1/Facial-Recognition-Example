﻿using System;
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

        public faceRecognition()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //face = new HaarCascade("haarcascade_frontalface_default.xml");
            face = new HaarCascade("C:\\Users\\cory.nance\\Downloads\\haarcascade_frontalface_alt.xml");
            btnTrain.Enabled = false;
            trainingImgs = new List<Image<Gray, byte>>();
            trainingNames = new List<string>();
            Application.Idle += new EventHandler(FrameGrabber);
            current = null;
            filePath = string.Empty;
            btnDetect.Enabled = false;
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
            }
            else if (btnGrabber.Text == "Stop Webcam")
            {
                btnGrabber.Text = "View Webcam";
                //btnTrain.Enabled = false;
                grab.Dispose();
                btnLoad.Enabled = true;
                btnTrain.Enabled = false;
            }

        }

        private void FrameGrabber(object sender, EventArgs args)
        {
            if (btnGrabber.Text == "View Webcam") return; 

            current = grab.QueryFrame().Resize(300, 250, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            if (chkboxDetectFaces.Checked == true)
            {

                Image<Gray, byte> grayScale = current.Convert<Gray, byte>();

                MCvAvgComp[][] detected = grayScale.DetectHaarCascade(face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
                foreach (MCvAvgComp d in detected[0])
                {
                    current.Draw(d.rect, new Bgr(Color.LawnGreen), 2);
                    if (trainingImgs.Count > 0)
                    {
                        Image<Gray, byte> dFace = current.Copy(d.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                        MCvTermCriteria criteria = new MCvTermCriteria(trainingImgs.Count, 0.001);  //count, epsilon value
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
            //current = new Image<Bgr, byte>(new Bitmap(picWebCam.Image));
            if (btnGrabber.Text == "View Webcam")
            {
                current = new Image<Bgr, byte>(filePath).Resize(300, 250, INTER.CV_INTER_CUBIC);
            }
            else
            {
                current = grab.QueryFrame().Resize(300, 250, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            }
            Image<Gray, byte> train = current.Convert<Gray, byte>();
            MCvAvgComp[][] detected = train.DetectHaarCascade(face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
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

                /*
                if (trainingNames.Contains(name))
                {
                    MessageBox.Show(name + " already exist in the training database!");
                    picTraining.Image = trainingImgs[lstTraining.SelectedIndex].ToBitmap();
                    return;
                }


                if (trainingImgs.Count > 0)
                {
                    MCvTermCriteria criteria = new MCvTermCriteria(trainingImgs.Count, 0.001);  //count, epsilon value
                    EigenObjectRecognizer recognize = new EigenObjectRecognizer(trainingImgs.ToArray(), trainingNames.ToArray(),0, ref criteria);
                    string result = recognize.Recognize(train);
                    if (!String.IsNullOrEmpty(result))
                    {
                        MessageBox.Show(name + "'s picture already exist in the training database as " + result + "!");
       
                            picTraining.Image = trainingImgs[lstTraining.SelectedIndex].ToBitmap();
                            return;
                    
                    }

                }
                */

                trainingNames.Add(name);
                lstTraining.Items.Add(name);
                trainingImgs.Add(train);
                lstTraining.SelectedIndex = lstTraining.Items.Count - 1;
            }
        }

        private void lstTraining_SelectedIndexChanged(object sender, EventArgs e)
        {
            picTraining.Image = trainingImgs[lstTraining.SelectedIndex].ToBitmap();
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

        private void btnDetect_Click(object sender, EventArgs e)
        {
            current = new Image<Bgr, byte>(filePath).Resize(300, 250, INTER.CV_INTER_CUBIC);
            Image<Gray, byte> grayScale = current.Convert<Gray, byte>();

                MCvAvgComp[][] detected = grayScale.DetectHaarCascade(face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
                foreach (MCvAvgComp d in detected[0])
                {
                    current.Draw(d.rect, new Bgr(Color.LawnGreen), 2);
                    if (trainingImgs.Count > 0)
                    {
                        Image<Gray, byte> dFace = current.Copy(d.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                        MCvTermCriteria criteria = new MCvTermCriteria(trainingImgs.Count, 0.001);  //count, epsilon value
                        EigenObjectRecognizer recognize = new EigenObjectRecognizer(trainingImgs.ToArray(), trainingNames.ToArray(), 0, ref criteria);
                        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 1, 1);
                        string name = recognize.Recognize(dFace);
                        current.Draw(name, ref font, new Point(d.rect.X - 2, d.rect.Y - 20), new Bgr(Color.Red));
                    }
                }
            picWebCam.Image = current.ToBitmap();
        }


    }
}


// Made by JinXiaoMing (2015.01.09)

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;

namespace Face_Gesture_Recogniton
{
    public partial class GestureRecognition : Form
    {
        //Declararation of all variables, vectors and haarcascades
        Capture m_camera;
        Image<Bgr, Byte> m_currentFrame;
        Image<Gray, byte> m_grayCurrentImg, m_resultFaceImg, m_trainedFaceImg = null;

        HaarCascade m_faceCascade;
        MCvFont m_Font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        
        List<Image<Gray, byte>> m_trainingFaceImages = new List<Image<Gray, byte>>();

        List<string> m_trainingFaceNames = new List<string>();
        List<string> m_trainingFaceBirthdays = new List<string>();

        int m_nTrainingFaceCnt, m_nResultFaceIdx;
        string m_strResultFaceName, m_strResultBirthday = null;

        public GestureRecognition()
        {
            InitializeComponent();

            if (!Directory.Exists(Application.StartupPath + "/TrainedData/TrainedFaces"))
                Directory.CreateDirectory(Application.StartupPath + "/TrainedData/TrainedFaces");

            //UI setting
            face_register_btn.Hide();
            face_register_refresh_btn.Hide();

            face_register_group.Enabled = false;
            result_display_group.Enabled = false;

            //Load haarcascades for face detection
            m_faceCascade = new HaarCascade("haarcascade_frontalface_default.xml");

            try
            {
                using (CsvFileReader faceDataReader = new CsvFileReader(Application.StartupPath + "/TrainedData/TrainedFaces/faceData.csv"))
                {
                    CsvRow row = new CsvRow();
                    while (faceDataReader.ReadRow(row))
                    {
                        int rowNum = 0;
                        string strName = "", strBirthday = "";

                        foreach (string subString in row)
                        {
                            switch (rowNum)
                            {
                                case 0:
                                    strName = subString;
                                    break;
                                case 1:
                                    strBirthday = subString;
                                    break;
                            }

                            rowNum++;
                        }

                        m_trainingFaceImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedData/TrainedFaces/" + strName + ".bmp"));
                        m_trainingFaceNames.Add(strName);
                        m_trainingFaceBirthdays.Add(strBirthday);
                    }
                }             

                m_nTrainingFaceCnt = m_trainingFaceNames.Count;
            }
            catch(Exception e)
            {
                MessageBox.Show("Nothing in binary database, please add at least a face", "Trianed faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void resetData()
        {
            m_trainingFaceImages.Clear();
            m_trainingFaceNames.Clear();
            m_trainingFaceBirthdays.Clear();
            m_nTrainingFaceCnt = 0;

            try
            {
                using (CsvFileReader faceDataReader = new CsvFileReader(Application.StartupPath + "/TrainedData/TrainedFaces/faceData.csv"))
                {
                    CsvRow row = new CsvRow();
                    while (faceDataReader.ReadRow(row))
                    {
                        int rowNum = 0;
                        string strName = "", strBirthday = "";

                        foreach (string subString in row)
                        {
                            switch (rowNum)
                            {
                                case 0:
                                    strName = subString;
                                    break;
                                case 1:
                                    strBirthday = subString;
                                    break;
                            }

                            rowNum++;
                        }

                        m_trainingFaceImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedData/TrainedFaces/" + strName + ".bmp"));
                        m_trainingFaceNames.Add(strName);
                        m_trainingFaceBirthdays.Add(strBirthday);
                    }
                }

                m_nTrainingFaceCnt = m_trainingFaceNames.Count;
            }
            catch (Exception e)
            {
                MessageBox.Show("Nothing in binary database, please add at least a face", "Trianed faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void camera_connect_btn_clicked(object sender, EventArgs e)
        {
            //Initialize the capture device
            m_camera = new Capture();
            m_camera.QueryFrame();

            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(FrameGrabber);

            camera_connect_btn.Enabled = false;
            face_register_group.Enabled = true;
            result_display_group.Enabled = true;
        }


        void FrameGrabber(object sender, EventArgs e)
        {
            Image<Bgr, Byte> resultImg = null;

            //Get the current frame form capture device
            m_currentFrame = m_camera.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            m_grayCurrentImg = m_currentFrame.Convert<Gray, Byte>();

            //Face Detector
            MCvAvgComp[][] facesDetected = m_grayCurrentImg.DetectHaarCascade(
            m_faceCascade,
            1.2,
            10,
            Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
            new Size(20, 20));

            //Action for each element detected
            foreach (MCvAvgComp f in facesDetected[0])
            {
                m_resultFaceImg = m_currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //draw the face detected in the 0th (gray) channel with blue color
                m_currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);

                if (m_trainingFaceImages.ToArray().Length != 0)
                {
                    //TermCriteria for face recognition with numbers of trained images like maxIteration
                    MCvTermCriteria termCrit = new MCvTermCriteria(m_nTrainingFaceCnt, 0.001);

                    //Eigen face recognizer
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
                        m_trainingFaceImages.ToArray(),
                        m_trainingFaceNames.ToArray(),
                        3000,
                        ref termCrit);

                    m_strResultFaceName = recognizer.Recognize(m_resultFaceImg);
                    m_nResultFaceIdx = recognizer.GetIndex(m_resultFaceImg);

                    //Draw the label for each face detected and recognized
                    m_currentFrame.Draw(m_strResultFaceName, ref m_Font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.Blue));

                    if (m_nResultFaceIdx >= 0)
                    {
                        FileInfo fileInfo = new FileInfo(Application.StartupPath + "/TrainedData/TrainedFaces/" + m_trainingFaceNames[m_nResultFaceIdx] + ".bmp");
                        if (fileInfo.Exists)
                        {
                            Image img = Image.FromFile(Application.StartupPath + "/TrainedData/TrainedFaces/" + m_trainingFaceNames[m_nResultFaceIdx] + ".bmp");
                            resultImg = new Image<Bgr, byte>((Bitmap)img);
                        }

                        m_strResultBirthday = m_trainingFaceBirthdays[m_nResultFaceIdx];
                    }                    
                }
                break;
            }           

            //Show the faces procesed and recognized
            camera_view.Image = m_currentFrame.ToBitmap();

            if (resultImg != null)
            {
                result_view.Image = resultImg.ToBitmap();
                result_name_lbl.Text = m_strResultFaceName;
                result_birthday_lbl.Text = m_strResultBirthday;
            }

            knowledge_lbl.Text = "face recognizing, gesturing...";
        }


        private void data_setting_btn_Click(object sender, EventArgs e)
        {
            DataSetting pDataSetting = new DataSetting();
            pDataSetting.m_strFaceNames = m_trainingFaceNames;
            pDataSetting.m_strBirthdays = m_trainingFaceBirthdays;
            pDataSetting.DialogSetting();
            pDataSetting.ShowDialog();

            resetData();
        }


        private void face_register_btn_clicked(object sender, System.EventArgs e)
        {
            string strName = face_register_name_textbox.Text;
            string strBirthday = face_register_birthday_picker.Text;

            if (strName == "")
            {
                MessageBox.Show("Please input name!", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (strBirthday == "")
            {
                MessageBox.Show("Please input birthday!", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            m_nTrainingFaceCnt = m_nTrainingFaceCnt + 1;

            //resize face detected image for force to compare the same size with the 
            //test image with cubic interpolation type method            
            m_trainingFaceImages.Add(m_trainedFaceImg);
            m_trainingFaceNames.Add(strName);
            m_trainingFaceBirthdays.Add(strBirthday);

            //save face image            
            m_trainedFaceImg.Save(Application.StartupPath + "/TrainedData/TrainedFaces/" + strName + ".bmp");

            //Write the number of triained faces in a file text for further load
            using (CsvFileWriter faceDataWriter = new CsvFileWriter(Application.StartupPath + "/TrainedData/TrainedFaces/faceData.csv"))
            {
                for (int i = 0; i < m_nTrainingFaceCnt; i++)
                {
                    CsvRow row = new CsvRow();
                    row.Add(m_trainingFaceNames[i]);
                    row.Add(m_trainingFaceBirthdays[i]);
                    faceDataWriter.WriteRow(row);
                }
            }

            MessageBox.Show(face_register_name_textbox.Text + "´s face detected and added", "Training OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            face_register_btn.Hide();
            face_register_refresh_btn.Hide();
            face_register_capture_btn.Show();
            face_register_name_textbox.Text = "face_01";
            face_register_birthday_picker.Text = "1900.01.01";
            face_view.Image = null;
        }
                

        private void face_register_capture_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //Get a gray frame from capture device
                m_grayCurrentImg = m_camera.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //Face Detector
                MCvAvgComp[][] facesDetected = m_grayCurrentImg.DetectHaarCascade(
                m_faceCascade,
                1.2,
                10,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));

                //Action for each element detected
                m_trainedFaceImg = null;
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    m_trainedFaceImg = m_currentFrame.Copy(f.rect).Convert<Gray, byte>();
                    break;
                }

                if (m_trainedFaceImg == null)
                {
                    MessageBox.Show("No exist face", "Capture Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                m_trainedFaceImg = m_resultFaceImg.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                face_view.Image = m_trainedFaceImg.ToBitmap();

                face_register_capture_btn.Hide();
                face_register_btn.Show();
                face_register_refresh_btn.Show();
            }
            catch
            {
                MessageBox.Show("Enable the face detection first", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void face_register_refresh_btn_Click(object sender, EventArgs e)
        {
            m_trainedFaceImg = null;
            face_register_btn.Hide();
            face_register_refresh_btn.Hide();
            face_register_capture_btn.Show();
            face_register_name_textbox.Text = "face_01";
            face_register_birthday_picker.Text = "1900.01.01";
            face_view.Image = null;
        }
    }
}

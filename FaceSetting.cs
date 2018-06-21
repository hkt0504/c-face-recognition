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

namespace Face_Gesture_Recogniton
{
    public partial class FaceSetting : Form
    {
        public List<string> m_strFaceNames, m_strBirthdays;
        public int m_nSelectedIdx;

        private ImageList m_faceImages = new ImageList();
        private Image<Gray, Byte> m_faceImg;

        public FaceSetting()
        {
            InitializeComponent();
        }

        public void DialogSetting()
        {
            name_textbox.Text = m_strFaceNames[m_nSelectedIdx];
            birthday_picker.Text = m_strBirthdays[m_nSelectedIdx];
            m_faceImg = new Image<Gray, byte>(Application.StartupPath + "/TrainedData/TrainedFaces/" + m_strFaceNames[m_nSelectedIdx] + ".bmp");
            face_view.Image = m_faceImg.ToBitmap();
        }

        private void check_btn_Click(object sender, EventArgs e)
        {
            m_strFaceNames.RemoveAt(m_nSelectedIdx);
            m_strFaceNames.Insert(m_nSelectedIdx, name_textbox.Text);
            m_strBirthdays.RemoveAt(m_nSelectedIdx);
            m_strBirthdays.Insert(m_nSelectedIdx, birthday_picker.Text);
            m_faceImg.Save(Application.StartupPath + "/TrainedData/TrainedFaces/" + m_strFaceNames[m_nSelectedIdx] + ".bmp");

            using (CsvFileWriter faceDataWriter = new CsvFileWriter(Application.StartupPath + "/TrainedData/TrainedFaces/faceData.csv"))
            {
                for (int i = 0; i < m_strFaceNames.Count; i++)
                {
                    CsvRow row = new CsvRow();
                    row.Add(m_strFaceNames[i]);
                    row.Add(m_strBirthdays[i]);
                    faceDataWriter.WriteRow(row);
                }
            }
            this.Hide();
        }
    }
}

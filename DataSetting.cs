using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Face_Gesture_Recogniton
{
    public partial class DataSetting : Form
    {
        public List<string> m_strFaceNames, m_strGestureNames, m_strBirthdays, m_strWavingGestureNames, m_strWavingGestureEvents;
        public List<List<string>> m_strWavingGestureParts;
        private ImageList m_faceImages = new ImageList();
        private ImageList m_gestureImages = new ImageList();
        private ImageList m_wavingGestureImages = new ImageList();
        private int m_nFaceIdx = -1, m_nWavingGestureIdx = -1;

        public DataSetting()
        {
            InitializeComponent();
        }

        public void DialogSetting()
        {
            // loading face datas
            for (int i = 0; i < m_strFaceNames.Count; i++)
            {
                try
                {
                    Bitmap bitmap = (Bitmap)Image.FromFile(Application.StartupPath + "/TrainedData/TrainedFaces/" + m_strFaceNames[i] + ".bmp");
                    m_faceImages.Images.Add(bitmap);
                }
                catch
                {
                    Console.WriteLine("This is not an image file");
                }
            }

            face_list.View = View.LargeIcon;
            m_faceImages.ImageSize = new Size(32, 32);
            face_list.LargeImageList = m_faceImages;

            for (int i = 0; i < m_strFaceNames.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = m_strFaceNames[i];
                face_list.Items.Add(item);
            }

            if (face_list.Items.Count <= 0)
            {
                face_edit_btn.Enabled = false;
                face_delete_btn.Enabled = false;
            }

            // loading gesture datas
            for (int i = 0; i < m_strGestureNames.Count; i++)
            {
                try
                {
                    Bitmap bitmap = (Bitmap)Image.FromFile(Application.StartupPath + "/TrainedData/TrainedGestures/" + m_strGestureNames[i] + ".bmp");
                    m_gestureImages.Images.Add(bitmap);
                }
                catch
                {
                    Console.WriteLine("This is not an image file");
                }
            }

            gesture_list.View = View.LargeIcon;
            m_gestureImages.ImageSize = new Size(32, 32);
            gesture_list.LargeImageList = m_gestureImages;

            for (int i = 0; i < m_strGestureNames.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = m_strGestureNames[i];
                gesture_list.Items.Add(item);
            }

            // loading waving gesture datas
            for (int i = 0; i < m_strWavingGestureNames.Count; i++)
            {
                try
                {
                    Bitmap bitmap = (Bitmap)Image.FromFile(Application.StartupPath + "/TrainedData/TrainedGestures/" + m_strWavingGestureParts[i][0] + ".bmp");
                    m_wavingGestureImages.Images.Add(bitmap);
                }
                catch
                {
                    Console.WriteLine("This is not an image file");
                }
            }

            waving_gesture_list.View = View.LargeIcon;
            m_wavingGestureImages.ImageSize = new Size(32, 32);
            waving_gesture_list.LargeImageList = m_gestureImages;

            for (int i = 0; i < m_strWavingGestureNames.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = m_strWavingGestureNames[i];
                waving_gesture_list.Items.Add(item);
            }

            if (waving_gesture_list.Items.Count <= 0)
            {
                gesture_edit_btn.Enabled = false;
                gesture_delete_btn.Enabled = false;
            }
        }

        private void face_edit_btn_Click(object sender, EventArgs e)
        {
            if (m_nFaceIdx < 0)
            {
                MessageBox.Show("Please select face!", "Selected Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                FaceSetting pFaceSetting = new FaceSetting();
                pFaceSetting.m_nSelectedIdx = m_nFaceIdx;
                pFaceSetting.m_strFaceNames = m_strFaceNames;
                pFaceSetting.m_strBirthdays = m_strBirthdays;
                pFaceSetting.DialogSetting();
                pFaceSetting.ShowDialog();

                m_strFaceNames.Clear();
                m_strBirthdays.Clear();
                m_faceImages.Images.Clear();
                face_list.Clear();

                CsvFileReader faceDataReader = new CsvFileReader(Application.StartupPath + "/TrainedData/TrainedFaces/faceData.csv");
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

                    m_strFaceNames.Add(strName);
                    m_strBirthdays.Add(strBirthday);
                }

                for (int i = 0; i < m_strFaceNames.Count; i++)
                {
                    try
                    {
                        Bitmap bitmap = (Bitmap)Image.FromFile(Application.StartupPath + "/TrainedData/TrainedFaces/" + m_strFaceNames[i] + ".bmp");
                        m_faceImages.Images.Add(bitmap);
                    }
                    catch
                    {
                        Console.WriteLine("This is not an image file");
                    }
                }

                face_list.View = View.LargeIcon;
                m_faceImages.ImageSize = new Size(32, 32);
                face_list.LargeImageList = m_faceImages;

                for (int i = 0; i < m_strFaceNames.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = i;
                    item.Text = m_strFaceNames[i];
                    face_list.Items.Add(item);
                }
            }
        }

        private void face_delete_btn_Click(object sender, EventArgs e)
        {
            if (m_nFaceIdx < 0)
            {
                MessageBox.Show("Please select face!", "Selected Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                m_strFaceNames.RemoveAt(m_nFaceIdx);
                m_strBirthdays.RemoveAt(m_nFaceIdx);

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

                face_list.Clear();
                m_faceImages.Images.Clear();

                for (int i = 0; i < m_strFaceNames.Count; i++)
                {
                    try
                    {
                        Bitmap bitmap = (Bitmap)Image.FromFile(Application.StartupPath + "/TrainedData/TrainedFaces/" + m_strFaceNames[i] + ".bmp");
                        m_faceImages.Images.Add(bitmap);
                    }
                    catch
                    {
                        Console.WriteLine("This is not an image file");
                    }
                }

                face_list.View = View.LargeIcon;
                m_faceImages.ImageSize = new Size(32, 32);
                face_list.LargeImageList = m_faceImages;

                for (int i = 0; i < m_strFaceNames.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = i;
                    item.Text = m_strFaceNames[i];
                    face_list.Items.Add(item);
                }

                MessageBox.Show("Delete completed!", "Selected Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void face_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_nFaceIdx = face_list.FocusedItem.Index;
        }

        private void gesture_edit_btn_Click(object sender, EventArgs e)
        {
        }

        private void gesture_delete_btn_Click(object sender, EventArgs e)
        {
            if (m_nWavingGestureIdx < 0)
            {
                MessageBox.Show("Please select waving gesture!", "Selected Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                m_strWavingGestureNames.RemoveAt(m_nWavingGestureIdx);
                m_strWavingGestureEvents.RemoveAt(m_nWavingGestureIdx);
                m_strWavingGestureParts.RemoveAt(m_nWavingGestureIdx);

                using (CsvFileWriter wavingGestureDataWriter = new CsvFileWriter(Application.StartupPath + "/TrainedData/WavingGestures/WavingGestures.csv"))
                {
                    for (int i = 0; i < m_strWavingGestureNames.Count; i++)
                    {
                        CsvRow row = new CsvRow();
                        row.Add(m_strWavingGestureNames[i]);
                        row.Add(m_strWavingGestureParts[i][0]);
                        row.Add(m_strWavingGestureParts[i][1]);
                        row.Add(m_strWavingGestureParts[i][2]);
                        row.Add(m_strWavingGestureEvents[i]);
                        wavingGestureDataWriter.WriteRow(row);
                    }
                }

                waving_gesture_list.Clear();
                m_wavingGestureImages.Images.Clear();

                for (int i = 0; i < m_strWavingGestureNames.Count; i++)
                {
                    try
                    {
                        Bitmap bitmap = (Bitmap)Image.FromFile(Application.StartupPath + "/TrainedData/TrainedGestures/" + m_strWavingGestureParts[i][0] + ".bmp");
                        m_wavingGestureImages.Images.Add(bitmap);
                    }
                    catch
                    {
                        Console.WriteLine("This is not an image file");
                    }
                }

                waving_gesture_list.View = View.LargeIcon;
                m_wavingGestureImages.ImageSize = new Size(32, 32);
                waving_gesture_list.LargeImageList = m_gestureImages;

                for (int i = 0; i < m_strWavingGestureNames.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = i;
                    item.Text = m_strWavingGestureNames[i];
                    waving_gesture_list.Items.Add(item);
                }

                if (waving_gesture_list.Items.Count <= 0)
                {
                    gesture_edit_btn.Enabled = false;
                    gesture_delete_btn.Enabled = false;
                }

                MessageBox.Show("Delete completed!", "Selected Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void waving_gesture_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_nWavingGestureIdx = waving_gesture_list.FocusedItem.Index;
        }
    }
}

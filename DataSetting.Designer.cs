namespace Face_Gesture_Recogniton
{
    partial class DataSetting
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
            this.face_list = new System.Windows.Forms.ListView();
            this.gesture_list = new System.Windows.Forms.ListView();
            this.face_delete_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.face_edit_btn = new System.Windows.Forms.Button();
            this.waving_gesture_list = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.gesture_delete_btn = new System.Windows.Forms.Button();
            this.gesture_edit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // face_list
            // 
            this.face_list.Location = new System.Drawing.Point(10, 36);
            this.face_list.Name = "face_list";
            this.face_list.Size = new System.Drawing.Size(336, 325);
            this.face_list.TabIndex = 0;
            this.face_list.UseCompatibleStateImageBehavior = false;
            this.face_list.SelectedIndexChanged += new System.EventHandler(this.face_list_SelectedIndexChanged);
            // 
            // gesture_list
            // 
            this.gesture_list.Location = new System.Drawing.Point(352, 36);
            this.gesture_list.Name = "gesture_list";
            this.gesture_list.Size = new System.Drawing.Size(336, 325);
            this.gesture_list.TabIndex = 1;
            this.gesture_list.UseCompatibleStateImageBehavior = false;
            // 
            // face_delete_btn
            // 
            this.face_delete_btn.BackgroundImage = global::Face_Gesture_Recogniton.Properties.Resources.delete;
            this.face_delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.face_delete_btn.Location = new System.Drawing.Point(316, 4);
            this.face_delete_btn.Name = "face_delete_btn";
            this.face_delete_btn.Size = new System.Drawing.Size(30, 30);
            this.face_delete_btn.TabIndex = 3;
            this.face_delete_btn.UseVisualStyleBackColor = true;
            this.face_delete_btn.Click += new System.EventHandler(this.face_delete_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Face Train Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Part Gesture Train Data";
            // 
            // face_edit_btn
            // 
            this.face_edit_btn.BackgroundImage = global::Face_Gesture_Recogniton.Properties.Resources.edit;
            this.face_edit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.face_edit_btn.Location = new System.Drawing.Point(266, 4);
            this.face_edit_btn.Name = "face_edit_btn";
            this.face_edit_btn.Size = new System.Drawing.Size(30, 30);
            this.face_edit_btn.TabIndex = 2;
            this.face_edit_btn.UseVisualStyleBackColor = true;
            this.face_edit_btn.Click += new System.EventHandler(this.face_edit_btn_Click);
            // 
            // waving_gesture_list
            // 
            this.waving_gesture_list.Location = new System.Drawing.Point(694, 36);
            this.waving_gesture_list.Name = "waving_gesture_list";
            this.waving_gesture_list.Size = new System.Drawing.Size(336, 325);
            this.waving_gesture_list.TabIndex = 8;
            this.waving_gesture_list.UseCompatibleStateImageBehavior = false;
            this.waving_gesture_list.SelectedIndexChanged += new System.EventHandler(this.waving_gesture_list_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(695, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Waving Gesture Train Data";
            // 
            // gesture_delete_btn
            // 
            this.gesture_delete_btn.BackgroundImage = global::Face_Gesture_Recogniton.Properties.Resources.delete;
            this.gesture_delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gesture_delete_btn.Location = new System.Drawing.Point(995, 4);
            this.gesture_delete_btn.Name = "gesture_delete_btn";
            this.gesture_delete_btn.Size = new System.Drawing.Size(30, 30);
            this.gesture_delete_btn.TabIndex = 11;
            this.gesture_delete_btn.UseVisualStyleBackColor = true;
            this.gesture_delete_btn.Click += new System.EventHandler(this.gesture_delete_btn_Click);
            // 
            // gesture_edit_btn
            // 
            this.gesture_edit_btn.BackgroundImage = global::Face_Gesture_Recogniton.Properties.Resources.edit;
            this.gesture_edit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gesture_edit_btn.Location = new System.Drawing.Point(945, 4);
            this.gesture_edit_btn.Name = "gesture_edit_btn";
            this.gesture_edit_btn.Size = new System.Drawing.Size(30, 30);
            this.gesture_edit_btn.TabIndex = 10;
            this.gesture_edit_btn.UseVisualStyleBackColor = true;
            this.gesture_edit_btn.Click += new System.EventHandler(this.gesture_edit_btn_Click);
            // 
            // DataSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 372);
            this.Controls.Add(this.gesture_delete_btn);
            this.Controls.Add(this.gesture_edit_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.waving_gesture_list);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.face_delete_btn);
            this.Controls.Add(this.face_edit_btn);
            this.Controls.Add(this.gesture_list);
            this.Controls.Add(this.face_list);
            this.Name = "DataSetting";
            this.Text = "DataSetting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView face_list;
        private System.Windows.Forms.ListView gesture_list;
        private System.Windows.Forms.Button face_edit_btn;
        private System.Windows.Forms.Button face_delete_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView waving_gesture_list;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button gesture_delete_btn;
        private System.Windows.Forms.Button gesture_edit_btn;
    }
}
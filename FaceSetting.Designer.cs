namespace Face_Gesture_Recogniton
{
    partial class FaceSetting
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
            this.name = new System.Windows.Forms.Label();
            this.birthday_picker = new System.Windows.Forms.DateTimePicker();
            this.check_btn = new System.Windows.Forms.Button();
            this.face_view = new System.Windows.Forms.PictureBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.face_view)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(129, 23);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            // 
            // birthday_picker
            // 
            this.birthday_picker.Location = new System.Drawing.Point(132, 56);
            this.birthday_picker.Name = "birthday_picker";
            this.birthday_picker.Size = new System.Drawing.Size(200, 20);
            this.birthday_picker.TabIndex = 4;
            // 
            // check_btn
            // 
            this.check_btn.Location = new System.Drawing.Point(255, 91);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(75, 23);
            this.check_btn.TabIndex = 5;
            this.check_btn.Text = "confirm";
            this.check_btn.UseVisualStyleBackColor = true;
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
            // 
            // face_view
            // 
            this.face_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.face_view.Location = new System.Drawing.Point(13, 11);
            this.face_view.Name = "face_view";
            this.face_view.Size = new System.Drawing.Size(100, 100);
            this.face_view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.face_view.TabIndex = 0;
            this.face_view.TabStop = false;
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(185, 20);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(145, 20);
            this.name_textbox.TabIndex = 6;
            // 
            // FaceSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 122);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.check_btn);
            this.Controls.Add(this.birthday_picker);
            this.Controls.Add(this.name);
            this.Controls.Add(this.face_view);
            this.MaximumSize = new System.Drawing.Size(360, 160);
            this.MinimumSize = new System.Drawing.Size(360, 160);
            this.Name = "FaceSetting";
            this.Text = "FaceSetting";
            ((System.ComponentModel.ISupportInitialize)(this.face_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox face_view;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.DateTimePicker birthday_picker;
        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.TextBox name_textbox;
    }
}
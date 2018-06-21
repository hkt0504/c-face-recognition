namespace Face_Gesture_Recogniton
{
    partial class GestureRecognition
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.face_register_name_textbox = new System.Windows.Forms.TextBox();
            this.face_register_group = new System.Windows.Forms.GroupBox();
            this.face_register_birthday_picker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.face_register_capture_btn = new System.Windows.Forms.Button();
            this.face_register_refresh_btn = new System.Windows.Forms.Button();
            this.face_view = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.face_register_btn = new System.Windows.Forms.Button();
            this.result_display_group = new System.Windows.Forms.GroupBox();
            this.result_birthday_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.result_event_lbl = new System.Windows.Forms.Label();
            this.result_view = new System.Windows.Forms.PictureBox();
            this.result_name_lbl = new System.Windows.Forms.Label();
            this.knowledge_lbl = new System.Windows.Forms.Label();
            this.camera_view = new System.Windows.Forms.PictureBox();
            this.camera_connect_btn = new System.Windows.Forms.Button();
            this.face_register_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.face_view)).BeginInit();
            this.result_display_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.result_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camera_view)).BeginInit();
            this.SuspendLayout();
            // 
            // face_register_name_textbox
            // 
            this.face_register_name_textbox.Location = new System.Drawing.Point(174, 18);
            this.face_register_name_textbox.Name = "face_register_name_textbox";
            this.face_register_name_textbox.Size = new System.Drawing.Size(171, 21);
            this.face_register_name_textbox.TabIndex = 7;
            this.face_register_name_textbox.Text = "face_01";
            // 
            // face_register_group
            // 
            this.face_register_group.Controls.Add(this.face_register_birthday_picker);
            this.face_register_group.Controls.Add(this.label4);
            this.face_register_group.Controls.Add(this.face_register_capture_btn);
            this.face_register_group.Controls.Add(this.face_register_refresh_btn);
            this.face_register_group.Controls.Add(this.face_view);
            this.face_register_group.Controls.Add(this.label1);
            this.face_register_group.Controls.Add(this.face_register_name_textbox);
            this.face_register_group.Controls.Add(this.face_register_btn);
            this.face_register_group.Location = new System.Drawing.Point(615, 194);
            this.face_register_group.Name = "face_register_group";
            this.face_register_group.Size = new System.Drawing.Size(353, 124);
            this.face_register_group.TabIndex = 8;
            this.face_register_group.TabStop = false;
            this.face_register_group.Text = "Face Register";
            // 
            // face_register_birthday_picker
            // 
            this.face_register_birthday_picker.Location = new System.Drawing.Point(174, 48);
            this.face_register_birthday_picker.Name = "face_register_birthday_picker";
            this.face_register_birthday_picker.Size = new System.Drawing.Size(171, 21);
            this.face_register_birthday_picker.TabIndex = 17;
            this.face_register_birthday_picker.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "Birthday:";
            // 
            // face_register_capture_btn
            // 
            this.face_register_capture_btn.BackgroundImage = global::Face_Gesture_Recogniton.Properties.Resources.capture;
            this.face_register_capture_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.face_register_capture_btn.Location = new System.Drawing.Point(304, 80);
            this.face_register_capture_btn.Name = "face_register_capture_btn";
            this.face_register_capture_btn.Size = new System.Drawing.Size(30, 28);
            this.face_register_capture_btn.TabIndex = 11;
            this.face_register_capture_btn.UseVisualStyleBackColor = true;
            this.face_register_capture_btn.Click += new System.EventHandler(this.face_register_capture_btn_Click);
            // 
            // face_register_refresh_btn
            // 
            this.face_register_refresh_btn.BackgroundImage = global::Face_Gesture_Recogniton.Properties.Resources.refresh;
            this.face_register_refresh_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.face_register_refresh_btn.Location = new System.Drawing.Point(303, 80);
            this.face_register_refresh_btn.Name = "face_register_refresh_btn";
            this.face_register_refresh_btn.Size = new System.Drawing.Size(30, 28);
            this.face_register_refresh_btn.TabIndex = 10;
            this.face_register_refresh_btn.UseVisualStyleBackColor = true;
            this.face_register_refresh_btn.Click += new System.EventHandler(this.face_register_refresh_btn_Click);
            // 
            // face_view
            // 
            this.face_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.face_view.Location = new System.Drawing.Point(7, 18);
            this.face_view.Name = "face_view";
            this.face_view.Size = new System.Drawing.Size(100, 92);
            this.face_view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.face_view.TabIndex = 9;
            this.face_view.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name: ";
            // 
            // face_register_btn
            // 
            this.face_register_btn.BackgroundImage = global::Face_Gesture_Recogniton.Properties.Resources.check;
            this.face_register_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.face_register_btn.Location = new System.Drawing.Point(254, 80);
            this.face_register_btn.Name = "face_register_btn";
            this.face_register_btn.Size = new System.Drawing.Size(30, 28);
            this.face_register_btn.TabIndex = 2;
            this.face_register_btn.UseVisualStyleBackColor = true;
            this.face_register_btn.Click += new System.EventHandler(this.face_register_btn_clicked);
            // 
            // result_display_group
            // 
            this.result_display_group.Controls.Add(this.result_birthday_lbl);
            this.result_display_group.Controls.Add(this.label6);
            this.result_display_group.Controls.Add(this.result_event_lbl);
            this.result_display_group.Controls.Add(this.result_view);
            this.result_display_group.Controls.Add(this.result_name_lbl);
            this.result_display_group.Location = new System.Drawing.Point(615, 330);
            this.result_display_group.Name = "result_display_group";
            this.result_display_group.Size = new System.Drawing.Size(353, 125);
            this.result_display_group.TabIndex = 9;
            this.result_display_group.TabStop = false;
            this.result_display_group.Text = "Results: ";
            // 
            // result_birthday_lbl
            // 
            this.result_birthday_lbl.AutoSize = true;
            this.result_birthday_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_birthday_lbl.ForeColor = System.Drawing.Color.Blue;
            this.result_birthday_lbl.Location = new System.Drawing.Point(123, 55);
            this.result_birthday_lbl.Name = "result_birthday_lbl";
            this.result_birthday_lbl.Size = new System.Drawing.Size(105, 19);
            this.result_birthday_lbl.TabIndex = 24;
            this.result_birthday_lbl.Text = "XXXX.XX.XX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(124, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Event : ";
            // 
            // result_event_lbl
            // 
            this.result_event_lbl.AutoSize = true;
            this.result_event_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_event_lbl.ForeColor = System.Drawing.Color.Blue;
            this.result_event_lbl.Location = new System.Drawing.Point(201, 90);
            this.result_event_lbl.Name = "result_event_lbl";
            this.result_event_lbl.Size = new System.Drawing.Size(72, 19);
            this.result_event_lbl.TabIndex = 22;
            this.result_event_lbl.Text = "No Event";
            // 
            // result_view
            // 
            this.result_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_view.Location = new System.Drawing.Point(7, 18);
            this.result_view.Name = "result_view";
            this.result_view.Size = new System.Drawing.Size(100, 92);
            this.result_view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.result_view.TabIndex = 18;
            this.result_view.TabStop = false;
            // 
            // result_name_lbl
            // 
            this.result_name_lbl.AutoSize = true;
            this.result_name_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_name_lbl.ForeColor = System.Drawing.Color.Blue;
            this.result_name_lbl.Location = new System.Drawing.Point(123, 18);
            this.result_name_lbl.Name = "result_name_lbl";
            this.result_name_lbl.Size = new System.Drawing.Size(61, 19);
            this.result_name_lbl.TabIndex = 16;
            this.result_name_lbl.Text = "Nobody";
            // 
            // knowledge_lbl
            // 
            this.knowledge_lbl.AutoSize = true;
            this.knowledge_lbl.Location = new System.Drawing.Point(18, 462);
            this.knowledge_lbl.Name = "knowledge_lbl";
            this.knowledge_lbl.Size = new System.Drawing.Size(137, 12);
            this.knowledge_lbl.TabIndex = 17;
            this.knowledge_lbl.Text = "Please connect camera.";
            // 
            // camera_view
            // 
            this.camera_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.camera_view.Cursor = System.Windows.Forms.Cursors.No;
            this.camera_view.Location = new System.Drawing.Point(13, 12);
            this.camera_view.Name = "camera_view";
            this.camera_view.Size = new System.Drawing.Size(589, 445);
            this.camera_view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.camera_view.TabIndex = 10;
            this.camera_view.TabStop = false;
            // 
            // camera_connect_btn
            // 
            this.camera_connect_btn.BackgroundImage = global::Face_Gesture_Recogniton.Properties.Resources.power;
            this.camera_connect_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.camera_connect_btn.Location = new System.Drawing.Point(728, 12);
            this.camera_connect_btn.Name = "camera_connect_btn";
            this.camera_connect_btn.Size = new System.Drawing.Size(157, 150);
            this.camera_connect_btn.TabIndex = 13;
            this.camera_connect_btn.UseVisualStyleBackColor = true;
            this.camera_connect_btn.Click += new System.EventHandler(this.camera_connect_btn_clicked);
            // 
            // GestureRecognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 481);
            this.Controls.Add(this.knowledge_lbl);
            this.Controls.Add(this.camera_view);
            this.Controls.Add(this.result_display_group);
            this.Controls.Add(this.face_register_group);
            this.Controls.Add(this.camera_connect_btn);
            this.MaximumSize = new System.Drawing.Size(1135, 520);
            this.Name = "GestureRecognition";
            this.Text = "Face & Gesture Recognition";
            this.face_register_group.ResumeLayout(false);
            this.face_register_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.face_view)).EndInit();
            this.result_display_group.ResumeLayout(false);
            this.result_display_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.result_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camera_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button face_register_btn;
        private System.Windows.Forms.TextBox face_register_name_textbox;
        private System.Windows.Forms.GroupBox face_register_group;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox result_display_group;
        private System.Windows.Forms.Label result_name_lbl;
        private System.Windows.Forms.Button camera_connect_btn;
        private System.Windows.Forms.PictureBox camera_view;
        private System.Windows.Forms.PictureBox face_view;
        private System.Windows.Forms.PictureBox result_view;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label result_event_lbl;
        private System.Windows.Forms.Button face_register_capture_btn;
        private System.Windows.Forms.Button face_register_refresh_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label result_birthday_lbl;
        private System.Windows.Forms.DateTimePicker face_register_birthday_picker;
        private System.Windows.Forms.Label knowledge_lbl;
    }
}


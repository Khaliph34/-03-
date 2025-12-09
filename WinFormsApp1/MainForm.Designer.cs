namespace WinFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxEmail = new TextBox();
            textBoxSubject = new TextBox();
            textBoxName = new TextBox();
            textBoxBody = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            buttonSend = new Button();
            SuspendLayout();
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(193, 128);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(254, 23);
            textBoxEmail.TabIndex = 0;
            // 
            // textBoxSubject
            // 
            textBoxSubject.Location = new Point(193, 173);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(471, 23);
            textBoxSubject.TabIndex = 1;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(490, 128);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(174, 23);
            textBoxName.TabIndex = 2;
            // 
            // textBoxBody
            // 
            textBoxBody.Location = new Point(122, 251);
            textBoxBody.Multiline = true;
            textBoxBody.Name = "textBoxBody";
            textBoxBody.Size = new Size(542, 127);
            textBoxBody.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 131);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 4;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 173);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 5;
            label2.Text = "Заговолок";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 219);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 6;
            label3.Text = "Текст";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 131);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 7;
            label4.Text = "Имя";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(334, 44);
            label5.Name = "label5";
            label5.Size = new Size(150, 15);
            label5.TabIndex = 8;
            label5.Text = "Отправление email писем";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(122, 89);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 9;
            label6.Text = "Кому";
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(268, 384);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(242, 23);
            buttonSend.TabIndex = 10;
            buttonSend.Text = "Отправить";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSend);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxBody);
            Controls.Add(textBoxName);
            Controls.Add(textBoxSubject);
            Controls.Add(textBoxEmail);
            Name = "MainForm";
            Text = "Отправление email писем";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEmail;
        private TextBox textBoxSubject;
        private TextBox textBoxName;
        private TextBox textBoxBody;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button buttonSend;
    }
}
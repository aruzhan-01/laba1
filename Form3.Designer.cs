namespace TextEditor1502
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            Back1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Back1
            // 
            Back1.Location = new Point(12, 12);
            Back1.Name = "Back1";
            Back1.Size = new Size(108, 41);
            Back1.TabIndex = 0;
            Back1.Text = "Назад";
            Back1.UseVisualStyleBackColor = true;
            Back1.Click += Back1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(174, 21);
            label1.MaximumSize = new Size(500, 500);
            label1.Name = "label1";
            label1.Size = new Size(491, 50);
            label1.TabIndex = 1;
            label1.Text = "Тема: Разработка пользовательского интерфейса (GUI) для языкового процессора.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(34, 93);
            label2.Name = "label2";
            label2.Size = new Size(461, 21);
            label2.TabIndex = 2;
            label2.Text = "Цель работы: Разработать приложение – текстовый редактор. ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(34, 129);
            label3.Name = "label3";
            label3.Size = new Size(671, 63);
            label3.TabIndex = 3;
            label3.Text = resources.GetString("label3.Text");
            label3.Click += label3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 269);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Back1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
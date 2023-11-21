namespace FieldOfDreams
{
    partial class FormGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.labelTemplate = new System.Windows.Forms.Label();
            this.textBoxLetter = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBadLetters = new System.Windows.Forms.Label();
            this.pictureBoxError = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTemplate
            // 
            this.labelTemplate.AutoSize = true;
            this.labelTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTemplate.Location = new System.Drawing.Point(85, 70);
            this.labelTemplate.Name = "labelTemplate";
            this.labelTemplate.Size = new System.Drawing.Size(63, 82);
            this.labelTemplate.TabIndex = 0;
            this.labelTemplate.Text = "*";
            // 
            // textBoxLetter
            // 
            this.textBoxLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLetter.Location = new System.Drawing.Point(75, 174);
            this.textBoxLetter.Name = "textBoxLetter";
            this.textBoxLetter.Size = new System.Drawing.Size(100, 62);
            this.textBoxLetter.TabIndex = 1;
            this.textBoxLetter.Text = "а";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(262, 174);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(156, 62);
            this.buttonCheck.TabIndex = 2;
            this.buttonCheck.Text = "Проверить";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Таких букв нет";
            // 
            // labelBadLetters
            // 
            this.labelBadLetters.AutoSize = true;
            this.labelBadLetters.Location = new System.Drawing.Point(83, 354);
            this.labelBadLetters.Name = "labelBadLetters";
            this.labelBadLetters.Size = new System.Drawing.Size(51, 20);
            this.labelBadLetters.TabIndex = 4;
            this.labelBadLetters.Text = "label2";
            // 
            // pictureBoxError
            // 
            this.pictureBoxError.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxError.Image")));
            this.pictureBoxError.Location = new System.Drawing.Point(460, 84);
            this.pictureBoxError.Name = "pictureBoxError";
            this.pictureBoxError.Size = new System.Drawing.Size(298, 246);
            this.pictureBoxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxError.TabIndex = 5;
            this.pictureBoxError.TabStop = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxError);
            this.Controls.Add(this.labelBadLetters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.textBoxLetter);
            this.Controls.Add(this.labelTemplate);
            this.Name = "FormGame";
            this.Text = "игра ПОЛЕ ЧУДЕС";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTemplate;
        private System.Windows.Forms.TextBox textBoxLetter;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBadLetters;
        private System.Windows.Forms.PictureBox pictureBoxError;
    }
}


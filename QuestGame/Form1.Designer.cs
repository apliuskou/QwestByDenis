namespace QuestGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.batPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(670, 11);
            this.buttonUp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(60, 27);
            this.buttonUp.TabIndex = 0;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(670, 80);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(60, 28);
            this.buttonDown.TabIndex = 1;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(610, 43);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(58, 29);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.Text = "Left";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(734, 45);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(62, 27);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.Text = "Right";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.playerPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playerPictureBox.BackgroundImage")));
            this.playerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("playerPictureBox.InitialImage")));
            this.playerPictureBox.Location = new System.Drawing.Point(487, 206);
            this.playerPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(38, 39);
            this.playerPictureBox.TabIndex = 4;
            this.playerPictureBox.TabStop = false;
            // 
            // batPictureBox
            // 
            this.batPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.batPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("batPictureBox.BackgroundImage")));
            this.batPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.batPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("batPictureBox.InitialImage")));
            this.batPictureBox.Location = new System.Drawing.Point(265, 60);
            this.batPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.batPictureBox.Name = "batPictureBox";
            this.batPictureBox.Size = new System.Drawing.Size(38, 39);
            this.batPictureBox.TabIndex = 5;
            this.batPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuestGame.Properties.Resources.dungeon600x400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(807, 308);
            this.Controls.Add(this.batPictureBox);
            this.Controls.Add(this.playerPictureBox);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        public System.Windows.Forms.PictureBox playerPictureBox;
        public System.Windows.Forms.PictureBox batPictureBox;
    }
}


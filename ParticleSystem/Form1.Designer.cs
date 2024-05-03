namespace ParticleSystem
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
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.lblDirection = new System.Windows.Forms.Label();
            this.tbSpreading = new System.Windows.Forms.TrackBar();
            this.lblSpreading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTeleportR = new System.Windows.Forms.TrackBar();
            this.tbTeleportDirection = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTeleportR = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTeleportDirection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeleportR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeleportDirection)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(12, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(1035, 582);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.Click += new System.EventHandler(this.picDisplay_Click);
            this.picDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseClick);
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(12, 655);
            this.tbDirection.Maximum = 90;
            this.tbDirection.Minimum = -90;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(222, 56);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(240, 655);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(0, 16);
            this.lblDirection.TabIndex = 2;
            // 
            // tbSpreading
            // 
            this.tbSpreading.Location = new System.Drawing.Point(293, 655);
            this.tbSpreading.Maximum = 359;
            this.tbSpreading.Name = "tbSpreading";
            this.tbSpreading.Size = new System.Drawing.Size(231, 56);
            this.tbSpreading.TabIndex = 3;
            this.tbSpreading.Scroll += new System.EventHandler(this.tbSpreading_Scroll);
            // 
            // lblSpreading
            // 
            this.lblSpreading.AutoSize = true;
            this.lblSpreading.Location = new System.Drawing.Point(531, 654);
            this.lblSpreading.Name = "lblSpreading";
            this.lblSpreading.Size = new System.Drawing.Size(0, 16);
            this.lblSpreading.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 633);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Направление";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 633);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Разброс";
            // 
            // tbTeleportR
            // 
            this.tbTeleportR.Location = new System.Drawing.Point(564, 654);
            this.tbTeleportR.Maximum = 100;
            this.tbTeleportR.Name = "tbTeleportR";
            this.tbTeleportR.Size = new System.Drawing.Size(187, 56);
            this.tbTeleportR.TabIndex = 7;
            this.tbTeleportR.Scroll += new System.EventHandler(this.tbTeleportR_Scroll);
            // 
            // tbTeleportDirection
            // 
            this.tbTeleportDirection.Location = new System.Drawing.Point(808, 654);
            this.tbTeleportDirection.Maximum = 359;
            this.tbTeleportDirection.Name = "tbTeleportDirection";
            this.tbTeleportDirection.Size = new System.Drawing.Size(194, 56);
            this.tbTeleportDirection.TabIndex = 8;
            this.tbTeleportDirection.Scroll += new System.EventHandler(this.tbTeleportDirection_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 633);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Радиус телепорта";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbTeleportR
            // 
            this.lbTeleportR.AutoSize = true;
            this.lbTeleportR.Location = new System.Drawing.Point(771, 654);
            this.lbTeleportR.Name = "lbTeleportR";
            this.lbTeleportR.Size = new System.Drawing.Size(0, 16);
            this.lbTeleportR.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(820, 631);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Направление из телепорта";
            // 
            // lbTeleportDirection
            // 
            this.lbTeleportDirection.AutoSize = true;
            this.lbTeleportDirection.Location = new System.Drawing.Point(1013, 664);
            this.lbTeleportDirection.Name = "lbTeleportDirection";
            this.lbTeleportDirection.Size = new System.Drawing.Size(0, 16);
            this.lbTeleportDirection.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 723);
            this.Controls.Add(this.lbTeleportDirection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTeleportR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTeleportDirection);
            this.Controls.Add(this.tbTeleportR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSpreading);
            this.Controls.Add(this.tbSpreading);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeleportR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeleportDirection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.TrackBar tbSpreading;
        private System.Windows.Forms.Label lblSpreading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbTeleportR;
        private System.Windows.Forms.TrackBar tbTeleportDirection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTeleportR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTeleportDirection;
    }
}


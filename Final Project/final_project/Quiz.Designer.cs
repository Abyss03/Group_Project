namespace Final_Project
{
    partial class Quiz
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
            this.lblTag = new System.Windows.Forms.Label();
            this.lblScr = new System.Windows.Forms.Label();
            this.grpAnswer = new System.Windows.Forms.GroupBox();
            this.radD = new System.Windows.Forms.RadioButton();
            this.radC = new System.Windows.Forms.RadioButton();
            this.radB = new System.Windows.Forms.RadioButton();
            this.radA = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblQues = new System.Windows.Forms.Label();
            this.grpAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.BackColor = System.Drawing.SystemColors.Window;
            this.lblTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.lblTag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTag.Location = new System.Drawing.Point(36, 179);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(80, 25);
            this.lblTag.TabIndex = 14;
            this.lblTag.Text = "Score:";
            // 
            // lblScr
            // 
            this.lblScr.AutoSize = true;
            this.lblScr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblScr.Location = new System.Drawing.Point(102, 179);
            this.lblScr.Name = "lblScr";
            this.lblScr.Size = new System.Drawing.Size(0, 20);
            this.lblScr.TabIndex = 13;
            // 
            // grpAnswer
            // 
            this.grpAnswer.Controls.Add(this.radD);
            this.grpAnswer.Controls.Add(this.radC);
            this.grpAnswer.Controls.Add(this.radB);
            this.grpAnswer.Controls.Add(this.radA);
            this.grpAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.grpAnswer.Location = new System.Drawing.Point(293, 133);
            this.grpAnswer.Name = "grpAnswer";
            this.grpAnswer.Size = new System.Drawing.Size(338, 176);
            this.grpAnswer.TabIndex = 12;
            this.grpAnswer.TabStop = false;
            this.grpAnswer.Text = "Answers";
            this.grpAnswer.Enter += new System.EventHandler(this.grpAnswer_Enter_1);
            // 
            // radD
            // 
            this.radD.AutoSize = true;
            this.radD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radD.Location = new System.Drawing.Point(3, 149);
            this.radD.Name = "radD";
            this.radD.Size = new System.Drawing.Size(14, 13);
            this.radD.TabIndex = 3;
            this.radD.TabStop = true;
            this.radD.UseVisualStyleBackColor = true;
            // 
            // radC
            // 
            this.radC.AutoSize = true;
            this.radC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radC.Location = new System.Drawing.Point(3, 106);
            this.radC.Name = "radC";
            this.radC.Size = new System.Drawing.Size(14, 13);
            this.radC.TabIndex = 2;
            this.radC.TabStop = true;
            this.radC.UseVisualStyleBackColor = true;
            // 
            // radB
            // 
            this.radB.AutoSize = true;
            this.radB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radB.Location = new System.Drawing.Point(3, 64);
            this.radB.Name = "radB";
            this.radB.Size = new System.Drawing.Size(14, 13);
            this.radB.TabIndex = 1;
            this.radB.TabStop = true;
            this.radB.UseVisualStyleBackColor = true;
            // 
            // radA
            // 
            this.radA.AutoSize = true;
            this.radA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radA.Location = new System.Drawing.Point(3, 19);
            this.radA.Name = "radA";
            this.radA.Size = new System.Drawing.Size(14, 13);
            this.radA.TabIndex = 0;
            this.radA.TabStop = true;
            this.radA.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubmit.Location = new System.Drawing.Point(452, 385);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(124, 38);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // btnPlay
            // 
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPlay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPlay.Location = new System.Drawing.Point(101, 385);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(124, 38);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(293, 385);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 38);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblQues
            // 
            this.lblQues.AutoSize = true;
            this.lblQues.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblQues.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblQues.Location = new System.Drawing.Point(15, 62);
            this.lblQues.Name = "lblQues";
            this.lblQues.Size = new System.Drawing.Size(0, 25);
            this.lblQues.TabIndex = 15;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Final_Project.Properties.Resources.question_mark_outline_in_a_circle_hand_drawn_button_318_51941;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(672, 474);
            this.Controls.Add(this.lblQues);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.lblScr);
            this.Controls.Add(this.grpAnswer);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(688, 512);
            this.MinimumSize = new System.Drawing.Size(688, 512);
            this.Name = "Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Quiz_Load);
            this.grpAnswer.ResumeLayout(false);
            this.grpAnswer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblScr;
        private System.Windows.Forms.GroupBox grpAnswer;
        private System.Windows.Forms.RadioButton radD;
        private System.Windows.Forms.RadioButton radC;
        private System.Windows.Forms.RadioButton radB;
        private System.Windows.Forms.RadioButton radA;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblQues;
    }
}
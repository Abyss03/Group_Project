namespace Safe_Internet_Usage
{
    partial class frmQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuiz));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtBoxQuestion = new System.Windows.Forms.TextBox();
            this.grpAnswer = new System.Windows.Forms.GroupBox();
            this.radA = new System.Windows.Forms.RadioButton();
            this.radB = new System.Windows.Forms.RadioButton();
            this.radC = new System.Windows.Forms.RadioButton();
            this.radD = new System.Windows.Forms.RadioButton();
            this.grpAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExitEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnLeave);
            // 
            // btnPlay
            // 
            resources.ApplyResources(this.btnPlay, "btnPlay");
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseEnter += new System.EventHandler(this.btnEnter);
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnLeave);
            // 
            // btnSubmit
            // 
            resources.ApplyResources(this.btnSubmit, "btnSubmit");
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.MouseEnter += new System.EventHandler(this.btnEnter);
            this.btnSubmit.MouseLeave += new System.EventHandler(this.btnLeave);
            // 
            // txtBoxQuestion
            // 
            resources.ApplyResources(this.txtBoxQuestion, "txtBoxQuestion");
            this.txtBoxQuestion.Name = "txtBoxQuestion";
            // 
            // grpAnswer
            // 
            this.grpAnswer.Controls.Add(this.radD);
            this.grpAnswer.Controls.Add(this.radC);
            this.grpAnswer.Controls.Add(this.radB);
            this.grpAnswer.Controls.Add(this.radA);
            resources.ApplyResources(this.grpAnswer, "grpAnswer");
            this.grpAnswer.Name = "grpAnswer";
            this.grpAnswer.TabStop = false;
            // 
            // radA
            // 
            resources.ApplyResources(this.radA, "radA");
            this.radA.Name = "radA";
            this.radA.TabStop = true;
            this.radA.UseVisualStyleBackColor = true;
            // 
            // radB
            // 
            resources.ApplyResources(this.radB, "radB");
            this.radB.Name = "radB";
            this.radB.TabStop = true;
            this.radB.UseVisualStyleBackColor = true;
            // 
            // radC
            // 
            resources.ApplyResources(this.radC, "radC");
            this.radC.Name = "radC";
            this.radC.TabStop = true;
            this.radC.UseVisualStyleBackColor = true;
            // 
            // radD
            // 
            resources.ApplyResources(this.radD, "radD");
            this.radD.Name = "radD";
            this.radD.TabStop = true;
            this.radD.UseVisualStyleBackColor = true;
            // 
            // frmQuiz
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.grpAnswer);
            this.Controls.Add(this.txtBoxQuestion);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnExit);
            this.Name = "frmQuiz";
            this.Load += new System.EventHandler(this.frmQuiz_Load);
            this.grpAnswer.ResumeLayout(false);
            this.grpAnswer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtBoxQuestion;
        private System.Windows.Forms.GroupBox grpAnswer;
        private System.Windows.Forms.RadioButton radD;
        private System.Windows.Forms.RadioButton radC;
        private System.Windows.Forms.RadioButton radB;
        private System.Windows.Forms.RadioButton radA;
    }
}
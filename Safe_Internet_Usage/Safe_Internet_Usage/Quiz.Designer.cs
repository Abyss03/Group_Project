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
            this.btnHTP = new System.Windows.Forms.Button();
            this.txtBoxQuestion = new System.Windows.Forms.TextBox();
            this.txtBoxAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExitEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnLeave);
            // 
            // btnPlay
            // 
            resources.ApplyResources(this.btnPlay, "btnPlay");
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.MouseEnter += new System.EventHandler(this.btnEnter);
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnLeave);
            // 
            // btnHTP
            // 
            resources.ApplyResources(this.btnHTP, "btnHTP");
            this.btnHTP.Name = "btnHTP";
            this.btnHTP.UseVisualStyleBackColor = true;
            this.btnHTP.MouseEnter += new System.EventHandler(this.btnEnter);
            this.btnHTP.MouseLeave += new System.EventHandler(this.btnLeave);
            // 
            // txtBoxQuestion
            // 
            resources.ApplyResources(this.txtBoxQuestion, "txtBoxQuestion");
            this.txtBoxQuestion.Name = "txtBoxQuestion";
            // 
            // txtBoxAnswer
            // 
            resources.ApplyResources(this.txtBoxAnswer, "txtBoxAnswer");
            this.txtBoxAnswer.Name = "txtBoxAnswer";
            // 
            // frmQuiz
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.txtBoxAnswer);
            this.Controls.Add(this.txtBoxQuestion);
            this.Controls.Add(this.btnHTP);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnExit);
            this.Name = "frmQuiz";
            this.Load += new System.EventHandler(this.frmQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnHTP;
        private System.Windows.Forms.TextBox txtBoxQuestion;
        private System.Windows.Forms.TextBox txtBoxAnswer;
    }
}
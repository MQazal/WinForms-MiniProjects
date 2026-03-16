namespace MathGame
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
            this.components = new System.ComponentModel.Container();
            this.gbxQuizInformation = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblQsNumber = new System.Windows.Forms.Label();
            this.lblQsType = new System.Windows.Forms.Label();
            this.lblOperation = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxProgress = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblFalseQs = new System.Windows.Forms.Label();
            this.lblTrueQs = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.QuizTimer = new System.Windows.Forms.Timer(this.components);
            this.panQuestions = new System.Windows.Forms.Panel();
            this.tbxQuestion = new System.Windows.Forms.TextBox();
            this.rbtnChoice4 = new System.Windows.Forms.RadioButton();
            this.rbtnChoice3 = new System.Windows.Forms.RadioButton();
            this.rbtnChoice2 = new System.Windows.Forms.RadioButton();
            this.rbtnChoice1 = new System.Windows.Forms.RadioButton();
            this.msboxA = new System.Windows.Forms.MaskedTextBox();
            this.rbtnFalse = new System.Windows.Forms.RadioButton();
            this.rbtnTrue = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxQuizInformation.SuspendLayout();
            this.gbxProgress.SuspendLayout();
            this.panQuestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxQuizInformation
            // 
            this.gbxQuizInformation.BackColor = System.Drawing.Color.Transparent;
            this.gbxQuizInformation.Controls.Add(this.lblTime);
            this.gbxQuizInformation.Controls.Add(this.lblQsNumber);
            this.gbxQuizInformation.Controls.Add(this.lblQsType);
            this.gbxQuizInformation.Controls.Add(this.lblOperation);
            this.gbxQuizInformation.Controls.Add(this.lblLevel);
            this.gbxQuizInformation.Controls.Add(this.label5);
            this.gbxQuizInformation.Controls.Add(this.label4);
            this.gbxQuizInformation.Controls.Add(this.label3);
            this.gbxQuizInformation.Controls.Add(this.label2);
            this.gbxQuizInformation.Controls.Add(this.label1);
            this.gbxQuizInformation.Font = new System.Drawing.Font("Segoe UI Variable Display", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxQuizInformation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxQuizInformation.Location = new System.Drawing.Point(84, 50);
            this.gbxQuizInformation.Margin = new System.Windows.Forms.Padding(4);
            this.gbxQuizInformation.Name = "gbxQuizInformation";
            this.gbxQuizInformation.Padding = new System.Windows.Forms.Padding(4);
            this.gbxQuizInformation.Size = new System.Drawing.Size(484, 449);
            this.gbxQuizInformation.TabIndex = 0;
            this.gbxQuizInformation.TabStop = false;
            this.gbxQuizInformation.Text = "Quiz Information";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Variable Display", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Yellow;
            this.lblTime.Location = new System.Drawing.Point(136, 391);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(28, 32);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "0";
            // 
            // lblQsNumber
            // 
            this.lblQsNumber.AutoSize = true;
            this.lblQsNumber.Font = new System.Drawing.Font("Segoe UI Variable Display", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQsNumber.ForeColor = System.Drawing.Color.Yellow;
            this.lblQsNumber.Location = new System.Drawing.Point(292, 313);
            this.lblQsNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQsNumber.Name = "lblQsNumber";
            this.lblQsNumber.Size = new System.Drawing.Size(28, 32);
            this.lblQsNumber.TabIndex = 8;
            this.lblQsNumber.Text = "0";
            // 
            // lblQsType
            // 
            this.lblQsType.AutoSize = true;
            this.lblQsType.Font = new System.Drawing.Font("Segoe UI Variable Display", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQsType.ForeColor = System.Drawing.Color.Yellow;
            this.lblQsType.Location = new System.Drawing.Point(255, 224);
            this.lblQsType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQsType.Name = "lblQsType";
            this.lblQsType.Size = new System.Drawing.Size(38, 32);
            this.lblQsType.TabIndex = 7;
            this.lblQsType.Text = "\"\"";
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Font = new System.Drawing.Font("Segoe UI Variable Display", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.ForeColor = System.Drawing.Color.Yellow;
            this.lblOperation.Location = new System.Drawing.Point(195, 139);
            this.lblOperation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(38, 32);
            this.lblOperation.TabIndex = 6;
            this.lblOperation.Text = "\"\"";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Segoe UI Variable Display", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.Yellow;
            this.lblLevel.Location = new System.Drawing.Point(138, 60);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(38, 32);
            this.lblLevel.TabIndex = 5;
            this.lblLevel.Text = "\"\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 391);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 313);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Questions Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Questions Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operation:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Level:";
            // 
            // gbxProgress
            // 
            this.gbxProgress.BackColor = System.Drawing.Color.Transparent;
            this.gbxProgress.Controls.Add(this.lblResult);
            this.gbxProgress.Controls.Add(this.lblFalseQs);
            this.gbxProgress.Controls.Add(this.lblTrueQs);
            this.gbxProgress.Controls.Add(this.label9);
            this.gbxProgress.Controls.Add(this.label7);
            this.gbxProgress.Controls.Add(this.label6);
            this.gbxProgress.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxProgress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxProgress.Location = new System.Drawing.Point(602, 71);
            this.gbxProgress.Margin = new System.Windows.Forms.Padding(4);
            this.gbxProgress.Name = "gbxProgress";
            this.gbxProgress.Padding = new System.Windows.Forms.Padding(4);
            this.gbxProgress.Size = new System.Drawing.Size(327, 306);
            this.gbxProgress.TabIndex = 1;
            this.gbxProgress.TabStop = false;
            this.gbxProgress.Text = "Round/Progress";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(131, 235);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(181, 34);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Quiz not start";
            // 
            // lblFalseQs
            // 
            this.lblFalseQs.AutoSize = true;
            this.lblFalseQs.Location = new System.Drawing.Point(253, 157);
            this.lblFalseQs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFalseQs.Name = "lblFalseQs";
            this.lblFalseQs.Size = new System.Drawing.Size(29, 34);
            this.lblFalseQs.TabIndex = 6;
            this.lblFalseQs.Text = "0";
            // 
            // lblTrueQs
            // 
            this.lblTrueQs.AutoSize = true;
            this.lblTrueQs.Location = new System.Drawing.Point(253, 74);
            this.lblTrueQs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrueQs.Name = "lblTrueQs";
            this.lblTrueQs.Size = new System.Drawing.Size(29, 34);
            this.lblTrueQs.TabIndex = 5;
            this.lblTrueQs.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 235);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 34);
            this.label9.TabIndex = 3;
            this.label9.Text = "Result:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 34);
            this.label7.TabIndex = 1;
            this.label7.Text = "False Questions:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 34);
            this.label6.TabIndex = 0;
            this.label6.Text = "True Questions:";
            // 
            // QuizTimer
            // 
            this.QuizTimer.Interval = 1000;
            this.QuizTimer.Tick += new System.EventHandler(this.QuizTimer_Tick);
            // 
            // panQuestions
            // 
            this.panQuestions.BackColor = System.Drawing.Color.Transparent;
            this.panQuestions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panQuestions.Controls.Add(this.tbxQuestion);
            this.panQuestions.Controls.Add(this.rbtnChoice4);
            this.panQuestions.Controls.Add(this.rbtnChoice3);
            this.panQuestions.Controls.Add(this.rbtnChoice2);
            this.panQuestions.Controls.Add(this.rbtnChoice1);
            this.panQuestions.Controls.Add(this.msboxA);
            this.panQuestions.Controls.Add(this.rbtnFalse);
            this.panQuestions.Controls.Add(this.rbtnTrue);
            this.panQuestions.Font = new System.Drawing.Font("Engravers MT", 15F);
            this.panQuestions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panQuestions.Location = new System.Drawing.Point(963, 71);
            this.panQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.panQuestions.Name = "panQuestions";
            this.panQuestions.Size = new System.Drawing.Size(383, 235);
            this.panQuestions.TabIndex = 2;
            // 
            // tbxQuestion
            // 
            this.tbxQuestion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tbxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxQuestion.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxQuestion.Location = new System.Drawing.Point(0, 0);
            this.tbxQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.tbxQuestion.Multiline = true;
            this.tbxQuestion.Name = "tbxQuestion";
            this.tbxQuestion.Size = new System.Drawing.Size(379, 61);
            this.tbxQuestion.TabIndex = 7;
            this.tbxQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbtnChoice4
            // 
            this.rbtnChoice4.AutoSize = true;
            this.rbtnChoice4.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnChoice4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnChoice4.Location = new System.Drawing.Point(240, 184);
            this.rbtnChoice4.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnChoice4.Name = "rbtnChoice4";
            this.rbtnChoice4.Size = new System.Drawing.Size(17, 16);
            this.rbtnChoice4.TabIndex = 6;
            this.rbtnChoice4.TabStop = true;
            this.rbtnChoice4.Tag = "";
            this.rbtnChoice4.UseVisualStyleBackColor = true;
            // 
            // rbtnChoice3
            // 
            this.rbtnChoice3.AutoSize = true;
            this.rbtnChoice3.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnChoice3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnChoice3.Location = new System.Drawing.Point(62, 184);
            this.rbtnChoice3.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnChoice3.Name = "rbtnChoice3";
            this.rbtnChoice3.Size = new System.Drawing.Size(17, 16);
            this.rbtnChoice3.TabIndex = 5;
            this.rbtnChoice3.TabStop = true;
            this.rbtnChoice3.Tag = "";
            this.rbtnChoice3.UseVisualStyleBackColor = true;
            // 
            // rbtnChoice2
            // 
            this.rbtnChoice2.AutoSize = true;
            this.rbtnChoice2.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnChoice2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnChoice2.Location = new System.Drawing.Point(240, 147);
            this.rbtnChoice2.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnChoice2.Name = "rbtnChoice2";
            this.rbtnChoice2.Size = new System.Drawing.Size(17, 16);
            this.rbtnChoice2.TabIndex = 4;
            this.rbtnChoice2.TabStop = true;
            this.rbtnChoice2.Tag = "";
            this.rbtnChoice2.UseVisualStyleBackColor = true;
            // 
            // rbtnChoice1
            // 
            this.rbtnChoice1.AutoSize = true;
            this.rbtnChoice1.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnChoice1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnChoice1.Location = new System.Drawing.Point(62, 150);
            this.rbtnChoice1.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnChoice1.Name = "rbtnChoice1";
            this.rbtnChoice1.Size = new System.Drawing.Size(17, 16);
            this.rbtnChoice1.TabIndex = 3;
            this.rbtnChoice1.TabStop = true;
            this.rbtnChoice1.Tag = "";
            this.rbtnChoice1.UseVisualStyleBackColor = true;
            // 
            // msboxA
            // 
            this.msboxA.AllowPromptAsInput = false;
            this.msboxA.BeepOnError = true;
            this.msboxA.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msboxA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.msboxA.Location = new System.Drawing.Point(91, 135);
            this.msboxA.Margin = new System.Windows.Forms.Padding(4);
            this.msboxA.Name = "msboxA";
            this.msboxA.Size = new System.Drawing.Size(132, 41);
            this.msboxA.TabIndex = 2;
            this.msboxA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbtnFalse
            // 
            this.rbtnFalse.AutoSize = true;
            this.rbtnFalse.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFalse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnFalse.Location = new System.Drawing.Point(206, 88);
            this.rbtnFalse.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnFalse.Name = "rbtnFalse";
            this.rbtnFalse.Size = new System.Drawing.Size(92, 39);
            this.rbtnFalse.TabIndex = 1;
            this.rbtnFalse.TabStop = true;
            this.rbtnFalse.Text = "False";
            this.rbtnFalse.UseVisualStyleBackColor = true;
            this.rbtnFalse.CheckedChanged += new System.EventHandler(this.ChooseTrueOrFalse);
            // 
            // rbtnTrue
            // 
            this.rbtnTrue.AutoSize = true;
            this.rbtnTrue.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTrue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnTrue.Location = new System.Drawing.Point(103, 88);
            this.rbtnTrue.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnTrue.Name = "rbtnTrue";
            this.rbtnTrue.Size = new System.Drawing.Size(84, 39);
            this.rbtnTrue.TabIndex = 0;
            this.rbtnTrue.TabStop = true;
            this.rbtnTrue.Text = "True";
            this.rbtnTrue.UseVisualStyleBackColor = true;
            this.rbtnTrue.CheckedChanged += new System.EventHandler(this.ChooseTrueOrFalse);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(79, 527);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 30);
            this.label10.TabIndex = 3;
            this.label10.Text = "Timer:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(233, 521);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label11.Size = new System.Drawing.Size(36, 42);
            this.label11.TabIndex = 5;
            this.label11.Text = ":";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMinutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMinutes.ForeColor = System.Drawing.Color.Yellow;
            this.lblMinutes.Location = new System.Drawing.Point(182, 520);
            this.lblMinutes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblMinutes.Size = new System.Drawing.Size(43, 43);
            this.lblMinutes.TabIndex = 6;
            this.lblMinutes.Text = "0";
            this.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSeconds.ForeColor = System.Drawing.Color.Yellow;
            this.lblSeconds.Location = new System.Drawing.Point(277, 519);
            this.lblSeconds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblSeconds.Size = new System.Drawing.Size(43, 43);
            this.lblSeconds.TabIndex = 7;
            this.lblSeconds.Text = "0";
            this.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCheck.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Bold);
            this.btnCheck.Location = new System.Drawing.Point(1056, 363);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(160, 51);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnStart.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Bold);
            this.btnStart.Location = new System.Drawing.Point(602, 472);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(149, 58);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExit.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(775, 472);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(151, 58);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmQuiz
            // 
            this.AcceptButton = this.btnCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1410, 618);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panQuestions);
            this.Controls.Add(this.gbxProgress);
            this.Controls.Add(this.gbxQuizInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuiz";
            this.Text = "frmQuiz";
            this.Load += new System.EventHandler(this.frmQuiz_Load);
            this.gbxQuizInformation.ResumeLayout(false);
            this.gbxQuizInformation.PerformLayout();
            this.gbxProgress.ResumeLayout(false);
            this.gbxProgress.PerformLayout();
            this.panQuestions.ResumeLayout(false);
            this.panQuestions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxQuizInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbxProgress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer QuizTimer;
        private System.Windows.Forms.Panel panQuestions;
        private System.Windows.Forms.RadioButton rbtnFalse;
        private System.Windows.Forms.RadioButton rbtnTrue;
        private System.Windows.Forms.MaskedTextBox msboxA;
        private System.Windows.Forms.TextBox tbxQuestion;
        private System.Windows.Forms.RadioButton rbtnChoice4;
        private System.Windows.Forms.RadioButton rbtnChoice3;
        private System.Windows.Forms.RadioButton rbtnChoice2;
        private System.Windows.Forms.RadioButton rbtnChoice1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblQsType;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblQsNumber;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblFalseQs;
        private System.Windows.Forms.Label lblTrueQs;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
    }
}
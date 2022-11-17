namespace ToolBoxQuiz
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Auswahl = new System.Windows.Forms.ComboBox();
            this.BildBox = new System.Windows.Forms.PictureBox();
            this.BTN_START = new System.Windows.Forms.Button();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.Antwort_A = new System.Windows.Forms.RadioButton();
            this.Antwort_B = new System.Windows.Forms.RadioButton();
            this.Antwort_C = new System.Windows.Forms.RadioButton();
            this.Antwort_D = new System.Windows.Forms.RadioButton();
            this.Fragenzähler = new System.Windows.Forms.Label();
            this.BTN_CANCEL = new System.Windows.Forms.Button();
            this.BTN_FORWARD = new System.Windows.Forms.Button();
            this.Fragekatalog = new System.Windows.Forms.Label();
            this.WHO_IS_LOGGED_IN = new System.Windows.Forms.Label();
            this.TB_Answer = new System.Windows.Forms.TextBox();
            this.MATH_NUM = new System.Windows.Forms.NumericUpDown();
            this.BTN_ERGEBNIS = new System.Windows.Forms.Button();
            this.BTN_LOGOUT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BildBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MATH_NUM)).BeginInit();
            this.SuspendLayout();
            // 
            // Auswahl
            // 
            this.Auswahl.BackColor = System.Drawing.Color.PeachPuff;
            this.Auswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Auswahl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Auswahl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Auswahl.FormattingEnabled = true;
            this.Auswahl.Location = new System.Drawing.Point(991, 31);
            this.Auswahl.Name = "Auswahl";
            this.Auswahl.Size = new System.Drawing.Size(249, 33);
            this.Auswahl.TabIndex = 0;
            this.Auswahl.SelectedIndexChanged += new System.EventHandler(this.Auswahl_SelectedIndexChanged);
            // 
            // BildBox
            // 
            this.BildBox.BackColor = System.Drawing.Color.Transparent;
            this.BildBox.Location = new System.Drawing.Point(387, 31);
            this.BildBox.Name = "BildBox";
            this.BildBox.Size = new System.Drawing.Size(450, 296);
            this.BildBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BildBox.TabIndex = 1;
            this.BildBox.TabStop = false;
            this.BildBox.Visible = false;
            // 
            // BTN_START
            // 
            this.BTN_START.BackColor = System.Drawing.Color.Transparent;
            this.BTN_START.BackgroundImage = global::ToolBoxQuiz.Properties.Resources.BTNblue;
            this.BTN_START.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_START.FlatAppearance.BorderSize = 0;
            this.BTN_START.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTN_START.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTN_START.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_START.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_START.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_START.Location = new System.Drawing.Point(455, 172);
            this.BTN_START.Name = "BTN_START";
            this.BTN_START.Size = new System.Drawing.Size(315, 155);
            this.BTN_START.TabIndex = 2;
            this.BTN_START.Text = "Test Starten";
            this.BTN_START.UseVisualStyleBackColor = false;
            this.BTN_START.Click += new System.EventHandler(this.BTN_START_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuestionLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuestionLabel.Location = new System.Drawing.Point(217, 330);
            this.QuestionLabel.MaximumSize = new System.Drawing.Size(800, 100);
            this.QuestionLabel.MinimumSize = new System.Drawing.Size(800, 100);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(800, 100);
            this.QuestionLabel.TabIndex = 3;
            this.QuestionLabel.Text = "Probetext";
            this.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QuestionLabel.Visible = false;
            // 
            // Antwort_A
            // 
            this.Antwort_A.AutoSize = true;
            this.Antwort_A.BackColor = System.Drawing.Color.Transparent;
            this.Antwort_A.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Antwort_A.Location = new System.Drawing.Point(70, 443);
            this.Antwort_A.MaximumSize = new System.Drawing.Size(300, 100);
            this.Antwort_A.MinimumSize = new System.Drawing.Size(300, 100);
            this.Antwort_A.Name = "Antwort_A";
            this.Antwort_A.Size = new System.Drawing.Size(300, 100);
            this.Antwort_A.TabIndex = 4;
            this.Antwort_A.TabStop = true;
            this.Antwort_A.Text = "Antwort A";
            this.Antwort_A.UseVisualStyleBackColor = false;
            this.Antwort_A.Visible = false;
            // 
            // Antwort_B
            // 
            this.Antwort_B.AutoSize = true;
            this.Antwort_B.BackColor = System.Drawing.Color.Transparent;
            this.Antwort_B.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Antwort_B.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Antwort_B.Location = new System.Drawing.Point(842, 443);
            this.Antwort_B.MaximumSize = new System.Drawing.Size(300, 100);
            this.Antwort_B.MinimumSize = new System.Drawing.Size(300, 100);
            this.Antwort_B.Name = "Antwort_B";
            this.Antwort_B.Size = new System.Drawing.Size(300, 100);
            this.Antwort_B.TabIndex = 5;
            this.Antwort_B.TabStop = true;
            this.Antwort_B.Text = "Antwort B";
            this.Antwort_B.UseVisualStyleBackColor = false;
            this.Antwort_B.Visible = false;
            // 
            // Antwort_C
            // 
            this.Antwort_C.AutoSize = true;
            this.Antwort_C.BackColor = System.Drawing.Color.Transparent;
            this.Antwort_C.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Antwort_C.Location = new System.Drawing.Point(70, 555);
            this.Antwort_C.MaximumSize = new System.Drawing.Size(300, 100);
            this.Antwort_C.MinimumSize = new System.Drawing.Size(300, 100);
            this.Antwort_C.Name = "Antwort_C";
            this.Antwort_C.Size = new System.Drawing.Size(300, 100);
            this.Antwort_C.TabIndex = 6;
            this.Antwort_C.TabStop = true;
            this.Antwort_C.Text = "Antwort C";
            this.Antwort_C.UseVisualStyleBackColor = false;
            this.Antwort_C.Visible = false;
            // 
            // Antwort_D
            // 
            this.Antwort_D.AutoSize = true;
            this.Antwort_D.BackColor = System.Drawing.Color.Transparent;
            this.Antwort_D.FlatAppearance.BorderSize = 0;
            this.Antwort_D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Antwort_D.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Antwort_D.Location = new System.Drawing.Point(842, 555);
            this.Antwort_D.MaximumSize = new System.Drawing.Size(300, 100);
            this.Antwort_D.MinimumSize = new System.Drawing.Size(300, 100);
            this.Antwort_D.Name = "Antwort_D";
            this.Antwort_D.Size = new System.Drawing.Size(300, 100);
            this.Antwort_D.TabIndex = 7;
            this.Antwort_D.TabStop = true;
            this.Antwort_D.Text = "Antwort D";
            this.Antwort_D.UseVisualStyleBackColor = false;
            this.Antwort_D.Visible = false;
            // 
            // Fragenzähler
            // 
            this.Fragenzähler.AutoSize = true;
            this.Fragenzähler.BackColor = System.Drawing.Color.Transparent;
            this.Fragenzähler.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Fragenzähler.Location = new System.Drawing.Point(853, 116);
            this.Fragenzähler.Name = "Fragenzähler";
            this.Fragenzähler.Size = new System.Drawing.Size(91, 25);
            this.Fragenzähler.TabIndex = 8;
            this.Fragenzähler.Text = "Frage 0/0";
            this.Fragenzähler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Fragenzähler.Visible = false;
            // 
            // BTN_CANCEL
            // 
            this.BTN_CANCEL.BackColor = System.Drawing.Color.Transparent;
            this.BTN_CANCEL.BackgroundImage = global::ToolBoxQuiz.Properties.Resources.BTNred;
            this.BTN_CANCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_CANCEL.FlatAppearance.BorderSize = 0;
            this.BTN_CANCEL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTN_CANCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTN_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_CANCEL.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_CANCEL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_CANCEL.Location = new System.Drawing.Point(12, 707);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(268, 80);
            this.BTN_CANCEL.TabIndex = 9;
            this.BTN_CANCEL.Text = "Abbrechen";
            this.BTN_CANCEL.UseVisualStyleBackColor = false;
            this.BTN_CANCEL.Visible = false;
            this.BTN_CANCEL.Click += new System.EventHandler(this.BTN_CANCEL_Click);
            // 
            // BTN_FORWARD
            // 
            this.BTN_FORWARD.BackColor = System.Drawing.Color.Transparent;
            this.BTN_FORWARD.BackgroundImage = global::ToolBoxQuiz.Properties.Resources.BTNgreen1;
            this.BTN_FORWARD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_FORWARD.FlatAppearance.BorderSize = 0;
            this.BTN_FORWARD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTN_FORWARD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTN_FORWARD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_FORWARD.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_FORWARD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_FORWARD.Location = new System.Drawing.Point(991, 707);
            this.BTN_FORWARD.Name = "BTN_FORWARD";
            this.BTN_FORWARD.Size = new System.Drawing.Size(263, 80);
            this.BTN_FORWARD.TabIndex = 10;
            this.BTN_FORWARD.Text = "Weiter";
            this.BTN_FORWARD.UseVisualStyleBackColor = false;
            this.BTN_FORWARD.Visible = false;
            this.BTN_FORWARD.Click += new System.EventHandler(this.BTN_FORWARD_Click);
            // 
            // Fragekatalog
            // 
            this.Fragekatalog.AutoSize = true;
            this.Fragekatalog.BackColor = System.Drawing.Color.Transparent;
            this.Fragekatalog.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Fragekatalog.Location = new System.Drawing.Point(849, 34);
            this.Fragekatalog.Name = "Fragekatalog";
            this.Fragekatalog.Size = new System.Drawing.Size(136, 25);
            this.Fragekatalog.TabIndex = 11;
            this.Fragekatalog.Text = "Fragenkatalog:";
            this.Fragekatalog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WHO_IS_LOGGED_IN
            // 
            this.WHO_IS_LOGGED_IN.AutoSize = true;
            this.WHO_IS_LOGGED_IN.BackColor = System.Drawing.Color.Transparent;
            this.WHO_IS_LOGGED_IN.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WHO_IS_LOGGED_IN.Location = new System.Drawing.Point(12, 123);
            this.WHO_IS_LOGGED_IN.Name = "WHO_IS_LOGGED_IN";
            this.WHO_IS_LOGGED_IN.Size = new System.Drawing.Size(0, 25);
            this.WHO_IS_LOGGED_IN.TabIndex = 13;
            this.WHO_IS_LOGGED_IN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Answer
            // 
            this.TB_Answer.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_Answer.Location = new System.Drawing.Point(481, 559);
            this.TB_Answer.Name = "TB_Answer";
            this.TB_Answer.Size = new System.Drawing.Size(172, 50);
            this.TB_Answer.TabIndex = 14;
            this.TB_Answer.Visible = false;
            // 
            // MATH_NUM
            // 
            this.MATH_NUM.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MATH_NUM.Location = new System.Drawing.Point(481, 555);
            this.MATH_NUM.Maximum = new decimal(new int[] {
            1241513984,
            370409800,
            542101,
            0});
            this.MATH_NUM.Name = "MATH_NUM";
            this.MATH_NUM.Size = new System.Drawing.Size(172, 54);
            this.MATH_NUM.TabIndex = 15;
            this.MATH_NUM.Visible = false;
            // 
            // BTN_ERGEBNIS
            // 
            this.BTN_ERGEBNIS.BackColor = System.Drawing.Color.Transparent;
            this.BTN_ERGEBNIS.BackgroundImage = global::ToolBoxQuiz.Properties.Resources.BTNblue;
            this.BTN_ERGEBNIS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_ERGEBNIS.FlatAppearance.BorderSize = 0;
            this.BTN_ERGEBNIS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTN_ERGEBNIS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTN_ERGEBNIS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_ERGEBNIS.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_ERGEBNIS.Location = new System.Drawing.Point(853, 156);
            this.BTN_ERGEBNIS.Name = "BTN_ERGEBNIS";
            this.BTN_ERGEBNIS.Size = new System.Drawing.Size(152, 60);
            this.BTN_ERGEBNIS.TabIndex = 16;
            this.BTN_ERGEBNIS.Text = "Ergebnisse einsehen:";
            this.BTN_ERGEBNIS.UseVisualStyleBackColor = false;
            this.BTN_ERGEBNIS.Visible = false;
            this.BTN_ERGEBNIS.Click += new System.EventHandler(this.Ergebnisse_Click);
            // 
            // BTN_LOGOUT
            // 
            this.BTN_LOGOUT.BackColor = System.Drawing.Color.Transparent;
            this.BTN_LOGOUT.BackgroundImage = global::ToolBoxQuiz.Properties.Resources.BTNred;
            this.BTN_LOGOUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_LOGOUT.FlatAppearance.BorderSize = 0;
            this.BTN_LOGOUT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTN_LOGOUT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTN_LOGOUT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_LOGOUT.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_LOGOUT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_LOGOUT.Location = new System.Drawing.Point(13, 182);
            this.BTN_LOGOUT.Name = "BTN_LOGOUT";
            this.BTN_LOGOUT.Size = new System.Drawing.Size(219, 57);
            this.BTN_LOGOUT.TabIndex = 17;
            this.BTN_LOGOUT.Text = "Ausloggen";
            this.BTN_LOGOUT.UseVisualStyleBackColor = false;
            this.BTN_LOGOUT.Click += new System.EventHandler(this.BTN_LOGOUT_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::ToolBoxQuiz.Properties.Resources.Back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1266, 799);
            this.Controls.Add(this.BTN_LOGOUT);
            this.Controls.Add(this.BTN_ERGEBNIS);
            this.Controls.Add(this.MATH_NUM);
            this.Controls.Add(this.TB_Answer);
            this.Controls.Add(this.WHO_IS_LOGGED_IN);
            this.Controls.Add(this.Fragekatalog);
            this.Controls.Add(this.BTN_FORWARD);
            this.Controls.Add(this.BTN_CANCEL);
            this.Controls.Add(this.Fragenzähler);
            this.Controls.Add(this.Antwort_D);
            this.Controls.Add(this.Antwort_C);
            this.Controls.Add(this.Antwort_B);
            this.Controls.Add(this.Antwort_A);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.BTN_START);
            this.Controls.Add(this.BildBox);
            this.Controls.Add(this.Auswahl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1282, 838);
            this.MinimumSize = new System.Drawing.Size(1282, 838);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Toolbox Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.BildBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MATH_NUM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox Auswahl;
        private PictureBox BildBox;
        private Button BTN_START;
        private Label QuestionLabel;
        private RadioButton Antwort_A;
        private RadioButton Antwort_B;
        private RadioButton Antwort_C;
        private RadioButton Antwort_D;
        private Label Fragenzähler;
        private Button BTN_CANCEL;
        private Button BTN_FORWARD;
        private Label Fragekatalog;
        private Label WHO_IS_LOGGED_IN;
        private TextBox TB_Answer;
        private NumericUpDown MATH_NUM;
        private Button BTN_ERGEBNIS;
        private Button BTN_LOGOUT;
    }
}
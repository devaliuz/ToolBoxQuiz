namespace ToolBoxQuiz
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.UsernameDD = new System.Windows.Forms.ComboBox();
            this.TB_PASSWORD = new System.Windows.Forms.TextBox();
            this.BTN_LOGIN = new System.Windows.Forms.Button();
            this.Label_Check = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameDD
            // 
            this.UsernameDD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameDD.BackColor = System.Drawing.Color.PeachPuff;
            this.UsernameDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsernameDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsernameDD.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UsernameDD.FormattingEnabled = true;
            this.UsernameDD.Location = new System.Drawing.Point(64, 292);
            this.UsernameDD.MaximumSize = new System.Drawing.Size(287, 0);
            this.UsernameDD.Name = "UsernameDD";
            this.UsernameDD.Size = new System.Drawing.Size(287, 33);
            this.UsernameDD.TabIndex = 0;
            this.UsernameDD.SelectedIndexChanged += new System.EventHandler(this.Username_SelectedIndexChanged);
            // 
            // TB_PASSWORD
            // 
            this.TB_PASSWORD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_PASSWORD.BackColor = System.Drawing.Color.PeachPuff;
            this.TB_PASSWORD.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_PASSWORD.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TB_PASSWORD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TB_PASSWORD.Location = new System.Drawing.Point(64, 331);
            this.TB_PASSWORD.Name = "TB_PASSWORD";
            this.TB_PASSWORD.PasswordChar = '*';
            this.TB_PASSWORD.Size = new System.Drawing.Size(287, 33);
            this.TB_PASSWORD.TabIndex = 1;
            // 
            // BTN_LOGIN
            // 
            this.BTN_LOGIN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_LOGIN.BackColor = System.Drawing.Color.Transparent;
            this.BTN_LOGIN.BackgroundImage = global::ToolBoxQuiz.Properties.Resources.BTNgreen;
            this.BTN_LOGIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_LOGIN.FlatAppearance.BorderSize = 0;
            this.BTN_LOGIN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTN_LOGIN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTN_LOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_LOGIN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_LOGIN.Location = new System.Drawing.Point(241, 370);
            this.BTN_LOGIN.Name = "BTN_LOGIN";
            this.BTN_LOGIN.Size = new System.Drawing.Size(110, 46);
            this.BTN_LOGIN.TabIndex = 2;
            this.BTN_LOGIN.Text = "Login";
            this.BTN_LOGIN.UseVisualStyleBackColor = false;
            this.BTN_LOGIN.Click += new System.EventHandler(this.BTN_LOGIN_Click);
            // 
            // Label_Check
            // 
            this.Label_Check.AutoSize = true;
            this.Label_Check.BackColor = System.Drawing.Color.Transparent;
            this.Label_Check.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Check.Location = new System.Drawing.Point(12, 370);
            this.Label_Check.Name = "Label_Check";
            this.Label_Check.Size = new System.Drawing.Size(0, 25);
            this.Label_Check.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ToolBoxQuiz.Properties.Resources.ToolboxQuiz;
            this.pictureBox1.Location = new System.Drawing.Point(31, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ToolBoxQuiz.Properties.Resources.User;
            this.pictureBox2.Location = new System.Drawing.Point(12, 292);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(55, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::ToolBoxQuiz.Properties.Resources.key;
            this.pictureBox3.Location = new System.Drawing.Point(12, 331);
            this.pictureBox3.MaximumSize = new System.Drawing.Size(55, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::ToolBoxQuiz.Properties.Resources.Back;
            this.ClientSize = new System.Drawing.Size(368, 439);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Label_Check);
            this.Controls.Add(this.BTN_LOGIN);
            this.Controls.Add(this.TB_PASSWORD);
            this.Controls.Add(this.UsernameDD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(384, 478);
            this.MinimumSize = new System.Drawing.Size(384, 478);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toolbox-Quiz Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox UsernameDD;
        private TextBox TB_PASSWORD;
        private Button BTN_LOGIN;
        private Label Label_Check;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
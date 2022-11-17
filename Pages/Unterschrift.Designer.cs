namespace ToolBoxQuiz
{
    partial class Unterschrift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Unterschrift));
            this.BTN_VALIDATE = new System.Windows.Forms.Button();
            this.BTN_CANCEL = new System.Windows.Forms.Button();
            this.PB_SIGN = new System.Windows.Forms.PictureBox();
            this.BTN_CLEAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_SIGN)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_VALIDATE
            // 
            this.BTN_VALIDATE.BackColor = System.Drawing.Color.Transparent;
            this.BTN_VALIDATE.BackgroundImage = global::ToolBoxQuiz.Properties.Resources.BTNgreen1;
            this.BTN_VALIDATE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_VALIDATE.FlatAppearance.BorderSize = 0;
            this.BTN_VALIDATE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTN_VALIDATE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTN_VALIDATE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_VALIDATE.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_VALIDATE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_VALIDATE.Location = new System.Drawing.Point(525, 291);
            this.BTN_VALIDATE.Name = "BTN_VALIDATE";
            this.BTN_VALIDATE.Size = new System.Drawing.Size(213, 60);
            this.BTN_VALIDATE.TabIndex = 12;
            this.BTN_VALIDATE.Text = "Bestätigen";
            this.BTN_VALIDATE.UseVisualStyleBackColor = false;
            this.BTN_VALIDATE.Click += new System.EventHandler(this.BTN_VALIDATE_Click_1);
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
            this.BTN_CANCEL.Location = new System.Drawing.Point(12, 291);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(221, 64);
            this.BTN_CANCEL.TabIndex = 13;
            this.BTN_CANCEL.Text = "Abbrechen";
            this.BTN_CANCEL.UseVisualStyleBackColor = false;
            this.BTN_CANCEL.Click += new System.EventHandler(this.BTN_CANCEL_Click);
            // 
            // PB_SIGN
            // 
            this.PB_SIGN.Location = new System.Drawing.Point(12, 12);
            this.PB_SIGN.Name = "PB_SIGN";
            this.PB_SIGN.Size = new System.Drawing.Size(726, 262);
            this.PB_SIGN.TabIndex = 14;
            this.PB_SIGN.TabStop = false;
            this.PB_SIGN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_SIGN_MouseDown);
            this.PB_SIGN.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_SIGN_MouseMove);
            // 
            // BTN_CLEAR
            // 
            this.BTN_CLEAR.Location = new System.Drawing.Point(12, 12);
            this.BTN_CLEAR.Name = "BTN_CLEAR";
            this.BTN_CLEAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_CLEAR.TabIndex = 15;
            this.BTN_CLEAR.Text = "Reset";
            this.BTN_CLEAR.UseVisualStyleBackColor = true;
            this.BTN_CLEAR.Click += new System.EventHandler(this.BTN_CLEAR_Click);
            // 
            // Unterschrift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ToolBoxQuiz.Properties.Resources.Back;
            this.ClientSize = new System.Drawing.Size(750, 363);
            this.Controls.Add(this.BTN_CLEAR);
            this.Controls.Add(this.PB_SIGN);
            this.Controls.Add(this.BTN_CANCEL);
            this.Controls.Add(this.BTN_VALIDATE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "Unterschrift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unterschrift";
            ((System.ComponentModel.ISupportInitialize)(this.PB_SIGN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button BTN_VALIDATE;
        private Button BTN_CANCEL;
        private PictureBox PB_SIGN;
        private Button BTN_CLEAR;
    }
}
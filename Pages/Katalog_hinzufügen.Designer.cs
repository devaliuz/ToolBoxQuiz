namespace ToolBoxQuiz
{
    partial class Katalog_hinzufügen
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
            this.TB_TABLE_NAME = new System.Windows.Forms.TextBox();
            this.BTN_KH_ADD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_TABLE_NAME
            // 
            this.TB_TABLE_NAME.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_TABLE_NAME.Location = new System.Drawing.Point(45, 42);
            this.TB_TABLE_NAME.Name = "TB_TABLE_NAME";
            this.TB_TABLE_NAME.PlaceholderText = "Katalogname";
            this.TB_TABLE_NAME.Size = new System.Drawing.Size(183, 33);
            this.TB_TABLE_NAME.TabIndex = 0;
            // 
            // BTN_KH_ADD
            // 
            this.BTN_KH_ADD.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_KH_ADD.Location = new System.Drawing.Point(45, 95);
            this.BTN_KH_ADD.Name = "BTN_KH_ADD";
            this.BTN_KH_ADD.Size = new System.Drawing.Size(183, 76);
            this.BTN_KH_ADD.TabIndex = 2;
            this.BTN_KH_ADD.Text = "Katalog\r\nhinzufügen";
            this.BTN_KH_ADD.UseVisualStyleBackColor = true;
            this.BTN_KH_ADD.Click += new System.EventHandler(this.BTN_KH_ADD_Click);
            // 
            // Katalog_hinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(279, 203);
            this.Controls.Add(this.BTN_KH_ADD);
            this.Controls.Add(this.TB_TABLE_NAME);
            this.Name = "Katalog_hinzufügen";
            this.Text = "Katalog_hinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TB_TABLE_NAME;
        private Button BTN_KH_ADD;
    }
}
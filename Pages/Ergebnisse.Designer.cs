namespace ToolBoxQuiz
{
    partial class Ergebnisse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ergebnisse));
            this.Ergebnisliste = new System.Windows.Forms.ListBox();
            this.BTN_FORWARD = new System.Windows.Forms.Button();
            this.PB_SHOW_SIGN = new System.Windows.Forms.PictureBox();
            this.Dateiname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_SHOW_SIGN)).BeginInit();
            this.SuspendLayout();
            // 
            // Ergebnisliste
            // 
            this.Ergebnisliste.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Ergebnisliste.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ergebnisliste.FormattingEnabled = true;
            this.Ergebnisliste.ItemHeight = 25;
            this.Ergebnisliste.Location = new System.Drawing.Point(12, 12);
            this.Ergebnisliste.Name = "Ergebnisliste";
            this.Ergebnisliste.Size = new System.Drawing.Size(776, 354);
            this.Ergebnisliste.TabIndex = 0;
            this.Ergebnisliste.SelectedIndexChanged += new System.EventHandler(this.Ergebnisliste_SelectedIndexChanged);
            // 
            // BTN_FORWARD
            // 
            this.BTN_FORWARD.BackColor = System.Drawing.Color.Transparent;
            this.BTN_FORWARD.BackgroundImage = global::ToolBoxQuiz.Properties.Resources.BTNred;
            this.BTN_FORWARD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_FORWARD.FlatAppearance.BorderSize = 0;
            this.BTN_FORWARD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTN_FORWARD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTN_FORWARD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_FORWARD.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_FORWARD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_FORWARD.Location = new System.Drawing.Point(475, 663);
            this.BTN_FORWARD.Name = "BTN_FORWARD";
            this.BTN_FORWARD.Size = new System.Drawing.Size(263, 80);
            this.BTN_FORWARD.TabIndex = 11;
            this.BTN_FORWARD.Text = "Schliessen";
            this.BTN_FORWARD.UseVisualStyleBackColor = false;
            this.BTN_FORWARD.Click += new System.EventHandler(this.BTN_FORWARD_Click);
            // 
            // PB_SHOW_SIGN
            // 
            this.PB_SHOW_SIGN.Location = new System.Drawing.Point(28, 395);
            this.PB_SHOW_SIGN.Name = "PB_SHOW_SIGN";
            this.PB_SHOW_SIGN.Size = new System.Drawing.Size(726, 262);
            this.PB_SHOW_SIGN.TabIndex = 15;
            this.PB_SHOW_SIGN.TabStop = false;
            // 
            // Dateiname
            // 
            this.Dateiname.AutoSize = true;
            this.Dateiname.Location = new System.Drawing.Point(28, 642);
            this.Dateiname.Name = "Dateiname";
            this.Dateiname.Size = new System.Drawing.Size(0, 15);
            this.Dateiname.TabIndex = 16;
            // 
            // Ergebnisse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::ToolBoxQuiz.Properties.Resources.Back;
            this.ClientSize = new System.Drawing.Size(800, 758);
            this.Controls.Add(this.Dateiname);
            this.Controls.Add(this.PB_SHOW_SIGN);
            this.Controls.Add(this.BTN_FORWARD);
            this.Controls.Add(this.Ergebnisliste);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ergebnisse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ergebnisse";
            ((System.ComponentModel.ISupportInitialize)(this.PB_SHOW_SIGN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox Ergebnisliste;
        private Button BTN_FORWARD;
        private PictureBox PB_SHOW_SIGN;
        private Label Dateiname;
    }
}
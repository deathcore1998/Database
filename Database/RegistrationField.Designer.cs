namespace Database
{
    partial class RegistrationField
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
            this.fioField = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ageField = new System.Windows.Forms.TextBox();
            this.workplaceField = new System.Windows.Forms.TextBox();
            this.RegistrationPers = new System.Windows.Forms.Button();
            this.CreatAndAddScore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fioField
            // 
            this.fioField.Location = new System.Drawing.Point(114, 46);
            this.fioField.Multiline = true;
            this.fioField.Name = "fioField";
            this.fioField.Size = new System.Drawing.Size(150, 38);
            this.fioField.TabIndex = 0;
            this.fioField.Enter += new System.EventHandler(this.fioField_Enter);
            this.fioField.Leave += new System.EventHandler(this.fioField_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ageField
            // 
            this.ageField.Location = new System.Drawing.Point(114, 113);
            this.ageField.Multiline = true;
            this.ageField.Name = "ageField";
            this.ageField.Size = new System.Drawing.Size(150, 38);
            this.ageField.TabIndex = 2;
            this.ageField.Enter += new System.EventHandler(this.ageField_Enter);
            this.ageField.Leave += new System.EventHandler(this.ageField_Leave);
            // 
            // workplaceField
            // 
            this.workplaceField.Location = new System.Drawing.Point(114, 192);
            this.workplaceField.Multiline = true;
            this.workplaceField.Name = "workplaceField";
            this.workplaceField.Size = new System.Drawing.Size(150, 38);
            this.workplaceField.TabIndex = 3;
            this.workplaceField.Enter += new System.EventHandler(this.workplaceField_Enter);
            this.workplaceField.Leave += new System.EventHandler(this.workplaceField_Leave);
            // 
            // RegistrationPers
            // 
            this.RegistrationPers.Location = new System.Drawing.Point(114, 271);
            this.RegistrationPers.Name = "RegistrationPers";
            this.RegistrationPers.Size = new System.Drawing.Size(150, 30);
            this.RegistrationPers.TabIndex = 4;
            this.RegistrationPers.Text = "Зарегистрироваться";
            this.RegistrationPers.UseVisualStyleBackColor = true;
            this.RegistrationPers.Click += new System.EventHandler(this.RegistrationPers_Click);
            // 
            // CreatAndAddScore
            // 
            this.CreatAndAddScore.Location = new System.Drawing.Point(337, 271);
            this.CreatAndAddScore.Name = "CreatAndAddScore";
            this.CreatAndAddScore.Size = new System.Drawing.Size(150, 30);
            this.CreatAndAddScore.TabIndex = 6;
            this.CreatAndAddScore.Text = "Действия со счетом";
            this.CreatAndAddScore.UseMnemonic = false;
            this.CreatAndAddScore.UseVisualStyleBackColor = true;
            this.CreatAndAddScore.Click += new System.EventHandler(this.CreatAndAddScore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Начальная Форма";
            // 
            // RegistrationField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreatAndAddScore);
            this.Controls.Add(this.RegistrationPers);
            this.Controls.Add(this.workplaceField);
            this.Controls.Add(this.ageField);
            this.Controls.Add(this.fioField);
            this.Name = "RegistrationField";
            this.Text = "RegistrationField";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fioField;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox ageField;
        private System.Windows.Forms.TextBox workplaceField;
        private System.Windows.Forms.Button RegistrationPers;
        private System.Windows.Forms.Button CreatAndAddScore;
        private System.Windows.Forms.Label label1;
    }
}
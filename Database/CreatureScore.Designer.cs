namespace Database
{
    partial class CreatureScore
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
            this.AddNewScore = new System.Windows.Forms.Button();
            this.DeleteScore = new System.Windows.Forms.Button();
            this.AddMoneyToScore = new System.Windows.Forms.Button();
            this.TekeMoneyToScore = new System.Windows.Forms.Button();
            this.TakeInfoScore = new System.Windows.Forms.Button();
            this.ValueForAddMoney = new System.Windows.Forms.TextBox();
            this.ValueForTakeMoney = new System.Windows.Forms.TextBox();
            this.IndexForAction = new System.Windows.Forms.TextBox();
            this.balanceNewScore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.indexPersonScore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddNewScore
            // 
            this.AddNewScore.Location = new System.Drawing.Point(8, 288);
            this.AddNewScore.Name = "AddNewScore";
            this.AddNewScore.Size = new System.Drawing.Size(100, 40);
            this.AddNewScore.TabIndex = 0;
            this.AddNewScore.Text = "Создать новый счет";
            this.AddNewScore.UseVisualStyleBackColor = true;
            this.AddNewScore.Click += new System.EventHandler(this.AddNewScore_Click);
            // 
            // DeleteScore
            // 
            this.DeleteScore.Location = new System.Drawing.Point(417, 141);
            this.DeleteScore.Name = "DeleteScore";
            this.DeleteScore.Size = new System.Drawing.Size(100, 40);
            this.DeleteScore.TabIndex = 1;
            this.DeleteScore.Text = "Удалить счет";
            this.DeleteScore.UseVisualStyleBackColor = true;
            this.DeleteScore.Click += new System.EventHandler(this.DeleteScore_Click);
            // 
            // AddMoneyToScore
            // 
            this.AddMoneyToScore.Location = new System.Drawing.Point(417, 230);
            this.AddMoneyToScore.Name = "AddMoneyToScore";
            this.AddMoneyToScore.Size = new System.Drawing.Size(100, 40);
            this.AddMoneyToScore.TabIndex = 2;
            this.AddMoneyToScore.Text = "Пополнить счет";
            this.AddMoneyToScore.UseVisualStyleBackColor = true;
            this.AddMoneyToScore.Click += new System.EventHandler(this.AddMoneyToScore_Click);
            // 
            // TekeMoneyToScore
            // 
            this.TekeMoneyToScore.Location = new System.Drawing.Point(417, 302);
            this.TekeMoneyToScore.Name = "TekeMoneyToScore";
            this.TekeMoneyToScore.Size = new System.Drawing.Size(100, 40);
            this.TekeMoneyToScore.TabIndex = 3;
            this.TekeMoneyToScore.Text = "Снять деньги";
            this.TekeMoneyToScore.UseVisualStyleBackColor = true;
            this.TekeMoneyToScore.Click += new System.EventHandler(this.TekeMoneyToScore_Click);
            // 
            // TakeInfoScore
            // 
            this.TakeInfoScore.Location = new System.Drawing.Point(417, 68);
            this.TakeInfoScore.Name = "TakeInfoScore";
            this.TakeInfoScore.Size = new System.Drawing.Size(100, 40);
            this.TakeInfoScore.TabIndex = 4;
            this.TakeInfoScore.Text = "Посмотреть баланс";
            this.TakeInfoScore.UseVisualStyleBackColor = true;
            this.TakeInfoScore.Click += new System.EventHandler(this.TakeInfoScore_Click);
            // 
            // ValueForAddMoney
            // 
            this.ValueForAddMoney.Location = new System.Drawing.Point(534, 227);
            this.ValueForAddMoney.Multiline = true;
            this.ValueForAddMoney.Name = "ValueForAddMoney";
            this.ValueForAddMoney.Size = new System.Drawing.Size(150, 40);
            this.ValueForAddMoney.TabIndex = 9;
            this.ValueForAddMoney.Enter += new System.EventHandler(this.ValueForAddMoney_Enter);
            this.ValueForAddMoney.Leave += new System.EventHandler(this.ValueForAddMoney_Leave);
            // 
            // ValueForTakeMoney
            // 
            this.ValueForTakeMoney.Location = new System.Drawing.Point(534, 303);
            this.ValueForTakeMoney.Multiline = true;
            this.ValueForTakeMoney.Name = "ValueForTakeMoney";
            this.ValueForTakeMoney.Size = new System.Drawing.Size(150, 40);
            this.ValueForTakeMoney.TabIndex = 10;
            this.ValueForTakeMoney.Enter += new System.EventHandler(this.ValueForTakeMoney_Enter);
            this.ValueForTakeMoney.Leave += new System.EventHandler(this.ValueForTakeMoney_Leave);
            // 
            // IndexForAction
            // 
            this.IndexForAction.Location = new System.Drawing.Point(109, 88);
            this.IndexForAction.Multiline = true;
            this.IndexForAction.Name = "IndexForAction";
            this.IndexForAction.Size = new System.Drawing.Size(150, 63);
            this.IndexForAction.TabIndex = 12;
            this.IndexForAction.Enter += new System.EventHandler(this.IndexForAction_Enter);
            this.IndexForAction.Leave += new System.EventHandler(this.IndexForAction_Leave);
            // 
            // balanceNewScore
            // 
            this.balanceNewScore.Location = new System.Drawing.Point(248, 288);
            this.balanceNewScore.Multiline = true;
            this.balanceNewScore.Name = "balanceNewScore";
            this.balanceNewScore.Size = new System.Drawing.Size(150, 40);
            this.balanceNewScore.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(118, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 58);
            this.label1.TabIndex = 14;
            this.label1.Text = "Введите начальную сумму на счете";
            // 
            // indexPersonScore
            // 
            this.indexPersonScore.Location = new System.Drawing.Point(109, 185);
            this.indexPersonScore.Multiline = true;
            this.indexPersonScore.Name = "indexPersonScore";
            this.indexPersonScore.Size = new System.Drawing.Size(150, 40);
            this.indexPersonScore.TabIndex = 15;
            this.indexPersonScore.Enter += new System.EventHandler(this.indexPersonScore_Enter);
            this.indexPersonScore.Leave += new System.EventHandler(this.indexPersonScore_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID персоны";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "ID счета";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(181, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Форма для работы со счетами";
            // 
            // CreatureScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 365);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.indexPersonScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.balanceNewScore);
            this.Controls.Add(this.IndexForAction);
            this.Controls.Add(this.ValueForTakeMoney);
            this.Controls.Add(this.ValueForAddMoney);
            this.Controls.Add(this.TakeInfoScore);
            this.Controls.Add(this.TekeMoneyToScore);
            this.Controls.Add(this.AddMoneyToScore);
            this.Controls.Add(this.DeleteScore);
            this.Controls.Add(this.AddNewScore);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "CreatureScore";
            this.Text = "CreatureScore";
            this.Load += new System.EventHandler(this.CreatureScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewScore;
        private System.Windows.Forms.Button DeleteScore;
        private System.Windows.Forms.Button AddMoneyToScore;
        private System.Windows.Forms.Button TekeMoneyToScore;
        private System.Windows.Forms.Button TakeInfoScore;
        private System.Windows.Forms.TextBox ValueForAddMoney;
        private System.Windows.Forms.TextBox ValueForTakeMoney;
        private System.Windows.Forms.TextBox IndexForAction;
        private System.Windows.Forms.TextBox balanceNewScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox indexPersonScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
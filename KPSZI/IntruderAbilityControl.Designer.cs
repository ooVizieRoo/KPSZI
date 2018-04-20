namespace KPSZI
{
    partial class IntruderAbilityControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.cbCompet = new System.Windows.Forms.ComboBox();
            this.cbProject = new System.Windows.Forms.ComboBox();
            this.cbAccess = new System.Windows.Forms.ComboBox();
            this.cbOsnast = new System.Windows.Forms.ComboBox();
            this.lbNameOfThreat = new System.Windows.Forms.Label();
            this.lbTCUInTCUIType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Затрачиваемое время";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Техническая компетентность нарушителя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(297, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Знание проекта информационной системы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(297, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Возможность доступа к ИС";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Оснащенность нарушителя";
            // 
            // cbTime
            // 
            this.cbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "Менее 0,5 часа",
            "Менее 1 дня",
            "Менее 1 месяца",
            "Более 1 месяца"});
            this.cbTime.Location = new System.Drawing.Point(9, 104);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(176, 21);
            this.cbTime.TabIndex = 5;
            // 
            // cbCompet
            // 
            this.cbCompet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompet.FormattingEnabled = true;
            this.cbCompet.Items.AddRange(new object[] {
            "Непрофессионал",
            "Специалист",
            "Профессионал"});
            this.cbCompet.Location = new System.Drawing.Point(9, 163);
            this.cbCompet.Name = "cbCompet";
            this.cbCompet.Size = new System.Drawing.Size(176, 21);
            this.cbCompet.TabIndex = 6;
            // 
            // cbProject
            // 
            this.cbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Items.AddRange(new object[] {
            "Отсутствие знаний",
            "Ограниченные знания",
            "Знание чувствительной информации"});
            this.cbProject.Location = new System.Drawing.Point(300, 104);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(176, 21);
            this.cbProject.TabIndex = 7;
            // 
            // cbAccess
            // 
            this.cbAccess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccess.FormattingEnabled = true;
            this.cbAccess.Items.AddRange(new object[] {
            "Менее 0,5 часа или необнаруживаемый доступ",
            "Менее 1 дня",
            "Менее 1 месяца",
            "Более 1 месяца",
            "Невозможно"});
            this.cbAccess.Location = new System.Drawing.Point(300, 165);
            this.cbAccess.Name = "cbAccess";
            this.cbAccess.Size = new System.Drawing.Size(176, 21);
            this.cbAccess.TabIndex = 8;
            // 
            // cbOsnast
            // 
            this.cbOsnast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOsnast.FormattingEnabled = true;
            this.cbOsnast.Items.AddRange(new object[] {
            "Отсутствует",
            "Стандартное оборудование",
            "Специализированное оборудование",
            "Оборудование, сделанное на заказ"});
            this.cbOsnast.Location = new System.Drawing.Point(9, 221);
            this.cbOsnast.Name = "cbOsnast";
            this.cbOsnast.Size = new System.Drawing.Size(176, 21);
            this.cbOsnast.TabIndex = 9;
            // 
            // lbNameOfThreat
            // 
            this.lbNameOfThreat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNameOfThreat.Location = new System.Drawing.Point(6, 4);
            this.lbNameOfThreat.Name = "lbNameOfThreat";
            this.lbNameOfThreat.Size = new System.Drawing.Size(521, 53);
            this.lbNameOfThreat.TabIndex = 10;
            this.lbNameOfThreat.Text = "label6";
            // 
            // lbTCUInTCUIType
            // 
            this.lbTCUInTCUIType.Location = new System.Drawing.Point(6, 57);
            this.lbTCUInTCUIType.Name = "lbTCUInTCUIType";
            this.lbTCUInTCUIType.Size = new System.Drawing.Size(546, 15);
            this.lbTCUInTCUIType.TabIndex = 11;
            this.lbTCUInTCUIType.Text = "label6";
            // 
            // IntruderAbilityControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbTCUInTCUIType);
            this.Controls.Add(this.lbNameOfThreat);
            this.Controls.Add(this.cbOsnast);
            this.Controls.Add(this.cbAccess);
            this.Controls.Add(this.cbProject);
            this.Controls.Add(this.cbCompet);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IntruderAbilityControl";
            this.Size = new System.Drawing.Size(568, 246);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.ComboBox cbCompet;
        private System.Windows.Forms.ComboBox cbProject;
        private System.Windows.Forms.ComboBox cbAccess;
        private System.Windows.Forms.ComboBox cbOsnast;
        private System.Windows.Forms.Label lbNameOfThreat;
        private System.Windows.Forms.Label lbTCUInTCUIType;
    }
}

namespace KPSZI
{
    partial class FillThreatsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvThreats = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpFillVulnerabilities = new System.Windows.Forms.TabPage();
            this.tpFillImplementWays = new System.Windows.Forms.TabPage();
            this.splitter = new System.Windows.Forms.Splitter();
            this.tpSFHs = new System.Windows.Forms.TabPage();
            this.dgvVulnerabilities = new System.Windows.Forms.DataGridView();
            this.CheckVulnerability = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clbImplementWays = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThreats)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tpFillVulnerabilities.SuspendLayout();
            this.tpFillImplementWays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVulnerabilities)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThreats
            // 
            this.dgvThreats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThreats.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvThreats.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvThreats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThreats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvThreats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThreats.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvThreats.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvThreats.EnableHeadersVisualStyles = false;
            this.dgvThreats.Location = new System.Drawing.Point(0, 0);
            this.dgvThreats.MultiSelect = false;
            this.dgvThreats.Name = "dgvThreats";
            this.dgvThreats.ReadOnly = true;
            this.dgvThreats.RowHeadersVisible = false;
            this.dgvThreats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThreats.Size = new System.Drawing.Size(957, 285);
            this.dgvThreats.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpFillVulnerabilities);
            this.tabControl.Controls.Add(this.tpFillImplementWays);
            this.tabControl.Controls.Add(this.tpSFHs);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 285);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(957, 312);
            this.tabControl.TabIndex = 2;
            // 
            // tpFillVulnerabilities
            // 
            this.tpFillVulnerabilities.Controls.Add(this.dgvVulnerabilities);
            this.tpFillVulnerabilities.Location = new System.Drawing.Point(4, 22);
            this.tpFillVulnerabilities.Name = "tpFillVulnerabilities";
            this.tpFillVulnerabilities.Padding = new System.Windows.Forms.Padding(3);
            this.tpFillVulnerabilities.Size = new System.Drawing.Size(949, 286);
            this.tpFillVulnerabilities.TabIndex = 0;
            this.tpFillVulnerabilities.Text = "Уязвимости ИС";
            this.tpFillVulnerabilities.UseVisualStyleBackColor = true;
            // 
            // tpFillImplementWays
            // 
            this.tpFillImplementWays.Controls.Add(this.clbImplementWays);
            this.tpFillImplementWays.Location = new System.Drawing.Point(4, 22);
            this.tpFillImplementWays.Name = "tpFillImplementWays";
            this.tpFillImplementWays.Padding = new System.Windows.Forms.Padding(3);
            this.tpFillImplementWays.Size = new System.Drawing.Size(949, 286);
            this.tpFillImplementWays.TabIndex = 1;
            this.tpFillImplementWays.Text = "Способы реализации УБИ";
            this.tpFillImplementWays.UseVisualStyleBackColor = true;
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter.Location = new System.Drawing.Point(0, 285);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(957, 3);
            this.splitter.TabIndex = 3;
            this.splitter.TabStop = false;
            // 
            // tpSFHs
            // 
            this.tpSFHs.Location = new System.Drawing.Point(4, 22);
            this.tpSFHs.Name = "tpSFHs";
            this.tpSFHs.Size = new System.Drawing.Size(949, 286);
            this.tpSFHs.TabIndex = 2;
            this.tpSFHs.Text = "СФХ";
            this.tpSFHs.UseVisualStyleBackColor = true;
            // 
            // dgvVulnerabilities
            // 
            this.dgvVulnerabilities.AllowUserToAddRows = false;
            this.dgvVulnerabilities.AllowUserToDeleteRows = false;
            this.dgvVulnerabilities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVulnerabilities.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvVulnerabilities.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvVulnerabilities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVulnerabilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVulnerabilities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckVulnerability});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVulnerabilities.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvVulnerabilities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVulnerabilities.Location = new System.Drawing.Point(3, 3);
            this.dgvVulnerabilities.MinimumSize = new System.Drawing.Size(500, 0);
            this.dgvVulnerabilities.Name = "dgvVulnerabilities";
            this.dgvVulnerabilities.RowHeadersVisible = false;
            this.dgvVulnerabilities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvVulnerabilities.ShowCellToolTips = false;
            this.dgvVulnerabilities.ShowEditingIcon = false;
            this.dgvVulnerabilities.Size = new System.Drawing.Size(943, 280);
            this.dgvVulnerabilities.TabIndex = 1;
            // 
            // CheckVulnerability
            // 
            this.CheckVulnerability.HeaderText = "";
            this.CheckVulnerability.Name = "CheckVulnerability";
            this.CheckVulnerability.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckVulnerability.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clbImplementWays
            // 
            this.clbImplementWays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.clbImplementWays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbImplementWays.FormattingEnabled = true;
            this.clbImplementWays.Location = new System.Drawing.Point(8, 6);
            this.clbImplementWays.Name = "clbImplementWays";
            this.clbImplementWays.Size = new System.Drawing.Size(430, 240);
            this.clbImplementWays.TabIndex = 3;
            // 
            // FillThreatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 597);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.dgvThreats);
            this.Name = "FillThreatsForm";
            this.Text = "FillThreatsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThreats)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tpFillVulnerabilities.ResumeLayout(false);
            this.tpFillImplementWays.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVulnerabilities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvThreats;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpFillVulnerabilities;
        private System.Windows.Forms.TabPage tpFillImplementWays;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.TabPage tpSFHs;
        internal System.Windows.Forms.DataGridView dgvVulnerabilities;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckVulnerability;
        internal System.Windows.Forms.CheckedListBox clbImplementWays;
    }
}
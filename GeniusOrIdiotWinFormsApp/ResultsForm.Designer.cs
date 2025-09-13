namespace GeniusOrIdiotWinFormsApp
{
    partial class ResultsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            ResultsGridView = new DataGridView();
            userNameColumn = new DataGridViewTextBoxColumn();
            correctAnswersCountColumn = new DataGridViewTextBoxColumn();
            DiagnoseColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ResultsGridView).BeginInit();
            SuspendLayout();
            // 
            // ResultsGridView
            // 
            ResultsGridView.AllowUserToAddRows = false;
            ResultsGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new Font("Cambria Math", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ResultsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ResultsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ResultsGridView.Columns.AddRange(new DataGridViewColumn[] { userNameColumn, correctAnswersCountColumn, DiagnoseColumn });
            ResultsGridView.Dock = DockStyle.Top;
            ResultsGridView.Location = new Point(0, 0);
            ResultsGridView.Name = "ResultsGridView";
            ResultsGridView.ReadOnly = true;
            ResultsGridView.Size = new Size(375, 440);
            ResultsGridView.TabIndex = 0;
            // 
            // userNameColumn
            // 
            userNameColumn.HeaderText = "Имя";
            userNameColumn.Name = "userNameColumn";
            userNameColumn.ReadOnly = true;
            // 
            // correctAnswersCountColumn
            // 
            correctAnswersCountColumn.HeaderText = "Кол-во правильных ответов";
            correctAnswersCountColumn.Name = "correctAnswersCountColumn";
            correctAnswersCountColumn.ReadOnly = true;
            // 
            // DiagnoseColumn
            // 
            DiagnoseColumn.HeaderText = "Диагноз";
            DiagnoseColumn.Name = "DiagnoseColumn";
            DiagnoseColumn.ReadOnly = true;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 440);
            Controls.Add(ResultsGridView);
            MaximizeBox = false;
            Name = "ResultsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Результаты";
            Load += ResultsForm_Load;
            ((System.ComponentModel.ISupportInitialize)ResultsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ResultsGridView;
        private DataGridViewTextBoxColumn userNameColumn;
        private DataGridViewTextBoxColumn correctAnswersCountColumn;
        private DataGridViewTextBoxColumn DiagnoseColumn;
    }
}
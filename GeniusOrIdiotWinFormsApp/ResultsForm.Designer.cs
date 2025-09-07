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
            resultsGridView = new DataGridView();
            userNameColumn = new DataGridViewTextBoxColumn();
            correctAnswersCountColumn = new DataGridViewTextBoxColumn();
            DiagnoseColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)resultsGridView).BeginInit();
            SuspendLayout();
            // 
            // resultsGridView
            // 
            dataGridViewCellStyle1.Font = new Font("Cambria Math", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            resultsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resultsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsGridView.Columns.AddRange(new DataGridViewColumn[] { userNameColumn, correctAnswersCountColumn, DiagnoseColumn });
            resultsGridView.Dock = DockStyle.Fill;
            resultsGridView.Location = new Point(0, 0);
            resultsGridView.Name = "resultsGridView";
            resultsGridView.Size = new Size(375, 440);
            resultsGridView.TabIndex = 0;
            // 
            // userNameColumn
            // 
            userNameColumn.HeaderText = "Имя";
            userNameColumn.Name = "userNameColumn";
            // 
            // correctAnswersCountColumn
            // 
            correctAnswersCountColumn.HeaderText = "Кол-во правильных ответов";
            correctAnswersCountColumn.Name = "correctAnswersCountColumn";
            // 
            // DiagnoseColumn
            // 
            DiagnoseColumn.HeaderText = "Диагноз";
            DiagnoseColumn.Name = "DiagnoseColumn";
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 440);
            Controls.Add(resultsGridView);
            Name = "ResultsForm";
            Text = "Результаты";
            Load += ResultsForm_Load;
            ((System.ComponentModel.ISupportInitialize)resultsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView resultsGridView;
        private DataGridViewTextBoxColumn userNameColumn;
        private DataGridViewTextBoxColumn correctAnswersCountColumn;
        private DataGridViewTextBoxColumn DiagnoseColumn;
    }
}
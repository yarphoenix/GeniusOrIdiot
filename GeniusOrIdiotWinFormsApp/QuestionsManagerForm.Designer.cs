namespace GeniusOrIdiotWinFormsApp
{
    partial class QuestionsManagerForm
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
            components = new System.ComponentModel.Container();
            QuestionsGridView = new DataGridView();
            QuestionTextColumn = new DataGridViewTextBoxColumn();
            AnswerColumn = new DataGridViewTextBoxColumn();
            DeleteQuestionMenuStrip = new ContextMenuStrip(components);
            DeleteQuestionToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            AddQuestionButton = new Button();
            AnswerLabel = new Label();
            AnswerTextBox = new TextBox();
            QuestionTextBox = new TextBox();
            QuestionTextLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)QuestionsGridView).BeginInit();
            DeleteQuestionMenuStrip.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // QuestionsGridView
            // 
            QuestionsGridView.AllowUserToAddRows = false;
            QuestionsGridView.AllowUserToDeleteRows = false;
            QuestionsGridView.BackgroundColor = Color.LightGray;
            QuestionsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            QuestionsGridView.Columns.AddRange(new DataGridViewColumn[] { QuestionTextColumn, AnswerColumn });
            QuestionsGridView.ContextMenuStrip = DeleteQuestionMenuStrip;
            QuestionsGridView.Cursor = Cursors.Hand;
            QuestionsGridView.Dock = DockStyle.Top;
            QuestionsGridView.Location = new Point(0, 0);
            QuestionsGridView.Name = "QuestionsGridView";
            QuestionsGridView.ReadOnly = true;
            QuestionsGridView.Size = new Size(623, 230);
            QuestionsGridView.TabIndex = 0;
            QuestionsGridView.CellMouseDown += QuestionsGridView_CellMouseDown;
            // 
            // QuestionTextColumn
            // 
            QuestionTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            QuestionTextColumn.HeaderText = "Текст вопроса";
            QuestionTextColumn.Name = "QuestionTextColumn";
            QuestionTextColumn.ReadOnly = true;
            // 
            // AnswerColumn
            // 
            AnswerColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            AnswerColumn.HeaderText = "Ответ";
            AnswerColumn.Name = "AnswerColumn";
            AnswerColumn.ReadOnly = true;
            AnswerColumn.Width = 64;
            // 
            // DeleteQuestionMenuStrip
            // 
            DeleteQuestionMenuStrip.Font = new Font("Cambria", 9F);
            DeleteQuestionMenuStrip.Items.AddRange(new ToolStripItem[] { DeleteQuestionToolStripMenuItem });
            DeleteQuestionMenuStrip.Name = "contextMenuStrip1";
            DeleteQuestionMenuStrip.Size = new Size(160, 26);
            // 
            // DeleteQuestionToolStripMenuItem
            // 
            DeleteQuestionToolStripMenuItem.Image = Properties.Resources.delete_forever_24dp_000000;
            DeleteQuestionToolStripMenuItem.Name = "DeleteQuestionToolStripMenuItem";
            DeleteQuestionToolStripMenuItem.Size = new Size(159, 22);
            DeleteQuestionToolStripMenuItem.Text = "Удалить вопрос";
            DeleteQuestionToolStripMenuItem.Click += DeleteQuestionToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AddQuestionButton);
            groupBox1.Controls.Add(AnswerLabel);
            groupBox1.Controls.Add(AnswerTextBox);
            groupBox1.Controls.Add(QuestionTextBox);
            groupBox1.Controls.Add(QuestionTextLabel);
            groupBox1.Location = new Point(12, 236);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(599, 77);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавить вопрос в список";
            // 
            // AddQuestionButton
            // 
            AddQuestionButton.Location = new Point(487, 26);
            AddQuestionButton.Name = "AddQuestionButton";
            AddQuestionButton.Size = new Size(90, 34);
            AddQuestionButton.TabIndex = 3;
            AddQuestionButton.Text = "Добавить";
            AddQuestionButton.UseVisualStyleBackColor = true;
            // 
            // AnswerLabel
            // 
            AnswerLabel.AutoSize = true;
            AnswerLabel.Location = new Point(375, 36);
            AnswerLabel.Name = "AnswerLabel";
            AnswerLabel.Size = new Size(39, 14);
            AnswerLabel.TabIndex = 2;
            AnswerLabel.Text = "Ответ";
            // 
            // AnswerTextBox
            // 
            AnswerTextBox.Location = new Point(420, 33);
            AnswerTextBox.Name = "AnswerTextBox";
            AnswerTextBox.Size = new Size(61, 22);
            AnswerTextBox.TabIndex = 1;
            // 
            // QuestionTextBox
            // 
            QuestionTextBox.Location = new Point(62, 33);
            QuestionTextBox.Name = "QuestionTextBox";
            QuestionTextBox.Size = new Size(307, 22);
            QuestionTextBox.TabIndex = 1;
            // 
            // QuestionTextLabel
            // 
            QuestionTextLabel.AutoSize = true;
            QuestionTextLabel.Location = new Point(20, 36);
            QuestionTextLabel.Name = "QuestionTextLabel";
            QuestionTextLabel.Size = new Size(36, 14);
            QuestionTextLabel.TabIndex = 0;
            QuestionTextLabel.Text = "Текст";
            // 
            // QuestionsManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 327);
            Controls.Add(groupBox1);
            Controls.Add(QuestionsGridView);
            Font = new Font("Cambria", 9F);
            Name = "QuestionsManagerForm";
            Text = "Менеджер вопросов";
            Load += QuestionsManagerForm_Load;
            ((System.ComponentModel.ISupportInitialize)QuestionsGridView).EndInit();
            DeleteQuestionMenuStrip.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView QuestionsGridView;
        private GroupBox groupBox1;
        private Label QuestionTextLabel;
        private TextBox QuestionTextBox;
        private Label AnswerLabel;
        private TextBox AnswerTextBox;
        private Button AddQuestionButton;
        private DataGridViewTextBoxColumn QuestionTextColumn;
        private DataGridViewTextBoxColumn AnswerColumn;
        private ContextMenuStrip DeleteQuestionMenuStrip;
        private ToolStripMenuItem DeleteQuestionToolStripMenuItem;
    }
}
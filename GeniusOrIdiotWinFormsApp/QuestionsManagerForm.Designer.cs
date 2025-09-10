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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionsManagerForm));
            QuestionsGridView = new DataGridView();
            QuestionTextColumn = new DataGridViewTextBoxColumn();
            AnswerColumn = new DataGridViewTextBoxColumn();
            DeleteQuestionMenuStrip = new ContextMenuStrip(components);
            DeleteQuestionToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            ErrorLabel = new Label();
            AddQuestionButton = new Button();
            AnswerLabel = new Label();
            AnswerTextBox = new TextBox();
            QuestionTextBox = new TextBox();
            QuestionTextLabel = new Label();
            toolTipValidation = new ToolTip(components);
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
            resources.ApplyResources(QuestionsGridView, "QuestionsGridView");
            QuestionsGridView.Name = "QuestionsGridView";
            QuestionsGridView.ReadOnly = true;
            // 
            // QuestionTextColumn
            // 
            QuestionTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(QuestionTextColumn, "QuestionTextColumn");
            QuestionTextColumn.Name = "QuestionTextColumn";
            QuestionTextColumn.ReadOnly = true;
            // 
            // AnswerColumn
            // 
            AnswerColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            resources.ApplyResources(AnswerColumn, "AnswerColumn");
            AnswerColumn.Name = "AnswerColumn";
            AnswerColumn.ReadOnly = true;
            // 
            // DeleteQuestionMenuStrip
            // 
            resources.ApplyResources(DeleteQuestionMenuStrip, "DeleteQuestionMenuStrip");
            DeleteQuestionMenuStrip.Items.AddRange(new ToolStripItem[] { DeleteQuestionToolStripMenuItem });
            DeleteQuestionMenuStrip.Name = "contextMenuStrip1";
            // 
            // DeleteQuestionToolStripMenuItem
            // 
            DeleteQuestionToolStripMenuItem.Image = Properties.Resources.delete_forever_24dp_000000;
            DeleteQuestionToolStripMenuItem.Name = "DeleteQuestionToolStripMenuItem";
            resources.ApplyResources(DeleteQuestionToolStripMenuItem, "DeleteQuestionToolStripMenuItem");
            DeleteQuestionToolStripMenuItem.Click += DeleteQuestionToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ErrorLabel);
            groupBox1.Controls.Add(AddQuestionButton);
            groupBox1.Controls.Add(AnswerLabel);
            groupBox1.Controls.Add(AnswerTextBox);
            groupBox1.Controls.Add(QuestionTextBox);
            groupBox1.Controls.Add(QuestionTextLabel);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // ErrorLabel
            // 
            resources.ApplyResources(ErrorLabel, "ErrorLabel");
            ErrorLabel.ForeColor = Color.DarkRed;
            ErrorLabel.Name = "ErrorLabel";
            // 
            // AddQuestionButton
            // 
            resources.ApplyResources(AddQuestionButton, "AddQuestionButton");
            AddQuestionButton.Name = "AddQuestionButton";
            AddQuestionButton.UseVisualStyleBackColor = true;
            AddQuestionButton.Click += AddQuestionButton_Click;
            // 
            // AnswerLabel
            // 
            resources.ApplyResources(AnswerLabel, "AnswerLabel");
            AnswerLabel.Name = "AnswerLabel";
            toolTipValidation.SetToolTip(AnswerLabel, resources.GetString("AnswerLabel.ToolTip"));
            // 
            // AnswerTextBox
            // 
            resources.ApplyResources(AnswerTextBox, "AnswerTextBox");
            AnswerTextBox.Name = "AnswerTextBox";
            toolTipValidation.SetToolTip(AnswerTextBox, resources.GetString("AnswerTextBox.ToolTip"));
            AnswerTextBox.Click += AnswerTextBox_Click;
            // 
            // QuestionTextBox
            // 
            QuestionTextBox.ForeColor = Color.Gray;
            resources.ApplyResources(QuestionTextBox, "QuestionTextBox");
            QuestionTextBox.Name = "QuestionTextBox";
            QuestionTextBox.Enter += QuestionTextBox_Enter;
            QuestionTextBox.Leave += QuestionTextBox_Leave;
            // 
            // QuestionTextLabel
            // 
            resources.ApplyResources(QuestionTextLabel, "QuestionTextLabel");
            QuestionTextLabel.Name = "QuestionTextLabel";
            // 
            // QuestionsManagerForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(QuestionsGridView);
            MaximizeBox = false;
            Name = "QuestionsManagerForm";
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
        private ToolTip toolTipValidation;
        private Label ErrorLabel;
    }
}
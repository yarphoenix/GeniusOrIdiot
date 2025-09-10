namespace GeniusOrIdiotWinFormsApp;

partial class GameForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        nextButton = new Button();
        questionNumberLabel = new Label();
        questionTextLabel = new Label();
        userAnswerTextBox = new TextBox();
        menuStrip = new MenuStrip();
        ActionsStripMenuItem = new ToolStripMenuItem();
        ShowResultsToolMenuItem = new ToolStripMenuItem();
        RestartToolMenuItem = new ToolStripMenuItem();
        QuitToolStripMenuItem = new ToolStripMenuItem();
        QuestionManagerToolStripMenuItem = new ToolStripMenuItem();
        errorLabel = new Label();
        RemainingTimeLabel = new Label();
        SeparatorLabel = new Label();
        menuStrip.SuspendLayout();
        SuspendLayout();
        // 
        // nextButton
        // 
        nextButton.Dock = DockStyle.Bottom;
        nextButton.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
        nextButton.Location = new Point(0, 144);
        nextButton.Margin = new Padding(4, 3, 4, 3);
        nextButton.Name = "nextButton";
        nextButton.Size = new Size(632, 56);
        nextButton.TabIndex = 0;
        nextButton.Text = "ДАЛЕЕ";
        nextButton.UseVisualStyleBackColor = true;
        nextButton.Click += nextButton_Click;
        // 
        // questionNumberLabel
        // 
        questionNumberLabel.AutoSize = true;
        questionNumberLabel.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
        questionNumberLabel.Location = new Point(50, 52);
        questionNumberLabel.Name = "questionNumberLabel";
        questionNumberLabel.Size = new Size(81, 16);
        questionNumberLabel.TabIndex = 1;
        questionNumberLabel.Text = "Вопрос № 1";
        // 
        // questionTextLabel
        // 
        questionTextLabel.AutoSize = true;
        questionTextLabel.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
        questionTextLabel.Location = new Point(50, 72);
        questionTextLabel.Name = "questionTextLabel";
        questionTextLabel.Size = new Size(104, 17);
        questionTextLabel.TabIndex = 2;
        questionTextLabel.Text = "Текст вопроса";
        // 
        // userAnswerTextBox
        // 
        userAnswerTextBox.Location = new Point(56, 96);
        userAnswerTextBox.Name = "userAnswerTextBox";
        userAnswerTextBox.Size = new Size(413, 22);
        userAnswerTextBox.TabIndex = 3;
        userAnswerTextBox.Click += userAnswerTextBox_Click;
        userAnswerTextBox.TextChanged += userAnswerTextBox_TextChanged;
        // 
        // menuStrip
        // 
        menuStrip.Items.AddRange(new ToolStripItem[] { ActionsStripMenuItem, QuestionManagerToolStripMenuItem });
        menuStrip.Location = new Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Size = new Size(632, 24);
        menuStrip.TabIndex = 4;
        menuStrip.Text = "menuStrip";
        // 
        // ActionsStripMenuItem
        // 
        ActionsStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ShowResultsToolMenuItem, RestartToolMenuItem, QuitToolStripMenuItem });
        ActionsStripMenuItem.Font = new Font("Cambria", 9F);
        ActionsStripMenuItem.Name = "ActionsStripMenuItem";
        ActionsStripMenuItem.Size = new Size(70, 20);
        ActionsStripMenuItem.Text = "Действия";
        // 
        // ShowResultsToolMenuItem
        // 
        ShowResultsToolMenuItem.Name = "ShowResultsToolMenuItem";
        ShowResultsToolMenuItem.Size = new Size(281, 22);
        ShowResultsToolMenuItem.Text = "Посмотреть предыдущие результаты";
        ShowResultsToolMenuItem.Click += ShowResultsToolMenuItem_Click;
        // 
        // RestartToolMenuItem
        // 
        RestartToolMenuItem.Name = "RestartToolMenuItem";
        RestartToolMenuItem.Size = new Size(281, 22);
        RestartToolMenuItem.Text = "Перезапустить";
        RestartToolMenuItem.Click += RestartToolMenuItem_Click;
        // 
        // QuitToolStripMenuItem
        // 
        QuitToolStripMenuItem.Name = "QuitToolStripMenuItem";
        QuitToolStripMenuItem.Size = new Size(281, 22);
        QuitToolStripMenuItem.Text = "Выйти";
        QuitToolStripMenuItem.Click += QuitToolStripMenuItem_Click;
        // 
        // QuestionManagerToolStripMenuItem
        // 
        QuestionManagerToolStripMenuItem.Name = "QuestionManagerToolStripMenuItem";
        QuestionManagerToolStripMenuItem.Size = new Size(12, 20);
        // 
        // errorLabel
        // 
        errorLabel.AutoSize = true;
        errorLabel.ForeColor = Color.DarkRed;
        errorLabel.Location = new Point(56, 121);
        errorLabel.Name = "errorLabel";
        errorLabel.Size = new Size(51, 14);
        errorLabel.TabIndex = 5;
        errorLabel.Text = "Ошибка";
        // 
        // RemainingTimeLabel
        // 
        RemainingTimeLabel.AutoSize = true;
        RemainingTimeLabel.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
        RemainingTimeLabel.Location = new Point(147, 52);
        RemainingTimeLabel.Name = "RemainingTimeLabel";
        RemainingTimeLabel.Size = new Size(128, 16);
        RemainingTimeLabel.TabIndex = 6;
        RemainingTimeLabel.Text = "Времени осталось: ";
        // 
        // SeparatorLabel
        // 
        SeparatorLabel.AutoSize = true;
        SeparatorLabel.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
        SeparatorLabel.Location = new Point(136, 51);
        SeparatorLabel.Name = "SeparatorLabel";
        SeparatorLabel.Size = new Size(11, 16);
        SeparatorLabel.TabIndex = 7;
        SeparatorLabel.Text = "|";
        // 
        // GameForm
        // 
        AutoScaleDimensions = new SizeF(7F, 14F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(632, 200);
        Controls.Add(SeparatorLabel);
        Controls.Add(RemainingTimeLabel);
        Controls.Add(errorLabel);
        Controls.Add(userAnswerTextBox);
        Controls.Add(questionTextLabel);
        Controls.Add(questionNumberLabel);
        Controls.Add(nextButton);
        Controls.Add(menuStrip);
        Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
        MainMenuStrip = menuStrip;
        MaximizeBox = false;
        Name = "GameForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Гений или Идиот";
        Load += MainForm_Load;
        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button nextButton;
    private Label questionNumberLabel;
    private Label questionTextLabel;
    private TextBox userAnswerTextBox;
    private MenuStrip menuStrip;
    private ToolStripMenuItem ActionsStripMenuItem;
    private ToolStripMenuItem ShowResultsToolMenuItem;
    private ToolStripMenuItem RestartToolMenuItem;
    private ToolStripMenuItem QuitToolStripMenuItem;
    private Label errorLabel;
    private ToolStripMenuItem QuestionManagerToolStripMenuItem;
    private Label RemainingTimeLabel;
    private Label SeparatorLabel;
}
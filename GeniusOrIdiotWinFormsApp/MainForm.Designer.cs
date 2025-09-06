namespace GeniusOrIdiotWinFormsApp;

partial class MainForm
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
        SuspendLayout();
        // 
        // nextButton
        // 
        nextButton.Dock = DockStyle.Bottom;
        nextButton.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
        nextButton.Location = new Point(0, 159);
        nextButton.Margin = new Padding(4, 3, 4, 3);
        nextButton.Name = "nextButton";
        nextButton.Size = new Size(606, 81);
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
        questionTextLabel.Size = new Size(108, 17);
        questionTextLabel.TabIndex = 2;
        questionTextLabel.Text = "Текст вопроса:";
        // 
        // userAnswerTextBox
        // 
        userAnswerTextBox.Location = new Point(56, 96);
        userAnswerTextBox.Name = "userAnswerTextBox";
        userAnswerTextBox.Size = new Size(413, 22);
        userAnswerTextBox.TabIndex = 3;
        // 
        // mainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 14F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(606, 240);
        Controls.Add(userAnswerTextBox);
        Controls.Add(questionTextLabel);
        Controls.Add(questionNumberLabel);
        Controls.Add(nextButton);
        Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
        Name = "MainForm";
        Text = "Гений или Идиот";
        Load += MainForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button nextButton;
    private Label questionNumberLabel;
    private Label questionTextLabel;
    private TextBox userAnswerTextBox;
}
namespace GeniusOrIdiotWinFormsApp;

partial class GeniusOrIdiot
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
        nextButton.Size = new Size(545, 81);
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
        questionNumberLabel.Size = new Size(99, 20);
        questionNumberLabel.TabIndex = 1;
        questionNumberLabel.Text = "Вопрос № 1";
        questionNumberLabel.Click += questionNumberLabel_Click;
        // 
        // questionTextLabel
        // 
        questionTextLabel.AutoSize = true;
        questionTextLabel.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
        questionTextLabel.Location = new Point(50, 72);
        questionTextLabel.Name = "questionTextLabel";
        questionTextLabel.Size = new Size(131, 21);
        questionTextLabel.TabIndex = 2;
        questionTextLabel.Text = "Текст вопроса:";
        questionTextLabel.Click += questionTextLabel_Click;
        // 
        // userAnswerTextBox
        // 
        userAnswerTextBox.Location = new Point(56, 96);
        userAnswerTextBox.Name = "userAnswerTextBox";
        userAnswerTextBox.Size = new Size(413, 25);
        userAnswerTextBox.TabIndex = 3;
        userAnswerTextBox.TextChanged += userAnswerTextBox_TextChanged;
        // 
        // GeniusOrIdiot
        // 
        AutoScaleDimensions = new SizeF(8F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(545, 240);
        Controls.Add(userAnswerTextBox);
        Controls.Add(questionTextLabel);
        Controls.Add(questionNumberLabel);
        Controls.Add(nextButton);
        Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
        Name = "GeniusOrIdiot";
        Text = "Гений или Идиот";
        Load += GeniusOrIdiot_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button nextButton;
    private Label questionNumberLabel;
    private Label questionTextLabel;
    private TextBox userAnswerTextBox;
}
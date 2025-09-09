namespace GeniusOrIdiotWinFormsApp;

partial class WelcomeForm
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
        welcomeLabel = new Label();
        gameNameLabel = new Label();
        label1 = new Label();
        userNameInputTextBox = new TextBox();
        startButton = new Button();
        pictureBox1 = new PictureBox();
        idiotPictureBox = new PictureBox();
        QuestionManagerButton = new Button();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)idiotPictureBox).BeginInit();
        SuspendLayout();
        // 
        // welcomeLabel
        // 
        welcomeLabel.AutoSize = true;
        welcomeLabel.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
        welcomeLabel.Location = new Point(190, 38);
        welcomeLabel.Name = "welcomeLabel";
        welcomeLabel.Size = new Size(155, 17);
        welcomeLabel.TabIndex = 0;
        welcomeLabel.Text = "Добро пожаловать в...";
        // 
        // gameNameLabel
        // 
        gameNameLabel.AutoSize = true;
        gameNameLabel.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
        gameNameLabel.Location = new Point(140, 54);
        gameNameLabel.Name = "gameNameLabel";
        gameNameLabel.Size = new Size(238, 28);
        gameNameLabel.TabIndex = 1;
        gameNameLabel.Text = "ГЕНИЙ ИЛИ ИДИОТ";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label1.Location = new Point(199, 91);
        label1.Name = "label1";
        label1.Size = new Size(122, 16);
        label1.TabIndex = 2;
        label1.Text = "Введите ваше имя";
        // 
        // userNameInputTextBox
        // 
        userNameInputTextBox.Font = new Font("Cambria", 9F);
        userNameInputTextBox.Location = new Point(157, 108);
        userNameInputTextBox.Name = "userNameInputTextBox";
        userNameInputTextBox.Size = new Size(221, 22);
        userNameInputTextBox.TabIndex = 3;
        // 
        // startButton
        // 
        startButton.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
        startButton.Location = new Point(224, 134);
        startButton.Name = "startButton";
        startButton.Size = new Size(75, 21);
        startButton.TabIndex = 4;
        startButton.Text = "Начать";
        startButton.UseVisualStyleBackColor = true;
        startButton.Click += startButton_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources._047237826913565eed83f7f3bd57fa93;
        pictureBox1.Location = new Point(395, 38);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(150, 80);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 5;
        pictureBox1.TabStop = false;
        // 
        // idiotPictureBox
        // 
        idiotPictureBox.Image = Properties.Resources._1654812674_new_preview_208_2084040_transparent_wojak_png_dumb_person_drawing_meme_png;
        idiotPictureBox.Location = new Point(-6, 110);
        idiotPictureBox.Name = "idiotPictureBox";
        idiotPictureBox.Size = new Size(162, 104);
        idiotPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        idiotPictureBox.TabIndex = 6;
        idiotPictureBox.TabStop = false;
        // 
        // QuestionManagerButton
        // 
        QuestionManagerButton.Location = new Point(388, 159);
        QuestionManagerButton.Name = "QuestionManagerButton";
        QuestionManagerButton.Size = new Size(146, 23);
        QuestionManagerButton.TabIndex = 7;
        QuestionManagerButton.Text = "Менеджер вопросов";
        QuestionManagerButton.UseVisualStyleBackColor = true;
        QuestionManagerButton.Click += QuestionManagerButton_Click;
        // 
        // WelcomeForm
        // 
        AutoScaleDimensions = new SizeF(7F, 14F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(546, 194);
        Controls.Add(QuestionManagerButton);
        Controls.Add(idiotPictureBox);
        Controls.Add(pictureBox1);
        Controls.Add(startButton);
        Controls.Add(userNameInputTextBox);
        Controls.Add(label1);
        Controls.Add(gameNameLabel);
        Controls.Add(welcomeLabel);
        Font = new Font("Cambria", 9F);
        ForeColor = SystemColors.ControlText;
        MaximizeBox = false;
        Name = "WelcomeForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Гений или Идиот";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)idiotPictureBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    public static TextBox userNameInputTextBox;

    private Label welcomeLabel;
    private Label gameNameLabel;
    private Label label1;
    private Button startButton;
    private PictureBox pictureBox1;
    private PictureBox idiotPictureBox;
    private Button QuestionManagerButton;
}
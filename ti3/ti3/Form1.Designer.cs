namespace ti3;

partial class Form1
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        PtextBox = new TextBox();
        QtextBox = new TextBox();
        DtextBox = new TextBox();
        makebutton = new Button();
        FtextBox = new TextBox();
        RtextBox = new TextBox();
        EtextBox = new TextBox();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        CradioButton = new RadioButton();
        DradioButton = new RadioButton();
        resbutton = new Button();
        menuStrip1 = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        openToolStripMenuItem = new ToolStripMenuItem();
        saveToolStripMenuItem = new ToolStripMenuItem();
        файлToolStripMenuItem = new ToolStripMenuItem();
        открытьToolStripMenuItem = new ToolStripMenuItem();
        сохранитьToolStripMenuItem = new ToolStripMenuItem();
        открытьЗашифрованныйТекстToolStripMenuItem = new ToolStripMenuItem();
        сохранитьРасшифрованныйТекстToolStripMenuItem = new ToolStripMenuItem();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        label8 = new Label();
        label9 = new Label();
        label10 = new Label();
        label11 = new Label();
        label12 = new Label();
        label13 = new Label();
        label14 = new Label();
        label15 = new Label();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // PtextBox
        // 
        PtextBox.Font = new Font("Segoe UI", 12F);
        PtextBox.ForeColor = SystemColors.ActiveCaptionText;
        PtextBox.Location = new Point(77, 41);
        PtextBox.Name = "PtextBox";
        PtextBox.Size = new Size(286, 34);
        PtextBox.TabIndex = 0;
        PtextBox.TextChanged += textBox1_TextChanged;
        // 
        // QtextBox
        // 
        QtextBox.Font = new Font("Segoe UI", 12F);
        QtextBox.ForeColor = SystemColors.ActiveCaptionText;
        QtextBox.Location = new Point(77, 119);
        QtextBox.Name = "QtextBox";
        QtextBox.Size = new Size(286, 34);
        QtextBox.TabIndex = 1;
        // 
        // DtextBox
        // 
        DtextBox.Font = new Font("Segoe UI", 12F);
        DtextBox.ForeColor = SystemColors.ActiveCaptionText;
        DtextBox.Location = new Point(77, 192);
        DtextBox.Name = "DtextBox";
        DtextBox.Size = new Size(286, 34);
        DtextBox.TabIndex = 2;
        // 
        // makebutton
        // 
        makebutton.Font = new Font("Segoe UI", 12F);
        makebutton.ForeColor = SystemColors.ActiveCaptionText;
        makebutton.Location = new Point(77, 270);
        makebutton.Name = "makebutton";
        makebutton.Size = new Size(286, 45);
        makebutton.TabIndex = 3;
        makebutton.Text = "рассчитать";
        makebutton.UseVisualStyleBackColor = true;
        makebutton.Click += makebutton_Click;
        // 
        // FtextBox
        // 
        FtextBox.Font = new Font("Segoe UI", 12F);
        FtextBox.Location = new Point(77, 437);
        FtextBox.Multiline = true;
        FtextBox.Name = "FtextBox";
        FtextBox.Size = new Size(286, 51);
        FtextBox.TabIndex = 4;
        // 
        // RtextBox
        // 
        RtextBox.Font = new Font("Segoe UI", 12F);
        RtextBox.ForeColor = SystemColors.ActiveCaptionText;
        RtextBox.Location = new Point(77, 352);
        RtextBox.Multiline = true;
        RtextBox.Name = "RtextBox";
        RtextBox.Size = new Size(286, 51);
        RtextBox.TabIndex = 5;
        // 
        // EtextBox
        // 
        EtextBox.Font = new Font("Segoe UI", 12F);
        EtextBox.Location = new Point(77, 533);
        EtextBox.Multiline = true;
        EtextBox.Name = "EtextBox";
        EtextBox.Size = new Size(286, 51);
        EtextBox.TabIndex = 6;
        // 
        // textBox1
        // 
        textBox1.AcceptsTab = true;
        textBox1.Font = new Font("Segoe UI", 12F);
        textBox1.ForeColor = SystemColors.ActiveCaptionText;
        textBox1.Location = new Point(478, 104);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(339, 115);
        textBox1.TabIndex = 7;
        // 
        // textBox2
        // 
        textBox2.Font = new Font("Segoe UI", 12F);
        textBox2.ForeColor = SystemColors.ActiveCaptionText;
        textBox2.Location = new Point(478, 288);
        textBox2.Multiline = true;
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(339, 115);
        textBox2.TabIndex = 8;
        // 
        // CradioButton
        // 
        CradioButton.AutoSize = true;
        CradioButton.Font = new Font("Segoe UI", 12F);
        CradioButton.Location = new Point(487, 438);
        CradioButton.Name = "CradioButton";
        CradioButton.Size = new Size(157, 32);
        CradioButton.TabIndex = 9;
        CradioButton.TabStop = true;
        CradioButton.Text = "зашифровать";
        CradioButton.UseVisualStyleBackColor = true;
        CradioButton.CheckedChanged += CradioButton_CheckedChanged;
        // 
        // DradioButton
        // 
        DradioButton.AutoSize = true;
        DradioButton.Font = new Font("Segoe UI", 12F);
        DradioButton.Location = new Point(487, 477);
        DradioButton.Name = "DradioButton";
        DradioButton.Size = new Size(169, 32);
        DradioButton.TabIndex = 10;
        DradioButton.TabStop = true;
        DradioButton.Text = "расшифровать";
        DradioButton.UseVisualStyleBackColor = true;
        DradioButton.CheckedChanged += DradioButton_CheckedChanged;
        // 
        // resbutton
        // 
        resbutton.Font = new Font("Segoe UI", 12F);
        resbutton.Location = new Point(478, 539);
        resbutton.Name = "resbutton";
        resbutton.Size = new Size(286, 45);
        resbutton.TabIndex = 11;
        resbutton.Text = "зашифровать";
        resbutton.UseVisualStyleBackColor = true;
        resbutton.Click += resbutton_Click;
        // 
        // menuStrip1
        // 
        menuStrip1.Font = new Font("Segoe UI", 12F);
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, файлToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(968, 36);
        menuStrip1.TabIndex = 12;
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
        fileToolStripMenuItem.Font = new Font("Segoe UI", 12F);
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new Size(14, 32);
        // 
        // openToolStripMenuItem
        // 
        openToolStripMenuItem.Font = new Font("Segoe UI", 12F);
        openToolStripMenuItem.Name = "openToolStripMenuItem";
        openToolStripMenuItem.Size = new Size(86, 26);
        openToolStripMenuItem.Click += openToolStripMenuItem_Click;
        // 
        // saveToolStripMenuItem
        // 
        saveToolStripMenuItem.Font = new Font("Segoe UI", 12F);
        saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        saveToolStripMenuItem.Size = new Size(86, 26);
        // 
        // файлToolStripMenuItem
        // 
        файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem, открытьЗашифрованныйТекстToolStripMenuItem, сохранитьРасшифрованныйТекстToolStripMenuItem });
        файлToolStripMenuItem.Name = "файлToolStripMenuItem";
        файлToolStripMenuItem.Size = new Size(73, 32);
        файлToolStripMenuItem.Text = "файл";
        // 
        // открытьToolStripMenuItem
        // 
        открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
        открытьToolStripMenuItem.Size = new Size(415, 32);
        открытьToolStripMenuItem.Text = "открыть исходный текст";
        открытьToolStripMenuItem.Click += openToolStripMenuItem_Click;
        // 
        // сохранитьToolStripMenuItem
        // 
        сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
        сохранитьToolStripMenuItem.Size = new Size(415, 32);
        сохранитьToolStripMenuItem.Text = "сохранить зашифрованный текст";
        сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
        // 
        // открытьЗашифрованныйТекстToolStripMenuItem
        // 
        открытьЗашифрованныйТекстToolStripMenuItem.Name = "открытьЗашифрованныйТекстToolStripMenuItem";
        открытьЗашифрованныйТекстToolStripMenuItem.Size = new Size(415, 32);
        открытьЗашифрованныйТекстToolStripMenuItem.Text = "открыть зашифрованный текст";
        открытьЗашифрованныйТекстToolStripMenuItem.Click += открытьЗашифрованныйТекстToolStripMenuItem_Click;
        // 
        // сохранитьРасшифрованныйТекстToolStripMenuItem
        // 
        сохранитьРасшифрованныйТекстToolStripMenuItem.Name = "сохранитьРасшифрованныйТекстToolStripMenuItem";
        сохранитьРасшифрованныйТекстToolStripMenuItem.Size = new Size(415, 32);
        сохранитьРасшифрованныйТекстToolStripMenuItem.Text = "сохранить расшифрованный текст";
        сохранитьРасшифрованныйТекстToolStripMenuItem.Click += сохранитьРасшифрованныйТекстToolStripMenuItem_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F);
        label1.ForeColor = SystemColors.ActiveCaptionText;
        label1.Location = new Point(478, 62);
        label1.Name = "label1";
        label1.Size = new Size(156, 28);
        label1.TabIndex = 13;
        label1.Text = "Исходный текст";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F);
        label2.ForeColor = SystemColors.ActiveCaptionText;
        label2.Location = new Point(478, 255);
        label2.Name = "label2";
        label2.Size = new Size(0, 28);
        label2.TabIndex = 14;
        label2.Click += label2_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F);
        label3.Location = new Point(12, 41);
        label3.Name = "label3";
        label3.Size = new Size(0, 28);
        label3.TabIndex = 15;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 12F);
        label4.Location = new Point(12, 126);
        label4.Name = "label4";
        label4.Size = new Size(0, 28);
        label4.TabIndex = 16;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 12F);
        label5.Location = new Point(12, 199);
        label5.Name = "label5";
        label5.Size = new Size(0, 28);
        label5.TabIndex = 17;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 12F);
        label6.Location = new Point(12, 367);
        label6.Name = "label6";
        label6.Size = new Size(0, 28);
        label6.TabIndex = 18;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI", 12F);
        label7.Location = new Point(12, 455);
        label7.Name = "label7";
        label7.Size = new Size(0, 28);
        label7.TabIndex = 19;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Segoe UI", 12F);
        label8.Location = new Point(12, 539);
        label8.Name = "label8";
        label8.Size = new Size(0, 28);
        label8.TabIndex = 20;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Font = new Font("Segoe UI", 12F);
        label9.ForeColor = SystemColors.ActiveCaptionText;
        label9.Location = new Point(478, 242);
        label9.Name = "label9";
        label9.Size = new Size(180, 28);
        label9.TabIndex = 21;
        label9.Text = "Полученный текст";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Font = new Font("Segoe UI", 12F);
        label10.ForeColor = SystemColors.ActiveCaptionText;
        label10.Location = new Point(36, 41);
        label10.Name = "label10";
        label10.Size = new Size(23, 28);
        label10.TabIndex = 22;
        label10.Text = "P";
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Font = new Font("Segoe UI", 12F);
        label11.ForeColor = SystemColors.ActiveCaptionText;
        label11.Location = new Point(36, 122);
        label11.Name = "label11";
        label11.Size = new Size(27, 28);
        label11.TabIndex = 23;
        label11.Text = "Q";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Font = new Font("Segoe UI", 12F);
        label12.ForeColor = SystemColors.ActiveCaptionText;
        label12.Location = new Point(36, 199);
        label12.Name = "label12";
        label12.Size = new Size(26, 28);
        label12.TabIndex = 24;
        label12.Text = "D";
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Font = new Font("Segoe UI", 12F);
        label13.ForeColor = SystemColors.ActiveCaptionText;
        label13.Location = new Point(33, 367);
        label13.Name = "label13";
        label13.Size = new Size(24, 28);
        label13.TabIndex = 25;
        label13.Text = "R";
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Font = new Font("Segoe UI", 12F);
        label14.ForeColor = SystemColors.ActiveCaptionText;
        label14.Location = new Point(18, 455);
        label14.Name = "label14";
        label14.Size = new Size(50, 28);
        label14.TabIndex = 26;
        label14.Text = "φ(R)";
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Font = new Font("Segoe UI", 12F);
        label15.ForeColor = SystemColors.ActiveCaptionText;
        label15.Location = new Point(13, 547);
        label15.Name = "label15";
        label15.Size = new Size(22, 28);
        label15.TabIndex = 27;
        label15.Text = "E";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(968, 708);
        Controls.Add(label15);
        Controls.Add(label14);
        Controls.Add(label13);
        Controls.Add(label12);
        Controls.Add(label11);
        Controls.Add(label10);
        Controls.Add(label9);
        Controls.Add(label8);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(resbutton);
        Controls.Add(DradioButton);
        Controls.Add(CradioButton);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(EtextBox);
        Controls.Add(RtextBox);
        Controls.Add(FtextBox);
        Controls.Add(makebutton);
        Controls.Add(DtextBox);
        Controls.Add(QtextBox);
        Controls.Add(PtextBox);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox RtextBox;
    private System.Windows.Forms.TextBox EtextBox;

    private System.Windows.Forms.TextBox PtextBox;
    private System.Windows.Forms.TextBox QtextBox;
    private System.Windows.Forms.TextBox DtextBox;
    private System.Windows.Forms.TextBox FtextBox;

    private System.Windows.Forms.Button makebutton;

    #endregion

    private TextBox textBox1;
    private TextBox textBox2;
    private RadioButton CradioButton;
    private RadioButton DradioButton;
    private Button resbutton;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem openToolStripMenuItem;
    private ToolStripMenuItem saveToolStripMenuItem;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private ToolStripMenuItem файлToolStripMenuItem;
    private ToolStripMenuItem открытьToolStripMenuItem;
    private ToolStripMenuItem сохранитьToolStripMenuItem;
    private Label label9;
    private Label label10;
    private Label label11;
    private Label label12;
    private Label label13;
    private Label label14;
    private Label label15;
    private ToolStripMenuItem открытьЗашифрованныйТекстToolStripMenuItem;
    private ToolStripMenuItem сохранитьРасшифрованныйТекстToolStripMenuItem;
}
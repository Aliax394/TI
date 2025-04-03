namespace ti2;

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
        button1 = new System.Windows.Forms.Button();
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        textBox3 = new System.Windows.Forms.TextBox();
        textBox4 = new System.Windows.Forms.TextBox();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(306, 187);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(204, 48);
        button1.TabIndex = 0;
        button1.Text = "зашифровать";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(25, 48);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(531, 42);
        textBox1.TabIndex = 1;
        textBox1.TextChanged += textBox1_TextChanged;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(31, 147);
        textBox2.Multiline = true;
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(257, 208);
        textBox2.TabIndex = 2;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(25, 105);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(535, 39);
        label1.TabIndex = 3;
        label1.Text = "";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(30, 12);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(190, 36);
        label2.TabIndex = 4;
        label2.Text = "Регистр";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(30, 389);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(199, 37);
        label3.TabIndex = 5;
        label3.Text = "Ключ";
        label3.Click += label3_Click;
        // 
        // textBox3
        // 
        textBox3.Location = new System.Drawing.Point(550, 147);
        textBox3.Multiline = true;
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(262, 208);
        textBox3.TabIndex = 6;
        // 
        // textBox4
        // 
        textBox4.Location = new System.Drawing.Point(25, 430);
        textBox4.Multiline = true;
        textBox4.Name = "textBox4";
        textBox4.Size = new System.Drawing.Size(257, 208);
        textBox4.TabIndex = 8;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(589, 12);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(204, 47);
        button3.TabIndex = 10;
        button3.Text = "открыть файл";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.Location = new System.Drawing.Point(589, 74);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(204, 47);
        button4.TabIndex = 11;
        button4.Text = "сохранить файл";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(589, 485);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(204, 47);
        button2.TabIndex = 12;
        button2.Text = "очистить все";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(831, 652);
        Controls.Add(button2);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(textBox4);
        Controls.Add(textBox3);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(button1);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;

    private System.Windows.Forms.TextBox textBox4;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox3;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox1;

    #endregion
}
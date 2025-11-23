namespace EventPlayground;

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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnChangeText = new Button();
        btnChangeColor = new Button();
        label1 = new Label();
        comboBox1 = new ComboBox();
        SuspendLayout();
        // 
        // btnChangeText
        // 
        btnChangeText.Font = new Font("Segoe UI", 15F);
        btnChangeText.Location = new Point(12, 160);
        btnChangeText.Name = "btnChangeText";
        btnChangeText.Size = new Size(382, 113);
        btnChangeText.TabIndex = 0;
        btnChangeText.Text = "Change Colour";
        btnChangeText.UseVisualStyleBackColor = true;
        btnChangeText.Click += btnChangeColor_Click;
        // 
        // btnChangeColor
        // 
        btnChangeColor.AccessibleName = "Change Text";
        btnChangeColor.Font = new Font("Segoe UI", 15F);
        btnChangeColor.Location = new Point(406, 160);
        btnChangeColor.Name = "btnChangeColor";
        btnChangeColor.Size = new Size(382, 113);
        btnChangeColor.TabIndex = 1;
        btnChangeColor.Text = "Change Text";
        btnChangeColor.UseVisualStyleBackColor = true;
        btnChangeColor.Click += btnChangeText_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 20F);
        label1.Location = new Point(195, 56);
        label1.Name = "label1";
        label1.Size = new Size(432, 54);
        label1.TabIndex = 2;
        label1.Text = "Welcome to Events Lab";
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(80, 305);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(257, 33);
        comboBox1.TabIndex = 3;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(comboBox1);
        Controls.Add(label1);
        Controls.Add(btnChangeColor);
        Controls.Add(btnChangeText);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnChangeText;
    private Button btnChangeColor;
    private Label label1;
    private ComboBox comboBox1;
}

using System;
using System.Drawing;
using System.Windows.Forms;
namespace EventPlayground;

public partial class Form1 : Form
{
    public delegate void ColorChangedHandler(object sender, ColorEventArgs e);
    public delegate void TextChangedHandler();

    public event ColorChangedHandler ColorChangedEvent;
    public event TextChangedHandler TextChangedEvent;

    public Form1()
    {
        InitializeComponent();
        comboBox1.Items.AddRange(new string[] { "Red", "Green", "Blue" });

        //ColorChangedEvent += OnColorChanged;
        ColorChangedEvent += UpdateLabelColor;
        ColorChangedEvent += ShowNotification;

        TextChangedEvent += OnTextChanged;
    }

    private void UpdateLabelColor(object sender, ColorEventArgs e)
    {
        label1.ForeColor = Color.FromName(e.ColorName);
    }

    private void ShowNotification(object sender, ColorEventArgs e)
    {
        MessageBox.Show("Selected Colour: " + e.ColorName);
    }

    public class ColorEventArgs : EventArgs
    {
        public string ColorName { get; set; }

        public ColorEventArgs(string colorName)
        {
            ColorName = colorName;
        }
    }

    private void OnTextChanged()
    {
        label1.Text = DateTime.Now.ToString();
    }

    private void btnChangeColor_Click(object sender, EventArgs e)
    {
        string selected = comboBox1.SelectedItem?.ToString();
        if (selected != null)
        {
            ColorChangedEvent?.Invoke(this, new ColorEventArgs(selected));
        }
    }

    private void btnChangeText_Click(object sender, EventArgs e)
    {
        TextChangedEvent?.Invoke();
    }
}


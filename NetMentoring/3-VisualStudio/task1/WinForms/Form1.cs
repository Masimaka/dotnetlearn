using System;
using System.Windows.Forms;

namespace _3_2_winforms;

public partial class Form1 : Form
{
    private System.Windows.Forms.TextBox nameTextBox;
    private System.Windows.Forms.Button submitButton;

    public Form1()
    {
        InitializeComponent();
        // создание нового текстового поля
        this.nameTextBox = new System.Windows.Forms.TextBox();
        this.nameTextBox.Location = new System.Drawing.Point(30, 30);

        // создание новой кнопки
        this.submitButton = new System.Windows.Forms.Button();
        this.submitButton.Location = new System.Drawing.Point(30, 70);
        this.submitButton.Text = "Submit";

        // обработчик клика по кнопке
        this.submitButton.Click += new System.EventHandler(submitButton_Click);

        // добавление элементов управления на форму
        this.Controls.Add(this.nameTextBox);
        this.Controls.Add(this.submitButton);

    }
    // обработчик события
    private void submitButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Hello, " + this.nameTextBox.Text + "!");
    }
}

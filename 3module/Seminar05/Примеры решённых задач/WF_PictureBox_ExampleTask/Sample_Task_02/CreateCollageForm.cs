using System;
using System.Windows.Forms;

namespace Sample_Task_02
{
    public partial class CreateCollageForm : Form
    {
        /// <summary>
        /// Конструктор формы
        /// </summary>
        public CreateCollageForm()
        {
            InitializeComponent();
            heightMaskedTextBox.Text = "1";
            widthMaskedTextBox.Text = "1";
        }
        /// <summary>
        /// Обработчик события, возникающего при задании количества ячеек в коллаже
        /// </summary>
        /// <param name="sender">Объект, на котором сработало событие</param>
        /// <param name="e">Параменты события</param>
        private void CreateCollageButton_Click(object sender, EventArgs e)
        {
            ImageForm.widthCells = int.Parse(widthMaskedTextBox.Text);
            ImageForm.heightCells = int.Parse(heightMaskedTextBox.Text);
            if (ImageForm.widthCells == 0 || ImageForm.heightCells == 0 || ImageForm.widthCells > 10 || ImageForm.heightCells > 10)
                MessageBox.Show("Amount of cells should be an integer number greater than zero and less then ten.", "Warning", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}

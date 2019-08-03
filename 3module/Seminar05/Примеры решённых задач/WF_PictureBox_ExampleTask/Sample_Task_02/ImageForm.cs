/* Разработать оконное приложение для создания коллажей, позволяющее:
 * 1) Выбирать количество ячеек в коллаже по горизонтали и вертикали;
 * 2) Выбирать фотографии для добавления через диалоговое окно;
 * 3) Автоматически изменять размеры коллажа при изменении размеров окна;
 * 4) Предоставлять возможность сохранения коллажа в виде картинки. */
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace Sample_Task_02
{
    public partial class ImageForm : Form
    {
        /// <summary>
        /// Количество ячеек по вертикали
        /// </summary>
        internal static int heightCells;
        /// <summary>
        /// Количество ячеек по горизонтали
        /// </summary>
        internal static int widthCells;
        /// <summary>
        /// Конструктор для создания формы
        /// </summary>
        public ImageForm()
        {
            //Метод, добавляющий на форму все компоненты, которые мы заявили в дизайнере форм (как то: label, PictureBox, etc.)
            InitializeComponent();
            menuStrip.Visible = false;
        }
        
        /// <summary>
         /// Список кнопок-ячеек для фото
         /// </summary>
        List<Button> buttons = new List<Button>();
        /// <summary>
        /// Обработчик события, возникающего при нажатии на кнопку создания коллажа.
        /// Создание новой разметки для коллажа.
        /// </summary>
        /// <param name="sender">Объект, на котором сработало событие</param>
        /// <param name="e">Параменты события</param>
        private void CreateButton_Click(object sender, EventArgs e)
        {
            //Создание нового окна создания коллажа
            CreateCollageForm createCollageForm = new CreateCollageForm();
            if (createCollageForm.ShowDialog(this) == DialogResult.OK)
            {
                //Инициализирование сетки коллажа начальными значениями
                tableLayoutPanel.RowCount = heightCells;
                tableLayoutPanel.ColumnCount = widthCells;
                tableLayoutPanel.RowStyles[0].SizeType = SizeType.AutoSize;
                tableLayoutPanel.ColumnStyles[0].SizeType = SizeType.AutoSize;
                createButton.Visible = false;
                menuStrip.Visible = true;
                //Добавление в ячейки сетки коллажа кнопок, по которым можно добавить изображение в ячейку коллажа
                for (var rowNumber = 0; rowNumber < tableLayoutPanel.RowCount; rowNumber++)
                    for (var columnNumber = 0; columnNumber < tableLayoutPanel.ColumnCount; columnNumber++)
                    {
                        Button button = new Button()
                        {
                            FlatStyle = FlatStyle.Flat,
                            Margin = new Padding(0, 0, 0, 0),
                            Width = ClientSize.Width / tableLayoutPanel.ColumnCount,
                            Height = (ClientSize.Height - menuStrip.Height) / tableLayoutPanel.RowCount,
                            Dock = DockStyle.Fill,
                        };
                        button.FlatAppearance.BorderSize = 0;
                        button.Click += new EventHandler(AddImageButton_Click);
                        buttons.Add(button);
                        tableLayoutPanel.Controls.Add(button, columnNumber, rowNumber);
                    }
            }
        }
        /// <summary>
        /// Метод для "блокировки" кнопок-ячеек
        /// </summary>
        private void DisableButtons()
        {
            foreach (var button in buttons)
                button.Enabled = false;
            this.ActiveControl = menuStrip;
        }
        /// <summary>
        /// Метод для снятия "блокировки" с кнопок-ячеек
        /// </summary>
        private void EnableButtons()
        {
            foreach (var button in buttons)
                button.Enabled = true;
        }

        /// <summary>
        /// Обработчик события, возникающего при изменении размеров коллажа
        /// </summary>
        /// <param name="sender">Объект, на котором сработало событие</param>
        /// <param name="e">Параменты события</param>
        private void TableLayoutPanel_Resize(object sender, EventArgs e)
        {
            //Изменение размеров каждого изображения в коллаже пропорционально уменьшению всей формы
            tableLayoutPanel.RowStyles[0].SizeType = SizeType.AutoSize;
            tableLayoutPanel.ColumnStyles[0].SizeType = SizeType.AutoSize;
            foreach (var button in buttons)
            {
                button.Width = ClientSize.Width / tableLayoutPanel.ColumnCount;
                button.Height = (ClientSize.Height - menuStrip.Height) / tableLayoutPanel.RowCount;
            }
        }
        /// <summary>
        /// Обработчик события, возникающего при нажатии на одну из кнопок-ячеек (выбор изображения)
        /// </summary>
        /// <param name="sender">Объект, на котором сработало событие</param>
        /// <param name="e">Параменты события</param>
        private void AddImageButton_Click(object sender, EventArgs e)
        {
            /* Среди возможных компонентов для формы есть SomeDialog, то есть диалоговые окна.
             * Например, ColorDialog представляет общее диалоговое окно, в котором отображаются доступные цвета и элементы управления,
             * позволяющие пользователю определять собственные цвета. FolderDialog позволяет пользователю выбрать папку в проводнике.
             * После окончания работы пользователя с диалоговым окном, компонент в соответствующих свойствах хранит
             * всю интересующую нас информацию.*/

            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Choose image",
                CheckPathExists = true,
                Filter = "Image Files(*.PNG)|*.PNG|Image Files(*.JPEG)|*.JPEG|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Установка выбранного пользователем изображения на изображение кнопки

                    Button button = sender as Button;
                    button.BackgroundImageLayout = ImageLayout.Stretch;

                    /* Bitmap Инкапсулирует точечный рисунок GDI+,
                     * состоящий из данных пикселей графического изображения и атрибутов рисунка.
                     * Удобный способ работы с изображениями в WinForms. */
                    button.BackgroundImage = new Bitmap(openFileDialog.FileName);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("The action cannot be completed because the file is open in another program.",
                                    "File in use", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception undefinedException)
                {
                    MessageBox.Show("Something went wrong. " + undefinedException.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Обработчик события, возникающего при нажатии на кнопку сохранения
        /// </summary>
        /// <param name="sender">Объект, на котором сработало событие</param>
        /// <param name="e">Параменты события</param>
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Снятие выделения с кнопок
            DisableButtons();
            // Создание нового изображения из объектов, находящихся на TableLayoutPanel
            Bitmap collage = new Bitmap(ClientSize.Width, (ClientSize.Height - menuStrip.Height));
            tableLayoutPanel.DrawToBitmap(collage, new Rectangle(0, 0, ClientSize.Width, (ClientSize.Height - menuStrip.Height)));
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Save as...",
                OverwritePrompt = true,
                CheckPathExists = true,
                Filter = "Image Files(*.PNG)|*.PNG"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    collage.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    MessageBox.Show("The action cannot be completed because the file is open in another program.",
                                    "File in use", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception undefinedException)
                {
                    MessageBox.Show("Something went wrong. " + undefinedException.Message, "Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            EnableButtons();
        }
    }
}

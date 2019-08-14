namespace TODO_Task_02
{
    partial class GameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button = new System.Windows.Forms.Button();
            this.hitsLabel = new System.Windows.Forms.Label();
            this.failsLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Bisque;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.ForeColor = System.Drawing.Color.Maroon;
            this.button.Location = new System.Drawing.Point(327, 178);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(147, 59);
            this.button.TabIndex = 0;
            this.button.Text = "Catch me!";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.Button_Click);
            // 
            // hitsLabel
            // 
            this.hitsLabel.AutoSize = true;
            this.hitsLabel.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitsLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.hitsLabel.Location = new System.Drawing.Point(175, 316);
            this.hitsLabel.Name = "hitsLabel";
            this.hitsLabel.Size = new System.Drawing.Size(43, 50);
            this.hitsLabel.TabIndex = 1;
            this.hitsLabel.Text = "0";
            // 
            // failsLabel
            // 
            this.failsLabel.AutoSize = true;
            this.failsLabel.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failsLabel.ForeColor = System.Drawing.Color.Red;
            this.failsLabel.Location = new System.Drawing.Point(580, 316);
            this.failsLabel.Name = "failsLabel";
            this.failsLabel.Size = new System.Drawing.Size(43, 50);
            this.failsLabel.TabIndex = 2;
            this.failsLabel.Text = "0";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.failsLabel);
            this.Controls.Add(this.hitsLabel);
            this.Controls.Add(this.button);
            this.Name = "GameForm";
            this.Text = "Game";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label hitsLabel;
        private System.Windows.Forms.Label failsLabel;
        private System.Windows.Forms.Timer timer;
    }
}


namespace Sample_Task_02
{
    partial class CreateCollageForm
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
            this.widthLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createCollageButton = new System.Windows.Forms.Button();
            this.widthMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.heightMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(77, 28);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(131, 31);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Width cells";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(77, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height cells";
            // 
            // createCollageButton
            // 
            this.createCollageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCollageButton.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createCollageButton.ForeColor = System.Drawing.Color.White;
            this.createCollageButton.Location = new System.Drawing.Point(83, 121);
            this.createCollageButton.Name = "createCollageButton";
            this.createCollageButton.Size = new System.Drawing.Size(158, 43);
            this.createCollageButton.TabIndex = 4;
            this.createCollageButton.Text = "Create";
            this.createCollageButton.UseVisualStyleBackColor = true;
            this.createCollageButton.Click += new System.EventHandler(this.CreateCollageButton_Click);
            // 
            // widthMaskedTextBox
            // 
            this.widthMaskedTextBox.BackColor = System.Drawing.Color.CadetBlue;
            this.widthMaskedTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthMaskedTextBox.ForeColor = System.Drawing.Color.White;
            this.widthMaskedTextBox.Location = new System.Drawing.Point(214, 25);
            this.widthMaskedTextBox.Mask = "00";
            this.widthMaskedTextBox.Name = "widthMaskedTextBox";
            this.widthMaskedTextBox.Size = new System.Drawing.Size(27, 38);
            this.widthMaskedTextBox.TabIndex = 5;
            // 
            // heightMaskedTextBox
            // 
            this.heightMaskedTextBox.BackColor = System.Drawing.Color.CadetBlue;
            this.heightMaskedTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightMaskedTextBox.ForeColor = System.Drawing.Color.White;
            this.heightMaskedTextBox.Location = new System.Drawing.Point(214, 70);
            this.heightMaskedTextBox.Mask = "00";
            this.heightMaskedTextBox.Name = "heightMaskedTextBox";
            this.heightMaskedTextBox.Size = new System.Drawing.Size(27, 38);
            this.heightMaskedTextBox.TabIndex = 6;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(320, 186);
            this.Controls.Add(this.heightMaskedTextBox);
            this.Controls.Add(this.widthMaskedTextBox);
            this.Controls.Add(this.createCollageButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.widthLabel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createCollageButton;
        private System.Windows.Forms.MaskedTextBox widthMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox heightMaskedTextBox;
    }
}
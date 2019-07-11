namespace Sample_Task_01
{
    partial class FractalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FractalForm));
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.maskedTextBoxOpacity = new System.Windows.Forms.MaskedTextBox();
            this.recursionDepthLabel = new System.Windows.Forms.Label();
            this.recursionDepthTrackBar = new System.Windows.Forms.TrackBar();
            this.labelDisplayDepth = new System.Windows.Forms.Label();
            this.labelStartColor = new System.Windows.Forms.Label();
            this.buttonStartColor = new System.Windows.Forms.Button();
            this.labelEndColor = new System.Windows.Forms.Label();
            this.buttonEndColor = new System.Windows.Forms.Button();
            this.formOpacityLabel = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pictureBoxFractal = new System.Windows.Forms.PictureBox();
            this.startColorDialog = new System.Windows.Forms.ColorDialog();
            this.endColorDialog = new System.Windows.Forms.ColorDialog();
            this.panelFractal = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.controlPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.recursionDepthTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFractal)).BeginInit();
            this.panelFractal.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // hScrollBar
            // 
            this.hScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBar.Location = new System.Drawing.Point(52, 346);
            this.hScrollBar.Maximum = 109;
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(173, 21);
            this.hScrollBar.TabIndex = 0;
            this.hScrollBar.ValueChanged += new System.EventHandler(this.HScrollBar_ValueChanged);
            // 
            // maskedTextBoxOpacity
            // 
            this.maskedTextBoxOpacity.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxOpacity.ForeColor = System.Drawing.Color.Teal;
            this.maskedTextBoxOpacity.Location = new System.Drawing.Point(190, 288);
            this.maskedTextBoxOpacity.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxOpacity.Mask = "000";
            this.maskedTextBoxOpacity.Name = "maskedTextBoxOpacity";
            this.maskedTextBoxOpacity.Size = new System.Drawing.Size(42, 31);
            this.maskedTextBoxOpacity.TabIndex = 3;
            this.maskedTextBoxOpacity.TextChanged += new System.EventHandler(this.MaskedTextBoxOpacity_TextChanged);
            // 
            // recursionDepthLabel
            // 
            this.recursionDepthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recursionDepthLabel.AutoSize = true;
            this.recursionDepthLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recursionDepthLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recursionDepthLabel.Location = new System.Drawing.Point(49, 15);
            this.recursionDepthLabel.Name = "recursionDepthLabel";
            this.recursionDepthLabel.Size = new System.Drawing.Size(168, 26);
            this.recursionDepthLabel.TabIndex = 4;
            this.recursionDepthLabel.Text = "Recursion depth";
            // 
            // recursionDepthTrackBar
            // 
            this.recursionDepthTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recursionDepthTrackBar.Location = new System.Drawing.Point(46, 41);
            this.recursionDepthTrackBar.Margin = new System.Windows.Forms.Padding(20);
            this.recursionDepthTrackBar.Name = "recursionDepthTrackBar";
            this.recursionDepthTrackBar.Size = new System.Drawing.Size(189, 56);
            this.recursionDepthTrackBar.TabIndex = 5;
            this.recursionDepthTrackBar.Scroll += new System.EventHandler(this.RecursionDepthTrackBar_Scroll);
            // 
            // labelDisplayDepth
            // 
            this.labelDisplayDepth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDisplayDepth.AutoSize = true;
            this.labelDisplayDepth.BackColor = System.Drawing.Color.White;
            this.labelDisplayDepth.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDisplayDepth.ForeColor = System.Drawing.Color.Teal;
            this.labelDisplayDepth.Location = new System.Drawing.Point(214, 15);
            this.labelDisplayDepth.Name = "labelDisplayDepth";
            this.labelDisplayDepth.Size = new System.Drawing.Size(18, 26);
            this.labelDisplayDepth.TabIndex = 10;
            this.labelDisplayDepth.Text = " ";
            // 
            // labelStartColor
            // 
            this.labelStartColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStartColor.AutoSize = true;
            this.labelStartColor.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStartColor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStartColor.Location = new System.Drawing.Point(49, 131);
            this.labelStartColor.Name = "labelStartColor";
            this.labelStartColor.Size = new System.Drawing.Size(112, 26);
            this.labelStartColor.TabIndex = 12;
            this.labelStartColor.Text = "Start color";
            // 
            // buttonStartColor
            // 
            this.buttonStartColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartColor.Location = new System.Drawing.Point(165, 196);
            this.buttonStartColor.Name = "buttonStartColor";
            this.buttonStartColor.Size = new System.Drawing.Size(60, 60);
            this.buttonStartColor.TabIndex = 13;
            this.buttonStartColor.UseVisualStyleBackColor = true;
            this.buttonStartColor.Click += new System.EventHandler(this.ButtonStartColor_Click);
            // 
            // labelEndColor
            // 
            this.labelEndColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEndColor.AutoSize = true;
            this.labelEndColor.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEndColor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEndColor.Location = new System.Drawing.Point(49, 212);
            this.labelEndColor.Name = "labelEndColor";
            this.labelEndColor.Size = new System.Drawing.Size(102, 26);
            this.labelEndColor.TabIndex = 14;
            this.labelEndColor.Text = "End color";
            // 
            // buttonEndColor
            // 
            this.buttonEndColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEndColor.Location = new System.Drawing.Point(165, 115);
            this.buttonEndColor.Name = "buttonEndColor";
            this.buttonEndColor.Size = new System.Drawing.Size(60, 60);
            this.buttonEndColor.TabIndex = 15;
            this.buttonEndColor.UseVisualStyleBackColor = true;
            this.buttonEndColor.Click += new System.EventHandler(this.ButtonEndColor_Click);
            // 
            // formOpacityLabel
            // 
            this.formOpacityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formOpacityLabel.AutoSize = true;
            this.formOpacityLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formOpacityLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.formOpacityLabel.Location = new System.Drawing.Point(49, 293);
            this.formOpacityLabel.Name = "formOpacityLabel";
            this.formOpacityLabel.Size = new System.Drawing.Size(139, 26);
            this.formOpacityLabel.TabIndex = 16;
            this.formOpacityLabel.Text = "Form opacity";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.Color.Teal;
            this.buttonSave.Location = new System.Drawing.Point(79, 403);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(124, 43);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save as";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // pictureBoxFractal
            // 
            this.pictureBoxFractal.BackColor = System.Drawing.Color.White;
            this.pictureBoxFractal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxFractal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFractal.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFractal.Name = "pictureBoxFractal";
            this.pictureBoxFractal.Size = new System.Drawing.Size(680, 485);
            this.pictureBoxFractal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFractal.TabIndex = 21;
            this.pictureBoxFractal.TabStop = false;
            // 
            // panelFractal
            // 
            this.panelFractal.AutoSize = true;
            this.panelFractal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelFractal.BackColor = System.Drawing.Color.White;
            this.panelFractal.Controls.Add(this.pictureBoxFractal);
            this.panelFractal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFractal.Location = new System.Drawing.Point(297, 3);
            this.panelFractal.Name = "panelFractal";
            this.panelFractal.Size = new System.Drawing.Size(680, 485);
            this.panelFractal.TabIndex = 22;
            this.panelFractal.Resize += new System.EventHandler(this.PanelFractal_Resize);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel.Controls.Add(this.controlPanel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panelFractal, 1, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(2, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(980, 491);
            this.tableLayoutPanel.TabIndex = 23;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.controlPanel.BackColor = System.Drawing.Color.Teal;
            this.controlPanel.Controls.Add(this.buttonSave);
            this.controlPanel.Controls.Add(this.hScrollBar);
            this.controlPanel.Controls.Add(this.recursionDepthLabel);
            this.controlPanel.Controls.Add(this.recursionDepthTrackBar);
            this.controlPanel.Controls.Add(this.labelDisplayDepth);
            this.controlPanel.Controls.Add(this.labelStartColor);
            this.controlPanel.Controls.Add(this.maskedTextBoxOpacity);
            this.controlPanel.Controls.Add(this.buttonEndColor);
            this.controlPanel.Controls.Add(this.formOpacityLabel);
            this.controlPanel.Controls.Add(this.labelEndColor);
            this.controlPanel.Controls.Add(this.buttonStartColor);
            this.controlPanel.Location = new System.Drawing.Point(3, 3);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(288, 485);
            this.controlPanel.TabIndex = 0;
            // 
            // FractalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(984, 491);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FractalForm";
            ((System.ComponentModel.ISupportInitialize)(this.recursionDepthTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFractal)).EndInit();
            this.panelFractal.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxOpacity;
        private System.Windows.Forms.Label recursionDepthLabel;
        private System.Windows.Forms.TrackBar recursionDepthTrackBar;
        private System.Windows.Forms.Label labelDisplayDepth;
        private System.Windows.Forms.Label labelStartColor;
        private System.Windows.Forms.Button buttonStartColor;
        private System.Windows.Forms.Label labelEndColor;
        private System.Windows.Forms.Button buttonEndColor;
        private System.Windows.Forms.Label formOpacityLabel;
        private System.Windows.Forms.Button buttonSave;
        public System.Windows.Forms.PictureBox pictureBoxFractal;
        private System.Windows.Forms.ColorDialog startColorDialog;
        private System.Windows.Forms.ColorDialog endColorDialog;
        private System.Windows.Forms.Panel panelFractal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel controlPanel;
    }
}


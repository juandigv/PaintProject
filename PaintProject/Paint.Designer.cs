
namespace PaintProject
{
    partial class Paint
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
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.pixelLabel = new System.Windows.Forms.Label();
            this.numbersBox = new System.Windows.Forms.GroupBox();
            this.trackBarPixel = new System.Windows.Forms.TrackBar();
            this.buttonClear = new System.Windows.Forms.Button();
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.numericWidth = new System.Windows.Forms.NumericUpDown();
            this.gridButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.transformButton = new System.Windows.Forms.RadioButton();
            this.doubleButton = new System.Windows.Forms.RadioButton();
            this.buttonFill = new System.Windows.Forms.RadioButton();
            this.buttonPaint = new System.Windows.Forms.RadioButton();
            this.colorPictureBox = new System.Windows.Forms.PictureBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.algorithmBox = new System.Windows.Forms.GroupBox();
            this.buttonEllipse = new System.Windows.Forms.RadioButton();
            this.doubleClickLabel = new System.Windows.Forms.Label();
            this.buttonCircle = new System.Windows.Forms.RadioButton();
            this.buttonBresenham = new System.Windows.Forms.RadioButton();
            this.buttonDDA = new System.Windows.Forms.RadioButton();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.transformationGroup = new System.Windows.Forms.GroupBox();
            this.rotateRButton = new System.Windows.Forms.Button();
            this.rotateLButton = new System.Windows.Forms.Button();
            this.comboDirecction = new System.Windows.Forms.ComboBox();
            this.numericTraslation = new System.Windows.Forms.NumericUpDown();
            this.traslationButton = new System.Windows.Forms.Button();
            this.numericScale = new System.Windows.Forms.NumericUpDown();
            this.scaleButton = new System.Windows.Forms.Button();
            this.labelCanva = new System.Windows.Forms.Label();
            this.numbersBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPixel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).BeginInit();
            this.algorithmBox.SuspendLayout();
            this.transformationGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTraslation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericScale)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingPanel
            // 
            this.drawingPanel.AutoScroll = true;
            this.drawingPanel.BackColor = System.Drawing.Color.White;
            this.drawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingPanel.Location = new System.Drawing.Point(13, 27);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(930, 600);
            this.drawingPanel.TabIndex = 0;
            this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingPanel_Paint);
            this.drawingPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseMove);
            this.drawingPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseDoubleClick);
            this.drawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseDown);
            this.drawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseMove);
            this.drawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseUp);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(9, 31);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(38, 13);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "Width:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(9, 65);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(41, 13);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Height:";
            // 
            // pixelLabel
            // 
            this.pixelLabel.AutoSize = true;
            this.pixelLabel.Location = new System.Drawing.Point(46, 188);
            this.pixelLabel.Name = "pixelLabel";
            this.pixelLabel.Size = new System.Drawing.Size(90, 13);
            this.pixelLabel.TabIndex = 6;
            this.pixelLabel.Text = "Pixel Size / Zoom";
            // 
            // numbersBox
            // 
            this.numbersBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numbersBox.BackColor = System.Drawing.Color.Transparent;
            this.numbersBox.Controls.Add(this.pixelLabel);
            this.numbersBox.Controls.Add(this.trackBarPixel);
            this.numbersBox.Controls.Add(this.buttonClear);
            this.numbersBox.Controls.Add(this.numericHeight);
            this.numbersBox.Controls.Add(this.numericWidth);
            this.numbersBox.Controls.Add(this.gridButton);
            this.numbersBox.Controls.Add(this.heightLabel);
            this.numbersBox.Controls.Add(this.widthLabel);
            this.numbersBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.numbersBox.Location = new System.Drawing.Point(988, 12);
            this.numbersBox.Name = "numbersBox";
            this.numbersBox.Size = new System.Drawing.Size(177, 213);
            this.numbersBox.TabIndex = 7;
            this.numbersBox.TabStop = false;
            this.numbersBox.Text = "Canva Data";
            // 
            // trackBarPixel
            // 
            this.trackBarPixel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trackBarPixel.Location = new System.Drawing.Point(6, 156);
            this.trackBarPixel.Maximum = 400;
            this.trackBarPixel.Minimum = 5;
            this.trackBarPixel.Name = "trackBarPixel";
            this.trackBarPixel.Size = new System.Drawing.Size(165, 45);
            this.trackBarPixel.SmallChange = 10;
            this.trackBarPixel.TabIndex = 11;
            this.trackBarPixel.Value = 50;
            this.trackBarPixel.Scroll += new System.EventHandler(this.trackBarPixel_Scroll);
            this.trackBarPixel.ValueChanged += new System.EventHandler(this.pixelNumeric_ValueChanged);
            this.trackBarPixel.MouseCaptureChanged += new System.EventHandler(this.trackBarPixel_MouseCaptureChanged_1);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.DimGray;
            this.buttonClear.Location = new System.Drawing.Point(12, 127);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(149, 23);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear Canva";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // numericHeight
            // 
            this.numericHeight.Location = new System.Drawing.Point(67, 63);
            this.numericHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(91, 20);
            this.numericHeight.TabIndex = 10;
            this.numericHeight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericHeight.ValueChanged += new System.EventHandler(this.numeric_ValueChanged);
            // 
            // numericWidth
            // 
            this.numericWidth.Location = new System.Drawing.Point(67, 24);
            this.numericWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericWidth.Name = "numericWidth";
            this.numericWidth.Size = new System.Drawing.Size(91, 20);
            this.numericWidth.TabIndex = 9;
            this.numericWidth.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericWidth.ValueChanged += new System.EventHandler(this.numeric_ValueChanged);
            // 
            // gridButton
            // 
            this.gridButton.BackColor = System.Drawing.Color.DimGray;
            this.gridButton.Location = new System.Drawing.Point(12, 98);
            this.gridButton.Name = "gridButton";
            this.gridButton.Size = new System.Drawing.Size(149, 23);
            this.gridButton.TabIndex = 8;
            this.gridButton.Text = "Toggle Grid";
            this.gridButton.UseVisualStyleBackColor = false;
            this.gridButton.Click += new System.EventHandler(this.gridButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.transformButton);
            this.groupBox1.Controls.Add(this.doubleButton);
            this.groupBox1.Controls.Add(this.buttonFill);
            this.groupBox1.Controls.Add(this.buttonPaint);
            this.groupBox1.Controls.Add(this.colorPictureBox);
            this.groupBox1.Controls.Add(this.colorLabel);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(988, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 155);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paint Tools";
            // 
            // transformButton
            // 
            this.transformButton.AutoSize = true;
            this.transformButton.Location = new System.Drawing.Point(12, 128);
            this.transformButton.Name = "transformButton";
            this.transformButton.Size = new System.Drawing.Size(100, 17);
            this.transformButton.TabIndex = 5;
            this.transformButton.TabStop = true;
            this.transformButton.Text = "Transformations";
            this.transformButton.UseVisualStyleBackColor = true;
            this.transformButton.CheckedChanged += new System.EventHandler(this.transformButton_CheckedChanged);
            // 
            // doubleButton
            // 
            this.doubleButton.AutoSize = true;
            this.doubleButton.Location = new System.Drawing.Point(12, 104);
            this.doubleButton.Name = "doubleButton";
            this.doubleButton.Size = new System.Drawing.Size(105, 17);
            this.doubleButton.TabIndex = 4;
            this.doubleButton.TabStop = true;
            this.doubleButton.Text = "Algorithm Figures";
            this.doubleButton.UseVisualStyleBackColor = true;
            // 
            // buttonFill
            // 
            this.buttonFill.AutoSize = true;
            this.buttonFill.Location = new System.Drawing.Point(12, 80);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(62, 17);
            this.buttonFill.TabIndex = 3;
            this.buttonFill.Text = "Fill Area";
            this.buttonFill.UseVisualStyleBackColor = true;
            // 
            // buttonPaint
            // 
            this.buttonPaint.AutoSize = true;
            this.buttonPaint.Checked = true;
            this.buttonPaint.Location = new System.Drawing.Point(12, 56);
            this.buttonPaint.Name = "buttonPaint";
            this.buttonPaint.Size = new System.Drawing.Size(84, 17);
            this.buttonPaint.TabIndex = 2;
            this.buttonPaint.TabStop = true;
            this.buttonPaint.Text = "Pencil Brush";
            this.buttonPaint.UseVisualStyleBackColor = true;
            // 
            // colorPictureBox
            // 
            this.colorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPictureBox.Location = new System.Drawing.Point(49, 28);
            this.colorPictureBox.Name = "colorPictureBox";
            this.colorPictureBox.Size = new System.Drawing.Size(109, 14);
            this.colorPictureBox.TabIndex = 1;
            this.colorPictureBox.TabStop = false;
            this.colorPictureBox.Click += new System.EventHandler(this.colorPictureBox_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(9, 29);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(34, 13);
            this.colorLabel.TabIndex = 0;
            this.colorLabel.Text = "Color:";
            // 
            // algorithmBox
            // 
            this.algorithmBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.algorithmBox.BackColor = System.Drawing.Color.Transparent;
            this.algorithmBox.Controls.Add(this.buttonEllipse);
            this.algorithmBox.Controls.Add(this.doubleClickLabel);
            this.algorithmBox.Controls.Add(this.buttonCircle);
            this.algorithmBox.Controls.Add(this.buttonBresenham);
            this.algorithmBox.Controls.Add(this.buttonDDA);
            this.algorithmBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.algorithmBox.Location = new System.Drawing.Point(988, 518);
            this.algorithmBox.Name = "algorithmBox";
            this.algorithmBox.Size = new System.Drawing.Size(177, 137);
            this.algorithmBox.TabIndex = 9;
            this.algorithmBox.TabStop = false;
            this.algorithmBox.Text = "Double Click Function";
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.AutoSize = true;
            this.buttonEllipse.Location = new System.Drawing.Point(12, 92);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(101, 17);
            this.buttonEllipse.TabIndex = 4;
            this.buttonEllipse.TabStop = true;
            this.buttonEllipse.Text = "Ellipse Algorithm";
            this.buttonEllipse.UseVisualStyleBackColor = true;
            // 
            // doubleClickLabel
            // 
            this.doubleClickLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.doubleClickLabel.Location = new System.Drawing.Point(9, 112);
            this.doubleClickLabel.Name = "doubleClickLabel";
            this.doubleClickLabel.Size = new System.Drawing.Size(160, 20);
            this.doubleClickLabel.TabIndex = 3;
            this.doubleClickLabel.Text = "Waiting for 1st click";
            this.doubleClickLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCircle
            // 
            this.buttonCircle.AutoSize = true;
            this.buttonCircle.Location = new System.Drawing.Point(12, 68);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(97, 17);
            this.buttonCircle.TabIndex = 2;
            this.buttonCircle.TabStop = true;
            this.buttonCircle.Text = "Circle Algorithm";
            this.buttonCircle.UseVisualStyleBackColor = true;
            // 
            // buttonBresenham
            // 
            this.buttonBresenham.AutoSize = true;
            this.buttonBresenham.Location = new System.Drawing.Point(12, 44);
            this.buttonBresenham.Name = "buttonBresenham";
            this.buttonBresenham.Size = new System.Drawing.Size(124, 17);
            this.buttonBresenham.TabIndex = 1;
            this.buttonBresenham.Text = "Bresenham Algorithm";
            this.buttonBresenham.UseVisualStyleBackColor = true;
            // 
            // buttonDDA
            // 
            this.buttonDDA.AutoSize = true;
            this.buttonDDA.Checked = true;
            this.buttonDDA.Location = new System.Drawing.Point(12, 20);
            this.buttonDDA.Name = "buttonDDA";
            this.buttonDDA.Size = new System.Drawing.Size(94, 17);
            this.buttonDDA.TabIndex = 0;
            this.buttonDDA.TabStop = true;
            this.buttonDDA.Text = "DDA Algorithm";
            this.buttonDDA.UseVisualStyleBackColor = true;
            // 
            // hScrollBar
            // 
            this.hScrollBar.LargeChange = 1;
            this.hScrollBar.Location = new System.Drawing.Point(13, 638);
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(929, 17);
            this.hScrollBar.TabIndex = 10;
            this.hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Scroll);
            this.hScrollBar.ValueChanged += new System.EventHandler(this.hScrollBar_ValueChanged);
            this.hScrollBar.MouseCaptureChanged += new System.EventHandler(this.hScrollBar_MouseCaptureChanged);
            // 
            // vScrollBar
            // 
            this.vScrollBar.LargeChange = 1;
            this.vScrollBar.Location = new System.Drawing.Point(955, 27);
            this.vScrollBar.Maximum = 10;
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(17, 628);
            this.vScrollBar.TabIndex = 11;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
            this.vScrollBar.ValueChanged += new System.EventHandler(this.vScrollBar_ValueChanged);
            this.vScrollBar.MouseCaptureChanged += new System.EventHandler(this.vScrollBar_MouseCaptureChanged);
            // 
            // transformationGroup
            // 
            this.transformationGroup.Controls.Add(this.rotateRButton);
            this.transformationGroup.Controls.Add(this.rotateLButton);
            this.transformationGroup.Controls.Add(this.comboDirecction);
            this.transformationGroup.Controls.Add(this.numericTraslation);
            this.transformationGroup.Controls.Add(this.traslationButton);
            this.transformationGroup.Controls.Add(this.numericScale);
            this.transformationGroup.Controls.Add(this.scaleButton);
            this.transformationGroup.Enabled = false;
            this.transformationGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.transformationGroup.Location = new System.Drawing.Point(988, 231);
            this.transformationGroup.Name = "transformationGroup";
            this.transformationGroup.Size = new System.Drawing.Size(177, 120);
            this.transformationGroup.TabIndex = 12;
            this.transformationGroup.TabStop = false;
            this.transformationGroup.Text = "Transformation";
            // 
            // rotateRButton
            // 
            this.rotateRButton.BackColor = System.Drawing.Color.DimGray;
            this.rotateRButton.Location = new System.Drawing.Point(86, 80);
            this.rotateRButton.Name = "rotateRButton";
            this.rotateRButton.Size = new System.Drawing.Size(84, 23);
            this.rotateRButton.TabIndex = 6;
            this.rotateRButton.Text = "Rotate Right";
            this.rotateRButton.UseVisualStyleBackColor = false;
            this.rotateRButton.Click += new System.EventHandler(this.rotateRButton_Click);
            // 
            // rotateLButton
            // 
            this.rotateLButton.BackColor = System.Drawing.Color.DimGray;
            this.rotateLButton.Location = new System.Drawing.Point(7, 80);
            this.rotateLButton.Name = "rotateLButton";
            this.rotateLButton.Size = new System.Drawing.Size(74, 23);
            this.rotateLButton.TabIndex = 5;
            this.rotateLButton.Text = "Rotate Left";
            this.rotateLButton.UseVisualStyleBackColor = false;
            this.rotateLButton.Click += new System.EventHandler(this.rotateLButton_Click);
            // 
            // comboDirecction
            // 
            this.comboDirecction.FormattingEnabled = true;
            this.comboDirecction.Items.AddRange(new object[] {
            "⮝",
            "⮟",
            "⮜",
            "⮞"});
            this.comboDirecction.Location = new System.Drawing.Point(77, 51);
            this.comboDirecction.Name = "comboDirecction";
            this.comboDirecction.Size = new System.Drawing.Size(49, 21);
            this.comboDirecction.TabIndex = 4;
            this.comboDirecction.Text = "⮝";
            // 
            // numericTraslation
            // 
            this.numericTraslation.Location = new System.Drawing.Point(130, 52);
            this.numericTraslation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTraslation.Name = "numericTraslation";
            this.numericTraslation.Size = new System.Drawing.Size(41, 20);
            this.numericTraslation.TabIndex = 3;
            this.numericTraslation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericTraslation.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // traslationButton
            // 
            this.traslationButton.BackColor = System.Drawing.Color.Gray;
            this.traslationButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.traslationButton.Location = new System.Drawing.Point(7, 51);
            this.traslationButton.Name = "traslationButton";
            this.traslationButton.Size = new System.Drawing.Size(67, 23);
            this.traslationButton.TabIndex = 2;
            this.traslationButton.Text = "Traslation";
            this.traslationButton.UseVisualStyleBackColor = false;
            this.traslationButton.Click += new System.EventHandler(this.traslationButton_Click);
            // 
            // numericScale
            // 
            this.numericScale.DecimalPlaces = 1;
            this.numericScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericScale.Location = new System.Drawing.Point(127, 20);
            this.numericScale.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericScale.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.numericScale.Name = "numericScale";
            this.numericScale.Size = new System.Drawing.Size(43, 20);
            this.numericScale.TabIndex = 1;
            this.numericScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // scaleButton
            // 
            this.scaleButton.BackColor = System.Drawing.Color.DimGray;
            this.scaleButton.Location = new System.Drawing.Point(6, 19);
            this.scaleButton.Name = "scaleButton";
            this.scaleButton.Size = new System.Drawing.Size(113, 23);
            this.scaleButton.TabIndex = 0;
            this.scaleButton.Text = "Scaling Factor";
            this.scaleButton.UseVisualStyleBackColor = false;
            this.scaleButton.Click += new System.EventHandler(this.scaleButton_Click);
            // 
            // labelCanva
            // 
            this.labelCanva.AutoSize = true;
            this.labelCanva.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCanva.Location = new System.Drawing.Point(12, 9);
            this.labelCanva.Name = "labelCanva";
            this.labelCanva.Size = new System.Drawing.Size(40, 13);
            this.labelCanva.TabIndex = 13;
            this.labelCanva.Text = "[ 0 , 0 ]";
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1177, 668);
            this.Controls.Add(this.labelCanva);
            this.Controls.Add(this.transformationGroup);
            this.Controls.Add(this.vScrollBar);
            this.Controls.Add(this.hScrollBar);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.algorithmBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numbersBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Paint";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Paint_Load);
            this.numbersBox.ResumeLayout(false);
            this.numbersBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPixel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).EndInit();
            this.algorithmBox.ResumeLayout(false);
            this.algorithmBox.PerformLayout();
            this.transformationGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericTraslation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericScale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label pixelLabel;
        private System.Windows.Forms.GroupBox numbersBox;
        private System.Windows.Forms.Button gridButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox colorPictureBox;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.GroupBox algorithmBox;
        private System.Windows.Forms.RadioButton buttonBresenham;
        private System.Windows.Forms.RadioButton buttonDDA;
        private System.Windows.Forms.NumericUpDown numericHeight;
        private System.Windows.Forms.NumericUpDown numericWidth;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TrackBar trackBarPixel;
        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.RadioButton buttonCircle;
        private System.Windows.Forms.Label doubleClickLabel;
        private System.Windows.Forms.RadioButton buttonEllipse;
        private System.Windows.Forms.RadioButton buttonFill;
        private System.Windows.Forms.RadioButton buttonPaint;
        private System.Windows.Forms.RadioButton doubleButton;
        private System.Windows.Forms.GroupBox transformationGroup;
        private System.Windows.Forms.Button scaleButton;
        private System.Windows.Forms.RadioButton transformButton;
        private System.Windows.Forms.NumericUpDown numericScale;
        private System.Windows.Forms.ComboBox comboDirecction;
        private System.Windows.Forms.NumericUpDown numericTraslation;
        private System.Windows.Forms.Button traslationButton;
        private System.Windows.Forms.Button rotateRButton;
        private System.Windows.Forms.Button rotateLButton;
        private System.Windows.Forms.Label labelCanva;
    }
}


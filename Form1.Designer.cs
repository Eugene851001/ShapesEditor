namespace OOPLaba2
{
    partial class frmMain
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
            this.pnShapesBar = new System.Windows.Forms.Panel();
            this.btParallelogram = new System.Windows.Forms.Button();
            this.cbShowArea = new System.Windows.Forms.CheckBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btEllipse = new System.Windows.Forms.Button();
            this.btSection = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btRectangle = new System.Windows.Forms.Button();
            this.btCircle = new System.Windows.Forms.Button();
            this.btSquare = new System.Windows.Forms.Button();
            this.btTriangle = new System.Windows.Forms.Button();
            this.pnShapesBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnShapesBar
            // 
            this.pnShapesBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnShapesBar.Controls.Add(this.btParallelogram);
            this.pnShapesBar.Controls.Add(this.cbShowArea);
            this.pnShapesBar.Controls.Add(this.btClear);
            this.pnShapesBar.Controls.Add(this.btEllipse);
            this.pnShapesBar.Controls.Add(this.btSection);
            this.pnShapesBar.Controls.Add(this.btReset);
            this.pnShapesBar.Controls.Add(this.btRectangle);
            this.pnShapesBar.Controls.Add(this.btCircle);
            this.pnShapesBar.Controls.Add(this.btSquare);
            this.pnShapesBar.Controls.Add(this.btTriangle);
            this.pnShapesBar.Location = new System.Drawing.Point(677, 0);
            this.pnShapesBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnShapesBar.Name = "pnShapesBar";
            this.pnShapesBar.Size = new System.Drawing.Size(247, 562);
            this.pnShapesBar.TabIndex = 0;
            // 
            // btParallelogram
            // 
            this.btParallelogram.Location = new System.Drawing.Point(21, 206);
            this.btParallelogram.Name = "btParallelogram";
            this.btParallelogram.Size = new System.Drawing.Size(75, 35);
            this.btParallelogram.TabIndex = 9;
            this.btParallelogram.Text = "Parallelogram";
            this.btParallelogram.UseVisualStyleBackColor = true;
            this.btParallelogram.Click += new System.EventHandler(this.btParallelogram_Click);
            // 
            // cbShowArea
            // 
            this.cbShowArea.AutoSize = true;
            this.cbShowArea.Location = new System.Drawing.Point(142, 459);
            this.cbShowArea.Name = "cbShowArea";
            this.cbShowArea.Size = new System.Drawing.Size(98, 21);
            this.cbShowArea.TabIndex = 8;
            this.cbShowArea.Text = "Show Area";
            this.cbShowArea.UseVisualStyleBackColor = true;
            this.cbShowArea.CheckedChanged += new System.EventHandler(this.cbShowArea_CheckedChanged);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(155, 523);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 7;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btEllipse
            // 
            this.btEllipse.Location = new System.Drawing.Point(139, 153);
            this.btEllipse.Name = "btEllipse";
            this.btEllipse.Size = new System.Drawing.Size(75, 33);
            this.btEllipse.TabIndex = 6;
            this.btEllipse.Text = "Ellipse";
            this.btEllipse.UseVisualStyleBackColor = true;
            this.btEllipse.Click += new System.EventHandler(this.btEllipse_Click);
            // 
            // btSection
            // 
            this.btSection.Location = new System.Drawing.Point(21, 153);
            this.btSection.Name = "btSection";
            this.btSection.Size = new System.Drawing.Size(75, 33);
            this.btSection.TabIndex = 5;
            this.btSection.Text = "Section";
            this.btSection.UseVisualStyleBackColor = true;
            this.btSection.Click += new System.EventHandler(this.btSection_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(21, 523);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 4;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btRectangle
            // 
            this.btRectangle.Location = new System.Drawing.Point(140, 100);
            this.btRectangle.Name = "btRectangle";
            this.btRectangle.Size = new System.Drawing.Size(75, 31);
            this.btRectangle.TabIndex = 3;
            this.btRectangle.Text = "Rectangle";
            this.btRectangle.UseVisualStyleBackColor = true;
            this.btRectangle.Click += new System.EventHandler(this.btRectangle_Click);
            // 
            // btCircle
            // 
            this.btCircle.Location = new System.Drawing.Point(21, 100);
            this.btCircle.Name = "btCircle";
            this.btCircle.Size = new System.Drawing.Size(75, 31);
            this.btCircle.TabIndex = 2;
            this.btCircle.Text = "Circle";
            this.btCircle.UseVisualStyleBackColor = true;
            this.btCircle.Click += new System.EventHandler(this.btCircle_Click);
            // 
            // btSquare
            // 
            this.btSquare.Location = new System.Drawing.Point(139, 31);
            this.btSquare.Name = "btSquare";
            this.btSquare.Size = new System.Drawing.Size(75, 29);
            this.btSquare.TabIndex = 1;
            this.btSquare.Text = "Square";
            this.btSquare.UseVisualStyleBackColor = true;
            this.btSquare.Click += new System.EventHandler(this.btSquare_Click);
            // 
            // btTriangle
            // 
            this.btTriangle.Location = new System.Drawing.Point(21, 31);
            this.btTriangle.Name = "btTriangle";
            this.btTriangle.Size = new System.Drawing.Size(75, 29);
            this.btTriangle.TabIndex = 0;
            this.btTriangle.Text = "Triangle";
            this.btTriangle.UseVisualStyleBackColor = true;
            this.btTriangle.Click += new System.EventHandler(this.btTriangle_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 558);
            this.Controls.Add(this.pnShapesBar);
            this.Name = "frmMain";
            this.Text = "Editor2D v2.0";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Click += new System.EventHandler(this.frmMain_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.pnShapesBar.ResumeLayout(false);
            this.pnShapesBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnShapesBar;
        private System.Windows.Forms.Button btCircle;
        private System.Windows.Forms.Button btSquare;
        private System.Windows.Forms.Button btTriangle;
        private System.Windows.Forms.Button btRectangle;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btEllipse;
        private System.Windows.Forms.Button btSection;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.CheckBox cbShowArea;
        private System.Windows.Forms.Button btParallelogram;
    }
}


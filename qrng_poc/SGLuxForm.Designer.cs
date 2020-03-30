namespace SGLux
{
  partial class SGLuxForm
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
      this.groupBoxInformation = new System.Windows.Forms.GroupBox();
      this.checkBoxFiles = new System.Windows.Forms.CheckBox();
      this.textBoxInfo = new System.Windows.Forms.TextBox();
      this.groupBoxData = new System.Windows.Forms.GroupBox();
      this.label0 = new System.Windows.Forms.Label();      
      this.textBoxFileName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();      
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();      
      this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
      this.buttonGenerate = new System.Windows.Forms.Button();
      this.textBoxBuffer = new System.Windows.Forms.TextBox();
      this.groupBoxInformation.SuspendLayout();
      this.groupBoxData.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBoxInformation
      // 
      this.groupBoxInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxInformation.AutoSize = true;
      this.groupBoxInformation.Controls.Add(this.textBoxInfo);
      this.groupBoxInformation.Location = new System.Drawing.Point(12, 207);
      this.groupBoxInformation.Name = "groupBoxInformation";
      this.groupBoxInformation.Size = new System.Drawing.Size(601, 141);
      this.groupBoxInformation.TabIndex = 1;
      this.groupBoxInformation.TabStop = false;
      this.groupBoxInformation.Text = "Information";
      // 
      // textBoxInfo
      // 
      this.textBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxInfo.Location = new System.Drawing.Point(11, 19);
      this.textBoxInfo.Multiline = true;
      this.textBoxInfo.Name = "textBoxInfo";
      this.textBoxInfo.ReadOnly = true;
      this.textBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBoxInfo.Size = new System.Drawing.Size(576, 106);
      this.textBoxInfo.TabIndex = 0;
      // 
      // groupBoxData
      // 
      this.groupBoxData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxData.Controls.Add(this.checkBoxFiles);
      this.groupBoxData.Controls.Add(this.label0);
      this.groupBoxData.Controls.Add(this.textBoxFileName);
      this.groupBoxData.Controls.Add(this.label1);
      this.groupBoxData.Controls.Add(this.numericUpDown1);
      this.groupBoxData.Controls.Add(this.label2);
      this.groupBoxData.Controls.Add(this.numericUpDown2);
      this.groupBoxData.Controls.Add(this.buttonGenerate);
      this.groupBoxData.Controls.Add(this.textBoxBuffer);
      this.groupBoxData.Location = new System.Drawing.Point(14, 10);
      this.groupBoxData.Name = "groupBoxData";
      this.groupBoxData.Size = new System.Drawing.Size(597, 189);
      this.groupBoxData.TabIndex = 2;
      this.groupBoxData.TabStop = false;
      this.groupBoxData.Text = "Parameters";
      //
      // checkBoxFiles : if check create multiple files, 1 per underlying, otherwise create 1 file with columns per underlying
      //
      this.checkBoxFiles.Text = "Multiple files";
      this.checkBoxFiles.Name = "checkBoxFiles";
      this.checkBoxFiles.Location = new System.Drawing.Point(450, 70);
       
      //
      // label0
      // 
      this.label0.AutoSize = true;
      this.label0.Location = new System.Drawing.Point(14, 70);
      this.label0.Name = "label0";
      this.label0.Size = new System.Drawing.Size(140, 13);
      this.label0.TabIndex = 3;
      this.label0.Text = "File name:";
      //
      // textBoxFileName
      // 
      this.textBoxFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxFileName.Location = new System.Drawing.Point(140, 70);
      this.textBoxFileName.Multiline = false;
      this.textBoxFileName.Name = "textBoxFileName";
      this.textBoxFileName.ReadOnly = false;
      this.textBoxFileName.Size = new System.Drawing.Size(300, 13);
      this.textBoxFileName.TabIndex = 0;
      //
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(14, 95);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(140, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Random Numbers:";
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Location = new System.Drawing.Point(140, 95);
      this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(61, 20);
      this.numericUpDown1.TabIndex = 2;
      this.numericUpDown1.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(14, 120);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(140, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Number of underlyings:";
      // 
      // numericUpDown2
      // 
      this.numericUpDown2.Location = new System.Drawing.Point(140, 120);
      this.numericUpDown2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
      this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown2.Name = "numericUpDown2";
      this.numericUpDown2.Size = new System.Drawing.Size(61, 20);
      this.numericUpDown2.TabIndex = 2;
      this.numericUpDown2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      // 
      // buttonGenerate
      // 
      this.buttonGenerate.Location = new System.Drawing.Point(231, 150);
      this.buttonGenerate.Name = "buttonGenerate";
      this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
      this.buttonGenerate.TabIndex = 1;
      this.buttonGenerate.Text = "Generate";
      this.buttonGenerate.UseVisualStyleBackColor = true;
      this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
      // 
      // textBoxBuffer
      // 
      this.textBoxBuffer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxBuffer.Location = new System.Drawing.Point(17, 22);
      this.textBoxBuffer.Multiline = true;
      this.textBoxBuffer.Name = "textBoxBuffer";
      this.textBoxBuffer.ReadOnly = true;
      this.textBoxBuffer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBoxBuffer.Size = new System.Drawing.Size(566, 40);
      this.textBoxBuffer.TabIndex = 0;
      // 
      // SGLuxForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(624, 359);
      this.Controls.Add(this.groupBoxData);
      this.Controls.Add(this.groupBoxInformation);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Quantis Random Pricing";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Quantis Random Princing generator";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBoxInformation.ResumeLayout(false);
      this.groupBoxInformation.PerformLayout();
      this.groupBoxData.ResumeLayout(false);
      this.groupBoxData.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBoxInformation;
    private System.Windows.Forms.TextBox textBoxInfo;
    private System.Windows.Forms.GroupBox groupBoxData;
    private System.Windows.Forms.Label label0;
    private System.Windows.Forms.TextBox textBoxFileName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown numericUpDown2;
    private System.Windows.Forms.Button buttonGenerate;
    private System.Windows.Forms.TextBox textBoxBuffer;
    private System.Windows.Forms.CheckBox checkBoxFiles;
  }
}


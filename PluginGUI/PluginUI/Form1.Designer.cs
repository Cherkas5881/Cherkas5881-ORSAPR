
namespace PluginUI
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.WidthBookcaseNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.HeightBookcaseNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.DepthBookcaseNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.HeightShelfNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.MaterialThicknessNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.WidthBookcaseLabel = new System.Windows.Forms.Label();
			this.HeightBookcaseLabel = new System.Windows.Forms.Label();
			this.DepthBookcaseLabel = new System.Windows.Forms.Label();
			this.MaterialThicknessLabel = new System.Windows.Forms.Label();
			this.HeightShelfLabel = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.LegTypeCombobox = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.WidthBookcaseNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HeightBookcaseNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DepthBookcaseNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HeightShelfNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MaterialThicknessNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// WidthBookcaseNumericUpDown
			// 
			this.WidthBookcaseNumericUpDown.Location = new System.Drawing.Point(144, 8);
			this.WidthBookcaseNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.WidthBookcaseNumericUpDown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
			this.WidthBookcaseNumericUpDown.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.WidthBookcaseNumericUpDown.Name = "WidthBookcaseNumericUpDown";
			this.WidthBookcaseNumericUpDown.Size = new System.Drawing.Size(112, 20);
			this.WidthBookcaseNumericUpDown.TabIndex = 1;
			this.WidthBookcaseNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.WidthBookcaseNumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
			// 
			// HeightBookcaseNumericUpDown
			// 
			this.HeightBookcaseNumericUpDown.Location = new System.Drawing.Point(144, 36);
			this.HeightBookcaseNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.HeightBookcaseNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
			this.HeightBookcaseNumericUpDown.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            0});
			this.HeightBookcaseNumericUpDown.Name = "HeightBookcaseNumericUpDown";
			this.HeightBookcaseNumericUpDown.Size = new System.Drawing.Size(112, 20);
			this.HeightBookcaseNumericUpDown.TabIndex = 2;
			this.HeightBookcaseNumericUpDown.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
			this.HeightBookcaseNumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
			// 
			// DepthBookcaseNumericUpDown
			// 
			this.DepthBookcaseNumericUpDown.Location = new System.Drawing.Point(144, 64);
			this.DepthBookcaseNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DepthBookcaseNumericUpDown.Maximum = new decimal(new int[] {
            700,
            0,
            0,
            0});
			this.DepthBookcaseNumericUpDown.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.DepthBookcaseNumericUpDown.Name = "DepthBookcaseNumericUpDown";
			this.DepthBookcaseNumericUpDown.Size = new System.Drawing.Size(112, 20);
			this.DepthBookcaseNumericUpDown.TabIndex = 3;
			this.DepthBookcaseNumericUpDown.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.DepthBookcaseNumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
			// 
			// HeightShelfNumericUpDown
			// 
			this.HeightShelfNumericUpDown.Location = new System.Drawing.Point(144, 94);
			this.HeightShelfNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.HeightShelfNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.HeightShelfNumericUpDown.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
			this.HeightShelfNumericUpDown.Name = "HeightShelfNumericUpDown";
			this.HeightShelfNumericUpDown.Size = new System.Drawing.Size(112, 20);
			this.HeightShelfNumericUpDown.TabIndex = 4;
			this.HeightShelfNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.HeightShelfNumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
			// 
			// MaterialThicknessNumericUpDown
			// 
			this.MaterialThicknessNumericUpDown.Location = new System.Drawing.Point(144, 122);
			this.MaterialThicknessNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaterialThicknessNumericUpDown.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.MaterialThicknessNumericUpDown.Name = "MaterialThicknessNumericUpDown";
			this.MaterialThicknessNumericUpDown.Size = new System.Drawing.Size(112, 20);
			this.MaterialThicknessNumericUpDown.TabIndex = 5;
			this.MaterialThicknessNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.MaterialThicknessNumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(144, 177);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 32);
			this.button1.TabIndex = 6;
			this.button1.Text = "Построить модель";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Ширина шкафа:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Высота шкафа:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Глубина шкафа:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 95);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Высота полок:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 123);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(131, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Толщина стенки шкафа:";
			// 
			// WidthBookcaseLabel
			// 
			this.WidthBookcaseLabel.AutoSize = true;
			this.WidthBookcaseLabel.Location = new System.Drawing.Point(261, 8);
			this.WidthBookcaseLabel.Name = "WidthBookcaseLabel";
			this.WidthBookcaseLabel.Size = new System.Drawing.Size(100, 13);
			this.WidthBookcaseLabel.TabIndex = 12;
			this.WidthBookcaseLabel.Text = "от 500 до 3000 мм";
			// 
			// HeightBookcaseLabel
			// 
			this.HeightBookcaseLabel.AutoSize = true;
			this.HeightBookcaseLabel.Location = new System.Drawing.Point(261, 36);
			this.HeightBookcaseLabel.Name = "HeightBookcaseLabel";
			this.HeightBookcaseLabel.Size = new System.Drawing.Size(100, 13);
			this.HeightBookcaseLabel.TabIndex = 13;
			this.HeightBookcaseLabel.Text = "от 400 до 2000 мм";
			// 
			// DepthBookcaseLabel
			// 
			this.DepthBookcaseLabel.AutoSize = true;
			this.DepthBookcaseLabel.Location = new System.Drawing.Point(261, 64);
			this.DepthBookcaseLabel.Name = "DepthBookcaseLabel";
			this.DepthBookcaseLabel.Size = new System.Drawing.Size(94, 13);
			this.DepthBookcaseLabel.TabIndex = 14;
			this.DepthBookcaseLabel.Text = "от 200 до 700 мм";
			// 
			// MaterialThicknessLabel
			// 
			this.MaterialThicknessLabel.AutoSize = true;
			this.MaterialThicknessLabel.Location = new System.Drawing.Point(261, 122);
			this.MaterialThicknessLabel.Name = "MaterialThicknessLabel";
			this.MaterialThicknessLabel.Size = new System.Drawing.Size(88, 13);
			this.MaterialThicknessLabel.TabIndex = 15;
			this.MaterialThicknessLabel.Text = "от 20 до 100 мм";
			// 
			// HeightShelfLabel
			// 
			this.HeightShelfLabel.AutoSize = true;
			this.HeightShelfLabel.Location = new System.Drawing.Point(261, 95);
			this.HeightShelfLabel.Name = "HeightShelfLabel";
			this.HeightShelfLabel.Size = new System.Drawing.Size(88, 13);
			this.HeightShelfLabel.TabIndex = 16;
			this.HeightShelfLabel.Text = "от 40 до 200 мм";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::PluginUI.Properties.Resources.Bookcase;
			this.pictureBox1.Location = new System.Drawing.Point(378, 8);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(84, 205);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 151);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "Тип ножек:";
			// 
			// LegTypeCombobox
			// 
			this.LegTypeCombobox.Cursor = System.Windows.Forms.Cursors.Default;
			this.LegTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.LegTypeCombobox.Location = new System.Drawing.Point(144, 148);
			this.LegTypeCombobox.Name = "LegTypeCombobox";
			this.LegTypeCombobox.Size = new System.Drawing.Size(112, 21);
			this.LegTypeCombobox.TabIndex = 18;
			this.LegTypeCombobox.SelectedIndexChanged += new System.EventHandler(this.LegTypeCombobox_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 220);
			this.Controls.Add(this.LegTypeCombobox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.HeightShelfLabel);
			this.Controls.Add(this.MaterialThicknessLabel);
			this.Controls.Add(this.DepthBookcaseLabel);
			this.Controls.Add(this.HeightBookcaseLabel);
			this.Controls.Add(this.WidthBookcaseLabel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.MaterialThicknessNumericUpDown);
			this.Controls.Add(this.HeightShelfNumericUpDown);
			this.Controls.Add(this.DepthBookcaseNumericUpDown);
			this.Controls.Add(this.HeightBookcaseNumericUpDown);
			this.Controls.Add(this.WidthBookcaseNumericUpDown);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Плагин";
			((System.ComponentModel.ISupportInitialize)(this.WidthBookcaseNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HeightBookcaseNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DepthBookcaseNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HeightShelfNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MaterialThicknessNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.NumericUpDown WidthBookcaseNumericUpDown;
		private System.Windows.Forms.NumericUpDown HeightBookcaseNumericUpDown;
		private System.Windows.Forms.NumericUpDown DepthBookcaseNumericUpDown;
		private System.Windows.Forms.NumericUpDown HeightShelfNumericUpDown;
		private System.Windows.Forms.NumericUpDown MaterialThicknessNumericUpDown;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label WidthBookcaseLabel;
		private System.Windows.Forms.Label HeightBookcaseLabel;
		private System.Windows.Forms.Label DepthBookcaseLabel;
		private System.Windows.Forms.Label MaterialThicknessLabel;
		private System.Windows.Forms.Label HeightShelfLabel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox LegTypeCombobox;
	}
}


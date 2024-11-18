namespace WindowsFormsComputer
{
	partial class AddEquipmentForm
	{

		private System.ComponentModel.IContainer components = null;


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
			this.label1 = new System.Windows.Forms.Label();
			this.BrandTextBox = new System.Windows.Forms.TextBox();
			this.CpuBrandTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.RamTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.PriceTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.TypeComboBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.AddButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Бренд";
			// 
			// BrandTextBox
			// 
			this.BrandTextBox.Location = new System.Drawing.Point(104, 6);
			this.BrandTextBox.Name = "BrandTextBox";
			this.BrandTextBox.Size = new System.Drawing.Size(196, 20);
			this.BrandTextBox.TabIndex = 1;
			// 
			// CpuBrandTextBox
			// 
			this.CpuBrandTextBox.Location = new System.Drawing.Point(104, 32);
			this.CpuBrandTextBox.Name = "CpuBrandTextBox";
			this.CpuBrandTextBox.Size = new System.Drawing.Size(196, 20);
			this.CpuBrandTextBox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Процессор";
			// 
			// RamTextBox
			// 
			this.RamTextBox.Location = new System.Drawing.Point(104, 58);
			this.RamTextBox.Name = "RamTextBox";
			this.RamTextBox.Size = new System.Drawing.Size(196, 20);
			this.RamTextBox.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "RAM";
			// 
			// PriceTextBox
			// 
			this.PriceTextBox.Location = new System.Drawing.Point(104, 84);
			this.PriceTextBox.Name = "PriceTextBox";
			this.PriceTextBox.Size = new System.Drawing.Size(196, 20);
			this.PriceTextBox.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Цена";
			// 
			// TypeComboBox
			// 
			this.TypeComboBox.FormattingEnabled = true;
			this.TypeComboBox.Items.AddRange(new object[] {
            "Компьютерное оборудование",
            "ПК",
            "Ноутбук"});
			this.TypeComboBox.Location = new System.Drawing.Point(104, 111);
			this.TypeComboBox.Name = "TypeComboBox";
			this.TypeComboBox.Size = new System.Drawing.Size(196, 21);
			this.TypeComboBox.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Тип устройства";
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(15, 141);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(83, 23);
			this.AddButton.TabIndex = 10;
			this.AddButton.Text = "Добавить";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(217, 141);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(83, 23);
			this.CancelButton.TabIndex = 11;
			this.CancelButton.Text = "Отмена";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// AddEquipmentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(312, 176);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.TypeComboBox);
			this.Controls.Add(this.PriceTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.RamTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.CpuBrandTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.BrandTextBox);
			this.Controls.Add(this.label1);
			this.Name = "AddEquipmentForm";
			this.Text = "Добавить товар";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox BrandTextBox;
		private System.Windows.Forms.TextBox CpuBrandTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox RamTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox PriceTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox TypeComboBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button CancelButton;
	}
}
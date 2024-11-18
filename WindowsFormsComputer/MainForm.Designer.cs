namespace WindowsFormsComputer
{
	partial class MainForm
	{

		/// Обязательная переменная конструктора.

		private System.ComponentModel.IContainer components = null;


		/// Освободить все используемые ресурсы.

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
			this.EquipmentListBox = new System.Windows.Forms.ListBox();
			this.AddButton = new System.Windows.Forms.Button();
			this.RemoveButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// EquipmentListBox
			// 
			this.EquipmentListBox.FormattingEnabled = true;
			this.EquipmentListBox.HorizontalExtent = 100;
			this.EquipmentListBox.HorizontalScrollbar = true;
			this.EquipmentListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.EquipmentListBox.Location = new System.Drawing.Point(12, 12);
			this.EquipmentListBox.Name = "EquipmentListBox";
			this.EquipmentListBox.Size = new System.Drawing.Size(581, 186);
			this.EquipmentListBox.TabIndex = 0;
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(599, 12);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(75, 23);
			this.AddButton.TabIndex = 1;
			this.AddButton.Text = "Добавить";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// RemoveButton
			// 
			this.RemoveButton.Location = new System.Drawing.Point(599, 41);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(75, 23);
			this.RemoveButton.TabIndex = 2;
			this.RemoveButton.Text = "Удалить";
			this.RemoveButton.UseVisualStyleBackColor = true;
			this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(599, 175);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(75, 23);
			this.ExitButton.TabIndex = 3;
			this.ExitButton.Text = "Выход";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(686, 211);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.RemoveButton);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.EquipmentListBox);
			this.Name = "MainForm";
			this.Text = "Главное окно";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox EquipmentListBox;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button RemoveButton;
		private System.Windows.Forms.Button ExitButton;
	}
}


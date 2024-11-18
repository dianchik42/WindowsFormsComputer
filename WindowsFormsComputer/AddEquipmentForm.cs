using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsComputer.Models;

namespace WindowsFormsComputer
{
	public partial class AddEquipmentForm : Form
	{
		public ComputerEquipment Equipment { get; private set; }

		public AddEquipmentForm()
		{
			InitializeComponent();
			TypeComboBox.SelectedIndex = 0; 
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			string brand = BrandTextBox.Text;
			string cpuBrand = CpuBrandTextBox.Text;
			int.TryParse(RamTextBox.Text, out int ram);
			int.TryParse(PriceTextBox.Text, out int price);

			switch (TypeComboBox.SelectedIndex)
			{
				case 0:
					Equipment = new ComputerEquipment(brand, cpuBrand, ram, price);
					break;
				case 1:
					Equipment = new PersonalComputer(brand, cpuBrand, ram, price);
					break;
				case 2:
					Equipment = new Laptop(brand, cpuBrand, ram, price);
					break;
				default:
					MessageBox.Show("Выберите тип устройства!", "Ошибка");
					return;
			}

			DialogResult = DialogResult.OK;
			Close();
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}

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
	public partial class MainForm : Form
	{
		private List<ComputerEquipment> equipmentList = new List<ComputerEquipment>();

		public MainForm()
		{
			InitializeComponent();
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			using (var addForm = new AddEquipmentForm())
			{
				if (addForm.ShowDialog() == DialogResult.OK)
				{
					equipmentList.Add(addForm.Equipment);
					UpdateEquipmentList();
				}
			}
		}

		private void UpdateEquipmentList()
		{
			EquipmentListBox.Items.Clear();
			foreach (var equipment in equipmentList)
			{
				EquipmentListBox.Items.Add(equipment.GetInfo());
			}
		}

		private void RemoveButton_Click(object sender, EventArgs e)
		{
			if (EquipmentListBox.SelectedIndex != -1)
			{
				equipmentList.RemoveAt(EquipmentListBox.SelectedIndex);
				UpdateEquipmentList();
			}
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		
	}
}

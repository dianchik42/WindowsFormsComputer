using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsComputer.Models
{
	public class ComputerEquipment
	{
		public string Brand { get; set; }
		public string CpuBrand { get; set; }
		public int Ram { get; set; }
		public int Price { get; set; }

		public ComputerEquipment(string brand = "Неизвестный", string cpuBrand = "Неизвестный", int ram = 0, int price = 0)
		{
			Brand = brand;
			CpuBrand = cpuBrand;
			Ram = ram;
			Price = price;
		}

		public virtual string GetInfo()
		{
			return $"Бренд: {Brand}\n Бренд процессора: {CpuBrand}\n ОЗУ: {Ram} Гб\n Цена: {Price} руб.";
		}
	}

	public class PersonalComputer : ComputerEquipment
	{
		public PersonalComputer(string brand = "Неизвестный", string cpuBrand = "Неизвестный", int ram = 0, int price = 0)
			: base(brand, cpuBrand, ram, price)
		{
		}

		public override string GetInfo()
		{
			return "Персональный компьютер\n " + base.GetInfo();
		}
	}

	public class Laptop : ComputerEquipment
	{
		public Laptop(string brand = "Неизвестный", string cpuBrand = "Неизвестный", int ram = 0, int price = 0)
			: base(brand, cpuBrand, ram, price)
		{
		}

		public override string GetInfo()
		{
			return "Ноутбук\n " + base.GetInfo();
		}
	}
}

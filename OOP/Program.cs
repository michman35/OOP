using System;

namespace OOP
{
	class Program
	{
		static void Main(string[] args)
		{
			Building building = new Building();
			building.SetHeight(1000);
			building.SetNumberFloors(5);
			building.SetNumberApartments(100);
			building.SetNumberEntrances(4);

			Console.WriteLine($@"высота этажа {building.GetApartmentHeight()}");
			Console.WriteLine($@"кол-во квартир в подьезде {building.GetApartmentsInEntrances()}");
			Console.WriteLine($@"кол-во квартир на этаже {building.GetApartmentsInFloor()}");
		}
	}
}

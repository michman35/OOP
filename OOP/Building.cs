using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

	class Building
	{
		private static int _numberBuildingId;

		public int NumberBuilding { get; }
		private float Height;
		private int NumberFloors;
		private int NumberApartments;
		private int NumberEntrances;

		public Building()
		{
			_numberBuildingId++;
			NumberBuilding = _numberBuildingId;
		} 

		
		public float GetHeight()
		{
			return Height;
		}
		public void SetHeight(float height)
		{
			Height = height;
		}
		public int GetNumberFloors()
		{
			return NumberFloors;
		}
		public void SetNumberFloors(int numberFloors)
		{
			NumberFloors = numberFloors;
		}
		public int GetNumberApartments()
		{
			return NumberApartments;
		}
		public void SetNumberApartments(int numberApartments)
		{
			NumberApartments = numberApartments;
		}
		public int GetNumberEntrances()
		{
			return NumberEntrances;
		}
		public void SetNumberEntrances(int numberEntrances)
		{
			NumberEntrances = numberEntrances;
		}

		public float GetApartmentHeight()
		{
			return Height / NumberFloors;
		}

		public int GetApartmentsInEntrances()
		{
			return (int)Math.Round(NumberApartments / NumberEntrances * 1.0d);
		}
		
		public int GetApartmentsInFloor()
		{
			return NumberApartments / NumberFloors;
		}



	}


}

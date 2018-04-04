using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinskGuide.Core.Entities;
using MinskGuide.Core.Enums;

namespace MinskGuide.Core.Services.Realization
{
	public class DataService : ILocalData
	{
		private List<Activity> DataList;

		public DataService()
		{
			DataList = new List<Activity>();
			Init();
		}

		public IEnumerable<Activity> GetActivities(ActivityTypeEnum type)
		{
			return DataList.Where(a => a.ActivityType == type);
		}

		private void Init()
		{
			DataList.Add(new BankActivity { Name = "Priorbank", Address = "Marks 2", Number = "11111111", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786 });
			DataList.Add(new BankActivity { Name = "Alfa bank", Address = "Engels 23", Number = "22222222", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786 });
			DataList.Add(new BankActivity { Name = "Belarusbank", Address = "Btylya 142", Number = "11111333111", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786 });
			DataList.Add(new BankActivity { Name = "Euro bank", Address = "Gastello 42", Number = "1111143111", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786 });

			DataList.Add(new FoodActivity { Name = "Salateira", Address = "Nemanskaya 21", Number = "684889165", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786 });
			DataList.Add(new FoodActivity { Name = "Mac", Address = "Nemiga 55", Number = "5554646", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786 });
			DataList.Add(new FoodActivity { Name = "KFC", Address = "Nemiga 77", Number = "7735158", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786 });
			DataList.Add(new FoodActivity { Name = "DOM", Address = "Revolutsionnaya 12", Number = "65868351", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786 });

			DataList.Add(new HospitalActivity { Name = "Poliklinika 1", Address = "Bedu 12", Number = "12121212", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786 });
			DataList.Add(new HospitalActivity { Name = "Hospital 4", Address = "Kamenskaya 103", Number = "4444444", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786 });
			DataList.Add(new HospitalActivity { Name = "Poliklinika 14", Address = "Marks 26", Number = "14141414", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786 });
			DataList.Add(new HospitalActivity { Name = "Hospital 10", Address = "Kamenskaya 1", Number = "10101010", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786 });

			DataList.Add(new PlaceActivity { Name = "Red Church", Address = "Nezavisimosti 1", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786});
			DataList.Add(new PlaceActivity { Name = "Gorky park", Address = "Nezavisimosti 40", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786 });
			DataList.Add(new PlaceActivity { Name = "Independence square", Address = "Nezavisimosti 13", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786});
			DataList.Add(new PlaceActivity { Name = "National Libtaty", Address = "Nezavisimosti 88", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786});

			DataList.Add(new HotelActivity { Name = "Tia Hotel", Address = "Latusa 2", Number = "12312323", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786 });
			DataList.Add(new HotelActivity { Name = "Hotel BELARUS", Address = "Gorkogo 140", Number = "444554555", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786 });
			DataList.Add(new HotelActivity { Name = "Minsk hotel", Address = "Oktoberskaya 25", Number = "12989898", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786 });
			DataList.Add(new HotelActivity { Name = "Free hotel", Address = "Pushkina 12", Number = "463856456", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786 });

			DataList.Add(new RelaxActivity { Name = "Bar 1", Address = "Marks 21", Number = "6511548", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786 });
			DataList.Add(new RelaxActivity { Name = "Bar 2", Address = "Revolutsionnaya 12", Number = "21318485", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786 });
			DataList.Add(new RelaxActivity { Name = "Cinema Belarus", Address = "Lenina 12", Number = "877984515", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786 });
			DataList.Add(new RelaxActivity { Name = "Cinema Dom", Address = "Nezavisimosti 4", Number = "58648451", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786 });

			DataList.Add(new TexiActivity { Name = "UBER", Number = "15487", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786 });
			DataList.Add(new TexiActivity { Name = "132", Number = "132", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786 });
			DataList.Add(new TexiActivity { Name = "7788", Number = "7788", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786 });
			DataList.Add(new TexiActivity { Name = "135", Number = "135", ImageUrl = "REDCHURCH.jpg", Lat = 53.9270619, Long = 27.68159786 });
		}
	}
}

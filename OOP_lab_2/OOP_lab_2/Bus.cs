using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab_2
{
     internal partial class Bus {
        private static int _busesConut;

        private readonly int _busId;
        private int _routeId;

        private float _ride;

        private string _driver;
        private string _busMark;

        private DateTime _startExploreDate;

        public static int bussesCount { get => _busesConut; }

        public int busId { get => _busId; }
        public int routeId { get => _routeId; set { _routeId = value; } }
        public float ride { get => _ride; }
        public string driver { get => _driver; set { _driver = value; } }
        public string busMark { get => _busMark; }
        public DateTime startExploreDate { get => _startExploreDate; }

        static Bus() {
            _busesConut = 0;
        }

        public Bus() {
            Console.Write("\nEnter bus id: ");
            _busId = int.TryParse(Console.ReadLine(), out int busId) ? busId : 0;

            Console.Write("Enter route id: ");
            _routeId = int.TryParse(Console.ReadLine(), out int routeId) ? routeId : 0;

            Console.Write("Enter ride: ");
            _ride = float.TryParse(Console.ReadLine(), out float ride) ? ride : 0;

            Console.Write("Enter driver: ");
            _driver = Console.ReadLine();

            Console.Write("Enter bus mark: ");
            _busMark = Console.ReadLine();

            Console.Write("Enter start explore date (yyyy.mm.dd): ");
            GetStartExploreDate(Console.ReadLine(), ref _startExploreDate);

            _busesConut++;
        }
        
        public Bus(int routeId, int busId, float ride, string driver, string carMark, DateTime startExploreDate) {
            _routeId = routeId;
            _ride = ride;
            _driver = driver;
            _busId = busId;
            _busMark = carMark;
            _startExploreDate = startExploreDate;

            _busesConut++;
        }

        public Bus(string driver, string carMark, DateTime startExploreDate, float ride = 0, int routeId = 9898, int busId = 6969)
            : this(routeId, busId, ride, driver, carMark, startExploreDate) { }

        private Bus(int id) {
            Console.WriteLine(id);
        }

        private void GetStartExploreDate(string date, ref DateTime dateTime) {
            string[] dateArr = date.Split('.');

            dateTime = new DateTime(int.Parse(dateArr[0]), int.Parse(dateArr[1]), int.Parse(dateArr[2]));
        }

        public int GetBusAge() => DateTime.Now.Year - _startExploreDate.Year;

        public static void GetInfoAboutClass() {
            Console.WriteLine("This class was created to show work with class");
        }
    }
}

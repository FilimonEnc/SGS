using SGS.Interfaces;
using SGS.Model;
using SGS.StaticData;
using SGS.ViewModel;
using System.Collections.ObjectModel;
using System.Linq;

namespace SGS.DesignViewModel
{
    class MainVindowDVM : IMainWindowVM
    {
        /// <summary>
        /// Загатовленные данные
        /// </summary>
        private static readonly StaticDataMainWindow StaticData = new();
        public MainVindowDVM()
        {
            Cities = StaticData.CitiesData;
            Workshops = Cities.FirstOrDefault()!.workshopModels;
            Employees = Workshops.FirstOrDefault()!.Employees;
        }

        public ObservableCollection<CityModel> Cities { get; set; } = new();
        public ObservableCollection<string> Brigades { get; set; } = new();
        public ObservableCollection<EmployeeModel> Employees { get; set; } = new();
        public ObservableCollection<WorkshopModel> Workshops { get; set; } = new();
        public string Shift { get ; set; }
        public string Brigade { get;set; }
       
    }
}

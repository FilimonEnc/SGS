using SGS.Model;
using System.Collections.ObjectModel;

namespace SGS.Interfaces
{
    internal interface IMainWindowVM
    {

        ObservableCollection<string> Brigades { get; }
        ObservableCollection<EmployeeModel> Employees { get; }
        ObservableCollection<WorkshopModel> Workshops { get; }
        ObservableCollection<CityModel> Cities { get; set; }
        string Shift { get; set; }
        string Brigade { get; set; }
       
    }
}
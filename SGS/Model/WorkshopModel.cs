using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SGS.Model
{
    class WorkshopModel
    {
        public string NameWorkshop { get; set; } = string.Empty;

        public CityModel? CityModel { get; set; }

        public ObservableCollection<EmployeeModel> Employees { get; set; } = null!;
    }
}

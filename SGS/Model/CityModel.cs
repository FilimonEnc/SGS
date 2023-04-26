using System.Collections.ObjectModel;

namespace SGS.Model
{
    class CityModel
    {
        public string NameCity { get; set; } = string.Empty;
        public ObservableCollection<WorkshopModel> workshopModels { get; set; } = new();
    }
}

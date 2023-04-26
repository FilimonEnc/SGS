using Newtonsoft.Json;
using SGS.Interfaces;
using SGS.Model;
using SGS.StaticData;
using SGS.Utils;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Input;

namespace SGS.ViewModel
{
    class MainWindowVM : BaseVM, IMainWindowVM
    {
        /// <summary>
        /// Загатовленные данные
        /// </summary>
        private static readonly StaticDataMainWindow StaticData = new();

        /// <summary>
        /// Выбранная бригада
        /// </summary>
        public string Brigade
        {
            get => _brigade;
            set
            {
                _brigade = value;
                OnPropertyChanged();
            }
        }
        private string _brigade = null!;

        /// <summary>
        /// Смена
        /// </summary>
        public string Shift
        {
            get => _shift;
            set
            {
                _shift = value;
                OnPropertyChanged();
            }
        }
        private string _shift = null!;

        /// <summary>
        /// Выбранный город
        /// </summary>
        public CityModel? City
        {
            get => _city;
            set
            {
                _city = value;
                OnPropertyChanged();
            }
        }
        private CityModel _city = null!;

        /// <summary>
        /// Выбранный цех
        /// </summary>
        public WorkshopModel? Workshop
        {
            get => _workshop;
            set
            {
                _workshop = value;
                OnPropertyChanged();
            }
        }
        private WorkshopModel _workshop = null!;

        /// <summary>
        /// Выбранный работник
        /// </summary>
        public EmployeeModel? Employee
        {
            get => _employeey;
            set
            {
                _employeey = value;
                OnPropertyChanged();
            }
        }
        private EmployeeModel _employeey = null!;

        /// <summary>
        /// Коллекция городов
        /// </summary>
        public ObservableCollection<CityModel>? Cities { get; set; } = new();

        /// <summary>
        /// Коллекция цехов
        /// </summary>
        public ObservableCollection<WorkshopModel>? Workshops { get => City?.workshopModels; }

        /// <summary>
        /// Коллекция работников
        /// </summary>
        public ObservableCollection<EmployeeModel>? Employees { get => Workshop?.Employees; }

        /// <summary>
        /// Список бригад
        /// </summary>
        public ObservableCollection<string> Brigades { get; set; } = new();

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public MainWindowVM()
        {
            Cities = StaticData.CitiesData;
            Brigades = StaticData.BrigadesData;
        }

        public ICommand SaveJson
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    try
                    {
                        SaveDataModel saveDataModel = new()
                        {
                            City = City!.NameCity,
                            Workshop = Workshop!.NameWorkshop,
                            Employee = Employee!.NameEmployee,
                            Brigades = Brigade,
                            Shift = Shift
                        };

                        var json = JsonConvert.SerializeObject(saveDataModel);

                        var filePath = Path.Combine(Environment.CurrentDirectory, "selection.json");
                        File.WriteAllText(filePath, json);
                    }
                    catch (Exception ex)
                    {
                        MessageBoxShow("Выбраны не все данные", "Ошибка", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                    }

                }, (obj) =>
                {
                    return true;
                });

            }
        }
    }
}

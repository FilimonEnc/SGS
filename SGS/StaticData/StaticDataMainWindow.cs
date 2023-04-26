using SGS.Model;
using System.Collections.ObjectModel;

namespace SGS.StaticData
{
    class StaticDataMainWindow
    {
        public ObservableCollection<CityModel> CitiesData = new()
        {
            new CityModel()
            {
                NameCity = "Москва",
                workshopModels = new()
                {
                    new WorkshopModel()
                    {
                        NameWorkshop = "первый цех Московский",
                        Employees = new()
                        {
                            new EmployeeModel()
                            {
                                NameEmployee = "Владимир Георгиевич"
                            },

                            new EmployeeModel()
                            {
                                NameEmployee = "Екатерина Кудрявцева"
                            },

                            new EmployeeModel()
                            {
                                NameEmployee = "Никита Олегович"
                            }
                        }
                    },

                     new WorkshopModel()
                    {
                        NameWorkshop = "второй цех Московский",
                        Employees = new()
                        {
                            new EmployeeModel()
                            {
                                NameEmployee = "Илья Георгиевич"
                            },

                            new EmployeeModel()
                            {
                                NameEmployee = "Алена Кудрявцева"
                            },

                            new EmployeeModel()
                            {
                                NameEmployee = "Олег Олегович"
                            }
                        }
                    }
                }
            },

            new CityModel()
            {
                NameCity = "Самара",
                workshopModels = new()
                {
                    new WorkshopModel()
                    {
                        NameWorkshop = "первый цех Самарский",
                        Employees = new()
                        {
                            new EmployeeModel()
                            {
                                NameEmployee = "Никита Георгиевич"
                            },

                            new EmployeeModel()
                            {
                                NameEmployee = "Анастасия Кудрявцева"
                            },

                            new EmployeeModel()
                            {
                                NameEmployee = "Алексанлр Олегович"
                            }
                        }
                    },

                     new WorkshopModel()
                    {
                        NameWorkshop = "второй цех Самарский",
                        Employees = new()
                        {
                            new EmployeeModel()
                            {
                                NameEmployee = "Тони Георгиевич"
                            },

                            new EmployeeModel()
                            {
                                NameEmployee = "Джони Кудрявцевев"
                            },

                            new EmployeeModel()
                            {
                                NameEmployee = "Дени Олегович"
                            }
                        }
                    }
                }
            },

            new CityModel()
            {
                NameCity = "Ухта",
                workshopModels = new()
                {
                    new WorkshopModel()
                    {
                        NameWorkshop = "первый цех Ухты",
                        Employees = new()
                        {
                            new EmployeeModel()
                            {
                                NameEmployee = "Ким Георгиевич"
                            },

                            new EmployeeModel()
                            {
                                NameEmployee = "Полина Кудрявцева"
                            },

                            new EmployeeModel()
                            {
                                NameEmployee = "Смит Олегович"
                            }
                        }
                    },

                     new WorkshopModel()
                    {
                        NameWorkshop = "второй цех Ухты",
                        Employees = new()
                        {
                            new EmployeeModel()
                            {
                                NameEmployee = "Владимир Георгиевич"
                            },

                            new EmployeeModel()
                            {
                                NameEmployee = "Елена Кудрявцева"
                            },

                            new EmployeeModel()
                            {
                                NameEmployee = "Виктор Олегович"
                            }
                        }
                    }
                }
            },

        };

        public ObservableCollection<string> BrigadesData = new()
        {
            "Первая бригада",
            "Вторая бригада",
            "Третья бригада",
        };
    }
}

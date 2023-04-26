namespace SGS.Model
{
    class EmployeeModel
    {
        public string NameEmployee { get; set; } = string.Empty;

        public WorkshopModel Workshop { get; set; } = null!;
    }
}

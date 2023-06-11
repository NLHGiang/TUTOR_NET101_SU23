namespace TUTOR_NET101_SU23_B3
{
    public class ConNguoi
    {
        // Thuoc tinh
        private string _name;
        private string _phoneNumber;
        private int _yearOfBirth;

        // Property (Boi den thuoc tinh -> Quick action... -> Encapsulate field(... property))
        public string Name { get => _name; set => _name = value; } // syntax must have get;
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public int YearOfBirth { get => _yearOfBirth; set => _yearOfBirth = value; }

        // prop -> Tab
        // Truyen vao tuoi(Age) -> NamHienTai - Tuoi(Age)
        // <= 0 -> _yearOfBirth = 0;
        // > 0 -> _yearOfBirth = NamHienTai - Tuoi(Age)
        public int Age
        {
            get => DateTime.Now.Year - _yearOfBirth; // modify prop
            set => _yearOfBirth = (DateTime.Now.Year - value < 0) ? 0 : (DateTime.Now.Year - value); // modify prop
        }

        // Ham tao (constructor)
        // Constructor khong tham so ("ctor" + Tab)
        public ConNguoi()
        {
            _name = "?";
            _phoneNumber = "??";
            _yearOfBirth = 1;
        }

        // Constructor co tham so (Boi den thuoc tinh -> Quick action... -> Generate constructor(..., ..., ...))
        public ConNguoi(string name, string phoneNumber, int yearOfBirth) // CTR 3 tham so
        {
            _name = name;
            _phoneNumber = phoneNumber;
            YearOfBirth = yearOfBirth;
        }

        public ConNguoi(string name) // CTR 1 tham so
        {
            _name = name;
        }

        // Phuong thuc (Method)
        public void Noi()
        {
            Console.WriteLine($"{Name} dang noi");
        }

        public void Hat()
        {
            Console.WriteLine($"{Name} dang hat");
        }

        public void InThongTin()
        {
            Console.WriteLine($"Property: {Name} - {PhoneNumber} - {YearOfBirth}");
            Console.WriteLine($"TT: {_name} - {_phoneNumber} - {_yearOfBirth}");
        }
    }
}

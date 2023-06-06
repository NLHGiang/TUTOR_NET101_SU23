// private, protected, public, internal(skip)
// private: scope nho nhat, chi su dung trong noi bo class
// protected: > private, < internal, < public, chi su dung trong noi bo class va class ke thua (class con)
// internal: < public, duoc su dung trong assemply (skip)
// public: scope lon nhat, su dung moi noi

using TUTOR_NET101_SU23_B3;

// Phuong thuc: khong tham so, co tham so
//ConNguoi conNguoi1 = new ConNguoi(); // khoi tao doi tuong
//ConNguoi conNguoi2 = new ConNguoi("Giang"); // khoi tao doi tuong
//ConNguoi conNguoi3 = new ConNguoi("Giang", "123456", 2002); // khoi tao doi tuong

//conNguoi1.InThongTin();
//conNguoi2.InThongTin();
//conNguoi3.InThongTin();

ConNguoi conNguoi4 = new ConNguoi(); // khoi tao doi tuong
// Gan gia tri
conNguoi4.Name = "Giang4";
conNguoi4.PhoneNumber = "0123456789";
conNguoi4.YearOfBirth = 2003;
conNguoi4.Age = 21;

// In ra
conNguoi4.InThongTin();
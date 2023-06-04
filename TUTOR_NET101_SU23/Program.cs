#region Xuat
// Console.Write(); // In khong xuong dong
// Console.WriteLine(); // In xuong dong

//Console.Write("Console.Write\n");
//Console.Write("Console.Write\n");
//Console.Write("Console.Write\n");

//Console.WriteLine("======================");

//Console.WriteLine("Console.WriteLine");
//Console.WriteLine("Console.WriteLine");
//Console.WriteLine("Console.WriteLine");
#endregion

#region Nhap
// int, long, float, double, bool, string
// Nguoi dung nhap 2 so nguyen a va b
// Yeu cau nguoi dung nhap -> Cho phep nguoi dung thuc hien nhap 2 so a,b
//Console.Write("Nhap a = ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Nhap b = ");
//int b = Convert.ToInt32(Console.ReadLine());

#endregion

#region Nhap va Xuat voi int
//Console.Write("Nhap a = ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Nhap b = ");
//int b = Convert.ToInt32(Console.ReadLine());

//// Cach 1
//Console.WriteLine($"Ban vua nhap a = {a}, b = {b}");
//// Cach 2
//Console.WriteLine("Ban vua nhap a = {0}, b = {1}", a, b);
//// Cach 3
//// int = int + int + int;
//// string = string + string + string;
//string thongBao = "Ban vua nhap a = " + a.ToString() + ", b = " + b.ToString();
//Console.WriteLine(thongBao);
#endregion

#region Nhap va Xuat voi bool
//Console.Write("Nhap isTrue = ");
//// bool: tien to "is"/"has". VD: isSuccess, hasNumber (true, false)
//bool isTrue = Convert.ToBoolean(Console.ReadLine());
//// Loi do nguoi dung nhap gia tri khong hop le nen khong the ep kieu sang kieu du lieu bool
//// String '1' was not recognized as a valid Boolean.
//// String 'a' was not recognized as a valid Boolean.

//Console.WriteLine("Ban vua nhap: isTrue = {0}", isTrue);
#endregion

#region Nhap va Xuat voi string
//Console.Write("Nhap ten = ");

//string ten = Console.ReadLine(); // Neu nguoi dung Enter -> string ten = "";

//Console.WriteLine($"Ban vua nhap ten: {ten}");
#endregion

#region Bai tap 1
/*
 * Nguoi dung nhap vao 2 so nguyen a va b
 * In ra man hinh ket qua cac phep toan a+b, a-b, a*b, a/b, a%b
 */
// B1: Thong bao -> cho nguoi dung nhap gia tri a va b
//Console.Write("Nhap a = ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Nhap b = ");
//int b = Convert.ToInt32(Console.ReadLine());

//// B2: Thuc hien cac phep toan
//int tong = a + b;
//int hieu = a - b;
//int tich = a * b;
//float thuong = (float)a / b; // int / int = int ; float / int = float; int / float = float
//int soDu = a % b;

//// B3: In ket qua cac phep toan ra man hinh
//Console.WriteLine($"a + b = {tong}");
//Console.WriteLine($"a - b = {hieu}");
//Console.WriteLine($"a * b = {tich}");
//Console.WriteLine($"a / b = {thuong}");
//Console.WriteLine($"a % b = {soDu}");
#endregion

#region Ep kieu
//// string va string?
//// string?: cho phep gan gia tri null;
//Console.Write("Nhap int = ");
//string? intValue = Console.ReadLine();
//Console.Write("Nhap decimal = ");
//string? decimalValue = Console.ReadLine();
//Console.Write("Nhap float = ");
//string? floatValue = Console.ReadLine();
//Console.Write("Nhap double = ");
//string? doubleValue = Console.ReadLine();
////Console.Write("Nhap bool = ");
////string? boolValue = Console.ReadLine();
////Console.Write("Nhap string = ");
////string? stringValue = Console.ReadLine();

//// Convert: khong can check null
//// neu gia tri truyen vao ma null -> gia tri default cua kieu du lieu (int = 0, float = 0.0)
//// neu gia tri truyen vao khong hop le -> Exception - <!> Loi <!>

//// Parse: TryParse - Parse (check null, check hop le gia tri truyen vao - ep kieu)

//Console.WriteLine("intValue16 = {0}", Convert.ToInt16(intValue));

//// Test Parse
//if (Int16.TryParse(intValue, out short testInt) == true) // gia tri truyen vao khong null va hop le
//{
//	Console.WriteLine("intValue16 = {0}", testInt);
//}
//else
//{
//    Console.WriteLine($"{intValue} khong the ep kieu sang Int16");
//}

////Console.WriteLine("intValue32 = {0}", Convert.ToInt32(intValue));
////Console.WriteLine("intValue64 = {0}", Convert.ToInt64(intValue));

//Console.WriteLine("decimalValue = {0}", Convert.ToDecimal(decimalValue));
//Console.WriteLine("floatValue = {0}", Convert.ToDouble(floatValue));
//Console.WriteLine("doubleValue = {0}", Convert.ToDouble(doubleValue));

////Console.WriteLine("boolValue = {0}", Convert.ToBoolean(boolValue));

////Console.WriteLine("stringValue = {0}", Convert.ToString(stringValue));
#endregion

Console.ReadKey();
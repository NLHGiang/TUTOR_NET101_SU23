// Tao mot class DoVat co:
// 1. cac thuoc tinh: maDV-int, tenDV-string, khoiLuong-float, chatLieu-string, trangThai-bool(true-moi; false-cu)
// 2. phuong thuc: InThongTin - void
// 3. co chua getter, setter

// Tao class QuanLiDoVat co:
// 1. Them moi DV
// 2. Sua TT DV
// 3. Xoa DV
// 4. Xuat DS DV

// Trong Program, tao menu thuc hien cac chuc nang trong QLDV
// 0. Thoat

// FOMART CODE NHANH: CTRL + A -> CTR + K -> CTRL + D/F

using TUTOR_NET101_SU23_B5;

QuanLiDoVat quanLiDoVat = new QuanLiDoVat();

do
{
    Console.WriteLine("MENU IS HERE");
    Console.WriteLine("1. Them moi DV");
    Console.WriteLine("2. Sua TT DV");
    Console.WriteLine("3. Xoa DV");
    Console.WriteLine("4. Xuat DS DV");
    Console.WriteLine("0. THOAT");
    Console.Write("Lua chon: ");
    string luaChon = Console.ReadLine();

    switch (luaChon)
    {
        case "1":
            quanLiDoVat.ThemMoiDV();
            break;
        case "2":
            quanLiDoVat.SuaThongTinDV();
            break;
        case "3":
            quanLiDoVat.XoaDV();
            break;
        case "4":
            quanLiDoVat.XuatDanhSach();
            break;
        case "0":
            Console.WriteLine("BAN DA THOAT !");
            return;
    }
} while (true);
// Tao mot doi tuong ConVat:
// cac thuoc tinh: ten - string, tuoi - int, can nang - float, gioiTinh - bool
// cac phuong thuc: InThongTin() - void
// bao gom getter, setter
// Tao mot List<ConVat> listCV
// Them moi CV
// Sua thong tin ConVat trong listCV
// Xoa CV trong listCV

using TUTOR_NET101_SU23_B4;

//ConVat conVat1 =  new ConVat();
//ConVat conVat2 =  new ConVat("CV2", 1);
//ConVat conVat3 =  new ConVat("CV3", 2, (float)2.5, true);

//// bool: true/false
////Console.WriteLine($"{_ten} - {_tuoi} - {_canNang} - {_gioiTinh}");

//conVat1.InThongTin(); // _ - 0 - 0 - false
//conVat2.InThongTin(); // CV2 - 1 - 0 - false
//conVat3.InThongTin(); // CV3 - 2 - 2.5 - true

// Tao mot List<ConVat> listCV
List<ConVat>? listCV = new List<ConVat>();
// Them moi CV
// Them 1 doi tuong
listCV.Add(new ConVat());

// Count: thuoc tinh cua List<>; Count(): phuong thuc cua List<> - return List.Count;
//Console.WriteLine(listCV.Count()); // 1

// Them nhieu doi tuong
// Vong lap (for, foreach, while, do...while)
for (int i = 0; i < 5; i++)
{
    listCV.Add(new ConVat());
}

//Console.WriteLine(listCV.Count); // 1 + 5 = 6

// AddRange
listCV.AddRange(listCV);
//Console.WriteLine(listCV.Count()); // 6 + 6 = 12

// Sua thong tin ConVat trong listCV
// arrInt[0] = //gan gia tri;
int viTriSua = 1000;
#region cach 1 & 2
// List = null -> RESULT: 1: ERROR ; 2: ERROR ; // LIST NULL
// List = new() -> RESULT: 1: RUN ; 2: ERROR ; // LIST RONG
// viTriSua = 3; List.Count = 3 -> RESULT: 1: RUN ; 2: ERROR ; // LIST KHONG CO PHAN TU TAI VI TRI TRUYEN VAO

// LIST CO PHAN TU TAI VI TRI TRUYEN VAO (khong NULL, khong RONG, co PHAN TU HOP LE)
// RESULT: 1: RUN ; 2: RUN ;
#endregion
listCV = new(); // new(): khai bao nhanh
for (int i = 1; i <= 3; i++) // i=1;i=2;i=3
{
    listCV.Add(new ConVat());
}

Console.WriteLine(listCV.Count); // 3 pt

// Cach 1: Vong lap -> if kiem tra vi tri -> Sua
if (listCV != null) // Dieu kien tranh ERROR TH1
{
    for (int i = 0; i < listCV.Count; i++) // Boi vi co dieu kien (i < listCV.Count) => tranh ERROR TH1
    {
        if (i == viTriSua)
        {
            listCV[i] = new ConVat("CV Test", 2);
            break;
        }
    }
}

// Cach 2: Truyen truc tiep vi tri -> Sua
if (listCV != null) // Dieu kien tranh ERROR TH1
{
    if (listCV.Count > viTriSua) // Dieu kien tranh ERROR TH2
    {
        listCV[viTriSua] = new ConVat("CV Test", 2);
    }
}

if (listCV != null && listCV.Count > viTriSua) // Dieu kien tranh ERROR TH1 & TH2
{
    listCV[viTriSua] = new ConVat("CV Test", 2);
}

// Xoa CV trong listCV
// Xoa 1
int viTriXoa = 0;
listCV.Remove(listCV[viTriXoa]);
listCV.RemoveAt(viTriXoa);

// Xoa nhieu
int start = 2;
int amount = 2;
listCV.RemoveRange(start, amount);

// Xoa het
listCV.Clear();
//listCV.RemoveAll(c=>c.GioiTinh == true);

// Hien thi
for (int i = 0; i < listCV.Count; i++)
{
    listCV[i].InThongTin();
}

// var, dynamic
foreach (ConVat item in listCV)
{
    item.InThongTin();
}
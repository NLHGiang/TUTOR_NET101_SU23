namespace TUTOR_NET101_SU23_B5
{
    public class DoVat
    {
        // Tao mot class DoVat co:
        // 1. cac thuoc tinh: maDV-int, tenDV-string, khoiLuong-double, chatLieu-string, trangThai-bool(true-moi; false-cu)
        int maDV;
        string tenDV;
        double khoiLuong;
        string chatLieu;
        bool trangThai;

        // 2. phuong thuc: InThongTin - void
        public void InThongTin()
        {
            Console.WriteLine($"{maDV} - {tenDV} - {khoiLuong} - {chatLieu} - {trangThai}");
        }

        // 3. co chua getter, setter
        public int MaDV { get => maDV; set => maDV = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }
        public double KhoiLuong { get => khoiLuong; set => khoiLuong = value; }
        public string ChatLieu { get => chatLieu; set => chatLieu = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
    }
}

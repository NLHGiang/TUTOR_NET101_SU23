namespace TUTOR_NET101_SU23_B5
{
    public class QuanLiDoVat
    {
        // Khai bao va khoi tao _lstDoVat
        List<DoVat> _lstDoVat = new();

        //public int MaDV { get => maDV; set => maDV = value; }
        //public string TenDV { get => tenDV; set => tenDV = value; }
        //public float KhoiLuong { get => khoiLuong; set => khoiLuong = value; }
        //public string ChatLieu { get => chatLieu; set => chatLieu = value; }
        //public bool TrangThai { get => trangThai; set => trangThai = value; }

        // 1. Them moi DV
        public void ThemMoiDV()
        {
            // B1: Khai bao va khoi tao doi tuong DoVat
            DoVat doVat = new();

            // B2: Gan gia tri cho cac thuoc tinh cua doi tuong DoVat
            Console.Write("MaDV: ");
            doVat.MaDV = Convert.ToInt32(Console.ReadLine());
            Console.Write("TenDV: ");
            doVat.TenDV = Console.ReadLine();
            Console.Write("KhoiLuong: ");
            doVat.KhoiLuong = Convert.ToDouble(Console.ReadLine());
            Console.Write("ChatLieu: ");
            doVat.ChatLieu = Console.ReadLine();
            Console.Write("TrangThai: ");
            doVat.TrangThai = Convert.ToBoolean(Console.ReadLine());

            // B3: Them doi tuong DoVat vao list
            _lstDoVat.Add(doVat);
        }

        // 2. Sua TT DV
        public void SuaThongTinDV()
        {
            // B1: Tim doi tuong can sua
            Console.Write("MaDV can sua: ");
            int maDVCanSua = Convert.ToInt32(Console.ReadLine());

            // B2: Kiem tra doi tuong can sua co ton tai hay khong ?
            #region Cach 1: For
            bool isExistFor = false;// bien kiem tra ton tai

            // List: 1-2-3-4-5-6 : co the dung break; vi maDV cua tung DoVat la duy nhat
            // List: 1-2-3-4-5-3------3 : khong dung break; de ra soat full listDV
            for (int i = 0; i < _lstDoVat.Count; i++)
            {
                if (_lstDoVat[i].MaDV == maDVCanSua)
                {
                    // Neu ton tai doi tuong trung khop yeu cau TIM
                    // B3: Gan lai gia tri cho doi tuong can sua
                    Console.Write("MaDV: ");
                    _lstDoVat[i].MaDV = Convert.ToInt32(Console.ReadLine());
                    Console.Write("TenDV: ");
                    _lstDoVat[i].TenDV = Console.ReadLine();
                    Console.Write("KhoiLuong: ");
                    _lstDoVat[i].KhoiLuong = Convert.ToDouble(Console.ReadLine());
                    Console.Write("ChatLieu: ");
                    _lstDoVat[i].ChatLieu = Console.ReadLine();
                    Console.Write("TrangThai: ");
                    _lstDoVat[i].TrangThai = Convert.ToBoolean(Console.ReadLine());

                    isExistFor = true; // gan gia tri TRUE cho isExist
                    //break; // thoat vong lap sau khi tim thay va update DoVat
                }
            }

            // B3: Thong bao khong tim thay
            if (!isExistFor) // !isExist tuong ung (isExist == false)
            {
                Console.WriteLine($"Khong co DoVat co maDV la {maDVCanSua}");
            }
            #endregion

            #region Cach 2: Foreach
            bool isExistForeach = false;

            foreach (DoVat item in _lstDoVat)
            {
                if (item.MaDV == maDVCanSua)
                {
                    // Neu ton tai doi tuong trung khop yeu cau TIM
                    // B3: Gan lai gia tri cho doi tuong can sua
                    Console.Write("MaDV: ");
                    item.MaDV = Convert.ToInt32(Console.ReadLine());
                    Console.Write("TenDV: ");
                    item.TenDV = Console.ReadLine();
                    Console.Write("KhoiLuong: ");
                    item.KhoiLuong = Convert.ToDouble(Console.ReadLine());
                    Console.Write("ChatLieu: ");
                    item.ChatLieu = Console.ReadLine();
                    Console.Write("TrangThai: ");
                    item.TrangThai = Convert.ToBoolean(Console.ReadLine());

                    isExistForeach = true;
                    //break;
                }
            }

            // Neu khong co doi tuong trung khop yeu cau TIM
            // B3: Thong bao khong tim thay
            if (!isExistForeach)
            {
                Console.WriteLine($"Khong co DoVat co maDV la {maDVCanSua}");
            }
            #endregion
        }

        // 3. Xoa DV
        public void XoaDV()
        {
            // B1: Tim doi tuong can xoa
            Console.Write("TenDV can sua: ");
            string tenDVCanSua = Console.ReadLine();

            // B2: Kiem tra doi tuong can xoa co ton tai hay khong ?
            bool isExistForeach = false;
            foreach (DoVat item in _lstDoVat)
            {
                // item.TenDV = "Abc"; tenDVCanSua="a"
                // item.TenDV.ToLower() = "abc"; tenDVCanSua.ToLower()="a"
                // item.TenDV.ToUpper() = "ABC"; tenDVCanSua.ToUpper()="A"
                if (item.TenDV.ToUpper().Contains(tenDVCanSua.ToUpper())) // TenDV cua item chua tenDVCanSua
                {
                    // Neu ton tai doi tuong trung khop yeu cau TIM
                    // B3: Xoa doi tuong
                    _lstDoVat.Remove(item); // removeat(index); remove(element);

                    isExistForeach = true;
                    //break;
                }
            }

            // Neu khong co doi tuong trung khop yeu cau TIM
            // B3: Thong bao khong tim thay
            if (!isExistForeach)
            {
                Console.WriteLine($"Khong co DoVat co tenDV chua {tenDVCanSua}");
            }
        }

        // 4. Xuat DS DV
        public void XuatDanhSach()
        {
            foreach (DoVat item in _lstDoVat)
            {
                item.InThongTin();
            }
        }
    }
}

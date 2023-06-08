using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TUTOR_NET101_SU23_B4
{
	public class ConVat
	{
		// Scope: private, protected, internal, public
		// cac thuoc tinh: ten - string, tuoi - int, can nang - float, gioiTinh - bool
		// cac phuong thuc: InThongTin() - void
		// bao gom getter, setter

		// Thuoc tinh
		private string _ten; // neu khong chi dinh scope thi mac dinh la "private"
		private int _tuoi;
		private float _canNang;
		private bool _gioiTinh; // true: Duc; false: Cai

        // Ham tao (constructor)
        // CTR khong tham so
        public ConVat()
        {
            
        }

		// CTR co tham so
		public ConVat(string ten, int tuoi)
		{
			_ten = ten;
			_tuoi = tuoi;
		}

		public ConVat(string ten, int tuoi, float canNang, bool gioiTinh)
		{
			_ten = ten;
			_tuoi = tuoi;
			_canNang = canNang;
			_gioiTinh = gioiTinh;
		}

		// Phuong thuc
		public void InThongTin()
		{
			// Xu li du lieu gioiTinh (true: Duc; false: Cai)
			// Cach 1: if else
			// Khai bao gioiTinhString
			string gioiTinhString = "";

			// Kiem tra gioiTinh -> gan gia tri cho gioiTinhString
			if (_gioiTinh == true) // if(gioiTinh) : true; if(!gioiTinh) : false
			{
				gioiTinhString = "Duc";
			}
			else if( _gioiTinh == false)
			{
				gioiTinhString = "Cai";
			}
			else
			{
				gioiTinhString = "N/A";
			}

			Console.WriteLine($"{_ten} - {_tuoi} - {_canNang} - {gioiTinhString}");

			// Cach 2: 3 ngoi
			// Khai bao gioiTinhPropString
			string gioiTinhPropString = "";

			// Kiem tra gioiTinh -> gan gia tri cho gioiTinhPropString
			// gioiTinh = true hay khong?
			// -> co -> "Duc"
			// -> khong -> gioiTinh = false hay khong?
			// -> co -> "Cai"
			// -> khong -> "N/A"
			gioiTinhPropString = (_gioiTinh == true) ? "Duc" : 
								(_gioiTinh == false) ? "Cai" : "N/A";
			Console.WriteLine($"{Ten} - {Tuoi} - {CanNang} - {gioiTinhPropString}");
        }

		// Property
		// Khi generate property:
		// -> use property (noi su dung thuoc tinh -> su dung property)
		// -> still use field (giu nguyen viec su dung thuoc tinh)
		public string Ten { get => _ten; set => _ten = value; }
		public int Tuoi { get => _tuoi; set => _tuoi = value; }
		public float CanNang { get => _canNang; set => _canNang = value; }
		public bool GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
	}
}

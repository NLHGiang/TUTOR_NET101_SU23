#region Cau truc cau dieu kien

#region if...else
//// Neu <dieu kien> thi <cong viec> ngoai ra thi <cong viec>
//// a < 0, a == 0, a == "a", a == true
//// a > 0 && a < 5
//Console.Write("Nhap a = ");
//int a = Convert.ToInt32(Console.ReadLine());

//// Lv1
//bool checkNumber = (a > 0) && (a < 5);
//if (checkNumber) // kiem tra dieu kien
//{
//	// do something
//	Console.WriteLine("a hop le !");
//}
//else
//{
//	// do something
//	Console.WriteLine("a khong hop le !");
//}

//// Lv2
//// Cach 1
//if (a == 2)
//{
//	Console.WriteLine("a = 2");
//}
//else if (a == 3)
//{
//	Console.WriteLine("a = 3");
//}
//else if (a == 4)
//{
//	Console.WriteLine("a = 4");
//}
//else
//{
//	Console.WriteLine("a");
//}

//// Cach 2
//if (a == 2)
//{
//	Console.WriteLine("a = 2");
//}
//else
//{
//	if (a == 3)
//	{
//		Console.WriteLine("a = 3");
//	}
//	else
//	{
//		if (a == 4)
//		{
//			Console.WriteLine("a = 4");
//		}
//		else
//		{
//			Console.WriteLine("a");
//		}
//	}
//}

// Lv3
//// kiem tra = 2 -> = 3 -> = 4 -> ngoai ra
//if (a == 2)
//{
//	Console.WriteLine("a = 2");
//}

//if (a == 3)
//{
//	Console.WriteLine("a = 3");
//}

//if (a == 4)
//{
//	Console.WriteLine("a = 4");
//}
//else
//{
//	Console.WriteLine("a");
//}

#endregion

#region switch...case
//Console.Write("Nhap a = ");
//int a = Convert.ToInt32(Console.ReadLine());

//// if: kiem tra nhieu bien cung luc
//// switch: kiem tra 1 bien cung luc

//switch (a)
//{
//	case 2:
//	case 3: // if (a == 2 || a == 3)
//		Console.WriteLine("2 or 3");
//		break;
//	case 4:
//		Console.WriteLine("4");
//		break;
//	default: // if (a != 2 && a != 3 && a != 4)
//		Console.WriteLine("a");
//		break;
//}

#endregion

#endregion

#region Vong lap
#region for
Console.Write("Nhap n = ");
int n = Convert.ToInt32(Console.ReadLine());

// int i = 0 : khai bao gia tri bat dau vong lap
// i < n : dieu kien DUNG vong lap
// i++ : buoc nhay
// (i = 0) -> kiem tra dieu kien (i < n) -> do something -> (i += 6) -> kiem tra dieu kien (i < n)
// -> 1: thoa man -> do something...
// -> 2: khong thoa man -> Dung vong lap
for (int i = 0; i < n; i++)
{
	// do something
	Console.WriteLine(i);
}

/* LUU Y: Vong lap vo tan
 * Khi dieu kien luon dung. VD: 0<5
 * Bo buoc nhay, va dieu kien luon dung neu khong co buoc nhay
 * Do logic code
 */
for (int i = 0; ; i++)
{
	// do something
	Console.WriteLine(i);
}

// Neu dieu kien la i != 0 -> khong bi TH vong lap vo tan
for (int i = 0; i < 1;)
{
	// do something
	Console.WriteLine(i);
}

for (int i = 0; i < 1; i++)
{
	// do something
	Console.WriteLine(i);
	i = -999;
}

#endregion

#region while
int indexWhile = 0;

// Luu y buoc nhay (neu can), dieu kien CHAY
// indexWhile < 5 : dieu kien CHAY
while (indexWhile < 5)
{
	Console.WriteLine(indexWhile);
	indexWhile++; // buoc nhay
}

#endregion

#region do...while
int indexDoWhile = 0;

// Luu y buoc nhay (neu can), dieu kien CHAY
// indexDoWhile < 5 : dieu kien CHAY
do
{
	Console.WriteLine(indexWhile);
	indexWhile++; // buoc nhay
} while (indexDoWhile < 5);

#endregion

#endregion

//// count++ va ++count
//// Giong nhau: 
//int count1 = 0;
//count1++; // count += 1;
//Console.WriteLine(count1); // count = 1
//++count1; // count += 1;
//Console.WriteLine(count1); // count = 2

//// Khac nhau:
//int count2 = 0;
//Console.WriteLine(count2++); // Write 0 -> count += 1
//Console.WriteLine(++count2); // count += 1 -> Write 2
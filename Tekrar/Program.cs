#region Task1
/*Tapşırıq 1:
İki ədəd dəyişən yaradın və onların cəmini ekranda çap edən proqramı yazın.*/
int first = 24;
int second = 32;
int sum = first + second;
Console.WriteLine(sum);

#endregion
#region Task2
/*Tapşırıq 2:
Bir dəyişəndə saxlanan ədədin kvadratını (özünə vurulmasını) ekranda çap edən proqramı yazın.*/
int a = 5;
int Double = a * a;
Console.WriteLine(Double);
#endregion
#region Task3
/*Tapşırıq 3:
Adınızı və yaşınızı ayrı dəyişənlərdə saxlayın, sonra bunları aşağıdakı kimi çap edən proqramı yazın:
Salam, mənim adım Boss-dur və mənim 222 yaşım var.*/
string Name = "Nezrin";
int Age = 21;
Console.WriteLine($"Salam, menim adim {Name}-dir,menim {Age} yasim var.");
#endregion
#region Task4
/*Tapşırıq 4:
İki dəyişəndə saxlanılan ədədlərin dəyərlərinin yerini dəyişin və ekrana aşağıdaki kimi çap edən proqramı yazın (Üçüncü dəyişəndən əlavə etmək olar):
x dəyişəninin əvvəlki dəyəri 10, yer dəyişmədən sonra 20-dir.
y dəyişəninin əvvəlki dəyəri 20, yer dəyişmədən sonra 10-dur.*/
int x = 10;
int y = 20;
int b = x;
x = y;
y = b;
Console.WriteLine($"deyerlerini deyiserek x={x},y={y} olur");


#endregion
#region Task5
/*Tapşırıq 5:
Daxil edilən üç tam ədədin cəmi və ədədi ortasını hesablayıb çap edən proqramı yazın.*/
int[] arr = { 2, 5, 8 }
;
int cem = 0;

for (int i = 0; i < arr.Length; i++)
{
    cem += arr[i];


}
int orta = cem / arr.Length;
Console.WriteLine($"cemi {cem}, ededi ortasi {orta}");
#endregion
#region Task6
/*Tapşırıq 6:
İstifadəçidən daxil edilən dördrəqəmli ədədin rəqəmlərinin cəmini hesablayıb çap edən proqramı yazın.*/
Console.Write("Dördrəqəmli ədəd daxil edin: ");
int number = int.Parse(Console.ReadLine());

if (number < 1000 || number > 9999)
{
    Console.WriteLine("Xahiş olunur, dördrəqəmli ədəd daxil edin.");
}
else
{
    int sum2 = 0;
    int temp = number;

    while (temp > 0)
    {
        sum2 += temp % 10;
        temp /= 10;
    }

    Console.WriteLine($"Rəqəmlərin cəmi: {sum2}");
}
#endregion
#region Task7
/*Tapşırıq 7:
İstifadəçidən alınan ədədin cüt və ya tək olduğunu yoxlayan və çap edən proqramı yazın.*/
Console.Write("Ədəd daxil edin: ");
int number2 = int.Parse(Console.ReadLine());
if (number2 % 2 == 0)
{
    Console.WriteLine("Daxil etdiyiniz eded cutdur");
}
else
{
    Console.WriteLine("Daxil etdiyinz eded tekdir");
}

#endregion
#region Task8
/*Tapşırıq 8:
İstifadəçinin daxil etdiyi iki ədədi müqayisə edib, hansı ədədin böyük olduğunu çap edən proqram yazın.*/
Console.WriteLine("iki eded daxil edin");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"Daxil etdiyiniz ilk eded-{num1} daha boyukdur");
}
else if (num1 < num2)
{
    Console.WriteLine($"Daxil etdiyiniz ikinci eded-{num2} daha boyukdur");
}
else
{
    Console.WriteLine("Daxil etdiyiniz ededler beraberdir");
}


#endregion
#region Task9
/*Tapşırıq 9:
İstifadəçinin daxil etdiyi ədədin müsbət, mənfi və ya sıfır olduğunu yoxlayan və çap edən proqramı yazın.*/

Console.WriteLine("Eded daxil edin");
int num = int.Parse(Console.ReadLine());
if (num < 0)
{
    Console.WriteLine("Daxil etdiyiniz eded menfidir");
}
else if (num > 0)
{
    Console.WriteLine("Daxil etdiyiniz eded musbetdir");
}
else
{
    Console.WriteLine("Daxil etdiyiniz eded sifira beraberdir");
}
#endregion
#region Task10
/*Tapşırıq 10:
İstifadəçidən alınan ədədin həm 3-ə həm də 5-ə bölünüb-bölünmədiyini yoxlayan və çap edən proqramı yazın.*/
Console.WriteLine("Eded daxil edin");
int eded = int.Parse(Console.ReadLine());
if (eded % 3 == 0 && eded % 5 == 0)
{
    Console.WriteLine("Bu eded hem 3-e, hem de 5-e bolunur");
}
else if (eded % 3 == 0)
{
    Console.WriteLine("Eded 3-e bolunur");
}
else if (eded % 5 == 0)
{
    Console.WriteLine("Eded 5-e bolunur");
}
else
{
    Console.WriteLine("eded ne 3-e, ne de 5-e bolunur.");
}
#endregion
#region Task11
/*Tapşırıq 11:
İstifadəçinin daxil etdiyi ədədin 2-yə və ya 3-ə eyni zamanda bölünə bildiyini yoxlayan və çap edən proqramı yazın.*/
Console.WriteLine("Eded daxil edin");
int nums = int.Parse(Console.ReadLine());
if (nums % 3 == 0 && nums % 2 == 0)
{
    Console.WriteLine("Bu eded hem 3-e, hem de 2-e bolunur");
}
else if (nums % 3 == 0)
{
    Console.WriteLine("Eded 3-e bolunur");
}
else if (nums % 2 == 0)
{
    Console.WriteLine("Eded 2-e bolunur");
}
else
{
    Console.WriteLine("eded ne 3-e, ne de 2-e bolunur.");
}
#endregion
#region Task12
/*Tapşırıq 12:
İstifadəçi ayın nömrəsini daxil edir (1-12 arasında). Proqram həmin ayın adını ekrana yazdıran proqramı yazın.(switch-case istifadə edin)*/
Console.WriteLine("Oldugunuz ayin nomresini daxil edin (1-12):");
int months = int.Parse(Console.ReadLine());
switch (months)
{
    case 1:
        Console.WriteLine("Yanvar ayindasiniz");
        break;
    case 2:
        Console.WriteLine("Fevral ayindasiniz");
        break;
    case 3:
        Console.WriteLine("Mart ayindasiniz");
        break;
    case 4:
        Console.WriteLine("Aprel ayindasiniz");
        break;
    case 5:
        Console.WriteLine("May ayindasiniz");
        break;
    case 6:
        Console.WriteLine("Iyun ayindasiniz");
        break;
    case 7:
        Console.WriteLine("Iyul ayindasiniz");
        break;
    case 8:
        Console.WriteLine("Avqust ayindasiniz");
        break;
    case 9:
        Console.WriteLine("Sentyabr ayindasiniz");
        break;
    case 10:
        Console.WriteLine("Oktyabr ayindasiniz");
        break;
    case 11:
        Console.WriteLine("Noyabr ayindasiniz");
        break;
    case 12:
        Console.WriteLine("Dekabr ayindasiniz");
        break;


}
#endregion
#region Task13
/*Tapşırıq 13:
İstifadəçi daxil etdiyi bal əsasında qiymət çap edən proqramı yazın.(istənilən bal sistemi)*/
Console.WriteLine("Zehmet olmazsa balinizi daxil edin");
int point = int.Parse(Console.ReadLine());
if (point >= 91 && point <= 100)
{
    Console.WriteLine("Siz A almisiniz");
}
else if (point >= 81 && point <= 90)
{
    Console.WriteLine("Siz B almisiniz");
}
else if (point >= 71 && point <= 80)
{
    Console.WriteLine("Siz C almisiniz");
}
else if (point >= 61 && point <= 70)
{
    Console.WriteLine("Siz B almisiniz");
}
else if (point >= 51 && point <= 60)
{
    Console.WriteLine("Siz B almisiniz");
}
else if (point >= 0 && point <= 50)
{
    Console.WriteLine("Universitet şotunuza ayaqdadi");
}
else
{
    Console.WriteLine("nice try diddy");
}
#endregion
#region Task14
/*Tapşırıq 14:
İstifadəçi iki ədəd və bir əməliyyat işarəsi daxil edir. Nəticəni hesablayan və çap edən proqramı yazın. (+, -, *, /)*/
Console.WriteLine("iki eded yazin");
int num5 = int.Parse(Console.ReadLine());
int num6 = int.Parse(Console.ReadLine());
Console.WriteLine("Əməliyyat isaresi secin:\n1.+\n2.-\n3.*\n4./");
int sign = int.Parse(Console.ReadLine());
if (sign == 1)
{
    Console.WriteLine(num5 + num6);

}
else if (sign == 2)
{
    if (num5 > num6)
    {

        Console.WriteLine(num5 - num6);

    }
    else
    {
        Console.WriteLine(num6 - num5);
    }

}
else if (sign == 3)
{
    Console.WriteLine(num5 * num6);
}
else if (sign == 4)
{
    if (num5 > num6)
    {

        Console.WriteLine(num5 / num6);

    }
    else if (num5 == 0 || num6 == 0)
    {
        Console.WriteLine("secdiyiniz ededler bolme emeliyyati ucun dogru deyil");
    }

    else
    {
        Console.WriteLine(num6 / num5);
    }
}



#endregion
#region Task15
/*Tapşırıq 15: 
İstifadəçinin daxil etdiyi məbləğə əsasən endirim edən və aşağıdaki şəkildə nəticəni çap edən proqramı yazın.
Məbləğ 100 AZN və ya daha çoxdursa, 10% endirim.

Məbləğ 50-99 AZN arasında olsa, 5% endirim.

Məbləğ 50 AZN-dən aşağıdırsa, endirim yoxdur.

Endirimli qiymət: Alınan məhsulun dəyəri 120 AZN. Ödəyəcəyiniz məbləğ 108 AZN (10% endirim tətbiq edildi)*/
Console.WriteLine("Salamlar, Ramazanla bagli endirimlerimiz davam edir. Alacaginiz her 100 AZN ve uzerin qiymetde mehsula 10% faiz endirim tetbiq olur. 55-90 AZN araliginda olarsa   5% endirim tetbiq olunur. 50 AZN ve asagi alisverislere endirim tetbig olunmur. Endirimli meblegi oyrenmek ucun muhsulun qiymetini daxil edin:");
int price = int.Parse(Console.ReadLine());
if (price >= 50 && price <= 99)
{
    Console.WriteLine($"Sizin secdiyiniz mehsul endrimle {price} AZN-den {price - (price * 5 / 100)} AZN-e enir.");
}
else if (price >= 100)
{
    Console.WriteLine($"Sizin secdiyiniz mehsul endrimle {price} AZN-den {price - (price * 10 / 100)}  AZN-e enir");
}
else if (price > 0 && price <= 50)
{
    Console.WriteLine("Bu meblegde mehsul ucun endirim tetbiq olunmur");
}
else
{
    Console.WriteLine("Meblegi duzgun daxil edin");
}

#endregion
#region Task16
/*Tapşırıq 16:
İstifadəçi adını və şifrəsini daxil edir. Əvvəldən təyin olunmuş istifadəçi adı və şifrəyə uyğun olarsa girişə icazə verən və nəticəni çap edən proqramı yazın.
Qeyd: əvvəlcədən istifadəçi adı "admin", şifrə "2222" olsun.*/
string correctname = "admin";
string correctpassword = "2222";
Console.WriteLine("Istifadeci adini daxil edin");
string name = Console.ReadLine();
Console.WriteLine("Sifreni daxil edin");
string password = Console.ReadLine();
if (name == correctname && password == correctpassword)
{
    Console.WriteLine("Girisiniz ugurla basa catdi.");
}
else
{
    Console.WriteLine("Istifadeci adi ve ya sifre sehvdir.");
}
#endregion
#region Task17
/*Tapşırıq 17:
AZN-dən USD və ya USD-dən AZN-ə məzənnə çevrilməsi həyata keçirən və nəticəni çap edən proqram yazın. (sabit məzənnə təyin edin).
*/
Console.WriteLine("Mezenne cevrilmesini secin:\n1.AZN-den USD-e\n2.USD-den AZN-e");
int option = int.Parse(Console.ReadLine());
Console.WriteLine("Meblegi daxil edin");
int cash = int.Parse(Console.ReadLine());
int change = 0;
if (option == 1)
{
    change = cash * 59 / 100;
    Console.WriteLine($"{cash} AZN {change} USD edir");
}
else if (option == 2)
{
    change = cash * 100 / 59;
    Console.WriteLine($"{cash} USD {change} AZN edir");
}
else
{
    Console.WriteLine("Meblegi duzgun daxil edin");
}
#endregion
#region Task18
/*Tapşırıq 18: 
İstifadəçinin boyunu (metr ilə) və çəkisini (kg ilə) alıb BMI (Body Mass Index) hesablayın və nəticəyə uyğun olaraq aşağıdakı mesajlardan birini çap edən proqramı yazın:

BMI Aralığı	Çap olunacaq məlumat
0-18.5		Çəki azlığı
18.5-24.9	Normal çəki
25-29.9		Artıq çəki
30 və daha çox	Piylənmə*/
Console.WriteLine("BMI hesablanmasi ucun boyunuzu (metr)daxil edin :");
int height = int.Parse(Console.ReadLine());
Console.WriteLine("Cekinizi (kg) daxil edin:");
int weight = int.Parse(Console.ReadLine());
int bmi = weight / (height * height);
if (bmi>0 && bmi<=18.5)
{
    Console.WriteLine("Sizde ceki azligi var,yemek yeyek(");
}
else if (bmi<18.5 && bmi<=24.9)
{
    Console.WriteLine("Normal cekidesiniz,siz jivoysunuz");
}
else if (bmi>=25 && bmi<=29.9)
{
    Console.WriteLine("Artiq cekiniz var, onlari azaltmaq lazimdir");
}
else if (bmi==30 && bmi>=30)
{
    Console.WriteLine("Gel meni de ye");
}
else
{
    Console.WriteLine("impossible");
}
#endregion

# region Task20
int[] nums = { 1, 2, 3, 4, 5 };
for(int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}
#endregion
# region Task21
int[] nums = { 1, 2, 3 };
int sum = 0;
for(int i=0; i<nums.Length;i++)
{
    sum = sum + nums[i];
    
}
Console.WriteLine(sum);
#endregion
# region Task22
int[] nums = { 1, 2, 3 };
int sum = 0;
for(int i=0;i<nums.Length;i++)
{

    sum = sum + nums[i];

}
Console.WriteLine(sum/nums.Length);
#endregion
#region Task23
int[] nums = {1,2,3,5,4,0};
int maxnum = nums[0];
int minnum = nums[0];
int maxindex = 0;
int minindex = 0;
for(int i=0; i<nums.Length; i++)
{
    if (maxnum < nums[i])
    {
        maxnum = nums[i];
        maxindex = i;
    }
    if (minnum > nums[i])
    {
        minnum = nums[i];
        minindex = i;
    }
}
Console.WriteLine($"max element: {maxnum}, index: {maxindex}");
Console.WriteLine($"min element: {minnum}, index: {minindex}");
#endregion
# region Task24

int[] nums = { 1, 3, 4, 6, 8, 9, 5 };
int cut = nums[0];
for(int i=0; i < nums.Length; i++)
{
    if (nums[i] % 2 == 0)
    {
        cut = nums[i];
        Console.WriteLine(cut);
    }
    
}
#endregion
# region Task25
int[] nums = { 1, 3, 4, 6, 8, 9, 5 };
int[] newArr = new int[nums.Length];
for(int i =0; i<nums.Length; i++)
{
    newArr[i] = nums[nums.Length - 1 - i];
    Console.WriteLine(newArr[i]);
}
#endregion
# region Task26
int[] nums = { 1, 3, 4, 6, 8, 9, 5 };
bool found = false;
for (int i = 0; i < nums.Length;i++)

{
    if (nums[i] == 2)
    {
        Console.WriteLine("axtarilan ededin indexi"+ i);
        found = true;
    }
    
}
if(!found)
    {
    Console.WriteLine("eded tapilmadi");
}
#endregion
# region Task28
int[] nums = { 1, 2, 3, 4, 5, 6 };
int max = default;
int max2 = default;
for(int i=0; i < nums.Length; i++)
{
    if (nums[i]>max)
    max2 = max;
    max = nums[i];
    if (nums[i] > max2&& max != nums[i])
    {
        max2 = nums[i];
    }
   

}
Console.WriteLine(max2);
#endregion
#region Task29
int a = Convert.ToInt32(Console.ReadLine());
int qaliq = 0;
int sum = 0;
while (a > 0)
{

    qaliq = a % 10;
    a = (a - qaliq) / 10;
    sum = sum + qaliq;
}
Console.WriteLine(sum);
#endregion
#region Task30
int a = Convert.ToInt32(Console.ReadLine());
int qaliq = 0;
int count = 0;
while (a > 0)
{
    qaliq = a % 10;
    a = (a - qaliq) / 10;
    count++;
}

Console.WriteLine(count);
#endregion
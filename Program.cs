//SORU 1 
System.Console.WriteLine("Lütfen 20 adet pozitif sayı giriniz : ");
List<int> asalSayılar = new List<int>() ;
List<int> asalOlmayan = new List<int>() ;
for (int i = 0; i < 20; i++)
{
    System.Console.WriteLine($"{i+1}i sayi giriniz");
    string sayiStr = Console.ReadLine().Trim();
    int sayi;

    while (!int.TryParse(sayiStr, out sayi) || sayi < 0)
    {
        System.Console.WriteLine("YSNLIŞ DEĞER GİRİLDİ TEKRER DENEYİN");
        sayiStr = Console.ReadLine().Trim();

    }
    
    int flag  =0;
    int  m = 0;
    m = sayi / 2;
    for (int j =2; j <=m;j++)
    {
        if (sayi % j == 0)
        {
            asalOlmayan.Add(sayi);
            flag = 1;
            break;
        }


    }
    if (flag == 0)
       asalSayılar.Add(sayi);
    }
System.Console.WriteLine("-------------------------------");
System.Console.WriteLine("Asal sayılar : ");
asalSayılar.Sort();
int asalSayılarınToplamı = 0;
int asalSayılarınSayısı = asalSayılar.Count() ;
foreach (var item in asalSayılar)
{
    
    System.Console.WriteLine(item);
    asalSayılarınToplamı += item;
}
System.Console.WriteLine("asal sayıların sayısı : " + asalSayılarınSayısı);
System.Console.WriteLine("asal sayıların ortalaması : "+(asalSayılarınToplamı/asalSayılarınSayısı));
System.Console.WriteLine("asal Olmayan sayılar : ");
asalOlmayan.Sort();
int asalOlmayanSayılarınToplamı = 0;
int asalOlmayanSayılarınSayısı = asalOlmayan.Count() ;
foreach (var item in asalOlmayan)
{
    
    System.Console.WriteLine(item);
    asalOlmayanSayılarınToplamı += item;
}
System.Console.WriteLine("asal olmayan  sayıların sayısı : " + asalOlmayan.Count());
System.Console.WriteLine("asal olmayan sayıların ortalaması : "+ asalOlmayanSayılarınToplamı/asalOlmayanSayılarınSayısı);

System.Console.WriteLine("Lütfen 20 adet sayı giriniz : ");  
//*** SORU 2 ***
int[] sayılar = new int[10];
for (int i = 0; i < 10; i++)
    {   
        System.Console.WriteLine($"{i+1}i sayi giriniz");
        string sayıStr = Console.ReadLine().Trim();
        int sayi;
        
        while (!int.TryParse(sayıStr,out sayi))
            {
                System.Console.WriteLine("yanlış veri girildi lütfen tekrer deneyiniz");
                sayıStr = Console.ReadLine().Trim();

            } 
        sayılar[i] = sayi;
    }

int j,first,second,third;
double firstk = double.PositiveInfinity;
double secondk = double.PositiveInfinity;
double thirdk = double.PositiveInfinity;
third = second = first  =  000;
for ( j = 0; j < 10; j++)
{
    if (sayılar[j] > first) {
                third = second;
                second = first;
                first = sayılar[j];
            }
     else if (sayılar[j] > second) {
                third = second;
                second = sayılar[j];
            }
     else if (sayılar[j] > third) {
                third = sayılar[j];
                
            }

    if (sayılar[j] < firstk) {
        firstk = secondk;
        secondk = thirdk;
        thirdk = sayılar[j];
    }
     else if (sayılar[j] < secondk) {
                firstk = secondk;
                secondk = sayılar[j];
            }
     else if (sayılar[j] < thirdk) {
                firstk = sayılar[j];
                
            }
}
int[] enBüyükler = new int[3];
enBüyükler[0] = third;
enBüyükler[1] = second;
enBüyükler[2] = first;

System.Console.WriteLine("En büyük 3 sayı "+first + " "+second +" "+third);
System.Console.WriteLine("En büyük 3 sayının ortalaması "+(first +second +third)/3);

System.Console.WriteLine("En küçük 3 sayı "+firstk + " "+secondk +" "+thirdk);
double ortalama = Math.Round((firstk+secondk+thirdk)/3);
System.Console.WriteLine("En küçük 3 sayının ortalaması "+ ortalama);


// SORU 3
//Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde 
//saklayan ve dizinin elemanlarını sıralayan programı yazınız.

char[] sesliHarfler = {'a','e','i','ı','o','ö','ü','u'};
System.Console.WriteLine("lütfen bir cümle yazınız ");
string cümle = Console.ReadLine().Trim();
char[] charArr = cümle.ToCharArray();

char[] cumledekiSesliHarfler =new char[charArr.Length] ;
for (int i = 0; i < charArr.Length; i++)
{
    if (charArr[i]=='a'||
        charArr[i]=='e'||
        charArr[i]=='ı'||
        charArr[i]=='i'||
        charArr[i]=='o'||
        charArr[i]=='ö'||
        charArr[i]=='u'||
        charArr[i]=='ü'
        )
    {
        cumledekiSesliHarfler[i] = charArr[i];
    }
}
foreach (var item in cumledekiSesliHarfler)
{
    System.Console.Write(item);
}
System.Console.WriteLine(cumledekiSesliHarfler.Count());
//benim adım abdülhamid eyyüb soltan
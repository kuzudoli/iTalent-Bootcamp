/*GÖMÜLÜ DELEGATE*/
//Action
using day3;

//Action<int> action = new Action<int>(actionMethod);
//action(5);


////Predicate
//Predicate<string> predicate = new Predicate<string>(predicateMethod);
//Console.WriteLine(predicate("enes"));


////Func
//Func<int, int, int> func = new Func<int, int, int>(funcMethod);
//Console.WriteLine(func(5, 7));



//void actionMethod(int number)
//{
//    Console.WriteLine(number);
//}

//bool predicateMethod(string text)
//{
//    if (text[0] == 'a')
//        return true;
//    return false;
//}

//int funcMethod(int a, int b)
//{
//    return a + b;
//}
/*GÖMÜLÜ DELEGATE BİTİŞ*/

/*EVENT*/
var nft = new NFT();

nft.SoldEvent += (nftID) => { Console.WriteLine($"{nft.name} {nftID}# satıldı!"); };

int sayi = 0;
while(sayi != 2)
{
    Console.WriteLine("Satın almak için 2 sayisini giriniz:");
    sayi = Convert.ToInt16(Console.ReadLine());
}

nft.buy();
//Sürekli ekrana basıyor

/*EVENT BİTİŞ*/
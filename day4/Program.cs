using day4;
using day4.Extensions;

//BL bl = new BL(new DAL());

////Events
//bl.DownThresholdEvent += Bl_DownThresholdEvent;

//void Bl_DownThresholdEvent(int count)
//{
//    Console.WriteLine("Ürün sayısı kritik durumda: " + count);

//}

//bl.UpThresholdEvent += Bl_UpThresholdEvent;

//void Bl_UpThresholdEvent(int count)
//{
//    Console.WriteLine("Maksimum ürün sayısına ulaşıldı: " + count);
//}

//bl.AddProduct(new() { id = 0, name = "Ürün 1", price = 100 });
//bl.AddProduct(new() { id = 1, name = "Ürün 2", price = 100 });
//bl.AddProduct(new() { id = 2, name = "Ürün 3", price = 100 });
//bl.AddProduct(new() { id = 3, name = "Ürün 4", price = 100 });
//bl.AddProduct(new() { id = 4, name = "Ürün 5", price = 100 });
//bl.AddProduct(new() { id = 5, name = "Ürün 6", price = 100 });
//bl.AddProduct(new() { id = 6, name = "Ürün 7", price = 100 });
//bl.AddProduct(new() { id = 7, name = "Ürün 8", price = 100 });
//bl.AddProduct(new() { id = 8, name = "Ürün 9", price = 100 });
//bl.AddProduct(new() { id = 9, name = "Ürün 10", price = 100 });
//bl.AddProduct(new() { id = 10, name = "Ürün 11", price = 100 });


//bl.ReadProductList().ForEach(x =>
//{
//    Console.WriteLine(x.name);
//});

//for(var i=0;i<7; i++)
//{
//    bl.RemoveProduct(i);
//}


//SOLID Principles
using day4.SOLID;
//->OCP

//ProductRepository2 repository2 = new ProductRepository2(new MongoDBRepository());

//repository2.GetAll().ForEach(x =>
//{
//    Console.WriteLine(x);
//});

//->SLP

//Phone iphone = new IPhone();
//iphone.Call();
//((ITakePhoto)iphone).TakePhoto();

////no more error
//Phone nokia = new Nokia3310();
//nokia.Call(); 
////can't reach takephoto
///

//->ISP

//IReadRepository repository = new Repository2();
//Now only access the READ operates


//Extensions

//string name = "enes";
//Console.WriteLine(name.BuyukHarfYap());

//int number = 5;
//Console.WriteLine(number.KareAl());

List<Person> personList = new List<Person>();
List<PersonDto> personDtoList = new List<PersonDto>();

personList.Add(new() { name = "enes", surname = "cakir", age = 22 });
personList.Add(new() { name = "ahmet", surname = "yildiz", age = 22 });
personList.Add(new() { name = "mehmet", surname = "son", age = 22 });

personList.toConvertDto(x => x.name.Contains("en")).ForEach(x =>
{
    Console.WriteLine(x.fullname);
});

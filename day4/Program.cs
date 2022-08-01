//using day4;

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

//->OCP
//using day4.SOLID;

//ProductRepository2 repository2 = new ProductRepository2(new MongoDBRepository());

//repository2.GetAll().ForEach(x =>
//{
//    Console.WriteLine(x);
//});

//->SLP

using day4.SOLID;

Phone iphone = new IPhone();
iphone.Call();
((ITakePhoto)iphone).TakePhoto();

//no more error
Phone nokia = new Nokia3310();
nokia.Call(); 
//can't reach takephoto
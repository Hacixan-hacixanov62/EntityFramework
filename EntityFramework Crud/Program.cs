
//using EntityFramework_Crud.Data;

//AppDbContext context= new AppDbContext();
//void GetAllSettings()
//{
//    var datas = context.Settings.ToList();

//    foreach (var item in datas)
//    {
//        Console.WriteLine(item.Address+" "+item.Phone+" "+item.Email);

//    }

//}

//void GetById(int id)
//{
//    var data = context.Settings.FirstOrDefault(m=>m.Id == id);

//    Console.WriteLine(data.Address + " " + data.Phone + " " + data.Email);
//}

//GetAllSettings();

//Console.WriteLine("-------------------");


//GetById(2);   





using EntityFramework_Crud.Controllers;

SettingController settingController = new SettingController();

await settingController.GetAllAsync();

//await settingController.GetByIdAsync();

//await settingController.CreateAsync();

await settingController.DeleteAsync();

await settingController.GetAllAsync();
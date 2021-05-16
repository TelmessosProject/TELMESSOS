using System;
using System.Collections.Generic;
using TELMESSOS.BUSINESS.Abstract;
using TELMESSOS.BUSINESS.Concrete;
using TELMESSOS.DATAACCESS.Concrete.EntityFramework;

namespace TestConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			//EfUserDal efUserDal= new EfUserDal();
			////efUserDal.Insert(new TELMESSOS.ENTITIES.Entity.User { Name="Duygu2",Lastname="Ulu2", Password="1234", Username="duyguulu2" });
			//var list = efUserDal.GetAll();
			//foreach (var i in list)
			//{
			//	Console.WriteLine($"Kayıt:{i.Name}");
			//}
			//Console.WriteLine("---------------");

			//var getList = efUserDal.Get();
			//Console.WriteLine(getList.Name);

			var idsList = new List<int>();
			idsList.Add(1);
			idsList.Add(2);

			IUserService userService = new UserManager(new EfUserDal { });
			var result=userService.GetUsersByIds(idsList);
			foreach (var data in result.Data)
			{
				data.Name = data.Name + "test";
				Console.WriteLine($"{data.Name}");

			}

			userService.Update(result.Data);
			





		}
	}
}

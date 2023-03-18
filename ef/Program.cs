using EF.Services;

SubjectService service = new SubjectService();
service.GetAll().ForEach(s => Console.WriteLine(s));


Console.ReadKey();
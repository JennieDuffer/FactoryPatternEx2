using FactoryPatternEx2;

Console.WriteLine("What database do you want to use:    ");
Console.WriteLine();
Console.WriteLine("List");
Console.WriteLine("SQL");
Console.WriteLine("Mongo");
Console.WriteLine();

var response = Console.ReadLine();

IDataAccess database = DataAccessFactory.GetDataAccessType(response);
database.LoadData();
database.SaveData();

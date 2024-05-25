// using System.Text.Json;


// var antonio = new People()
// {
//   Name = "Antonio",
//   Age = 29,
// };

// People.Get(); //static

// string json = JsonSerializer.Serialize(antonio);

// Console.WriteLine(json);

// string myJson = @"{
//   ""Name"":""Pedro"",
//   ""Age"":34
// }";

// People? juan = JsonSerializer.Deserialize<People>(myJson);
// Console.WriteLine(juan?.Name);
// Console.WriteLine(juan?.Age);


// public class People
// {
//   public string Name { get; set; }
//   public int Age { get; set; }

//   public static string Get() => "Hola";
//   // public static string Get() {return "hola"};

// }
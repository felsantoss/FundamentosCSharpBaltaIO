var id = Guid.NewGuid(); // gerando um novo Guid

id = new Guid("b0b4e983-e854-4033-8ed3-01ad5488f317");

Console.WriteLine(id);
Console.WriteLine(id.ToString().Substring(0, 8)); // Pegando os 8 primeiros caracteres do guid 
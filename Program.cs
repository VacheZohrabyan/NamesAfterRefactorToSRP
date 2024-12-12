using System;

var names = new Names();
var path = new NamesFilePatfBuilder().BuilderFilePath();
var stringTextualRepository = new StringTextualRepository();
if (File.Exists(path))
{
    Console.WriteLine("Names file already exists. Loading names.");
    var stringFormFile = new StringTextualRepository().Read(path);
    names.AddNames(stringFormFile);
}
else
{
    Console.WriteLine("Names file does not yet exist.");
    
    names.AddName("John");
    names.AddName("not valid name");
    names.AddName("Clear");
    names.AddName("123 definitely not a valid name");
    
    Console.WriteLine("Saving names to the file");
    stringTextualRepository.Write(path, names.All);
}

Console.WriteLine(new NamesFormatter().Format(names.All));

Console.ReadKey();
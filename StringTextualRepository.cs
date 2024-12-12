public class StringTextualRepository
{
    private static readonly string Separator = Environment.NewLine;

    public List<string> Read(string FilePath)
    {
        var fileContents = File.ReadAllText(FilePath);
        return fileContents.Split(Separator).ToList();
    }

    public void Write(string FilePath, List<string> names)
    {
        File.WriteAllText(FilePath,string.Join(Separator, names));
    }
}
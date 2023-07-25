using IniParser;
using IniParser.Model;

class Program{
    public static void Main(string[] args){

        if(args.Length == 0){
            return;
        }

        if(!File.Exists(args[0])){
            return;
        }

        FileInfo fileInfo = new (args[0]);
        if(fileInfo.Extension.ToLower() != ".ini"){
            return;
        }

        CriarClasseINI(fileInfo);
    }

    static void CriarClasseINI(FileInfo arquivo){
        string arqBase = arquivo.Name.Replace(".ini",".cs");
        FileIniDataParser parser = new();
        IniData data = parser.ReadFile(arquivo.FullName);

        if(File.Exists(arqBase))
            File.Delete(arqBase);

        using StreamWriter streamWriter = new(arqBase);
        foreach (var item in data.Sections)
        {
            streamWriter.WriteLine("public class " + item.SectionName + "\n{");
            foreach (var section in item.Keys)
            {
                streamWriter.WriteLine("    public string " + section.KeyName + " { get; set; } = \"\";");
            }
            streamWriter.WriteLine("}");
        }
    }

}
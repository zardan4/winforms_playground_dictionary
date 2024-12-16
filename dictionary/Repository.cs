using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

public class Repository
{
    private const string path = "../dictionary.txt";

    public List<Translation> GetAll()
    {
        string contents = File.ReadAllText(path);

        var lines = Regex.Split(contents, "\r\n|\r|\n");

        List<Translation> result = new List<Translation>();

        foreach (var line in lines)
        {
            if (line.Trim() == "") continue;

            var lineSegments = line.Split(';');
            var trans = new Translation(lineSegments[0], lineSegments[1]);

            result.Add(trans);
        }

        return result;
    }

    public void PutTranslation(string First, string Second)
    {
        List<Translation> All = GetAll();

        using (StreamWriter writer = new StreamWriter(path, false))
        {
            {
                string output = "";
                bool modified = false;

                foreach (var trans in All)
                {
                    if (trans.English == First)
                    {
                        trans.Ukrainian = Second;
                        modified = true;
                    }
                    else if (trans.Ukrainian == First)
                    {
                        trans.English = Second;
                        modified = true;
                    }

                    output += $"{trans.English};{trans.Ukrainian}\r\n";
                }

                if (!modified)
                {
                    output += $"{First};{Second}\r\n";
                }

                writer.Write(output);
            }

            writer.Close();
        }
    }

    // translation itself + from which lang was translated
    public Translation GetTranslation(string ToTranslate)
    {
        List<Translation> All = GetAll();

        foreach (var Item in All)
        {
            if (Item.English.ToLower() == ToTranslate.ToLower() || Item.Ukrainian.ToLower() == ToTranslate.ToLower()) return Item;
        }

        return new Translation("", "");
    }
}
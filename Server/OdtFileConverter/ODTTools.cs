using AODL.Document.TextDocuments;
using AODL.Document.Content;
using System.Text;
using System.Xml.Linq;

namespace OdtFileConverter
{
    public static class ODTTools
    {
        public static string GetTextFromOdt(string path)
        {
            var sb = new StringBuilder();
            using (var doc = new TextDocument())
            {
                doc.Load(path);

                //The header and footer are in the DocumentStyles part. Grab the XML of this part
                XElement stylesPart = XElement.Parse(doc.DocumentStyles.Styles.OuterXml);
                //Take all headers and footers text, concatenated with return carriage
                string stylesText = string.Join("\r\n", stylesPart.Descendants().Where(x => x.Name.LocalName == "header" || x.Name.LocalName == "footer").Select(y => y.Value));

                //Main content
                var mainPart = doc.Content.Cast<IContent>();
                var mainText = String.Join("\r\n", mainPart.Select(x => x.Node.InnerText));

                //Append both text variables
                sb.Append(stylesText + "\r\n");
                sb.Append(mainText);
            }

            return sb.ToString();
        }

        public static void InformationAboutFiles()
        {
            int i = 0;
            int odt = 0;
            int jpg = 0;
            int other = 0;

            List<string> files = new List<string>();

            foreach (string file in Directory.GetFiles("./Aplikacja/", "", SearchOption.AllDirectories))
            {
                if (file.EndsWith(".odt")) odt++;
                else if (file.EndsWith(".jpg")) jpg++;
                else
                {
                    files.Add(file);
                    other++;
                }

                i++;
                Console.WriteLine(i + " - " + file);
            }

            Console.WriteLine($"\nStatystyki:\nodt: {odt}\njpg: {jpg}\nRazem: {odt + jpg}\nLiczba plików: {i}\n");

            foreach (string file in files)
                Console.WriteLine(file);
        }
    }
}

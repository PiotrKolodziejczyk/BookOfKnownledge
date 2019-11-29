using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookOfKnownledge
{
   public static class Knownledge
    {
        
        public static List<Note> CreateNote(string path,string text)
        {
            MatchCollection resultNote;
            Regex regex =
                new Regex(@"^.+$", RegexOptions.Multiline);
            if (text != null)
            {
                text = text.TrimEnd();
                resultNote = regex.Matches(text);
                
            }
            else
            {
                resultNote = regex.Matches(File.ReadAllText(path));
            }
            

            List<Note> noteList = new List<Note>();

            foreach (Match item in resultNote)
            {
                Note note = new Note
                {
                    Info = item.Value
                };
                noteList.Add(note);
            }
            return noteList;
        }

        public static List<Book> CreateBook(string path,string text)
        {
            MatchCollection resultRegularExpressionKnownledge;
            Regex regexRegularExpressionKnownledge =
                new Regex(@"(?<title>.*?)( \()(?<description>.*?)\)<;(?<expression>.*?)(;>)(Receptura\s(?<recipe>\d+\.\d+\.))( str (?<page>\d+))",
                          RegexOptions.Multiline | RegexOptions.IgnoreCase);

            if (text != null)
            {
                resultRegularExpressionKnownledge = regexRegularExpressionKnownledge.Matches
                                                    (text);
            }
            else
            {
               resultRegularExpressionKnownledge = regexRegularExpressionKnownledge.Matches
                                                    (File.ReadAllText(path));
            }
            
            List<Book> listOfRegularExpressionKnowledge = new List<Book>();
            foreach (Match item in resultRegularExpressionKnownledge)
            {
                Book line = new Book
                {
                    Title = item.Groups["title"].Value,
                    Description = item.Groups["description"].Value,
                    Expression = item.Groups["expression"].Value,
                    Recipe = item.Groups["recipe"].Value,
                    Page = Int32.Parse(item.Groups["page"].Value)
                };
                listOfRegularExpressionKnowledge.Add(line);
            }
            return listOfRegularExpressionKnowledge;
        }
    }
    
}

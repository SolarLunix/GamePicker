using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePicker
{
    class AllLists
    {
        List<String> ownedPlatforms = new List<String>();
        

        static public void fillAllGames()
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file =
               new System.IO.StreamReader("Games.txt");
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
                counter++;
            }

            file.Close();
        }

        static public void addGameToList(List<Boolean> platforms, String gameName, List<Boolean> Attributes, List<String> genres)
        {
            
        }

    }

}

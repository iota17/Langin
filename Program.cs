using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
namespace Lingin
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("[     [[[  [   [  [[[[  [ [   [ [");
            Console.WriteLine("[    [   [ [[  [ [      [ [[  [  [");
            Console.WriteLine("[    [---[ [ [ [ [   [[ [ [ [ [");
            Console.WriteLine("[[[[ [   [ [  [[  [[[[  [ [  [[");

            // *PHONOLOGY*

            //consonants
            Console.WriteLine(); Console.WriteLine("==========="); Console.WriteLine();
            Console.WriteLine("Write your consonants (ipa, NO COMMAS OR SPACES)");
            Console.WriteLine(); Console.WriteLine("==========="); Console.WriteLine();
            string phonemeStringC = Console.ReadLine();
            //add help
            if (phonemeStringC == "help")
            {
                Console.WriteLine("https://en.wikipedia.org/wiki/International_Phonetic_Alphabet");
                Console.WriteLine();
                Console.WriteLine("Write your consonants (ipa, NO COMMAS OR SPACES)");
                phonemeStringC = Console.ReadLine();
            }
            char[] phonemesC = strCharArray(phonemeStringC);
            //vowels
            Console.WriteLine(); Console.WriteLine("==========="); Console.WriteLine();
            Console.WriteLine("Write your vowels (ipa, NO COMMAS OR SPACES)");
            Console.WriteLine(); Console.WriteLine("==========="); Console.WriteLine();
            string phonemeStringV = Console.ReadLine();
            //add help
            if (phonemeStringV == "help")
            {
                Console.WriteLine();
                Console.WriteLine("https://en.wikipedia.org/wiki/International_Phonetic_Alphabet");
                Console.WriteLine();
                Console.WriteLine("Write your vowels (ipa, NO COMMAS OR SPACES)");
                phonemeStringV = Console.ReadLine();
            }
            char[] phonemesV = strCharArray(phonemeStringV);

            string[] phonemesVtxt = new string[phonemesV.Count()];
            string[] phonemesCtxt = new string[phonemesC.Count()];

            for(int i = 0; i < phonemesV.Count(); i++)
            {
                phonemesVtxt[i] = phonemesV[i].ToString();
            }
            for(int i = 0; i < phonemesC.Count(); i++)
            {
                phonemesCtxt[i] = phonemesC[i].ToString();
            }

            //displays all phonology
            Console.WriteLine();
            
            Console.WriteLine("Here is your phonology:");

            Console.WriteLine();

            while (true)
            {
                try
                {
                    for(int i = 0; i < 1000000; i++)
                    {
                        Console.WriteLine(phonemesVtxt[i]);
                    }
                }
                catch
                {
                    break;
                }
            }
            while (true)
            {
                try
                {
                    for (int i = 0; i < 1000000; i++)
                    {
                        Console.WriteLine(phonemesCtxt[i]);
                    }
                }
                catch
                {
                    break;
                }
            }

            //do you like your alphabet
            {
                Console.WriteLine("Do you like it (true or false)");

                bool love = bool.Parse(Console.ReadLine());

                if(love == true)
                {
                    Console.WriteLine("Gud");
                }
                else if(love == false)
                {
                    Console.WriteLine("Too bad sucka!!!");
                    Environment.Exit(0);
                }
            }

            //welcomes to MORPHOLOGY section
            {    
                Console.WriteLine("                            .__           .__                      ");
                Console.WriteLine("  _____   _________________ |  |__   ____ |  |   ____   ____ ___.__.");
                Console.WriteLine(" /     \\ /  _ \\_  __ \\____ \\|  |  \\ /  _ \\|  |  /  _ \\ / ___<   |  | ");
                Console.WriteLine("|  Y Y  (  <_> )  | \\/  |_> >   Y  (  <_> )  |_(  <_> ) /_/  >___  | ");
                Console.WriteLine("|__|_|  /\\____/|__|  |   __/|___|  /\\____/|____/\\____/\\___  // ____|");
                Console.WriteLine("      \\/             |__|        \\/                  /_____/ \\/     ");
            
                Console.WriteLine();

                Console.WriteLine("Welcome to MORPHOLOGY, the only segment which actually killed me inside to code! Here we will lay out ALL the rules for your language, you can always skip a step by typing \"skip card\";");
            }
            
            //creates "MorphSave.txt"
            try
            {
                File.Copy("MorphBase.txt", "MorphSave.txt");
            }
             catch
            {
                Console.WriteLine("Running this program will overwite your previous language, do you wish to continue. If you wish to not overwite your file, type false and move \"MorphSave.txt\" out of \"C:\\Users\\Sebbie\\source\\repos\\Langin'\\bin\\release\", then reboot the program");
                
                if(bool.Parse(Console.ReadLine()) == false)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Ok");
                    Console.WriteLine();
                }
            }
            
            //creates interactable morphology section
            string[] morfSv = File.ReadAllLines("MorphBase.txt");

            //writes alphabet in save file
            morfSv[0] = phonemeStringC + phonemeStringV;

            //handles encoding morphology on file
            while (true) 
            {
                for (int i = 1; i < 1000; i++)
                {
                    try
                    {
                        if(i % 2 == 1)
                        {
                            try
                            { 
                                Console.WriteLine(morfSv[i]);
                             
                                #pragma warning disable CS8601 // Possible null reference assignment.

                                morfSv[i+1] = Console.ReadLine();

                                #pragma warning restore CS8601 // Possible null reference assignment.
    
                                File.WriteAllLines("MorphSave.txt", morfSv);
                                }
                            catch
                            {
                                Console.WriteLine("DONE!");
                                break;
                            }
                        }
                    }
                    catch
                    {
                        break;
                    }
                }
                
                break;
            }
            
        }
        public static char[] strCharArray(string parse)
        {
            char[] result = new char[parse.Length];
            for (int i = 0; i < parse.Length; i++)
            {
                result[i] = parse[i];
            }
            return result;
        }
        public static string[] charStrArray(char[] parse)
        {
            string[] result = new string[parse.Length];
            for (int i = 0; i < parse.Length; i++)
            {
                result[i] = parse[i].ToString();
            }
            return result;
        }
        
            
    }
}

//©iota17 & iota17a
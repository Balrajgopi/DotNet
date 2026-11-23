using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProblemSet1_Inheritance
{
    internal class AudioFile : MediaFile, Iplayable
    {
        public override string Play()
        {
            return $"{PlayInfo()}.....";
        }

        public override string Pause()
        {
            return $"{PauseInfo()}......";
        }

        //string Iplayable.Pause { get => Pause; set => "Paused"; }

        public string PlayInfo()
        {
            return $" * {FileName} is Playing";
        }

        public string PauseInfo()
        {
            return $" * {FileName} is Pausing";
        }

        //public override void DisplayInfo()
        //{
        //    Console.Write(" * Enter Audio FileName : ");
        //    FileName = Console.ReadLine();

        //    Console.Write(" * Do You Want To Play : Y/N : ");
        //    string Input = (Console.ReadLine().ToLower());

        //    string[] y = { "yes", "y", "yeap", "1" };
        //    string[] n = { "no", "n", "nope", "2" };

        //    //   for (int i = 0; i < y.Length; i++)
        //    //{
        //    //if (y[i] == Input)
        //    if (y.Contains(Input))
        //    {
        //        Console.WriteLine(PlayInfo());

        //    }

        //    // else if (n[i] == Input)
        //    else if (n.Contains(Input))
        //    {
        //        Console.WriteLine(PauseInfo());

        //    }

        //    else
        //    {
        //        Console.WriteLine(" * Take A Chill Pilll Byeeeee.....<3");
        //    }
        //    //}

        public override void DisplayInfo(string Filename, bool input)
        {
            FileName = Filename;

            Console.WriteLine($"Video File Name : {Filename}");

            if (input)
            {
                Console.WriteLine(Pause());
            }
            else
            {
                Console.WriteLine(PlayInfo());
            }
        }
                
        static void Main(string[] args)
        {
            AudioFile A1 = new AudioFile();

            A1.DisplayInfo("Sound",true);
        }


    }

}

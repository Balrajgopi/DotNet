using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProblemSet1_Inheritance
{
    internal class VideoFile : MediaFile,Iplayable
    {
        public override string Play()
        {
            return $"Playing the {FileName} video";
        }

        public string PlayInfo()
        {
            return Play();
        }
        
        public string PauseInfo()
        {
            return $"Pausing the {FileName} Video";
        }

        public override string Pause()
        {
            return PauseInfo();
        }

        public override void DisplayInfo(string Filename, bool input)
        {
            FileName = Filename ;
          
            Console.WriteLine($"Video File Name : {Filename}" );

            if (input)
            {
                Console.WriteLine(Pause());
            }
            else
            {
                Console.WriteLine(PlayInfo());
            }
        }

        static void Main (string[]args)
        {
            VideoFile V1= new VideoFile();

            V1.DisplayInfo("Hello", false);
        }
    }
}

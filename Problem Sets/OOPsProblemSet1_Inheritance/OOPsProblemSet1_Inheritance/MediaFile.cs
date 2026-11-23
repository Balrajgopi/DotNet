using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProblemSet1_Inheritance
{
    internal abstract class MediaFile
    {
        //public string Input
        //{
        //    get { return Input; }
        //    set { Input = value; }
        //}
        public abstract string Play();
        public abstract string Pause();
        public string FileName { get; set; }

        public abstract void DisplayInfo(string Filename,bool input);
    }
}

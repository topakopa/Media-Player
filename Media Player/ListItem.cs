using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player
{
    class ListItem
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FullPath { get; set; }
        public string Format { get; set; }
        public string OldFullPath { get; set; }
        public string GetFullPath()
        { 
            if (FullPath == null)
            {
                return Path.Combine(FilePath, FileName+'.'+Format);
            }
            else
            {
                return FullPath;
            }
        } 

        public override string ToString()
        {
            return FileName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CountLines
{
    public class FilterLineCons
    {
        private string filePath;
        private bool isBrace;
        private bool isSpace;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public bool IsBrace
        {
            get { return isBrace; }
            set { isBrace = value; }
        }

        public bool IsSpace
        {
            get { return isSpace; }
            set { isSpace = value; }
        }

        private string includeStr;
        private bool relationAnd;
        private string excludeStr;

        public string IncludeStr
        {
            get { return includeStr; }
            set { includeStr = value; }
        }

        public bool RelationAnd
        {
            get { return relationAnd; }
            set { relationAnd = value; }
        }

        public string ExcludeStr
        {
            get { return excludeStr; }
            set { excludeStr = value; }
        }


    }
}

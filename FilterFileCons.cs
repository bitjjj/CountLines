using System;
using System.Collections.Generic;
using System.Text;

namespace CountLines
{
    public class FilterFileCons
    {
        private string filters;
        private string includeStr;
        private bool relationAnd;
        private string excludeStr;

        public string Filters
        {
            get { return filters; }
            set { filters = value; }
        }
        
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

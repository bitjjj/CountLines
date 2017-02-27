using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CountLines
{
    public static class Utility
    {

        public static string RightFileKindFormat(string kind)
        {
            StringBuilder sbKind = new StringBuilder();
            foreach (char c in kind)
            {
                if (c != '/' && c != '\\' && c != ':' && c != '*' && c != '?' && c != '<' && c != '>' && c != '|' && c != '"')
                    sbKind.Append(c);
            }
            if (sbKind[0] != '.')
                sbKind.Insert(0, '.');
            return sbKind.ToString();
        }

        public static string[] SplitKind(System.Collections.Specialized.StringCollection kind)
        {
            string[] kinds = new string[kind.Count];
            kind.CopyTo(kinds, 0);
            return kinds;
        }

        public static int CountFileLines(string path,FilterLineCons condition,Dictionary<string,int> lineInfo)
        {

            int lines = 0;
            string aLine = null;
            if (File.Exists(path))
            {
                try
                {
                    StreamReader sr = new StreamReader(path, Encoding.Default);
                    while (!sr.EndOfStream)
                    {
                        aLine = sr.ReadLine().Trim();
                        if (aLine.StartsWith("using ") || aLine.StartsWith("#include ") || aLine.StartsWith("import ")
                            || aLine.StartsWith("imports ") || aLine.StartsWith("namespace "))
                        {
                            lineInfo[Constants.NAMESPACENUM] += 1;
                            continue;
                        }
                        if (aLine == "{" || aLine == "}")
                            lineInfo[Constants.BRACENUM] += 1;
                        if (!condition.IsBrace && (aLine == "{" || aLine == "}"))
                            continue;
                        if (aLine == "")
                            lineInfo[Constants.SPACENUM] += 1;
                        if (!condition.IsSpace && aLine == "")
                            continue;
                        if (FilterLine(aLine,condition))
                        {
                            lineInfo[Constants.FILTERCONSNUM] += 1;
                            if (condition.IsBrace && (aLine == "{" || aLine == "}"))
                            {
                                lineInfo[Constants.COMMONNUM] += 1;
                            }
                            if (condition.IsSpace && aLine == "")
                            {
                                lineInfo[Constants.COMMONNUM] += 1; 
                            }
                            continue;
                        }
                        lineInfo[Constants.COMMONNUM] += 1;
                        lines++;
                    }
                }
                catch
                {
                    lines = 0;
                }
            }
            return lines;
        }

        public static bool FilterLine(string lineStr, FilterLineCons condition)
        {
            if (condition.IncludeStr != null && condition.IncludeStr != "")                  //如果包含的字符串为空
            {
                if (condition.ExcludeStr == null || condition.ExcludeStr == "")         //如果不包含的字符串为空
                {
                    if (lineStr.IndexOf(condition.IncludeStr) == -1)
                    {
                        return true;
                    }
                }
                else
                {
                    if (condition.RelationAnd)                                          //如果关系为并且
                    {
                        if (!(lineStr.IndexOf(condition.IncludeStr) != -1 && lineStr.IndexOf(condition.ExcludeStr) == -1))
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if (!(lineStr.IndexOf(condition.IncludeStr) != -1 || lineStr.IndexOf(condition.ExcludeStr) == -1))
                        {
                            return true;
                        }
                    }
                }
            }
            else
            {
                if (condition.ExcludeStr != null && condition.ExcludeStr != "")
                {
                    if (lineStr.IndexOf(condition.ExcludeStr) != -1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static string[] GetFilterFiles(string path,FilterFileCons condition)
        {

            List<string> files = new List<String>();
            string[] filters = condition.Filters.Split(';');
            if (Directory.Exists(path))
            {
                foreach (string fltr in filters)
                {
                    string[] subFiles = null;
                    try
                    {
                        subFiles = Directory.GetFiles(path, fltr);
                    }
                    catch (UnauthorizedAccessException e)
                    {
                        continue;
                    }
                    files.AddRange(subFiles);
                }
            }
            return FilterFile(files.ToArray(), condition);
        }

        public static string[] FilterFile(string[] tempResult, FilterFileCons condition)
        {
            if(condition.IncludeStr!=null && condition.IncludeStr!="")                  //如果包含的字符串为空
            {
                if (condition.ExcludeStr == null || condition.ExcludeStr == "")         //如果不包含的字符串为空
                {
                    for (int i = 0; i < tempResult.Length; i++)
                    {
                        if (Path.GetFileNameWithoutExtension(tempResult[i]).IndexOf(condition.IncludeStr) == -1)
                        {
                            tempResult[i] = null;
                        }
                    }
                }
                else
                {
                    if(condition.RelationAnd)                                          //如果关系为并且
                    {
                        for (int i = 0; i < tempResult.Length; i++)
                        {
                            if (!(Path.GetFileNameWithoutExtension(tempResult[i]).IndexOf(condition.IncludeStr) != -1
                                  && Path.GetFileNameWithoutExtension(tempResult[i]).IndexOf(condition.ExcludeStr) == -1))
                            {
                                tempResult[i] = null;
                            }
                        }                        
                    }
                    else
                    {
                        for (int i = 0; i < tempResult.Length; i++)
                        {
                            if (!(Path.GetFileNameWithoutExtension(tempResult[i]).IndexOf(condition.IncludeStr) != -1
                                  || Path.GetFileNameWithoutExtension(tempResult[i]).IndexOf(condition.ExcludeStr) == -1))
                            {
                                tempResult[i] = null;
                            }
                        }                        
                    }
                }
            }
            else
            {
                if(condition.ExcludeStr!=null && condition.ExcludeStr!="")
                {
                    for(int i=0;i<tempResult.Length;i++)
                    {
                        if(Path.GetFileNameWithoutExtension(tempResult[i]).IndexOf(condition.ExcludeStr)!=-1)
                        {
                            tempResult[i] = null;
                        }
                    }
                }
            }

            return Array.FindAll(tempResult, IsNotNull);
        }


        private static bool IsNotNull(string s)
        {
            if (s!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

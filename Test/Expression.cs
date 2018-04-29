﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Audio2Minecraft
{
    public static class InheritExpression
    {
        static private Dictionary<string, Dictionary<string, string>> CompareList = new Dictionary<string, Dictionary<string, string>>();
        static private void UpdateCompareLists(string directoryPath, string upper = "")
        {
            FileInfo[] files = new DirectoryInfo(directoryPath).GetFiles();
            DirectoryInfo[] directories = new DirectoryInfo(directoryPath).GetDirectories();
            foreach (var file in files)
            {
                if (file.Extension == ".json")
                    CompareList.Add(
                        ((upper == "") ? "" : upper + "\\") + file.Name,
                        JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(file.FullName))
                        );
            }
            foreach (var directory in directories)
            {
                UpdateCompareLists(directory.FullName, directory.Name);
            }
        }
        public static void SetCompareLists(string parentPath)
        {
            try
            {
                UpdateCompareLists(parentPath);
            }
            catch
            {
            }
        }
        public static string Expression(string Expression, int Pitch, int MinecraftTickDuration)
        {
            if (Expression == "" || Expression == null) return "";
            //%pc[]
            var pc = new Regex(@"(?<=%pc\[)([^\[\]])*(?=\])").Matches(Expression);
            foreach (var p in pc)
            {
                var _p = p as Match;
                if (CompareList.Keys.Contains(_p.Value))
                {
                    var list = CompareList[_p.Value];
                    if (list.Keys.Contains(Pitch.ToString()))
                    {
                        Expression = Expression.Replace("%pc[" + _p.Value + "]", list[Pitch.ToString()]);
                    }
                }
            }
            //%pc[]
            var tc = new Regex(@"(?<=%tc\[)([^\[\]])*(?=\])").Matches(Expression);
            foreach (var t in tc)
            {
                var _t = t as Match;
                if (CompareList.Keys.Contains(_t.Value))
                {
                    var list = CompareList[_t.Value];
                    if (list.Keys.Contains(MinecraftTickDuration.ToString()))
                    {
                        Expression = Expression.Replace("%tc[" + _t.Value + "]", list[MinecraftTickDuration.ToString()]);
                    }
                }
            }
            //%p
            Expression = Expression.Replace("%p", Pitch.ToString());
            //%t
            Expression = Expression.Replace("%t", MinecraftTickDuration.ToString());
            return Expression;
        }
    }
}

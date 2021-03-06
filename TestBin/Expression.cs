﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Audio2Minecraft
{
    /// <summary>
    /// 子表达式
    /// </summary>
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
        /// <summary>
        /// 设置匹配表文件夹
        /// </summary>
        /// <param name="parentPath">文件夹路径</param>
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
        /// <summary>
        /// 根据子表达式获取实际表达式
        /// </summary>
        /// <param name="Expression">子表达式</param>
        /// <param name="Pitch">音高</param>
        /// <param name="MinecraftTickDuration">持续刻数</param>
        /// <returns></returns>
        public static string Expression(string Expression, int Pitch = 0, int MinecraftTickDuration = 0, int Velocity = 0, int BarIndext = 0, int BeatDuration = 0, int Channel = 0)
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
            //%tc[]
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
            //%vc[]
            var vc = new Regex(@"(?<=%vc\[)([^\[\]])*(?=\])").Matches(Expression);
            foreach (var v in vc)
            {
                var _v = v as Match;
                if (CompareList.Keys.Contains(_v.Value))
                {
                    var list = CompareList[_v.Value];
                    if (list.Keys.Contains(Velocity.ToString()))
                    {
                        Expression = Expression.Replace("%vc[" + _v.Value + "]", list[Velocity.ToString()]);
                    }
                }
            }
            //%p
            var pr = new Regex(@"(?<=%p\[)([^\[\]])*(?=\])").Matches(Expression);
            foreach (var p in pr)
            {
                var _p = p as Match;
                var min = getMin(_p.Value);
                var max = getMax(_p.Value);
                if (max != null && Pitch > max) Expression = Expression.Replace("%p[" + _p.Value + "]", max.ToString());
                else if (min != null && Pitch < min) Expression = Expression.Replace("%p[" + _p.Value + "]", min.ToString());
                else Expression = Expression.Replace("%t[" + _p.Value + "]", Pitch.ToString());
            }
            Expression = Expression.Replace("%p", Pitch.ToString());
            //%t
            var tr = new Regex(@"(?<=%t\[)([^\[\]])*(?=\])").Matches(Expression);
            foreach (var t in tr)
            {
                var _t = t as Match;
                var min = getMin(_t.Value);
                var max = getMax(_t.Value);
                if (max != null && MinecraftTickDuration > max) Expression = Expression.Replace("%t[" + _t.Value + "]", max.ToString());
                else if (min != null && MinecraftTickDuration < min) Expression = Expression.Replace("%t[" + _t.Value + "]", min.ToString());
                else Expression = Expression.Replace("%t[" + _t.Value + "]", MinecraftTickDuration.ToString());
            }
            Expression = Expression.Replace("%t", MinecraftTickDuration.ToString());
            //%v
            var vr = new Regex(@"(?<=%t\[)([^\[\]])*(?=\])").Matches(Expression);
            foreach (var v in vr)
            {
                var _v = v as Match;
                var min = getMin(_v.Value);
                var max = getMax(_v.Value);
                if (max != null && Velocity > max) Expression = Expression.Replace("%v[" + _v.Value + "]", max.ToString());
                else if (min != null && Velocity < min) Expression = Expression.Replace("%v[" + _v.Value + "]", min.ToString());
                else Expression = Expression.Replace("%v[" + _v.Value + "]", Velocity.ToString());
            }
            Expression = Expression.Replace("%v", Velocity.ToString());
            //%bi
            Expression = Expression.Replace("%bi", BarIndext.ToString());
            //%bd
            Expression = Expression.Replace("%bd", BeatDuration.ToString());
            //%ch
            Expression = Expression.Replace("%ch", Channel.ToString());
            return Expression;
        }

        private static int? getMin(string rngexp)
        {
            var min = Regex.Match(rngexp, @"(?<=^)\d+(?=\.\.)").Value;
            var r = 0;
            if (min != null & Int32.TryParse(min, out r))
            {
                if (r != 0)
                {
                    return r;
                }
                else return null;
            }
            else return null;
        }
        private static int? getMax(string rngexp)
        {
            var max = Regex.Match(rngexp, @"(?<=\.\.)\d+(?=$)").Value;
            var r = 0;
            if (max != null & Int32.TryParse(max, out r))
            {
                if (r != 0)
                {
                    return r;
                }
                else return null;
            }
            else return null;
        }
    }
}

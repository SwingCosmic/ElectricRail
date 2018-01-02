using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LoveKicher.ElectricRail.Core.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// 判断某个字符串是否匹配指定正则表达式
        /// </summary>
        /// <param name="input">要判断的字符串</param>
        /// <param name="pattern">要匹配的正则表达式模式</param>
        /// <param name="result">要输出的<see cref="Match"/>对象</param>
        /// <returns></returns>
        public static bool IsMatch(this string input, string pattern, out Match result)
        {
            var reg = new Regex(pattern);
            result = reg.Match(input);
            return result.Success;
        }
    }
}

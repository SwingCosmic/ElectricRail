using System;
using System.Collections.Generic;
using System.Text;

namespace LoveKicher.ElectricRail.Core
{
    /// <summary>
    /// 提供一种格式化数据以用于显示或者交换的方法
    /// </summary>
    /// <typeparam name="TSource">源数据类型</typeparam>
    /// <typeparam name="TDestination">格式化后的目标类型</typeparam>
    public interface IDataFormartter<TSource, TDestination>
    {
        TDestination FormartData(TSource source,params object[] parameters);


    }
}

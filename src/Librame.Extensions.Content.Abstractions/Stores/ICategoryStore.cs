﻿#region License

/* **************************************************************************************
 * Copyright (c) Librame Pang All rights reserved.
 * 
 * http://librame.net
 * 
 * You must not remove this notice, or any other, from this software.
 * **************************************************************************************/

#endregion

using System.Linq;

namespace Librame.Extensions.Content.Stores
{
    using Data.Stores;

    /// <summary>
    /// 分类存储接口。
    /// </summary>
    /// <typeparam name="TCategory">指定的内容分类类型。</typeparam>
    public interface ICategoryStore<TCategory> : IStore
        where TCategory : class
    {
        /// <summary>
        /// 分类查询。
        /// </summary>
        /// <value>返回 <see cref="IQueryable{TCategory}"/>。</value>
        IQueryable<TCategory> Categories { get; }
    }
}

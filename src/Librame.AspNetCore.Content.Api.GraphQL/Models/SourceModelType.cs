﻿#region License

/* **************************************************************************************
 * Copyright (c) Librame Pong All rights reserved.
 * 
 * https://github.com/librame
 * 
 * You must not remove this notice, or any other, from this software.
 * **************************************************************************************/

#endregion

namespace Librame.AspNetCore.Content.Api.Models
{
    using AspNetCore.Api.Models;

    /// <summary>
    /// 来源模型类型。
    /// </summary>
    public class SourceModelType : CreationIdentifierModelTypeBase<SourceModel>
    {
        /// <summary>
        /// 构造一个 <see cref="SourceModelType"/>。
        /// </summary>
        public SourceModelType()
            : base()
        {
            Field(f => f.Name);
            Field(f => f.Description);
            Field(f => f.Website);
            Field(f => f.Weblogo);

            Field(f => f.Parent, type: typeof(SourceModelType), nullable: true);
        }

    }
}

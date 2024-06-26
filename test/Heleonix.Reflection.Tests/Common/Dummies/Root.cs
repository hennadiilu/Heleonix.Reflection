﻿// <copyright file="Root.cs" company="Heleonix - Hennadii Lutsyshyn">
// Copyright (c) Heleonix - Hennadii Lutsyshyn. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the repository root for full license information.
// </copyright>

namespace Heleonix.Reflection.Tests.Common.Dummies
{
    /// <summary>
    /// The root type.
    /// </summary>
    public class Root
    {
#pragma warning disable CA1051 // Do not declare visible instance fields
#pragma warning disable SA1401 // Fields must be private
        /// <summary>
        /// Gets or sets the sub item field.
        /// </summary>
        public SubItem SubItemField = new SubItem();
#pragma warning restore SA1401 // Fields must be private
#pragma warning restore CA1051 // Do not declare visible instance fields

        /// <summary>
        /// Gets or sets the static sub item property.
        /// </summary>
        public static SubItem StaticSubItemProperty { get; set; } = new SubItem();

        /// <summary>
        /// Gets or sets the sub item property.
        /// </summary>
        public SubItem SubItemProperty { get; set; } = new SubItem();

        /// <summary>
        /// Gets or sets an array of primitive items.
        /// </summary>
        public string[] ItemsProperty { get; set; } = new string[] { "111", "222", "333", "444", "555" };
    }
}
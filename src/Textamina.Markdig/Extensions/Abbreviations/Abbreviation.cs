﻿// Copyright (c) Alexandre Mutel. All rights reserved.
// This file is licensed under the BSD-Clause 2 license. 
// See the license.txt file in the project root for more information.

using System.Diagnostics;
using Textamina.Markdig.Helpers;
using Textamina.Markdig.Parsers;
using Textamina.Markdig.Syntax;

namespace Textamina.Markdig.Extensions.Abbreviations
{
    /// <summary>
    /// An abbreviation object stored at the document level. See extension methods in <see cref="AbbreviationHelper"/>.
    /// </summary>
    /// <seealso cref="Textamina.Markdig.Syntax.LeafBlock" />
    [DebuggerDisplay("Abbr {Label} => {Text}")]
    public class Abbreviation : LeafBlock
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Abbreviation"/> class.
        /// </summary>
        /// <param name="parser">The parser used to create this block.</param>
        public Abbreviation(BlockParser parser) : base(parser)
        {
        }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// The text associated to this label.
        /// </summary>
        public StringSlice Text;
    }
}
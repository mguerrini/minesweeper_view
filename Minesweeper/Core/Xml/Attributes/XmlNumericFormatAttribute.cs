﻿namespace Minesweeper.Core.Xml.Attributes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class XmlNumericFormatAttribute : Attribute
    {
        public XmlNumericFormatAttribute(string format)
        {
            this.Format = format;
        }

        public string Format { get; set; }
    }
}
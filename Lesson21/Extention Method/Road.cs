﻿using System;

namespace Extention_Method
{
    public sealed class Road
    {
        public string Number { get; set; }
        public int Lenght { get; set; }
        public override string ToString()
        {
            return $"Road {Number} - lenght: {Lenght}km";
        }
    }
}

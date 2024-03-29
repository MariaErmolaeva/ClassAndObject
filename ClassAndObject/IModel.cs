﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public interface IModel
    {
        int index { set; }

        int count { get; }

        Time element { get; set; }

        List<Time> allArray { get; }

        void AddElement(Time time);
    }
}

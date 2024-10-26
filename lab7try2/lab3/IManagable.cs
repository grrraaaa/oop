﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public interface IManageable<T>
    {
        void Add(T item);
        void Remove(T item);
        T View(Func<T, bool> predicate);
    }
}

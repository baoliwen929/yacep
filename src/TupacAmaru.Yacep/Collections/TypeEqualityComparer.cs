﻿using System;
using System.Collections.Generic;

namespace TupacAmaru.Yacep.Collections
{
    internal sealed class TypeEqualityComparer : IEqualityComparer<Type>
    {
        private TypeEqualityComparer() { }

        internal static readonly TypeEqualityComparer Instance = new TypeEqualityComparer();

        public bool Equals(Type x, Type y) => x == y;

        public int GetHashCode(Type obj) => obj.GetHashCode();
    }
}
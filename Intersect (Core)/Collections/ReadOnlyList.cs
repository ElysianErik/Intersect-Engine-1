﻿using System.Collections;

namespace Intersect.Collections
{
    public partial class ReadOnlyList<T> : IReadOnlyList<T>
    {
        private IList<T> backingList;

        public T this[int index] => backingList[index];

        public int Count => backingList.Count;

        public IEnumerator<T> GetEnumerator() => backingList.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => backingList.GetEnumerator();

        public ReadOnlyList(IList<T> backingList) =>
            this.backingList = backingList;
    }

    public static partial class ListExtensions
    {
        public static IReadOnlyList<T> WrapReadOnly<T>(this IList<T> list) =>
            new ReadOnlyList<T>(list);
    }
}

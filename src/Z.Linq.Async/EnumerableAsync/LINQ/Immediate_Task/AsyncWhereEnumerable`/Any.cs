﻿// Description: Async extension methods for LINQ (Language Integrated Query).
// Website & Documentation: https://github.com/zzzprojects/LINQ-Async
// Forum: https://github.com/zzzprojects/LINQ-Async/issues
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Z.Linq.Async;

namespace Z.Linq
{
    public static partial class EnumerableAsync
    {
        public static Task<bool> Any<TSource>(this Task<AsyncWhereEnumerable<TSource>> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, Enumerable.Any, cancellationToken);
        }

        public static Task<bool> Any<TSource>(this Task<AsyncWhereEnumerable<TSource>> source, Func<TSource, bool> predicate, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, predicate, Enumerable.Any, cancellationToken);
        }
    }
}
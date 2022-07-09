﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqQL.Core.Extensions;

public static class StringExtensions
{
    public static string Join(this IEnumerable<string>? values, string separator = ", ")
    {
        if (values is null)
        {
            return string.Empty;
        }

        return string.Join(separator, values);
    }

    public static string JoinWithNewLine(this IEnumerable<string>? values, int gap = 0)
    {
        return values.Join(Environment.NewLine);
    }

    public static string FirstToUpper(this string value)
    {
        return value[..1].ToUpper() + value[1..];
    }
}
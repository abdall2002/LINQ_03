﻿using System;
using LINQ03.Shared;

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

var evenNumbersUsingExtensionWhere =
    numbers.Where(x => x % 2 == 0);

var evenNumbersUsingEnumerableWhereMethod =
    Enumerable.Where(numbers, x => x % 2 == 0);

// Select n fROM numbers where n % 2 = 0;
var evenNumbersUsingQuerySyntax =
     from n in numbers
     where n % 2 == 0
     select n;


evenNumbersUsingExtensionWhere.Print("evenNumbersUsingExtensionWhere");
evenNumbersUsingEnumerableWhereMethod.Print("evenNumbersUsingEnumerableWhereMethod");
evenNumbersUsingQuerySyntax.Print("evenNumbersUsingQuerySyntax");
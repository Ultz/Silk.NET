// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#include <stdio.h>
#include "library.h"
#include "SumC_Export.h"

SumC_EXPORT int sum(int length, int* values) {
    printf("Hello from Native! Calculating sum of %d numbers\n", length);
    int sum = 0;
    for (int i = 0; i < length; i++)
        sum += *(values + i);
    return sum;
}

﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System;
using Microsoft.AppMagic.Transport;

namespace Microsoft.PowerFx.Core.Types
{
    [Flags]
    [TransportType(TransportKind.Enum)]
#pragma warning disable CA1028
    public enum FunctionCategories : uint
#pragma warning restore CA1028
    {
        None = 0x0,
        Text = 0x1,
        Logical = 0x2,
        Table = 0x4,
        Behavior = 0x8,
        DateTime = 0x10,
        MathAndStat = 0x20,
        Information = 0x40,
        Color = 0x80,
        REST = 0x100,
        Component = 0x200,
        PiFlow = 0x400
    }
}

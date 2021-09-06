﻿#pragma warning disable 1591

namespace NServiceBus.Testing
{
    [ObsoleteEx(
        Message = "Forwarding functionality has been removed from NServiceBus.",
        RemoveInVersion = "9",
        TreatAsErrorFromVersion = "8")]
    public class TestableForwardingContext
    {
    }
}

namespace NServiceBus.Testing
{
    [ObsoleteEx(
        Message = "Use the arrange act assert (AAA) syntax instead. Please see the upgrade guide for more details.",
        RemoveInVersion = "9",
        TreatAsErrorFromVersion = "8")]
    public class Saga<T>
    {
    }
}

namespace NServiceBus.Testing
{
    [ObsoleteEx(
        Message = "Use the arrange act assert (AAA) syntax instead. Please see the upgrade guide for more details.",
        RemoveInVersion = "9",
        TreatAsErrorFromVersion = "8")]
    public class Test
    {
    }
}

namespace NServiceBus.Testing
{
    using System;

    [ObsoleteEx(
        Message = "Use the arrange act assert (AAA) syntax instead. Please see the upgrade guide for more details.",
        RemoveInVersion = "9",
        TreatAsErrorFromVersion = "8")]
    public class ExpectationException : Exception
    {
    }
}

namespace NServiceBus.Testing
{
    [ObsoleteEx(
        Message = "Use the arrange act assert (AAA) syntax instead. Please see the upgrade guide for more details.",
        RemoveInVersion = "9",
        TreatAsErrorFromVersion = "8")]
    public class Handler<T>
    {
    }
}

#pragma warning restore 1591
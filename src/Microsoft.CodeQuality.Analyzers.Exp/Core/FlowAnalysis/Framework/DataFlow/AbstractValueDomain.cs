﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Microsoft.CodeAnalysis.Operations.DataFlow
{
    /// <summary>
    /// Abstract value domain for a <see cref="DataFlowAnalysis"/> to merge and compare values.
    /// </summary>
    internal abstract class AbstractValueDomain<T> : AbstractDomain<T>
    {
        /// <summary>
        /// Returns the major Unknown or MayBe top value of the domain.
        /// </summary>
        public abstract T UnknownOrMayBeValue { get; }
    }
}

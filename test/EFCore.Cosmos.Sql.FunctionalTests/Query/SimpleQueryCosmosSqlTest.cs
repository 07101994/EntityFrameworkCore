﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq;
using Microsoft.EntityFrameworkCore.TestModels.Northwind;
using Microsoft.EntityFrameworkCore.TestUtilities;
using Microsoft.EntityFrameworkCore.TestUtilities.Xunit;
using Xunit;

namespace Microsoft.EntityFrameworkCore.Query
{
    public class SimpleQueryCosmosSqlTest : QueryTestBase<NorthwindQueryCosmosSqlFixture<NoopModelCustomizer>>
    {
        public SimpleQueryCosmosSqlTest(NorthwindQueryCosmosSqlFixture<NoopModelCustomizer> fixture)
            : base(fixture)
        {
        }

        protected NorthwindContext CreateContext()
        {
            return Fixture.CreateContext();
        }

        protected virtual void ClearLog()
        {
        }

        [ConditionalFact]
        public virtual void Where_simple()
        {
            AssertQuery<Customer>(cs => cs.Where(c => c.CustomerID == "ALFKI"));
        }
    }
}

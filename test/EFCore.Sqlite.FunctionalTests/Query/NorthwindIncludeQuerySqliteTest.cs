// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Xunit.Abstractions;

namespace Microsoft.EntityFrameworkCore.Query
{
    public class NorthwindIncludeQuerySqliteTest : NorthwindIncludeQueryTestBase<IncludeSqliteFixture>
    {
        public NorthwindIncludeQuerySqliteTest(IncludeSqliteFixture fixture, ITestOutputHelper testOutputHelper)
            : base(fixture)
        {
            //TestSqlLoggerFactory.CaptureOutput(testOutputHelper);
        }

        // Sqlite does not support Apply operations
        public override Task Include_collection_with_cross_apply_with_filter(bool async) => Task.CompletedTask;

        public override Task Include_collection_with_outer_apply_with_filter(bool async) => Task.CompletedTask;
    }
}

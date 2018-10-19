// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;

namespace Microsoft.EntityFrameworkCore.Migrations.Operations
{
    public class OracleCreateUserOperation : MigrationOperation
    {
        public virtual string UserName { get; [param: NotNull] set; }
    }
}

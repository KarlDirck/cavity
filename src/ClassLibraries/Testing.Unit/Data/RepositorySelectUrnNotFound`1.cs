﻿namespace Cavity.Data
{
    using System;
    using Cavity.Properties;
    using Cavity.Tests;

    public sealed class RepositorySelectUrnNotFound<T> : VerifyRepositoryBase<T>
        where T : new()
    {
        protected override void OnVerify(IRepository<T> repository)
        {
            if (null == repository)
            {
                throw new ArgumentNullException("repository");
            }

            var record = repository.Select("urn://example.com/" + Guid.NewGuid());

            if (null != record)
            {
                throw new UnitTestException(Resources.Repository_ExpectNullWhenRecordNotFound_UnitTestExceptionMessage.FormatWith("Select", "URN"));
            }
        }
    }
}
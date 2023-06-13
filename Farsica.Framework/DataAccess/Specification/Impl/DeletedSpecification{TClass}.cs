﻿namespace Farsica.Framework.DataAccess.Specification.Impl
{
    using System;
    using System.Linq.Expressions;
    using Farsica.Framework.DataAccess.Entities;

    public sealed class DeletedSpecification<TClass> : SpecificationBase<TClass>
        where TClass : class, IDeleteable<TClass>
    {
        private readonly bool deleted;

        public DeletedSpecification(bool deleted)
        {
            this.deleted = deleted;
        }

        public override Expression<Func<TClass, bool>> Expression() => t => t.Deleted == deleted;
    }
}

﻿using Microsoft.EntityFrameworkCore;

using System;
using System.Linq;
using System.Linq.Expressions;

namespace SL.Services.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder SetPropertyDefaultSqlValue(this ModelBuilder builder, string propertyName, string value)
        {
            foreach (var entityType in builder.Model.GetEntityTypes().Where(e => e.FindProperty(propertyName) != null))
            {
                builder.Entity(entityType.ClrType).Property(propertyName)/*.HasDefaultValueSql(value)*/;
            }
            return builder;
        }

        public static ModelBuilder SetPropertyDefaultValue<TProperty>(this ModelBuilder builder, string propertyName, object value)
        {
            foreach (var entityType in builder.Model.GetEntityTypes().Where(
                                                    e => e.FindProperty(propertyName) != null
                                                    && e.FindProperty(propertyName).ClrType == typeof(TProperty)))
            {
                builder.Entity(entityType.ClrType).Property(propertyName).HasDefaultValue(value);
            }
            return builder;
        }

        public static ModelBuilder SetPropertyQueryFilter<TProperty>(this ModelBuilder builder, string propertyName, TProperty value)
        {
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                var property = entityType.FindProperty(propertyName);
                if (property != null && property.ClrType == typeof(TProperty) && entityType.BaseType == null)
                {
                    var parameter = Expression.Parameter(entityType.ClrType, entityType.ClrType.Name);
                    var body = Expression.Property(parameter, property.PropertyInfo);
                    var constant = Expression.Constant(value, typeof(TProperty));
                    var filter = Expression.Lambda(Expression.Equal(body, constant), parameter);
                    entityType.SetQueryFilter(filter);
                }
            }
            return builder;
        }

        public static ModelBuilder SetQueryFilter<TEntity>(this ModelBuilder builder, Expression<Func<TEntity, bool>> filter) where TEntity : class
        {
            builder.Model.FindEntityType(typeof(TEntity))?.SetQueryFilter(filter);
            return builder;
        }

        public static ModelBuilder RemoveQueryFilter<TEntity>(this ModelBuilder builder)
        {
            builder.Model.FindEntityType(typeof(TEntity))?.SetQueryFilter(null);
            return builder;
        }

        public static ModelBuilder RemoveQueryFilter(this ModelBuilder builder, params Type[] types)
        {
            foreach (var type in types)
            {
                builder.Model.FindEntityType(type)?.SetQueryFilter(null);
            }
            return builder;
        }
    }
}

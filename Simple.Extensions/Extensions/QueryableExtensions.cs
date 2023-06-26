﻿using Simple.Extensions.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Simple.Extensions
{
    public static class QueryableExtensions
    {
        /// <summary>
        /// Retrieve number of records with pagination data
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="pageNumber">The number of page</param>
        /// <param name="pageSize">The amount of records per page, by default is set to 10</param>
        /// <param name="cancellationToken"></param>
        /// <returns>PaginatedResult with IEnumerable of records and pagination meta data</returns>
        public static async Task<PaginatedResult<T>> ToPaginatedListAsync<T>(this IQueryable<T> source,
            int pageNumber,
            int pageSize = 10,
            CancellationToken cancellationToken = default)
        {
            long count = 0;
            IEnumerable<T> items = Enumerable.Empty<T>();

            pageNumber = pageNumber <= 0 ? 1 : pageNumber;
            pageSize = pageSize <= 0 ? 10 : pageSize;

            await Task.Run(() =>
            {
                count = source.LongCount();
                items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            }, cancellationToken);

            return new PaginatedResult<T>(items, count, pageNumber, pageSize);
        }

        /// <summary>
        /// Apply Where expression with if condtion
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="expression"></param>
        /// <param name="condition"></param>
        /// <returns>Return IQueryable with Where expression If condtion is true else return the same IQuerable without Where</returns>
        public static IQueryable<T> WhereIf<T>(this IQueryable<T> source,
            Expression<Func<T, bool>> expression,
            Func<bool> condition)
        => condition() ? source.Where(expression) : source;
    }
}
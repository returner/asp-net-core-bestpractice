using Ardalis.GuardClauses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCommon.GuardExtensions
{
    public static class NotNullExtension
    {
        /// <summary>
        /// 파라미터가 null이 아니면 예외를 발생시킴
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="guardClause"></param>
        /// <param name="obj"></param>
        /// <exception cref="NotSupportedException"></exception>
        public static void NotNull<T>(this IGuardClause guardClause, T? obj)
        {
            if (obj != null)
                throw new NotSupportedException(nameof(obj));
        }
    }
}

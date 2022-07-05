using Ardalis.GuardClauses;

namespace AppCommon.GuardExtensions
{
    public static class LengthExtension
    {
        /// <summary>
        /// 배열의 갯수가 0~maxLength 사이에 있는지 검사
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="guardClause"></param>
        /// <param name="enumerable">IEnumerable</param>
        /// <param name="maxLength">최대 크기</param>
        /// <param name="parameterName"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static void Length<T>(this IGuardClause guardClause, IEnumerable<T>? enumerable, int maxLength, string? parameterName = null)
        {
            if (enumerable != null && enumerable.Count() > maxLength)
                throw new ArgumentException(parameterName);
        }
    }
}

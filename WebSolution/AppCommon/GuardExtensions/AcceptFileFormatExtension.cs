using Ardalis.GuardClauses;

namespace AppCommon.GuardExtensions
{
    public static class AcceptFileFormatExtension
    {
        public static void IsImage(this IGuardClause guardClause, string fileExtension)
        {
            if (string.IsNullOrWhiteSpace(fileExtension))
                throw new ArgumentNullException(nameof(fileExtension));

            var extension = fileExtension.Replace(".", string.Empty).Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(fileExtension))
                throw new ArgumentNullException(nameof(fileExtension));

            var imageFormats = new[] { "JPG", "JPEG", "GIF", "PNG", "BMP" };
            if (!imageFormats.Any(d => extension.Contains(d)))
                throw new NotSupportedException(extension);
        }
    }
}

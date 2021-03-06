﻿namespace Nancy.ViewEngines.Razor
{
    /// <summary>
    /// An html string that is not encoded.
    /// </summary>
    public class NonEncodedHtmlString : IHtmlString
    {
        private readonly string value;

        /// <summary>
        /// Initializes a new instance of the <see cref="NonEncodedHtmlString"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public NonEncodedHtmlString(string value)
        {
            this.value = value;
        }

        /// <summary>
        /// Returns an HTML-encoded string.
        /// </summary>
        /// <returns>An HTML-encoded string.</returns>
        public string ToHtmlString()
        {
            return value;
        }
    }
}
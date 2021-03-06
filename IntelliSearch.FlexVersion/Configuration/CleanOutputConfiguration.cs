﻿namespace IntelliSearch.FlexVersion.Configuration
{
    /// <summary>
    /// Defines how cleaning of the output should be performed.
    /// </summary>
    public class CleanOutputConfiguration
    {
        /// <summary>
        ///  Defines a regex-pattern to match invalid characters.
        /// </summary>
        public string InvalidPattern { get; set; }

        public string OutputMatch { get; set; }

        /// <summary>
        /// Defines what to be used as a replacement for the invalid matches.
        /// </summary>
        public string Replacement { get; set; }

        internal bool IsConfigured => 
            !string.IsNullOrWhiteSpace(InvalidPattern) 
            && !string.IsNullOrWhiteSpace(Replacement) 
            && !string.IsNullOrWhiteSpace(OutputMatch);
    }
}
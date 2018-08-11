﻿using System.Collections.Generic;

namespace IntelliSearch.GitSemVer.Configuration
{
    /// <summary>
    /// Contains the configuration on how results are to be generated.
    /// </summary>
    public class ResultsConfiguration
    {
        /// <summary>
        /// Used to clean the result output strings.
        /// </summary>
        public CleanOutputConfiguration CleanOutput { get; set; }

        /// <summary>
        /// A list of outputs to generate.
        /// </summary>
        public Dictionary<string, string> Output { get; set; }
    }
}
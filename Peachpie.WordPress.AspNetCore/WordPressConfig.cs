﻿using Pchp.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peachpie.WordPress.AspNetCore
{
    /// <summary>
    /// WordPress configuration.
    /// The configuration is loaded into WordPress before every request.
    /// </summary>
    public class WordPressConfig
    {
        /// <summary>MySQL database name.</summary>
        public string DbName { get; set; } = "wordpress";

        /// <summary>MySQL database user name.</summary>
        public string DbUser { get; set; } = "root";

        /// <summary>MySQL database password.</summary>
        public string DbPassword { get; set; }

        /// <summary>MySQL host.</summary>
        public string DbHost { get; set; } = "localhost";

        /// <summary>
        /// Set of WordPress plugins to be loaded.
        /// </summary>
        public IEnumerable<IWpPlugin> Plugins { get; set; }
    }
}
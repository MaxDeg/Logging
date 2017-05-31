﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Extensions.Logging.AzureAppServices.Internal
{
    /// <summary>
    /// Represents the configuration of the logger from Azure WebApp.
    /// </summary>
    public class WebAppLogConfiguration
    {
        /// <summary>
        /// The configuration that has all loggers disabled.
        /// </summary>
        public static WebAppLogConfiguration Disabled { get; } = new WebAppLogConfigurationBuilder().Build();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebAppLogConfiguration"/> class.
        /// </summary>
        public WebAppLogConfiguration(
            bool isRunningInWebApp,
            bool fileLoggingEnabled,
            LogLevel fileLoggingLevel,
            string fileLoggingFolder,
            bool blobLoggingEnabled,
            LogLevel blobLoggingLevel,
            string blobContainerUrl)
        {
            IsRunningInWebApp = isRunningInWebApp;

            FileLoggingEnabled = fileLoggingEnabled;
            FileLoggingLevel = fileLoggingLevel;
            FileLoggingFolder = fileLoggingFolder;

            BlobLoggingEnabled = blobLoggingEnabled;
            BlobLoggingLevel = blobLoggingLevel;
            BlobContainerUrl = blobContainerUrl;
        }

        /// <summary>
        /// Gets a value indicating whether we're running in WebApp or not.
        /// </summary>
        public bool IsRunningInWebApp { get; }

        /// <summary>
        /// Gets a value indicating whether the file logger is enabled or not.
        /// </summary>
        public bool FileLoggingEnabled { get; }
        /// <summary>
        /// Gets a value indicating the file logger logging level.
        /// </summary>
        public LogLevel FileLoggingLevel { get; }
        /// <summary>
        /// Gets a value indicating the folder where the file logger stores the logs.
        /// </summary>
        public string FileLoggingFolder { get; }

        /// <summary>
        /// Gets a value indicating whether the blob logger is enabled or not.
        /// </summary>
        public bool BlobLoggingEnabled { get; }
        /// <summary>
        /// Gets a value indicating the blob logger logging level.
        /// </summary>
        public LogLevel BlobLoggingLevel { get; }
        /// <summary>
        /// Gets the SAS endpoint where blob logs are stored.
        /// </summary>
        public string BlobContainerUrl { get; }
    }
}

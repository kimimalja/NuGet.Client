﻿using NuGet.Resolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGet.ProjectManagement
{
    /// <summary>
    /// Comprises of the various client context such as logging, fileconflictaction
    /// </summary>
    public interface IExecutionContext
    {
        /// <summary>
        /// Logs a message for the given execution context
        /// </summary>
        void Log(MessageLevel level, string message, params object[] args);
        /// <summary>
        /// Resolves a file conflict for the given execution context
        /// </summary>
        FileConflictAction ResolveFileConflict(string message);
    }

    /// <summary>
    /// MessageLevel
    /// </summary>
    public enum MessageLevel
    {
        /// <summary>
        /// Information
        /// </summary>
        Info,
        /// <summary>
        /// Warning
        /// </summary>
        Warning,
        /// <summary>
        /// Debug only
        /// </summary>
        Debug,
        /// <summary>
        /// Error
        /// </summary>
        Error
    }
}

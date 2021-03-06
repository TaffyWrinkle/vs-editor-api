﻿////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Microsoft Corporation.  All rights reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.VisualStudio.Language.Intellisense
{
    /// <summary>
    /// Provides custom commit operations for completions.
    /// </summary>
    public interface ICustomCommit
    {
        /// <summary>
        /// Commits the completion using the completion's own commit logic.
        /// </summary>
        void Commit();
    }
}

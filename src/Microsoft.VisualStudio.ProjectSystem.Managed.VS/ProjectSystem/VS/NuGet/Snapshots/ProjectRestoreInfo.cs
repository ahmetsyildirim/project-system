﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using NuGet.SolutionRestoreManager;

namespace Microsoft.VisualStudio.ProjectSystem.VS.NuGet
{
    internal class ProjectRestoreInfo : IVsProjectRestoreInfo
    {
        public ProjectRestoreInfo(string baseIntermediatePath, string originalTargetFrameworks, IVsTargetFrameworks targetFrameworks, IVsReferenceItems toolReferences)
        {
            Requires.NotNullOrEmpty(baseIntermediatePath, nameof(baseIntermediatePath));
            Requires.NotNull(originalTargetFrameworks, nameof(originalTargetFrameworks));
            Requires.NotNull(targetFrameworks, nameof(targetFrameworks));
            Requires.NotNull(toolReferences, nameof(toolReferences));

            BaseIntermediatePath = baseIntermediatePath;
            OriginalTargetFrameworks = originalTargetFrameworks;
            TargetFrameworks = targetFrameworks;
            ToolReferences = toolReferences;
        }

        public string BaseIntermediatePath { get; }

        public string OriginalTargetFrameworks { get; }

        public IVsTargetFrameworks TargetFrameworks { get; }

        public IVsReferenceItems ToolReferences { get; }
    }
}

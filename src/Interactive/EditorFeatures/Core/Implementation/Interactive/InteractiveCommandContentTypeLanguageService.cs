// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Composition;
using Microsoft.CodeAnalysis.Host;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.CodeAnalysis.Interactive;
using Microsoft.VisualStudio.Utilities;
using Roslyn.Editor.InteractiveWindow;
using Roslyn.Editor.InteractiveWindow.Commands;

namespace Microsoft.CodeAnalysis.Editor.Implementation.Interactive
{
    [ExportLanguageService(typeof(IContentTypeLanguageService), InteractiveLanguageNames.InteractiveCommand), Shared]
    internal class InteractiveCommandContentTypeLanguageService : IContentTypeLanguageService
    {
        private readonly IContentTypeRegistryService _contentTypeRegistry;

        [ImportingConstructor]
        public InteractiveCommandContentTypeLanguageService(IContentTypeRegistryService contentTypeRegistry)
        {
            _contentTypeRegistry = contentTypeRegistry;
        }

        public IContentType GetDefaultContentType()
        {
            return _contentTypeRegistry.GetContentType(PredefinedInteractiveCommandsContentTypes.InteractiveCommandContentTypeName);
        }
    }
}

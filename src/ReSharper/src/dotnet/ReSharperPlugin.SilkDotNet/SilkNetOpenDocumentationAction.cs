// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Linq;
using JetBrains.Application.DataContext;
using JetBrains.Application.StdApplicationUI;
using JetBrains.Application.UI.Actions;
using JetBrains.Application.UI.ActionsRevised.Menu;
using JetBrains.Application.UI.ActionSystem.ActionsRevised.Menu;
using JetBrains.Diagnostics;
using JetBrains.Metadata.Reader.Impl;
using JetBrains.ProjectModel.DataContext;
using JetBrains.ReSharper.Feature.Services.Util;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Files;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.TextControl.DataContext;

namespace ReSharperPlugin.SilkDotNet
{
    [Action("SilkNetOpenDocumentationAction", "Open Documentation")]
    public class SilkNetOpenDocumentationAction : IActionWithExecuteRequirement, IExecutableAction
    {
        public IActionRequirement GetRequirement(IDataContext dataContext)
        {
            return CommitAllDocumentsRequirement.TryGetInstance(dataContext);
        }

        public bool Update(IDataContext context, ActionPresentation presentation, DelegateUpdate nextUpdate)
        {
            return true;
        }

        public void Execute(IDataContext context, DelegateExecute nextExecute)
        {
            var solution = context.GetData(ProjectModelDataConstants.SOLUTION).NotNull();
            var textControl = context.GetData(TextControlDataConstants.TEXT_CONTROL).NotNull();
            var services = solution.GetPsiServices();

            var references = TextControlToPsi.GetReferencesAtCaret(solution, textControl);
            if (references?.Length != 1 ||
                references.Single().Resolve().DeclaredElement is not IMethod method)
                return;

            var attributeTypeName = new ClrTypeName("Silk.NET.Core.Native.NativeApiAttribute");
            var attribute = method.GetAttributeInstances(attributeTypeName, inherit: true).SingleOrDefault();
            if (attribute == null)
                return;

            var (_, attributeValue) = attribute.NamedParameters().SingleOrDefault(x => x.First == "EntryPoint");
            var name = attributeValue?.ConstantValue.Value?.ToString();
            if (name == null)
                return;

            var openGlDocs = Data.DocumentationUrls["Silk.NET.OpenGL"];
            if (openGlDocs.TryGetValue(name, out var url))
            {
                var opensUri = services.GetComponent<OpensUri>();
                opensUri.OpenUri(new Uri(url));
            }

            // var buildClasses = services.Finder.FindNukeClasses(solution).ToList();
            // var items = buildClasses.SelectMany(x => x.GetMembers())
            //     .OfType<IProperty>()
            //     .Where(x => x.GetNukeTarget() != null)
            //     .OrderBy(x => x.ShortName)
            //     .SelectMany(x => NukeTargetMarkOnGutter.CreateRunTargetMenu(
            //         x.GetDeclarations().First().GetProject(),
            //         x.ShortName,
            //         gutterMarkAnchor: null,
            //         solution,
            //         textControl)).ToList();
            //
            // var popupWindowContextSource = context.GetData(UIDataConstants.PopupWindowContextSource);
            // var bulbMenuComponent = solution.GetComponent<BulbMenuComponent>();
            // bulbMenuComponent.ShowBulbMenu(items, popupWindowContextSource);
        }
    }
}

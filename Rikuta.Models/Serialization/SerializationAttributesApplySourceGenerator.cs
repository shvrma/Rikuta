using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Rikuta.Models.Serialization;

[Generator(LanguageNames.CSharp)]
internal class SerializationAttributesApplySourceGenerator : ISourceGenerator
{
    public void Execute(GeneratorExecutionContext context)
    {
        DiagnosticDescriptor diagnosticDescriptor = new(
            id: "1",
            title: "msg",
            messageFormat: "No message there.",
            category: "Info",
            defaultSeverity: DiagnosticSeverity.Error,
            isEnabledByDefault: true);

        Diagnostic diagnosticMsg = Diagnostic.Create(
            descriptor: diagnosticDescriptor,
            location: Location.None);

        context.ReportDiagnostic(diagnosticMsg);
    }

    public void Initialize(GeneratorInitializationContext context)
    {
        context.RegisterForSyntaxNotifications(() => new SyntaxReceiver());
    }

    private class SyntaxReceiver : ISyntaxReceiver
    {
        public List<MemberDeclarationSyntax> MembersWithAttributes { get; } = new();

        public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
        {
            if (syntaxNode is MemberDeclarationSyntax member && member.AttributeLists.Count > 0)
            {
                MembersWithAttributes.Add(member);
            }
        }
    }
}
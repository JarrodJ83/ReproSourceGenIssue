using Microsoft.CodeAnalysis;
using System.Diagnostics;

namespace ReproSourceGenIssue
{
    [Generator]
    public class OpenApiSourceGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            Debugger.Launch();

            // Uncommenting the next line will cause this method to never be invoked (Debugger.Launch() will not be called)
            //var openApiReader = new Microsoft.OpenApi.Readers.OpenApiStringReader();
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            //Debugger.Launch();
        }
    }
}
namespace NexusMods.App.Generators.Diagnostics;

public static class Constants
{
    public const string Namespace = "NexusMods.Generators.Diagnostics";
    public const string DiagnosticsNamespace = "global::NexusMods.Abstractions.Diagnostics";

    public const string AutoGeneratedHeader = /*lang=csharp*/"// <auto-generated/>";
    public const string NullableEnable = /*lang=csharp*/"#nullable enable";
    public const string InheritDocumentation = /*lang=csharp*/"/// <inheritdoc/>";

    public const string CodeCoverageAttribute = /*lang=csharp*/
        """
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage(Justification = "Auto-generated")]
""";

    public const string InlineAttribute = /*lang=csharp*/"[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]";
}
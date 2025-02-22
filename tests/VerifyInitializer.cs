using System.Runtime.CompilerServices;

public static class VerifyInitializer
{
    [ModuleInitializer]
    public static void Initialize()
    {
        Verifier.DerivePathInfo(
            (sourceFile, projectDirectory, type, method) => new(
                directory: Path.Combine(projectDirectory, "Snapshots"),
                typeName: type.Name,
                methodName: method.Name));
    }
}
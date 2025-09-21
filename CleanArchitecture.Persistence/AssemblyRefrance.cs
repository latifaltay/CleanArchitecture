using System.Reflection;

namespace CleanArchitecture.Persistence;

public static class AssemblyRefrance
{
    public static readonly Assembly assembly = typeof(Assembly).Assembly; 
}

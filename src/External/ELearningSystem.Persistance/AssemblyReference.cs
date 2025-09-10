using System.Reflection;

namespace ELearningSystem.Persistance;

public class AssemblyReference
{
    public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
}

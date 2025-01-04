using System.IO; // For Path.Combine
using Sharpmake; // Contains the entire Sharpmake object library.

[Generate]
public class NlohmannJsonProject : Project
{
    public NlohmannJsonProject()
    {
        Name = "nlohmann-json";
        SourceRootPath = "";
        AddTargets(TargetUtil.DefaultTarget);
    }
    
    [Configure]
    public void ConfigureAll(Project.Configuration conf, Target target)
    {
        conf.Output = Project.Configuration.OutputType.None;
        conf.SolutionFolder = Constants.EXTERNAL_VS_CATEGORY;
        conf.IncludePaths.Add(@"[project.SharpmakeCsPath]\single_include");
    }
}
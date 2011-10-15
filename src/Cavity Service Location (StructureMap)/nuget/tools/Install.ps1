param($installPath, $toolsPath, $package, $project)

$project.ProjectItems.Item("StructureMap.config").Properties.Item("CopyToOutputDirectory").Value = 1

try
{
    $item = $project.ProjectItems.Item("Program.cs")
}
catch [System.Management.Automation.MethodInvocationException]
{
}

if (!$item)
{
    $item = $project.ProjectItems.Item("global.asax").ProjectItems.Item("global.asax.cs")
}

$terminator = ""
if ($item.FileCodeModel.Language -eq "{B5E9BD34-6D3E-4B5D-925E-8A43B79820B4}")
{
    $terminator = ";"
}

$win = $item.Open("{7651A701-06E5-11D1-8EBD-00A0C90F26EA}")
$text = $win.Document.Object("TextDocument");
$namespace = $item.FileCodeModel.CodeElements | where-object {$_.Kind -eq 5}

$edit = $namespace.StartPoint.CreateEditPoint();
$edit.LineDown()
$edit.CharRight(1)
$edit.Insert([Environment]::NewLine)
$edit.Insert("    using Cavity.Configuration")
$edit.Insert($terminator)
$edit.Insert([Environment]::NewLine)
$edit.Insert("    // using Microsoft.Practices.ServiceLocation")
$edit.Insert($terminator)
$edit.Insert([Environment]::NewLine)

$class = $namespace.Children | where-object {$_.Kind -eq 1}

$methods = $class.Children | where-object {$_.Name -eq "Main"}
if (!$methods)
{
    $methods = $class.Children | where-object {$_.Name -eq "Application_Start"}
    if (!$methods)
    {
        [system.windows.forms.messagebox]::show("methods is null")
    }
}

$edit = $methods.StartPoint.CreateEditPoint();
$edit.LineDown()
$edit.CharRight(1)
$edit.Insert([Environment]::NewLine)
$edit.Insert("            Config.ExeSection<ServiceLocation>().Provider.Configure()")
$edit.Insert($terminator)
$edit.Insert([Environment]::NewLine)
$edit.Insert("            // var obj = ServiceLocator.Current.GetInstance<InterfaceName>()")
$edit.Insert($terminator)
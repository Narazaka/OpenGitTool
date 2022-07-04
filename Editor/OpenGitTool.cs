using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Diagnostics;
using System.IO;

public class OpenGitTool {
    const string GitExtensionsExe = @"C:\Program Files (x86)\GitExtensions\GitExtensions.exe";

    [MenuItem("Open Git Tool/Git Extensions")]
    static void GitExtensions() {
        Process.Start(GitExtensionsExe, $"openrepo \"{Directory.GetCurrentDirectory().Replace("\"", "\\\"")}\"");
    }

    [MenuItem("Open Git Tool/Powershell")]
    static void Powershell() {
        Process.Start("powershell");
    }
}

using System.Diagnostics;

namespace DeployCommand
{
    [Command(PackageIds.MyCommand)]
    internal sealed class MyCommand : BaseCommand<MyCommand>
    {
        protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
        {

            Process.Start("cmd", "/k PowerShell.exe -command \"C:\\Users\\rohansharma\\source\\repos\\sample.ps1\"");
            await VS.MessageBox.ShowWarningAsync("DeployCommand", "Button clicked");
        }
    }
}

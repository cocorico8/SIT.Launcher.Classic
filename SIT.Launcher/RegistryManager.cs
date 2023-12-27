using Microsoft.Win32;

namespace SIT.Launcher
{
    public static class RegistryManager
    {
        public static string ArenaGamePathEXE
        {
            get
            {

                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\EscapeFromTarkovArena_live"))
                {
                    if (key != null)
                    {
                        string exePath = key.GetValue("DisplayIcon").ToString();
                        return exePath;
                    }
                }

                return string.Empty;
            }
        }

        public static string EFTGamePathEXE
        {
            get
            {

                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\EscapeFromTarkov"))
                {
                    if (key != null)
                    {
                        string exePath = key.GetValue("DisplayIcon").ToString();
                        return exePath;
                    }
                }

                return string.Empty;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIT.Launcher
{
    public static class ArenaGameFinder
    {
        public static FileInfo FindOfficialGame()
        {
            try
            {
                var fi = new FileInfo(RegistryManager.ArenaGamePathEXE);
                return fi;
            }
            catch 
            {
                return null;
            }
        }
    }
}

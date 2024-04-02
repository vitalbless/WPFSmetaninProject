using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSmetaninProject.Data
{
    class SupplyMethods
    {
        public async static void SetMesssageToStatusBar(string message)
        {
            SuppObj.statusBarText.Text = message;
            await Task.Delay(3000);
            SuppObj.statusBarText.Text = string.Empty;
        }

    }
}

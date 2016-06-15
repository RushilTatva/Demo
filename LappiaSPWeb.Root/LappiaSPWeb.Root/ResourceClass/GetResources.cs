using Microsoft.SharePoint.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LappiaSPWeb.Common;

namespace LappiaSPWeb.Root.ResourceClass
{
    public class GetResources
    {
        public string LoadResource(string _resName)
        {
            return SPUtility.GetLocalizedString("$Resources:" + _resName, Common.Comman.ResourceFilename, (uint)System.Globalization.CultureInfo.CurrentUICulture.LCID);
        }
    }
}

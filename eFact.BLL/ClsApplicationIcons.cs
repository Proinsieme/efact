using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace eFact
{
    public class ClsApplicationIcons
    {
                    private ImageSource _applIcon;
            private string _applName;

            public ClsApplicationIcons(ImageSource applIcon, string applName)
            {
                _applIcon = applIcon;
                _applName = applName;
            }

            public override string ToString()
            {
                return _applName;
            }

            public ImageSource ApplIcon
            {
                get { return _applIcon; }
            }

            public string ApplName
            {
                get { return _applName; }
            }

            public string GetApplName(string applName)
            {
                return applName;
            }
    }
}

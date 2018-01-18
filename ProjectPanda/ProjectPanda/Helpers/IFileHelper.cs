using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Helpers
{

    //platform-specific functionality

    public  interface IFileHelper
    {

        string GetLocalFilePath(string filename);


    }
}

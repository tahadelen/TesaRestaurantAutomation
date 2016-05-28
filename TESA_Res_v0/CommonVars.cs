using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TESA_Res_v0
{

    public class CommonVars
    {
        private static CommonVars instance;
        private CommonVars() { }
        public static CommonVars Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new CommonVars();
                }
                return instance;
            }
        }

       
    }
    
   
}

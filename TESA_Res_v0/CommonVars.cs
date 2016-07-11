using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TESA_Res_v0
{

    public class CommonVars
    {
        private string username;
        public string Username
        {
            get
            {
                return this.username;
            }
            set
            {
                this.username = value;
            }
        }

        private int userid;
        public int Userid
        {
            get
            {
                return this.userid;
            }
            set
            {
                this.userid = value;
            }
        }

        private int tableid;

        public int Tableid
        {
            get
            {
                return this.tableid;
            }
            set
            {
                this.tableid = value;
            }
        }
         
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

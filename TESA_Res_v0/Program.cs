using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TESA_Res_v0
{   
    static class Program
    {
        public static Form Form_Login;
        public static Form Form_Main;
        public static Form Form_Customers;
        public static Form Form_Tables;
        public static Form Form_Orders;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form_Login = new Form1();
            Form_Main = new Form2();
            Form_Tables = new Form3();
            Form_Customers = new Form_Customers();
            Form_Orders = new Form4();

            Program.Form_Main.Hide();
            Program.Form_Tables.Hide();
            Program.Form_Customers.Hide();
            Program.Form_Orders.Hide();

            Application.Run(Form_Login);
        }
    }
}

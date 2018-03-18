using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Baitap1_Server.Helper
{
    public class readFileText
    {
        public static string docFile(string pad)
        {
            string data = "";
            try
            {
                StreamReader stw = new StreamReader(pad);

                while (!stw.EndOfStream)
                {
                    data = stw.ReadToEnd();
                }
                stw.Close();
            }
            catch
            {
            }
            return data;
        }
    }
}
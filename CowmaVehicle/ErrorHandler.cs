using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace CowmaVehicle
{
    class ErrorHandler
    {
        StreamWriter _sw;
        Exception _smException;
        string _controllername;
        string _actionname;

        #region "Properties"
        /// <summary>
        /// Set the Property for displaying Error Message
        /// </summary>
        public Exception ErrorMsg
        {
            get
            {
                return _smException;
            }
            set
            {
                _smException = value;
            }
        }

        #endregion



        #region "Functions"

        /// <summary>
        /// This is used to return the Exception message      
        /// </summary>
        /// <returns>string</returns>
        /// <example>
        /// <code>
        /// using System;
        /// using System.IO;
        /// using System.Web;
        /// using System.Data;
        /// using TradingBell.WebCat.CatalogDB;
        /// using TradingBell.WebCat.CommonServices;
        /// 
        /// protected void Page_Load(object sender, EventArgs e)
        /// {
        ///     ErrorHandler objErrorHandler = new ErrorHandler();
        ///     string lastErr;
        ///     ...
        ///     lastErr = objErrorHandler.GetLastError();
        /// }
        /// </code>
        /// </example>

        public string GetLastError()
        {
            return _smException.Message;
        }

        /// <summary>
        /// This is used to Create the Log file for Every Exception      
        /// </summary>
        /// <example>  
        /// <code>
        /// using System;
        /// using System.IO;
        /// using System.Web;
        /// using System.Data;
        /// using TradingBell.WebCat.CatalogDB;
        /// using TradingBell.WebCat.CommonServices;
        /// 
        /// protected void Page_Load(object sender, EventArgs e)
        /// {
        ///     ErrorHandler objErrorHandler = new ErrorHandler();
        ///     ...
        ///     objErrorHandler.CreateLog();
        /// }
        /// </code>
        /// </example>

        public void CreateLog()
        {
            try
            {
                //AppDomain sPath = AppDomain.CurrentDomain;
                string sPath = "D:\\ErrorLogVehicle\\";
                if (Directory.Exists(sPath))
                {
                    string fName = "log" + DateTime.Now.ToShortDateString().Replace("/", "").Trim() + ".txt";
                    string strPathName = sPath + fName;
                    strPathName = strPathName.Replace("\\", "/");
                    if (File.Exists(strPathName) == false)
                    {
                        var fs = new FileStream(strPathName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                        fs.Close();
                    }
                    WriteErrorLog(strPathName, _smException);
                }
                else
                {
                    Directory.CreateDirectory(sPath);
                    string fName = "log" + DateTime.Now.ToShortDateString().Replace("/", "").Trim() + ".txt";
                    string strPathName = sPath + fName;
                    strPathName = strPathName.Replace("\\", "/");
                    if (File.Exists(strPathName) == false)
                    {
                        var fs = new FileStream(strPathName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                        fs.Close();
                    }
                    WriteErrorLog(strPathName, _smException);

                }
            }
            catch (Exception objException)
            {
                _smException = objException;
                //oErrHand.CreateLog();
            }
        }


        public bool WriteErrorLog(string strPathName, Exception objException)
        {
            bool bReturn;
            try
            {
                _sw = new StreamWriter(strPathName, true);
                _sw.WriteLine("Source        : " + objException.Source.Trim());
                _sw.WriteLine("Method        : " + objException.TargetSite.Name);
                _sw.WriteLine("Date        : " + DateTime.Now.ToLongTimeString());
                _sw.WriteLine("Time        : " + DateTime.Now.ToShortDateString());
                _sw.WriteLine("Computer    : " + Dns.GetHostName());
                _sw.WriteLine("Error        : " + objException.Message.Trim());
                _sw.WriteLine("Stack Trace    : " + objException.StackTrace.Trim());
                _sw.WriteLine("^^-------------------------------------------------------------------^^");
                _sw.Flush();
                _sw.Close();
                bReturn = true;
            }
            catch (Exception objExecption)
            {
                _smException = objExecption;
                bReturn = false;
            }
            return bReturn;
        }

        #endregion
    }
}

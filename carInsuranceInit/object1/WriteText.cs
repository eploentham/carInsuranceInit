using carInsuranceInit.objdb;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace carInsuranceInit.object1
{
    class WriteText
    {
        ConnectDB conn;
        String path = @"E:\AppServ\Example.txt";
        String fileNameSedanAgeCar = "";
        String fileNameSedanAgeDriver = "";
        String fileNameSedanUseCar = "";
        String fileNameSedanEngineCC = "";
        String fileNameSedanCapitalInsur = "";
        String fileNameSedanCatCar = "";
        String fileNameSedanInjuryAsset = "";
        String fileNameSedanInjuryPerson = "";
        String fileNameSedanInjuryTime = "";
        public WriteText()
        {
            initConfig();
        }
        public WriteText(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            conn = new ConnectDB();
        }
        private void writeSedanAgeCar()
        {

        }
        public Boolean writeTxt(String pathFile, String filename, String data)
        {
            Boolean chk = false;
            if (filename.Equals("") || filename.Equals("\\"))
            {
                return false;
            }
            //File.Create(filename).Dispose();
            try
            {
                if (!System.IO.Directory.Exists(pathFile))
                {
                    System.IO.Directory.CreateDirectory(pathFile);
                }
                using (TextWriter tw = new StreamWriter(pathFile+"\\"+filename))
                {
                    tw.Write(data);
                    tw.Close();
                    chk = true;
                }
            }
            catch (Exception ex)
            {
                chk = false;
            }
            return chk;
           
            //if (!File.Exists(pathFilename))
            //{
            //    File.Create(pathFilename).Dispose();
            //    using (TextWriter tw = new StreamWriter(pathFilename))
            //    {
            //        tw.Write(data);
            //        tw.Close();
            //    }
            //}
            //else if (File.Exists(pathFilename))
            //{
            //    using (TextWriter tw = new StreamWriter(pathFilename))
            //    {
            //        tw.Write(data);
            //        tw.Close();
            //    }
            //}
        }
    }
}

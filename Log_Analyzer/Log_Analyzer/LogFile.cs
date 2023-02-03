using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Log_Analyzer
{
    internal class LogFile
    {
        private string filePath { get; set; }
        private  string fileName { get; set; }
        public FilterSet filterSet1 { get; set; }
        public FilterSet filterSet2 { get; set; }
        public int totalLogsNum { get; set; }

        public int maxMatchedNum { get; set; }        
        public int matchedNum { get; set; }
        public int matchedShownNum { get; set; }
           
        public string filteredLogs = "";
        public bool outofMemory { get; set; }
        public bool matchedLogExists { get; set; }
        public StreamReader reader;
        public StringBuilder sb = new StringBuilder();
        private Stopwatch sw = new Stopwatch();

        public LogFile(string fileName, string filePath)
        {
            this.fileName = fileName;
            this.filePath = filePath;
            this.totalLogsNum= 0;
            this.matchedNum = 0;
            this.outofMemory = false;
            this.matchedLogExists= false;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            reader = new StreamReader(filePath, System.Text.Encoding.GetEncoding(950));
            
        }

        //primary method for filtering logs with stream reader
        //return a single string of filtered logs seperated with a new line character
        public string FilterLogs()
        {      
            string newLine = "";
            bool match = true;
       
            while (!reader.EndOfStream && matchedNum < maxMatchedNum)
            {
                match = true;
                newLine = reader.ReadLine();
                totalLogsNum++;
                if (filterSet1.filterNum > 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        string filterStr = filterSet1.filterProperties[i].filterText;

                        if (filterStr.Length > 0 && !newLine.Contains(filterStr))
                        {
                            match = false;
                            break;
                        }
                    }
                }

                if (filterSet2.filterNum > 0 && (!match || filterSet1.filterNum <= 0))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        string filterStr = filterSet2.filterProperties[i].filterText;
                        if (filterStr.Length > 0 && newLine.Contains(filterStr))
                        {
                            match = true;
                        }
                        else if (!newLine.Contains(filterStr))
                        {
                            match = false;
                            break;
                        }
                    }
                }

                if (match)
                {
                    sb.Append(newLine + "\n");
                    matchedNum++;
                    matchedLogExists = true;
                }

                if(match && sb.Length < Int32.MaxValue / 3)
                {
                    matchedShownNum++;
                }

            }
            reader.Close();
          
            try
            {
                return sb.ToString();
            }
            catch(Exception ex)
            {
                outofMemory = true;

                return sb.ToString(0, Int32.MaxValue / 3);
            }
          
        }                


    } 
}

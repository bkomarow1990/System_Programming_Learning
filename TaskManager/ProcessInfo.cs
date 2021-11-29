using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class ProcessInfo
    {
        public string GetProcessOwner(int processId)
        {
            string query = "Select * From Win32_Process Where ProcessID = " + processId;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection processList = searcher.Get();

            foreach (ManagementObject obj in processList)
            {
                string[] argList = new string[] { string.Empty, string.Empty };
                int returnVal = Convert.ToInt32(obj.InvokeMethod("GetOwner", argList));
                if (returnVal == 0)
                {
                    return argList[0];
                }
            }

            return "NO OWNER";
        }
        public int ID{ get; set; }
        public string Name { get; set; }
        public string User { get; set; }
        public ProcessInfo(Process process)
        {
            ID = process.Id;
            Name = process.ProcessName;
            User = GetProcessOwner(process.Id);
        }
    }
}

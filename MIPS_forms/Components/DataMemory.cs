using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIPS_forms.Utils;

namespace MIPS_forms.Components
{
    class DataMemory : AbstractComponent
    {
        public int[] memory = new int[100];
        public DataMemory(Clock clock)
        {
            memory[0] = 5;
            memory[1] = 5;
            clk = clock;
            InPorts["address"] = 0;
            InPorts["writeData"] = 0;
            InPorts["memWrite"] = 0;
            OutPorts["readData"] = 0;
        }
        public string memoryToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < memory.Length; i++)
            {
                sb.AppendLine(i.ToString() + ": " + memory[i].ToString());
            }
            return sb.ToString();
        }

        public override void UpdateOutput()
        {
            Dictionary<string, int> AllPorts = InPorts.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            AllPorts.Concat(PredefinedPorts).ToDictionary(x => x.Key, x => x.Value);

            int address = AllPorts["address"];
            int writeData = AllPorts["writeData"];
            int memWrite = AllPorts["memWrite"];

            if (ClkCheck == clk.Get())
            {
                ClkCheck++;
                if (memWrite == 1 && address >= 0)
                {
                    memory[address] = writeData;
                }
            }
            if (address >= 0)
            {
                OutPorts["readData"] = memory[address];
            }
            //connect to other components here
            for (int i = 0; i < connectedComponents.Count(); i++)
            {
                connectedComponents[i].SetSignal(connectedComponentPort[i], OutPorts[connectedOutput[i]]);
            }
        }
        public void SetMemory(string values)
        {
            string s = values;
            string[] strings = s.Split('\n');
            Array.Fill(memory, 0);
            for (int i = 0; i < strings.Length; i++)
            {
                memory[i] = int.Parse(strings[i]);
            }
        }
    }
}

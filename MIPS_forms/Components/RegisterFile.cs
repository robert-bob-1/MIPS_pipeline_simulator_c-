using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIPS_forms.Utils;

namespace MIPS_forms.Components
{
    class RegisterFile : AbstractComponent
    {
        public int[] memory = new int[2^5];
        public RegisterFile(Clock clock)
        {
            memory[1] = 10; memory[2] = 1;
            clk = clock;
            InPorts["readAddress1"] = 0;
            InPorts["readAddress2"] = 0;
            InPorts["writeAddress"] = 0;
            InPorts["writeData"] = 0;
            InPorts["regWrite"] = 0;
            OutPorts["readData1"] = 0;
            OutPorts["readData2"] = 0;
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

            int readAddress1 = AllPorts["readAddress1"];
            int readAddress2 = AllPorts["readAddress2"];
            int writeAddress = AllPorts["writeAddress"];
            int writeData = AllPorts["writeData"];
            int regWrite = AllPorts["regWrite"];

            if (ClkCheck == clk.Get())
            {
                ClkCheck++;
                if (regWrite == 1)
                {
                    memory[writeAddress] = writeData;
                }
            }
            OutPorts["readData1"] = memory[readAddress1];
            OutPorts["readData2"] = memory[readAddress2];


            //connect to other components here
            for (int i = 0; i < connectedComponents.Count(); i++)
            {
                connectedComponents[i].SetSignal(connectedComponentPort[i], OutPorts[connectedOutput[i]]);
            }
        }
    }
}

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
            clk = clock;
            InPorts["instruction"] = 0;
            InPorts["writeAddress"] = 0;
            InPorts["writeData"] = 0;
            InPorts["regWrite"] = 0;
            OutPorts["readData1"] = 0;
            OutPorts["readData2"] = 0;
        }
        public override void UpdateOutput()
        {
            Dictionary<string, int> AllPorts = InPorts.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            AllPorts.Concat(PredefinedPorts).ToDictionary(x => x.Key, x => x.Value);

            int readAddress1 = AllPorts["instruction"] / (2 ^ 20) % (2 ^ 5);
            int readAddress2 = AllPorts["instruction"] / (2 ^ 15) % (2 ^ 5);
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

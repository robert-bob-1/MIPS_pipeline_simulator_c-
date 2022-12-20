using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS_forms.Components
{
    class ControlUnit : AbstractComponent
    {
        public ControlUnit()
        {
            InPorts["instruction"] = -1;
            OutPorts["jump"] = 0;
            OutPorts["memToReg"] = 0;
            OutPorts["regWrite"] = 0;
            OutPorts["memWrite"] = 0;
            OutPorts["branch"] = 0;
            OutPorts["ALUOp"] = 0;
            OutPorts["ALUSrc"] = 0;
            OutPorts["regDst"] = 0;
            OutPorts["extOp"] = 0;
        }
        public override void UpdateOutput()
        {
            //adding inports and predefinedPorts together to operate using all of them
            Dictionary<string, int> AllPorts = InPorts.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            AllPorts = AllPorts.Concat(PredefinedPorts).ToDictionary(x => x.Key, x => x.Value);

            //get opcode
            int opcode = AllPorts["instruction"] % 67108864;

            OutPorts["jump"] = 0;
            OutPorts["memToReg"] = 0;
            OutPorts["regWrite"] = 0;
            OutPorts["memWrite"] = 0;
            OutPorts["branch"] = 0;
            OutPorts["ALUOp"] = 0;
            OutPorts["ALUSrc"] = 0;
            OutPorts["regDst"] = 0;
            OutPorts["extOp"] = 0;

            switch (opcode)
            {
                //instructiune de tip r
                case 0:
                    OutPorts["regDst"] = 1;
                    OutPorts["ALUOp"] = 10;
                    OutPorts["ALUSrc"] = 0;
                    OutPorts["regWrite"] = 1;
                    break;
                

            }
            //send signals to other components here
            for (int i = 0; i < connectedComponents.Count(); i++)
            {
                connectedComponents[i].SetSignal(connectedComponentPort[i], OutPorts[connectedOutput[i]]);
            }

        }
    }
}

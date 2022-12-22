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
            int opcode = AllPorts["instruction"] / (2 ^ 25);

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
                    OutPorts["ALUOp"] = 0;
                    OutPorts["regWrite"] = 1;
                    break;
                //addi
                case 1: //extop posibil redundant
                    OutPorts["extOp"] = 1;
                    OutPorts["ALUSrc"] = 1;
                    OutPorts["regWrite"] = 1;
                    OutPorts["ALUOp"] = 1;
                    break;
                //lw
                case 2:
                    OutPorts["extOp"] = 1;
                    OutPorts["ALUSrc"] = 1;
                    OutPorts["memToReg"] = 1;
                    OutPorts["regWrite"] = 1;
                    OutPorts["ALUOp"] = 1;
                    break;
                //sw
                case 3:
                    OutPorts["extOp"] = 1;
                    OutPorts["ALUSrc"] = 1;
                    OutPorts["memWrite"] = 1;
                    OutPorts["regWrite"] = 1;
                    OutPorts["ALUOp"] = 1;
                    break;
                //beq
                case 4:
                    OutPorts["extOp"] = 1;
                    OutPorts["branch"] = 1;
                    OutPorts["ALUOp"] = 2;
                    break;
                //andi
                case 5:
                    OutPorts["ALUSrc"] = 1;
                    OutPorts["regWrite"] = 1;
                    OutPorts["ALUOp"] = 5;
                    break;
                //ori
                case 6:
                    OutPorts["ALUSrc"] = 1;
                    OutPorts["regWrite"] = 1;
                    OutPorts["ALUOp"] = 6;
                    break;
                //jump
                case 7:
                    OutPorts["jump"] = 1;
                    break;

                default:
                    OutPorts["jump"] = 0;
                    OutPorts["memToReg"] = 0;
                    OutPorts["regWrite"] = 0;
                    OutPorts["memWrite"] = 0;
                    OutPorts["branch"] = 0;
                    OutPorts["ALUOp"] = 0;
                    OutPorts["ALUSrc"] = 0;
                    OutPorts["regDst"] = 0;
                    OutPorts["extOp"] = 0;
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

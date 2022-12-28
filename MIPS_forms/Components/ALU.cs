using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS_forms.Components
{
    class ALU : AbstractComponent
    {
        public ALU()
        {
            InPorts["rd1"] = 0;
            InPorts["rd2"] = 0;
            InPorts["ALUCtrl"] = 0;
            OutPorts["ALUResult"] = 0;
            OutPorts["zero"] = 0;
        }

        public override void UpdateOutput()
        {
            //adding inports and predefinedPorts together to operate using all of them
            Dictionary<string, int> AllPorts = InPorts.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            AllPorts = AllPorts.Concat(PredefinedPorts).ToDictionary(x => x.Key, x => x.Value);

            int rd1 = AllPorts["rd1"];
            int rd2 = AllPorts["rd2"];
            int ALUOp = AllPorts["ALUCtrl"];
            int result = 0;
            
            switch (ALUOp)
            {
                case 0:
                    result = rd1 + rd2;
                    break;
                case 1:
                    result = rd1 - rd2;
                    break;
                case 2:
                    result = rd1 & rd2;
                    break;
                case 3:
                    result = rd1 | rd2;
                    break;
                case 4:
                    result = rd1 ^ rd2;
                    break;
                case 5:
                    result = rd1 << rd2;
                    break;
                case 6:
                    result = rd1 >> rd2;
                    break;
                case 7:
                    result = rd1 - rd2;
                    break;
                default:
                    result = 0; break;
            }
            OutPorts["ALUResult"] = result;

            if (result == 0 | (result != 0 && ALUOp == 7))
                OutPorts["zero"] = 1;
            else
                OutPorts["zero"] = 0;

            //send signals to other components here
            for (int i = 0; i < connectedComponents.Count(); i++)
            {
                connectedComponents[i].SetSignal(connectedComponentPort[i], OutPorts[connectedOutput[i]]);
            }

        }
    }
}

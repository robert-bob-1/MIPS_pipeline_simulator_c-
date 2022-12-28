using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS_forms.Components
{
    class And : AbstractComponent
    {
        public And()
        {
            InPorts["input0"] = -1;
            InPorts["input1"] = -1;
            OutPorts["output"] = -1;
        }
        public override void UpdateOutput()
        {
            Dictionary<string, int> AllPorts = InPorts.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            AllPorts = AllPorts.Concat(PredefinedPorts).ToDictionary(x => x.Key, x => x.Value);

            int input0 = AllPorts["input0"];
            int input1 = AllPorts["input1"];

            OutPorts["output"] = input0 & input1;
            //send signals to other components here
            for (int i = 0; i < connectedComponents.Count(); i++)
            {
                connectedComponents[i].SetSignal(connectedComponentPort[i], OutPorts[connectedOutput[i]]);
            }

        }
    }
}

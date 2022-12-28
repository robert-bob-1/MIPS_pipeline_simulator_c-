using MIPS_forms.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS_forms.Components
{
    class PC : AbstractComponent
    {

        public PC(Clock clock)
        {
            clk = clock;
            InPorts["pc_in"] = 0;   
            OutPorts["pc_out"] = 0;
        }
        public override void UpdateOutput()
        {
            Dictionary<string, int> AllPorts = InPorts.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            AllPorts.Concat(PredefinedPorts).ToDictionary(x => x.Key, x => x.Value);

            int input = AllPorts["pc_in"];

            if(ClkCheck == clk.Get())
            {
                ClkCheck++;
                OutPorts["pc_out"] = input;
            }

            //connect to other components here
            for(int i = 0; i<connectedComponents.Count(); i++)
            {
                connectedComponents[i].SetSignal(connectedComponentPort[i], OutPorts[connectedOutput[i]]);
            }
        }
    }
}

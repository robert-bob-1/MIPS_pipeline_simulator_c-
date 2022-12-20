using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS_forms.Components
{
    class InstructionMemory : AbstractComponent
    {
        //instructiunile interne vor fi salvate aici
        private List<int> instructionMemory = new List<int>();
        
        public InstructionMemory()
        {
            instructionMemory.AddRange(new List<int> {11,22,33,44,55,66 });
            InPorts["pc_in"] = 0;
            OutPorts["pc_out"] = 0;
        }
        public override void UpdateOutput()
        {
            Dictionary<string, int> AllPorts = InPorts.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            AllPorts.Concat(PredefinedPorts).ToDictionary(x => x.Key, x => x.Value);

            int pc_in = AllPorts["pc_in"];

            OutPorts["pc_out"] = instructionMemory.ElementAt(pc_in % instructionMemory.Count);

            //connect to other components here
            for (int i = 0; i < connectedComponents.Count(); i++)
            {
                connectedComponents[i].SetSignal(connectedComponentPort[i], OutPorts[connectedOutput[i]]);
            }
        }
    }
}

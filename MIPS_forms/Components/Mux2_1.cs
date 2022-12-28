using MIPS_forms.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS_forms.Components
{
    class Mux2_1 : AbstractComponent
    {
        public Mux2_1()
        {
            InPorts["input0"] = 0;
            InPorts["input1"] = 0;
            InPorts["select"] = 0;
            OutPorts["output"] = 0;
        }

        //set an input to a permanent value
        public Mux2_1(string inputName, int inputValue)
        {
            InPorts["input0"] = 0;
            InPorts["input1"] = 0;
            InPorts["select"] = 0;
            OutPorts["output"] = 0;

            SetPredefinedInput(inputName, inputValue);
        }
        public override void UpdateOutput()
        {
            Dictionary<string, int> AllPorts = InPorts.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            AllPorts = AllPorts.Concat(PredefinedPorts).ToDictionary(x =>x.Key, x=> x.Value);

            int input0 = AllPorts["input0"];
            int input1 = AllPorts["input1"];
            int select = AllPorts["select"];

            if (select == 0)
            {
                OutPorts["output"] = input0;
            }
            else if (select == 1)
            {
                OutPorts["output"] = input1;
            }
            //send signals to other components here
            for (int i = 0; i < connectedComponents.Count(); i++)
            {
                connectedComponents[i].SetSignal(connectedComponentPort[i], OutPorts[connectedOutput[i]]);
            }

        }
    }
}

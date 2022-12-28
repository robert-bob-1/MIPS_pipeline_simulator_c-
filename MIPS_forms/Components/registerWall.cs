using MIPS_forms.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS_forms.Components
{
    class RegisterWall : AbstractComponent
    {
        public List<string> signals = new List<string>();
        public RegisterWall(Clock clock)
        {
            this.clk = clock;
        }
        public RegisterWall(List<String> signals, Clock clock)
        {
            this.clk = clock;
            this.signals = signals.ToList();
            for (int i = 0; i < signals.Count; i++)
            {
                InPorts["input" + signals.ElementAt(i)] = 0;
                OutPorts["output" + signals.ElementAt(i)] = 0;
            }
        }

        override public void ConnectComponent(AbstractComponent component, string from, string to)
        {
            InPorts[from] = 0;
            OutPorts[from] = 0;
            if (!signals.Contains(from))
            {
                signals.Add(from);
            }
            connectedComponents.Add(component);
            connectedOutput.Add(from);
            connectedComponentPort.Add(to);
        }

        public override void UpdateOutput()
        {
            //adding inports and predefinedPorts together to operate using all of them
            Dictionary<string, int> AllPorts = InPorts.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            AllPorts.Concat(PredefinedPorts).ToDictionary(x => x.Key, x => x.Value);

            if (ClkCheck == clk.Get())
            {
                ClkCheck++;
                for(int i = 0; i < signals.Count; i++)
                {
                    //OutPorts["output" + signals.ElementAt(i)] = AllPorts["input" + signals.ElementAt(i)];
                    OutPorts[signals[i]] = InPorts[signals.ElementAt(i)];
                }
                
            }
            //send signals to other components 
            for (int i = 0; i < connectedComponents.Count(); i++)
            {
                connectedComponents[i].SetSignal(connectedComponentPort[i], OutPorts[connectedOutput[i]]);
            }

        }
    }
}

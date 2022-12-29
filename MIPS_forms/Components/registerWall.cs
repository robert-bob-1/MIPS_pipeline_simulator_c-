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
        public Dictionary<string, int> BufferSignals = new Dictionary<string, int>();

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
                InPorts[signals.ElementAt(i)] = 0;
                BufferSignals[signals.ElementAt(i)] = 0;
                OutPorts[signals.ElementAt(i)] = 0;
            }
        }
        public override void ResetComponent()
        {
            foreach (KeyValuePair<string, int> kvp in InPorts)
            {
                InPorts[kvp.Key] = 0;
                OutPorts[kvp.Key] = 0;
                BufferSignals[kvp.Key] = 0;
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
            //buffer-> output
            for (int i = 0; i < signals.Count; i++)
            {
                OutPorts[signals.ElementAt(i)] = BufferSignals[signals.ElementAt(i)];
            }
            //input -> buffer
            if (ClkCheck == clk.Get())
            {
                ClkCheck++;
                for(int i = 0; i < signals.Count; i++)
                {
                    BufferSignals[signals[i]] = InPorts[signals.ElementAt(i)];
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

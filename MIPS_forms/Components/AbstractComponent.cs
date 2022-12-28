using MIPS_forms.Utils;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS_forms.Components
{
    abstract class AbstractComponent
    {
        public Clock clk;
        public int ClkCheck = 1;

        public Dictionary<string, int> InPorts = new Dictionary<string, int>();
        public Dictionary<string , int> PredefinedPorts = new Dictionary<string , int>();
        public Dictionary<string, int> OutPorts = new Dictionary<string, int>();

        public List<AbstractComponent> connectedComponents = new List<AbstractComponent>();
        public List<string> connectedOutput = new List<string>();
        public List<string> connectedComponentPort = new List<string>();

        virtual public void ConnectComponent(AbstractComponent component, string from, string to)
        {
            connectedComponents.Add(component);
            connectedOutput.Add(from);
            connectedComponentPort.Add(to);
        }

        private int _updatedSignals = 0;
        private int _predefinedInputs = 0;
        public int PredefinedInputs
        {
            get { return _predefinedInputs; }
            set { _predefinedInputs = value; }
        }
        public void SetSignal(string signalName, int value) {
            if (PredefinedPorts.ContainsKey(signalName))
            {
                throw new ArgumentException("given signal name is predefined and cannot be changed");
            }
            InPorts[signalName] = value;
            //_updatedSignals++;

            //if(_updatedSignals + _predefinedInputs == InPorts.Count)
            //{
            //    //UpdateOutput();
            //}
        }

        public void SetPredefinedInput(string inputName, int value)
        {
            InPorts.Remove(inputName);
            PredefinedInputs++;
            PredefinedPorts[inputName] = value; 
        }

        public abstract void UpdateOutput();

        public virtual string PrintSignals()
        {
            string signals = "";

            foreach(KeyValuePair<string, int> kvp in InPorts)
            {
                signals += kvp.Key + ":" + kvp.Value + "\n";
            }
            signals += "\n";
            foreach (KeyValuePair<string, int> kvp in OutPorts)
            {
                signals += kvp.Key + ":" + kvp.Value + "\n";
            }
            

            return signals;
        }
    }
}

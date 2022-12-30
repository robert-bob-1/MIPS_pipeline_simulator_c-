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
        private List<string> instructionMemory = new List<string>();
        
        public InstructionMemory()
        {
            instructionMemory.AddRange(new List<String> {
                                                          "add r1, r2, r1", //0th instruction
                                                          "sub r3, r3, r4",
                                                          "and r5, r5, r6",
                                                          "or r7, r7, r8",  //3rd instruction
                                                          "xor r9, r10, r9",
                                                          "addi r11, r11, 16",
                                                          "noop",
                                                          "noop",
                                                          "subi r12, r12, 100",
                                                          "andi r13, r11, 17",
                                                          "ori r14, r11, 17",
                                                          "sll r15, r11, 2",
                                                          "slr r16, r11, 2",
                                                          "noop",
                                                          "noop",
                                                          "noop",
                                                          "lw r1, 0(r0)",
                                                          "lw r2, 1(r0)",
                                                          "sw r11, 11(r0)",
                                                          "noop",
                                                          "jump 25", //20th instruction
                                                          "noop",
                                                          "noop",
                                                          "noop",
                                                          "noop",
                                                          "beq r2, r3, 6", //25th
                                                          "noop",
                                                          "noop",
                                                          "noop",
                                                          "noop",
                                                          "noop",
                                                          "noop",
                                                          "jump 0",

                                                          "noop",
                                                          "noop",
                                                          "noop",
                                                          "noop"

                                                            });
            InPorts["pc_in"] = 0;
            OutPorts["instr31_26"] = 0;
            OutPorts["instr25_21"] = 0;
            OutPorts["instr20_16"] = 0;
            OutPorts["instr15_0"] = 0;
            OutPorts["instr5_0"] = 0;
            OutPorts["instr15_11"]  = 0;
        }
        public string memoryToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(string s in instructionMemory)
            {
                sb.AppendLine(s);
            }
            return sb.ToString();
        }
        public void instructionToInt(string instruction)
        {
            //add 1, 2, 3     
            // r3 = r1 + r2
            //first separate the string
            instruction = instruction.Replace(",", "");
            instruction = instruction.Replace(")", "");
            instruction = instruction.Replace("$", "");

            string[] instructionList = instruction.Split(' ');
            if (instructionList.Length > 1 && instructionList[0] != "jump" && instruction != "noop")
            {
                instructionList[1] = instructionList[1].Replace("r", "");
                instructionList[1] = instructionList[1].Replace("s", "");
                instructionList[2] = instructionList[2].Replace("r", "");
                instructionList[2] = instructionList[2].Replace("s", "");
                if (instructionList[0] != "lw" && instructionList[0] != "sw")
                {
                    instructionList[3] = instructionList[3].Replace("r", "");
                    instructionList[3] = instructionList[3].Replace("s", "");
                }
            }

            int register1 = 0, register2 = 0, destinationRegister = 0;
            int opcode = 0, sa = 0, func = 0, immediate = 0, targetAddr = 0;

            switch(instructionList[0])
            {
                case "add":
                    destinationRegister = int.Parse(instructionList[1]);
                    register1 = int.Parse(instructionList[2]);
                    register2 = int.Parse(instructionList[3]);
                    opcode    = 0;
                    func      = 0;
                    immediate = 0;
                    break;
                case "sub":
                    destinationRegister = int.Parse(instructionList[1]);
                    register1 = int.Parse(instructionList[2]);
                    register2 = int.Parse(instructionList[3]);
                    opcode    = 0;
                    func      = 1;
                    immediate = 0;
                    break;
                case "and":
                    destinationRegister = int.Parse(instructionList[1]);
                    register1 = int.Parse(instructionList[2]);
                    register2 = int.Parse(instructionList[3]);
                    opcode    = 0;
                    func      = 2;
                    immediate = 0;
                    break;
                case "or":
                    destinationRegister = int.Parse(instructionList[1]);
                    register1 = int.Parse(instructionList[2]);
                    register2 = int.Parse(instructionList[3]);
                    opcode    = 0;
                    func      = 3;
                    immediate = 0;
                    break;
                case "xor":
                    destinationRegister = int.Parse(instructionList[1]);
                    register1 = int.Parse(instructionList[2]);
                    register2 = int.Parse(instructionList[3]);
                    opcode    = 0;
                    func      = 4;
                    immediate = 0;
                    break;

                    //////type i
                case "addi":
                    destinationRegister = int.Parse(instructionList[1]);
                    register1 = int.Parse(instructionList[2]);
                    opcode    = 1;
                    immediate = int.Parse(instructionList[3]);
                    break;
                case "subi":
                    destinationRegister = int.Parse(instructionList[1]);
                    register1 = int.Parse(instructionList[2]);
                    opcode    = 2;
                    immediate = int.Parse(instructionList[3]);
                    break;
                case "andi":
                    destinationRegister = int.Parse(instructionList[1]);
                    register1 = int.Parse(instructionList[2]);
                    opcode    = 3;
                    immediate = int.Parse(instructionList[3]);
                    break;
                case "ori":
                    destinationRegister = int.Parse(instructionList[1]);
                    register1 = int.Parse(instructionList[2]);
                    opcode    = 4;
                    immediate = int.Parse(instructionList[3]);
                    break;
                case "beq":
                    register1 = int.Parse(instructionList[1]);
                    register2 = int.Parse(instructionList[2]);
                    opcode    = 5;
                    immediate = int.Parse(instructionList[3]);
                    break;
                case "sll":
                    destinationRegister = int.Parse(instructionList[1]);
                    register1 = int.Parse(instructionList[2]);
                    opcode    = 7;
                    immediate = int.Parse(instructionList[3]);
                    break;
                case "slr":
                    destinationRegister = int.Parse(instructionList[1]);
                    register1 = int.Parse(instructionList[2]);
                    opcode    = 8;
                    immediate = int.Parse(instructionList[3]);
                    break;
                case "sw":
                    string[] args = instructionList[2].Split('(');
                    register1 = int.Parse(args[1]);
                    register2 = int.Parse(instructionList[1]);
                    opcode    = 9;
                    immediate = int.Parse(args[0]);
                    break;
                case "lw":
                    string[] arg = instructionList[2].Split('(');
                    register1 = int.Parse(arg[1]);
                    register2 = int.Parse(instructionList[1]);
                    opcode    = 10;
                    immediate = int.Parse(arg[0]);
                    break;
                case "jump":
                    opcode    = 11;
                    immediate = int.Parse(instructionList[1]);
                    break;
                case "noop":
                    opcode = 12;
                    break;
                default:
                    throw new Exception("unregistered instruction in memory");
            }
            //
            OutPorts["instr31_26"] = opcode;
            OutPorts["instr25_21"] = register1;
            OutPorts["instr20_16"] = register2;
            OutPorts["instr15_0"] = immediate;
            OutPorts["instr5_0"] = func;
            OutPorts["instr15_11"] = destinationRegister;

        }

        public string GetCurrentInstruction()
        {
            return instructionMemory.ElementAt(InPorts["pc_in"]);
        }

        public override string PrintSignals()
        {
            string signals;
            if (InPorts["pc_in"] < instructionMemory.Count)
                signals = "current: " + instructionMemory.ElementAt(InPorts["pc_in"]) + "\n";
            else
                signals = "no more instructions";
            foreach (KeyValuePair<string, int> kvp in InPorts)
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

        public override void UpdateOutput()
        {
            Dictionary<string, int> AllPorts = InPorts.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            AllPorts.Concat(PredefinedPorts).ToDictionary(x => x.Key, x => x.Value);

            //convert instruction at [pc_in] to string
            int pc_in = AllPorts["pc_in"];
            //for assembly-like instruction s
            //OutPorts["pc_out"] = instructionMemory.ElementAt(pc_in % instructionMemory.Count);
            if (InPorts["pc_in"] < instructionMemory.Count)
                instructionToInt(instructionMemory.ElementAt(pc_in));
            else
                instructionToInt("noop");

            //connect to other components here
            for (int i = 0; i < connectedComponents.Count(); i++)
            {
                connectedComponents[i].SetSignal(connectedComponentPort[i], OutPorts[connectedOutput[i]]);
            }
        }
        public void SetMemory(string values)
        {
            string s = values;
            string[] strings = s.Split('\n');
            instructionMemory.Clear();
            for (int i = 0; i < strings.Length; i++)
            {
                instructionMemory.Add(strings[i]);
            }
            instructionMemory.Add("noop");
            instructionMemory.Add("noop");
            instructionMemory.Add("noop");
            instructionMemory.Add("noop");
            instructionMemory.Add("noop");
            instructionMemory.Add("noop");
            instructionMemory.Add("noop");
            instructionMemory.Add("noop");
            instructionMemory.Add("noop");
        }
    }
}

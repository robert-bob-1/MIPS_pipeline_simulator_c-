using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS_forms.Components
{
    class ALUCtrl : AbstractComponent
    {
        public ALUCtrl()
        {
            InPorts["ALUOp"] = 0;
            InPorts["func"] = 0;
            OutPorts["ALUCtrl"] = 0;
        }

        public override void UpdateOutput()
        {
            //adding inports and predefinedPorts together to operate using all of them
            Dictionary<string, int> AllPorts = InPorts.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            AllPorts = AllPorts.Concat(PredefinedPorts).ToDictionary(x => x.Key, x => x.Value);

            int func = AllPorts["func"];
            int aluop = AllPorts["ALUOp"];

            switch (aluop)
            {
                case 0:
                    switch (func)
                    {
                        case 0: //add
                            OutPorts["ALUCtrl"] = 0;
                            break;
                        case 1: //sub
                            OutPorts["ALUCtrl"] = 1;
                            break;
                        case 2: //and
                            OutPorts["ALUCtrl"] = 2;
                            break;
                        case 3: //or
                            OutPorts["ALUCtrl"] = 3;
                            break;
                        case 4: //xor
                            OutPorts["ALUCtrl"] = 4;
                            break;
                        case 5: //sll
                            OutPorts["ALUCtrl"] = 5;
                            break;
                        case 6: //slr
                            OutPorts["ALUCtrl"] = 6;
                            break;

                    }
                    break;
                case 1: //addi
                    OutPorts["ALUCtrl"] = 0;
                    break;
                case 2: //subi
                    OutPorts["ALUCtrl"] = 1;
                    break;
                case 3: //andi
                    OutPorts["ALUCtrl"] = 2;
                    break;
                case 4: //ori
                    OutPorts["ALUCtrl"] = 3;
                    break;
                case 5: //beq
                    OutPorts["ALUCtrl"] = 1;
                    break;
                case 6: //bneq
                    OutPorts["ALUCtrl"] = 1;
                    break;
                case 7: //sll
                    OutPorts["ALUCtrl"] = 5;
                    break;
                case 8: //slr
                    OutPorts["ALUCtrl"] = 6;
                    break;
                case 9: //sw
                    OutPorts["ALUCtrl"] = 0;
                    break;
                case 10: //lw
                    OutPorts["ALUCtrl"] = 0;
                    break;
                case 11: //jump
                    OutPorts["ALUCtrl"] = 0;
                    break;
                default:
                    throw new ArgumentException("aluctrl: no such instruction ops");
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

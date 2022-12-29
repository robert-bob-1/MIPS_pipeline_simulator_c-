using MIPS_forms.Components;
using MIPS_forms.Utils;
using System.Diagnostics.CodeAnalysis;

namespace MIPS_forms
{
    public partial class Form1 : Form
    {
        //Mux2_1 dummyMUX = new Mux2_1("select", 0);

        Clock clock = new Clock();
        //IF
        Mux2_1 pcSrcMUX = new Mux2_1();
        
        Mux2_1 jumpMUX = new Mux2_1();
        PC pc;
        InstructionMemory instructionMemory = new InstructionMemory();
        
        Adder adderIF = new Adder("input0", 1);
        RegisterWall IFID;

        //ID
        ControlUnit controlUnit= new ControlUnit();
        RegisterFile registerFile ;
        RegisterWall IDEX;

        //EX
        Adder adderEX = new Adder();
        ALU alu = new ALU();
        Mux2_1 aluMUX = new Mux2_1();
        ALUCtrl aluCtrl = new ALUCtrl();
        Mux2_1 regMUX = new Mux2_1();
        RegisterWall EXMEM;

        //MEM
        And and = new And();
        DataMemory dataMemory;
        RegisterWall MEMWB;

        //WB
        Mux2_1 memMUX= new Mux2_1();

        public Form1()
        {
            InitializeComponent();
            
            List<String> listIFID  = new List<String>();
            listIFID.AddRange(new List<String> { "pc+1", "instr31_26", "instr25_21", "instr20_16", "instr15_0", "instr5_0", "instr15_11" });
            List<String> listIDEX  = new List<String>();
            listIDEX.AddRange(new List<String> { "memToReg", "regWrite", "memWrite", "branch", "ALUOp", "ALUSrc", "regDst", "pc+1", 
                                                "rd1", "rd2", "instr5_0", "instr15_0", "instr20_16", "instr15_11" });
            List<String> listEXMEM = new List<String>();
            listEXMEM.AddRange(new List<String> { "memToReg", "regWrite", "memWrite", "branch", "branchAddress", "zero", "ALUResult",
                                                "rd2", "writeAddress"});
            List<String> listMEMWB = new List<String>();
            listMEMWB.AddRange(new List<String> { "memToReg", "regWrite", "readData", "ALUResult", "writeAddress" });
            
            //instrucion fetch components
            pc = new PC(clock);
            IFID = new RegisterWall(listIFID, clock);
            IFID.InPorts["instr31_26"] = -1;
            IFID.BufferSignals["instr31_26"] = -1;
            IFID.OutPorts["instr31_26"] = -1;
            //instruction decode components
            registerFile = new RegisterFile(clock);
            IDEX = new RegisterWall(listIDEX, clock);

            ////execution components
            EXMEM = new RegisterWall(listEXMEM, clock);

            //memory components
            dataMemory= new DataMemory(clock);
            MEMWB = new RegisterWall(listMEMWB, clock);
            
            //writing starting data /////////////////////////////////////////////////////////////////////////////////////
            InstructionMemoryTextBox2.Text = instructionMemory.memoryToString();
            DataMemoryTextBox2.Text = dataMemory.memoryToString();
            RegisterFileTextBox2.Text = registerFile.memoryToString();

            instruction1Label.Text = "";
            instruction2Label.Text = "";
            instruction3Label.Text = "";
            instruction4Label.Text = "";
            instruction5Label.Text = "";

            pcsrcMUXTextBox.Text = pcSrcMUX.PrintSignals();
            JumpMUXTextBox.Text = jumpMUX.PrintSignals();
            PCTextBox.Text = pc.PrintSignals();
            PCAdderTextBox.Text = adderIF.PrintSignals();
            InstructionMemoryTextBox.Text = instructionMemory.PrintSignals();
            IFIDTextBox.Text = IFID.PrintSignals();
            ///////////////////// ID ////////////////////////
            MainControlTextBox.Text = controlUnit.PrintSignals();
            RegisterFileTextBox.Text = registerFile.PrintSignals();
            RegisterFileTextBox2.Text = registerFile.memoryToString();
            IDEXTextBox.Text = IDEX.PrintSignals();
            ///////////////////// EX ////////////////////////
            BranchAddressTextBox.Text = adderEX.PrintSignals();
            ALUSrcMUXTextBox.Text = aluMUX.PrintSignals();
            ALUControlTextBox.Text = aluCtrl.PrintSignals();
            ALUTextBox.Text = alu.PrintSignals();
            RegDstMUXTextBox.Text = regMUX.PrintSignals();
            EXMEMTextBox.Text = EXMEM.PrintSignals();
            ////////////////////// MEM ///////////////////////
            BranchTextBox.Text = and.PrintSignals();
            DataMemoryTextBox.Text = dataMemory.PrintSignals();
            DataMemoryTextBox2.Text = dataMemory.memoryToString();
            MEMWBTextBox.Text = MEMWB.PrintSignals();
            ////////////////////// WB /////////////////////////
            MemtoRegTextBox.Text = memMUX.PrintSignals();
            registerFile.WriteToRegisterFile();
            RegisterFileTextBox2.Text = registerFile.memoryToString();

            //components
            dataMemory = new DataMemory(clock);

            ///////////////connecting components
            
            //IF
            pcSrcMUX.ConnectComponent(jumpMUX, "output", "input0");
            jumpMUX.ConnectComponent(pc, "output", "pc_in");
            pc.ConnectComponent(adderIF, "pc_out", "input1");
            pc.ConnectComponent(instructionMemory, "pc_out", "pc_in");
            adderIF.ConnectComponent(pcSrcMUX, "output", "input0");
            adderIF.ConnectComponent(IFID, "output", "pc+1");
            instructionMemory.ConnectComponent(IFID, "instr31_26", "instr31_26");
            instructionMemory.ConnectComponent(IFID, "instr25_21", "instr25_21");
            instructionMemory.ConnectComponent(IFID, "instr20_16", "instr20_16");
            instructionMemory.ConnectComponent(IFID, "instr15_0" , "instr15_0");
            instructionMemory.ConnectComponent(IFID, "instr5_0"  , "instr5_0");
            instructionMemory.ConnectComponent(IFID, "instr15_11", "instr15_11");

            IFID.ConnectComponent(jumpMUX, "instr15_0", "input1");
            //IFID.ConnectComponent(pcSrcMUX, "pc+1", "input1");
            IFID.ConnectComponent(controlUnit, "instr31_26", "opcode");
            IFID.ConnectComponent(registerFile, "instr25_21", "readAddress1");
            IFID.ConnectComponent(registerFile, "instr20_16", "readAddress2");
            IFID.ConnectComponent(IDEX, "pc+1", "pc+1");
            IFID.ConnectComponent(IDEX, "instr15_0", "instr15_0");
            IFID.ConnectComponent(IDEX, "instr5_0", "instr5_0");
            IFID.ConnectComponent(IDEX, "instr15_11", "instr15_11");
            IFID.ConnectComponent(IDEX, "instr20_16", "instr20_16");

            //ID
            controlUnit.ConnectComponent(jumpMUX, "jump", "select");
            controlUnit.ConnectComponent(IDEX, "memToReg", "memToReg");
            controlUnit.ConnectComponent(IDEX, "regWrite", "regWrite");
            controlUnit.ConnectComponent(IDEX, "memWrite", "memWrite");
            controlUnit.ConnectComponent(IDEX, "branch", "branch");
            controlUnit.ConnectComponent(IDEX, "ALUOp", "ALUOp");
            controlUnit.ConnectComponent(IDEX, "ALUSrc", "ALUSrc");
            controlUnit.ConnectComponent(IDEX, "regDst", "regDst");
            registerFile.ConnectComponent(IDEX, "readData1", "rd1");
            registerFile.ConnectComponent(IDEX, "readData2", "rd2");

            IDEX.ConnectComponent(EXMEM, "memToReg", "memToReg");
            IDEX.ConnectComponent(EXMEM, "regWrite", "regWrite");
            IDEX.ConnectComponent(EXMEM, "memWrite", "memWrite");
            IDEX.ConnectComponent(EXMEM, "branch", "branch");
            IDEX.ConnectComponent(EXMEM, "rd2", "rd2");
            IDEX.ConnectComponent(adderEX, "pc+1", "input0");
            IDEX.ConnectComponent(adderEX, "instr15_0", "input1");
            IDEX.ConnectComponent(alu, "rd1", "rd1");
            IDEX.ConnectComponent(aluMUX, "rd2", "input0");
            IDEX.ConnectComponent(aluMUX, "instr15_0", "input1");
            IDEX.ConnectComponent(aluMUX, "ALUSrc", "select");
            IDEX.ConnectComponent(aluCtrl, "ALUOp", "ALUOp");
            IDEX.ConnectComponent(aluCtrl, "instr5_0", "func");
            IDEX.ConnectComponent(regMUX, "instr20_16", "input0");
            IDEX.ConnectComponent(regMUX, "instr15_11", "input1");
            IDEX.ConnectComponent(regMUX, "regDst", "select");

            //EX
            adderEX.ConnectComponent(EXMEM, "output", "branchAddress");
            aluMUX.ConnectComponent(alu, "output", "rd2");
            aluCtrl.ConnectComponent(alu, "ALUCtrl", "ALUCtrl");
            alu.ConnectComponent(EXMEM, "zero", "zero");
            alu.ConnectComponent(EXMEM, "ALUResult", "ALUResult");
            regMUX.ConnectComponent(EXMEM, "output", "writeAddress");

            EXMEM.ConnectComponent(MEMWB, "memToReg", "memToReg");
            EXMEM.ConnectComponent(MEMWB, "regWrite", "regWrite");
            EXMEM.ConnectComponent(pcSrcMUX, "branchAddress", "input1");
            EXMEM.ConnectComponent(and, "branch", "input0");
            EXMEM.ConnectComponent(dataMemory, "memWrite", "memWrite");
            EXMEM.ConnectComponent(and, "zero", "input1");
            EXMEM.ConnectComponent(dataMemory, "ALUResult", "address");
            EXMEM.ConnectComponent(dataMemory, "rd2", "writeData");
            EXMEM.ConnectComponent(MEMWB, "ALUResult", "ALUResult");
            EXMEM.ConnectComponent(MEMWB, "writeAddress", "writeAddress");

            //MEM
            dataMemory.ConnectComponent(MEMWB, "readData", "readData");
            and.ConnectComponent(pcSrcMUX, "output", "select");

            MEMWB.ConnectComponent(registerFile, "regWrite", "regWrite");
            MEMWB.ConnectComponent(memMUX, "memToReg", "select");
            MEMWB.ConnectComponent(memMUX, "readData", "input1");
            MEMWB.ConnectComponent(memMUX, "ALUResult", "input0");
            MEMWB.ConnectComponent(registerFile, "writeAddress", "writeAddress");

            //WB
            memMUX.ConnectComponent(registerFile, "output", "writeData");

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clock.Increase();
         
            //////////////////// IF ///////////////////////
            pcSrcMUX.UpdateOutput();
            pcsrcMUXTextBox.Text = pcSrcMUX.PrintSignals();

            jumpMUX.UpdateOutput();
            JumpMUXTextBox.Text = jumpMUX.PrintSignals();

            pc.UpdateOutput();
            PCTextBox.Text = pc.PrintSignals();

            adderIF.UpdateOutput();
            PCAdderTextBox.Text = adderIF.PrintSignals();
            
            instructionMemory.UpdateOutput();
            InstructionMemoryTextBox.Text = instructionMemory.PrintSignals();

            IFID.UpdateOutput();
            IFIDTextBox.Text = IFID.PrintSignals();
            instruction5Label.Text = instruction4Label.Text;
            instruction4Label.Text = instruction3Label.Text;
            instruction3Label.Text = instruction2Label.Text;
            instruction2Label.Text = instruction1Label.Text;
            instruction1Label.Text = instructionMemory.GetCurrentInstruction();
            ///////////////////// ID ////////////////////////
            
            controlUnit.UpdateOutput();
            MainControlTextBox.Text = controlUnit.PrintSignals();

            registerFile.UpdateOutput();
            RegisterFileTextBox.Text = registerFile.PrintSignals();
            RegisterFileTextBox2.Text = registerFile.memoryToString();

            IDEX.UpdateOutput();
            IDEXTextBox.Text = IDEX.PrintSignals();

            ///////////////////// EX ////////////////////////
            adderEX.UpdateOutput();
            BranchAddressTextBox.Text = adderEX.PrintSignals();

            aluMUX.UpdateOutput();
            ALUSrcMUXTextBox.Text= aluMUX.PrintSignals();

            aluCtrl.UpdateOutput();
            ALUControlTextBox.Text = aluCtrl.PrintSignals();

            alu.UpdateOutput();
            ALUTextBox.Text= alu.PrintSignals();

            regMUX.UpdateOutput();
            RegDstMUXTextBox.Text = regMUX.PrintSignals();

            EXMEM.UpdateOutput();
            EXMEMTextBox.Text= EXMEM.PrintSignals();

            ////////////////////// MEM ///////////////////////
            and.UpdateOutput();
            BranchTextBox.Text= and.PrintSignals();
            
            dataMemory.UpdateOutput();
            DataMemoryTextBox.Text= dataMemory.PrintSignals();
            DataMemoryTextBox2.Text = dataMemory.memoryToString();

            // we need to update IF MUXes for branch command
            pcSrcMUX.UpdateOutput();
            pcsrcMUXTextBox.Text = pcSrcMUX.PrintSignals();

            jumpMUX.UpdateOutput();
            JumpMUXTextBox.Text = jumpMUX.PrintSignals();

            MEMWB.UpdateOutput();
            MEMWBTextBox.Text= MEMWB.PrintSignals();

            ////////////////////// WB /////////////////////////
            memMUX.UpdateOutput();
            MemtoRegTextBox.Text= memMUX.PrintSignals();
            registerFile.WriteToRegisterFile();
            RegisterFileTextBox2.Text = registerFile.memoryToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void InstructionsButton_Click(object sender, EventArgs e)
        {
            pcSrcMUX.ResetComponent();
            jumpMUX.ResetComponent();
            pc.ResetComponent();
            adderEX.ResetComponent();
            adderIF.ResetComponent();
            instructionMemory.ResetComponent();
            instructionMemory.SetMemory(InsertInstructionsTextBox.Text);
            IFID.ResetComponent();
            
            controlUnit.ResetComponent();
            registerFile.ResetComponent();
            registerFile.SetMemory(InsertRegisterFileTextBox.Text);
            IDEX.ResetComponent();

            adderEX.ResetComponent();
            alu.ResetComponent();
            aluMUX.ResetComponent();
            aluCtrl.ResetComponent();
            regMUX.ResetComponent();
            EXMEM.ResetComponent();

            and.ResetComponent();
            dataMemory.ResetComponent();
            dataMemory.SetMemory(InsertDataMemoryTextBox.Text);
            MEMWB.ResetComponent();

            memMUX.ResetComponent();

            IFID.InPorts["instr31_26"] = -1;
            IFID.BufferSignals["instr31_26"] = -1;
            IFID.OutPorts["instr31_26"] = -1;

            //InstructionMemoryTextBox2.Text = instructionMemory.memoryToString();
            //DataMemoryTextBox2.Text = dataMemory.memoryToString();
            //RegisterFileTextBox2.Text = registerFile.memoryToString();

            pcsrcMUXTextBox.Text = pcSrcMUX.PrintSignals();
            JumpMUXTextBox.Text = jumpMUX.PrintSignals();
            PCTextBox.Text = pc.PrintSignals();
            PCAdderTextBox.Text = adderIF.PrintSignals();
            InstructionMemoryTextBox.Text = instructionMemory.PrintSignals();
            InstructionMemoryTextBox2.Text = instructionMemory.memoryToString();
            IFIDTextBox.Text = IFID.PrintSignals();
            ///////////////////// ID ////////////////////////
            MainControlTextBox.Text = controlUnit.PrintSignals();
            RegisterFileTextBox.Text = registerFile.PrintSignals();
            RegisterFileTextBox2.Text = registerFile.memoryToString();
            IDEXTextBox.Text = IDEX.PrintSignals();
            ///////////////////// EX ////////////////////////
            BranchAddressTextBox.Text = adderEX.PrintSignals();
            ALUSrcMUXTextBox.Text = aluMUX.PrintSignals();
            ALUControlTextBox.Text = aluCtrl.PrintSignals();
            ALUTextBox.Text = alu.PrintSignals();
            RegDstMUXTextBox.Text = regMUX.PrintSignals();
            EXMEMTextBox.Text = EXMEM.PrintSignals();
            ////////////////////// MEM ///////////////////////
            BranchTextBox.Text = and.PrintSignals();
            DataMemoryTextBox.Text = dataMemory.PrintSignals();
            DataMemoryTextBox2.Text = dataMemory.memoryToString();
            MEMWBTextBox.Text = MEMWB.PrintSignals();
            ////////////////////// WB /////////////////////////
            MemtoRegTextBox.Text = memMUX.PrintSignals();
            registerFile.WriteToRegisterFile();
            RegisterFileTextBox2.Text = registerFile.memoryToString();

            instruction1Label.Text = "";
            instruction2Label.Text = "";
            instruction3Label.Text = "";
            instruction4Label.Text = "";
            instruction5Label.Text = "";
        }
    }
}
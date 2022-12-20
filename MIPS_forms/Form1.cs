using MIPS_forms.Components;
using MIPS_forms.Utils;

namespace MIPS_forms
{
    public partial class Form1 : Form
    {
        Mux2_1 dummyMUX = new Mux2_1("select", 0);

        Clock clock = new Clock();
        Mux2_1 pcSrcMUX = new Mux2_1("select", 1);
        Mux2_1 jumpMUX = new Mux2_1("select", 0);
        PC pc;
        InstructionMemory instructionMemory = new InstructionMemory();
        Adder adderIF = new Adder("input0", 1);
        RegisterWall IFID;
        public Form1()
        {
            InitializeComponent();
            dummyMUX.SetPredefinedInput("input1", -100);

            //instrucion fetch components
            pc = new PC(clock);
            IFID = new RegisterWall(clock);

            
            //connecting components
            pcSrcMUX.ConnectComponent(jumpMUX, "output", "input0");
            jumpMUX.ConnectComponent(pc, "output", "input");
            pc.ConnectComponent(adderIF, "output", "input1");
            pc.ConnectComponent(instructionMemory, "output", "pc_in");
            IFID.ConnectComponent(jumpMUX, "pc+1", "input0");
            IFID.ConnectComponent(pcSrcMUX, "pc+1", "input1");
            IFID.ConnectComponent(dummyMUX, "instruction", "input0");
            adderIF.ConnectComponent(pcSrcMUX, "output", "input0");
            adderIF.ConnectComponent(IFID, "output", "pc+1");
            instructionMemory.ConnectComponent(IFID, "pc_out", "instruction");
            pcSrcMUX.UpdateOutput();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clock.Increase();
            pcSrcMUX.UpdateOutput();
            jumpMUX.UpdateOutput();
            pc.UpdateOutput();
            adderIF.UpdateOutput();
            instructionMemory.UpdateOutput();
            IFID.UpdateOutput();
            dummyMUX.UpdateOutput();
            richTextBox1.Text = dummyMUX.OutPorts["output"].ToString();
        }
    }
}
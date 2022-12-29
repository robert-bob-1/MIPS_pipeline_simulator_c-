namespace MIPS_forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcsrcMUXTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.JumpMUXTextBox = new System.Windows.Forms.RichTextBox();
            this.PCTextBox = new System.Windows.Forms.RichTextBox();
            this.InstructionMemoryTextBox = new System.Windows.Forms.RichTextBox();
            this.IFIDTextBox = new System.Windows.Forms.RichTextBox();
            this.MainControlTextBox = new System.Windows.Forms.RichTextBox();
            this.RegisterFileTextBox = new System.Windows.Forms.RichTextBox();
            this.IDEXTextBox = new System.Windows.Forms.RichTextBox();
            this.EXMEMTextBox = new System.Windows.Forms.RichTextBox();
            this.BranchAddressTextBox = new System.Windows.Forms.RichTextBox();
            this.ALUTextBox = new System.Windows.Forms.RichTextBox();
            this.ALUControlTextBox = new System.Windows.Forms.RichTextBox();
            this.ALUSrcMUXTextBox = new System.Windows.Forms.RichTextBox();
            this.RegDstMUXTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.DataMemoryTextBox = new System.Windows.Forms.RichTextBox();
            this.MEMWBTextBox = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.BranchTextBox = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.MemtoRegTextBox = new System.Windows.Forms.RichTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.PCAdderTextBox = new System.Windows.Forms.RichTextBox();
            this.InstructionMemoryTextBox2 = new System.Windows.Forms.RichTextBox();
            this.RegisterFileTextBox2 = new System.Windows.Forms.RichTextBox();
            this.DataMemoryTextBox2 = new System.Windows.Forms.RichTextBox();
            this.instruction1Label = new System.Windows.Forms.Label();
            this.instruction2Label = new System.Windows.Forms.Label();
            this.instruction3Label = new System.Windows.Forms.Label();
            this.instruction4Label = new System.Windows.Forms.Label();
            this.instruction5Label = new System.Windows.Forms.Label();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.InsertInstructionsTextBox = new System.Windows.Forms.RichTextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.InsertRegisterFileTextBox = new System.Windows.Forms.RichTextBox();
            this.InsertDataMemoryTextBox = new System.Windows.Forms.RichTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pcsrcMUXTextBox
            // 
            this.pcsrcMUXTextBox.Location = new System.Drawing.Point(215, 49);
            this.pcsrcMUXTextBox.Name = "pcsrcMUXTextBox";
            this.pcsrcMUXTextBox.Size = new System.Drawing.Size(79, 83);
            this.pcsrcMUXTextBox.TabIndex = 0;
            this.pcsrcMUXTextBox.Text = "";
            this.pcsrcMUXTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Increase Clock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // JumpMUXTextBox
            // 
            this.JumpMUXTextBox.Location = new System.Drawing.Point(236, 153);
            this.JumpMUXTextBox.Name = "JumpMUXTextBox";
            this.JumpMUXTextBox.Size = new System.Drawing.Size(85, 84);
            this.JumpMUXTextBox.TabIndex = 2;
            this.JumpMUXTextBox.Text = "";
            // 
            // PCTextBox
            // 
            this.PCTextBox.Location = new System.Drawing.Point(236, 281);
            this.PCTextBox.Name = "PCTextBox";
            this.PCTextBox.Size = new System.Drawing.Size(85, 60);
            this.PCTextBox.TabIndex = 3;
            this.PCTextBox.Text = "";
            // 
            // InstructionMemoryTextBox
            // 
            this.InstructionMemoryTextBox.Location = new System.Drawing.Point(340, 240);
            this.InstructionMemoryTextBox.Name = "InstructionMemoryTextBox";
            this.InstructionMemoryTextBox.Size = new System.Drawing.Size(130, 185);
            this.InstructionMemoryTextBox.TabIndex = 4;
            this.InstructionMemoryTextBox.Text = "";
            // 
            // IFIDTextBox
            // 
            this.IFIDTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.IFIDTextBox.Location = new System.Drawing.Point(491, 75);
            this.IFIDTextBox.Name = "IFIDTextBox";
            this.IFIDTextBox.Size = new System.Drawing.Size(112, 459);
            this.IFIDTextBox.TabIndex = 5;
            this.IFIDTextBox.Text = "";
            // 
            // MainControlTextBox
            // 
            this.MainControlTextBox.Location = new System.Drawing.Point(623, 66);
            this.MainControlTextBox.Name = "MainControlTextBox";
            this.MainControlTextBox.Size = new System.Drawing.Size(111, 131);
            this.MainControlTextBox.TabIndex = 6;
            this.MainControlTextBox.Text = "";
            // 
            // RegisterFileTextBox
            // 
            this.RegisterFileTextBox.Location = new System.Drawing.Point(623, 234);
            this.RegisterFileTextBox.Name = "RegisterFileTextBox";
            this.RegisterFileTextBox.Size = new System.Drawing.Size(111, 173);
            this.RegisterFileTextBox.TabIndex = 7;
            this.RegisterFileTextBox.Text = "";
            // 
            // IDEXTextBox
            // 
            this.IDEXTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.IDEXTextBox.Location = new System.Drawing.Point(767, 75);
            this.IDEXTextBox.Name = "IDEXTextBox";
            this.IDEXTextBox.Size = new System.Drawing.Size(109, 459);
            this.IDEXTextBox.TabIndex = 8;
            this.IDEXTextBox.Text = "";
            // 
            // EXMEMTextBox
            // 
            this.EXMEMTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.EXMEMTextBox.Location = new System.Drawing.Point(1120, 75);
            this.EXMEMTextBox.Name = "EXMEMTextBox";
            this.EXMEMTextBox.Size = new System.Drawing.Size(106, 459);
            this.EXMEMTextBox.TabIndex = 9;
            this.EXMEMTextBox.Text = "";
            // 
            // BranchAddressTextBox
            // 
            this.BranchAddressTextBox.Location = new System.Drawing.Point(995, 98);
            this.BranchAddressTextBox.Name = "BranchAddressTextBox";
            this.BranchAddressTextBox.Size = new System.Drawing.Size(110, 66);
            this.BranchAddressTextBox.TabIndex = 10;
            this.BranchAddressTextBox.Text = "";
            // 
            // ALUTextBox
            // 
            this.ALUTextBox.Location = new System.Drawing.Point(1004, 204);
            this.ALUTextBox.Name = "ALUTextBox";
            this.ALUTextBox.Size = new System.Drawing.Size(110, 102);
            this.ALUTextBox.TabIndex = 11;
            this.ALUTextBox.Text = "";
            // 
            // ALUControlTextBox
            // 
            this.ALUControlTextBox.Location = new System.Drawing.Point(1004, 364);
            this.ALUControlTextBox.Name = "ALUControlTextBox";
            this.ALUControlTextBox.Size = new System.Drawing.Size(102, 104);
            this.ALUControlTextBox.TabIndex = 12;
            this.ALUControlTextBox.Text = "";
            // 
            // ALUSrcMUXTextBox
            // 
            this.ALUSrcMUXTextBox.Location = new System.Drawing.Point(906, 206);
            this.ALUSrcMUXTextBox.Name = "ALUSrcMUXTextBox";
            this.ALUSrcMUXTextBox.Size = new System.Drawing.Size(93, 105);
            this.ALUSrcMUXTextBox.TabIndex = 13;
            this.ALUSrcMUXTextBox.Text = "";
            // 
            // RegDstMUXTextBox
            // 
            this.RegDstMUXTextBox.Location = new System.Drawing.Point(906, 417);
            this.RegDstMUXTextBox.Name = "RegDstMUXTextBox";
            this.RegDstMUXTextBox.Size = new System.Drawing.Size(93, 135);
            this.RegDstMUXTextBox.TabIndex = 14;
            this.RegDstMUXTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "PCSrc MUX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Jump MUX";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "PC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Instruction Memory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "IF/ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(639, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Main Control";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(646, 216);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Register File";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(804, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "ID/EX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(904, 188);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "ALUSrc MUX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(906, 400);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "RegDst MUX";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(981, 81);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "BranchAddress Adder";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1032, 186);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "ALU";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1018, 346);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "ALU Control";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1146, 57);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 15);
            this.label15.TabIndex = 29;
            this.label15.Text = "EX/MEM";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1245, 186);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 15);
            this.label16.TabIndex = 31;
            this.label16.Text = "Data Memory";
            // 
            // DataMemoryTextBox
            // 
            this.DataMemoryTextBox.Location = new System.Drawing.Point(1245, 204);
            this.DataMemoryTextBox.Name = "DataMemoryTextBox";
            this.DataMemoryTextBox.Size = new System.Drawing.Size(103, 189);
            this.DataMemoryTextBox.TabIndex = 30;
            this.DataMemoryTextBox.Text = "";
            // 
            // MEMWBTextBox
            // 
            this.MEMWBTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MEMWBTextBox.Location = new System.Drawing.Point(1370, 75);
            this.MEMWBTextBox.Name = "MEMWBTextBox";
            this.MEMWBTextBox.Size = new System.Drawing.Size(112, 436);
            this.MEMWBTextBox.TabIndex = 32;
            this.MEMWBTextBox.Text = "";
            this.MEMWBTextBox.TextChanged += new System.EventHandler(this.richTextBox15_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1252, 87);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 15);
            this.label14.TabIndex = 34;
            this.label14.Text = "Branch And";
            // 
            // BranchTextBox
            // 
            this.BranchTextBox.Location = new System.Drawing.Point(1245, 105);
            this.BranchTextBox.Name = "BranchTextBox";
            this.BranchTextBox.Size = new System.Drawing.Size(103, 74);
            this.BranchTextBox.TabIndex = 33;
            this.BranchTextBox.Text = "";
            this.BranchTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1392, 60);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 15);
            this.label17.TabIndex = 35;
            this.label17.Text = "MEM/WB";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1500, 237);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 15);
            this.label18.TabIndex = 37;
            this.label18.Text = "MemtoReg MUX";
            // 
            // MemtoRegTextBox
            // 
            this.MemtoRegTextBox.Location = new System.Drawing.Point(1500, 252);
            this.MemtoRegTextBox.Name = "MemtoRegTextBox";
            this.MemtoRegTextBox.Size = new System.Drawing.Size(96, 89);
            this.MemtoRegTextBox.TabIndex = 36;
            this.MemtoRegTextBox.Text = "";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(375, 86);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 15);
            this.label19.TabIndex = 39;
            this.label19.Text = "PC Adder";
            // 
            // PCAdderTextBox
            // 
            this.PCAdderTextBox.Location = new System.Drawing.Point(361, 104);
            this.PCAdderTextBox.Name = "PCAdderTextBox";
            this.PCAdderTextBox.Size = new System.Drawing.Size(86, 93);
            this.PCAdderTextBox.TabIndex = 38;
            this.PCAdderTextBox.Text = "";
            // 
            // InstructionMemoryTextBox2
            // 
            this.InstructionMemoryTextBox2.Location = new System.Drawing.Point(340, 431);
            this.InstructionMemoryTextBox2.Name = "InstructionMemoryTextBox2";
            this.InstructionMemoryTextBox2.Size = new System.Drawing.Size(130, 140);
            this.InstructionMemoryTextBox2.TabIndex = 40;
            this.InstructionMemoryTextBox2.Text = "";
            // 
            // RegisterFileTextBox2
            // 
            this.RegisterFileTextBox2.Location = new System.Drawing.Point(623, 411);
            this.RegisterFileTextBox2.Name = "RegisterFileTextBox2";
            this.RegisterFileTextBox2.Size = new System.Drawing.Size(111, 160);
            this.RegisterFileTextBox2.TabIndex = 41;
            this.RegisterFileTextBox2.Text = "";
            // 
            // DataMemoryTextBox2
            // 
            this.DataMemoryTextBox2.Location = new System.Drawing.Point(1245, 399);
            this.DataMemoryTextBox2.Name = "DataMemoryTextBox2";
            this.DataMemoryTextBox2.Size = new System.Drawing.Size(103, 172);
            this.DataMemoryTextBox2.TabIndex = 42;
            this.DataMemoryTextBox2.Text = "";
            // 
            // instruction1Label
            // 
            this.instruction1Label.AutoSize = true;
            this.instruction1Label.Location = new System.Drawing.Point(362, 17);
            this.instruction1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instruction1Label.Name = "instruction1Label";
            this.instruction1Label.Size = new System.Drawing.Size(70, 15);
            this.instruction1Label.TabIndex = 43;
            this.instruction1Label.Text = "instruction1";
            // 
            // instruction2Label
            // 
            this.instruction2Label.AutoSize = true;
            this.instruction2Label.Location = new System.Drawing.Point(646, 17);
            this.instruction2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instruction2Label.Name = "instruction2Label";
            this.instruction2Label.Size = new System.Drawing.Size(70, 15);
            this.instruction2Label.TabIndex = 44;
            this.instruction2Label.Text = "instruction2";
            // 
            // instruction3Label
            // 
            this.instruction3Label.AutoSize = true;
            this.instruction3Label.Location = new System.Drawing.Point(970, 17);
            this.instruction3Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instruction3Label.Name = "instruction3Label";
            this.instruction3Label.Size = new System.Drawing.Size(70, 15);
            this.instruction3Label.TabIndex = 45;
            this.instruction3Label.Text = "instruction3";
            // 
            // instruction4Label
            // 
            this.instruction4Label.AutoSize = true;
            this.instruction4Label.Location = new System.Drawing.Point(1263, 17);
            this.instruction4Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instruction4Label.Name = "instruction4Label";
            this.instruction4Label.Size = new System.Drawing.Size(70, 15);
            this.instruction4Label.TabIndex = 46;
            this.instruction4Label.Text = "instruction4";
            // 
            // instruction5Label
            // 
            this.instruction5Label.AutoSize = true;
            this.instruction5Label.Location = new System.Drawing.Point(1514, 17);
            this.instruction5Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instruction5Label.Name = "instruction5Label";
            this.instruction5Label.Size = new System.Drawing.Size(70, 15);
            this.instruction5Label.TabIndex = 47;
            this.instruction5Label.Text = "instruction5";
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.Location = new System.Drawing.Point(23, 28);
            this.InstructionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(69, 15);
            this.InstructionsLabel.TabIndex = 49;
            this.InstructionsLabel.Text = "Instructions";
            // 
            // InsertInstructionsTextBox
            // 
            this.InsertInstructionsTextBox.Location = new System.Drawing.Point(23, 46);
            this.InsertInstructionsTextBox.Name = "InsertInstructionsTextBox";
            this.InsertInstructionsTextBox.Size = new System.Drawing.Size(126, 465);
            this.InsertInstructionsTextBox.TabIndex = 48;
            this.InsertInstructionsTextBox.Text = "";
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(186, 744);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(126, 44);
            this.LoadButton.TabIndex = 50;
            this.LoadButton.Text = "Load instructions and reset program";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.InstructionsButton_Click);
            // 
            // InsertRegisterFileTextBox
            // 
            this.InsertRegisterFileTextBox.Location = new System.Drawing.Point(23, 541);
            this.InsertRegisterFileTextBox.Name = "InsertRegisterFileTextBox";
            this.InsertRegisterFileTextBox.Size = new System.Drawing.Size(126, 113);
            this.InsertRegisterFileTextBox.TabIndex = 51;
            this.InsertRegisterFileTextBox.Text = "";
            // 
            // InsertDataMemoryTextBox
            // 
            this.InsertDataMemoryTextBox.Location = new System.Drawing.Point(23, 675);
            this.InsertDataMemoryTextBox.Name = "InsertDataMemoryTextBox";
            this.InsertDataMemoryTextBox.Size = new System.Drawing.Size(126, 113);
            this.InsertDataMemoryTextBox.TabIndex = 52;
            this.InsertDataMemoryTextBox.Text = "";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(23, 523);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(245, 15);
            this.label20.TabIndex = 53;
            this.label20.Text = "Register File Memory (separated by newlines)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(23, 657);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 15);
            this.label21.TabIndex = 54;
            this.label21.Text = "Data Memory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1622, 870);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.InsertDataMemoryTextBox);
            this.Controls.Add(this.InsertRegisterFileTextBox);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.InsertInstructionsTextBox);
            this.Controls.Add(this.instruction5Label);
            this.Controls.Add(this.instruction4Label);
            this.Controls.Add(this.instruction3Label);
            this.Controls.Add(this.instruction2Label);
            this.Controls.Add(this.instruction1Label);
            this.Controls.Add(this.DataMemoryTextBox2);
            this.Controls.Add(this.RegisterFileTextBox2);
            this.Controls.Add(this.InstructionMemoryTextBox2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.PCAdderTextBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.MemtoRegTextBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BranchTextBox);
            this.Controls.Add(this.MEMWBTextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.DataMemoryTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegDstMUXTextBox);
            this.Controls.Add(this.ALUSrcMUXTextBox);
            this.Controls.Add(this.ALUControlTextBox);
            this.Controls.Add(this.ALUTextBox);
            this.Controls.Add(this.BranchAddressTextBox);
            this.Controls.Add(this.EXMEMTextBox);
            this.Controls.Add(this.IDEXTextBox);
            this.Controls.Add(this.RegisterFileTextBox);
            this.Controls.Add(this.MainControlTextBox);
            this.Controls.Add(this.IFIDTextBox);
            this.Controls.Add(this.InstructionMemoryTextBox);
            this.Controls.Add(this.PCTextBox);
            this.Controls.Add(this.JumpMUXTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pcsrcMUXTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox pcsrcMUXTextBox;
        private Button button1;
        private RichTextBox JumpMUXTextBox;
        private RichTextBox PCTextBox;
        private RichTextBox InstructionMemoryTextBox;
        private RichTextBox IFIDTextBox;
        private RichTextBox MainControlTextBox;
        private RichTextBox RegisterFileTextBox;
        private RichTextBox IDEXTextBox;
        private RichTextBox EXMEMTextBox;
        private RichTextBox BranchAddressTextBox;
        private RichTextBox ALUTextBox;
        private RichTextBox ALUControlTextBox;
        private RichTextBox ALUSrcMUXTextBox;
        private RichTextBox RegDstMUXTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label15;
        private Label label16;
        private RichTextBox DataMemoryTextBox;
        private RichTextBox MEMWBTextBox;
        private Label label14;
        private RichTextBox BranchTextBox;
        private Label label17;
        private Label label18;
        private RichTextBox MemtoRegTextBox;
        private Label label19;
        private RichTextBox PCAdderTextBox;
        private RichTextBox InstructionMemoryTextBox2;
        private RichTextBox RegisterFileTextBox2;
        private RichTextBox DataMemoryTextBox2;
        private Label instruction1Label;
        private Label instruction2Label;
        private Label instruction3Label;
        private Label instruction4Label;
        private Label instruction5Label;
        private Label InstructionsLabel;
        private RichTextBox InsertInstructionsTextBox;
        private Button LoadButton;
        private RichTextBox InsertRegisterFileTextBox;
        private RichTextBox InsertDataMemoryTextBox;
        private Label label20;
        private Label label21;
    }
}
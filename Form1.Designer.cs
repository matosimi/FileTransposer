namespace FileTransposer
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
            components = new System.ComponentModel.Container();
            buttonOpen = new Button();
            textBoxOriginal = new TextBox();
            textBoxTransposed = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            buttonTranspose = new Button();
            numericUpDownTranspose = new NumericUpDown();
            buttonCut = new Button();
            numericUpDownCut = new NumericUpDown();
            textBoxLog = new TextBox();
            textBoxChars = new TextBox();
            buttonSave = new Button();
            toolTip1 = new ToolTip(components);
            radioButtonMads = new RadioButton();
            radioButtonMemDump = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTranspose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCut).BeginInit();
            SuspendLayout();
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(12, 12);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(75, 23);
            buttonOpen.TabIndex = 0;
            buttonOpen.Text = "Open";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += ButtonOpen_Click;
            // 
            // textBoxOriginal
            // 
            textBoxOriginal.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOriginal.Location = new Point(12, 215);
            textBoxOriginal.Multiline = true;
            textBoxOriginal.Name = "textBoxOriginal";
            textBoxOriginal.ScrollBars = ScrollBars.Both;
            textBoxOriginal.Size = new Size(279, 356);
            textBoxOriginal.TabIndex = 1;
            textBoxOriginal.WordWrap = false;
            // 
            // textBoxTransposed
            // 
            textBoxTransposed.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTransposed.Location = new Point(296, 15);
            textBoxTransposed.Multiline = true;
            textBoxTransposed.Name = "textBoxTransposed";
            textBoxTransposed.ScrollBars = RichTextBoxScrollBars.Both;
            textBoxTransposed.Size = new Size(791, 194);
            textBoxTransposed.TabIndex = 2;
            textBoxTransposed.WordWrap = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonTranspose
            // 
            buttonTranspose.Location = new Point(12, 110);
            buttonTranspose.Name = "buttonTranspose";
            buttonTranspose.Size = new Size(75, 23);
            buttonTranspose.TabIndex = 3;
            buttonTranspose.Text = "Transpose";
            buttonTranspose.UseVisualStyleBackColor = true;
            buttonTranspose.Click += ButtonTranspose_Click;
            // 
            // numericUpDownTranspose
            // 
            numericUpDownTranspose.Location = new Point(120, 110);
            numericUpDownTranspose.Name = "numericUpDownTranspose";
            numericUpDownTranspose.Size = new Size(68, 23);
            numericUpDownTranspose.TabIndex = 4;
            toolTip1.SetToolTip(numericUpDownTranspose, "number of groups");
            numericUpDownTranspose.Value = new decimal(new int[] { 9, 0, 0, 0 });
            // 
            // buttonCut
            // 
            buttonCut.Location = new Point(12, 81);
            buttonCut.Name = "buttonCut";
            buttonCut.Size = new Size(75, 23);
            buttonCut.TabIndex = 5;
            buttonCut.Text = "Cut";
            buttonCut.UseVisualStyleBackColor = true;
            buttonCut.Click += ButtonCut_Click;
            // 
            // numericUpDownCut
            // 
            numericUpDownCut.Location = new Point(120, 81);
            numericUpDownCut.Name = "numericUpDownCut";
            numericUpDownCut.Size = new Size(68, 23);
            numericUpDownCut.TabIndex = 6;
            toolTip1.SetToolTip(numericUpDownCut, "bytes to be cut from the beginning of the file");
            numericUpDownCut.Value = new decimal(new int[] { 81, 0, 0, 0 });
            // 
            // textBoxLog
            // 
            textBoxLog.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLog.Location = new Point(11, 139);
            textBoxLog.Multiline = true;
            textBoxLog.Name = "textBoxLog";
            textBoxLog.ScrollBars = ScrollBars.Both;
            textBoxLog.Size = new Size(279, 70);
            textBoxLog.TabIndex = 7;
            // 
            // textBoxChars
            // 
            textBoxChars.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxChars.Location = new Point(297, 215);
            textBoxChars.Multiline = true;
            textBoxChars.Name = "textBoxChars";
            textBoxChars.ScrollBars = ScrollBars.Both;
            textBoxChars.Size = new Size(466, 203);
            textBoxChars.TabIndex = 8;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(113, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // radioButtonMads
            // 
            radioButtonMads.AutoSize = true;
            radioButtonMads.Location = new Point(875, 224);
            radioButtonMads.Name = "radioButtonMads";
            radioButtonMads.Size = new Size(99, 19);
            radioButtonMads.TabIndex = 10;
            radioButtonMads.Text = "Output MADS";
            radioButtonMads.UseVisualStyleBackColor = true;
            // 
            // radioButtonMemDump
            // 
            radioButtonMemDump.AutoSize = true;
            radioButtonMemDump.Checked = true;
            radioButtonMemDump.Location = new Point(875, 249);
            radioButtonMemDump.Name = "radioButtonMemDump";
            radioButtonMemDump.Size = new Size(129, 19);
            radioButtonMemDump.TabIndex = 11;
            radioButtonMemDump.TabStop = true;
            radioButtonMemDump.Text = "Output mem dump";
            radioButtonMemDump.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 607);
            Controls.Add(radioButtonMemDump);
            Controls.Add(radioButtonMads);
            Controls.Add(buttonSave);
            Controls.Add(textBoxChars);
            Controls.Add(textBoxLog);
            Controls.Add(numericUpDownCut);
            Controls.Add(buttonCut);
            Controls.Add(numericUpDownTranspose);
            Controls.Add(buttonTranspose);
            Controls.Add(textBoxTransposed);
            Controls.Add(textBoxOriginal);
            Controls.Add(buttonOpen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownTranspose).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOpen;
        private TextBox textBoxOriginal;
        private RichTextBox textBoxTransposed;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button buttonTranspose;
        private NumericUpDown numericUpDownTranspose;
        private Button buttonCut;
        private NumericUpDown numericUpDownCut;
        private TextBox textBoxLog;
        private TextBox textBoxChars;
        private Button buttonSave;
        private ToolTip toolTip1;
        private RadioButton radioButtonMads;
        private RadioButton radioButtonMemDump;
    }
}
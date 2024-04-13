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
            numericUpDownBytesLine = new NumericUpDown();
            radioButtonMads = new RadioButton();
            radioButtonMemDump = new RadioButton();
            labelBytesPerLine = new Label();
            splitContainerVertical = new SplitContainer();
            splitContainerHorizontal = new SplitContainer();
            buttonReload = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTranspose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBytesLine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerVertical).BeginInit();
            splitContainerVertical.Panel1.SuspendLayout();
            splitContainerVertical.Panel2.SuspendLayout();
            splitContainerVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerHorizontal).BeginInit();
            splitContainerHorizontal.Panel1.SuspendLayout();
            splitContainerHorizontal.Panel2.SuspendLayout();
            splitContainerHorizontal.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(14, 12);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(75, 23);
            buttonOpen.TabIndex = 0;
            buttonOpen.Text = "Open";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += ButtonOpen_Click;
            // 
            // textBoxOriginal
            // 
            textBoxOriginal.Font = new Font("Consolas", 9F);
            textBoxOriginal.Location = new Point(14, 215);
            textBoxOriginal.Multiline = true;
            textBoxOriginal.Name = "textBoxOriginal";
            textBoxOriginal.ScrollBars = ScrollBars.Both;
            textBoxOriginal.Size = new Size(278, 356);
            textBoxOriginal.TabIndex = 1;
            textBoxOriginal.WordWrap = false;
            // 
            // textBoxTransposed
            // 
            textBoxTransposed.Dock = DockStyle.Fill;
            textBoxTransposed.Font = new Font("Consolas", 9F);
            textBoxTransposed.Location = new Point(0, 0);
            textBoxTransposed.Name = "textBoxTransposed";
            textBoxTransposed.Size = new Size(831, 363);
            textBoxTransposed.TabIndex = 2;
            textBoxTransposed.Text = "";
            textBoxTransposed.WordWrap = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonTranspose
            // 
            buttonTranspose.Location = new Point(14, 110);
            buttonTranspose.Name = "buttonTranspose";
            buttonTranspose.Size = new Size(75, 23);
            buttonTranspose.TabIndex = 3;
            buttonTranspose.Text = "Transpose";
            buttonTranspose.UseVisualStyleBackColor = true;
            buttonTranspose.Click += ButtonTranspose_Click;
            // 
            // numericUpDownTranspose
            // 
            numericUpDownTranspose.Location = new Point(122, 110);
            numericUpDownTranspose.Name = "numericUpDownTranspose";
            numericUpDownTranspose.Size = new Size(68, 23);
            numericUpDownTranspose.TabIndex = 4;
            toolTip1.SetToolTip(numericUpDownTranspose, "number of groups");
            numericUpDownTranspose.Value = new decimal(new int[] { 9, 0, 0, 0 });
            // 
            // buttonCut
            // 
            buttonCut.Location = new Point(14, 81);
            buttonCut.Name = "buttonCut";
            buttonCut.Size = new Size(75, 23);
            buttonCut.TabIndex = 5;
            buttonCut.Text = "Cut";
            buttonCut.UseVisualStyleBackColor = true;
            buttonCut.Click += ButtonCut_Click;
            // 
            // numericUpDownCut
            // 
            numericUpDownCut.Location = new Point(122, 81);
            numericUpDownCut.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownCut.Name = "numericUpDownCut";
            numericUpDownCut.Size = new Size(68, 23);
            numericUpDownCut.TabIndex = 6;
            toolTip1.SetToolTip(numericUpDownCut, "bytes to be cut from the beginning of the file");
            numericUpDownCut.Value = new decimal(new int[] { 81, 0, 0, 0 });
            // 
            // textBoxLog
            // 
            textBoxLog.Font = new Font("Consolas", 9F);
            textBoxLog.Location = new Point(13, 139);
            textBoxLog.Multiline = true;
            textBoxLog.Name = "textBoxLog";
            textBoxLog.ScrollBars = ScrollBars.Both;
            textBoxLog.Size = new Size(279, 70);
            textBoxLog.TabIndex = 7;
            // 
            // textBoxChars
            // 
            textBoxChars.Font = new Font("Consolas", 9F);
            textBoxChars.Location = new Point(3, 3);
            textBoxChars.Multiline = true;
            textBoxChars.Name = "textBoxChars";
            textBoxChars.ScrollBars = ScrollBars.Both;
            textBoxChars.Size = new Size(466, 203);
            textBoxChars.TabIndex = 8;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(115, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // numericUpDownBytesLine
            // 
            numericUpDownBytesLine.Location = new Point(725, 12);
            numericUpDownBytesLine.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownBytesLine.Name = "numericUpDownBytesLine";
            numericUpDownBytesLine.Size = new Size(68, 23);
            numericUpDownBytesLine.TabIndex = 12;
            toolTip1.SetToolTip(numericUpDownBytesLine, "bytes to be cut from the beginning of the file");
            numericUpDownBytesLine.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // radioButtonMads
            // 
            radioButtonMads.AutoSize = true;
            radioButtonMads.Location = new Point(475, 12);
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
            radioButtonMemDump.Location = new Point(475, 37);
            radioButtonMemDump.Name = "radioButtonMemDump";
            radioButtonMemDump.Size = new Size(129, 19);
            radioButtonMemDump.TabIndex = 11;
            radioButtonMemDump.TabStop = true;
            radioButtonMemDump.Text = "Output mem dump";
            radioButtonMemDump.UseVisualStyleBackColor = true;
            // 
            // labelBytesPerLine
            // 
            labelBytesPerLine.AutoSize = true;
            labelBytesPerLine.Location = new Point(639, 14);
            labelBytesPerLine.Name = "labelBytesPerLine";
            labelBytesPerLine.Size = new Size(80, 15);
            labelBytesPerLine.TabIndex = 13;
            labelBytesPerLine.Text = "Bytes Per Line";
            // 
            // splitContainerVertical
            // 
            splitContainerVertical.Dock = DockStyle.Fill;
            splitContainerVertical.FixedPanel = FixedPanel.Panel1;
            splitContainerVertical.Location = new Point(0, 0);
            splitContainerVertical.Name = "splitContainerVertical";
            // 
            // splitContainerVertical.Panel1
            // 
            splitContainerVertical.Panel1.Controls.Add(buttonReload);
            splitContainerVertical.Panel1.Controls.Add(buttonSave);
            splitContainerVertical.Panel1.Controls.Add(buttonOpen);
            splitContainerVertical.Panel1.Controls.Add(textBoxOriginal);
            splitContainerVertical.Panel1.Controls.Add(buttonTranspose);
            splitContainerVertical.Panel1.Controls.Add(numericUpDownTranspose);
            splitContainerVertical.Panel1.Controls.Add(buttonCut);
            splitContainerVertical.Panel1.Controls.Add(numericUpDownCut);
            splitContainerVertical.Panel1.Controls.Add(textBoxLog);
            // 
            // splitContainerVertical.Panel2
            // 
            splitContainerVertical.Panel2.Controls.Add(splitContainerHorizontal);
            splitContainerVertical.Size = new Size(1137, 583);
            splitContainerVertical.SplitterDistance = 302;
            splitContainerVertical.TabIndex = 15;
            // 
            // splitContainerHorizontal
            // 
            splitContainerHorizontal.Dock = DockStyle.Fill;
            splitContainerHorizontal.FixedPanel = FixedPanel.Panel2;
            splitContainerHorizontal.Location = new Point(0, 0);
            splitContainerHorizontal.Name = "splitContainerHorizontal";
            splitContainerHorizontal.Orientation = Orientation.Horizontal;
            // 
            // splitContainerHorizontal.Panel1
            // 
            splitContainerHorizontal.Panel1.Controls.Add(textBoxTransposed);
            // 
            // splitContainerHorizontal.Panel2
            // 
            splitContainerHorizontal.Panel2.Controls.Add(textBoxChars);
            splitContainerHorizontal.Panel2.Controls.Add(labelBytesPerLine);
            splitContainerHorizontal.Panel2.Controls.Add(radioButtonMads);
            splitContainerHorizontal.Panel2.Controls.Add(numericUpDownBytesLine);
            splitContainerHorizontal.Panel2.Controls.Add(radioButtonMemDump);
            splitContainerHorizontal.Size = new Size(831, 583);
            splitContainerHorizontal.SplitterDistance = 363;
            splitContainerHorizontal.TabIndex = 0;
            // 
            // buttonReload
            // 
            buttonReload.Location = new Point(13, 41);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(75, 23);
            buttonReload.TabIndex = 10;
            buttonReload.Text = "Reload";
            buttonReload.UseVisualStyleBackColor = true;
            buttonReload.Click += buttonReload_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 583);
            Controls.Add(splitContainerVertical);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownTranspose).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCut).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBytesLine).EndInit();
            splitContainerVertical.Panel1.ResumeLayout(false);
            splitContainerVertical.Panel1.PerformLayout();
            splitContainerVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerVertical).EndInit();
            splitContainerVertical.ResumeLayout(false);
            splitContainerHorizontal.Panel1.ResumeLayout(false);
            splitContainerHorizontal.Panel2.ResumeLayout(false);
            splitContainerHorizontal.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerHorizontal).EndInit();
            splitContainerHorizontal.ResumeLayout(false);
            ResumeLayout(false);
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
        private NumericUpDown numericUpDownBytesLine;
        private Label labelBytesPerLine;
        private TableLayoutPanel tableLayoutPanel1;
        private SplitContainer splitContainerVertical;
        private SplitContainer splitContainerHorizontal;
        private Button buttonReload;
    }
}
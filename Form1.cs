using System.Globalization;
using System.Text;

namespace FileTransposer
{
    public partial class Form1 : Form
    {
        private static byte[] data = { };
        private static byte[] transposedData;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "noFile";
            UpdateTitle();
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                data = File.ReadAllBytes(openFileDialog1.FileName);
                PrintOriginal();
                UpdateTitle();
            }
        }

        private void PrintOriginal()
        {
            int count = 0;
            string hexdata = Convert.ToHexString(data);
            string output = "";
            textBoxChars.Text = Encoding.ASCII.GetString(data);
            for (int line = 0; line < hexdata.Length / 16; line++)
            {
                /* byte[] bytes = new byte[16];
                 try
                 {
                     Array.Copy(data, line * 16, bytes, 0, 16);
                 }
                 catch (Exception ex)
                 {
                     textBoxLog.Text = ex.Message;
                 }
                */
                string hexspace = hexdata.Substring(line * 16, 16);
                // string chars = Encoding.ASCII.GetString(bytes);
                for (int i = 2; i < hexspace.Length; i += 2)
                    hexspace = hexspace.Insert(i++, " ");

                output += $"{(line * 8):X4}: {hexspace}" + Environment.NewLine;
            }
            textBoxOriginal.Text = output;
        }

        private void UpdateTitle()
        {
            this.Text = $"FileTransposer 0.2 by MatoSimi 13.4.2024 - {openFileDialog1.FileName} - {data.Length}(${data.Length:X4}) bytes";
        }

        private void ButtonCut_Click(object sender, EventArgs e)
        {
            byte[] newdata = new byte[data.Length - (int)numericUpDownCut.Value];
            Array.Copy(data, (int)numericUpDownCut.Value, newdata, 0, newdata.Length);
            data = newdata;
            PrintOriginal();
            UpdateTitle();
        }

        private void ButtonTranspose_Click(object sender, EventArgs e)
        {
            textBoxTransposed.Text = "";
            int frameSize = (int)numericUpDownTranspose.Value;
            int frameCount = data.Length / frameSize;
            string[] output = new string[frameSize];
            int index = 0;
            int overdrive = 0;
            transposedData = new byte[data.Length];
            while (index < data.Length)
            {
                for (int line = 0; line < frameSize; line++)
                    if (index + line < data.Length)
                    {
                        output[line] += $"${data[index + line]:X2} ";
                    }
                    else
                    {
                        output[line] += "XX ";
                        overdrive++;
                    }
                index += frameSize;
            }

            for (int i = 0; i < data.Length; i++)
                transposedData[(i % frameSize) * frameCount + i / frameSize] = data[i];

            textBoxLog.Text = $"{(int)(data.Length / frameSize)} frames, {overdrive} bytes orphaned";
            int length = 0;
            for (int line = 0; line < frameSize; line++)
            {
                if (radioButtonMemDump.Checked)
                {
                    textBoxTransposed.Text += $"{length:X4}: {output[line]}{Environment.NewLine}";
                }
                else
                {
                    int bytesPerLine = (int)numericUpDownBytesLine.Value;
                    for (int j = 0; j < output[line].Length / bytesPerLine / 4; j++)
                    {
                        if (j == 0)
                            textBoxTransposed.Text += $"group{line}\tdta {output[line].Substring(0, bytesPerLine * 4 - 1).Replace(' ', ',')}{Environment.NewLine}";
                        else
                            textBoxTransposed.Text += $"\tdta {output[line].Substring(j * bytesPerLine * 4, bytesPerLine * 4 - 1).Replace(' ', ',')}" + (j == 0 ? $"\t;{length:X4}" : "") + $"{Environment.NewLine}";
                    }
                }
                length += (int)(data.Length / frameSize);
            }

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveFileDialog1.FileName, transposedData);
                textBoxLog.Text = $"File {saveFileDialog1.FileName} saved.";
            }
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName != "noFile")
            {
                data = File.ReadAllBytes(openFileDialog1.FileName);
                PrintOriginal();
                UpdateTitle();
            }
        }
    }
}


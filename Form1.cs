using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Text;

namespace Prismo_Client
{
    public partial class Form1 : Form
    {

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font adventureTimeFont;
        Font fromWhereYouAreFont;
        Font fromWhereYouAreSmallFont;

        public Form1()
        {
            InitializeComponent();
            comboBoxItemLogic.SelectedIndex = 1;
            comboBoxItemPool.SelectedIndex = 0;
            comboBoxNPCPool.SelectedIndex = 0;

            byte[] fontData1 = Properties.Resources.Adventure_Time_Logo;
            IntPtr fontPtr1 = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData1.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData1, 0, fontPtr1, fontData1.Length);
            uint dummy1 = 0;
            fonts.AddMemoryFont(fontPtr1, Properties.Resources.Adventure_Time_Logo.Length);
            AddFontMemResourceEx(fontPtr1, (uint)Properties.Resources.Adventure_Time_Logo.Length, IntPtr.Zero, ref dummy1);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr1);

            byte[] fontData2 = Properties.Resources.GLOBAL_FROMWHEREYOUARE_AT;
            IntPtr fontPtr2 = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData2.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData2, 0, fontPtr2, fontData2.Length);
            uint dummy2 = 0;
            fonts.AddMemoryFont(fontPtr2, Properties.Resources.GLOBAL_FROMWHEREYOUARE_AT.Length);
            AddFontMemResourceEx(fontPtr2, (uint)Properties.Resources.GLOBAL_FROMWHEREYOUARE_AT.Length, IntPtr.Zero, ref dummy2);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr2);

            adventureTimeFont = new Font(fonts.Families[0], 16.0F);
            fromWhereYouAreFont = new Font(fonts.Families[1], 8.0F);
            fromWhereYouAreSmallFont = new Font(fonts.Families[1], 6.0F);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelPrismo.Font = adventureTimeFont;
            labelATRando.Font = fromWhereYouAreFont;
            labelData.Font = fromWhereYouAreFont;
            labelSeed.Font = fromWhereYouAreFont;
            buttonData.Font = fromWhereYouAreSmallFont;
            labelItemLogic.Font = fromWhereYouAreFont;
            labelItemPool.Font = fromWhereYouAreFont;
            labelNPCPool.Font = fromWhereYouAreFont;
            comboBoxItemLogic.Font = fromWhereYouAreFont;
            comboBoxItemPool.Font = fromWhereYouAreFont;
            comboBoxNPCPool.Font = fromWhereYouAreFont;
            checkBoxCBM.Font = fromWhereYouAreFont;
            checkBoxLSP.Font = fromWhereYouAreFont;
            checkBoxNMC.Font = fromWhereYouAreFont;
            checkBoxSpoilerLog.Font = fromWhereYouAreFont;
            buttonRandom.Font = adventureTimeFont;

        }

        private void buttonData_Click_1(object sender, EventArgs e)
        {
            DialogResult resultData = folderBrowserDialogData.ShowDialog();
            if (resultData == DialogResult.OK)
                textBoxData.Text = folderBrowserDialogData.SelectedPath;
        }

        private void checkBoxItemRando_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxItemRando.CheckState is CheckState.Checked)
            {
                comboBoxItemLogic.Enabled = true;
                comboBoxItemPool.Enabled = true;
            }
            else
            {
                comboBoxItemLogic.Enabled = false;
                comboBoxItemPool.Enabled = false;
            }
        }

        private void checkBoxNPCRando_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNPCRando.CheckState is CheckState.Checked)
            {
                comboBoxNPCPool.Enabled = true;
            }
            else
            {
                comboBoxNPCPool.Enabled = false;
            }
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogData.SelectedPath == "")
            {
                MessageBox.Show("Error Occurred: No data path selected.", "Error");
                return;
            }
            string launchParameters = "-f " + folderBrowserDialogData.SelectedPath;
            if (textBoxSeed.Text != "")
            {
                launchParameters += (" -s " + textBoxSeed.Text);
            }
            if (checkBoxItemRando.CheckState is CheckState.Checked)
            {
                launchParameters += comboBoxItemPool.SelectedIndex == 0 ? " -sir" : " -eir";
            }
            else
            {
                launchParameters += " -nir";
            }
            launchParameters += comboBoxItemLogic.SelectedIndex == 0 ? " -nl" : " -sl";
            if (checkBoxNPCRando.CheckState is CheckState.Checked)
            {
                launchParameters += comboBoxNPCPool.SelectedIndex == 0 ? " -snr" : " -gunt";
            }
            else
            {
                launchParameters += " -nnr";
            }
            if (checkBoxSpoilerLog.CheckState is CheckState.Checked)
            {
                launchParameters += " -spl";
            }
            if (checkBoxLSP.CheckState is CheckState.Checked)
            {
                launchParameters += " -lsp";
            }
            if (checkBoxNMC.CheckState is CheckState.Checked)
            {
                launchParameters += " -ntmr";
            }
            if (checkBoxCBM.CheckState is CheckState.Checked)
            {
                launchParameters += " -bsmt";
            }
            var randoProcess = new System.Diagnostics.Process();
            randoProcess.StartInfo.FileName = "python3.exe";
            randoProcess.StartInfo.Arguments = "python\\main.py " + launchParameters + " -hl";
            //randoProcess.StartInfo.RedirectStandardError = true;
            //randoProcess.StartInfo.RedirectStandardOutput = true;
            //randoProcess.StartInfo.UseShellExecute = false;
            //randoProcess.StartInfo.CreateNoWindow = true;
            randoProcess.Start();
            string randoErrorOutput = "";
            randoProcess.WaitForExit();
            if (randoProcess.ExitCode != 0)
            {
                //randoErrorOutput += randoProcess.StandardError.ReadToEnd();
                MessageBox.Show("The process did not exit successfully. Error Code: " + randoProcess.ExitCode + "\r\n" + randoErrorOutput, "Error");
                MessageBox.Show("Randomization did not complete successfully", "Error");
            }
            else
            {
                MessageBox.Show("Randomization completed successfully.", "Success!");
            }
        }
    }
}

// Initialize the Python engine
//PythonEngine.Initialize();

// Load the Python script
//dynamic randomizerScript = PythonEngine.ModuleFromString("main", File.ReadAllText("main.py"));

//dynamic output = randomizerScript.main(1, 2, 3);

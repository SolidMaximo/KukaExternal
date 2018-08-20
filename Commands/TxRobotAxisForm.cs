using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tecnomatix.Engineering.Ui;
using Tecnomatix.Engineering;
using System.Text.RegularExpressions;
using System.IO;

namespace Commands
{
    public partial class TxRobotAxisForm : TxForm
    {
        public TxRobotAxisForm()
        {
            InitializeComponent();
        }


        public override void OnInitTxForm()
        {
            base.OnInitTxForm();
            TxObjectList selectedObjects= TxApplication.ActiveSelection.GetItems();
            if(selectedObjects.Count>0)
            {
                ITxObject firstObject = selectedObjects[0];
                if (firstObject is TxRobot)
                { m_robotPicker.Object = firstObject;
                    UpdateUI();
                }
            }
            m_robotPicker.Focus();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void m_robotPicker_Picked(object sender, TxObjEditBoxCtrl_PickedEventArgs args)
        {
            UpdateUI();

        }

        private void m_robotPicker_TypeValid(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void m_robotPicker_TypeInvalid(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            TxRobot robot = m_robotPicker.Object as TxRobot;
            if (robot != null)
            {

                m_txtExternalID.Text = robot.ProcessModelId.ExternalId;
                string id = robot.ProcessModelId.ExternalId;
                string root = TxApplication.SystemRootDirectory;
                string madaRoot = root + "\\" + "robotsmachinedatafiles" +"\\"+id+ @"\KRC\R1\Mada\$machine.dat";              

                cPath.Text = madaRoot;
                Read(madaRoot);

            }
            else
            {
                m_txtExternalID.Text = string.Empty;
                cPath.Text = string.Empty;

            }

        }

        public bool isValid(string[] partNumbers)
        {

            Regex rgx = new Regex(@"^[-+]?[0-9]*\.?[0-9]*$");
            foreach (string partNumber in partNumbers)
            {
                if ((rgx.IsMatch(partNumber)) == false)
                { return false; }

            }

            return true;
        }

        public  string[] Read(string path)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            int index = 7, j = 0;
            if (File.Exists(path))
            {
                string[] tab = System.IO.File.ReadAllLines(path);
                TextBox[] array = { Lower7, Lower8, Lower9, Lower10, Lower11, Lower12, Upper7, Upper8, Upper9, Upper10, Upper11, Upper12 };
                for (int i = 0; i < tab.Length; i++)
                {
                    if (tab[i].Contains("$SOFTN_END[" + index + "]="))
                    {
                        if (index < 10)
                            array[j].Text = tab[i].Remove(0, 14);
                        else
                            array[j].Text = tab[i].Remove(0, 15);
                        if (array[j].Text.Contains(".") == false)
                            array[j].Text = array[j].Text + ".0";
                        array[j].BackColor = SystemColors.Window;
                        index++; j++;

                    }

                    if (index > 12) index = 7;


                    if (tab[i].Contains("$SOFTP_END[" + index + "]="))
                    {
                        if (index < 10)
                            array[j].Text = tab[i].Remove(0, 14);
                        else
                            array[j].Text = tab[i].Remove(0, 15);
                        array[j].BackColor = SystemColors.Window;
                        if (array[j].Text.Contains(".") == false)
                            array[j].Text = array[j].Text + ".0";
                        index++; j++;

                    }

                }
                j = 0;

                return tab;
            }
            else
            MessageBox.Show("File does not exists. Set correct path", "Error", MessageBoxButtons.OK);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                this.cPath.Text = path;
                Read(path);
            }
            return null;
        }

        private void WriteAsBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(cPath.Text) == true)
            {
                string[] values = { Lower7.Text, Lower8.Text, Lower9.Text, Lower10.Text, Lower11.Text, Lower12.Text,
             Upper7.Text, Upper8.Text, Upper9.Text, Upper10.Text, Upper11.Text, Upper12.Text};

                if ((isValid(values)) == false)
                    MessageBox.Show("Values are invaild", "Error", MessageBoxButtons.OK);
                else
                {

                    FolderBrowserDialog fbd = new FolderBrowserDialog();
                    fbd.SelectedPath = ePath.Text;

                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        ePath.Text = fbd.SelectedPath;
                        string path = fbd.SelectedPath + "\\$machine.dat";
                        Write(Read(this.cPath.Text), values, path);
                    }

                }
            }
            else
                MessageBox.Show("Path does not exists!", "Error", MessageBoxButtons.OK);

        }


        private void Write(string[] tab, string[] values, string path )
        {
            int index = 7, j = 0;


            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i].Contains("$SOFTN_END[" + index + "]="))
                {
                    tab[i] = "$SOFTN_END[" + index + "]=" + values[j];
                    if (tab[i].Contains(".") == false)
                        tab[i] = tab[i] + ".0";
                    index++;
                    j++;
                }


                if (index > 12) index = 7;

                if (tab[i].Contains("$SOFTP_END[" + index + "]="))
                {
                    tab[i] = "$SOFTP_END[" + index + "]=" + values[j];
                    if (tab[i].Contains(".") == false)
                        tab[i] = tab[i] + ".0";
                    index++;
                    j++;
                }
            }
            j = 0;

            System.IO.File.WriteAllLines(path, tab);

            Read(this.cPath.Text);
            MessageBox.Show("Saved", "Saved", MessageBoxButtons.OK);

        }

        private void WriteBtn(object sender, EventArgs e)
        {
            if (File.Exists(cPath.Text) == true)
            {
                string[] values = { Lower7.Text, Lower8.Text, Lower9.Text, Lower10.Text, Lower11.Text, Lower12.Text,
             Upper7.Text, Upper8.Text, Upper9.Text, Upper10.Text, Upper11.Text, Upper12.Text};

                if ((isValid(values)) == false)
                    MessageBox.Show("Values are invaild", "Error", MessageBoxButtons.OK);

                else if (File.Exists(cPath.Text) == true)
                {
                    Write(Read(cPath.Text), values, cPath.Text);

                }
            }
            else
                MessageBox.Show("Path does not exists!", "Error", MessageBoxButtons.OK);

        }


        private void ReadBtn_Click(object sender, EventArgs e)
        {
            Read(cPath.Text);
        }


        private void Lower7_TextChanged(object sender, EventArgs e)
        {
            Lower7.BackColor = Color.FromArgb(255, 232, 232);
        }

        private void Lower8_TextChanged(object sender, EventArgs e)
        {
            Lower8.BackColor = Color.FromArgb(255, 232, 232);
        }

        private void Lower9_TextChanged(object sender, EventArgs e)
        {
            Lower9.BackColor = Color.FromArgb(255, 232, 232);
        }

        private void Lower10_TextChanged(object sender, EventArgs e)
        {
            Lower10.BackColor = Color.FromArgb(255, 232, 232);
        }

        private void Lower11_TextChanged(object sender, EventArgs e)
        {
            Lower11.BackColor = Color.FromArgb(255, 232, 232);
        }

        private void Lower12_TextChanged(object sender, EventArgs e)
        {
            Lower12.BackColor = Color.FromArgb(255, 232, 232);
        }

        private void Upper7_TextChanged(object sender, EventArgs e)
        {
            Upper7.BackColor = Color.FromArgb(255, 232, 232);
        }

        private void Upper8_TextChanged(object sender, EventArgs e)
        {
            Upper8.BackColor = Color.FromArgb(255, 232, 232);
        }

        private void Upper9_TextChanged(object sender, EventArgs e)
        {
            Upper9.BackColor = Color.FromArgb(255, 232, 232);
        }

        private void Upper10_TextChanged(object sender, EventArgs e)
        {
            Upper10.BackColor = Color.FromArgb(255, 232, 232);
        }

        private void Upper11_TextChanged(object sender, EventArgs e)
        {
            Upper11.BackColor = Color.FromArgb(255, 232, 232);
        }

        private void Upper12_TextChanged(object sender, EventArgs e)
        {
            Upper12.BackColor = Color.FromArgb(255, 232, 232);
        }

        private void Lower7_Click(object sender, EventArgs e)
        {
            Lower7.Text = "";
        }

        private void Lower8_Click_1(object sender, EventArgs e)
        {
            Lower8.Text = "";
        }

        private void Lower9_Click(object sender, EventArgs e)
        {
            Lower9.Text = "";
        }

        private void Lower10_Click(object sender, EventArgs e)
        {
            Lower10.Text = "";
        }

        private void Lower11_Click(object sender, EventArgs e)
        {
            Lower11.Text = "";

        }

        private void Lower12_Click(object sender, EventArgs e)
        {
            Lower12.Text = "";

        }

        private void Upper7_Click(object sender, EventArgs e)
        {
            Upper7.Text = "";
        }

        private void Upper8_Click(object sender, EventArgs e)
        {
            Upper8.Text = "";
        }

        private void Upper9_Click(object sender, EventArgs e)
        {
            Upper9.Text = "";

        }

        private void Upper10_Click(object sender, EventArgs e)
        {
            Upper10.Text = "";
        }

        private void Upper11_Click(object sender, EventArgs e)
        {
            Upper11.Text = "";
        }

        private void Upper12_Click(object sender, EventArgs e)
        {
            Upper12.Text = "";

        }

        private void m_robotPicker_Load(object sender, EventArgs e)
        {

        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("•Read button - program reads current values from file in “current path” without saving.\n\n•Write button – Saves given values in robot $machine.dat file \n\n•Export button -  $machine.dat can be also exported to selected path. Export path can be selected or pasted to “export path” section. To confirm export you have to click Export, select path and confirm by clicking ok.\n"
, "Help", MessageBoxButtons.OK);

        }
    }
}

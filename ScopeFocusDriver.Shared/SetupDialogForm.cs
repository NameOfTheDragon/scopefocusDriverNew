using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using ASCOM.Utilities;
using ASCOM.scopefocus6;

namespace ASCOM.scopefocus6
{
    [ComVisible(false)]					// Form not registered for COM!
    public partial class SetupDialogForm : Form
        {
        private string driverID, driverDescription;
        //   private Serial serialPort;
        public SetupDialogForm(string id, string description)
            {
            this.driverID = id;
            this.driverDescription = description;
            InitializeComponent();
            //   _c = config;
            // Initialise current values of user settings from the ASCOM Profile 
            //     textBox1.Text = Focuser.comPort;
            chkTrace.Checked = Focuser.traceState;
        }

        private void cmdOK_Click(object sender, EventArgs e) // OK button event handler
        {
            // Place any validation constraint checks here

            using (ASCOM.Utilities.Profile p = new Utilities.Profile())
            {
                p.DeviceType = "Focuser";
                p.WriteValue(driverID, "ComPort", (string)cbComPort.SelectedItem);
                p.WriteValue(driverID, "SetPos", checkSetPos.Checked.ToString());
                // 6-16-16 added 2 lines below
                p.WriteValue(driverID, "Reverse", reverseCheckBox1.Checked.ToString());  // motor sitting shaft up turns clockwise with increasing numbers if NOT reversed
                p.WriteValue(driverID, "ContHold", contHoldCheckBox2.Checked.ToString());

                p.WriteValue(driverID, "MaxPos", tbMaxPos.Text);
                if (checkSetPos.Checked)
                {
                    p.WriteValue(driverID, "Pos", textPos.Text.ToString());
                }
            }
            Dispose();
        }

        private void cmdCancel_Click(object sender, EventArgs e) // Cancel button event handler
        {
            //   Close();
            Dispose();

        }

        private void BrowseToAscom(object sender, EventArgs e) // Click on ASCOM logo event handler
        {
            try
            {
                System.Diagnostics.Process.Start("http://ascom-standards.org/");
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }


        //*****try addt
        //  *** 2-28-16  need to add chkTrace check box that sets trace enable true

        private void SetupDialogForm_Load(object sender, EventArgs e)
        {
            string portName;
            using (ASCOM.Utilities.Profile p = new ASCOM.Utilities.Profile())
            {
                p.DeviceType = "Focuser";
                portName = p.GetValue(driverID, "ComPort");
                tbMaxPos.Text = p.GetValue(driverID, "MaxPos");

                // added 6-16-16
                if (p.GetValue(driverID, "Reverse") == "False")  // motor sitting shaft up turns clockwise with increasing numbers if NOT reversed
                    reverseCheckBox1.Checked = false;
                else
                    reverseCheckBox1.Checked = true;
                if (p.GetValue(driverID, "ContHold") == "False")
                   contHoldCheckBox2.Checked = false;
                else
                    contHoldCheckBox2.Checked = true;
            }

            cbComPort.Items.Clear();
            using (ASCOM.Utilities.Serial serial = new Utilities.Serial())
            {
                foreach (var item in serial.AvailableCOMPorts)
                {
                    cbComPort.Items.Add(item);
                    if (item == portName)
                        cbComPort.SelectedItem = item;

                }
            }
            /*
            foreach (string s in serialPort.GetPortNames())
            {
                cbComPort.Items.Add(s);
            }
            */
            cbComPort.SelectedItem = portName;

        }

        private void checkSetPos_CheckedChanged(object sender, EventArgs e)
        {
            bool enable = false;
            if (checkSetPos.Checked)
                enable = true;


            //  label2.Enabled = enable;
            textPos.Enabled = enable;
            

        }

        private void chkTrace_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTrace.Checked)
                Focuser.traceState = true;
            else
                Focuser.traceState = false;
        }

        //**** end addt.

    }
}
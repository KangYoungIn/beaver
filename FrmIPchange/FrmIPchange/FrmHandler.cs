using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace FrmIPchange
{
    public partial class FrmHandler : Form
    {
        private string sAdapter = string.Empty;
        private string sIpAdress = string.Empty;
        private string sGateway = string.Empty;
        private string sSubnetMask = string.Empty;
        private string sDNS = string.Empty;

        public FrmHandler()
        {
            InitializeComponent();
        }

        public FrmHandler(string Adapter) : this()
        {
            init();
            sAdapter = Adapter; 
        }

        public void init()
        {
            sAdapter = "";
            txtIP.Text = "";
            txtGateWay.Text = "";
        }

        public void setIP수동(string IPAddress, string Gateway, string SubnetMask, string DNS)
        {
            var adapterConfig = new ManagementClass("Win32_NetworkAdapterConfiguration");
            var networkCollection = adapterConfig.GetInstances();

            foreach (ManagementObject adapter in networkCollection)
            {
                string description = adapter["Description"] as string;
                if (string.Compare(description, sAdapter, StringComparison.InvariantCultureIgnoreCase) == 0)
                {
                    try
                    {
                        // Gateway
                        var newGateway = adapter.GetMethodParameters("SetGateways");
                        newGateway["DefaultIPGateway"] = new string[] { Gateway };
                        newGateway["GatewayCostMetric"] = new int[] { 1 };

                        // IP
                        var newAddress = adapter.GetMethodParameters("EnableStatic");
                        newAddress["IPAddress"] = new string[] { IPAddress };
                        newAddress["SubnetMask"] = new string[] { SubnetMask };

                        // DNS
                        var newDNS = adapter.GetMethodParameters("SetDNSServerSearchOrder");
                        newDNS["DNSServerSearchOrder"] = DNS.Split(',');

                        adapter.InvokeMethod("EnableStatic", newAddress, null);
                        adapter.InvokeMethod("SetGateways", newGateway, null);
                        adapter.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
                        MessageBox.Show("수동IP가 설정되었습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        return;
                    }
                }
            }
        }

        private void btn수동발번_Click(object sender, EventArgs e)
        {
            if (txtIP.Text.Trim().Length == 0)
            {
                MessageBox.Show("IP를 입력해주세요.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtSubnetMask.Text.Trim().Length == 0)
            {
                MessageBox.Show("SubnetMask를 입력해주세요.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            setIP수동(txtIP.Text.Trim(), txtGateWay.Text.Trim(), txtSubnetMask.Text.Trim(), txtDNS1.Text.Trim() + ',' + txtDNS2.Text.Trim()); // IP, Gateway, SubnetMask(고정) 
        }
    }
}

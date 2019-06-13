using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Net.NetworkInformation;
using System.Net;
namespace FrmIPchange
{
    public partial class Form1 : Form
    {
        string sAdapterDsc = string.Empty; 

        public Form1()
        {
            InitializeComponent();
            Set_adapters();
        }

        public void Set_adapters()
        {
            sAdapterDsc = ""; 

            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces(); 
            foreach (NetworkInterface adapter in nics)
            {
                if (adapter.NetworkInterfaceType.ToString() == "Ethernet")
                {
                    // Adapter 이름
                    sAdapterDsc = adapter.Description; 

                    // 기존컴퓨터 DNS 코드 가져오기 (참고)
                    //if (adapter.OperationalStatus == OperationalStatus.Up)
                    //{
                    //    IPInterfaceProperties ipProperties = adapter.GetIPProperties();
                    //    IPAddressCollection dnsAddresses = ipProperties.DnsAddresses;

                    //    int i = 0;

                    //    foreach (IPAddress dnsAdress in dnsAddresses)
                    //    {
                    //        if (i == 0)
                    //        {   
                    //            txtDNS1.Text = dnsAdress.ToString(); // 기본 설정 DNS 서버
                    //        }
                    //        else
                    //        {
                    //            txtDNS2.Text = dnsAdress.ToString(); // 보조 DNS 서버

                    //        }
                    //        i++; 
                    //    }
                    //}
                }
            } 
        }

        public void setIP수동(string IPAddress, string Gateway, string SubnetMask, string DNS) 
        { 
            var adapterConfig = new ManagementClass("Win32_NetworkAdapterConfiguration");
            var networkCollection = adapterConfig.GetInstances();

            foreach (ManagementObject adapter in networkCollection)
            {
                string description = adapter["Description"] as string;
                if (string.Compare(description, sAdapterDsc, StringComparison.InvariantCultureIgnoreCase) == 0)
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
                    }
                    catch (Exception ex)
                    {
                        return;
                    }
                }
            }
        }

        public void setIP자동()
        { 
            var adapterConfig = new ManagementClass("Win32_NetworkAdapterConfiguration");
            var networkCollection = adapterConfig.GetInstances();

            foreach (ManagementObject adapter in networkCollection)
            {
                string description = adapter["Description"] as string;
                if (string.Compare(description, sAdapterDsc, StringComparison.InvariantCultureIgnoreCase) == 0)
                {
                    try
                    {
                        adapter.InvokeMethod("EnableDHCP", null);
                        MessageBox.Show("자동IP가 설정되었습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch (Exception ex)
                    {
                        return;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setIP자동();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Chk_Info();
            setIP수동(txtIP.Text.Trim(), txtGateWay.Text.Trim(), txtSubnetMask.Text.Trim(), txtDNS1.Text.Trim() + ',' + txtDNS2.Text.Trim()); // IP, Gateway, SubnetMask(고정) 
        }

        public void Chk_Info()
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
        }

         
    }
}

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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            Set_adapters();
        }

        public void Set_adapters()
        {
            // Adapter
            DataTable dt = new DataTable();
            dt.Columns.Add("Adapter");

            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces(); 
            foreach (NetworkInterface adapter in nics)
            {
                if (adapter.NetworkInterfaceType.ToString() == "Ethernet")
                {
                    // Adapter 이름
                    DataRow dr = dt.NewRow();
                    dr["Adapter"] = adapter.Description; 
                    dt.Rows.Add(dr);
                }
            }
            lueAdapter.Properties.DataSource = dt;

            if (dt != null)
            {
                //lueAdapter.ItemIndex = 0;
                lueAdapter.EditValue = dt.Rows[0][lueAdapter.Properties.ValueMember];
            }
        }
        public void setIP자동()
        { 
            var adapterConfig = new ManagementClass("Win32_NetworkAdapterConfiguration");
            var networkCollection = adapterConfig.GetInstances();

            if (lueAdapter.EditValue.ToString() != "")
            {
                foreach (ManagementObject adapter in networkCollection)
                {
                    string description = adapter["Description"] as string;
                    if (string.Compare(description, lueAdapter.EditValue.ToString(), StringComparison.InvariantCultureIgnoreCase) == 0)
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
            else
            {
                MessageBox.Show("Adapter를 확인해주세요.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
         
        private void btn수동발번_Click(object sender, EventArgs e)
        {
            if (lueAdapter.EditValue.ToString() != "")
            {
                FrmHandler Level2 = new FrmHandler(lueAdapter.EditValue.ToString()); // Adapter 
                Level2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Adapter를 확인해주세요.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btn자동발번_Click(object sender, EventArgs e)
        {
            setIP자동();
        } 
    }
}

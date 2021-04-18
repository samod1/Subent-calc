using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominZadanie2
{
    struct Subnet
    {
        public int maxSubnets, maxHosts;
        public String SubnetMask, BitMask;
    };


    public partial class Form1 : Form
    {
        String firstByte = "110nnnnn", CurrentBitMask = "";
        int NetworkBytes = 3,
            maxFirstByte = 223,
            minFirstByte = 192;
        int[] IPparts;

        List<Subnet> SubnetList = new List<Subnet>();

        List<String> SubnetMasks = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }
   

        private int BinaryToDecimal(String binary)
        {
            int result = 0;
            int l = binary.Length;
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    result += (int)Math.Pow(2.0, (binary.Length - (i + 1)));
                }
            }
            return result;
        }

        private bool FormatCheck()
        {
            int DotsCount = 0;
            foreach (char c in tbIPAdresa.Text)
            {
                if (c == '.')
                    DotsCount++;
                if (DotsCount > 3)
                    return false;
                if (Char.IsLetter(c) && c != '.')
                    return false;
            }
            int StartIdx = 0, EndIdx = tbIPAdresa.Text.IndexOf('.');
            for (int i = 0; i < 4; i++)
            {
                if (EndIdx - StartIdx < 1 || EndIdx - StartIdx > 4)
                    return false;
                if (i != 3)
                    StartIdx = EndIdx + 1; EndIdx = tbIPAdresa.Text.IndexOf('.', StartIdx);
                if (i == 2)
                {
                    EndIdx = tbIPAdresa.Text.Length;
                }
            }
            return true;
        }
        private String DecimalToBinary(int Decimal)
        {
            String result = "";
            int zvysok = Decimal;
            for (int i = 7; i >= 0; i--)
            {
                if (zvysok / Math.Pow(2.0, i) >= 1)
                {
                    result += '1';
                    zvysok = (int)(zvysok % Math.Pow(2.0, i));
                }
                else
                {
                    result += '0';
                }
            }
            return result;
        }

        private int[] DivideIP()
        {
            int StartIdx = 0, length = tbIPAdresa.Text.IndexOf('.'), EndIdx = tbIPAdresa.Text.IndexOf('.');
            int[] IPparts = new int[4];
            for (int i = 0; i < 4; i++)
            {
                string s = tbIPAdresa.Text.Substring(StartIdx, length);
                IPparts[i] = Convert.ToInt32(s);
                if (IPparts[i] > 255)
                    IPparts[i] = 255;
                else if (IPparts[i] < 0)
                    IPparts[i] = 0;
                if (i == 2)
                {
                    StartIdx = EndIdx + 1; length = tbIPAdresa.Text.Length - StartIdx;
                }
                else
                {
                    StartIdx = EndIdx + 1; EndIdx = tbIPAdresa.Text.IndexOf('.', EndIdx + 1); length = EndIdx - StartIdx;
                }
            }
            if (IPparts[0] > maxFirstByte)
                IPparts[0] = maxFirstByte;
            else if (IPparts[0] < minFirstByte)
                IPparts[0] = minFirstByte;
            if (IPparts[3] == 0)
                IPparts[3] = 1;
            else if (IPparts[3] == 255)
                IPparts[3] = 254;
            tbIPAdresa.Text = IPparts[0].ToString() + '.' + IPparts[1].ToString() + '.' + IPparts[2].ToString() + '.' + IPparts[3].ToString();
            return IPparts;
        }

        private void GenerateBitmasks()
        {
            int availableBytes = 4 - NetworkBytes, availablebits = 8 * availableBytes - 2;
            Subnet subnet = new Subnet();
            SubnetList.Clear();
            subnet.BitMask = firstByte + '.';
            for (int i = 1; i < NetworkBytes; i++)
            {
                subnet.BitMask += "nnnnnnnn.";
            }
            for (int i = 0; i <= availablebits; i++)
            {
                for (int j = 0; j < 8 * availableBytes; j++)
                {
                    if (j < i)
                        subnet.BitMask += 's';
                    else
                        subnet.BitMask += 'h';
                    int r = j - (int)j / 8, r2 = 9 * (availableBytes - 1);
                    int r3 = (j - (int)j / 9) % 7;
                    bool t1 = (j - (int)j / 9) % 7 == 0, t2 = j != 0, t3 = j < 9 * (availableBytes - 1);
                    if ((j - (int)j / 9) % 7 == 0 && j != 0 && j < 9 * (availableBytes - 1))
                        subnet.BitMask += '.';
                }
                int[] MaxValues = GetMaxValues(subnet.BitMask);
                subnet.maxSubnets = MaxValues[0] + 1;
                subnet.maxHosts = MaxValues[1] - 1;
                subnet.SubnetMask = GenerateSubnetMask(subnet.BitMask);
                SubnetList.Add(subnet);
                subnet.BitMask = subnet.BitMask.Substring(0, 9 * NetworkBytes);
            }
            cbMask.DataSource = null;
            SubnetMasks.Clear();
            for (int i = 0; i < SubnetList.Count; i++)
            {
                SubnetMasks.Add(SubnetList[i].SubnetMask);
            }
            cbMask.DataSource = SubnetMasks;
            cbMask.SelectedIndex = 0;
        }

        private void GetClassAddressRange()
        {
            String result = minFirstByte.ToString() + ".0.0.1 - " + maxFirstByte.ToString() + ".255.255.254";
            IPRangeLabel.Text = result;
        }


        private void GetIPAddressRange()
        {
            String subnet = "";
            int SubnetSize = 0;
            String BitMask = CurrentBitMask;
            for (int i = NetworkBytes; i < 4; i++)
            {
                int StartIdx = i * 9, EndIdx = StartIdx + 8;
                String Binary = DecimalToBinary(IPparts[i]);
                bool ended = false;
                for (int j = StartIdx; j < EndIdx; j++)
                {
                    if (BitMask[j] != 'h')
                    {
                        subnet += Binary[j - StartIdx];
                        SubnetSize++;
                    }
                    else if (BitMask[j] == 'h')
                    {
                        ended = true;
                        break;
                    }

                }
                if (ended)
                    break;
                subnet += '.';

            }
            for (int i = 9 * NetworkBytes + SubnetSize; i < BitMask.Length; i++)
            {
                if (BitMask[i] == '.')
                    subnet += '.';
                else
                    subnet += '0';
            }

            int MinAddress = 1, MaxAddress = 1;
            String SubnetID = "";
            for (int i = 0; i < 4; i++)
            {
                if (i < NetworkBytes)
                {
                    SubnetID += IPparts[i].ToString() + '.';
                }
                else
                {
                    int StartIdx = (i - NetworkBytes) * 9;
                    int minValue = BinaryToDecimal(subnet.Substring(StartIdx, 8));
                    SubnetID += minValue.ToString();
                    if (i < 3)
                    {
                        SubnetID += '.';
                    }
                    else
                        MinAddress = minValue + 1;
                }
            }
            NetIDLabel.Text = SubnetID;
            int Dots = SubnetSize / 9;
            subnet = subnet.Substring(0, SubnetSize + Dots);
            for (int i = NetworkBytes * 9 + SubnetSize; i < BitMask.Length; i++)
            {
                if (BitMask[i] == '.')
                    subnet += '.';
                else
                    subnet += '1';
            }
            String BroadcastAddress = "";
            for (int i = 0; i < 4; i++)
            {
                if (i < NetworkBytes)
                {
                    BroadcastAddress += IPparts[i].ToString() + '.';
                }
                else
                {
                    int StartIdx = (i - NetworkBytes) * 9;
                    int maxValue = BinaryToDecimal(subnet.Substring(StartIdx, 8));
                    BroadcastAddress += maxValue.ToString();
                    if (i < 3)
                    {
                        BroadcastAddress += '.';
                    }
                    else
                        MaxAddress = maxValue - 1;
                }
            }
            BroadcastLabel.Text = BroadcastAddress;
            String IPRange = SubnetID.Substring(0, SubnetID.LastIndexOf('.') + 1) + MinAddress.ToString() + " - " + BroadcastAddress.Substring(0, BroadcastAddress.LastIndexOf('.') + 1) + MaxAddress.ToString();
            NetRangeLabel.Text = IPRange;
        }

        private int[] GetMaxValues(String bitmask)
        {
            String SubnetBinary = "", HostsBinary = "";
            foreach (char c in bitmask)
            {
                if (c == 's')
                {
                    SubnetBinary += '1';
                }
                else if (c == 'h')
                {
                    HostsBinary += '1';
                }
            }
            return new int[] { BinaryToDecimal(SubnetBinary), BinaryToDecimal(HostsBinary) };
        }

        private String GenerateSubnetMask(String bitmask)
        {
            String result = "";
            String SubnetBinary = "", HostsBinary = "";
            bool moreBytes = false;
            for (int i = 0; i < NetworkBytes; i++)
            {
                result += "255.";
            }
            for (int i = 0; i < 4 - NetworkBytes; i++)
            {
                if (moreBytes)
                {
                    result += '.';
                }

                for (int j = 0; j < 8; j++)
                {
                    char c = bitmask[9 * NetworkBytes + 9 * i + j];
                    if (c == 's')
                    {
                        SubnetBinary += '1';
                        HostsBinary += '0';
                    }
                    else if (c == 'h')
                    {
                        SubnetBinary += '0';
                        HostsBinary += '1';
                    }
                }
                result += BinaryToDecimal(SubnetBinary);
                moreBytes = true;
                SubnetBinary = "";
                HostsBinary = "";
            }

            return result;
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autor frmAutor = new Autor();
            frmAutor.Show();
        }

        private void pomocníkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help frmHelp = new Help();
            frmHelp.Show();
        }

        private void cbTrieda_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTrieda.SelectedIndex)
            {
                case 0:
                    firstByte = "0nnnnnnn";
                    NetworkBytes = 1;
                    minFirstByte = 1;
                    maxFirstByte = 126;
                    IPparts = DivideIP();
                    break;
                case 1:
                    firstByte = "10nnnnnn";
                    NetworkBytes = 2;
                    minFirstByte = 128;
                    maxFirstByte = 191;
                    IPparts = DivideIP();
                    break;
                case 2:
                    firstByte = "110nnnnn";
                    NetworkBytes = 3;
                    minFirstByte = 192;
                    maxFirstByte = 223;
                    IPparts = DivideIP();
                    break;
            }
            GenerateBitmasks();

            GetClassAddressRange();
            if (!FormatCheck())
            {
                MessageBox.Show("Zlý formát IP adresy!", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            IPparts = DivideIP();
            GetIPAddressRange();
        }

        private void tbIPAdresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!FormatCheck())
                {
                    MessageBox.Show("Zlý formát IP adresy!", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                IPparts = DivideIP();
                GetIPAddressRange();
            }
        }

        private void cbMask_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbMask.SelectedIndex;
            if (i >= 0)
            {
                BitMaskLabel.Text = SubnetList[i].BitMask;
                CurrentBitMask = SubnetList[i].BitMask;
                SubnetAmmountLabel.Text = SubnetList[i].maxSubnets.ToString();
                HostsAmmountLabel.Text = SubnetList[i].maxHosts.ToString();
            }
            else
                cbMask.SelectedIndex = 0;

            if (!FormatCheck())
            {
                MessageBox.Show("Zlý formát IP adresy!", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            IPparts = DivideIP();
            GetIPAddressRange();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            cbTrieda.SelectedIndex = 2;
            IPparts = DivideIP();
            GenerateBitmasks();
            GetIPAddressRange();
            cbMask.DataSource = SubnetMasks;
        }
    }
}

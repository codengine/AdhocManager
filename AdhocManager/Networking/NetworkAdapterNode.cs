using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace AdhocManager.Networking
{
    internal class NetworkAdapterNode : TreeNode
    {
        public NetworkAdapterNode(NetworkInterface adapter) : base(adapter.Name)
        {
            Id = adapter.Id;
            var icon = GetImageByAdapterType(adapter);
            ImageIndex = icon;
            SelectedImageIndex = icon;
            GetIpSubNode(adapter, Nodes);
            GetSpeedSubNode(adapter, Nodes);
            GetStatisticsSubNode(adapter, Nodes);
        }

        public string Id { get; private set; }

        private static void GetStatisticsSubNode(NetworkInterface adapter, TreeNodeCollection nodes)
        {
            var statistics = adapter.GetIPStatistics();
            if (statistics.BytesSent > 0)
            {
                nodes.Add(new TreeNode("Sent: " + StringUtils.ReadableFileSize(statistics.BytesSent),
                    NetworkIcons.Up, NetworkIcons.Up));
            }

            if (statistics.BytesReceived > 0)
            {
                nodes.Add(new TreeNode("Received: " + StringUtils.ReadableFileSize(statistics.BytesReceived),
                    NetworkIcons.Down, NetworkIcons.Down));
            }
        }

        private static void GetSpeedSubNode(NetworkInterface adapter, TreeNodeCollection nodes)
        {
            if (adapter.Speed > 0)
            {
                nodes.Add(new TreeNode("Speed: " + StringUtils.ReadableFileSize(adapter.Speed, 0, false) + "ps",
                    NetworkIcons.Gauge, NetworkIcons.Gauge));
            }
        }

        private static int GetImageByAdapterType(NetworkInterface adapter)
        {
            switch (adapter.NetworkInterfaceType)
            {
                case NetworkInterfaceType.Ethernet:
                case NetworkInterfaceType.Ethernet3Megabit:
                case NetworkInterfaceType.FastEthernetFx:
                case NetworkInterfaceType.FastEthernetT:
                case NetworkInterfaceType.GigabitEthernet:
                case NetworkInterfaceType.Fddi:
                    return NetworkIcons.Ethernet;
                case NetworkInterfaceType.Wireless80211:
                    return NetworkIcons.Wireless;
                case NetworkInterfaceType.BasicIsdn:
                case NetworkInterfaceType.Wwanpp:
                case NetworkInterfaceType.Wwanpp2:
                case NetworkInterfaceType.GenericModem:
                case NetworkInterfaceType.Isdn:
                case NetworkInterfaceType.PrimaryIsdn:
                    return NetworkIcons.Phone;
                default:
                    return NetworkIcons.Default;
            }
        }

        private static void GetIpSubNode(NetworkInterface adapter, TreeNodeCollection nodes)
        {
            if (adapter.OperationalStatus != OperationalStatus.Up) return;

            foreach (var ip in adapter.GetIPProperties().UnicastAddresses)
            {
                if (ip.Address.AddressFamily != AddressFamily.InterNetwork) continue;
                nodes.Add(new TreeNode("IP: " + ip.Address, NetworkIcons.Info, NetworkIcons.Info));
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is NetworkAdapterNode)
            {
                return string.Equals(Id, ((NetworkAdapterNode) obj).Id);
            }

            if (obj is TreeNode)
            {
                return string.Equals(Name, ((TreeNode) obj).Name);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
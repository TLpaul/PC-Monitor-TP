namespace PC_Monitor_TP
{
    using System.Management;
    using System.Windows.Forms; // <-- gives you the WinForms Timer

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_Load(null, null);
        }


        ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
        Timer timer1 = new Timer();



        private void Update_Val (object sender, EventArgs e)
        {
            UpdateCpuLabel();
            UpdateRamUsage();
           // UpdateGpuLabel();
        }
        private void UpdateCpuLabel()
        {
            var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");

            foreach (ManagementObject obj in searcher.Get())
            {
                string cpuLoad = obj["LoadPercentage"]?.ToString() ?? "N/A";
                CPU_Load_Display.Text = cpuLoad;
            }
        }
        private void UpdateRamUsage()
        {
            var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem ");
          
            foreach (ManagementObject obj in searcher.Get())
            {
                 string RamTotalSize = obj["TotalVisibleMemorySize"]?.ToString() ?? "N/A";
                 string RamFree = obj["FreePhysicalMemory"]?.ToString() ?? "N/A";
                 int totalMemory = int.Parse(RamTotalSize);
                 int freeMemory = int.Parse(RamFree);
                 int usedMemory = totalMemory - freeMemory;
                 int usedMemoryPercentage = (int)((double)usedMemory / totalMemory * 100);
                Ram_Usage_Display.Text = usedMemoryPercentage.ToString();
            }
        }

        private void UpdateGpuLabel()
        {
            var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            foreach (ManagementObject obj in searcher.Get())
            {
                string gpuLoad = obj["CurrentUsage"]?.ToString() ?? "N/A";
                GPU_Load_Display.Text = gpuLoad;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string CpuName = string.Empty;

           timer1.Interval = 1000; // 1 second
           timer1.Tick += Update_Val;
           timer1.Start();

            UpdateRamUsage();
            foreach (ManagementObject obj in searcher.Get())
            {
            

               CpuName = obj["Name"] as string;
                CPU_Name_L.Text = CpuName;


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

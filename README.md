CaseHUD

A lightweight C# WinForms system monitor that displays real-time CPU load and RAM usage using WMI queries. Designed with a modular structure to add GPU load monitoring and Arduino-based in-case display support in the future.

✨ Features

Real-time CPU load display using Win32_Processor.

Real-time RAM usage display using Win32_OperatingSystem.

1-second update interval via System.Windows.Forms.Timer.

Extensible architecture for future GPU load and Arduino integration.

Simple, clean WinForms interface.

🛠️ Technologies Used

Language: C#

Framework: .NET (Windows Forms)

APIs: WMI (System.Management)

UI: WinForms Controls (Labels, TextBoxes, etc.)

📸 Planned Features

GPU load support (via NVAPI, ADL, or DirectX performance counters)

Serial output to Arduino for physical in-case display

Customizable refresh intervals

Optional compact overlay mode

📦 Installation

Clone the repository:

git clone https://github.com/YourUsername/CaseHUD.git


Open the solution in Visual Studio.

Restore any required NuGet packages.

Build and run.

🚀 Usage

Launch the application — CPU load and RAM usage will begin updating every second.

The labels CPU_Load_Display, CPU_Name_L, and Ram_Usage_Display will show current system stats.

GPU load functionality is currently in development.

📄 Code Structure

Form1.cs — Main UI logic & system stat updates

UpdateCpuLabel() — Retrieves CPU load

UpdateRamUsage() — Retrieves RAM usage percentage

UpdateGpuLabel() (WIP) — Will retrieve GPU load

🤝 Contributing

Contributions are welcome!

Fork the repo

Create a feature branch

Submit a pull request with detailed changes

📜 License

This project is licensed under the MIT License.

If you want, I can also add a README diagram showing how data flows from WMI → WinForms → Arduino so it looks more professional on GitHub. That would make the repo stand out visually.

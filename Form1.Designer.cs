namespace PC_Monitor_TP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            CPU_Name_L = new Label();
            CPU_Load_Const = new Label();
            CPU_Load_Display = new Label();
            GPU_Name_L = new Label();
            GPU_Load_Display = new Label();
            GPU_Load_Const = new Label();
            Ram_Usage_Const = new Label();
            Ram_Usage_Display = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(167, 29);
            label1.TabIndex = 1;
            label1.Text = "PC Monitor ";
            label1.Click += label1_Click;
            // 
            // CPU_Name_L
            // 
            CPU_Name_L.AutoSize = true;
            CPU_Name_L.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CPU_Name_L.Location = new Point(14, 67);
            CPU_Name_L.Name = "CPU_Name_L";
            CPU_Name_L.Size = new Size(109, 23);
            CPU_Name_L.TabIndex = 2;
            CPU_Name_L.Text = "CPU Name";
            // 
            // CPU_Load_Const
            // 
            CPU_Load_Const.AutoSize = true;
            CPU_Load_Const.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CPU_Load_Const.Location = new Point(124, 131);
            CPU_Load_Const.Name = "CPU_Load_Const";
            CPU_Load_Const.Size = new Size(101, 23);
            CPU_Load_Const.TabIndex = 3;
            CPU_Load_Const.Text = "CPU Load";
            // 
            // CPU_Load_Display
            // 
            CPU_Load_Display.AutoSize = true;
            CPU_Load_Display.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CPU_Load_Display.Location = new Point(271, 131);
            CPU_Load_Display.Name = "CPU_Load_Display";
            CPU_Load_Display.Size = new Size(46, 23);
            CPU_Load_Display.TabIndex = 5;
            CPU_Load_Display.Text = "N/A";
            // 
            // GPU_Name_L
            // 
            GPU_Name_L.AutoSize = true;
            GPU_Name_L.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GPU_Name_L.Location = new Point(12, 243);
            GPU_Name_L.Name = "GPU_Name_L";
            GPU_Name_L.Size = new Size(111, 23);
            GPU_Name_L.TabIndex = 6;
            GPU_Name_L.Text = "GPU Name";
            // 
            // GPU_Load_Display
            // 
            GPU_Load_Display.AutoSize = true;
            GPU_Load_Display.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GPU_Load_Display.Location = new Point(271, 334);
            GPU_Load_Display.Name = "GPU_Load_Display";
            GPU_Load_Display.Size = new Size(46, 23);
            GPU_Load_Display.TabIndex = 8;
            GPU_Load_Display.Text = "N/A";
            // 
            // GPU_Load_Const
            // 
            GPU_Load_Const.AutoSize = true;
            GPU_Load_Const.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GPU_Load_Const.Location = new Point(124, 334);
            GPU_Load_Const.Name = "GPU_Load_Const";
            GPU_Load_Const.Size = new Size(103, 23);
            GPU_Load_Const.TabIndex = 7;
            GPU_Load_Const.Text = "GPU Load";
            // 
            // Ram_Usage_Const
            // 
            Ram_Usage_Const.AutoSize = true;
            Ram_Usage_Const.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ram_Usage_Const.Location = new Point(442, 67);
            Ram_Usage_Const.Name = "Ram_Usage_Const";
            Ram_Usage_Const.Size = new Size(117, 23);
            Ram_Usage_Const.TabIndex = 9;
            Ram_Usage_Const.Text = "Ram Usage";
            // 
            // Ram_Usage_Display
            // 
            Ram_Usage_Display.AutoSize = true;
            Ram_Usage_Display.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ram_Usage_Display.Location = new Point(521, 131);
            Ram_Usage_Display.Name = "Ram_Usage_Display";
            Ram_Usage_Display.Size = new Size(117, 23);
            Ram_Usage_Display.TabIndex = 10;
            Ram_Usage_Display.Text = "Ram Usage";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Ram_Usage_Display);
            Controls.Add(Ram_Usage_Const);
            Controls.Add(GPU_Load_Display);
            Controls.Add(GPU_Load_Const);
            Controls.Add(GPU_Name_L);
            Controls.Add(CPU_Load_Display);
            Controls.Add(CPU_Load_Const);
            Controls.Add(CPU_Name_L);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label CPU_Name_L;
        private Label CPU_Load_Const;
        private Label CPU_Load_Display;
        private Label GPU_Name_L;
        private Label GPU_Load_Display;
        private Label GPU_Load_Const;
        private Label Ram_Usage_Const;
        private Label Ram_Usage_Display;
    }
}

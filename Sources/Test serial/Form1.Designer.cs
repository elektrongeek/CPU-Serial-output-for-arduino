namespace Test_serial
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Cpu_USAGE = new System.Windows.Forms.Label();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.Start = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Netbios_Name = new System.Windows.Forms.Label();
            this.Os_Type = new System.Windows.Forms.Label();
            this.Os_Version = new System.Windows.Forms.Label();
            this.Machine_Uptime = new System.Windows.Forms.Label();
            this.Ram_USAGE = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.SuspendLayout();
            // 
            // Cpu_USAGE
            // 
            this.Cpu_USAGE.AutoSize = true;
            this.Cpu_USAGE.Location = new System.Drawing.Point(12, 9);
            this.Cpu_USAGE.Name = "Cpu_USAGE";
            this.Cpu_USAGE.Size = new System.Drawing.Size(29, 13);
            this.Cpu_USAGE.TabIndex = 2;
            this.Cpu_USAGE.Text = "CPU";
            // 
            // Clock
            // 
            this.Clock.Interval = 1000;
            this.Clock.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(223, 147);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(332, 151);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(79, 17);
            this.Output.TabIndex = 4;
            this.Output.Text = "Serial out ?";
            this.Output.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // Netbios_Name
            // 
            this.Netbios_Name.AutoSize = true;
            this.Netbios_Name.Location = new System.Drawing.Point(12, 33);
            this.Netbios_Name.Name = "Netbios_Name";
            this.Netbios_Name.Size = new System.Drawing.Size(44, 13);
            this.Netbios_Name.TabIndex = 5;
            this.Netbios_Name.Text = "NetBios";
            // 
            // Os_Type
            // 
            this.Os_Type.AutoSize = true;
            this.Os_Type.Location = new System.Drawing.Point(12, 59);
            this.Os_Type.Name = "Os_Type";
            this.Os_Type.Size = new System.Drawing.Size(22, 13);
            this.Os_Type.TabIndex = 6;
            this.Os_Type.Text = "OS";
            // 
            // Os_Version
            // 
            this.Os_Version.AutoSize = true;
            this.Os_Version.Location = new System.Drawing.Point(12, 85);
            this.Os_Version.Name = "Os_Version";
            this.Os_Version.Size = new System.Drawing.Size(44, 13);
            this.Os_Version.TabIndex = 7;
            this.Os_Version.Text = "OSVER";
            // 
            // Machine_Uptime
            // 
            this.Machine_Uptime.AutoSize = true;
            this.Machine_Uptime.Location = new System.Drawing.Point(113, 33);
            this.Machine_Uptime.Name = "Machine_Uptime";
            this.Machine_Uptime.Size = new System.Drawing.Size(48, 13);
            this.Machine_Uptime.TabIndex = 8;
            this.Machine_Uptime.Text = "UPTIME";
            // 
            // Ram_USAGE
            // 
            this.Ram_USAGE.AutoSize = true;
            this.Ram_USAGE.Location = new System.Drawing.Point(113, 9);
            this.Ram_USAGE.Name = "Ram_USAGE";
            this.Ram_USAGE.Size = new System.Drawing.Size(31, 13);
            this.Ram_USAGE.TabIndex = 9;
            this.Ram_USAGE.Text = "RAM";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(220, 9);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(37, 13);
            this.Username.TabIndex = 10;
            this.Username.Text = "USER";
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(24, 145);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(100, 23);
            this.metroProgressBar1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 180);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Ram_USAGE);
            this.Controls.Add(this.Machine_Uptime);
            this.Controls.Add(this.Os_Version);
            this.Controls.Add(this.Os_Type);
            this.Controls.Add(this.Netbios_Name);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Cpu_USAGE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Cpu_USAGE;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.CheckBox Output;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Netbios_Name;
        private System.Windows.Forms.Label Os_Type;
        private System.Windows.Forms.Label Os_Version;
        private System.Windows.Forms.Label Machine_Uptime;
        private System.Windows.Forms.Label Ram_USAGE;
        private System.Windows.Forms.Label Username;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
    }
}


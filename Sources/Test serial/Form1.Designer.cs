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
            this.SuspendLayout();
            // 
            // Cpu_USAGE
            // 
            this.Cpu_USAGE.AutoSize = true;
            this.Cpu_USAGE.Location = new System.Drawing.Point(12, 9);
            this.Cpu_USAGE.Name = "Cpu_USAGE";
            this.Cpu_USAGE.Size = new System.Drawing.Size(0, 13);
            this.Cpu_USAGE.TabIndex = 2;
            // 
            // Clock
            // 
            this.Clock.Interval = 500;
            this.Clock.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 40);
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
            this.Output.Location = new System.Drawing.Point(113, 44);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(79, 17);
            this.Output.TabIndex = 4;
            this.Output.Text = "Serial out ?";
            this.Output.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 75);
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
    }
}


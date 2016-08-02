namespace WindowsFormsApplication1
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tbProcessName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDefaultWidth = new System.Windows.Forms.Label();
            this.tbDefaultWidth = new System.Windows.Forms.TextBox();
            this.labelDefaultHeigth = new System.Windows.Forms.Label();
            this.tbDefaultHeigth = new System.Windows.Forms.TextBox();
            this.labelProcessCount = new System.Windows.Forms.Label();
            this.btnResize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tbProcessName
            // 
            this.tbProcessName.Location = new System.Drawing.Point(113, 33);
            this.tbProcessName.Name = "tbProcessName";
            this.tbProcessName.Size = new System.Drawing.Size(100, 20);
            this.tbProcessName.TabIndex = 0;
            this.tbProcessName.Text = "Diablo III";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Process name: ";
            // 
            // labelDefaultWidth
            // 
            this.labelDefaultWidth.AutoSize = true;
            this.labelDefaultWidth.Location = new System.Drawing.Point(27, 62);
            this.labelDefaultWidth.Name = "labelDefaultWidth";
            this.labelDefaultWidth.Size = new System.Drawing.Size(72, 13);
            this.labelDefaultWidth.TabIndex = 3;
            this.labelDefaultWidth.Text = "Default Width";
            // 
            // tbDefaultWidth
            // 
            this.tbDefaultWidth.Location = new System.Drawing.Point(113, 59);
            this.tbDefaultWidth.Name = "tbDefaultWidth";
            this.tbDefaultWidth.Size = new System.Drawing.Size(100, 20);
            this.tbDefaultWidth.TabIndex = 2;
            this.tbDefaultWidth.Text = "300";
            this.tbDefaultWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDefaultWidth_KeyPress);
            // 
            // labelDefaultHeigth
            // 
            this.labelDefaultHeigth.AutoSize = true;
            this.labelDefaultHeigth.Location = new System.Drawing.Point(27, 88);
            this.labelDefaultHeigth.Name = "labelDefaultHeigth";
            this.labelDefaultHeigth.Size = new System.Drawing.Size(73, 13);
            this.labelDefaultHeigth.TabIndex = 5;
            this.labelDefaultHeigth.Text = "Default heigth";
            // 
            // tbDefaultHeigth
            // 
            this.tbDefaultHeigth.Location = new System.Drawing.Point(113, 85);
            this.tbDefaultHeigth.Name = "tbDefaultHeigth";
            this.tbDefaultHeigth.Size = new System.Drawing.Size(100, 20);
            this.tbDefaultHeigth.TabIndex = 4;
            this.tbDefaultHeigth.Text = "200";
            this.tbDefaultHeigth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDefaultHeigth_KeyPress);
            // 
            // labelProcessCount
            // 
            this.labelProcessCount.AutoSize = true;
            this.labelProcessCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcessCount.Location = new System.Drawing.Point(250, 59);
            this.labelProcessCount.Name = "labelProcessCount";
            this.labelProcessCount.Size = new System.Drawing.Size(37, 39);
            this.labelProcessCount.TabIndex = 6;
            this.labelProcessCount.Text = "0";
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(113, 111);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(100, 28);
            this.btnResize.TabIndex = 7;
            this.btnResize.Text = "Resize them";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 168);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.labelProcessCount);
            this.Controls.Add(this.labelDefaultHeigth);
            this.Controls.Add(this.tbDefaultHeigth);
            this.Controls.Add(this.labelDefaultWidth);
            this.Controls.Add(this.tbDefaultWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbProcessName);
            this.Name = "Form1";
            this.Text = "Process resizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox tbProcessName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDefaultWidth;
        private System.Windows.Forms.TextBox tbDefaultWidth;
        private System.Windows.Forms.Label labelDefaultHeigth;
        private System.Windows.Forms.TextBox tbDefaultHeigth;
        private System.Windows.Forms.Label labelProcessCount;
        private System.Windows.Forms.Button btnResize;
    }
}


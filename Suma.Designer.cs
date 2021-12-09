namespace AppForms
{
    partial class Suma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nv1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nv2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_res = new System.Windows.Forms.Label();
            this.escape = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nv2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor 1: ";
            // 
            // nv1
            // 
            this.nv1.Location = new System.Drawing.Point(303, 117);
            this.nv1.Name = "nv1";
            this.nv1.Size = new System.Drawing.Size(120, 23);
            this.nv1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor 2 :";
            // 
            // nv2
            // 
            this.nv2.Location = new System.Drawing.Point(303, 173);
            this.nv2.Name = "nv2";
            this.nv2.Size = new System.Drawing.Size(120, 23);
            this.nv2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "El resultado es :";
            // 
            // lbl_res
            // 
            this.lbl_res.AutoSize = true;
            this.lbl_res.Location = new System.Drawing.Point(382, 287);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(38, 15);
            this.lbl_res.TabIndex = 6;
            this.lbl_res.Text = "label4";
            // 
            // escape
            // 
            this.escape.Location = new System.Drawing.Point(711, 400);
            this.escape.Name = "escape";
            this.escape.Size = new System.Drawing.Size(75, 23);
            this.escape.TabIndex = 7;
            this.escape.Text = "CERRAR";
            this.escape.UseVisualStyleBackColor = true;
            this.escape.Click += new System.EventHandler(this.escape_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Suma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Suma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.escape);
            this.Controls.Add(this.lbl_res);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nv2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nv1);
            this.Controls.Add(this.label1);
            this.Name = "Suma";
            this.Text = "Suma";
            ((System.ComponentModel.ISupportInitialize)(this.nv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown nv1;
        private Label label2;
        private NumericUpDown nv2;
        private Label label3;
        private Label lbl_res;
        private Button escape;
        private Button button1;
    }
}
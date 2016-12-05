namespace Papegaaienopvangprogramma
{
    partial class Ondersoortinput
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
            this.labelOndersoortnaam = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonToevoegen = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOndersoortnaam
            // 
            this.labelOndersoortnaam.AutoSize = true;
            this.labelOndersoortnaam.Location = new System.Drawing.Point(13, 13);
            this.labelOndersoortnaam.Name = "labelOndersoortnaam";
            this.labelOndersoortnaam.Size = new System.Drawing.Size(90, 13);
            this.labelOndersoortnaam.TabIndex = 0;
            this.labelOndersoortnaam.Text = "OndersoortNaam:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 1;
            // 
            // buttonToevoegen
            // 
            this.buttonToevoegen.Location = new System.Drawing.Point(197, 42);
            this.buttonToevoegen.Name = "buttonToevoegen";
            this.buttonToevoegen.Size = new System.Drawing.Size(75, 23);
            this.buttonToevoegen.TabIndex = 2;
            this.buttonToevoegen.Text = "Toevoegen";
            this.buttonToevoegen.UseVisualStyleBackColor = true;
            this.buttonToevoegen.Click += new System.EventHandler(this.buttonToevoegen_Click);
            // 
            // buttoncancel
            // 
            this.buttoncancel.Location = new System.Drawing.Point(116, 42);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(75, 23);
            this.buttoncancel.TabIndex = 3;
            this.buttoncancel.Text = "Cancel";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // Ondersoortinput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 77);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonToevoegen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelOndersoortnaam);
            this.Name = "Ondersoortinput";
            this.Text = "Ondersoortinput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOndersoortnaam;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonToevoegen;
        private System.Windows.Forms.Button buttoncancel;
    }
}
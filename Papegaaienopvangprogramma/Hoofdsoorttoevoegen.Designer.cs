namespace Papegaaienopvangprogramma
{
    partial class Hoofdsoorttoevoegen
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
            this.labelVSNAAM = new System.Windows.Forms.Label();
            this.Ondersoorten = new System.Windows.Forms.Label();
            this.textBoxVOGELSOORTNAAM = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OnderSoortnaam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonToevoegen = new System.Windows.Forms.Button();
            this.buttonCANCEL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVSNAAM
            // 
            this.labelVSNAAM.AutoSize = true;
            this.labelVSNAAM.Location = new System.Drawing.Point(12, 9);
            this.labelVSNAAM.Name = "labelVSNAAM";
            this.labelVSNAAM.Size = new System.Drawing.Size(88, 13);
            this.labelVSNAAM.TabIndex = 0;
            this.labelVSNAAM.Text = "Vogelsoort Naam";
            // 
            // Ondersoorten
            // 
            this.Ondersoorten.AutoSize = true;
            this.Ondersoorten.Location = new System.Drawing.Point(12, 51);
            this.Ondersoorten.Name = "Ondersoorten";
            this.Ondersoorten.Size = new System.Drawing.Size(71, 13);
            this.Ondersoorten.TabIndex = 1;
            this.Ondersoorten.Text = "Ondersoorten";
            // 
            // textBoxVOGELSOORTNAAM
            // 
            this.textBoxVOGELSOORTNAAM.Location = new System.Drawing.Point(118, 6);
            this.textBoxVOGELSOORTNAAM.Name = "textBoxVOGELSOORTNAAM";
            this.textBoxVOGELSOORTNAAM.Size = new System.Drawing.Size(284, 20);
            this.textBoxVOGELSOORTNAAM.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OnderSoortnaam});
            this.dataGridView1.Location = new System.Drawing.Point(118, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(284, 88);
            this.dataGridView1.TabIndex = 3;
            // 
            // OnderSoortnaam
            // 
            this.OnderSoortnaam.HeaderText = "Ondersoort naam";
            this.OnderSoortnaam.Name = "OnderSoortnaam";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Toevoegen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonToevoegen
            // 
            this.buttonToevoegen.Location = new System.Drawing.Point(326, 283);
            this.buttonToevoegen.Name = "buttonToevoegen";
            this.buttonToevoegen.Size = new System.Drawing.Size(75, 23);
            this.buttonToevoegen.TabIndex = 5;
            this.buttonToevoegen.Text = "Toevoegen";
            this.buttonToevoegen.UseVisualStyleBackColor = true;
            // 
            // buttonCANCEL
            // 
            this.buttonCANCEL.Location = new System.Drawing.Point(245, 283);
            this.buttonCANCEL.Name = "buttonCANCEL";
            this.buttonCANCEL.Size = new System.Drawing.Size(75, 23);
            this.buttonCANCEL.TabIndex = 6;
            this.buttonCANCEL.Text = "Cancel";
            this.buttonCANCEL.UseVisualStyleBackColor = true;
            // 
            // Hoofdsoorttoevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 318);
            this.Controls.Add(this.buttonCANCEL);
            this.Controls.Add(this.buttonToevoegen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxVOGELSOORTNAAM);
            this.Controls.Add(this.Ondersoorten);
            this.Controls.Add(this.labelVSNAAM);
            this.Name = "Hoofdsoorttoevoegen";
            this.Text = "Vogelsoort Toevoegen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVSNAAM;
        private System.Windows.Forms.Label Ondersoorten;
        private System.Windows.Forms.TextBox textBoxVOGELSOORTNAAM;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnderSoortnaam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonToevoegen;
        private System.Windows.Forms.Button buttonCANCEL;
    }
}

namespace EnumStudy
{
    partial class Case2
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
            this.lblPutNumber = new System.Windows.Forms.Label();
            this.lbCities = new System.Windows.Forms.ListBox();
            this.btnControlledEnumValue = new System.Windows.Forms.Button();
            this.btnEnumValue = new System.Windows.Forms.Button();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPutNumber
            // 
            this.lblPutNumber.AutoSize = true;
            this.lblPutNumber.Location = new System.Drawing.Point(38, 43);
            this.lblPutNumber.Name = "lblPutNumber";
            this.lblPutNumber.Size = new System.Drawing.Size(61, 13);
            this.lblPutNumber.TabIndex = 9;
            this.lblPutNumber.Text = "Sayı Giriniz:";
            // 
            // lbCities
            // 
            this.lbCities.FormattingEnabled = true;
            this.lbCities.Location = new System.Drawing.Point(309, 40);
            this.lbCities.Name = "lbCities";
            this.lbCities.Size = new System.Drawing.Size(120, 121);
            this.lbCities.TabIndex = 8;
            // 
            // btnControlledEnumValue
            // 
            this.btnControlledEnumValue.Location = new System.Drawing.Point(127, 138);
            this.btnControlledEnumValue.Name = "btnControlledEnumValue";
            this.btnControlledEnumValue.Size = new System.Drawing.Size(126, 23);
            this.btnControlledEnumValue.TabIndex = 7;
            this.btnControlledEnumValue.Text = "Kontrollü Enum Değeri";
            this.btnControlledEnumValue.UseVisualStyleBackColor = true;
            this.btnControlledEnumValue.Click += new System.EventHandler(this.btnControlledEnumValue_Click);
            // 
            // btnEnumValue
            // 
            this.btnEnumValue.Location = new System.Drawing.Point(127, 91);
            this.btnEnumValue.Name = "btnEnumValue";
            this.btnEnumValue.Size = new System.Drawing.Size(126, 23);
            this.btnEnumValue.TabIndex = 6;
            this.btnEnumValue.Text = "Enum Değeri";
            this.btnEnumValue.UseVisualStyleBackColor = true;
            this.btnEnumValue.Click += new System.EventHandler(this.btnEnumValue_Click);
            // 
            // txtEntry
            // 
            this.txtEntry.Location = new System.Drawing.Point(127, 40);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(126, 20);
            this.txtEntry.TabIndex = 5;
            // 
            // Case2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 203);
            this.Controls.Add(this.lblPutNumber);
            this.Controls.Add(this.lbCities);
            this.Controls.Add(this.btnControlledEnumValue);
            this.Controls.Add(this.btnEnumValue);
            this.Controls.Add(this.txtEntry);
            this.Name = "Case2";
            this.Text = "Case2";
            this.Load += new System.EventHandler(this.Case2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPutNumber;
        private System.Windows.Forms.ListBox lbCities;
        private System.Windows.Forms.Button btnControlledEnumValue;
        private System.Windows.Forms.Button btnEnumValue;
        private System.Windows.Forms.TextBox txtEntry;
    }
}
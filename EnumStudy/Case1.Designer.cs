
namespace EnumStudy
{
    partial class Case1
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
            this.btnIslemYap = new System.Windows.Forms.Button();
            this.lbCitiesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnIslemYap
            // 
            this.btnIslemYap.Location = new System.Drawing.Point(61, 218);
            this.btnIslemYap.Name = "btnIslemYap";
            this.btnIslemYap.Size = new System.Drawing.Size(159, 23);
            this.btnIslemYap.TabIndex = 3;
            this.btnIslemYap.Text = "İşlem Yap";
            this.btnIslemYap.UseVisualStyleBackColor = true;
            this.btnIslemYap.Click += new System.EventHandler(this.btnIslemYap_Click);
            // 
            // lbCitiesList
            // 
            this.lbCitiesList.FormattingEnabled = true;
            this.lbCitiesList.Location = new System.Drawing.Point(61, 49);
            this.lbCitiesList.Name = "lbCitiesList";
            this.lbCitiesList.Size = new System.Drawing.Size(159, 134);
            this.lbCitiesList.TabIndex = 2;
            // 
            // Case1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 303);
            this.Controls.Add(this.btnIslemYap);
            this.Controls.Add(this.lbCitiesList);
            this.Name = "Case1";
            this.Text = "Case1";
            this.Load += new System.EventHandler(this.Case1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIslemYap;
        private System.Windows.Forms.ListBox lbCitiesList;
    }
}


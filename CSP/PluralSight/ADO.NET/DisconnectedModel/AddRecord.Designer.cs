namespace CSP.PluralSight.ADO.NET
{
    partial class AddRecord
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(763, 736);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(348, 125);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Color";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtColorName
            // 
            this.txtColorName.Location = new System.Drawing.Point(748, 69);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(362, 38);
            this.txtColorName.TabIndex = 1;
            this.txtColorName.Text = "Yellow";
            //this.txtColorName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 906);
            this.Controls.Add(this.txtColorName);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddRecord";
            this.Text = "AddRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtColorName;
    }
}
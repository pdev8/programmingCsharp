namespace CSP.PluralSight.ADO.NET.ConnectionOrientedModel
{
    partial class Form1
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.Color = new System.Windows.Forms.Label();
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtColorId = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(202, 757);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(220, 102);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(481, 757);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(220, 102);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(767, 757);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(220, 102);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(1050, 757);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(220, 102);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Location = new System.Drawing.Point(205, 165);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(91, 32);
            this.Color.TabIndex = 4;
            this.Color.Text = "Color:";
            // 
            // txtColorName
            // 
            this.txtColorName.Location = new System.Drawing.Point(555, 159);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(560, 38);
            this.txtColorName.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1172, 129);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(220, 102);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtColorId
            // 
            this.txtColorId.Location = new System.Drawing.Point(555, 303);
            this.txtColorId.Name = "txtColorId";
            this.txtColorId.Size = new System.Drawing.Size(560, 38);
            this.txtColorId.TabIndex = 8;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(205, 309);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(121, 32);
            this.id.TabIndex = 7;
            this.id.Text = "Color Id:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1849, 1111);
            this.Controls.Add(this.txtColorId);
            this.Controls.Add(this.id);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtColorName);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.TextBox txtColorName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtColorId;
        private System.Windows.Forms.Label id;
    }
}
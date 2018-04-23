namespace WindowsApplication1
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
            this.repositoryItemRichTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.repositoryItemRichTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.myButtonEdit1 = new WindowsApplication1.MyButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemRichTextEdit2
            // 
            this.repositoryItemRichTextEdit2.DocumentFormat = DevExpress.XtraRichEdit.DocumentFormat.Html;
            this.repositoryItemRichTextEdit2.Name = "repositoryItemRichTextEdit2";
            // 
            // repositoryItemRichTextEdit3
            // 
            this.repositoryItemRichTextEdit3.DocumentFormat = DevExpress.XtraRichEdit.DocumentFormat.Html;
            this.repositoryItemRichTextEdit3.Name = "repositoryItemRichTextEdit3";
            // 
            // myButtonEdit1
            // 
            this.myButtonEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.myButtonEdit1.Location = new System.Drawing.Point(0, 0);
            this.myButtonEdit1.Margin = new System.Windows.Forms.Padding(2);
            this.myButtonEdit1.Name = "myButtonEdit1";
            this.myButtonEdit1.Properties.AutoHeight = false;
            this.myButtonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.myButtonEdit1.Properties.RichEdit = this.repositoryItemRichTextEdit2;
            this.myButtonEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.myButtonEdit1.Size = new System.Drawing.Size(579, 107);
            this.myButtonEdit1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 420);
            this.Controls.Add(this.myButtonEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyButtonEdit myButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit3;
    }
}


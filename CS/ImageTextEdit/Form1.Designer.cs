namespace ImageTextEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageCollection1 = new DevExpress.Utils.ImageCollection();
            this.customIconTextEdit3 = new ImageTextEdit.CustomIconTextEdit();
            this.customIconTextEdit2 = new ImageTextEdit.CustomIconTextEdit();
            this.customIconTextEdit1 = new ImageTextEdit.CustomIconTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customIconTextEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customIconTextEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customIconTextEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageCollection1.Images.SetKeyName(0, "arrowleft_green_32_h.bmp");
            this.imageCollection1.Images.SetKeyName(1, "arrowleft_green_32_d.bmp");
            this.imageCollection1.Images.SetKeyName(2, "delete_x_32.bmp");
            // 
            // customIconTextEdit3
            // 
            this.customIconTextEdit3.EditValue = "Disabled";
            this.customIconTextEdit3.Enabled = false;
            this.customIconTextEdit3.Location = new System.Drawing.Point(12, 102);
            this.customIconTextEdit3.Name = "customIconTextEdit3";
            this.customIconTextEdit3.Properties.ImageIndex = 1;
            this.customIconTextEdit3.Properties.ImageList = this.imageCollection1;
            this.customIconTextEdit3.Properties.OnIconSelection += new ImageTextEdit.OnIconSelectionEventHandler(this.customIconTextEdit1_Properties_OnIconSelection);
            this.customIconTextEdit3.Size = new System.Drawing.Size(100, 38);
            this.customIconTextEdit3.TabIndex = 2;
            this.customIconTextEdit3.IconClick += new ImageTextEdit.IconClickEventHandler(this.customIconTextEdit1_IconClick);
            // 
            // customIconTextEdit2
            // 
            this.customIconTextEdit2.EditValue = "Second";
            this.customIconTextEdit2.Location = new System.Drawing.Point(12, 56);
            this.customIconTextEdit2.Name = "customIconTextEdit2";
            this.customIconTextEdit2.Properties.ImageIndex = 1;
            this.customIconTextEdit2.Properties.ImageList = this.imageCollection1;
            this.customIconTextEdit2.Properties.OnIconSelection += new ImageTextEdit.OnIconSelectionEventHandler(this.customIconTextEdit1_Properties_OnIconSelection);
            this.customIconTextEdit2.Size = new System.Drawing.Size(100, 38);
            this.customIconTextEdit2.TabIndex = 1;
            this.customIconTextEdit2.IconClick += new ImageTextEdit.IconClickEventHandler(this.customIconTextEdit1_IconClick);
            // 
            // customIconTextEdit1
            // 
            this.customIconTextEdit1.EditValue = "First";
            this.customIconTextEdit1.Location = new System.Drawing.Point(12, 12);
            this.customIconTextEdit1.Name = "customIconTextEdit1";
            this.customIconTextEdit1.Properties.ImageIndex = 1;
            this.customIconTextEdit1.Properties.ImageList = this.imageCollection1;
            this.customIconTextEdit1.Properties.OnIconSelection += new ImageTextEdit.OnIconSelectionEventHandler(this.customIconTextEdit1_Properties_OnIconSelection);
            this.customIconTextEdit1.Size = new System.Drawing.Size(100, 38);
            this.customIconTextEdit1.TabIndex = 0;
            this.customIconTextEdit1.IconClick += new ImageTextEdit.IconClickEventHandler(this.customIconTextEdit1_IconClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 196);
            this.Controls.Add(this.customIconTextEdit3);
            this.Controls.Add(this.customIconTextEdit2);
            this.Controls.Add(this.customIconTextEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customIconTextEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customIconTextEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customIconTextEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection imageCollection1;
        private CustomIconTextEdit customIconTextEdit1;
        private CustomIconTextEdit customIconTextEdit2;
        private CustomIconTextEdit customIconTextEdit3;

    }
}


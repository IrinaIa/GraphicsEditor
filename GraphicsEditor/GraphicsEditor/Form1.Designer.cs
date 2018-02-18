namespace GraphicsEditor
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
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonPointer = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonRectangle = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonEllipse = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonRedo = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripSeparator1,
            this.toolStripButtonPointer,
            this.toolStripButtonRectangle,
            this.toolStripButtonEllipse,
            this.toolStripSeparator2,
            this.toolStripButtonDelete,
            this.toolStripSeparator3,
            this.toolStripButtonUndo,
            this.toolStripButtonRedo});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(634, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButtonNew
			// 
			this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
			this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonNew.Name = "toolStripButtonNew";
			this.toolStripButtonNew.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonNew.Text = "New";
			this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButtonPointer
			// 
			this.toolStripButtonPointer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonPointer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPointer.Image")));
			this.toolStripButtonPointer.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonPointer.Name = "toolStripButtonPointer";
			this.toolStripButtonPointer.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonPointer.Text = "Pointer";
			this.toolStripButtonPointer.Click += new System.EventHandler(this.toolStripButtonPointer_Click);
			// 
			// toolStripButtonRectangle
			// 
			this.toolStripButtonRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonRectangle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRectangle.Image")));
			this.toolStripButtonRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonRectangle.Name = "toolStripButtonRectangle";
			this.toolStripButtonRectangle.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonRectangle.Text = "Rectangle";
			this.toolStripButtonRectangle.Click += new System.EventHandler(this.toolStripButtonRectangle_Click);
			// 
			// toolStripButtonEllipse
			// 
			this.toolStripButtonEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonEllipse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEllipse.Image")));
			this.toolStripButtonEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonEllipse.Name = "toolStripButtonEllipse";
			this.toolStripButtonEllipse.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonEllipse.Text = "Ellipse";
			this.toolStripButtonEllipse.Click += new System.EventHandler(this.toolStripButtonEllipse_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButtonDelete
			// 
			this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
			this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonDelete.Name = "toolStripButtonDelete";
			this.toolStripButtonDelete.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonDelete.Text = "Delete";
			this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
			
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButtonUndo
			// 
			this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUndo.Image")));
			this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonUndo.Name = "toolStripButtonUndo";
			this.toolStripButtonUndo.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonUndo.Text = "Undo";
			this.toolStripButtonUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
			// 
			// toolStripButtonRedo
			// 
			this.toolStripButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonRedo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRedo.Image")));
			this.toolStripButtonRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonRedo.Name = "toolStripButtonRedo";
			this.toolStripButtonRedo.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonRedo.Text = "Redo";
			this.toolStripButtonRedo.Click += new System.EventHandler(this.toolStripButtonRedo_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 415);
			this.Controls.Add(this.toolStrip1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButtonNew;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripButtonPointer;
		private System.Windows.Forms.ToolStripButton toolStripButtonRectangle;
		private System.Windows.Forms.ToolStripButton toolStripButtonEllipse;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
		private System.Windows.Forms.ToolStripButton toolStripButtonRedo;
	}
}


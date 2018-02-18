using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsEditor
{
	public partial class Form1 : Form
	{
		DrawArea drawArea;
		public Form1()
		{
			InitializeComponent();
			drawArea = new DrawArea();
			Controls.Add(drawArea);
			drawArea.UpdateToolBar += drawArea_UpdateToolBar;
			DefaultSetings();
		}
		#region Mouse Function
		private void drawArea_UpdateToolBar(object sender, EventArgs e)
		{
			EnableButtonUndoRedo();
			if (drawArea.ListShapes.GetSelectedObject()!=null)
			{
				toolStripButtonDelete.Enabled = true;
			}
			else
			{
				toolStripButtonDelete.Enabled = false;
			}
		}

		private void toolStripButtonRectangle_Click(object sender, EventArgs e)
		{
			CommandRectangle();
		}

		private void toolStripButtonEllipse_Click(object sender, EventArgs e)
		{
			CommandEllipse();
		}

		private void toolStripButtonNew_Click(object sender, EventArgs e)
		{
			drawArea.Clear();
			DefaultSetings();
		}

		private void toolStripButtonPointer_Click(object sender, EventArgs e)
		{
			CommandPointer();
		}


		private void toolStripButtonDelete_Click(object sender, EventArgs e)
		{
			CommandDelete();
		}


		private void toolStripButtonUndo_Click(object sender, EventArgs e)
		{
			drawArea.Undo();
			EnableButtonUndoRedo();
		}

		private void EnableButtonUndoRedo()
		{
			toolStripButtonUndo.Enabled = drawArea.UndoEnabled();
			toolStripButtonRedo.Enabled = drawArea.RedoEnabled();

		}

		private void toolStripButtonRedo_Click(object sender, EventArgs e)
		{
			drawArea.Redo();
			EnableButtonUndoRedo();
		}
		#endregion

		#region Private Functions

		private void CommandPointer()
		{
			drawArea.ActiveShape = DrawArea.DrawShapeType.Pointer;
		}

		private void CommandEllipse()
		{
			drawArea.ActiveShape = DrawArea.DrawShapeType.Ellipse;
		}

		private void CommandDelete()
		{
			drawArea.DeleteObject();
		}
		private void CommandRectangle()
		{
			drawArea.ActiveShape = DrawArea.DrawShapeType.Rectangle;
		}
		private void DefaultSetings()
		{
			EnableButtonUndoRedo();
			this.toolStripButtonDelete.Enabled = false;
			drawArea.ActiveShape = DrawArea.DrawShapeType.Pointer;
		}
		#endregion
	}
}

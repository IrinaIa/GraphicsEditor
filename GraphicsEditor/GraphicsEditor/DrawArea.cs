using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphicsEditor.Actions;
using GraphicsEditor.Commands;

namespace GraphicsEditor
{
	
	public partial class DrawArea : UserControl
	{
		#region Enum
		public enum DrawShapeType
		{
			Pointer,
			Rectangle,
			Ellipse,
			NumberOfDrawShapes
		}
		#endregion

		#region Event
		public event EventHandler UpdateToolBar;
		#endregion

		#region Private Field
		private ListShapes listShapes;
		private GraphicsEditor.Actions.Action[] actions;
		private UndoRedoManager uRManager;
		#endregion
		#region Property
		public DrawShapeType ActiveShape 
		{ get; set; }
		public ListShapes ListShapes 
		{ 
			get 
			{ 
				return listShapes; 
			} 
		}
		#endregion
		#region Constructor
		public DrawArea()
		{
			InitializeComponent();
			ActiveShape = DrawShapeType.Pointer;
			listShapes = new ListShapes();
			uRManager = new UndoRedoManager(listShapes);
			
			actions = new GraphicsEditor.Actions.Action[(int)DrawShapeType.NumberOfDrawShapes];
			actions[(int)DrawShapeType.Pointer] = new ActionPointer();
			actions[(int)DrawShapeType.Rectangle] = new ActionRectangle();
			actions[(int)DrawShapeType.Ellipse] = new ActionEllipse();
			
		}
		#endregion
		#region Private Function
		private void DrawArea_MouseDown(object sender, MouseEventArgs e)
		{
			
			if (e.Button == MouseButtons.Left)
			{
				actions[(int)ActiveShape].OnMouseDown(this, e);
			}
		}

		private void DrawArea_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				actions[(int)ActiveShape].OnMouseUp(this, e);
			}
			if (ActiveShape != DrawShapeType.Pointer)
			{
				uRManager.AddCommandToHistory(new CommandAdd(listShapes.GetLastObject()));
			}
			Refresh();
		}

		private void DrawArea_Paint(object sender, PaintEventArgs e)
		{
			if (ListShapes != null)
			{
				ListShapes.Draw(e.Graphics);
			}
		}

		private void DrawArea_MouseMove(object sender, MouseEventArgs e)
		{
			actions[(int)ActiveShape].OnMouseMove(this, e);
			
		}

		#endregion
		#region Public Function
		public void Undo()
		{
			if (uRManager.CanUndo)
			{
				uRManager.Undo();
				Refresh();
			}
		}

		public void Redo()
		{
			if (uRManager.CanRedo)
			{
				uRManager.Redo();
				Refresh();
			}
		}
		public bool UndoEnabled()
		{
			return this.uRManager.CanUndo;
		}

		public bool RedoEnabled()
		{
			return this.uRManager.CanRedo;
		}

		public void DeleteObject()
		{		
			uRManager.AddCommandToHistory(new CommandDelete(listShapes.GetSelectedObject()));
			listShapes.DeleteShape(listShapes.GetSelectedObject());
			Refresh();
		}

		public void Clear()
		{
			listShapes.Clear();
			uRManager.ClearHistory();
			Refresh();
		}
		public override void Refresh()
		{
			if (UpdateToolBar != null)
			{
				UpdateToolBar(this, EventArgs.Empty) ;
			}
			base.Refresh();
		}
		#endregion
	}
}


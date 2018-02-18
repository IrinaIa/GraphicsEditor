using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.Actions
{
	
	public class ActionObject: Action
	{
		#region Private fields
		private Cursor cursor;
		#endregion

		#region Properties

		/// <summary>
		/// Change Cursor for Rectangle, Ellipse.
		/// </summary>
		/// 
		protected Cursor Cursor
		{
			get { return cursor; }
			set { cursor = value; }
		}
		#endregion

		#region Functions
		public override void OnMouseUp(DrawArea drawArea, MouseEventArgs e)
		{
			drawArea.Refresh();
		}

		protected void AddNewShape(DrawArea drawArea, DrawObject o)
		{
			drawArea.ListShapes.UnselectAll();
			o.Selected = true;
			drawArea.ListShapes.Add(o);
		}
		#endregion
	}
}

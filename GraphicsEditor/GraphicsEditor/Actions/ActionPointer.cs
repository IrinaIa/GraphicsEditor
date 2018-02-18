using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.Actions
{
	class ActionPointer : Action
	{
		#region Function
		public override void OnMouseDown(DrawArea drawArea, MouseEventArgs e)
		{
			Point point = new Point(e.X, e.Y);
			drawArea.ListShapes.UnselectAll();
			drawArea.ListShapes.SetSelectedObject(point);
			
			drawArea.Refresh();
		}
		public override void OnMouseMove(DrawArea drawArea, MouseEventArgs e)
		{
			drawArea.Cursor = Cursors.Default; ;
		}
		#endregion
	}
}

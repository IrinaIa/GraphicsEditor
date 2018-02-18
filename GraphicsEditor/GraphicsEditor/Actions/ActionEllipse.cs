using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.Actions
{
	class ActionEllipse: ActionRectangle
	{
		#region Constructor
		public ActionEllipse()
		{			
			Cursor = new Cursor(GetType(), "Ellipse.cur");
		}
		#endregion

		#region Functions
		public override void OnMouseDown(DrawArea drawArea, MouseEventArgs e)
		{
			
			AddNewShape(drawArea, new DrawEllipse(e.X, e.Y, Width, Height));
		}
		public override void OnMouseMove(DrawArea drawArea, MouseEventArgs e)
		{
			drawArea.Cursor = Cursor;
		}
		#endregion
	}
}

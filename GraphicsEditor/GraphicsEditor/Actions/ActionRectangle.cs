using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphicsEditor.Shapes;
using System.Drawing;

namespace GraphicsEditor.Actions
{
	class ActionRectangle: ActionObject
	{
		#region Protected Fields
		///<summary>
		///Figure's size
		///</summary>
		protected int Width =150;
		protected int Height = 100;
		#endregion

		#region Constructor
		public ActionRectangle()
		{
			Cursor = new Cursor(GetType(), "Rectangle.cur");
		}
		#endregion

		#region Function
		public override void OnMouseDown(DrawArea drawArea, MouseEventArgs e)
		{
			AddNewShape(drawArea, new DrawRectangle(e.X, e.Y, Width, Height));
		}
		public override void OnMouseMove(DrawArea drawArea, MouseEventArgs e)
		{
			drawArea.Cursor = Cursor;
		}
		#endregion
	}
}

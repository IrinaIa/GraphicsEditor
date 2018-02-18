using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor.Shapes
{
	class DrawEllipse: DrawRectangle
	{
		#region Constructor
		public DrawEllipse()
		{
			SetRectangle(0, 0, 1, 1);		
		}
		public DrawEllipse(int x, int y, int width, int height)
		{
			Rectangle = new Rectangle(x, y, width, height);
		}
		#endregion

		#region Function
		public override DrawObject Clone()
		{
			DrawEllipse drawEllipse = new DrawEllipse();
			drawEllipse.Rectangle = Rectangle;

			DeepCopy(drawEllipse);
			return drawEllipse;
		}
		public override void Draw(Graphics g)
		{
			Pen pen;
			pen = new Pen(Color, PenWidth);
			GraphicsPath gp = new GraphicsPath();
			gp.AddEllipse(Rectangle);			
			g.DrawPath(pen, gp);
		
			gp.Dispose();
			pen.Dispose();
		}
		#endregion

	}
}

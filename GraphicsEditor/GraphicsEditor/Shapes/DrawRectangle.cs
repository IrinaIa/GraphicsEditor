using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor.Shapes
{
	class DrawRectangle: DrawObject
	{
		#region Private Fields
		private Rectangle rectangle;
		#endregion

		#region Property
		protected Rectangle Rectangle 
		{ 
			get 
			{ 
				return rectangle; 
			} 
			set 
			{ 
				rectangle = value; 
			} 
		}
		#endregion

		#region Constructor
		public DrawRectangle()
		{
			SetRectangle(0, 0, 1, 1);
		}

		public DrawRectangle(int x, int y, int width, int height)
		{
			SetRectangle(x, y, width, height);
		}
		#endregion

		#region Function
		protected void SetRectangle(int x, int y, int width, int height)
		{
			rectangle.X = x;
			rectangle.Y = y;
			rectangle.Width = width;
			rectangle.Height = height;
		}

		public override DrawObject Clone()
		{
			DrawRectangle drawRectangle = new DrawRectangle();
			drawRectangle.rectangle = rectangle;

			DeepCopy(drawRectangle);
			return drawRectangle;
		}

		public override void Draw(Graphics g)
		{
			Pen pen;
			pen = new Pen(Color, PenWidth);
			GraphicsPath gp = new GraphicsPath();
			gp.AddRectangle(Rectangle);
			g.DrawPath(pen, gp);
			
			gp.Dispose();
			pen.Dispose();
		}

		public override Rectangle[] GetHandleRectangle()
		{
			int sideTracker = 6;
			return new Rectangle[] {	
			new Rectangle(rectangle.X-sideTracker/2, rectangle.Y-sideTracker/2, sideTracker, sideTracker),
			new Rectangle(rectangle.X + rectangle.Width-sideTracker/2, rectangle.Y-sideTracker/2, sideTracker, sideTracker),
			new Rectangle(rectangle.X-sideTracker/2 , rectangle.Y+ rectangle.Height-sideTracker/2, sideTracker, sideTracker),
			new Rectangle(rectangle.X +rectangle.Width-sideTracker/2, rectangle.Y+ rectangle.Height-sideTracker/2, sideTracker, sideTracker)};
		}

		public override bool PointInObject(Point point)
		{
			return rectangle.Contains(point);
		}

		#endregion
	}

}

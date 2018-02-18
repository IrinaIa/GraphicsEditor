using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor.Shapes
{
	public abstract class DrawObject
	{
		#region Properties

		public Color Color { get; set; }

		public int PenWidth { get; set; }

		public bool Selected { get; set; }

		public int ID { get; set; }

		#endregion
		#region Constructor
		public DrawObject()
		{
			Color = Color.Black;
			PenWidth = 1;
			ID = GetHashCode();
		}
		#endregion

		public abstract DrawObject Clone();

		#region Virtual Functions

		public virtual void Draw(Graphics g)
		{
		}
		public virtual bool PointInObject(Point point)
		{
			return false;
		}
		public virtual void DrawTracker(Graphics g)
		{
			if (!Selected)
				return;
			SolidBrush brush = new SolidBrush(Color.Black);
			
			g.FillRectangles(brush, GetHandleRectangle());
			
			brush.Dispose();
		}
		protected virtual void DeepCopy(DrawObject drawRectangle)
		{
			drawRectangle.Selected = Selected;
			drawRectangle.Color = Color;
			drawRectangle.PenWidth = PenWidth;
			drawRectangle.ID = ID;
		}

		public virtual Rectangle[] GetHandleRectangle()
		{
			return new Rectangle[] {};
		}
		#endregion		
	}
}

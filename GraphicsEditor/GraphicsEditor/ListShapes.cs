using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicsEditor.Shapes;

namespace GraphicsEditor
{
	/// <summary>
	/// what shapes on the field
	/// </summary>
	public class ListShapes
	{
		#region Private Field
		private List<DrawObject> list;
		#endregion
		#region Constructor
		public ListShapes()
		{
			list = new List<DrawObject>();
		}
		#endregion
		#region Function
		public void UnselectAll()
		{
			foreach (DrawObject o in list)
			{
				o.Selected = false;
			}
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Add(DrawObject o)
		{
			list.Insert(0, o);
		}
		
		public void SetSelectedObject(Point p)
		{
			foreach (DrawObject item in list)
			{
				if (item.PointInObject(p))
				{
					item.Selected = true;		
				}
			}
		
		}

		public void Draw(Graphics graphics)
		{
			int numberObjects = list.Count;

			
			for (int i = numberObjects - 1; i >= 0; i--)
			{
				DrawObject o;
				o = list[i];
				o.Draw(graphics);

				if (o.Selected)
					o.DrawTracker(graphics);
			}
		}

		public void DeleteLastAddedObject()
		{
			if (list.Count > 0)
			{
				list.RemoveAt(0);
			}
		}

		public void DeleteShape(DrawObject drawObject)
		{
			foreach (DrawObject o in list)
				{
					if (drawObject.ID ==
						o.ID)
					{
						list.Remove(o);
						return;
					}
				}
		}

		public DrawObject GetLastObject()
		{
			if (list.Count > 0)
			{
				return list[0];
			};
			return null;
		}

		public DrawObject GetSelectedObject()
		{
			foreach (DrawObject obj in list)
			{
				if (obj.Selected)
				{
					return obj;
				}
			}
			return null;
		}
		#endregion
	}
}

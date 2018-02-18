using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.Commands
{
	public class CommandDelete: Command
	{
		#region Private Field
		DrawObject drawObject;
		#endregion

		#region Constructor
		public CommandDelete(DrawObject dObject)
		{
				drawObject = dObject.Clone();		
		}
		#endregion

		#region Function
		public override void Undo(ListShapes list)
		{
			list.UnselectAll();
			list.Add(drawObject);
		}

		public override void Redo(ListShapes list)
		{
			list.DeleteShape(drawObject);
		}
		#endregion
	}
}

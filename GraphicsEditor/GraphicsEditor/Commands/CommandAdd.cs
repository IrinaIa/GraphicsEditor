using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.Commands
{
	public class CommandAdd: Command
	{
		#region Private Fields
		DrawObject drawObject;
		#endregion

		#region Constructor
		public CommandAdd(DrawObject dObject)
		{	
				drawObject = dObject.Clone();
		}
		#endregion

		#region Function
		public override void Redo(ListShapes list)
		{
			list.UnselectAll();
			list.Add(drawObject);
		}

		public override void Undo(ListShapes list)
		{
			list.DeleteLastAddedObject();
		}
		#endregion
	}
}

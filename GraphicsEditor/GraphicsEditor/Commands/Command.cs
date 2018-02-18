using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor.Commands
{
	public abstract class Command
	{
		public abstract void Undo(ListShapes list);


		public abstract void Redo(ListShapes list);
	
	}
}

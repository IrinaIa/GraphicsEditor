using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsEditor.Actions
{
	public abstract class Action
	{
		public virtual void OnMouseDown(DrawArea drawArea, MouseEventArgs e)
		{
		}


		public virtual void OnMouseMove(DrawArea drawArea, MouseEventArgs e)
		{
		}


		public virtual void OnMouseUp(DrawArea drawArea, MouseEventArgs e)
		{
		}
	}
}

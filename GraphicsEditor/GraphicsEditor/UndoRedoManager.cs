﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicsEditor.Commands;

namespace GraphicsEditor
{
	class UndoRedoManager
	{
		#region Class Members
		private ListShapes list;

		private List<Command> historyList;
		private int nextUndo;
		#endregion  Class Members

		#region Constructor
		public UndoRedoManager(ListShapes _list)
		{
			list = _list;

			ClearHistory();
		}
		#endregion Constructor

		#region Properties
		
		public bool CanUndo
		{
			get
			{
				if (nextUndo < 0 ||
					nextUndo > historyList.Count - 1) // precaution
				{
					return false;
				}

				return true;
			}
		}

		public bool CanRedo
		{
			get
			{
				if (nextUndo == historyList.Count - 1)
				{
					return false;
				}

				return true;
			}
		}
		#endregion Properties

		#region Public Functions
		
		public void ClearHistory()
		{
			historyList = new List<Command>();
			nextUndo = -1;
		}
		public void AddCommandToHistory(Command command)
		{
			
			TrimHistoryList();
			historyList.Add(command);
			nextUndo++;
		}

		public void Undo()
		{
			if (!CanUndo)
			{
				return;
			}		
			Command command = historyList[nextUndo];		
			command.Undo(list);
			nextUndo--;
		}

		
		public void Redo()
		{
			if (!CanRedo)
			{
				return;
			}

			int itemToRedo = nextUndo + 1;
			Command command = historyList[itemToRedo];
			command.Redo(list);
			nextUndo++;
		}
		#endregion Public Functions

		#region Private Functions
		private void TrimHistoryList()
		{
			
			if (historyList.Count == 0)
			{
				return;
			}	
			if (nextUndo == historyList.Count - 1)
			{
				return;
			}
			for (int i = historyList.Count - 1; i > nextUndo; i--)
			{
				historyList.RemoveAt(i);
			}
		}
		#endregion
	}
}

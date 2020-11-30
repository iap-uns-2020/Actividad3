using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BoardCreation.Model
{
	public interface IBoardManager
	{
		void Load(int level);
		int GetRows();
		int GetCols();
		string GetLevelToPlay();
	}
}

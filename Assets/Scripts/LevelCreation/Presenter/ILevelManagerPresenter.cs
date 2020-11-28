
namespace LevelCreation.Presenter
{
	public interface ILevelManagerPresenter
	{
		void Load(int levelNumber);
		int GetRows();
		int GetCols();
		string GetLevelToPlay();
	}
}
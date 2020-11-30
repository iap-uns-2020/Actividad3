
namespace BoardCreation.Presenter
{
	public interface IBoardManagerPresenter
	{
		void Load(int levelNumber);
		int GetRows();
		int GetCols();
		string GetLevelToPlay();
	}
}
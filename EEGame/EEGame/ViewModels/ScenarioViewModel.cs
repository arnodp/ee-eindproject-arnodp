using FreshMvvm;
using System.Windows.Input;
using Xamarin.Forms;

namespace EEGame.ViewModels
{
    public class ScenarioViewModel : FreshBasePageModel
    {
        public ICommand StartGameCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<GameViewModel>(true);
            });
    }
}

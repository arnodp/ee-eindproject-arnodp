using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using FreshMvvm;
using Xamarin.Forms;

namespace EEGame.ViewModels
{
    public class MainViewModel : FreshBasePageModel
    {


        public ICommand StartGameCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<ScenarioViewModel>(true);
            });
        public ICommand ContinueCommand => new Command(
            async () =>
            {
                //nothing yet
            });
        public ICommand OpenSettingsCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<SettingsViewModel>(true);
            });
        public ICommand OpenHistoryCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<HistoryViewModel>(true);
            });
    }
}

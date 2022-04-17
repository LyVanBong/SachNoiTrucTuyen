using Prism.Mvvm;
using SachNoiTrucTuyen.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace SachNoiTrucTuyen.ViewModels
{
    public class FavouriteAudioPageViewModel : BindableBase
    {
        private ObservableCollection<Audio> _favouriteAudioResult;

        public ObservableCollection<Audio> FavouriteAudioResult
        {
            get => _favouriteAudioResult;
            set => SetProperty(ref _favouriteAudioResult, value);
        }

        public FavouriteAudioPageViewModel()
        {
            FavouriteAudioResult = new ObservableCollection<Audio>(App.Knowledges.Skip(2));
        }
    }
}
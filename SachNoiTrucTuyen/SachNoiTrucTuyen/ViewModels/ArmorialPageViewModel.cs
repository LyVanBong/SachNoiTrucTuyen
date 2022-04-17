using Prism.Mvvm;
using SachNoiTrucTuyen.Models;
using System.Collections.ObjectModel;

namespace SachNoiTrucTuyen.ViewModels
{
    public class ArmorialPageViewModel : BindableBase
    {
        public ObservableCollection<Armorial> Armorials { get; set; }

        public ArmorialPageViewModel()
        {
            Armorials = App.Armorials;
        }
    }
}
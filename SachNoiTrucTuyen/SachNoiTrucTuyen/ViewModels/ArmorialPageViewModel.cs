using Prism.Commands;
using Prism.Mvvm;
using SachNoiTrucTuyen.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

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

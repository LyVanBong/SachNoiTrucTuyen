using Prism.Commands;
using Prism.Mvvm;
using SachNoiTrucTuyen.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace SachNoiTrucTuyen.ViewModels
{
    public class NotificationPageViewModel : BindableBase
    {    
        public ObservableCollection<Notification> Notifications { get; set; }
        public NotificationPageViewModel()
        {
            Notifications = App.Notifications;
            AllReadedCommmand = new Command(()=>
            {
                Notifications.ForEach(n => n.IsActive = true);
            });
        }
        public Command AllReadedCommmand { get; set; }
    }
}

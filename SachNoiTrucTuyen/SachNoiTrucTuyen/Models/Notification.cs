using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace SachNoiTrucTuyen.Models
{
    public class Notification : BindableBase
    {
        public string Title { get; set; }
        private bool _isActive;
        public bool IsActive { get => _isActive; set => SetProperty(ref _isActive, value); }
        public string Description { get; set; }
        private DateTime _time;
        public DateTime Time 
        { 
            get => _time; 
            set
            {
                StrTime = SetTime(DateTime.Now, value);
                SetProperty(ref _time, value);
            }
        }
        public string StrTime { get; set; }
        public string SetTime(DateTime time, DateTime now)
        {
            double sc = now.Subtract(time).TotalSeconds;
            double mn = now.Subtract(time).TotalMinutes;
            double hs = now.Subtract(time).TotalHours;
            double day = now.Subtract(time).TotalDays;
            if (sc < 10)
            {
                return "Vài giây trước";
            }
            else if (sc > 10 && sc < 60)
            {
                return sc + " giây trước";
            }
            else if(sc >= 60 && mn < 60)
            {
                return mn + " phút trước";
            }
            else if (mn >= 60 && hs < 24)
            {
                return hs + " giờ trước";
            }
            else if (hs > 24 && day < 31)
            {
                return day + " ngày trước";
            }
            else 
            {
                return time.ToString("dd/MM/yyyy HH:mm:ss");
            }
        }
    }
}

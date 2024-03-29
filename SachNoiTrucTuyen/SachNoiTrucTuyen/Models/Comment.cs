﻿using System;
using System.Collections.ObjectModel;

namespace SachNoiTrucTuyen.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public ObservableCollection<Comment> ReplyComment { get; set; }
        public int Status { get; set; }
        public string Avatar { get; set; }
    }
}
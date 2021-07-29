﻿using SQLite;
using System;
using System.ComponentModel;

namespace Manage.Base
{
    public class Model : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaiseNotification(String property) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));

        #region Properties

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        #endregion
    }
}

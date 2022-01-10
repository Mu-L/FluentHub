﻿using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentHub.DataModels
{
    public class TabItem : INotifyPropertyChanged
    {
        private string _header;
        public string Header
        {
            get => _header;
            set
            {
                _header = value;
                NotifyPropertyChanged(nameof(Header));
            }
        }

        private FontIconSource _iconSource;
        public FontIconSource IconSource
        {
            get => _iconSource;
            set
            {
                _iconSource = value;
                NotifyPropertyChanged(nameof(IconSource));
            }
        }

        private List<string> _pageUrl = new List<string>();
        public List<string> PageUrl
        {
            get => _pageUrl;
            set
            {
                _pageUrl = value;
                NotifyPropertyChanged(nameof(PageUrl));
            }
        }

        private int _naviationIndex;
        public int NavigationIndex
        {
            get => _naviationIndex;
            set
            {
                _naviationIndex = value;
                NotifyPropertyChanged(nameof(NavigationIndex));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
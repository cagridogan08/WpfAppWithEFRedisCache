﻿using System.Windows;
using WpfAppWithRedisCache.ViewModels;

namespace WpfAppWithRedisCache
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MainViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
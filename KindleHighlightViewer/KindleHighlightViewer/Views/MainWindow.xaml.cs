﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using KindleHighlightViewer.ViewModels;

namespace KindleHighlightViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            (this.DataContext as MainViewModel).CopyCommand(sender, e);
        }

        private void ByAuthor(object sender, ExecutedRoutedEventArgs e)
        {
            (this.DataContext as MainViewModel).OrderCommand(c => c.Author);
        }

        private void ByTitle(object sender, ExecutedRoutedEventArgs e)
        {
            (this.DataContext as MainViewModel).OrderCommand(c => c.Title);
        }
    }
}

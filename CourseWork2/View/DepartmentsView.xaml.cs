﻿using System.Windows.Controls;
using System.Windows.Media;

namespace CourseWork2.View;

public partial class DepartmentsView
{
    public DepartmentsView()
    {
        InitializeComponent();
    }

    private void SearchBox_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        if (!sender.Equals(SearchBox))
        {
            return;
        }

        SearchBox.Background = string.IsNullOrEmpty(SearchBox.Text)
            ? (ImageBrush)FindResource("Watermark") : null;
    }
}
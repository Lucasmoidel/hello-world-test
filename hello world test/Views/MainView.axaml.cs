using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace hello_world_test.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }
    private void YES_Button_Click(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("ysss");
        //MessageBox.Show("Hello world!");
    }
    private void NO_Button_Click(object sender, RoutedEventArgs e)
    {
        System.Environment.Exit(0);
    }
}

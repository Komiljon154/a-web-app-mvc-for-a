using System.Windows;
using System.Windows.Input;
using HandyControl.Controls;
using MusicHub.Wpf.ViewModels;

namespace MusicHub.Wpf.Views;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public ICommand SwitchViewCommand { get; }

    public MainWindow(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
        SwitchViewCommand = new RelayCommand(p => SwitchView((ViewModelBase)p!));
    }

    private void SwitchView(ViewModelBase viewModel)
    {
        if (DataContext is MainViewModel mainVM)
        {
            mainVM.CurrentViewModel = viewModel;
        }
    }
}

// Simple RelayCommand implementation
public class RelayCommand : ICommand
{
    private readonly Action<object> _execute;
    public RelayCommand(Action<object> execute) => _execute = execute;
    public bool CanExecute(object? parameter) => true;
    public void Execute(object? parameter) => _execute(parameter!);
    public event EventHandler? CanExecuteChanged;
}

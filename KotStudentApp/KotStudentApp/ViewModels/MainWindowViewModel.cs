using KotStudentApp.Core;
using System.Windows;
using System.Windows.Input;
using System;
using System.Threading.Tasks;

namespace KotStudentApp
{
    class MainWindowViewModel : ViewModelBase
    {
        #region Private Variables

        private Window mWindow;

        private WindowResizer wWindowResizer;

        private WindowDockPosition mDockPosition = WindowDockPosition.Undocked;

        private int mOutMargin = 8;

        #endregion

        #region Public Properties

        /// <summary>
        /// MainWindow title text!
        /// </summary>
        public string Title { get; set; } = "Kot #Student";

        /// <summary>
        /// The smallest width the window can go to
        /// </summary>
        public double WindowMinimumWidth { get; set; } = 850;

        /// <summary>
        /// The smallest height the window can go to
        /// </summary>
        public double WindowMinimumHeight { get; set; } = 550;

        /// <summary>
        /// True if the window should be borderless because it is docked or maximized
        /// </summary>
        public bool Borderless => (mWindow.WindowState == WindowState.Maximized || mDockPosition != WindowDockPosition.Undocked);

        /// <summary>
        /// The size of the resize border around the window
        /// </summary>
        public int ResizeBorder => Borderless ? 0 : 6;

        /// <summary>
        /// Margin Outer of MainWindow
        /// </summary>
        public int OutMarginSize
        {
            get => mWindow.WindowState == WindowState.Maximized ? 0 : mOutMargin;
            set => mOutMargin = value;
        }   

        /// <summary>
        /// Setting padding MainWindow
        /// </summary>
        public Thickness ResizeBorderThickness => new Thickness(ResizeBorder + OutMarginSize);

        /// <summary>
        /// Margin Outer of MainWindow
        /// </summary>
        public Thickness OutMarginSizeThickness { get { return new Thickness(OutMarginSize); } }

        public Thickness InnerContentPadding { get; set; } = new Thickness(0);

        /// <summary>
        /// TitibleBar height
        /// </summary>
        public int TitleHeight { get; set; } = 36;

        public GridLength TitleHeightGridLength => new GridLength(TitleHeight + ResizeBorder);

        #endregion

        #region Commands

        /// <summary>
        /// Minimalization click
        /// </summary>
        public ICommand MinimalizeCommand { get; set; }
        
        /// <summary>
        /// Maximalization click
        /// </summary>
        public ICommand MaximalizationCommand { get; set; }

        /// <summary>
        /// Close click
        /// </summary>
        public ICommand CloseCommand { get; set; }

        /// <summary>
        /// To open profile menu
        /// </summary>
        public ICommand UserProfileCommand { get; set; }

        /// <summary>
        /// To open message list
        /// </summary>
        public ICommand MessageCommand { get; set; }

        /// <summary>
        /// To see alerts
        /// </summary>
        public ICommand AlertCommand { get; set; }

        #endregion

        #region CTORS
        public MainWindowViewModel(Window window)
        {
            mWindow = window;
            #region Commands
            MinimalizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);
            MaximalizationCommand = new RelayCommand(() => mWindow.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(() => mWindow.Close());
            UserProfileCommand = new RelayCommand(async () => await ProfilAsync());
            MessageCommand = new RelayCommand(async () => await Test());
            #endregion

            wWindowResizer = new WindowResizer(mWindow);

            mWindow.StateChanged += (sender, e) =>
            {
                // Fire off events for all properties that are affected by a resize
                WindowResizer();
            };

            wWindowResizer.WindowDockChanged += (dock) =>
            {
                // Store last position
                mDockPosition = dock;

                // Fire off resize events
                WindowResizer();
            };

        }

        private async Task ProfilAsync()
        {
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.Profile);

            await Task.Delay(1);
        }

        private async Task Test()
        {
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.DashboardScreen);

            await Task.Delay(1);
        }
        #endregion

        #region Helpers

        private void WindowResizer()
        {
            
            OnPropertyChanged(nameof(ResizeBorder));
            OnPropertyChanged(nameof(ResizeBorderThickness));
            OnPropertyChanged(nameof(OutMarginSize));
            OnPropertyChanged(nameof(OutMarginSizeThickness));
        }

        #endregion

    }
}

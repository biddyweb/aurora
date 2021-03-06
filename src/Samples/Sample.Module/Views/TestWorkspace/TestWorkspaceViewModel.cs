﻿using Aurora.Core;
using System.Windows.Input;

namespace Aurora.Sample.Module.Views.TestWorkspace
{
    public enum WindowType
    {
        Floating,
        Docked
    }

    public enum ViewType
    {
        TestWorkspace,
        Custom
    }

    public class TestWorkspaceViewModel : ViewModelBase
    {
        private double top;
        private double left;
        private double width;
        private double height;
        private int groupIdx;
        private int order;
        private WindowType selectedWindowType;
        private ViewType selectedViewType;
        private string title;
        private string jsonInput;
        private double dockWidth;


        public ICommand CreateViewCommand { get; set; }
        public ICommand ToggleOrientationCommand { get; set; }
        public ICommand CloseViewCommand { get; set; }

        public double Top
        {
            get { return top; }
            set
            {
                top = value;
                OnPropertyChanged();
            }
        }

        public double Left
        {
            get { return left; }
            set
            {
                left = value;
                OnPropertyChanged();
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                width = value;
                OnPropertyChanged();
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                height = value;
                OnPropertyChanged();
            }
        }

        public int GroupIdx
        {
            get { return groupIdx; }
            set
            {
                groupIdx = value;
                OnPropertyChanged();
            }
        }

        public int Order
        {
            get { return order; }
            set
            {
                order = value;
                OnPropertyChanged();
            }
        }

        public WindowType SelectedWindowType
        {
            get { return selectedWindowType; }
            set
            {
                selectedWindowType = value;
                OnPropertyChanged();
            }
        }

        public ViewType SelectedViewType
        {
            get { return selectedViewType; }
            set
            {
                selectedViewType = value;
                OnPropertyChanged();
            }
        }

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged();
            }
        }

        public string JsonInput
        {
            get { return jsonInput; }
            set
            {
                jsonInput = value;
                OnPropertyChanged();
            }
        }

        public double DockWidth
        {
            get { return dockWidth; }
            set
            {
                dockWidth = value;
                OnPropertyChanged();
            }
        }


    }
}

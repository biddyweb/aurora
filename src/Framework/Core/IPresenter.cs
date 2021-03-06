﻿using System;
using System.Threading.Tasks;

namespace Aurora.Core
{
    public interface IPresenter<TViewModel> : IPresenter
        where TViewModel : IViewModel
    {
        new TViewModel ViewModel { get;  }

        Task InitializeAsync(TViewModel viewModel);
    }

    public interface IPresenter : IDisposable
    { 
        IViewModel ViewModel { get; }

        Task InitializeAsync(IViewModel viewModel);
    }
}
﻿using Aurora.Core.Activities;
using Aurora.Core.ViewContainer;

namespace Aurora.Core.Workspace
{
    public class WorkspaceViewPresenter<TViewModel> : ViewPresenter<TViewModel, ViewActivityInfo>, IViewContainerAware
        where TViewModel : IViewModel
    {
        public WorkspaceViewPresenter(ViewActivityInfo info) : base(info)
        {

        }

        public IViewContainerService ViewContainerService { get; set; }


        public void CloseView()
        {
            ViewContainerService.CloseView();
        }

        public void SetTitle(string title)       
        {
            ViewContainerService.SetTitle(title);
        }
    }
}

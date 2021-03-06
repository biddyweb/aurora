﻿using System.Windows;
using System.Windows.Controls;
using Aurora.Core;

namespace Aurora.Controls
{
    public class ActiveViewer : Control
    {
        public static readonly DependencyProperty ActiveViewProperty = DependencyProperty.Register(
            "ActiveView", typeof(ActiveView), typeof(ActiveViewer), new PropertyMetadata(default(ActiveView), ActiveViewChanged));


        private static void ActiveViewChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var old = e.OldValue as ActiveView;
        }


        static ActiveViewer()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ActiveViewer), new FrameworkPropertyMetadata(typeof(ActiveViewer)));
        }

        public ActiveView ActiveView
        {
            get { return (ActiveView)GetValue(ActiveViewProperty); }
            set { SetValue(ActiveViewProperty, value); }
        }
    }
}

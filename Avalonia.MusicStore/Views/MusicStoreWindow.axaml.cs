using Avalonia.ReactiveUI;
using Avalonia.MusicStore.ViewModels;
using ReactiveUI;
using System;
using Avalonia.Controls;

namespace Avalonia.MusicStore.Views
{
    public partial class MusicStoreWindow : ReactiveWindow<MusicStoreViewModel>
    {
        public MusicStoreWindow()
        {
            InitializeComponent();

            // This line is needed to make the previewer happy (the previewer plugin cannot handle the following line).
            if (Design.IsDesignMode) return;

            this.WhenActivated(action => action(ViewModel!.BuyMusicCommand.Subscribe(Close)));
        }
    }
}
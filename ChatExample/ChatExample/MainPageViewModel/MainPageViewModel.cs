using ChatExample.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ChatExample.MainPageViewModel
{
    public  class MainPageViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Message> ListMessages { get; }
        public ICommand SendCommand { get; set; }


        public MainPageViewModel()
        {
            ListMessages = new ObservableRangeCollection<Message>();

            SendCommand = new Command(() =>
            {
                if (!String.IsNullOrWhiteSpace(OutText))
                {
                    var message = new Message
                    {
                        Text = OutText,
                        IsTextIn = false,
                        MessageDateTime = DateTime.Now
                    };


                    ListMessages.Add(message);
                    OutText = "";
                }

            });

        }


        public string OutText
        {
            get { return _outText; }
            set { SetProperty(ref _outText, value); }
        }
        string _outText = string.Empty;
    }
}
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

            var messages1 = new Message
            {
                Text = "Hy",
                IsTextIn = false,
                MessageDateTime = DateTime.Now
            };

            var messages2 = new Message
            {
                Text = "Hy",
                IsTextIn = true,
                MessageDateTime = DateTime.Now
            };

            var messages3 = new Message
            {
                Text = "Test",
                IsTextIn = true,
                MessageDateTime = DateTime.Now
            };

            var messages4 = new Message
            {
                Text = "Test",
                IsTextIn = false,
                MessageDateTime = DateTime.Now
            };

            var messages5 = new Message
            {
                Text = "Tes1",
                IsTextIn = false,
                MessageDateTime = DateTime.Now
            };

            ListMessages.Add(messages1);
            ListMessages.Add(messages2);
            ListMessages.Add(messages3);
            ListMessages.Add(messages4);
            ListMessages.Add(messages5);
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
  public override async void PressedSendButton(UIButton button, string text, string senderId, string senderDisplayName, NSDate date)
        {
            //asenkron bir þekilde bizden verileri yineli olarak alýyor.
            InputToolbar.ContentView.TextView.Text = "";
            InputToolbar.ContentView.RightBarButtonItem.Enabled = false;
            SystemSoundPlayer.PlayMessageSentSound();
 
           
            var message = new Message("2CC8343", "Sen", NSDate.Now, text);
            messages.Add(message);
            FinishReceivingMessage(true);
 
            //giriþ imgesini bot için normalize hale getiriyoruz.
            ShowTypingIndicator = true;
 
            //botumuza mesaj gönderip iþlenmesini saðlýyoruz ve devamýnda cevap alýyoruz.
            ms = await SendMessage(text);
 
            //cevap verilen kýsým burasý oluyor.
            while (ms.messages.Length &gt; messageCount)
            {
                if (ms.messages[messageCount].from == "XamarinBot")
                {
 
                    ScrollToBottom(true);
 
                    SystemSoundPlayer.PlayMessageReceivedSound();
 
                    var messageBot = new Message(friend.Id, friend.DisplayName, NSDate.Now, ms.messages[messageCount].text);
                    messages.Add(messageBot);
 
                    FinishReceivingMessage(true);
                    InputToolbar.ContentView.RightBarButtonItem.Enabled = true;
 
                }
                messageCount++;
            }
        }
  public override async void PressedSendButton(UIButton button, string text, string senderId, string senderDisplayName, NSDate date)
        {
            //asenkron bir �ekilde bizden verileri yineli olarak al�yor.
            InputToolbar.ContentView.TextView.Text = "";
            InputToolbar.ContentView.RightBarButtonItem.Enabled = false;
            SystemSoundPlayer.PlayMessageSentSound();
 
           
            var message = new Message("2CC8343", "Sen", NSDate.Now, text);
            messages.Add(message);
            FinishReceivingMessage(true);
 
            //giri� imgesini bot i�in normalize hale getiriyoruz.
            ShowTypingIndicator = true;
 
            //botumuza mesaj g�nderip i�lenmesini sa�l�yoruz ve devam�nda cevap al�yoruz.
            ms = await SendMessage(text);
 
            //cevap verilen k�s�m buras� oluyor.
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
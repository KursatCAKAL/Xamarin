        public override async void ViewYapýmLoad()
        {
            base.ViewDidLoad();
 
            CollectionView.BackgroundColor = new UIColor(red: 0.00f, green: 0.12f, blue: 0.31f, alpha: 1.0f);
            Title = "Xamarin Konuş Benimle";
 
            // HTTPClient için instance oluþturduk ve DirectLine botumuzun confuguration ayarlarýný saðladýk.
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://directline.botframework.com/api/conversations/");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("BotConnector",
                DirectLineKey);
            var response = await _client.GetAsync("/api/tokens/");
            if (response.IsSuccessStatusCode)//Json haberleþmesinin olduðu kýsým
            {
                var conversation = new Conversation();
                HttpContent contentPost = new StringContent(JsonConvert.SerializeObject(conversation), Encoding.UTF8,
                    "application/json");
                response = await _client.PostAsync("/api/conversations/", contentPost);
                if (response.IsSuccessStatusCode)
                {
                    var conversationInfo = await response.Content.ReadAsStringAsync();
                    _lastConversation = JsonConvert.DeserializeObject(conversationInfo);
                }
 
            }
 
            //Gönderilen ýd için bir display isim veriyoruz
            SenderId = sender.Id;
            SenderDisplayName = sender.DisplayName;
 
        
            var bubbleFactory = new MessagesBubbleImageFactory();
            outgoingBubbleImageData = bubbleFactory.CreateOutgoingMessagesBubbleImage(UIColorExtensions.MessageBubbleLightGrayColor);
            incomingBubbleImageData = bubbleFactory.CreateIncomingMessagesBubbleImage(new UIColor(red: 0.88f, green: 0.07f, blue: 0.55f, alpha: 1.0f));
 
        
            InputToolbar.ContentView.LeftBarButtonItem = null;
 
 
           
            CollectionView.CollectionViewLayout.IncomingAvatarViewSize = CoreGraphics.CGSize.Empty;
            CollectionView.CollectionViewLayout.OutgoingAvatarViewSize = CoreGraphics.CGSize.Empty;
 
  
            messages.Add(new Message(friend.Id, friend.DisplayName, NSDate.DistantPast, "Ben bir botum abi :)"));
            FinishReceivingMessage(true);
        }

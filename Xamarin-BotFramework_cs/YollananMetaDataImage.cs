    MessagesBubbleImage outgoingBubbleImageData, incomingBubbleImageData;
        List messages = new List();
        int messageCount = 0;
        private HttpClient _client;
        private Conversation _lastConversation;
        string DirectLineKey = "[Add Direct Line Key]";
 
        //Mesajla�ma hiyerar�inisini sa�lar.
        User sender = new User { Id = "2CC8343", DisplayName = "Sen" };
        User friend = new User { Id = "BADB229", DisplayName = "Xamarin Bot" };
 
     
        //Session yard�m�yla girilen mesajlar� Session �al��mas� ba�lam�nda tutuyoruz.
        MessageSet ms = new MessageSet();
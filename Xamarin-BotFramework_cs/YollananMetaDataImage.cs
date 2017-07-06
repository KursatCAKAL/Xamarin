    MessagesBubbleImage outgoingBubbleImageData, incomingBubbleImageData;
        List messages = new List();
        int messageCount = 0;
        private HttpClient _client;
        private Conversation _lastConversation;
        string DirectLineKey = "[Add Direct Line Key]";
 
        //Mesajlaþma hiyerarþinisini saðlar.
        User sender = new User { Id = "2CC8343", DisplayName = "Sen" };
        User friend = new User { Id = "BADB229", DisplayName = "Xamarin Bot" };
 
     
        //Session yardýmýyla girilen mesajlarý Session çalýþmasý baðlamýnda tutuyoruz.
        MessageSet ms = new MessageSet();
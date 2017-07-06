public async Task SendMessage(string messageText)
        {
            try
            {
 
                var messageToSend = new BotMessage() { text = messageText, conversationId = _lastConversation.conversationId };
                var contentPost = new StringContent(JsonConvert.SerializeObject(messageToSend), Encoding.UTF8, "application/json");
                var conversationUrl = "https://directline.botframework.com/api/conversations/" + _lastConversation.conversationId + "/messages/";//bu donusturme url'i olmazsa api d�zg�n �al��maz entegrasyonu sa�l�yor HTTPGET ile veri al�p i�liyoruz.
 
 
                var response = await _client.PostAsync(conversationUrl, contentPost);
                var messageInfo = await response.Content.ReadAsStringAsync();
 
                var messagesReceived = await _client.GetAsync(conversationUrl);
                var messagesReceivedData = await messagesReceived.Content.ReadAsStringAsync();
 
                var messages = JsonConvert.DeserializeObject(messagesReceivedData);
 
                return messages;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);//cath i�i dolmas� ad�na b�yle bir�ey yapt�k.
                return null;
            }
        }
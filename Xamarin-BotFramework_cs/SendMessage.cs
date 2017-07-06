public async Task SendMessage(string messageText)
        {
            try
            {
 
                var messageToSend = new BotMessage() { text = messageText, conversationId = _lastConversation.conversationId };
                var contentPost = new StringContent(JsonConvert.SerializeObject(messageToSend), Encoding.UTF8, "application/json");
                var conversationUrl = "https://directline.botframework.com/api/conversations/" + _lastConversation.conversationId + "/messages/";//bu donusturme url'i olmazsa api düzgün çalýþmaz entegrasyonu saðlýyor HTTPGET ile veri alýp iþliyoruz.
 
 
                var response = await _client.PostAsync(conversationUrl, contentPost);
                var messageInfo = await response.Content.ReadAsStringAsync();
 
                var messagesReceived = await _client.GetAsync(conversationUrl);
                var messagesReceivedData = await messagesReceived.Content.ReadAsStringAsync();
 
                var messages = JsonConvert.DeserializeObject(messagesReceivedData);
 
                return messages;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);//cath içi dolmasý adýna böyle birþey yaptýk.
                return null;
            }
        }
    [LuisIntent("")]
        public async Task None(IDialogContext context, LuisResult result)
        {
        
            string message = "Siride bu tip bir yapý içerisinde bizi anlmýyor bu model yardýmýyla otomatik olarak anlaþýlmadýðýný karþý tarafa bildiriyoruz.";
            await context.PostAsync(message);
            context.Done(true);
        }
    [LuisIntent("")]
        public async Task None(IDialogContext context, LuisResult result)
        {
        
            string message = "Siride bu tip bir yap� i�erisinde bizi anlm�yor bu model yard�m�yla otomatik olarak anla��lmad���n� kar�� tarafa bildiriyoruz.";
            await context.PostAsync(message);
            context.Done(true);
        }
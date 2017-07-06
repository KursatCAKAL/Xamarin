    [LuisIntent("CustomerService")]//Servici çağıralım
        public async Task KullaniciServis(IDialogContext context, LuisResult result)
        {
            foreach(var entity in result.Entities)
            {
                if (entity.Type == "ServiceKeyword" &amp;&amp; customerSupportKeywords.Contains(entity.Entity.ToLower()))
                {
                    switch(entity.Entity.ToLower())
                    {
                        case "password":
                            PromptDialog.Text(context, SupportUsernameEntered, "Hesabýnýza entegreli e-posta adresiniz nedir?");
                            break;
                    }
                   
                }
            }
        }

    private async Task SupportUsernameEntered(IDialogContext context, IAwaitable result)
        {
            var item = await result;
            {
                if (Account.IsFound(item))
                {
                    
                    await context.PostAsync("Hesap bulunamad�, e-posta adresinize g�nderilen bilgileri do�rulay�n.");
                    context.Done(true);
                }
             
            }
        }
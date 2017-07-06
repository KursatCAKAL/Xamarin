  	public override bool FinishedLaunching(UIApplication uygulama,NSDictionary secenek)
        {
            //pencere için instance alıyoruz(UIScreen interface ile )
            window = new UIWindow(UIScreen.MainScreen.Bounds);
 
      
	    //ana viewcontroller için bir degere sahipsen burada ayarlıyorsun işlemlerini.
            window.RootViewController = new UINavigationController(new ChatPageViewController());
 
            //son olarak pencereyi görünür kılıyoruz.
            window.MakeKeyAndVisible();
 
            return true;
        }

# Xamarin

Xamarin cross-platform uygulamalarını windows,android ve ios simulatorlerde derleyerek test edebiliyoruz.
Ancak bu durumu telefonumuzda yapıp daha izlenebilir bir yapıya sahip olabiliriz.
Windows phone , iphone ve android cihazlar olmak üzere her birinde ayrı ayrı bu yapıya sahip olabiliriz.
Bu makalemde ben anroid bir cihaz üzerinde bunu nasıl yapacağımızı ele alacağım.
Xamarin.Android'i bir Android cihazda Xamarin Studio veya Visual Studio'yu kullanarak debug etmek mümkündür.
Öncelikle development işlemini gerçekleştirebilmek için cihazımızı bilgisayarımıza kurmamız gerekmekte.

Bu kurulum işlemi için 3 temel adım mevcut:

1-Aygıtta Geliştirici Modu Etkinleştirmek:Varsayılan olarak, uygulamaları bir Android cihazda debug etmek mümkün olmayacaktır.

2-USB Sürücülerini Yükle:Windows bilgisayarları,cihaza özel USB sürücülerinin yüklenmesini gerektirmektedir.

3-Aygıtı Bilgisayara Bağlayın:Son adım, aygıtı bilgisayara USB veya WiFi ile bağlamayı içerir.

Adım 1:
Bu adımda android telefonumuzda ayarlar bölümünde 'Telefon Hakkında' yı seçerek.
![alt text](https://github.com/KursatCAKAL/Xamarin/blob/master/XAMAR%C4%B0N_DEBUG_ON_DEV%C4%B0CE/1.png)
En alttaki 'derleme numarası' bir diğer deyişle 'build number' ı buluyoruz.
![alt text](https://github.com/KursatCAKAL/Xamarin/blob/master/XAMAR%C4%B0N_DEBUG_ON_DEV%C4%B0CE/2.png)
Burası 'geliştirici mod' seçeneceğini bizim için aktifleştiren komut butonu yani android'in mayasında bu işlemi aktifleştirmek bu şekilde belirlenmiş.
Derleme numarası etiketine ard arda tıklayarak (bu cihazdan cihaza değişebilir) geliştirici modu aktifleştireceğiz.
Örneğin ben aktive ettiğim için cihaz artık beni bir geliştiric olarak görüyor ve izin vermiyor.
![alt text](https://github.com/KursatCAKAL/Xamarin/blob/master/XAMAR%C4%B0N_DEBUG_ON_DEV%C4%B0CE/3.png)![alt text](https://github.com/KursatCAKAL/Xamarin/blob/master/XAMAR%C4%B0N_DEBUG_ON_DEV%C4%B0CE/4.png)
USB debugging seçeneğini telefon ile derleme işlemini gerçekleştirmek için aktifleştiriyoruz.
Artık ayarlar menümüze Developer Mode etiketi eklendi.
RESİM7

Adım2:
Android SDK manager sayesinde gerekli driver'ları yükliyeceğiz.
Gereksiz yükleme yapmak istemiyorsanız lütfen sadece 'Google USB Driver package' in seçili olduğundan emin olun işlem için bu yükleme yeterli olacak.
Kurulumu gerçekleştirdikten sonra "C:\Program Files (x86)\Android\android-sdk\extras\google\usb_driver" yolunu kontrol ediniz.
RESİM 1_ 
ŞEKLİNDE DOSYA İÇERİĞİ OLMASI GEREKİR.

Adım 3:
Geriye sadece bilgisayarımıza telefonu bağlayarak cihaz kurulumunu yüklemiş olduğumuz Google Usb Driver yolu ile özdeşleştirmek kaldı.
-Aygıtınızı bir USB kablosuyla bilgisayara bağlayın.
-Masaüstünden veya Windows Gezgini'nden Bilgisayar'ı sağ tıklatın ve Yönet'i seçin.
-Sol bölmedeki Aygıt Yöneticisini seçin.
-Taşınabilir Aygıtlar ya da Diğer Cihazlar bölmelerinden bağlı cihazımıza sağ tıklayıp sürücüyü güncelleştir diyoruz.
-Karşımıza çıkan pencereden Sürücü Yazılımı İçin Bilgisayarı Tara diyerek.
-Daha önce Google Usb Driver yüklediğimiz yolu karşımızda açılan penceredeki textbox'a girerek yüklemiş olduğumuz usb driver ile telefonumuzu özdeşleştiriyoruz.
-USB bağlantısı için işlemlerimiz bu kadar Wifi ile de bu olayları yapmak mümkün(TCP portlarını kullanarak IP adresi configurasyonu yapmamız gerekli).







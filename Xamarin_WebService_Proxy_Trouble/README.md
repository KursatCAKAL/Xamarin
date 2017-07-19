
<h4 class="override">Buradaki sorunumuz localhost üzerinde bulunan bir web service uygulamasına bağlı olan xamarin uygulamamıza verilerin düzgün bir şekilde gitmiyor olması</h4>
<h5>Görüldüğü üzere localhost üzerinde verilerimize ulaşabiliyoruz.</h5> 
<img src="https://github.com/KursatCAKAL/Xamarin/blob/master/Xamarin_WebService_Proxy_Trouble/Proxy_Confuguration_For_Android_Emulator.png">
<h5>Ayrıca şuan bu web service üzerinden console uygulamasında bile bu verileri herhangi liste,dizi,deger ve benzeri yapılar içine çekip uygulama üzerinde verilerde değişiklikler yapabiliyoruz.Ancak iş mobil uygulama olunca bu durumda bir istisna söz konusu oluyor.<h5>
<img src="https://github.com/KursatCAKAL/Xamarin/blob/master/Xamarin_WebService_Proxy_Trouble/Proxy_Confuguration_For_Android_Emulator_0.png">
<h5>Gördüğümüz gibi debug aşamasında localhost web service adresimiz verilerin asenkron olarak deserialize edeliceği yani json formattan bizim uygun model yapımıza dönüştürüleceği aşamada veri bir türlü gelmiyor</h5>
<img src="https://github.com/KursatCAKAL/Xamarin/blob/master/Xamarin_WebService_Proxy_Trouble/Proxy_Confuguration_For_Android_Emulator_1_.png">
<h5>Bu aşamada istersek web servisimizi azure veya diğer sunucular üzerinde yayına açıp bu adres üzerinden uygulamayı ayağa kaldırıp, kendi cihazımız üzerinde çalıştırabiliriz.Fakat aynı durumlar karşılaşabiliriz bu durumun sebebi cihazımızda internet bağlantısının açık olmamasıdır.Biz bu bağlantıyı cihaz üzerinden sağlamak istesek de eğer emulator cihazın üzerinde external virtual switch mevcut değil ise cihazımızın wi-fi optimizasyonu tam olmamış oluyor.</h5>
<img src="https://github.com/KursatCAKAL/Xamarin/blob/master/Xamarin_WebService_Proxy_Trouble/Proxy_Confuguration_For_Android_Emulator_3.png">
<h5>Bu optimizasyonu yapabilmek için öncelikle Hyper-V üzerinde bir switch oluşturmamız gerekiyor.Daha sonra bu switch'i hangi emulator üzerinde uygulama çalıştıracaksak o emulatorün donatılarına bir ağ adaptörü ekliyeceğiz.Emulator cihazımızın bu işlem için sahip olması gereken 2 adet adaptör mevcuttur ve aşağıda işaretlenmiştir.</h5>
<img src="https://github.com/KursatCAKAL/Xamarin/blob/master/Xamarin_WebService_Proxy_Trouble/Proxy_Confuguration_For_Android_Emulator_3_.png">
<h5>Sanal anahtar yöneticisine giriyoruz.</h5>
<img src="https://github.com/KursatCAKAL/Xamarin/blob/master/Xamarin_WebService_Proxy_Trouble/Proxy_Confuguration_For_Android_Emulator_6.png">
<h5>Emulator cihazımız üzerinde 2 adet(internal-external) switch bulunması gerektiğini söylemiştik şuanda biz external olan switch eklentisini oluşturacağız.Bu eklentiyi oluştururken dikkat etmemiz gereken şey mevcut wi-fi donanımızı kullanarak oluşturmamız gerektiğidir.Fakat ethernet kablosu ile internet erişimi sağlıyorsak bu durumu wi-fi donanımız yerine ethernet ile entegrasyon sağlayan seçeneğimizi seçebiliriz.</h5>
<img src="https://github.com/KursatCAKAL/Xamarin/blob/master/Xamarin_WebService_Proxy_Trouble/Proxy_Confuguration_For_Android_Emulator_7.png">
<h5>Şimdi sıra mevcut cihaza bu switch'i eklemekte.Bu switch'i barındıran bir ağ adaptörü oluşturuyoruz.Ve oluşturduğumuz bu ağ adaptörünü cihazımıza ekliyeceğiz.</h5>
<img src="https://github.com/KursatCAKAL/Xamarin/blob/master/Xamarin_WebService_Proxy_Trouble/Proxy_Confuguration_For_Android_Emulator_4.png">
<h5></h5>
<img src="https://github.com/KursatCAKAL/Xamarin/blob/master/Xamarin_WebService_Proxy_Trouble/Proxy_Confuguration_For_Android_Emulator_5.png">


<img src="https://github.com/KursatCAKAL/Xamarin/blob/master/Xamarin_WebService_Proxy_Trouble/Proxy_Confuguration_For_Android_Emulator_8.png">
<img src="https://github.com/KursatCAKAL/Xamarin/blob/master/Xamarin_WebService_Proxy_Trouble/Proxy_Confuguration_For_Android_Emulator_9.png">
<img src="https://github.com/KursatCAKAL/Xamarin/blob/master/Xamarin_WebService_Proxy_Trouble/Proxy_Confuguration_For_Android_Emulator_10.png">

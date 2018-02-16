# Product_Analysis
TARIM ÜRÜNLERİ ANALİZİ
- Mehmet Ersoy-Ömer Batır / 2016 -

Her tarım ürünü her bölgede yetiştirilemez. Ürünlerin yetişebildiği çeşitli iklim koşulları vardır.
Bulunulan bölgeye elverişli olan tarım ürünü seçimi, o bölgenin çeşitli iklim koşulları göz önünde bulundurularak karar verilmelidir.

Bu seçim işlemi, geçmiş deneyimlerden yola çıkılarak karar verilebilir.

Örneğin, Türkiye’de çay yetiştiriciliği yapmaya elverişli bölgelerin iklim koşulları aşağıda verilmiştir.

Max Sıcaklık: 35 °C
Min Sıcaklık: 10 °C
Ortalama Nem: 70.9
Yağış: 828 mm
Deniz Kenarı mı?: EVET

Geçmiş deneyimlerden yararlanıp, çeşitli sınıflandırma yöntemleri kullanılarak bu seçim işlemine yardımcı bir uygulama geliştirilebilir.

Weka yazılımı kullanarak bu deneyimlerin var olduğu veri setlerini kullanıp, çeşitli algoritmalar uyguladıktan sonra sistemin başarısını, hangi algoritmanın daha verimli olduğuna karar verip gözlemleyebiliriz.

Veri setlerini kullarak yapılan eğitim işleminden sonra ürün yetiştirmeyi düşündüğümüz bölge özelliklerini kullanıcıdan isteyip ürün ile ilgili bir kestirimde bulunması istenebilir.

Weka, java dilinde yazılmış olmasından dolayı kolaylıkla java ortamında da weka klasörü içerisindeki weka.jar dosyası projeye dahil edilip çeşitli kütüphaneleri ekleyerek kullanılabilir.

Aynı zamanda Weka işlemleri .NET ortamında da kullanılabilmektedir.

# NASIL ?
# .NET ortamında Weka’yı kullanabilmek için IKVM denilen .NET ve Java’yı bir arada kullanılmasını sağlayan kütüphane referans olarak projeye dahil edilmelidir. Ancak içerisinde hem Weka kütüphanesini hem de IKVM'yi birlikte barındıran ve ayrı ayrı kurulumlar yapmamıza gerek kalmayan "PicNet ML" adlı bir kütüphane vardır. Bunu kurmamız yeterlidir.

1-) TOOLS MENÜSÜNDEN => LIBRARY PACKAGE MANAGER => MANAGE "nuget packages for solutıon.." Kısmına tıklanır.

2-) DAHA SONRA ARAMA KISMINA "Install-Package PıcNetML" YAZILDIKTAN SONRA ‘PICNETML’ PAKETİ YÜKLENİR VE BU IKVM DOSYALARI PROJEYE REFERANS OLARAK EKLENMİŞ OLUR.

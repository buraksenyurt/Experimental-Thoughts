# Experimental-Thoughts

Bu deneysel repoda .Net tabanlı bir business uygulama geliştirmeye çalışıyorum. Daha çok **event-based** çalışan bir sistem kurmaya, basit bir domain alanı oluşturmaya, bağımlılıkları ideal bir şekilde yönetmek için düzenekler hazırlamaya, sıralı ve standardize işlevsellikleri işleten workflow yapılarını inşa etmeye odaklanıyorum.

Çalışmanın nispeten kolaylaştırılması için tek bir solution üzerinde çalışılmaktadır. İdeal senaryoda bazı blokların birer Nuget paket haline getirilerek kullanılması söz konusudur. Bu stratejiler ilerleyen zamanlarda dokümana eklenecektir.

## Notlar

- **Shared:** SDK için gerekli genel türleri içerir _(Result, Error türleri)_
- **Contracts:** Özellikle SDK tüketicileri için gerekli soyutlamaları içerir. _(Repository, Logger, Event Handlers vs)_
- **Core:** Genel event'leri, event işleticilerini veya çekirdek yürütücüleri içeren kütüphane. _(Events, Attributes, Dispatchers)_
- **Domain:** Burası SDK dışında kalması planlanan business odaklı domain nesnelerinin konuşlandırıldığı standart kütüphanedir.

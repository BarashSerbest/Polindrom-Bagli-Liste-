# Polindrom-Bagli-Liste-
5220505051 - Barash Serbest 

  Bu algoritma, verilen bağlı listenin palindrom olup olmadığını kontrol etmek için kullanılır. 
Bağlı liste, verilerin düğümler arasında hizalanarak depolandığı veri yapısıdır. Bu algoritma, 
bir bağlı listenin düğümlerini inceleyerek, listenin palindrom olup olmadığını belirler.

  Palindromik bir kelime veya cümle, tersten okunduğunda da aynı anlamı koruyan bir kelime veya cümledir. 
Benzer şekilde, bir palindromik bağlı liste de, düğümleri tersten okunduğunda da aynı sırayla okunabilir.
Örneğin, "1 -> 2 -> 3 -> 2 -> 1" bağlı listesi bir palindromik bağlı listedir, çünkü bu liste tersten 
okunduğunda da aynı sırayla okunur.

  Bu algoritma, verilen bağlı listenin palindromik olup olmadığını kontrol etmek için stack
(yığın) veri yapısını kullanır. Stack veri yapısı, son giren ilk çıkar (LIFO) prensibiyle 
çalışır. Bu algoritma, stack veri yapısını kullanarak, önce bağlı listenin ortasına kadar 
ilerleyip düğümleri stack içerisine ekler, ardından kalan düğümleri yığıttan çıkararak, palindromik 
olup olmadıklarını kontrol eder.

Algoritmanın çalışma şekli şöyledir:

1) Başlangıçta, verilen bağlı listenin başlangıç düğümüne erişilir.
2) Stack veri yapısı oluşturulur.
3) Yavaş (slow) ve hızlı (fast) iki işaretçi düğümü başlangıç düğümüne atanır.
4) Hızlı işaretçi düğümü, iki adım önde olduğu için, hızlı düğümü null veya son düğüme 
  ulaşıncaya kadar yavaş düğüm ilerler. Her adımda yavaş düğüm stack içerisine eklenir.
5) Eğer bağlı listenin uzunluğu tek sayıysa, hızlı işaretçi düğümü null olur ve yavaş düğüm bir 
  sonraki düğüme ilerletilir.
6) Stack veri yapısından düğümler çıkarılarak, yavaş düğümdeki değerlerle karşılaştırılır.
7) Düğümlerin değerleri eşit olmazsa, bağlı liste palindromik değildir ve false döndürülür. Aksi takdirde, 
  liste palindromik olarak kabul edilir ve true döndürülür.
  
  Bu algoritma, özellikle bağlı liste işlemlerinde kullanılır. Bağlı listeler, birçok algoritmada 
kullanılan veri yapılarıdır. Örneğin, veri tabanlarında, metin işlemler gibi birçok alanda kullanılabilirler. 

TetrisGame
==========

## Семинарска : Визуелно програмирање
### Изработиле:
* Виктор Кајтазов 111106 
* Костадин Поп-Кочев 111170

___

### Вовед

  Играта претставува имплементација на познатата игра "Тетрис". Основните правила на играта се поместување на активната коцка и нејзино подредување со цел да се формира пополнета редица со коцки кои ќе бидат отстранети од играта. Со отстранување на секој ред добиваме поени и целта ни е да добиеме што повеќе поени за да се квалификуваме помеѓу првите 10мина со најдобри поени. Со секои успешно уништени 10 реда коцки ни се зголемува нивото на тежина на играта така што се забрзува паѓањето на активната коцка. Играта завршува тогаш кога нема да има простор за појавување на нова коцка на екранот затоа што целата околина ќе биде зафатена од други форми на коцки.

### Опис на решението

Во имплементација на решението не се користени некои надворешни библиотеки. Решението е претставено во повеќе класи.
Класи за исцртување на тетрис формите и нивните ротации.

Класа TetrisForm: Од којашто наследуваат сите тетрис форми. Се чува листа од Square , боја на коцките итн..

метод pickColor() се избира рандом боја за тетрис формата
метод draw()  за исцртување на коцките од којашто е составена тетрис формата
методи за поместување на лево, десно и долу, како и методи за проверка дали тетрис формата може да се придвижи во дадената насока
метод rotate() виртуелен каде што секој специфична тетрис форма си го имплементира
метод deleteSquares() метод за бришење на коцки од тетрис формата кои се нашле во исполнетиот ред

Останатите класи си имаат своја имплементација на сите ротации коишто можат да ги направат

Во класата Game содржи листа од тетрис форми , за секоја состојба во којашто може да се најде играта ( Active, Pause, PreGame, GameOver) креирано е посебен GameState

Креирани се 3 различни форми: MainForm  каде што се игра играта, Best Players каде што се прикажани најдобрите резултати , и форма за внес на името на играчот откако ќе ја заврши играта

Креирано е посебна класа за звуците коишто се повикуваат во играта при LevelUp , исполнет ред, и при допир на формата до дното.

Овозможено е зачувување на најдобрите резултати со помош на серијализација.

### Упатсво за играње: 

Играта се игра со помош на стрелките на тастатурата

Стрелка надолу: се придвижува формата надолу
Стрелка нагоре: се ротира формата
Стрелка налево:се придвижува формата налево
Стрелка надесно:се придвижува формата надесно

Копче 'P': се паузира играта

### Слики од играта

Главната форма на играта

<a href="http://imgur.com/tVunNhK"><img src="http://i.imgur.com/tVunNhK.png?1" title="Hosted by imgur.com" /></a>

Форма за приказ на најдобри резултати

  <a href="http://imgur.com/ORlP4sd"><img src="http://i.imgur.com/ORlP4sd.png" title="Hosted by imgur.com" /></a>
  
  <a href="http://imgur.com/h8FYi8u"><img src="http://i.imgur.com/h8FYi8u.png" title="Hosted by imgur.com" /></a>
  <a href="http://imgur.com/YOW3q0u"><img src="http://i.imgur.com/YOW3q0u.png" title="Hosted by imgur.com" /></a>



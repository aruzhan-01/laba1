<html>

<head>
    <h1>Вариант задания: Объявление целочисленной константы с инициализацией на языке Java</h1>
    
    </head>

    <body>
<p>Примеры верных строк:</p>
<p> final int LIMIT =5; </p>
<p></p>
<p></p>
<img src = "автомат.png" style="width: 700px">
<p>Разработанная грамматика:</p>
<p>1) DEF -> final FINAL</p>
<p>2) FINAL -> int INT</p>
<p>3) INT -> letter ID</p>
<p>4) ID -> letter ID | "=" ASSIGNTMENT</p>
<p>5) ASSIGNTMENT -> ['+' | '-'] SIGN</p>
<p>6) SIGN -> digit NUMBER</p>
<p>7) NUMBER -> digit NUMBER | ";"</p>
<p>Классификация грамматики</p>
<p> Автоматная</p>
<p>Граф конечного автомата</p>
<img src = "автомат.png" style="width: 700px">
<p>тестовые примеры</p>
<img src = "1.png" style="width: 700px">
<img src = "2.png" style="width: 700px">
    </body>

</html>
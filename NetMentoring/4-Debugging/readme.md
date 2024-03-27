Открытые вопросы:
- в коде есть проверка на ArgumentNullException . Где посмотерть все исключения ? Тут есть всё по алфавиту но толку мало https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception?view=net-8.0
- Есть ли разница в С# для передачи null и пустого массива []. Тест на пустой порходит из под копота. а тест на null нужно было сделать


Разобрался:
- Какая разница в throw new ArgumentNullException() и throw new ArgumentNullException(nameof(numbers)); 
throw new ArgumentNullException(nameof(numbers)); выкидывает дополнительно (Parameter 'numbers') 

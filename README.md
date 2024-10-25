# Инструкция по настройке и конфигурированию приложения
## Общая информация
Было разработано приложение WinForms для службы доставки, которое фильтрует заказы в зависимости от количества обращений в конкретном районе города и времени обращения с и по. В качестве исходных данных используется файл с данными. Было реализовано логирование основных операций, а также валидация входных данных. Результат фильтрации заказов для доставки записывается в результирующий файл. Также было написано несколько тестов для проверки корректности работы приложения.

## Параметры запуска приложения
1) **Район города**: можно выбрать один вариант из предложенных в раскрывающемся списке(Center, North, West). <br/>Для того чтобы изменить доступные варианты, необходимо изменить enum AreaOfTheCity в файле MainForm.cs. <br/>Также реализован учет регистра записи.
2) **Время первой доставки**: в соотвествующем элементе формы необходимо выбрать время первой доставки в формате "yyyy-MM-dd HH:mm:ss". <br/>Также была реализована возможность установки периода поиска заказов от времени первой доставки в минутах. По умолчанию значение периода равно 30, т.к. по условию задания было сказано, что необходимо производить фильтрацию заказов на ближайшие полчаса после времени первого заказа.
3) **Путь к файлу с логами**: необходимо указать путь к файлу в который будут записываться все логи. По умолчанию указан файл находящийся в папке где находится исполняемый файл(.exe).
4) **Путь к результирующему файлу**: необходимо указать путь к файлу в который будет записан результат фильтрации приложения. По умолчанию указан файл находящийся в папке где находится исполняемый файл(.exe).
5) **Путь к файлу с входными данными**: необходимо указать путь к файлу в котором будут записаны входные данные соответсвующего формата(см. раздел "Структура файла входных данных"). По умолчанию указан файл находящийся в папке где находится исполняемый файл(.exe).

## Структура файла входных данных
Для корректной работы приложения файл входных данных должен иметь следующую структуру записи данных: 
<br/>"{идентификатор(числовой)};{вес};{район заказа(Center, North, West)};{время доставки груза(в формате: yyyy-MM-dd HH:mm:ss)}"
<br/>Пример: 1;5,0;Center;2024-10-23 10:00:00

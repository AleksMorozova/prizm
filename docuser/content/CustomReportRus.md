# Подготовка к созданию настраиваемых отчётов

## Настройки источников данных ODBC

* Открыть Панель управления - Система и безопасность - Администрирование - Источники данных ODBC

![_ConfiguringODBCDataSource.png](./images/_ConfiguringODBCDataSource.png "")

Запустить источники данных ODBC(32-bit) или источники данных ODBC (64-bit), в зависимости от версии установленного Microsoft Office.
Если установлен MS Office 32-bit необходимо запустить источник данных ODBC(32-bit)
Если установлен MS Office 64-bit необходимо запустить источник данных ODBC(64-bit)

*Примечание 1: Windows 7 отображает только 64-bit источник данных ODBC. Поэтому если установлен MS Office 32-bit, необходимо запустить следующую команду %windir%\SysWOW64\odbcad32.exe для настраивания 32-bit источника данных:*


![_ConfiguringForWindows732bit.png](./images/_ConfiguringForWindows732bit.png "")

* Переключиться на вкладку **Системный DSN** и нажмите кнопку **Добавить...**

![_SystemDSN.png](./images/_SystemDSN.png "")

* Выбрать **ODBC Driver 11 for SQL Server** и нажмите **Готово**
![_CreateNewDataSource.png](./images/_CreateNewDataSource.png "")

*Примечание 1: Если у вас уже есть установленный ODBC драйвер, он может быть назван "SQL Server Native Client 11.0"*

![_CreateNewDataSourceForPreinstalledDriver.png](./images/_CreateNewDataSourceForPreinstalledDriver.png "")

*Примечание 2: Не используйте драйвер с названием "SQL Server". Только "SQL Server Native Client 11.0" или “ODBC Driver 11 for SQL Server” могут использоваться для успешного соединения.*

* Заполнить имя источника данных ODBC, описание и SQL сервер:

![_CreateNewDataSourceStep2.png](./images/_CreateNewDataSourceStep2.png "")

*Важно: название SQL сервера должно быть (localdb)\v11.0, а имя и описание могут быть любыми строками.*


* Убедиться, что выбрана опция **With Integrated Windows authenctication** и нажмите далее:

![_CreateNewDataSourceStep3.png](./images/_CreateNewDataSourceStep3.png "")

* Выбрать **Change the default database to** и из выпадающего списка укажите название соответствующей базы данных.

![_CreateNewDataSourceStep4.png](./images/_CreateNewDataSourceStep4.png "")


Название базы данных соответствует названию проекта. Название проекта указывается во время установки программы. 

*Примечание 1: Если SQL сервер не был запущен, он запустится автоматически при попытке развернуть список. Этот процесс может занять некоторое время, и пользователь может получить сообщение об ошибке соединения. Это нормальное поведение, нужно подождать и попробовать ещё. Когда сервер SQL будет запущен, вы увидите список всех баз данных на локальном сервере*

* Проверить следующие этапы по скриншоту и нажмиет **Готово**

![_CreateNewDataSourceStep5.png](./images/_CreateNewDataSourceStep5.png "")

* Нажать **Test Data Source…** для проверки, что процесс созданния источника данных прошел успешно и нажать **ОК** 

![_TestDataSource.png](./images/_TestDataSource.png "")

* Убедиться, что только что созданный источник данных появился в списке источников данных ODBC:

![_VerifyNewlyCreatedDataSource.png](./images/_VerifyNewlyCreatedDataSource.png "")

##	Настройка MS Access

*Примечание: Язык программ , не поддерживающих Юникод, должен быть такой же как язык интерфейса Access.*

*Set up language for Non-Unicode program:*
*Панель управления – Часы, Язык, и Регион – Региональные стандарты  – Дополнительно – язык программ, не поддерживающих Юникод*

![_LanguageForNonUnicodeProgram.png](./images/_LanguageForNonUnicodeProgram.png "")


* Запустить MS Access и создать новую базу данных. В примере используется MS Access 2013

* Открыть **Внешние данные** и выбрать **База данных ODBC** :

![_ConfigAccessStep1.png](./images/_ConfigAccessStep1.png "")

* Выбрать опцию **Создать связанную таблицу для связи с источником данных**

![_ConfigAccessStep2.png](./images/_ConfigAccessStep2.png "")

* Откроется новый диалог **Выбор источника данных**. Переключиться на вкладку **Источник данных компьютера** , и найти созданый ранее источник данных:

![_ConfigAccessSelectDataSource.png](./images/_ConfigAccessSelectDataSource.png "")

* Выбрать таблицы которые надо отобржать в отчете и нажмите **ОК**

![_ConfigAccessSelectTables.png](./images/_ConfigAccessSelectTables.png "")

* Выбранные таблицы отобразятся в общем списке таблиц Microsoft Access (в примере была добавлена таблица Сварщики)

![_ConfigAccessFinalResult.png](./images/_ConfigAccessFinalResult.png "")
 

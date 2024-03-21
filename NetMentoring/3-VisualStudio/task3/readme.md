Установка:  
dotnet new maui
dotnet build -t:InstallAndroidDependencies -f:net8.0-android -p:AndroidSdkDirectory="C:/bin/Android/Sdk" -p:JavaSdkDirectory="C:\Program Files\Microsoft\jdk-17.0.10.7-hotspot" -p:AcceptAndroidSDKLicenses=True

Запуск: (пока не то что бы рабочий)  
dotnet build -t:Run -f net8.0-windows10.0.19041.0
dotnet build -t:Run -f net7.0-windows10.0.19041.0

Запуск из VS работает, скрин приложен.  
Открытые вопросы: 
1. Почему открываестя только в system developer mode?
1. во время запуска идёт деплоймент, куда?

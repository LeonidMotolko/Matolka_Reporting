# TestProject с Allure и xUnit

## Установка зависимостей

```sh
dotnet restore
```

## Запуск тестов с генерацией отчёта

```sh
dotnet test --logger:"console;verbosity=detailed" --results-directory "allure-results"
```

## Установка Allure Commandline

Скачайте и установите Allure CLI:  
[https://docs.qameta.io/allure/#_installing_a_commandline](https://docs.qameta.io/allure/#_installing_a_commandline)

## Генерация и просмотр отчёта

```sh
allure generate allure-results --clean -o allure-report
allure open allure-report
```

## Описание тестов

- **PassingTest** — всегда проходит.
- **FailingTest** — всегда проваливается.
- **SkippedTest** — всегда пропускается.

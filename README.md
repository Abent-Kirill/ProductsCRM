# Product Catalog API

Этот проект представляет собой простой RESTful веб-сервис для управления товарами и категориями товаров. Проект реализован на C# с использованием ASP.NET Core и Entity Framework Core. Для хранения данных используется InMemory-база данных.

## Требования

Для запуска проекта убедитесь, что на вашем компьютере установлены следующие компоненты:

- **.NET SDK** версии 8.0 или выше. Скачать можно с официального сайта [dotnet.microsoft.com](https://dotnet.microsoft.com/download).
  
  Чтобы проверить установленную версию .NET SDK, выполните в командной строке:
  ```bash
  dotnet --version
  ```
  # Установка и запуск
  
    Клонируйте репозиторий или загрузите исходный код.

    ```bash
    git clone https://github.com/your-repository/ProductCatalogAPI.git
    cd ProductCatalogAPI
    ```
Установите необходимые пакеты.

Перейдите в каталог проекта и выполните команду для установки всех зависимостей:

```bash

dotnet restore
```

Запустите приложение.

Используйте команду для запуска проекта в режиме разработки:

```bash

dotnet run
```
Приложение запустится на https://localhost:5001 по умолчанию.

## Использование API.

После запуска API будет доступно по следующим маршрутам:

    Получить все категории: GET /api/ProductCategories

    Получить категорию по ID: GET /api/ProductCategories/{id}

    Создать новую категорию: POST /api/ProductCategories

    Обновить категорию: PUT /api/ProductCategories/{id}

    Удалить категорию: DELETE /api/ProductCategories/{id}

    Получить все товары: GET /api/Products

    Получить товар по ID: GET /api/Products/{id}

    Создать новый товар: POST /api/Products

    Обновить товар: PUT /api/Products/{id}

    Удалить товар: DELETE /api/Products/{id}

Для упрощения реализации в проекте используется InMemory база данных. Вы можете заменить её на реальную базу данных, такую как SQLite или PostgreSQL, обновив настройки в файле Program.cs и добавив соответствующий провайдер базы данных.

# Unity Serialization Surrogates

<div>
    <strong><a href="README.md">English</a> | <a href="README.RU.md">Русский</a></strong>
</div>

<details>
<summary>Содержание</summary>

- [Введение](#введение)
- [Особенности](#особенности)
- [Установка](#установка)
- [Сотрудничество](#сотрудничество)
- [Поддержка](#поддержка)
- [Лицензия](#лицензия)

</details>

## Введение

Содержит суррогаты сериализации для структур **Unity**.

## 🦾 Особенности

Предоставляемые суррогаты обеспечивают сериализацию и десериализацию следующих типов:

- Color
- Quaternion
- Vector2
- Vector2Int
- Vector3
- Vector3Int
- Vector4

## 📥 Установка

Скачайте любую версию из [релизов](https://github.com/Depression-aggression/Serialization.Unity.Surrogates/releases).

#### Установка через URL git:

Также вы можете добавить этот пакет, открыв **PackageManager**,
перейдя к опции `Добавить пакет из URL git` и введите:

`https://github.com/Depression-aggression/Serialization.Unity.Surrogates.git`

## 🔰 Использование

Сериализация:

```csharp
using (var memoryStream = new MemoryStream())
{
    // Настройте суррогаты сериализации структур Unity.
    var surrogateSelector = new SurrogateSelector();
    surrogateSelector.AddAllUnitySurrogates();
    var binaryFormatter = new BinaryFormatter { SurrogateSelector = surrogateSelector };

    // Сериализуйте и поместите в пакет.
    binaryFormatter.Serialize(memoryStream, data);
    memoryStream.Flush();
    memoryStream.Seek(0, SeekOrigin.Begin);
    var bytes = memoryStream.ToArray();
}

Десериализация:

```csharp
using (var memoryStream = new MemoryStream(bytes))
{
    // Настройте суррогаты сериализации для структур Unity.
    var surrogateSelector = new SurrogateSelector();
    surrogateSelector.AddAllUnitySurrogates();
    var binaryFormatter = new BinaryFormatter { SurrogateSelector = surrogateSelector };

    // Десериализуйте.
    var data = binaryFormatter.Deserialize(memoryStream);
}
```

## 🤝 Сотрудничество

Я приветствую запросы на добавление новых функций и сообщения об ошибках
в разделе [issues](https://github.com/Depression-aggression/Serialization.Unity.Surrogates/issues) этого репозитория,
а также принимаю [pull requests](https://github.com/Depression-aggression/Serialization.Unity.Surrogates/pulls).

## 🫂 Поддержка

Я независимый разработчик,
и большая часть разработки этого проекта выполняется в моём свободном времени.
Если вас интересует сотрудничество или вы хотите нанять меня для выполнения проекта,
пожалуйста, ознакомьтесь с [моим портфолио](https://github.com/Depression-aggression) и [свяжитесь со мной](mailto:g0dzZz1lla@yandex.ru)!

## 🪪 Лицензия

Этот проект под лицензией **[Apache-2.0](https://github.com/Depression-aggression/SerializedReference.Dropdown/blob/main/LICENSE)**.

Авторские права (c) 2023 Николай Мельников
[g0dzZz1lla@yandex.ru](mailto:g0dzZz1lla@yandex.ru)
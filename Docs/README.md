# Unity Serialization Surrogates

<div>
    <strong><a href="README.md">English</a> | <a href="README.RU.md">Русский</a></strong>
</div>

<details>
<summary>Table of Contents</summary>

- [Introduction](#introduction)
- [Features](#-features)
- [Installation](#-installation)
- [Contribute](#-contribute)
- [Support](#-support)
- [License](#-license)

</details>

## Introduction

Contains serialization surrogates for **Unity**'s structs.

## 🦾 Features

The provided surrogates provide serialization and deserialization of the following types:

- Color
- Quaternion
- Vector2
- Vector2Int
- Vector3
- Vector3Int
- Vector4

## 📥 Installation

Download any version from [releases](https://github.com/Depression-aggression/Serialization.Unity.Surrogates/releases).

#### Install via git URL:

Alternatively, you can add this package by opening the **PackageManager**,
going to the `Add package from git URL` option, and entering:

`https://github.com/Depression-aggression/Serialization.Unity.Surrogates.git`

## 🔰 Usage

Serialization:

```csharp
using (var memoryStream = new MemoryStream())
{
    // Setup Unity's structs serialization surrogates.
    var surrogateSelector = new SurrogateSelector();
    surrogateSelector.AddAllUnitySurrogates();
    var binaryFormatter = new BinaryFormatter { SurrogateSelector = surrogateSelector };

    // Serialize and put to packet.
    binaryFormatter.Serialize(memoryStream, data);
    memoryStream.Flush();
    memoryStream.Seek(0, SeekOrigin.Begin);
    var bytes = memoryStream.ToArray();
}
```

Deserialization:

```csharp
using (var memoryStream = new MemoryStream(bytes))
{
    // Setup Unity's structs serialization surrogates.
    var surrogateSelector = new SurrogateSelector();
    surrogateSelector.AddAllUnitySurrogates();
    var binaryFormatter = new BinaryFormatter { SurrogateSelector = surrogateSelector };

    // Deserialize.
    var data = binaryFormatter.Deserialize(memoryStream);
}
```

## 🤝 Contribute

I welcome feature requests and bug reports
in [issues](https://github.com/Depression-aggression/Serialization.Unity.Surrogates/issues) section,
as well as [pull requests](https://github.com/Depression-aggression/Serialization.Unity.Surrogates/pulls).

## 🫂 Support

I am an independent developer,
and most of the development on this project is done in my spare time.
If you're interested in collaboration or hiring me for a project,
please check out [my portfolio](https://github.com/Depression-aggression) and [reach out](mailto:g0dzZz1lla@yandex.ru)!

## 🪪 License

This project is licensed under the **[Apache-2.0](https://github.com/Depression-aggression/SerializedReference.Dropdown/blob/main/LICENSE)** license.

Copyright (c) 2023 Nikolay Melnikov
[g0dzZz1lla@yandex.ru](mailto:g0dzZz1lla@yandex.ru)
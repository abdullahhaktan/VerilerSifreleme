# HashingDatas

[TR]

**Veri Güvenliği İçin Temel Hashing (Özetleme) Algoritmalarının Uygulamaları**

[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Security](https://img.shields.io/badge/Topic-Security%20%2F%20Cryptography-red.svg)](https://docs.microsoft.com/en-us/dotnet/standard/security/cryptography-model)
[![Algorithm](https://img.shields.io/badge/Concept-Hashing%20Algorithms-orange.svg)]()
[![GitHub repo size](https://img.shields.io/github/repo-size/abdullahhaktan/HashingDatas)](https://github.com/abdullahhaktan/HashingDatas)

---

## 💻 Proje Hakkında

Bu depo, **veri güvenliği ve kriptografi** alanında en temel ve yaygın kullanılan **Hashing (Özetleme)** algoritmalarının C# dilindeki pratik uygulamalarını içerir. Projenin amacı, kullanıcı şifreleri, dosya bütünlüğü kontrolü ve verilerin değiştirilmediğinin doğrulanması gibi senaryolarda hashing mekanizmasının nasıl çalıştığını göstermektir.

---

## ✨ Uygulanan Algoritmalar ve Konular

Bu proje, veri güvenliği temellerini anlamayı amaçlar ve aşağıdaki algoritmaların örnek uygulamalarını içerebilir:

### Temel Hashing Algoritmaları
* **MD5:** (Amaç: Eski sistemleri anlama/Dosya bütünlüğü kontrolü için) MD5 özetleme algoritmasının kullanımı. (⚠️ Not: Güvenlik açısından şifreler için önerilmez.)
* **SHA-1:** (Amaç: Eski uygulamalar) SHA-1 özetleme algoritmasının kullanımı. (⚠️ Not: Güvenlik açısından şifreler için önerilmez.)
* **SHA-2 (SHA-256, SHA-512):** Güncel projelerde sıklıkla kullanılan daha güçlü ve güvenli özetleme algoritmalarının uygulamaları.

### Güvenlik Uygulamaları
* **Tuzlama (Salting):** Aynı şifreye sahip kullanıcıların farklı hash değerleri üretmesi için şifrelerin yanına rastgele verilerin (salt) eklenmesi ve bunun hash'lenmesi.
* **Şifre Doğrulama:** Girilen düz metin şifrenin, veritabanında kayıtlı olan hash ve salt değeriyle karşılaştırılarak doğru olup olmadığının kontrol edilmesi.

### Kullanılan Teknolojiler
* **C#:** Programlama dili.
* **.NET Security/Cryptography Kütüphaneleri:** Algoritmaların implementasyonunda kullanılan yerleşik .NET sınıfları (örneğin: `System.Security.Cryptography`).

---

## 🚀 Nasıl Çalıştırılır?

Bu proje, genellikle C# dilinde yazılmış basit bir Konsol Uygulaması veya Kütüphane projesi şeklindedir.

1.  **Projeyi Klonlama:**
    ```bash
    git clone [https://github.com/abdullahhaktan/HashingDatas](https://github.com/abdullahhaktan/HashingDatas)
    cd HashingDatas
    ```

2.  **Projeyi Açma:**
    * **Visual Studio** ile `.sln` (Solution) dosyasını açın.

3.  **Çözümü Başlatma:**
    * Projeyi derleyin ve Konsol Uygulamasını **F5** tuşu ile çalıştırın. Uygulama, farklı metinlerin hash değerlerini hesaplayıp ekrana yazdıracaktır.

---
---

[EN]

# HashingDatas

**Implementations of Core Hashing Algorithms for Data Security**

---

## 💻 About the Project

This repository contains practical implementations of the most fundamental and commonly used **Hashing** algorithms in the **C#** language, relevant to the field of **data security and cryptography**. The project's goal is to demonstrate how the hashing mechanism works in scenarios like securing user passwords, checking file integrity, and verifying that data hasn't been tampered with.

---

## ✨ Implemented Algorithms and Concepts

This project aims to help understand the basics of data security and may include sample implementations of the following algorithms:

### Core Hashing Algorithms
* **MD5:** (Purpose: Understanding older systems/File integrity checking) Usage of the MD5 digest algorithm. (⚠️ Note: Not recommended for passwords due to security concerns.)
* **SHA-1:** (Purpose: Legacy applications) Usage of the SHA-1 digest algorithm. (⚠️ Note: Not recommended for passwords due to security concerns.)
* **SHA-2 (SHA-256, SHA-512):** Implementations of stronger and more secure digest algorithms frequently used in modern projects.

### Security Applications
* **Salting:** Adding random data (**salt**) next to passwords before hashing to ensure that users with the same password produce different hash values.
* **Password Verification:** Checking if a plain-text password entered by the user is correct by comparing its hash with the stored hash and salt value in the database.

### Technologies Used
* **C#:** The programming language.
* **.NET Security/Cryptography Libraries:** Built-in .NET classes used for algorithm implementation (e.g., `System.Security.Cryptography`).

---

## 🚀 How to Run

This project is typically structured as a simple Console Application or Library project written in C#.

1.  **Cloning the Project:**
    ```bash
    git clone [https://github.com/abdullahhaktan/HashingDatas](https://github.com/abdullahhaktan/HashingDatas)
    cd HashingDatas
    ```

2.  **Opening the Project:**
    * Open the **`.sln`** (Solution) file with **Visual Studio**.

3.  **Starting the Solution:**
    * Build the project and run the Console Application by pressing **F5**. The application will calculate and print the hash values of different texts to the console.

---
---

<img width="726" height="383" alt="Ekran görüntüsü 2025-10-04 110006" src="https://github.com/user-attachments/assets/c3faad87-be1b-413f-86b0-c3493c9994b4" />

---

<img width="725" height="383" alt="Ekran görüntüsü 2025-10-04 105918" src="https://github.com/user-attachments/assets/103a0cee-963a-4b28-abb4-bdb3dbd63b7a" />

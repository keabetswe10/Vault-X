# 🔐 Vault-X (Console App)

Vault-X is a beginner-friendly C# console application that allows users to create a secure password vault. Users can set their own master password, store a single set of credentials, and retrieve them later using a simple menu.

---

## 🧠 What It Does

- ✅ Lets users create a **master password**
- 🔐 Requires the password to **authenticate**
- ✍️ Allows users to **add one set of credentials** (website, username, password)
- 👁️ Lets users **view stored credentials**
- 🚪 Option to **exit** the vault

---

## 📸 Sample Output

===Welcome To Vault-X====

Please enter your name:

Keabetswe

Create a master password: ********

Wellcome, Keabetswe! Your vault is now ready.
Remember your master password to access your saved data.

Re-enter your master password to continue:

Access granted!

Welcome to VAULT-X 🔐
Vault Menu :

Add new Credentials

View stored Credentials

Exit
Your choice:

---

## 🛠️ Tech Stack

- Language: **C#**
- Environment: **Console App**
- Framework: **.NET (any version that supports console apps)**

---

## 💻 How to Run

1. Open the project in **Visual Studio** or **Visual Studio Code**
2. Copy the full code into your `Program.cs` file
3. Click **Run** or use `dotnet run` in terminal
4. Follow the on-screen instructions

---

## ⚙️ Features Explained

- **Master Password Setup:**  
  User is asked to create and re-enter the master password to gain access.

- **Login Attempts:**  
  Only 3 chances to enter the correct master password.

- **Vault Menu:**  
  A simple menu lets users choose between adding, viewing, or exiting.

- **Credential Storage:**  
  App stores **one set of credentials** in memory (website, username, password).

---

## 🚧 Limitations

- Stores only **one credential set** at a time
- Data is stored **in memory only** (no file/database saving)
- Password is **visible when typed** (no masking or encryption yet)

---

## ✅ Future Improvements

- Add **multiple credentials support**
- Store credentials to a **local file or encrypted database**
- Mask passwords as they are typed
- Encrypt sensitive data
- Build a **GUI version** or convert it to a **mobile app**

---

## 📄 License

Open source and free to use under the **MIT License**.

---

## 👨‍💻 Developer

Made with ❤️ by **Keabetswe Malwa**  
Passionate about learning C# and building real-world apps!

---

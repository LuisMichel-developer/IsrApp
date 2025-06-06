# 📘 ISR Calculator Console App

A simple C# console application to calculate net salary based on ISR (Income Tax in Mexico). Just input your gross monthly salary, and the app will calculate your net salary.

---

## 📦 Technologies Used

- **Language**: C# (.NET 6 / 7 / 8)
- **IDE**: Visual Studio 2022+
- **Type of App**: Console
- **Platform**: Windows / Cross-platform

---

## 🎯 Main Features

- ✅ Calculates net salary **annually**, **monthly**, **weekly**, and **daily**
- ✅ Displays the **ISR percentage** applied based on your salary bracket

---

## 🧠 Project Logic

This project uses `if-else` conditionals to determine the ISR rate based on the user's **monthly income**.

The user only needs to input their salary, and the logic handles the calculations automatically.

```csharp
Console.Write("Ingrese el salario mensual: ");
salarioMensual = Convert.ToInt32(Console.ReadLine());
```

---

## 🏁 How to Run the Project

1. Clone this repository:

   ```bash
   git clone https://github.com/LuisMichel-developer/IsrApp.git
   ```

2. Open the `.sln` file in **Visual Studio**
3. Run the project with `Ctrl + F5`

---

## 🚀 Future Improvements

- [ ] Add more detailed tax breakdowns
- [ ] Improve UI (visual design for output)
- [ ] Optimize code with cleaner structure or functions

---

## 🧑‍💻 Author

- 👤 **Luis Michel**
- 🎓 Software Engineering student
- 📍 Colima, Mexico
- 🌐 [LinkedIn Profile](https://www.linkedin.com/in/luis-michel-dev/)

---

## 📃 License

This project is licensed under the **MIT License**.


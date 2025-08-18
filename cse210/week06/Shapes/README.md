# Shape Project

This project demonstrates **object-oriented programming (OOP)** principles in C#, focusing on **inheritance, polymorphism, and abstraction**.  
It models different geometric shapes, calculates their area, and outputs results in a structured way.

---

## Learning Objectives
- Understand and implement **abstract classes** in C#
- Apply **inheritance** to create specific shape classes from a base class
- Practice **polymorphism** by overriding methods
- Use constructors and encapsulation for clean code structure
- Work with collections (e.g., `List<T>`) to store and iterate over multiple shapes

---

## Concepts Practiced
- **Abstraction**: Defining a base `Shape` class with abstract methods
- **Inheritance**: Extending the `Shape` class into specific shapes like `Square`, `Rectangle`, and `Circle`
- **Polymorphism**: Overriding the `GetArea()` and `GetName()` methods in derived classes
- **Encapsulation**: Using properties and constructors for shape dimensions
- **Collections**: Managing multiple shape objects in a list and iterating over them

---

## Project Structure
- `Shape.cs` → Abstract base class defining the contract for shapes
- `Square.cs` → Derived class representing a square
- `Rectangle.cs` → Derived class representing a rectangle
- `Circle.cs` → Derived class representing a circle
- `Program.cs` → Main entry point that demonstrates creating and working with different shapes

---

## Example Output
```text
Hello World! This is the Shapes Project.
Color: Red, Area: 78.54
Color: Blue, Area: 24.00
Color: Green, Area: 9.00

# Exercise Tracking Project

This project demonstrates **object-oriented programming (OOP)** principles in C#.  
It simulates a fitness tracking system where different types of activities (Running, Cycling, Swimming) record distance, speed, and pace.  
Each activity can provide a detailed **summary report**.

---

## Learning Objectives
- Practice designing **abstract base classes** with shared functionality
- Implement **inheritance** to extend a common `Activity` base class
- Use **polymorphism** by overriding methods in derived classes
- Work with **properties** and **constructors** for encapsulating data
- Apply formulas for **distance, speed, and pace** calculations in different contexts

---

## Concepts Practiced
- **Abstraction**: The `Activity` class defines the shared interface for all activities  
- **Inheritance**: `Running`, `Cycling`, and `Swimming` extend the `Activity` class  
- **Polymorphism**: Each activity overrides `GetDistance()`, `GetSpeed()`, and `GetPace()` to fit its calculation rules  
- **Encapsulation**: Activity-specific data (distance, speed, laps) is kept private and accessed through methods  
- **Collections**: A `List<Activity>` stores multiple activity objects and allows iteration using polymorphism  

---

## Project Structure
- `Activity.cs` → Abstract base class with shared properties (`Date`, `Minutes`) and abstract methods
- `Running.cs` → Represents a running workout (tracks distance in miles)
- `Cycling.cs` → Represents a cycling workout (tracks speed in mph)
- `Swimming.cs` → Represents a swimming workout (tracks laps and converts to miles)
- `Program.cs` → Entry point, creates activities, and prints summaries

---

## Example Output
```text
Hello World! This is the ExerciseTracking Project.
03 Nov 2022 Running (30 min): Distance 3.0 miles, Speed 6.0 mph, Pace: 10.00 min per mile
04 Nov 2022 Cycling (45 min): Distance 9.0 miles, Speed 12.0 mph, Pace: 5.00 min per mile
05 Nov 2022 Swimming (25 min): Distance 0.6 miles, Speed 1.5 mph, Pace: 40.23 min per mile  

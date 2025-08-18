
---

## Classes & Functions

### `Assignment` (Base Class)
- **Fields:**
  - `_studentName` → Name of the student.
  - `_topic` → The topic of the assignment.
- **Constructor:**  
  - `Assignment(string name, string topic)` → Initializes student name and topic.
- **Methods:**
  - `GetSummary()` → Displays the student name and topic.

---

### `MathAssignment` (Derived Class)
- **Fields:**
  - `_textbookSection` → Section in the textbook.
  - `_problem` → Problem set from the textbook.
- **Constructor:**  
  - `MathAssignment(string name, string topic, string textbookSection, string problem)` → Initializes fields and inherits from `Assignment`.
- **Methods:**
  - `GetHomeworkList()` → Displays the textbook section and problems.

---

### `WritingAssignment` (Derived Class)
- **Fields:**
  - `_title` → Title of the writing assignment.
- **Constructor:**  
  - `WritingAssignment(string name, string topic, string title)` → Initializes fields and inherits from `Assignment`.
- **Methods:**
  - `GetWritingInformation()` → Displays the title and student name.

---

### `Program` (Entry Point)
- **Main Method:**  
  Demonstrates how each class works:
  - Creates an `Assignment` object.
  - Creates a `MathAssignment` object and displays its summary and homework list.
  - Creates a `WritingAssignment` object and displays its summary and writing information.

---

## How to Run
1. Open the project in **Visual Studio** or any C# IDE.
2. Build and run the program.
3. Example Output:



---

## Key Concepts
- **Encapsulation** → Using private/protected fields.
- **Inheritance** → `MathAssignment` and `WritingAssignment` inherit from `Assignment`.
- **Polymorphism** → Different assignment types extend behavior from the base class.

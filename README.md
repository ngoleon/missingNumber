## How This Project Adheres to SOLID Principles

- **Single Responsibility Principle**  
  Each class has a single, well-defined responsibility.
    - The `MissingNumberProgram` class handles execution and orchestration.
    - Each solution class (e.g., `SumFormula`, `SortCompare`) encapsulates a specific algorithm for finding the missing number.


- **Open/Closed Principle**  
  The application is open for extension but closed for modification.
    - New finding solutions can be added (e.g., `XorFinder`) without modifying existing code, thanks to the use of the `IMissingNumber` interface.


- **Liskov Substitution Principle**  
  All implementations of `IMissingNumber` can be substituted for one another without affecting the correctness of the program.
    - For example, switching from `SumFormula` to `SortCompare` doesn’t break the logic.


- **Interface Segregation Principle**  
  The interface `IMissingNumber` only defines what is necessary eg. a single method `FindMissingNumber()`.
    - This ensures all implementing classes are not forced to include unnecessary methods.


- **Dependency Inversion Principle**  
  High-level modules (like `MissingNumberProgram`) depend on abstractions (`IMissingNumber`) rather than concrete implementations.
    - This decouples the execution logic from the specific algorithm used.


This design allows for testability, extensibility, and modular growth without tightly coupling logic to the core program.

I have also added a couple of xUnit, unit tests for fun :D
# Studying Object Oriented Programming and SOLID

#Chapter-02 - SRP and Cohesion
- Calculate Salary Discount depending on job role. Three ways to solve it and switching between implementations.
- Solution-01 Based on book using EnumType and Interfaces
- Solution-02 Using Reflection
- Solution-03 Using Dictionaries

#Chapter-03 - Coupling and DI
- Examples for low coupling and how to abstract implementation behavior
- Solution-01 Based on book using Interfaces
- Solution-02 Using EventHandlers
- Solution-03 Using Actions

#Chapter-04 - Open Closed
- Example using open closed principle and Unit Test with MOQ 

#Chapter-05 - Encapsulation and propagation of changes
- Tell, Don't ask - If you need to ask with a IF statment what you should to do when a object has a value, probably probably you'll be hurting the encapsulation principle. The rule of implementation must be encapsulatated on a method of this object.
- "Demeter's Law" - If you have to chain methods, encapsulate this behavior in the class which really needs to use this behavior and expose just one method, doing it you'll have less code to modify if necessery a change in the future.

#Chapter-06 - Inheritance Vs Composition
"No code, I only wrote some considerations for the chapter."
- A son class should not be tighten pre condition or loosen the post condition. The pre condition are the inputs and the post condition are the outputs.
For example, if the main class knows how to work with 1 to 100, your son's pre condition could bigger than it, creating a new behavior as so the value will be treat inside the son class.
However, if the main class knows how to return 1 to 100, your child's the pos condition must be between these values, and not bigger. The reason is, if some class in the system already is using the abstraction of the main class, it's wont have a problem because it's already prepared to work with the max value.
- With composition it's easier to change the implementation while receiving it on constructor than just implementing the methods from a interface or just using the inherited methods.

#Chapter-07 - Thin Interfaces and ISP
- Examples for create cohesive interfaces and how to simplify parameters into methods.

#Chapter-08 - Consistency, small and big objects
- Builder and Factory to create valide objects
- Tiny Types, Immutable types

# References
 - Orientação a Objetos e SOLID para Ninjas
<img src="https://github.com/adlerpagliarini/ObjectOrientedProgramming/blob/master/oop-solid-book.png" />
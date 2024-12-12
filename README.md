# MessageBoard

A simple message board project which follows the [clean architecture](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html) desgin pattern. This project won't be the most accurate implementation and will have numerous errors and failure to adhere to best coding practices so feel free to give me some pointers. 

## General architectural approach

The strengths of clean architecture primarily revolves around seperation of concerns and maintaining independence between layers. You can sort of visualize an onion and at the heart of it is the domain layer. What makes the architecture work is the **dependency rule**, essentially the inner layers will **not** depend on the outermost layers but the outer layers will depend on the inner layers,  inner layers will define interfaces and outer layers will implement those interfaces. 
- Domain Layer
   - Core entities and data models
- Application Layer
   - Implementing use cases.
- Infrastructure Layer
  - External concerns (databases, api controllers)
- Presentation Layer
  - What the user sees and interacts with (Razor pages)

So persistance is achived by a simple SQL database powered by Entity Framework, for this I will be following the [repository pattern](https://dotnettutorials.net/lesson/repository-design-pattern-csharp/) to minimize coupling and abstract away database interactions from the buisness layer. 


## Use Cases
+ Users will be able to make posts
+ Users will be able to view all posts made by other users.

I have only outlined two primary use cases for now to keep things simple but I plan on adding more as the scope of the project grows.

## General todos
- [x] Initialize the project directories with respect to the clean architecture design pattern.
- [x] Define the entities/domain/models.
- [x] Define the business logic/interfaces
- [x] Implement the buisness logic/interfaces
- [x] Define the repository class.
- [x] Set up dependency injection
- [ ] Implement data validation and error handling
- [ ] Create unit tests for business logic
- [ ] Implement logging
- [ ] Figure out prerendering

# RestApiDemo-WebApi
A .NET console application, written in C#.

### Task

Create an Asp.NET Rest Api application that would allow you to add fruits, vegetables, cookware (knives, forks, etc.).
Requirements:
   1. Fruits, Cookware, Vegetables are different types of objects with separate controllers.
   2. Each object must have at least an Id and a Name.
   3. Possible actions: add vegetable, delete, get all, get by id, change name.
   4. Should be tested help of the Postman.
   5. The types of Get, Post, Put, Delete Http methods must be used.

Extra:
1. Implement 'Generic Controller', 'Generic types' and change 3 controllers to one.
2. Add a Swagger Api library that describes this RestApi.

### Usage

Required dependency: **`Swashbuckle.AspNetCore`** NuGet package.

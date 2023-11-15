<h1 align="center">Install</h1>

This is a simple json C# ORM system for your projects. To work with it you must download the library and dotnet. Go to the project to which you want to add the library and enter <code>dotnet add reference [path to the library on your computer]</code> in the console and the library will be installed in your project.

<h2 align="center">Working</h2>

Next, you need to create a context class and inherit from <code>DbContext</code>. In <code>OnConfig</code> use <code>UseTxtDb</code>, and in <code>OnGenerate</code> create tables and use them in <code>UseTable<T></code>

![github](https://github.com/Niybell/Json-Database/assets/111873540/77dd54be-989f-4c7d-bb9d-3cca5c76c591)

After this, you can instantiate the context in any file and use asynchronous methods to interact with the database

![github](https://github.com/Niybell/Json-Database/assets/111873540/7fbdac84-a7e7-4c62-b658-211d2fec4fa8)

Good luck)

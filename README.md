# Лабораторная работа: Система управления товарами в корзине

Проект представляет собой систему управления товарами в корзине с графическим интерфейсом (WForms) и консольным интерфейсом (Console).

## Структура проекта
Laba.sln
├── ModelLogic/                     
│   ├── LogicClass.cs          
│   ├── ProductClass.cs               
│   └── ModelLogic.csproj           
│     
├── Console/                          
│   ├── AddProduct.cs                
│   ├── CalculateTotalClass.cs        
│   ├── GetProduct.cs                 
│   ├── RemoveProduct.cs              
│   ├── ShowAllProductsClass.cs      
│   ├── ShowProductsByCategoryClass.cs# 
│   ├── UpdateProduct.cs              
│   ├── Program.cs                    
│   └── Console.csproj                
│       
└── WForms/                           
    ├── Add.cs                        
    ├── Del.cs                       
    ├── Find.cs                 
    ├── MainForm.cs             
    ├── Update.cs                   
    ├── AllCategories.cs         
    ├── ProductDisplayer.cs         
    ├── Program.cs                   
    └── WForms.csproj       


## Методы класса Logic
**AddInBasket()** - Добавляет товар  
**RemoveProduct()** - Удаляет товар  
**GetProduct()** - Ищет товар  
**UpdateProduct()** - Обновляет товар  
**GetTotalPrice()** - Считает сумму  
**GetProductsByCategory()** - Ищет товары по категории  
**GetAllProducts()** - Возвращает все товары

## Функциональность
### Консольное приложение (Console)
1. Добавить товар(Создание сущности через Logic.AddInBasket)
2. Удалить товар(удаление сущности черех Logic.RemoveProduct)
3. Найти товар по имени(чтение сущности черех Logic.GetProduct)
4. Обновить товар(Изменение сущности черех Logic.UpdateProduct)
5. Посчитать общую сумму(Подсчет общей суммы вещей в корзине черех Logic.GetTotalPrice)
6. Показать товары по категории(Выводит все товары в категории через Logic.GetAllProducts)
7. Показать все товары(Выводит все товары через Logic.GetProductsByCategory)
0. Выход(Выход из консольного приложения)



### Windows Forms
1. Добавить товар(Создание сущности через Logic.AddInBasket)
2. Удалить товар(удаление сущности черех Logic.RemoveProduct)
3. Найти товар по имени(чтение сущности черех Logic.GetProduct)
4. Обновить товар(Изменение сущности черех Logic.UpdateProduct)
5. Посчитать общую сумму(Подсчет общей суммы вещей в корзине черех Logic.GetTotalPrice)
6. Показать товары по категории(Выводит все товары в категории Logic.GetProductsByCategory)

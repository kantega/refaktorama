# Refaktorama

Everything starts out great, and before you know it the code stops being easy to work with.
A lot of small changes in code and business logic can over time become quite messy.
The codebase becomes more complex, time-consuming and frustrating to work with.
This is why it is important to maintain the code and clean up after your self(and others) - to refactor.

## What you need
- Java 11 (or newer) or .Net 7
- Git
- Intellij

# Todays assignment

We would recommend working together in groups of 2 or 3 people.

In Todays assignment you will work together to refactor this truly horrific codebase of a Pub.
When refactoring you want to make the code easier to understand, and easier to expand with new functionality.
The most important element of refactoring is to not change the business logic. 
Luckily there is a testsuite for the existing functionality, use it while refactoring to ensure business logic. 
Add test as you add new functionality.

To make the assignment a bit more like real life we have a business owner Tina who holds the money.
She will give you some features and some constraints. 
Each group gets one feature and one restraint, if you have more time you can of course implement more features.

## Features
<details>
<summary>
Possible features
</summary>

### 1. Adjustable menu
Tina is creating a whole new menu. 
Before launching the new menu she would like to experiment with adding and removing items to the menu to see how customers react.
She needs an easier way to add and remove items form the menu.

Acceptance criteria:
- add a vodka redbull to the menu
- remove grans cider from the menu
### 2. Offer food
To attract more people to the bar Tina decided to include food on the menu.

Acceptance criteria:


### 3. Add tips
The customers in the pub are happy with the service, but when paying with a credit card they are not able to leave tips.

Acceptance criteria:
- leave a 10% tips
- leave to tips

### 4. Flexible discount system
Tina wants to have a better system for discounts.

Acceptance criteria:
- 50% happy hour discount

### 5. Special orders
There has been customers that want to specialize their drinks at the bar, but the bartender was no way to register that in the till.
Tina has agreed that the price of the drink will always be the sum of the ingredients.

Acceptance criteria
- to order a double gin tonic
- to order a virgin gin tonic
- to order a shot of rum

### 6. Receipts
The Pub wants to offer customers receipts.

Acceptance criteria:
- name, price and number of the product
- all products listed
- total cost

</details>


## Restraints
<details>
<summary>
Possible restraints
</summary>

### 1. None
Redesign as you wish

### 2. Partial
Fixed interface.
The signature(parameters and return type) of the method computeCost cannot change.
It is in use by another system that will break if this is changed.

### 3. Severe:
Finish in 2 hours.
The pub opens in 2 hours, and the system needs to be working.

</details>

# Where to start
1. Open the project in IntelliJ or your editor of choice
2. Run all the tests, look through the code and tests.
3. What does the code do? Discuss and ensure everyone has the same understanding of what the code does.
4. What problems do you find? naming? comments? magical numbers? structural problems?
5. Fix the magical numbers
6. Improve the naming to reflect what it is
7. Remove unnecessary comments
8. create functions
9. add feature
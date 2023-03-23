# Refaktorama -- refactoring under constraints

Everything starts out great, but before you know it the code stops being easy to work with.
New requirements, changed requirements, misunderstandings, mistakes and a better understanding of the domain all lead 
to changes in the codebase.
The codebase becomes ever more complex, time-consuming and frustrating to work with.
This is why it is important to maintain the code and clean up after yourself (and others) - to refactor.


## What you need
- Java 11 (or newer) or .Net 7
- Git
- Intellij


# The mission

In today's workshop you will work together on a (truly horrific, but functioning) codebase which is used in Tina's pub. 
Tina opened the pub a while ago, and is looking to expand and make the whole business more serious as business is blooming.
She had some students help her write the code originally, but none of them are around anymore, and you have been hired to 
further develop the pub. 

In order to do so, we need to prepare the code for upcoming features. The code was written by some very inexperienced developers, 
so there are quite a few problems! Luckily there is a testsuite which completely covers the existing functionality! Use it while refactoring
to preserve the current business logic. Add tests if you find something missing.

We recommend working together in small groups of around 3 people. While there are new features on the way, your job 
isn't to actually implement them, but to get the code ready to implement them. Even though some details are missing, 
Tina has lined up some upcoming features and real life constraints. Each group gets one feature and one restraint. 

There are two implementations, one in Java and one in C#. They both have the same test suite and perform the exact same task. 
Pick the one you (and your team) feel most comfortable with. 


## Features
<details>
<summary>
Upcoming features
</summary>

### 1. Adjustable menu
Tina is getting a new beverage supplier and will be creating a whole new drinks menu. The only thing she knows already is 
that the code needs to accommodate not only a new menu, but frequently changing menus. Your job is to refactor to allow 
for this. 


### 2. Offer food
To attract more people to the bar Tina has decided to serve food. Refactor the code to accomodate this change. 


### 3. Add tips
The customers in the pub are happy with the service, and would like to tip the staff. Prepare the code so that 
it's easy to get going with tips. This will require an API change. 


### 4. Flexible discount system
Tina wants to have a better system for discounts, even though she doesn't have the list of new discounts just yet. 
Prepare the code for a more flexible discount system. 


### 5. Special orders
There have been customers that want to customize their drink orders, but the bartender was no way 
to register these orders. Tina has agreed that the price of the drink will always be the sum of the ingredients.
Prepare the code for special orders. This requires an API change.


### 6. Receipts
Customers sometimes want receipts for billing purposes, and Tina wants to have business events in the pub. 
Refactor so that receipts can be implemented. 

</details>


## Constraints
<details>
<summary>
Possible restraints
</summary>

### 1. None
Redesign as you wish, change or expand the API to suit your needs.  

### 2. Fixed API (partial)
The signature (parameters and return type) of the method computeCost cannot change.
It is in use by another system that will break if this is changed.

### 3. Finish in 2 hours (severe)
Finish completely in 2 hours, as the pub opens in 2 hours, and the system needs to be working! 

</details>

# Where to start
1. Open the project in IntelliJ or your editor of choice
2. Run all the tests, look through the code and tests.
3. What does the code do? Discuss and ensure everyone has the same understanding of what the code does.
4. What problems do you find? naming? comments? magical numbers? structural problems?

It's a good idea to make a list of the things you want to do, both small and large changes. There are many issues with this code. 

Don't know where to begin? Here are some tips that will get you started:
1. Fix magical numbers
2. Improve the naming to reflect the concepts that are represented in the code
3. Remove unnecessary comments
4. create functions for different tasks performed by the code

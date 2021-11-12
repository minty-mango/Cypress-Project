# Cypress-Project
This was an old school project for Introduction to Software Engineering.

## 1. Overview

After reviewing the Use Case analysis, following are the basic classes and actions that emerge out:

#### __Classes:__ (Building blocks of Cypress) 

| SI no. | Class           | Principle Responsibility            |
| ---    | ---             | ---                                 |
| 1      |Report           | Manages information to the Reports  |
| 2      |Security Manager | Manages user verification           |
| 3      |Notifications    | Manages the notifications           |
| 4      |GUI              | Manages the Graphic User Interface  |
| 5      |Database         | Manages all data operations         |
| 6      |LanguageManager  | Manages all the languages           |
| 7      |Register         | Manages registration                |
> __Note:__ _Other subsidiary classes may be added to the list in course of implementation for loading balance and modularity_

#### __Actions:__

| SI no. | Action                    |
| ---    | ---                       |
| 1      | Create/Edit/Delete Report |
| 2      | Create Password/Username  |
| 3      | Edit user information     |
| 4      | Login/Logout User         |
| 5      | Validate User             |
> __Note:__ _Other actions have minor play in modeling_

## 2. System Structure

Here we describe the final structure. It should, however, be kept in mind that obtaining the final structure is an iterative excercise - and initial structures is refined as the design moves forward. In particular, the dynamic modeling has an impact on the strucutre. 

### 2.1. Inheritance Structure

With the use case there seems to be no inheretance stucture that could be used becasue of the lack in commonality between classes. In some cases where there is an existance of inheritance it is seem as intuitive and thus ommited in this documentation.

## 3. System Behaviour 

### 3.1 Principle Actor: Create/Edit/Delete Reports


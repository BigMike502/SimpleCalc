# SimpleCalc
```
This Project is now my final project for SD 1 / Code Louisville.  

There is NOTHING special you need to have downloaded or ready on your computer.  If you run it through Visual Studio It should work without any problems.  This Project was built on Visual Studios 2019 with C# under .NET 5 Framework.  You should also beable to build it and should show up under bin/debug/net5.0/SimpleCalc.exe. 

This is just as the name says, it is a Simple Calculator.  It will only at this moment will do simple arithmatic.  (add, subtract, multiply, devide) It will only take two numbers at the moment.  

It will ask you for the the first number, and then the second number and ask how you would like to process the numbers. 1.Add, 2.Subtract, 3.Multiply, 4.devide.

It will then process the number and print out the solution.  

[Final Project outline](https://docs.google.com/document/d/1tY20mxteNcUFE3CjzzszfNaBJskcpmstoqgj5khVA5M/edit?usp=sharing)  
```
## Nuts and Bolts (How works)

The Program will ask you for your First Number and Second Number.  If you fail to enter in a proper value for ether it will tell you that what you typed was invalid and return you back to the start of the number you were on at that point. It will show you both numbers and move onto the next section of the program.

It will then as you what operator you want to use.  (1.Add, 2.Subtract, 3.Multiply, 4.devide.) If you do not enter in the correct 1-4 value it will ask you again.

It then asks you if you would like to use the calculator again, If you say yes it will start you over from the beginning. if you say no it will prompt you saying thanks for using the program and exit.


## The 3 Extra Features that I am using are:

### Master Loop : Line 17
I am looping the program is the user would like to keep using the program.

### Implement a regular expression : CheckExpressions.CS (I have them all isolated)
I am using regular expressions Only in the CheckExpressions.CS to limit how much I am repeating code in the program.  

#### IsInputANumber Method:
I have it Checking for Any size decimal string for the 2 numbers that the user may enter in.

#### CheckOperatorInput Method:
Is checking that only the numbers 1-4 are used and only 1 digit long.

#### CheckYesOrNo Method:
Is checking that only the 4 diffrent options for yes and no are able to use continue.

### Create an additional class which inherits one or more properties from its parent
I have CheckExpression as the parrent and I have InfoCheck and Equations as its child to pull the Check Expression info.

## I have a Test Project I was using for Testing the CheckExpressions to see that I had everything correct.
This was every helpful in me checking the diffrent options for the CheckExpressions.CS Methods to see that I had all the bugs worked out for all the options. 

